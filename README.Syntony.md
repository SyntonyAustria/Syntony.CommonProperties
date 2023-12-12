# Syntony.CommonProperties
**Common Properties** is a repository for ***Syntony*** projects for managing the build process with MSBuild and the associated relevant settings.

<details>
<summary><b>Table of Contents</b> (click to open)</summary>
<!-- MarkdownTOC -->

1. [Introduction](#introduction)
1. [Some files explained](#some-files-explained)
    1. [Markdown](#markdown)
    1. [README.md](#readme)
    1. [License](#license)
    1. [.NET SDK](#NetSdk)
    1. [.NET Analyzers](#NetAnalyzers)
    1. [.globalconfig](#globalconfig)
    1. [.editorconfig](#editorconfig)
    1. [git](#git)
    1. [.gitattributes](#gitattributes)
    1. [.gitignore ](#gitignore )
    1. [.mailmap ](#mailmap )
    1. [.sln](#sln)
    1. [.suo](#suo)
    1. [.props](#props)
    1. [.targets](#targets)
    1. [MSBuild Files](#MSBuildFiles)
    1. [Directory.Build.props](#Directory.Build.props)
    1. [Directory.Build.targets](#Directory.Build.targets)Docs\
    1. [Strong naming](#strongNaming)
    1. [Sign assembly](#signAssembly)
    1. [Pack](#pack)
    1. [Documentation](#documentation)
1. [Build Operation](#buildOperation)
1. [Software we use](#SoftwareWeUse)
1. [AI Tools](#AiTools)
1. [Contact](#contact)
1. [Helpful Links](#helpful-links)

<!-- /MarkdownTOC -->
</details>

## Introduction <a name="introduction"></a>
This file explains the basic structure of ***Syntony*** projects.
Thease are their files and relationships, the configuration files and the most important properties (*.props) and targets (*.targets) files for the MSBuild engine, as well as the sequence of the various build processes.

## File description <a name="some-files-explained"/>
-----------
<a name="markdown"/>[**Markdown**](https://www.markdownguide.org/basic-syntax/)

Markdown is a lightweight markup language for creating formatted text using a plain-text editor. 
John Gruber created Markdown in 2004 as a markup language that is easy to read in its source code form.
Markdown is widely used for blogging and instant messaging, and also used elsewhere in online forums, collaborative software, documentation pages, and readme files.
A comprehensive Markdown reference can be found at [mardown-guide](https://github.com/mattcone/markdown-guide)

<a name="readme"/>[**README.md**](https://docs.github.com/en/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-readmes)

In software development, a README file contains information about the other files in a directory or archive of computer software. 
A form of documentation, it is usually a simple plain text file called README, Read Me, READ.ME, README.TXT, **README.md** (to indicate the use of Markdown), or README.1ST.
The file's name is generally written in uppercase. On Unix-like systems in particular, this causes it to stand out � both because lowercase filenames are more common,
and because the ls command commonly sorts and displays files in ASCII-code order, in which uppercase filenames will appear first.

There are several reasons why a **README** file is typically written in plain text or markdown format (**README.md**) rather than a Word document (**.docx**):

1. *Compatibility*: Plain text and Markdown files can be read on any system with any text editor. Word documents require specific software to open and read, which may not be available on all systems.

2. *Version Control*: Plain text and Markdown files work well with version control systems like Git. Changes can be easily tracked line by line. Word documents are binary files, and changes in these files are not easily diffable in version control systems.

3. *Simplicity*: **README** files often don't need the complex formatting options that Word provides. Markdown provides enough formatting options (like headers, links, lists, code blocks) for a **README** file.

4. *Visibility*: On platforms like GitHub, GitLab, and Bitbucket, **README.md** files are automatically rendered and displayed on the main page of the repository. This is not the case with Word documents.

5. *Portability*: Plain text and Markdown files are lightweight and easy to share or distribute, while Word documents are typically larger and can be cumbersome to distribute.

So, while you technically could use a Word document for your **README**, it's generally not recommended due to these reasons.

<a name="license"/>**License**

This file contains the license details for the project. It tells others what they can and can't do with your code. It's important to choose an appropriate license for your project.
In a typical software solution, the LICENSE and [**README.md**](#readme) files are placed at the root level of the project directory.

<a name="fileStructure"/>**File Structure**
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

<a name="NetSdk"/>[**.NET SDK**](https://learn.microsoft.com/en-us/dotnet/core/sdk)

The .NET SDK (Software Development Kit) is a set of libraries and tools that allow developers to create .NET applications and libraries. It includes the .NET runtime, which is used to run .NET applications, and the .NET compiler, which is used to turn .NET code into a format that the runtime can understand. The SDK also includes templates for creating new projects and a command-line interface (CLI) for managing them. It supports different types of applications such as console, web, desktop, and mobile applications. The .NET SDK is cross-platform, meaning it can be used to develop applications on Windows, Linux, and macOS. It also supports a variety of programming languages, including C#, F#, and Visual Basic. The .NET SDK is open-source and maintained by Microsoft and the .NET community on GitHub. It is continuously updated to add new features, improve performance, and fix bugs. The .NET SDK is essential for any developer working with .NET technology. It provides the necessary tools and resources to efficiently build, test, and run .NET applications.

The typical path to .Net SDK is <a href="file:///C:/Program%20Files/dotnet/sdk/8.0.100/">"C:\Program Files\dotnet\sdk\8.0.100\"</a>


<a name="NetAnalyzers"/>[**.Net Analyzers](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview?tabs=net-8)

**.NET Analyzers** are code quality tools that are integrated into the [**.NET SDK**](#NetSdk). They analyze your code as you write it, providing feedback and suggestions to help you improve the quality of your code and adhere to best practices.

Analyzers can detect a wide range of issues, such as potential bugs, code style issues

<a name="globalconfig"/>[**.globalconfig**](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig)

The **.globalconfig** file is a special kind of AnalyzerConfig file that is used to configure code analyzers on a global level across multiple projects. 
Unlike EditorConfig files, global configuration files can't be used to configure editor style settings for IDEs, such as indent size or whether to trim trailing whitespace. 
Instead, they are designed purely for specifying project-level analyzer configuration options.
**.globalconfig** is a newer feature introduced in .NET 5.0 as part of the .NET analyzers. 
A **.globalconfig** file is similar to an [**.editorconfig**](#editorconfig) file, but it's used to configure analyzer diagnostics.
You can use a **.globalconfig** file to configure the severity of diagnostics, enable or disable specific diagnostics, and so on. The main advantage of .globalconfig files is that they can be used to enforce coding conventions across multiple projects or even across an entire solution, regardless of the directory structure. This makes them particularly useful in large code

<a name="editorconfig"/>[**.editorconfig**](https://editorconfig.org/)

When opening a file, EditorConfig plugins look for a file named **.editorconfig** in the directory of the opened file and in every parent directory.
A search for .editorconfig files will stop if the root filepath is reached or an EditorConfig file with **root=true** is found.
An **.editorconfig** file is used to define and maintain consistent coding styles for different editors and IDEs. 
It's a text file that contains a collection of code style settings. It supports a wide range of languages and can be used in almost any text editor or IDE. 
In .NET projects, you can use **.editorconfig** to enforce specific conventions related to naming, layout, and language features. 
For example, you can specify whether to use tabs or spaces for indentation, the maximum line length, and so on. When an **.editorconfig** file is placed in a directory, it applies to all applicable files in that directory and its subdirectories. Multiple **.editorconfig** files can be used in a project, with settings in closer files taking precedence.

<a name="git"/>[**git**](https://git-scm.com/)

Git is a distributed version control system. It allows developers to track changes to their code over time, and enables multiple developers to work on the same codebase without overwriting each other's changes.

Git is a command-line tool that is installed and run on a developer's local machine. It does not provide a user interface or hosting for repositories.

Git is open-source and can be used with any type of project, regardless of the programming languages or tools used.

<a name="gitattributes"/>[**.gitattributes**](https://git-scm.com/docs/gitattributes)

The **.gitattributes** file is a text file that you can place in your repository's root directory or in any subdirectory. 
It allows you to define attributes on a per-path basis. These attributes can affect the way Git handles certain files. 

Here are some common uses of the **.gitattributes** file:

**Line Endings:** You can use the **.gitattributes** file to normalize line endings to a standard style. 
This can be helpful when working on a project across different operating systems.
```
* text=auto
```

**Language Statistics:** GitHub uses the **.gitattributes** file to determine the language statistics of a repository. 
You can override these statistics using the linguist-generated attribute.
```
*.generated linguist-generated=true
```

**Merge Strategies:** You can specify a custom merge driver for specific files or file types
```
*.java merge=javaMerge
```

**Diff Rendering:** You can customize how git diff command outputs differences of specific files.
```
 *.java diff=javaDiff
```

Git will check the first 8,000 bytes of a file to see if it contains a NUL character. If it does, the file is assumed to be binary.
From git's [source code:](https://github.com/git/git/blob/9c9b961d7eb15fb583a2a812088713a68a85f1c0/xdiff-interface.c#L187-L193)
```
#define FIRST_FEW_BYTES 8000
int buffer_is_binary(const char *ptr, unsigned long size)
{
    if (FIRST_FEW_BYTES < size)
        size = FIRST_FEW_BYTES;
    return !!memchr(ptr, 0, size);
}
```

<a name="gitignore"/>[**.gitignore**](https://git-scm.com/docs/gitignore)

The **.gitignore** file is used to specify intentionally untracked files that Git should ignore. Files already tracked by Git are not affected.
The purpose of this file is to ensure that certain files and directories are untracked by Git. 
This is typically because these files are generated from source files that are already tracked, are personal to developers and not needed by others, or are temporary files that don't need to be shared.

<a name="mailmap"/>[**.mailmap**](https://git-scm.com/docs/gitmailmap)

A **.mailmap** file is used in a Git repository to handle inconsistencies in commit author names and email addresses. It's a mechanism to map each author's various names and email addresses to a single, canonical representation.
The **.mailmap**  file is typically placed in the root directory of a Git repository.

<a name="sln"/>[**.sln**](https://learn.microsoft.com/en-us/visualstudio/extensibility/internals/solution-dot-sln-file?view=vs-2022)

In a Visual Studio solution file, paths are typically defined relative to the location of the solution file itself. This is done to ensure that the solution can be moved or shared across different environments without breaking the path references.

Unfortunately, Visual Studio solution files do not support absolute paths without a drive letter. The paths must be either relative to the solution file or absolute with a drive letter.

<a name="suo"/>[**.suo**](https://learn.microsoft.com/en-us/visualstudio/extensibility/internals/solution-user-options-dot-suo-file?view=vs-2022)

The solution user options (.suo) file contains per-user solution options. This file should not be checked in to source code control.

<a name="props"/>[**.props**](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2022#choose-between-adding-properties-to-a-props-or-targets-file)

.props files: These are property files used by MSBuild to define properties and items that are common to multiple projects. They are typically imported at the top of a project file. The .NET SDK includes several .props files that set up common properties for .NET projects.

<a name="targets"/>[**.targets**](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2022#choose-between-adding-properties-to-a-props-or-targets-file)

.targets files: These files define targets, tasks, and other build logic for building, packaging, and testing .NET projects. They are typically imported at the bottom of a project file. The .NET SDK includes several .targets files that implement the build process for .NET projects.

<a name="MSBuildFiles"/>[**MSBuild Files**]()
MSBuild Files: These are the files that drive the build process. They include [.props](#props) and [.targets](#targtes) files, which define properties, items, and targets used by the build process. These files are typically located in the CurrentVersion.targets and CurrentVersion.props files in the SDK.

<a name="Directory.Build.props"/>[**Directory.Build.props**](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-by-directory?view=vs-2022)

When MSBuild runs, **Microsoft.Common.props** searches your directory structure for the Directory.Build.props file. 
If it finds one, it imports the file and reads the properties defined within it. 
**Directory.Build.props** is a user-defined file that provides customizations to projects under a directory. **Directory.Build.props** is imported early in the sequence of imported files, which can be important if you need a set a property that is used by imports, especially those that are implicitly imported by using the Sdk attribute, such as when using the .NET SDK in most .NET project files.

The **Directory.Build.props** file is imported very early in the build process of an SDK-style project in .NET.
Specifically, it is imported *before* the project file itself is imported. This allows properties defined in **Directory.Build.props** to influence the behavior of the SDK and the project file.
The **Directory.Build.props** file is typically placed in the root directory of your source code repository. MSBuild will automatically import this file from the current directory, or any of its parent directories. This allows you to specify common properties for all projects in your repository in a single file.

Note that if there are multiple **Directory.Build.props** files in the directory hierarchy, all of them will be imported, with files in child directories imported before files in parent directories. This allows a **Directory.Build.props** file in a child directory to override properties specified in a **Directory.Build.props** file in a parent directory.


<a name="Directory.Build.targets"/>[**Directory.Build.targets**](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-by-directory?view=vs-2022)

<a name="strongNaming"/>[Strong naming](https://learn.microsoft.com/en-us/dotnet/standard/assembly/strong-named)

Strong-naming an assembly creates a unique identity for the assembly, and can prevent assembly conflicts.
Do not rely on strong names for security. They provide a unique identity only.

Both .pfx and .snk files are associated with strong name and code signing in .NET, but they serve different purposes and contain different types of data.

[**.snk**] (Strong Name Key) file: This is a simple key file used by .NET for strong-naming assemblies. It contains just the key pair (public and private keys) that's used to sign an assembly and doesn't have any associated certificate or metadata. Strong names are used to uniquely identify an assembly and prevent DLL Hell, but they don't provide any security or trust guarantees.

[**.pfx**] (Personal Information Exchange) file: This is a certificate file that can be used for code signing. It contains not only the key pair, but also the certificate that vouches for the identity of the key owner. This certificate can be issued by a trusted certificate authority (CA), which allows others to verify the identity of the key owner and trust the signed code. PFX files are protected by a password to secure the private key.

In summary, if you just want to strong-name your assemblies, you can use a .snk file. If you want to sign your code and provide trust guarantees, you need a .pfx file with a certificate issued by a trusted CA.

For .NET Framework, strong-named assemblies are useful in the following scenarios:

* You want to enable your assemblies to be referenced by strong-named assemblies, or you want to give friend access to your assemblies from other strong-named assemblies. 

* An app needs access to different versions of the same assembly. This means you need different versions of an assembly to load side by side in the same app domain without conflict. For example, if different extensions of an API exist in assemblies that have the same simple name, strong-naming provides a unique identity for each version of the assembly. 

* You do not want to negatively affect performance of apps using your assembly, so you want the assembly to be domain neutral. This requires strong-naming because a domain-neutral assembly must be installed in the global assembly cache.

* You want to centralize servicing for your app by applying publisher policy, which means the assembly must be installed in the global assembly cache.

For .NET Core and .NET 5+, strong-named assemblies do not provide material benefits. The runtime never validates the strong-name signature, nor does it use the strong-name for assembly binding.

<a name="signAssembly"/>[**Sign Asembly**](https://learn.microsoft.com/en-us/dotnet/standard/assembly/sign-strong-name)

In .NET, signing an assembly is not mandatory, but it is a recommended practice. When you sign an assembly, you are adding a digital signature to it that uniquely identifies the assembly and its author. This signature can be used to verify the integrity of the assembly and ensure that it has not been tampered with.
There are several reasons why you might want to sign an assembly:

[**Authenticity**]: Signing an assembly ensures that it is authentic and has not been tampered with.

[**Security**]: Signed assemblies can be placed in the Global Assembly Cache (GAC), which is a central repository for shared assemblies. Signing an assembly guarantees that it cannot be spoofed by someone else.

[**Versioning**]: Strongly named assemblies are tied to a specific version, meaning that you can use binding
redirects or recompile the application if you want to use a different version.

[**Dependency**]: If you sign an executable, then any class libraries it links to also need to be signed.

As for .NET 8.0, there are no major changes in the signing process. However, it is important to note that .NET 8.0 has a tighter version coupling for assemblies that are embedded in compositions. This means that apps cannot use custom versions of Framework or ASP.NET binaries 


<a name="pack"/>[**Pack**](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio)
Here are some commonly used MSBuild properties for Pack:

1. [**PackageId**]: Specifies the NuGet package ID.
2. [**PackageVersion**]: Specifies the NuGet package version.
3. [**Authors**]: Specifies the authors of the package.
4. [**Company**]: Specifies the company that produced the package.
5. [**Product**]: Specifies the product name.
6. [**Description**]: Specifies a description of the package.
7. [**Copyright**]: Specifies the copyright details for the package.
8. [**PackageLicenseExpression or PackageLicenseFile**]: Specifies the package license.
9. [**PackageProjectUrl**]: Specifies the project URL.
10. [**PackageIcon**]: Specifies the package icon.
11. [**PackageTags**]: Specifies the tags that apply to the package.
12. [**PackageReleaseNotes**]: Specifies the release notes for the package.
13. [**PackageOutputPath**]: Specifies the output path where the package will be created.
14. [**IncludeSymbols**]: If set to true, creates a symbols package alongside the regular package.
15. [**IncludeSource**]: If set to true, includes the source files in the symbols package.

<a name="documentation"/>**Documentation**

Converting XML documentation to other formats like Markdown (MD), HTML, or DOCX is not a built-in feature of Visual Studio or ReSharper. However, there are several tools and libraries available that can help with this task.

Here are a few options:
1. [**Sandcastle Help File Builder (SHFB)**](https://github.com/EWSoftware/SHFB): This is a Microsoft tool that can generate MSDN-style documentation from .NET XML documentation files. It can output HTML and CHM (Microsoft Compiled HTML Help) files.
2. [**DocFX**](https://dotnet.github.io/docfx/): This is another Microsoft tool that can generate API documentation directly from XML comments in .NET source code. It can output static HTML that you can host on any web server, and it also supports Markdown files.
3. [**Pandoc**](https://pandoc.org/): This is a universal document converter that can convert XML to many other formats including Markdown, HTML, and DOCX. However, it might not understand the structure of .NET XML documentation files out of the box, so you might need to preprocess the XML to a format Pandoc can understand.
4. [**Doxygen**](https://www.doxygen.nl/): Doxygen is a popular documentation system for various programming languages, including C++, C, C#, Objective-C, Python, Java, PHP, and others. It is used to generate documentation from annotated source code.

<a name="buildOperation"/>[**Build Opertation**]()

Visual Studio defines several build operations by default. Here are the main ones:

[**Build**]: The Build operation compiles all the project files into executable code. If the project has been built previously, the Build operation only recompiles those files that have been modified since the last build. This makes the build process faster as it doesn't need to recompile all files.

[**Rebuild**]: The Rebuild operation performs a Clean followed by a Build. It deletes all compiled files in the build directory and then compiles all project files regardless of whether they have been modified or not. This ensures that any old or unnecessary compiled files are removed, and all code is compiled from scratch.

[**Clean**]: The Clean operation deletes all compiled files (like DLLs and EXEs) from the build directory. This is useful when you want to ensure that the next build operation is done from scratch and doesn't use any old compiled files.

[**Pack**]: The Pack operation creates a NuGet package (.nupkg file) from the project. This is useful when you want to distribute your project as a NuGet package that can be consumed by other projects.

[**Publish**]: The Publish operation builds the project and deploys the output to a specified location, which could be a folder on your local machine, a network share, or a cloud-based service. This operation is typically used when you're ready to deploy your application to a staging or production environment.

Each of these operations serves a different purpose in the software development lifecycle, and you would use them at different stages of your project.
These operations can be accessed from the Build menu in Visual Studio. Note that not all operations are available for all project types. For example, the Publish operation is not available for class library projects.




---------

TODO:
The structure of an csproj a C# project

1. MSBuild starts by reading the .csproj file.

2. It sees the Sdk attribute and loads the specified SDK. The SDK includes a set of MSBuild .targets and .props files, which define the build process for .NET Core projects.

For the Microsoft.NET.Sdk, the first file that gets imported is [Microsoft.NET.Sdk.props](https://github.com/dotnet/sdk/blob/main/src/Tasks/Microsoft.NET.Build.Tasks/targets/Microsoft.NET.Sdk.props). This file is located in the Sdk folder of your .NET installation directory.


## Software we use <a name="SoftwareWeUse"/>
1. [Visual Studio](https://learn.microsoft.com/en-us/visualstudio/releases/2022/release-notes) 
1. [Notepad++](https://notepad-plus-plus.org/)
1. [iGrafx Origins](https://www.igrafx.com/)
1. [MindManager](https://www.mindmanager.com/en/)
1. [Audible](https://www.audible.de/)
1. [Office](https://www.microsoft.com/de-at/microsoft-365/)
1. [OneDrive](https://www.microsoft.com/en-gb/microsoft-365/onedrive/download)
1. [Teams](https://www.microsoft.com/de-at/microsoft-teams/download-app)
1. [SmartSwitch](https://www.samsung.com/at/apps/smart-switch/)
1. [MyPhoneExplorer](https://www.fjsoft.at/de/)
1. [GitHub Desktop](https://desktop.github.com/)
1. [Git Bash](https://git-scm.com/downloads)
1. [Postman](https://www.postman.com/downloads/)
1. [Deepl](https://www.deepl.com/translator)
1. [ID3-TagIT3](https://www.heise.de/download/product/id3-tag-editor-38844)
1. [MP3tag](https://www.mp3tag.de/)
1. [iTunes](https://support.apple.com/de_AT/downloads/itunes)
1. [VLC media player](https://www.videolan.org/vlc/)
1. [Axialis IconWorkShop](https://axialis.com/iconworkshop/)
1. [pdfFactory Pro](https://fineprint.com/pdfp/)
1. [Winaero Tweaker](https://winaero.com/winaero-tweaker/)
1. [MSBuild Structured Log Viewer](https://msbuildlog.com/)
1. [Glary Utilities](https://www.glarysoft.com/)
1. [Ultra Search](https://www.jam-software.com/ultrasearch)
1. [PatchMyPC](https://patchmypc.com/home-updater#download)
1. [WinGetUI](https://github.com/marticliment/WingetUI)
1. [Autorun Organizer](https://www.chemtable.com/autorun-organizer.htm)

1. [Syntony.GetSharper](https://github.com/SyntonyAustria/Syntony.GetSharper)
1. [GhostDoc](https://submain.com/ghostdoc/)
1. [JetBrains ReSharper](https://www.jetbrains.com/resharper/)
    * [Code Extensions](https://plugins.jetbrains.com/plugin/16767-code-extensions)
    * [Heap Allocation Viewer](https://github.com/controlflow/resharper-heapview)
    * [CognitiveComplexity](https://github.com/matkoch/resharper-cognitivecomplexity)
    * [AutocompleteTestStrings](https://github.com/Socolin/AutocompleteTestStrings-Rider-Plugin)
    * [Structured Logging](https://github.com/olsh/resharper-structured-logging)
    * [InternalsVisibelTo Helper](https://github.com/matkoch/resharper-internalsvisibleto)
    * [CyclomaticComplexity](https://github.com/JetBrains/resharper-cyclomatic-complexity)
    * [CleanCode](https://github.com/MO2k4/CleanCode)
    * [Enhanced Tooltip](https://github.com/MrJul/ReSharper.EnhancedTooltip/)
    * [Exceptional by MF](https://github.com/hhu-mahmoud/ExceptionalReSharper)
    * [MoqComplete](https://github.com/Abc-Arbitrage/Abc.MoqComplete)

31. [WingetUI](https://github.com/marticliment/WingetUI)
 1. [WingetUI](https://github.com/marticliment/WingetUI)


## AI Tools <a name="AiTools"/>
-----------
* [Jetbrains AI Assistant](https://www.jetbrains.com/ai/)
* [Bard](https://bard.google.com/chat)
* [Chat GPT](https://chat.openai.com/auth/login)
* [Copilot](https://copilot.microsoft.com/)
* [Opera Aria](https://www.opera.com/de/features/aria)

## Contact <a name="contact"/>
-----------

You can contact us at <syntony@aon.at>

[GitHub](https://github.com/SyntonyAustria)  
[Twitter](https://twitter.com/SyntonyAustria)  
[WordPress](https://syntonyblog.wordpress.com/)

## Helpful Links <a name="helpful-links"/>
-----------
[Markdown Guide](https://about.gitlab.com/handbook/markdown-guide/)

[MSBuild on github](https://github.com/dotnet/msbuild)
[MSBuild documentation](https://learn.microsoft.com/en-us/visualstudio/msbuild/msbuild?view=vs-2022)

[git documentation](https://git-scm.com/doc)
[git cheatsheet](https://ndpsoftware.com/git-cheatsheet.html#loc=index)
[Pro Git online](https://git-scm.com/book/en/v2)
[Pro Git as PDF](https://github.com/progit/progit2/releases/download/2.1.412/progit.pdf)
[Pro Git source](https://github.com/progit/progit2)

[.gitattributes best practice](https://rehansaeed.com/gitattributes-best-practices/)
[A Collection of Useful .gitattributes Templates](https://github.com/gitattributes/gitattributes)
[dotnet runtime .gitattributes](https://github.com/dotnet/runtime/blob/main/.gitattributes)
