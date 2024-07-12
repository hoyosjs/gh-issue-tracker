
import { constants } from 'fs';
import path from 'path';
import { tmpdir, EOL } from 'os';
import * as promises from 'fs/promises';
import { DefaultArtifactClient } from '@actions/artifact';

export default async function generateReportsEntrypoint({ core, exec, inputs }) {
  core.info('Starting report generation...');

  core.info(`Inputs: "${JSON.stringify(inputs)}"`);

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
    const configs = await getConfigurations({ core, inputs });
    core.endGroup();

    core.startGroup(`Run generate-all-reports for ${configs.configFilePath}`);
    await generateReports({ core, exec, execOptions, configs });
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

const WellKnownDirectories = Object.freeze({
  Configs: 'configs',
  Reports: 'reports'
});

const WellKnownSuffixes = Object.freeze({
  Cache: '-cache.json',
  Comparative: '-comp.md',
  Full: '-full.md',
  CsvTotals: '-totals.csv'
});

async function getConfigurations({ core, inputs }) {
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
    loadedConfig.configName = inputs.configName;
    const configFilePath = path.join(WellKnownDirectories.Configs, `${inputs.configName}.json`)
    loadedConfig.configFilePath = path.resolve(configFilePath);
    const configContents = await promises.readFile(loadedConfig.configFilePath, 'utf8');
    const config = JSON.parse(configContents);

    loadedConfig.reportDirectory = path.resolve(path.join(WellKnownDirectories.Reports, config.ReportConfig.ReportOutputPath));
    loadedConfig.relativeDirectoryName = config.ReportConfig.ReportOutputPath;
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

    if ('oldConfigDate' in inputs && inputs.oldConfigDate !== '') {
      cache_date = inputs.oldConfigDate;
    } else {
      core.info("No cache date specified. Finding latest cache date.");
      cache_date = await findLatestCacheDate(loadedConfig.reportDirectory);
    }

    if (cache_date === '') {
      core.info("No cache data found.");
      loadedConfig.cacheFile = '';
    } else {
      const cached_list = path.join(loadedConfig.reportDirectory, cache_date, `${loadedConfig.cacheFilesPrefix}${WellKnownSuffixes.Cache}`);
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
  let args = ["run",
    "--project", "gh-issue-tracker.csproj",
    "-c", "release",
    "--",
    "generate-all-reports",
    configs.configFilePath];

  if (configs.cacheFile !== '') {
    args.push(configs.cacheFile);
  }

  await exec.exec("dotnet", args, execOptions);
}

async function updateAndUploadReports({ core, exec, execOptions, configs }) {

  const latestReportDate = await findLatestCacheDate(configs.reportDirectory);
  const filesGenerated = getLatestGeneratedFiles(configs, latestReportDate);

  if (configs.shouldUpdateCaches) {
    core.info("Updating checked in caches and reports");
    await updateGlobalCacheFiles(configs, filesGenerated, latestReportDate);
    await uploadResultsToCache(exec, configs, filesGenerated);
  } else {
    core.info("Upload reports as artifacts.");
    await uploadResultsAsArtifact(configs, filesGenerated);
  }

  async function uploadResultsAsArtifact(configs, filesGenerated) {
    const artifact = new DefaultArtifactClient();
    await artifact.uploadArtifact('report', Object.values(filesGenerated), configs.reportDirectory, { retentionDays: 5 });
  }

  async function uploadResultsToCache(exec, configs, filesGenerated) {
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
      cacheFile: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}${WellKnownSuffixes.Cache}`),
      compReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}${WellKnownSuffixes.Comparative}`),
      csvTotals: path.join(baseDir, `${config.cacheFilesPrefix}${WellKnownSuffixes.CsvTotals}`),
      fullReport: path.join(baseDir, folderDate, `${config.cacheFilesPrefix}${WellKnownSuffixes.Full}`),
    }
  }

  async function updateGlobalCacheFiles(configs, filesGenerated, latestReportDate) {
    // Move the global report to the root of the report directory.
    const targetFullReport = path.resolve(path.join(configs.reportDirectory, `${configs.cacheFilesPrefix}${WellKnownSuffixes.Full}`));
    await promises.rename(filesGenerated.fullReport, targetFullReport);
    core.info(`Full report moved to ${targetFullReport}`);
    filesGenerated.fullReport = targetFullReport;

    const readme = path.resolve(path.join(WellKnownDirectories.Reports, 'README.md'));
    await updateReadmeTable(configs, readme);
    filesGenerated.GlobalReadme = readme;
  }

  async function updateReadmeTable(configs, readmePath) {
    const originalReadme = await promises.open(readmePath, 'r');

    const temp = await promises.mkdtemp(path.join(tmpdir(), 'readme-'));
    const tempReadmePath = path.join(temp, 'README.md');
    const tempReadme = await promises.open(tempReadmePath, 'wx', 0o600);

    const Markers = Object.freeze({
      Start: `[marker]: <> (Begin:${configs.configName})`,
      End: `[marker]: <> (End:${configs.configName})`
    });

    // Start section
    const newSection = `${Markers.Start}

## ${configs.reportFriendlyName}

- [${configs.reportFriendlyName} Full Report](./${configs.relativeDirectoryName}/${configs.cacheFilesPrefix}${WellKnownSuffixes.Full})
- [${configs.reportFriendlyName} Latest Comparative Report (${latestReportDate})](./${configs.relativeDirectoryName}/${latestReportDate}/${configs.cacheFilesPrefix}${WellKnownSuffixes.Comparative})
- [${configs.reportFriendlyName} CSV](./${configs.relativeDirectoryName}/${configs.cacheFilesPrefix}${WellKnownSuffixes.CsvTotals})

${Markers.End}
`;
    // End section

    const States = Object.freeze({
      NotSeen: 0,
      InSection: 1,
      SectionSeenAndClosed: 2
    });

    var state = States.NotSeen;
    for await (const line of originalReadme.readLines()) {
      if (line === Markers.Start) {
        if (state !== States.NotSeen) {
          throw new Error("Invalid README state");
        }
        state = States.InSection;
        continue;
      } else if (line === Markers.End) {
        await tempReadme.write(newSection);
        state = States.SectionSeenAndClosed;
        continue;
      } else if (state === States.InSection) {
        continue;
      }
      await tempReadme.write(line + EOL);
    }

    if (state === States.NotSeen) {
      await tempReadme.write(newSection);
    }

    originalReadme.close();
    tempReadme.close();
    await promises.copyFile(tempReadmePath, readmePath);

    filesGenerated.GlobalReadme = readmePath;
  }
}

async function findLatestCacheDate(reportDirectory) {
  // Find the latest cache file by date descending
  var date_list = await promises.readdir(reportDirectory, { withFileTypes: true });
  date_list = date_list.filter(dirent => dirent.isDirectory()).sort((a, b) => (a.name > b.name ? -1 : -1));
  return date_list.length > 0 ? date_list[0].name : '';
}

// Purely for test when  running locally.
// import core from '@actions/core';
// import exec from '@actions/exec';
// const phonyContext = { ...core, info: console.info, error: console.error };
// const inputs = {
//   configName: 'diagnostics',
//   shouldUpdateCaches: 'true',
//   oldConfigDate: ''
// };
// generateReportsEntrypoint({ core: phonyContext, exec, inputs });