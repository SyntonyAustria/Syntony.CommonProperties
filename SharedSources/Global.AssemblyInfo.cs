// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalAssemblyInfo.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>06.12.2023 12:53:04</date>
// <information solution="ConsoleApp1" project="ConsoleApp1" framework=".NETCoreApp,Version=v8.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="04.12.2023 10:35:00" modified="06.12.2023 12:53:04" lastAccess="06.12.2023 12:53:04">
//         D:\Syntony\Proj\Syntony\ConsoleApp1\Properties\GlobalAssemblyInfo.cs
//     </file>
//     <lineStatistics total="32" netLines="30" blankLines ="2" codeLines="30" codeRatio="93.75 %" allCommentLines="19" commentLines="0" headerLines="19" documentationLines="0"/>
//     <language>C#</language>
//     <codeMetric>
//         <numberOfUsings>3</numberOfUsings>
//         <numberOfAttributes>3</numberOfAttributes>
//     </codeMetric>
// </information>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

#if DEBUG
[assembly: Debuggable(true, true)]
[assembly: SecurityRules(SecurityRuleSet.Level2, SkipVerificationInFullTrust = false)]
#else
[assembly: Debuggable(false, false)]
[assembly: SecurityRules(SecurityRuleSet.Level2, SkipVerificationInFullTrust = true)]
#endif

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
