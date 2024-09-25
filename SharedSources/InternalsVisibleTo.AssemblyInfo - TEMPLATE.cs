// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - Josef</author>
// <email>syntony@aon.at</email>
// <date>25.09.2024 13:16:33</date>
// <information solution="Syntony.Common.Core.Basics" project="SharedSources" framework="{ProjectTargetFramework}" kind="Project Folders">
//     <file type=".cs" created="19.12.2023 13:43:44" modified="25.09.2024 13:16:33" lastAccess="25.09.2024 13:16:33">
//         D:\Syntony\Proj\Syntony\CommonProperties\SharedSources\InternalsVisibleTo.AssemblyInfo - TEMPLATE.cs
//     </file>
//     <lineStatistics total="55" netLines="49" blankLines ="6" codeLines="40" codeRatio="72.73 %" allCommentLines="27" commentLines="9" headerLines="18" documentationLines="0"/>
//     <language>.cs</language>
// </information>
// <workItems>
//     <ATTENTION>add new assemblies, if more packages are developed</ATTENTION>
// </workItems>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#define TRUE

using System.Runtime.CompilerServices;

using Syntony;

using MetaData = {Company_Metacontent};

// ====================================================================================================================================================================================
// All following assemblies that can use internals from {MSBuildProjectName} --- ATTENTION: add new assemblies, if more packages are developed
// SignAssembly is set to 'true' only in 'Release' and 'PushNuGetPackage' configuration
// ====================================================================================================================================================================================

// ATTENTION: add new assemblies, if more packages are developed
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommonCore + FrameworkConstants.InternalsVisibleToPublicKey)]
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCommon + FrameworkConstants.InternalsVisibleToPublicKey)]
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyCore + FrameworkConstants.InternalsVisibleToPublicKey)]
// [assembly: InternalsVisibleTo(MetaData.InternalSyntonyTestsBase + FrameworkConstants.InternalsVisibleToPublicKey)]

#if !DISTRIBUTION

[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".Tests.Net.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".UnitTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".PerformanceTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".SecurityTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".BenchmarkTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests.Net" + FrameworkConstants.InternalsVisibleToPublicKey)]
[assembly: InternalsVisibleTo(MetaData.TargetName + ".QuickBenchmarkTests.NetFramework" + FrameworkConstants.InternalsVisibleToPublicKey)]

#endif
