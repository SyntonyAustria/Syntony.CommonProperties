// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs" company="Syntony">
//     {Copyright}
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>25.12.2023 11:11:13</date>
// <information solution="Syntony.CommonProperties" project="SharedSources" framework="{ProjectTargetFramework}" kind="Project Folders">
//     <file type=".cs" created="19.12.2023 13:43:44" modified="25.12.2023 11:11:13" lastAccess="25.12.2023 11:11:13">
//         D:\Syntony\Proj\Syntony\CommonProperties\SharedSources\InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs
//     </file>
//     <lineStatistics total="66" netLines="62" blankLines ="4" codeLines="57" codeRatio="86.36 %" allCommentLines="20" commentLines="5" headerLines="15" documentationLines="0"/>
//     <language>.cs</language>
// </information>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

// ReSharper disable FilesNotPartOfProjectWarning
// ====================================================================================================================================================================================
// All assemblies that can use internals from {MSBuildProjectName} --- ATTENTION: add new assemblies, if more packages are developed
// ====================================================================================================================================================================================
// like [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommon + FrameworkConstants.InternalsVisibleToPublicKey)]

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

#endif
#endif
