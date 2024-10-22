// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>22.10.2024 08:29:17</date>
// <information solution="Syntony.Base.Tokenizer" project="SharedSources" framework="{ProjectTargetFramework}" kind="Project Folders">
//     <file type=".cs" created="19.12.2023 13:43:44" modified="22.10.2024 08:29:17" lastAccess="22.10.2024 08:29:17">
//         D:\Syntony\Proj\Syntony\CommonProperties\SharedSources\InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs
//     </file>
//     <lineStatistics total="56" netLines="46" blankLines ="6" codeLines="43" codeRatio="76.92 %" allCommentLines="24" commentLines="6" headerLines="18" documentationLines="0"/>
//     <language>.cs</language>
// </information>
// <workItems>
//     <ATTENTION>add new assemblies, if more packages are developed</ATTENTION>
// </workItems>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

using System.Runtime.CompilerServices;

using Syntony.Constants;

using MetaData = {Company_Metacontent};

// ====================================================================================================================================================================================
// All following assemblies that can use internals from {MSBuildProjectName} --- ATTENTION: add new assemblies, if more packages are developed
// SignAssembly is set to 'true' only in 'Release' and 'PushNuGetPackage' configuration
// ====================================================================================================================================================================================

// ATTENTION: add new assemblies, if more packages are developed
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommonCore + CommonConstants.InternalsVisibleToPublicKey)]

#if !DISTRIBUTION

[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests.Net.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests.Net" + CommonConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests.NetFramework" + CommonConstants.InternalsVisibleToPublicKey)]

#endif