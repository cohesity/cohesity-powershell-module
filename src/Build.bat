git pull
call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat"
dotnet clean --configuration Release
dotnet build --configuration Release


rmdir /Q /S  .\Cohesity.Powershell\bin\Release\Cohesity.Powershell\
rmdir /Q /S  .\Cohesity.Powershell\bin\Release\Cohesity.Powershell.Core\
call c:\Windows\System32\xcopy.exe /E /Q /I .\Cohesity.Powershell\bin\Release\net451 .\Cohesity.Powershell\bin\Release\Cohesity.Powershell
call c:\Windows\System32\xcopy.exe /E /Q /I .\Cohesity.Powershell\bin\Release\netcoreapp2.0 .\Cohesity.Powershell\bin\Release\Cohesity.Powershell.Core

TIMEOUT /T 10