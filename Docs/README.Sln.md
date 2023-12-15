##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)

<a name="sln"/>[**.sln**](https://learn.microsoft.com/en-us/visualstudio/extensibility/internals/solution-dot-sln-file?view=vs-2022)

In a Visual Studio solution file, paths are typically defined relative to the location of the solution file itself. This is done to ensure that the solution can be moved or shared across different environments without breaking the path references.

Unfortunately, Visual Studio solution files do not support absolute paths without a drive letter. The paths must be either relative to the solution file or absolute with a drive letter.
