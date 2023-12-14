##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="globalconfig"/>[**.globalconfig**](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig)

The **.globalconfig** file is a special kind of AnalyzerConfig file that is used to configure code analyzers on a global level across multiple projects. 
Unlike EditorConfig files, global configuration files can't be used to configure editor style settings for IDEs, such as indent size or whether to trim trailing whitespace. 
Instead, they are designed purely for specifying project-level analyzer configuration options.
**.globalconfig** is a newer feature introduced in .NET 5.0 as part of the .NET analyzers. 
A **.globalconfig** file is similar to an [**.editorconfig**](README.Editorconfig.md) file, but it's used to configure analyzer diagnostics.
You can use a **.globalconfig** file to configure the severity of diagnostics, enable or disable specific diagnostics, and so on. The main advantage of **.globalconfig** files is that they can be used to enforce coding conventions across multiple projects or even across an entire solution, regardless of the directory structure. This makes them particularly useful in large code

The **.globalconfig** file is part of the EditorConfig system, but it's not a standard EditorConfig file. It's a special type of EditorConfig file that's used by the .NET Roslyn compiler to configure code style and analysis rules that apply across multiple projects.

The **.globalconfig** file is typically placed at the root of your repository, and it applies to all the projects in the repository. The settings in the **.globalconfig** file override the settings in the .editorconfig files in the individual projects.

When the .NET compiler runs, it looks for **.globalconfig** files in the following order:

1. Local **.globalconfig** file: The compiler first looks for a **.globalconfig** file in the same directory as the project file (.csproj, .vbproj, etc.).

2. Parent directories' **.globalconfig** files: If the local **.globalconfig** file does not exist, the compiler then looks for **.globalconfig** files in the parent directories of the project file, up to the root of the file system.

3. User profile's **.globalconfig** file: If none of the above **.globalconfig** files exist, the compiler then looks for a **.globalconfig** file in the user's profile directory. This file applies to all projects on the machine.

Please note that this is a general explanation and the exact behavior might vary depending on the version of the .NET compiler and the configuration of your projects.

Here's an example of a .globalconfig file:
```
# .globalconfig
# Top-most EditorConfig file
root = true
# Don't use var
[*.{cs,vb}]
dotnet_style_predefined_type_for_locals_parameters_members = true:error
dotnet_style_predefined_type_for_member_access = true:error
# Use expression-bodied members for properties and methods
[*.{cs,vb}]
dotnet_style_prefer_expression_bodied_properties = true:error
dotnet_style_prefer_expression_bodied_methods = true:error
# Prefer pattern matching over as with null check
[*.cs]
csharp_style_pattern_matching_over_as_with_null_check = true:error
# Prefer out var over declaring the out variable inline
[*.cs]
csharp_style_inlined_variable_declaration = true:error
```

In this example, the **.globalconfig** file specifies that the code should not use var (instead, it should use explicit types), it should use expression-bodied members for properties and methods, it should prefer pattern matching over as with null check, and it should prefer out var over declaring the out variable inline. The :error at the end of each rule means that violations of these rules will be reported as errors.
