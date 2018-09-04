# How to use

* After installation, you can import Cohesity PowerShell Module in your scripts as below

  ```powershell
  Get-Module -ListAvailable -Name Cohesity* | Import-Module
  ```

* To get a list of available Cohesity Cmdlets

  ```powershell
  Get-Command *Cohesity*
  ```
  
* To get brief help for available Cohesity Cmdlets

  ```powershell
  Get-Help *Cohesity* | ft -Property Name, Synopsis
  ```

* To get detailed help for a specific Cohesity Cmdlet

  ```powershell
  Get-Help <cmdlet-name> -Full
  ```
  
* Run `Connect-CohesityCluster` cmdlet before using any other Cmdlets

  ```powershell
  Connect-CohesityCluster -Server cohesity-cluster.example.com -Credential (Get-Credential)
  ```
  You can also export and persist the credential securely using [PSCredentialTools](https://www.powershellgallery.com/packages/PSCredentialTools/1.0.1) and then import it in your scripts.


* You are all set! Now explore other Cohesity Cmdlets such as

  ```powershell
  Get-CohesityProtectionJob
  ```
