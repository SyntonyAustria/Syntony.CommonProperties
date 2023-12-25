// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="InternalsVisibleTo.AssemblyInfo.cs" company="{Company}">
//     {Copyright}
// </copyright>
// <author>{Author}</author>
// <email>{AuthorEmail}</email>
// <date>{Now}</date>
// <information solution="{SolutionName}" project="{MSBuildProjectName}" framework="{TargetFramework}" kind="(C# - csproj)">
//     <file type=".cs" created="{Now}" modified="{Now}" lastAccess="{Now}">
//         {DestinationFile}
//     </file>
//     <lineStatistics total="92" netLines="79" blankLines ="13" codeLines="73" codeRatio="79.35 %" allCommentLines="28" commentLines="6" headerLines="22" documentationLines="0"/>
//     <language>C#</language>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfAttributes>18</numberOfAttributes>
//     </codeMetric>
// </information>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

using System.Runtime.CompilerServices;

#if !DEBUG
using Syntony;
#endif

// using MetaData = {Company_Metacontent};
//
// ====================================================================================================================================================================================
// All following assemblies that can use internals from {MSBuildProjectName} --- ATTENTION: add new assemblies, if more packages are developed
// SignAssembly is set to 'true' only in 'Release' and 'PushNuGetPackage' configuration
// ====================================================================================================================================================================================

#if DEBUG

// ATTENTION: add new assemblies, if more packages are developed
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommon)]

[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net.NetFramework")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.NetFramework")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.NetFramework")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.NetFramework")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.NetFramework")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.Net")]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.NetFramework")]

#else      

// ATTENTION: add new assemblies, if more packages are developed
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommon + FrameworkConstants.InternalsVisibleToPublicKey)]

// #if !DISTRIBUTION

[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]

// #endif

#endif
