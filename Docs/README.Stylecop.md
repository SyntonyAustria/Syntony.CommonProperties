##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)


## Stylecop <a name="Stylecop"/>
-----------

[StyleCop Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/tree/master) are a set of Roslyn analyzers that enforce the StyleCop rules at compile-time. Roslyn analyzers are extensions to the .NET compiler platform that provide real-time feedback to developers about their code. 

StyleCop is a tool that was originally developed by Microsoft to enforce coding style rules in C# code. It checks your code for compliance with a set of style and consistency rules. It can be integrated into Visual Studio and run during the build process.

However, the original StyleCop tool operates on the compiled binary of your code, which means it can only run after the code has been compiled. This can slow down the feedback loop for developers.

StyleCop Analyzers, on the other hand, operate on the source code as it's being compiled, which means they can provide immediate feedback in the editor as you're typing. This makes it much easier to catch and fix style violations as you're writing code.

StyleCop Analyzers come with a default set of rules, but you can customize these rules to fit your team's coding style. You can enable or disable individual rules, and you can adjust the severity of rule violations. You can also add a stylecop.json file to your project to configure certain rules, such as specifying the company name for the file header rule.
The stylecop.json file is a configuration file for the **StyleCop.Analyzers**, a set of Roslyn analyzers which aim to enforce the StyleCop rules in C# code. This file allows you to configure certain rules and settings for StyleCop.

To set a company name in stylecop.json, you would include it in the settings object under the documentationRules property. Here's an example:
```
{
    // ACTION REQUIRED: This file was automatically added to your project, but it
    // will not take effect until additional steps are taken to enable it. See the
    // following page for additional information:
    // https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/EnableConfiguration.md
    // https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/Configuration.md

    "$schema": "https://raw.githubusercontent.com/DotNetAnalyzers/StyleCopAnalyzers/master/StyleCop.Analyzers/StyleCop.Analyzers/Settings/stylecop.schema.json",
    "settings": {
        "documentationRules": {
            "companyName": "Your Company Name",
            "copyrightText": "Copyright © 2017 - 2023 by {companyName} - syntony@aon.at - All rights reserved.",
            "headerDecoration": "--------------------------------------------------------------------------------------------------------------------",
            "xmlHeader": true,
            "documentInterfaces": true,
            "documentExposedElements": true,
            "documentInternalElements": true,
            "documentPrivateElements": true,
            "documentPrivateFields": true,
            "documentationCulture": "en-US",
            "fileNamingConvention": "stylecop",
            "variables": {
                "licenseName": "MIT",
                "licenseFile": "LICENSE"
            }
        }
    }
}
```

In this example, replace "Your Company Name" with the name of your company. This company name will be used in the file header rules enforced by StyleCop, such as [SA1633](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1633.md) (File must have header).

Please note that the **stylecop.json** file should be placed in the project directory and included in the project file (**.csproj**), and you should also ensure that the StyleCop.Analyzers NuGet package is installed in your project.
