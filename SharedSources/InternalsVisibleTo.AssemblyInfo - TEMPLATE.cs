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
//     <lineStatistics total="72" netLines="67" blankLines ="5" codeLines="62" codeRatio="86.11 %" allCommentLines="24" commentLines="5" headerLines="19" documentationLines="0"/>
//     <language>C#</language>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfAttributes>18</numberOfAttributes>
//     </codeMetric>
// </information>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

// ReSharper disable FilesNotPartOfProjectWarning
using System.Runtime.CompilerServices;

// ====================================================================================================================================================================================
// All assemblies that can use internals from {MSBuildProjectName} --- ATTENTION: add new assemblies, if more packages are developed
// ====================================================================================================================================================================================
// like [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommon + SyntonyConstants.InternalsVisibleToPublicKey)]

#if !DISTRIBUTION

#if DEBUG
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
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.Tests.Net.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.UnitTests.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.PerformanceTests.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.SecurityTests.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.BenchmarkTests.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.Net" + SyntonyConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo("{MSBuildProjectName}.QuickBenchmarkTests.NetFramework" + SyntonyConstants.InternalsVisibleToPublicKey)]

#endif
#endif
