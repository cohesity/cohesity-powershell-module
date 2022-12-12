@REM git pull
call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat"
dotnet clean --configuration Release
dotnet build --configuration Release


rmdir /Q /S  .\Cohesity.Powershell\bin\Release\Cohesity.PowerShell\
rmdir /Q /S  .\Cohesity.Powershell\bin\Release\Cohesity.PowerShell.Core\
call c:\Windows\System32\xcopy.exe /E /Q /I .\Cohesity.Powershell\bin\Release\net451 .\Cohesity.Powershell\bin\Release\Cohesity.PowerShell
call c:\Windows\System32\xcopy.exe /E /Q /I .\Cohesity.Powershell\bin\Release\netcoreapp2.0 .\Cohesity.Powershell\bin\Release\Cohesity.PowerShell.Core
