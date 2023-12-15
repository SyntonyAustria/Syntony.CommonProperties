##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)

When MSBuild runs, **Microsoft.Common.props** searches your directory structure for the Directory.Build.props file. 
If it finds one, it imports the file and reads the properties defined within it. 
**Directory.Build.props** is a user-defined file that provides customizations to projects under a directory. **Directory.Build.props** is imported early in the sequence of imported files, which can be important if you need a set a property that is used by imports, especially those that are implicitly imported by using the Sdk attribute, such as when using the .NET SDK in most .NET project files.

The **Directory.Build.props** file is imported very early in the build process of an SDK-style project in .NET.
Specifically, it is imported *before* the project file itself is imported. This allows properties defined in **Directory.Build.props** to influence the behavior of the SDK and the project file.
The **Directory.Build.props** file is typically placed in the root directory of your source code repository. MSBuild will automatically import this file from the current directory, or any of its parent directories. This allows you to specify common properties for all projects in your repository in a single file.

Note that if there are multiple **Directory.Build.props** files in the directory hierarchy, all of them will be imported, with files in child directories imported before files in parent directories. This allows a **Directory.Build.props** file in a child directory to override properties specified in a **Directory.Build.props** file in a parent directory.
