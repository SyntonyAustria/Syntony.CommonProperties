// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="{Company}">
//     {Copyright}
// </copyright>
// <author>{Author}</author>
// <email>{AuthorEmail}</email>
// <date>{Now}</date>
// <information solution="{SolutionName}" project="{MSBuildProjectName}" framework="{TargetFramework}" kind="(C# - csproj)">
//     <file type=".cs" created="{Now}" modified="{Now}" lastAccess="{Now}">
//         {DestinationFile}
//     </file>
//     <lineStatistics total="85" netLines="74" blankLines ="11" codeLines="68" codeRatio="80.00 %" allCommentLines="25" commentLines="6" headerLines="19" documentationLines="0"/>
//     <language>C#</language>
//     <codeMetric>
//         <numberOfUsings>8</numberOfUsings>
//         <numberOfAttributes>32</numberOfAttributes>
//     </codeMetric>
// </information>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

// ReSharper disable FilesNotPartOfProjectWarning
using Syntony;
using Syntony.Annotations;

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MetaData = {SyntonyCommonCoreMetacontent};

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: AssemblyVersion(MetaData.AssemblyVersionInfo)]
[assembly: AssemblyFileVersion(MetaData.AssemblyFileVersionInfo)]
[assembly: SatelliteContractVersion(MetaData.SatelliteContractVersionInfo)]
[assembly: AssemblyInformationalVersion(MetaData.AssemblyInformationalVersionInfo)]
[assembly: ComCompatibleVersion(MetaData.Major, MetaData.Minor, 0, 0)]

[assembly: AssemblyCulture(MetaData.AssemblyCulture)]
[assembly: NeutralResourcesLanguage(MetaData.NeutralResourcesLanguage, UltimateResourceFallbackLocation.MainAssembly)]
[assembly: DefaultResourceLocation(MetaData.DefaultResourceLocation)]

[assembly: AssemblyConfiguration(MetaData.Configuration)]
[assembly: RootNamespace(MetaData.RootNamespace)]
[assembly: AssemblyRelease(MetaData.ReleaseType)]

[assembly: AssemblyCompany(MetaData.Company)]
[assembly: AssemblyCopyright(MetaData.Copyright)]
[assembly: AssemblyTrademark(MetaData.Trademark)]
[assembly: AssemblyTitle(MetaData.Title)]
[assembly: AssemblyDescription(MetaData.Description)]
[assembly: AssemblyProduct(MetaData.Product)]

[assembly: AssemblyDefaultAlias(MetaData.Title + " " + MetaData.InformationalVersion)]
[assembly: Guid(MetaData.AssemblyGuid)]
[assembly: AssemblyMetadata(nameof(MetaData.RepositoryUrl), MetaData.RepositoryUrl)]

// stigmatize this assembly as a Syntony file.
[assembly:
    AssemblySyntony(
        SyntonyAssemblyApplicationScopes.Syntony | SyntonyAssemblyApplicationScopes.Framework,
        MetaData.TargetFileName,
        MetaData.StartDate,
        MetaData.ExpirationDate,
        SyntonyConstants.DefaultUpdateUrl,
        SyntonyConstants.DefaultUpdateLinkText,
        MetaData.PreReleaseVersion,
        MetaData.VersionMetadata,
        Active = true,
        Identifier = SyntonyConstants.DefaultIdentifier,
        PackageGuidValue = MetaData.AssemblyGuid,
        BuildDate = MetaData.BuildDateTimeString,
        DateTimeInfo = MetaData.BuildDateTimeString,
        DateTimeFormat = MetaData.BuildDateTimeFormat,
        Author = MetaData.Author,
        Description = MetaData.Description,
        DefaultBuildConfigurationState = MetaData.BuildConfigurationState)]

// ====================================================================================================================================================================================
// All assemblies that can use internals from this Application
// ====================================================================================================================================================================================
// [assembly: InternalsVisibleTo(MetaData.TargetName + SyntonyConstants.DotString + SyntonyTestsConstants.DefaultUnitTestsModuleName + SyntonyConstants.InternalsVisibleToPublicKey)]
