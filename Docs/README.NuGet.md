##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="NuGet"/>[**NuGet**](https://www.nuget.org/)

For .NET (including .NET Core), the Microsoft-supported mechanism for sharing code is NuGet, which defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles.

Put simply, a NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number

The [NuGet.config](https://learn.microsoft.com/en-us/nuget/reference/nuget-config-file)

NuGet's behavior is driven by the accumulated settings in one or more [NuGet.Config (XML) files](https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior) that can exist at solution- (project if no solution is used), user-, and computer-wide levels.

Specifically, NuGet loads settings from the different config files in the following order:

1. The [NuGetDefaults.Config file](https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior#nuget-defaults-file), which contains settings related only to package sources.
1. The computer-level file.
1. The user-level file.
1. The file specified with -configFile.
1. Files found in every folder in the path from the drive root to the current folder (where nuget.exe is invoked or the folder containing the Visual Studio solution). For example, if a command is invoked in c:\A\B\C, NuGet looks for and loads config files in c:\, then c:\A, then c:\A\B, and finally c:\A\B\C.
