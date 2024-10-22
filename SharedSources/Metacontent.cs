﻿
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="MetaContent.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     undefined
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Hahnl</author>
// <email>syntony@aon.at</email>
// <date>08.02.2019 16:48:24</date>
// <information solution="" project="" framework="" kind="Windows (C#)">
//     <file type=".cs" created="2024-10-21 20:00:21.0518963" modified="2024-10-21 20:00:21.0518963" lastAccess="2024-10-21 20:00:21.0518963">
//         Properties\MetaContent.cs
//     </file>
//     <lineStatistics total="624" netLines="481" blankLines ="143" codeLines="261" codeRatio="41.83 %" allCommentLines="33" commentLines="3" headerLines="30" documentationLines="220"/>
//     <language>C#</language>
//     <namespace>Syntony.Properties</namespace>
//     <class>MetaContent</class>
//     <identifiers>
//         <Namespace>Syntony.Properties</Namespace>
//         <Class>MetaContent</Class>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>3</numberOfUsings>
//         <numberOfFields>116</numberOfFields>
//         <numberOfAttributes>79</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Defines MetaContent constants mostly read from project file. The vocabularies used to assemble metadata (metacontent) statements.
// </summary>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace Syntony.Properties;

using System;
using System.Diagnostics.CodeAnalysis;

using JetBrains.Annotations;

using Syntony.Constants;

#pragma warning disable CA1724, CC0021 // Type names should not match namespaces

/// <summary>Define MetaContent constants mostly read from project file. The vocabularies used to assemble metadata (metacontent) statements.</summary>
/// <remarks>MetaContent defines a hybrid implementation of semantic version that supports semantic versioning as described at <a href="http://semver.org">Semantic Versioning</a>
/// while not strictly enforcing it to allow older 4-digit versioning schemes to continue working.</remarks>
/// <devdoc>
/// <a href="http://stackoverflow.com/questions/64602/what-are-differences-between-assemblyversion-assemblyfileversion-and-assemblyin"/>,
/// <a href="https://andrewlock.net/version-vs-versionsuffix-vs-packageversion-what-do-they-all-mean"/>,
/// <a href="http://haacked.com/archive/2006/09/27/Which_Version_of_Version.aspx/"/>.
/// Caution: This code was generated by a tool. Any changes made manually will be lost the next time this code is regenerated.
/// </devdoc>
[SuppressMessage("ReSharper", "PartialTypeWithSinglePart", Justification = "okay here")]
[SuppressMessage("ReSharper", "RedundantNameQualifier", Justification = "okay here")]
[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "okay here")]
[PublicAPI]
internal static partial class MetaContent
{
#if SYNTONY_CODE_ANALYSIS || CODE_ANALYSIS

    /// <summary>The current <b>build</b> configuration of this assembly: <see cref="Syntony.Configuration.BuildConfigurationState.CodeAnalysis"/>.</summary>
    public const Syntony.Configuration.BuildConfigurationState BuildConfigurationState = Syntony.Configuration.BuildConfigurationState.CodeAnalysis;

    /// <summary>The current MSBUILD Configuration: CodeAnalysis.</summary>
    [JetBrains.Annotations.NotNull]
    public const string Configuration = "CodeAnalysis";

    /// <summary>Indicates whether the current build configuration is set to Release: "false".</summary>
    public const bool IsReleaseConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to Debug: "true".</summary>
    public const bool IsDebugConfiguration = true;

    /// <summary>Indicates whether the current build configuration is set to CodeAnalysis: "true".</summary>
    public const bool IsCodeAnalysisConfiguration = true;

    /// <summary>Indicates whether the current build configuration is set to PushNuGetPackage: "false".</summary>
    public const bool IsPushNuGetPackageConfiguration = false;

#elif DEBUG

    /// <summary>The current <b>build</b> configuration of this assembly: <see cref="Syntony.Configuration.BuildConfigurationState.Debug"/>.</summary>
    public const Syntony.Configuration.BuildConfigurationState BuildConfigurationState = Syntony.Configuration.BuildConfigurationState.Debug;

    /// <summary>The current MSBUILD Configuration: Debug.</summary>
    [JetBrains.Annotations.NotNull]
    public const string Configuration = "Debug";

    /// <summary>Indicates whether the current build configuration is set to Release: "false".</summary>
    public const bool IsReleaseConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to Debug: "true".</summary>
    public const bool IsDebugConfiguration = true;

    /// <summary>Indicates whether the current build configuration is set to CodeAnalysis: "false".</summary>
    public const bool IsCodeAnalysisConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to PushNuGetPackage: "false".</summary>
    public const bool IsPushNuGetPackageConfiguration = false;

#elif PUSHNUGETPACKAGE

    /// <summary>The current <b>build</b> configuration of this assembly: <see cref="Syntony.Configuration.BuildConfigurationState.PushNuGetPackage"/>.</summary>
    public const Syntony.Configuration.BuildConfigurationState BuildConfigurationState = Syntony.Configuration.BuildConfigurationState.PushNuGetPackage;

    /// <summary>The current MSBUILD Configuration: PushNuGetPackage.</summary>
    /// <devdoc>The name "NuGet" comes from "New Get", indicating a new way to get libraries for .NET development.</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string Configuration = "PushNuGetPackage";

    /// <summary>Indicates whether the current build configuration is set to Release: "true".</summary>
    public const bool IsReleaseConfiguration = true;

    /// <summary>Indicates whether the current build configuration is set to Debug: "false".</summary>
    public const bool IsDebugConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to CodeAnalysis: "false".</summary>
    public const bool IsCodeAnalysisConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to PushNuGetPackage: "true".</summary>
    public const bool IsPushNuGetPackageConfiguration = true;

#else

    /// <summary>The current <b>build</b> configuration of this assembly: <see cref="Syntony.Configuration.BuildConfigurationState.Release"/>.</summary>
    public const Syntony.Configuration.BuildConfigurationState BuildConfigurationState = Syntony.Configuration.BuildConfigurationState.Release;

    /// <summary>The current MSBUILD Configuration: Release.</summary>
    [JetBrains.Annotations.NotNull]
    public const string Configuration = "Release";

    /// <summary>Indicates whether the current build configuration is set to Release: "true".</summary>
    public const bool IsReleaseConfiguration = true;

    /// <summary>Indicates whether the current build configuration is set to Debug: "false".</summary>
    public const bool IsDebugConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to CodeAnalysis: "false".</summary>
    public const bool IsCodeAnalysisConfiguration = false;

    /// <summary>Indicates whether the current build configuration is set to PushNuGetPackage: "false".</summary>
    public const bool IsPushNuGetPackageConfiguration = false;

#endif

    /// <summary>The last MSBUILD configuration with which this file was created: undefined.</summary>
    [JetBrains.Annotations.NotNull]
    public const string FileCreationConfiguration = "undefined";

    /// <summary>The current release type.</summary>
    public const Syntony.Annotations.ReleaseType ReleaseType = Syntony.Annotations.ReleaseType.Release;

    /// <summary>The current used language version: "latest".</summary>
    /// <remarks><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version"/>.</remarks>
    [JetBrains.Annotations.NotNull]
    public const string LangVersion = "latest";

    /// <summary>Deterministic compilation can be used for establishing whether a binary is compiled from a trusted source: "false".</summary>
    /// <remarks><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/code-generation#deterministic"/>.</remarks>
    public const bool Deterministic = false;

    /// <summary>Defines the nullable warnings: "disabled".</summary>
    /// <remarks><a href="https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references#nullable-contexts"/>.</remarks>
    [JetBrains.Annotations.NotNull]
    public const string Nullable = "disabled";

    /// <summary>The defined company: "Syntony".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Company = "Syntony";

    /// <summary>The defined company in uppercase letters: "SYNTONY".</summary>
    [JetBrains.Annotations.NotNull]
    public const string CompanyUppercase = "SYNTONY";

    /// <summary>The current NuGet authors: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Authors = "undefined";

    /// <summary>The default author: "Syntony".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Author = "Syntony";

    /// <summary>The assembly name: <see cref="TargetFileName"/>: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyName = TargetFileName;

    /// <summary>The current MSBuildProjectName: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string ProjectName = "";

    /// <summary>The current <see cref="DateTime"/> UTC string when this file was built with format "yyyy-MM-dd HH:mm:ss.FFFFFFF": "2024-10-21 20:00:21.0518963".</summary>
    /// <seealso cref="BuildDateTimeFormat"/>
    [JetBrains.Annotations.NotNull]
    public const string BuildDateTimeString = "2024-10-21 20:00:21.0518963";

    /// <summary>The used format to build <see cref="BuildDateTimeString"/> string: "yyyy-MM-dd HH:mm:ss.FFFFFFF".</summary>
    /// <seealso cref="BuildDateTime"/>
    [JetBrains.Annotations.NotNull]
    public const string BuildDateTimeFormat = "yyyy-MM-dd HH:mm:ss.FFFFFFF";

    /// <summary>The current MSBUILD Configurations: "Debug".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Configurations = "Debug";

    /// <summary>The major version number when you make incompatible API change: 1.</summary>
    public const int Major = 1;

    /// <summary>The minor version number when you add functionality in a backwards-compatible manner: 0.</summary>
    public const int Minor = 0;

    /// <summary>The patch version number when you make backwards-compatible bug fixes: 0.</summary>
    public const int Patch = 0;

    /// <summary>The build version number: 0.</summary>
    /// <remarks>A difference in build number represents a recompilation of the same source. This would be appropriate because of processor, platform, or compiler changes.</remarks>
    public const int Build = 0;

    /// <summary>The build number used for none-stable builds: 1.</summary>
    /// <remarks>A difference in build number represents a recompilation of the same source. This would be appropriate because of processor, platform, or compiler changes.</remarks>
    public const int BuildNumber = 1;

    /// <summary>The revision version number: 36010.</summary>
    /// <remarks>Assemblies with the same name, major, and minor version numbers but different revisions are intended to be fully interchangeable.</remarks>
    public const int Revision = 36010;

    /// <summary>The build counter: 1.</summary>
    /// <remarks>Represents the number of total builds for this project.</remarks>
    public const int ProjectBuildCounter = 1;

    /// <summary>The build counter for the 'Release' configuration: 1.</summary>
    /// <remarks>Represents the number of builds for the 'Release' configuration.</remarks>
    public const int ReleaseBuildCounter = 1;

    /// <summary>The metacontent build counter: 1.</summary>
    /// <remarks>Represents the number of metacontent builds.</remarks>
    public const int MetacontentBuildCounter = 1;

    /// <summary>The current NuGet PackageVersion: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PackageVersion = "undefined";

    /// <summary>The current NuGet SemVersion BuildMetaData: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string BuildMetaData = "";

    /// <summary>The major version string: "1".</summary>
    [JetBrains.Annotations.NotNull]
    public const string MajorVersionInfo = "1";

    /// <summary>The minor version string: "0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string MinorVersionInfo = "0";

    /// <summary>The patch version string: "0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PatchVersionInfo = "0";

    /// <summary>The build version string: "0".</summary>
    /// <remarks>That's the number that is changed on every build.</remarks>
    [JetBrains.Annotations.NotNull]
    public const string BuildVersionInfo = "0";

    /// <summary>The revision version string: "36010".</summary>
    /// <remarks>No revision number should be greater than 65535.</remarks>
    [JetBrains.Annotations.NotNull]
    public const string RevisionVersionInfo = "36010";

    /// <summary>The <see cref="CommonConstants.Company"/> version short: "1.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionShortInfo = MajorVersionInfo + CommonConstants.DotString + MinorVersionInfo;

    /// <summary>All possible development types of this assembly: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string DevelopmentTypes = "undefined";

    /// <summary>The current ProjectFileName: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string ProjectFileName = "";

    /// <summary>The current project target file name: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string TargetFileName = "";

    /// <summary>The current project target name without extension: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string TargetName = "";

    /// <summary>The last prefix of Assembly: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string LastPrefix = "";

    /// <summary>The Test prefix of Assembly: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string TestPrefix = "";

    /// <summary>The class prefix for content class: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string ClassPrefix = "";

    /// <summary>The current NuGet PackageDescription: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PackageDescription = "undefined";

    /// <summary>The current NuGet PackageId: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PackageId = "undefined";

    /// <summary>The current NuGet Title: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Title = "undefined";

    /// <summary>The current NuGet Description: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Description = "undefined";

    /// <summary>The current NuGet PackageTags: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PackageTags = "undefined";

    /// <summary>The current NuGet VersionPrefix: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionPrefix = "undefined";

    /// <summary>The current NuGet VersionSuffix: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionSuffix = "";

    /// <summary>The current NuGet InformationalVersion: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string InformationalVersion = "undefined";

    /// <summary>The current NuGet Copyright: "undefined".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Copyright = "undefined";

    /// <summary>The current NuGet Trademark: "Syntony®".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Trademark = "Syntony®";

    /// <summary>The current AssemblyCulture: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyCulture = "";

    /// <summary>Indicates whether a program element is by default compliant with the Common Language Specification (CLS): "true".</summary>
    public const bool CLSCompliantAttribute = true;

    /// <summary>Controls accessibility of all types within an assembly by default, to COM.: "true".</summary>
    public const bool ComVisibleAttribute = true;

    /// <summary>The current TargetFramework: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string TargetFramework = "";

    /// <summary>The TargetFrameworks built: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string TargetFrameworks = "";

    /// <summary>The current Platform: "Win32".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Platform = "Win32";

    /// <summary>The current RootNamespace: "Syntony".</summary>
    [JetBrains.Annotations.NotNull]
    public const string RootNamespace = "Syntony";

    /// <summary>Defines if the assembly source code is based for a cross-targeting build: "false".</summary>
    /// <remarks>
    /// We are doing a cross-targeting build if there is a non-empty list of target frameworks specified
    /// and there is no current target framework being built individually. In that case, a multitargeting
    /// project file like Microsoft.&lt;language&gt;.CrossTargeting.targets gets imported.
    /// <para></para>
    /// Cross-targeting in the context of .NET development refers to the ability of a project to target multiple .NET frameworks.
    /// This is useful when you want to create a library that can be used in projects targeting different versions of .NET, such as .NET Framework, .NET Core, or .NET Standard.
    /// <para></para>
    /// When a project cross-targets multiple frameworks, MSBuild essentially builds the project multiple times, once for each targeted framework.
    /// This is done by the DispatchToInnerBuilds target, which invokes the Build target once for each targeted framework.
    /// <para></para>
    /// In the project file, you can specify multiple target frameworks by using the TargetFrameworks property (note the plural form).
    /// </remarks>
    /// <seealso cref="TargetFramework"/> <seealso cref="TargetFrameworks"/>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting"/></devdoc>
    public const bool IsCrossTargetingBuild = false;

    /// <summary>Defines if this assembly represents a test assembly: "false".</summary>
    public const bool IsTestAssembly = false;

    /// <summary>The assembly to be tested: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyToTest = "";

    /// <summary>Defines if this assembly represents an example assembly: "false".</summary>
    public const bool IsExampleProject = false;

    /// <summary>Defines if this assembly represents a benchmark (Benchmark .NET) assembly: "false".</summary>
    public const bool IsBenchmarkProject = false;

    /// <summary>Defines if this assembly represents a quick benchmark assembly: "false".</summary>
    public const bool IsQuickBenchmarkProjectString = false;

    /// <summary>Defines if this assembly represents a localization assembly: "false".</summary>
    public const bool IsLocalizationProject = false;

    /// <summary>Defines if the assembly is signed: "false".</summary>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/standard/assembly/sign-strong-name"/>,
    /// <a href="https://www.c-sharpcorner.com/uploadfile/puranindia/signing-an-assembly-in-C-Sharp/"/>,
    /// <a href="https://learn.microsoft.com/en-us/dotnet/standard/assembly/delay-sign"/>,
    /// <a href="https://learn.microsoft.com/en-us/dotnet/standard/assembly/strong-named"/>
    /// <a href="https://github.com/dotnet/runtime/blob/main/docs/project/strong-name-signing.md"/>,
    /// <a hre="https://learn.microsoft.com/en-us/dotnet/framework/tools/sn-exe-strong-name-tool"/>.</devdoc>
    public const bool IsSigned = false;

    /// <summary>Determines if this assembly can be shipped, delivered to customers: "false".</summary>
    /// <remarks>Determine which (if any) assets produced by the project are shipping. An asset is considered shipping if it is intended to be delivered to customers via an official channel.
    /// If <see langword="true"/> and <see cref="BuildConfigurationState"/> is <see cref="Syntony.Configuration.BuildConfigurationState.Release"/> also
    /// "DISTRIBUTION" is defined as a conditional compilation symbol; otherwise "DISTRIBUTION" is not defined as a conditional compilation symbol.</remarks>
    /// <devdoc><a href="https://github.com/dotnet/arcade/blob/main/Documentation/ArcadeSdk.md#isshipping-isshippingassembly-isshippingpackage-isshippingvsix-bool"/></devdoc>
    public const bool IsShipping = false;

    /// <summary>Defines if build assembly can be delivered to customers: "false".</summary>
    public const bool IsShippingAssembly = false;

    /// <summary>Defines if build package can be delivered to customers: "false".</summary>
    /// <remarks>By default, all projects which produce packages are not intended to ship to NuGet.org as a product package.
    /// Packages which are intended to ship to NuGet.org must opt-in by setting this to true in the project file.</remarks>
    public const bool IsShippingPackage = false;

    /// <summary>Defines if build VSIX can be delivered to customers: "false".</summary>
    public const bool IsShippingVsix = false;

    /// <summary>If this assembly is designated to be release: "false".</summary>
    public const bool IsReleaseVersion = false;

    /// <summary>The <see cref="CommonConstants.Company"/> version used by <see cref="System.Reflection.AssemblyVersionAttribute"/>: "1.0.0.0".</summary>
    /// <remarks>Every assembly you produce as part of your build process has a version number embedded in it, which forms an important part of the assembly's identity.
    /// It's stored in the assembly manifest and is used by the runtime to ensure correct versions are loaded etc.
    /// The <seealso cref="System.Reflection.AssemblyVersionAttribute"/> is used along with name, public key token and culture information only if the assemblies are strong-named signed.
    /// If assemblies are not strong-named signed, only file names are used for loading.</remarks>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyVersionInfo = VersionShortInfo + ".0.0";

    /// <summary>The full <see cref="CommonConstants.Company"/> version including <see cref="VersionShortInfo"/>, <see cref="BuildVersionInfo"/> and <see cref="RevisionVersionInfo"/>: "1.0.0.36010".</summary>
    [JetBrains.Annotations.NotNull]
    public const string FullVersionInfo = VersionShortInfo + CommonConstants.DotString + BuildVersionInfo + CommonConstants.DotString + RevisionVersionInfo; // The format of the version string is: major. minor. build. revision.

    /// <summary>The full <see cref="CommonConstants.Company"/> semantic version: "1.0.0.36010+2024-10-21-20-0-21".</summary>
    /// <devdoc>https://andrewlock.net/version-vs-versionsuffix-vs-packageversion-what-do-they-all-mean/ http://semver.org .</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string FullSyntonyVersionInfo = FullVersionInfo + "-" + VersionSuffix + "+" + VersionMetadata;

    /// <summary>The full <see cref="CommonConstants.Company"/> version used by <see cref="System.Reflection.AssemblyFileVersionAttribute"/>: "1.0.0.36010".</summary>
    /// <remarks>
    /// The file version is literally the version number exposed by the DLL to the file system. It's the number displayed in Windows explorer, which often matches the AssemblyVersion, but it doesn't have to.
    /// The FileVersion number isn't part of the assembly identity as far as the .NET Framework or runtime are concerned.
    /// </remarks>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyFileVersionInfo = FullVersionInfo;

    /// <summary>The <see cref="CommonConstants.Company"/> file version:"1.0.0.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string CompanyFileVersion = VersionShortInfo + CommonConstants.DotString + BuildVersionInfo + ".0"; // "15.2.3.0"

    /// <summary>The <see cref="CommonConstants.Company"/> package version: "1.0.0.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string PackageVersionInfo = CompanyFileVersion + "-" + VersionSuffix;

    /// <summary>The current marketing information of this version: "".</summary>
    /// <devdoc>Change string if product is in distribution state.</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string MarketingInfo = "";

    /// <summary>The product state.</summary>
    [JetBrains.Annotations.NotNull]
    public const string ProductState = "";

    /// <summary>The marketing version: " 1.0.0.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string MarketingVersion = TargetFileName + CommonConstants.SpaceString + PackageVersionInfo;

    /// <summary>The product version used by <see cref="System.Reflection.AssemblyInformationalVersionAttribute"/>: " 1.0.0.0".</summary>
    /// <remarks>
    /// The Product version of the assembly. This is the version you would use when talking to customers or for display on your website.
    /// The InformationalVersion is a bit of an odd-one out, in that it doesn't need to contain a "traditional" version number per-se, it can contain any text you like.
    /// That makes it generally less useful for programmatic uses, though the value is still displayed in Windows explorer.
    /// </remarks>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyInformationalVersionInfo = MarketingVersion;

    /// <summary>The product name: " 1.0.0.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string Product = MarketingVersion;

    /// <summary>The current pre-release information of this version: "".</summary>
    /// <devdoc>Change string to <see cref="string.Empty"/> or "RTM" if product is in distribution state.</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string PreReleaseVersion = "";

    /// <summary>The metadata information of this version includes the build date and time as UTC: 2024-10-21-20-0-21.</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionMetadata = "2024" + CommonConstants.HyphenString + "10" + CommonConstants.HyphenString + "21" + CommonConstants.HyphenString + "20" + CommonConstants.HyphenString + "0" + CommonConstants.HyphenString + "21";

    /// <summary>The full assembly version extension: ", Version=1.0.0.36010, Culture=neutral, PublicKeyToken=...".</summary>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyVersionExtension = ", Version=" + FullVersionInfo + ", Culture=neutral, PublicKeyToken=" + CommonConstants.SyntonyPublicKeyToken;

    /// <summary>The satellite contract version: "1.0.0.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string SatelliteContractVersionInfo = VersionShortInfo + ".0.0";

    /// <summary>The version suffix without separator: "v1.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionSuffixWithoutSeparator = "v" + VersionShortInfo;

    /// <summary>The version suffix: ".v1.0".</summary>
    [JetBrains.Annotations.NotNull]
    public const string VersionSuffixWithSeparator = CommonConstants.DotString + VersionSuffixWithoutSeparator;

    /// <summary>The full product name info: " © ".</summary>
    [JetBrains.Annotations.NotNull]
    public const string ProductNameInformation = MarketingVersion + CommonConstants.SpaceString + VersionSuffix;

    /// <summary>The neutral resource language: "en-us".</summary>
    [JetBrains.Annotations.NotNull]
    public const string NeutralResourcesLanguage = "en-us";

    /// <summary>The company email: "syntony@aon.at".</summary>
    [JetBrains.Annotations.NotNull]
    public const string CompanyEmail = "syntony@aon.at";

    /// <summary>The company homepage: "https://syntonyblog.wordpress.com/".</summary>
    [JetBrains.Annotations.NotNull]
    public const string CompanyHomepage = "https://syntonyblog.wordpress.com/";

    /// <summary>The repository URL: "https://syntonyblog.wordpress.com/".</summary>
    [JetBrains.Annotations.NotNull]
    [SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "It's a hard coded url")]
    public const string RepositoryUrl = "https://syntonyblog.wordpress.com/";

    /// <summary>The copyright time span: "2024".</summary>
    [JetBrains.Annotations.NotNull]
    public const string CopyrightTimeSpan = "2024";

    /// <summary>The start date: "2019-12-17".</summary>
    [JetBrains.Annotations.NotNull]
    public const string StartDate = "2019-12-17";

    /// <summary>The expiration date: "9999-12-31".</summary>
    [JetBrains.Annotations.NotNull]
    public const string ExpirationDate = "9999-12-31";

    /// <summary>The conditional compilation symbols: "".</summary>
    [JetBrains.Annotations.NotNull]
    public const string DefineConstants = "";

    /// <summary>The default resource location of the assembly used by <see cref="Syntony.Annotations.DefaultResourceLocationAttribute"/>: "".</summary>
    /// <devdoc>The resources file inside the Resources directory.</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string DefaultResourceLocation = "";

    /// <summary>The unique identifier for this module: "fdf6dd00-0000-4000-8000-652ff8ee81cb".</summary>
    [JetBrains.Annotations.NotNull]
    public const string AssemblyGuid = "fdf6dd00-0000-4000-8000-652ff8ee81cb";

    /// <summary>The user secrets Id for this assembly: 312f415f-7cab-4532-9cfb-90d449705d2d.</summary>
    /// <devdoc><a href="https://makolyte.com/csharp-user-secrets-arent-being-loaded-when-youre-using-generateassemblyinfofalse/"/>
    /// The actual secrets associated with this UserSecretsId are stored in a JSON configuration file located in a directory on your machine.
    /// The path to this directory is typically %APPDATA%\Microsoft\UserSecrets\&lt;user_secrets_id&gt;\secrets.json on Windows,
    /// and ~/.microsoft/usersecrets/&lt;user_secrets_id&gt;/secrets.json on Linux and macOS. Replace &lt;user_secrets_id&gt; with your actual UserSecretsId.</devdoc>
    [JetBrains.Annotations.NotNull]
    public const string UserSecretsId = "312f415f-7cab-4532-9cfb-90d449705d2d";

    /// <summary>The number of items compiled for this "" assembly.</summary>
    public const int CompileItems = CommonConstants.InvalidIdentifier;

    /// <summary>The number of EmbeddedResource items compiled for this "" assembly.</summary>
    public const int EmbeddedResourceItems = CommonConstants.InvalidIdentifier;

    /// <summary>The number of Content items compiled for this "" assembly.</summary>
    public const int ContentItems = CommonConstants.InvalidIdentifier;

    /// <summary>The number of Reference items compiled for this "" assembly.</summary>
    public const int ReferenceItems = CommonConstants.InvalidIdentifier;

    /// <summary>The number of ProjectReference items compiled for this "" assembly.</summary>
    public const int ProjectReferenceItems = CommonConstants.InvalidIdentifier;

    /// <summary>The number of PackageReference items compiled for this "" assembly.</summary>
    public const int PackageReferenceItems = CommonConstants.InvalidIdentifier;

    /// <summary>If this assembly uses <PackageReference Include="..."/> for <see cref="Company"/> dependent assemblies inside its build process: "false".</summary>
    public const bool UsePackageReference = false;

    /// <summary>If this assembly uses <UseProjectReference Include="..."/> for <see cref="Company"/> dependent assemblies inside its build process: "false".</summary>
    public const bool UseProjectReference = false;

    /// <summary>Date and time of building this version in UTC: 2024-10-21 20:0:21.0518963.</summary>
    public static readonly DateTimeOffset BuildDateTime = new(new DateTime(2024, 10, 21, 20, 0, 21, DateTimeKind.Utc) + TimeSpan.FromSeconds(0.0518963));

    /// <summary>Date of starting development: 2019-1-7 08:17:05 local time.</summary>
    /// <seealso cref="BuildDateTime"/>
    public static readonly DateTimeOffset StartDevelopmentDate = new(new DateTime(2019, 1, 7, 8, 17, 5, DateTimeKind.Local));

    /// <summary>The full assembly version.</summary>
    [PublicAPI]
    public static readonly Version AssemblyVersion = new(Major, Minor, Build, Revision);

    /// <summary>A hybrid implementation of semantic version that supports semantic versioning as described at <a href="http://semver.org">Semantic Versioning</a>
    /// while not strictly enforcing it to allow older 4-digit versioning schemes to continue working.</summary>
    [PublicAPI]
    public static readonly FrameworkVersion Version = new(AssemblyVersion, PreReleaseVersion, VersionMetadata);
}
