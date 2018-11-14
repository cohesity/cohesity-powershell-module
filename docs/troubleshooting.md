# Troubleshooting

### Issue:
#### Failed to Connect to Cohesity Cluster
```
Connect-CohesityCluster : Failed to connect to the Cohesity Cluster
The SSL connection could not be established, see inner exception.
The remote certificate is invalid according to the validation procedure.
At line:1 char:1
+ Connect-CohesityCluster -Server 192.2.68.1 -Credential (Get-Credenti ...
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
+ CategoryInfo          : NotSpecified: (:) [Connect-CohesityCluster], Exception
+ FullyQualifiedErrorId : System.Exception,Cohesity.Powershell.Cmdlets.Cluster.ConnectCohesityCluster
```

### Solution:
This error may be seen on `MacOS` or `Linux` if you have inadvertently installed `Cohesity.PowerShell` instead of `Cohesity.PowerShell.Core`.
You can run `Get-Module -ListAvailable` to verify which flavor of Cohesity PowerShell Module is installed.
To correct this error please uninstall `Cohesity.PowerShell` and install `Cohesity.PowerShell.Core` instead.
  ```powershell
  Uninstall-Module -Name Cohesity.PowerShell
  ```
  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```
  