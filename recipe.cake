#load nuget:?package=Cake.Recipe&version=1.0.0

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Cake.EntityFrameworkCore",
    repositoryOwner: "louisfischer",
    repositoryName: "Cake.EntityFrameworkCore",
    appVeyorAccountName: "louisfischer",
    shouldRunDupFinder: false,
    shouldRunInspectCode: false,
    shouldRunCodecov: false,
    shouldDeployGraphDocumentation: false,
    shouldRunGitVersion: true,
    shouldRunDotNetCorePack: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    dupFinderExcludePattern: new string[] { BuildParameters.RootDirectoryPath + "/src/Cake.EntityFrameworkCore.Tests/**/*.cs" },
    testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* -[Shouldly]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

Build.RunDotNetCore();
