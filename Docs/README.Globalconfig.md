##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="globalconfig"/>[**.globalconfig**](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig)

The **.globalconfig** file is a special kind of AnalyzerConfig file that is used to configure code analyzers on a global level across multiple projects. 
Unlike EditorConfig files, global configuration files can't be used to configure editor style settings for IDEs, such as indent size or whether to trim trailing whitespace. 
Instead, they are designed purely for specifying project-level analyzer configuration options.
**.globalconfig** is a newer feature introduced in .NET 5.0 as part of the .NET analyzers. 
A **.globalconfig** file is similar to an [**.editorconfig**](#editorconfig) file, but it's used to configure analyzer diagnostics.
You can use a **.globalconfig** file to configure the severity of diagnostics, enable or disable specific diagnostics, and so on. The main advantage of .globalconfig files is that they can be used to enforce coding conventions across multiple projects or even across an entire solution, regardless of the directory structure. This makes them particularly useful in large code
