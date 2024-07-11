
import { constants } from 'fs';
import path from 'path';
import * as promises from 'fs/promises';

import { DefaultArtifactClient } from '@actions/artifact'

export default async function generateReportsEntrypoint({ core, exec }) {
  try {
    await generateReports({ core, exec });
  } catch (error) {
    core.error(error);
    core.setFailed(error);
  }
}

async function generateReports({ core, exec }) {
  core.startGroup('Get Configurations');
  const configs = await getConfigurations(core);
  core.endGroup();

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

  core.startGroup(`Run generate-all-reports for ${configs.configFilePath}`);
  await generateIssueReports(configs, execOptions);
  core.endGroup();

  core.startGroup('Upload Reports');
  const folderDate = await findLatestCacheDate(configs.reportDirectory);
  const filesGenerated = getCacheFilesPaths(configs, folderDate);
  if (configs.shouldUpdateCaches) {
    await uploadResultsToCache(filesGenerated);
  } else {
    await uploadResultsAsArtifact(filesGenerated);
  }
  core.endGroup();

  core.info('Report generation completed successfully!');

  async function uploadResultsAsArtifact(filesGenerated) {
    const artifact = new DefaultArtifactClient();
    await artifact.uploadArtifact('report', Object.values(filesGenerated), configs.reportDirectory, { retentionDays: 5 });
  }

  async function uploadResultsToCache(filesGenerated) {
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

  async function generateIssueReports(configs) {
    await exec.exec("dotnet", ["run",
      "--project", "gh-issue-tracker.csproj",
      "-c", "release",
      "--",
      "generate-all-reports", configs.configFilePath, configs.cacheFile],
      execOptions);
  }
}

async function getConfigurations(core) {
  let loadedConfig = {
    shouldUpdateCaches: core.getBooleanInput('shouldUpdateCaches', { required: true }),
    cacheFile: ''
  };

  // Try to find the specified config file
  try {
    const configFileName = core.getInput('configName', { required: true });
    var configFilePath = path.join('Configs', `${configFileName}.json`)
    loadedConfig.configFilePath = path.resolve(configFilePath);

    const configContents = await promises.readFile(loadedConfig.configFilePath, 'utf8');
    const config = JSON.parse(configContents);
    loadedConfig.reportDirectory = config.ReportConfig.ReportOutputPath;
    loadedConfig.reportFriendlyName = config.ReportConfig.ReportFriendlyName;
    loadedConfig.cacheFilesPrefix = config.ReportConfig.ReportFilePrefix;
    core.info(`Fully loaded config: "${loadedConfig.configFilePath}"`);
  } catch (error) {
    core.error("Unable to parse config file");
    throw error;
  }

  await promises.mkdir(loadedConfig.reportDirectory, { recursive: true })

  // Try to find the specified cache file or load the latest one.
  try {
    var cache_date = core.getInput('oldConfigDate', { required: false });

    if (!cache_date) {
      core.info("No cache date specified. Finding latest cache date.");
      cache_date = await findLatestCacheDate(loadedConfig.reportDirectory);
    }

    const cached_list = cache_date === ''
      ? ''
      : path.join(loadedConfig.reportDirectory, cache_date, `${loadedConfig.cacheFilesPrefix}-cache.json`);

    if (cached_list !== '') {
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

async function findLatestCacheDate(reportDirectory) {
  // Find the latest cache file by date descending
  var date_list = await promises.readdir(reportDirectory, { withFileTypes: true });
  date_list = date_list.filter(dirent => dirent.isDirectory()).sort((a, b) => (a.name > b.name ? -1 : -1));
  return date_list.length > 0 ? date_list[0].name : '';
}

function getCacheFilesPaths(config, folderDate) {
  const baseDir = path.resolve(config.reportDirectory);

  return {
    cacheFile: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-cache.json`),
    compReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-comp.md`),
    csvTotals: path.join(baseDir, `${config.cacheFilesPrefix}-totals.csv`),
    fullReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}-full.md`),
  }
}

import core from '@actions/core';
import exec from '@actions/exec';
const phonyContext = { ...core, info: console.info, error: console.error };
generateReportsEntrypoint({ core: phonyContext, exec });