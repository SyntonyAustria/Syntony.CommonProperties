// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.AssemblyInfo.cs" company="Syntony® / Ing. Josef Hahnl, MBA">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>21.10.2024 13:36:38</date>
// <information solution="Syntony.Base.Tokenizer" project="Syntony.Base.Tokenizer" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="21.10.2024 13:36:15" modified="21.10.2024 13:36:38" lastAccess="21.10.2024 13:36:38">
//         D:\Syntony\Proj\Syntony\Base\Source\Syntony.Base.Tokenizer\Source\Properties\Global.AssemblyInfo.cs
//     </file>
//     <lineStatistics total="32" netLines="30" blankLines ="2" codeLines="30" codeRatio="93.75 %" allCommentLines="19" commentLines="0" headerLines="19" documentationLines="0"/>
//     <language>C#</language>
//     <codeMetric>
//         <numberOfUsings>3</numberOfUsings>
//         <numberOfAttributes>3</numberOfAttributes>
//     </codeMetric>
// </information>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
