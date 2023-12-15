##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)

<a name="projectStructure"/>**Project Structure**
'''
/myproject
&nbsp;&nbsp;&nbsp;&nbsp;|-- src
&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|-- /module1
&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|-- /module2
&nbsp;&nbsp;&nbsp;&nbsp;|-- test
&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|-- /test1
&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|-- /test2
&nbsp;&nbsp;&nbsp;&nbsp;|-- .gitignore
&nbsp;&nbsp;&nbsp;&nbsp;|-- README.md
&nbsp;&nbsp;&nbsp;&nbsp;|-- LICENSE

'''

The structure of an csproj a C# project

1. MSBuild starts by reading the .csproj file.

2. It sees the Sdk attribute and loads the specified SDK. The SDK includes a set of MSBuild .targets and .props files, which define the build process for .NET Core projects.

For the Microsoft.NET.Sdk, the first file that gets imported is [Microsoft.NET.Sdk.props](https://github.com/dotnet/sdk/blob/main/src/Tasks/Microsoft.NET.Build.Tasks/targets/Microsoft.NET.Sdk.props). This file is located in the Sdk folder of your .NET installation directory.

