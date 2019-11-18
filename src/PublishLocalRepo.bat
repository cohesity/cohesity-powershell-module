set localRepoPath=C:\workspace\MyServer\MyServer\Packages\
rmdir /Q /S  %localRepoPath%Cohesity.Powershell
call c:\Windows\System32\xcopy.exe /E /Q /I .\Cohesity.Powershell\bin\Release\Cohesity.Powershell %localRepoPath%Cohesity.Powershell