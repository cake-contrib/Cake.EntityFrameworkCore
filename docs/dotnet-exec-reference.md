# dotnet exec reference

dotnet exec allows executing of the ef.dll along with the efcore assembly

```cmd
Usage: dotnet [host-options] [path-to-application]

path-to-application:
  The path to an application .dll file to execute.

host-options:
  --additionalprobingpath <path>  Path containing probing policy and assemblies to probe for.
  --depsfile <path>               Path to <application>.deps.json file.
  --runtimeconfig <path>          Path to <application>.runtimeconfig.json file.
  --fx-version <version>          Version of the installed Shared Framework to use to run the application.
  --roll-forward <value>          Roll forward to framework version (LatestPatch, Minor, LatestMinor, Major, LatestMajor, Disable)
  --additional-deps <path>        Path to additional deps.json file.
  --list-runtimes                 Display the installed runtimes
  --list-sdks                     Display the installed SDKs
```