# How to use

* After installation, you can import Cohesity PowerShell Module in your scripts as below:

  ```text
  Get-Module -ListAvailable -Name Cohesity* | Import-Module
  ```

* To get a list of available Cohesity Cmdlets

  ```text
  Get-Command -Module Cohesity*
  ```
  
* To get brief help for available Cohesity Cmdlets

  ```text
  Get-Help *Cohesity*
  ```

* To get detailed help for a specific Cohesity Cmdlet
  ```text
  Get-Help <cmdlet-name> -Full
  ```
  
* Run `Connect-CohesityCluster` cmdlet before using any other Cmdlets.

  ```text
  Connect-CohesityCluster -Server cohesity-cluster.example.com -Credential (Get-Credential)
  ```
  You can also export and persist the credential securely using [PSCredentialTools](https://www.powershellgallery.com/packages/PSCredentialTools/1.0.1)
  and then import it in your scripts.
  
  
 * All set! Now try out other Cohesity Cmdlets such as: Getting a list of Protection Jobs
   ```text
   Get-CohesityProtectionJob
   ```
