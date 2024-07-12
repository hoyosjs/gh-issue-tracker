
import { constants } from 'fs';
import path from 'path';
import * as promises from 'fs/promises';
import { DefaultArtifactClient } from '@actions/artifact';

export default async function generateReportsEntrypoint({ inputs, core, exec }) {
  const execOptions = {
    listeners: {
      stdout: (data) => {
        core.info(data.toString());
      },
      stderr: (data) => {
        core.error(data.toString());
      }
    },
    failOnStdErr: true
  };

  try {
    core.startGroup('Get Configurations');
    const configs = await getConfigurations({core, inputs});
    core.endGroup();

    core.startGroup(`Run generate-all-reports for ${configs.configFilePath}`);
    await generateReports({ core, exec, execOptions, configs});
    core.endGroup();

    core.startGroup('Update caches and reports');
    await updateAndUploadReports({ core, exec, execOptions, configs });
    core.endGroup();

    core.info('Report generation completed successfully!');

  } catch (error) {
    core.error(error);
    core.setFailed(error);
  }
}

async function getConfigurations({core, inputs}) {
  let loadedConfig = {
    cacheFile: ''
  };

  // Nasty... using inputs instead of core.getInput. But this doesn't play well in workflow_call
  loadedConfig.shouldUpdateCaches = 'shouldUpdateCaches' in inputs && inputs.shouldUpdateCaches === 'true';

  // Try to find the specified config file
  if (!('configName' in inputs)) {
    throw new Error("No config file specified");
  }

  try {
    const configFilePath = path.join('Configs', `${inputs.configName}.json`)
    loadedConfig.configFilePath = path.resolve(configFilePath);
    const configContents = await promises.readFile(loadedConfig.configFilePath, 'utf8');
    const config = JSON.parse(configContents);

    loadedConfig.reportDirectory = config.ReportConfig.ReportOutputPath;
    loadedConfig.reportFriendlyName = config.ReportConfig.ReportFriendlyName;
    loadedConfig.cacheFilesPrefix = config.ReportConfig.ReportFilePrefix;

    core.info(`Fully loaded config: "${loadedConfig.configFilePath}"`);
  } catch (error) {
    core.error(`Unable to parse or find config file ${inputs.configName}`);
    throw error;
  }

  await promises.mkdir(loadedConfig.reportDirectory, { recursive: true })

  // Try to find the specified cache file or load the latest one.
  try {
    var cache_date = '';

    if ('oldConfigDate' in inputs) {
      cache_date = inputs.oldConfigDate;
    } else {
      core.info("No cache date specified. Finding latest cache date.");
      cache_date = await findLatestCacheDate(loadedConfig.reportDirectory);
    }

    if (cache_date === '') {
      core.info("No cache data found.");
      loadedConfig.cacheFile = '';
    } else {
      const cached_list = path.join(loadedConfig.reportDirectory, cache_date, `${loadedConfig.cacheFilesPrefix}-cache.json`);
      await promises.access(cached_list, constants.R_OK).catch(() => {
        throw new Error(`Cached result not found at ${cached_list}.`)
      });
      core.info(`Using cached result: "${cached_list}"`);
      loadedConfig.cacheFile = cached_list;
    }
  } catch (error) {
    core.error("Unable to find cache file");
    throw error;
  }

  return loadedConfig;
}

async function generateReports({ exec, execOptions, configs }) {
  await exec.exec("dotnet", ["run",
    "--project", "gh-issue-tracker.csproj",
    "-c", "release",
    "--",
    "generate-all-reports", configs.configFilePath, configs.cacheFile],
    execOptions);
}

async function updateAndUploadReports({ core, exec, execOptions, configs }) {

  const folderDate = await findLatestCacheDate(configs.reportDirectory);
  const filesGenerated = getLatestGeneratedFiles(configs, folderDate);

  if (configs.shouldUpdateCaches) {
    await uploadResultsToCache(exec, configs, filesGenerated);
  } else {
    await uploadResultsAsArtifact(configs, filesGenerated);
  }

  async function uploadResultsAsArtifact(configs, filesGenerated) {
    const artifact = new DefaultArtifactClient();
    await artifact.uploadArtifact('report', Object.values(filesGenerated), configs.reportDirectory, { retentionDays: 5 });
  }

  async function uploadResultsToCache(exec, configs, filesGenerated) {
    let targetFullReport = path.resolve(path.join(configs.reportDirectory, `${configs.cacheFilesPrefix}-full.md`));
    promises.rename(filesGenerated.fullReport, targetFullReport);
    core.info(`Full report moved to ${targetFullReport}`);
    filesGenerated.fullReport = targetFullReport;

    for (const file of Object.values(filesGenerated)) {
      core.info(`Adding file ${file}`);
      await exec.exec('git', ['add', file]);
    }

    await exec.exec('git', [
      "-c", 'user.name="Report Generator"',
      '-c', 'user.email="19413848+hoyosjs@users.noreply.github.com"',
      'commit',
      '-m', `Update reports for "${configs.ReportFriendlyName}" on ${new Date().toISOString()}`],
      execOptions);

    await exec.exec('git', ['push'], execOptions);
  }

  function getLatestGeneratedFiles(config, folderDate) {
    const baseDir = path.resolve(config.reportDirectory);

    return {
      cacheFile: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-cache.json`),
      compReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-comp.md`),
      csvTotals: path.join(baseDir, `${config.cacheFilesPrefix}-totals.csv`),
      fullReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-full.md`),
    }
  }
}

async function findLatestCacheDate(reportDirectory) {
  // Find the latest cache file by date descending
  var date_list = await promises.readdir(reportDirectory, { withFileTypes: true });
  date_list = date_list.filter(dirent => dirent.isDirectory()).sort((a, b) => (a.name > b.name ? -1 : -1));
  return date_list.length > 0 ? date_list[0].name : '';
}

// Purely for test when  running locally.
import core from '@actions/core';
import exec from '@actions/exec';

const phonyContext = { ...core, info: console.info, error: console.error };
generateReportsEntrypoint({ core: phonyContext, exec });