echo off
REM https://learn.microsoft.com/en-us/windows-server/administration/windows-commands/mklink
REM https://ss64.com/nt/mklink.html#:~:text=Create%20a%20symbolic%20link%20to%20a%20directory%20or,Directory%20Junction.%20LinkName%20The%20new%20symbolic%20link%20name.
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\build.root D:\Syntony\Proj\Syntony\build.root
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\Directory.Build.props D:\Syntony\Proj\Syntony\Directory.Build.props
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\Directory.Build.rsp D:\Syntony\Proj\Syntony\Directory.Build.rsp
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\Directory.Build.targets D:\Syntony\Proj\Syntony\Directory.Build.targets
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\.editorconfig D:\Syntony\Proj\Syntony\.editorconfig
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\.gitattributes D:\Syntony\Proj\Syntony\.gitattributes
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\.gitignore D:\Syntony\Proj\Syntony\.gitignore
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\.globalconfig D:\Syntony\Proj\Syntony\.globalconfig
mklink /h D:\Syntony\Proj\Syntony\CommonProperties\.mailmap D:\Syntony\Proj\Syntony\.mailmap
pause
