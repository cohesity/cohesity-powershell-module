# Installation

You can install Cohesity PowerShell Module directly from the [PowerShell Gallery](https://www.powershellgallery.com/items?q=cohesity).

* For Windows PowerShell (Windows Only)

  ```text
  Install-Module -Name Cohesity.PowerShell
  ```

* For PowerShell Core (Windows, Mac OS, Linux)

  ```text
  Install-Module -Name Cohesity.PowerShell.Core
  ```

---

* For installing a pre-release version, please use the `-AllowPrerelease` option as below.


  ```text
  Install-Module -Name Cohesity.PowerShell -AllowPrerelease
   ```
   
  ```text
  Install-Module -Name Cohesity.PowerShell.Core -AllowPrerelease
   ```

  Note: If you get this error _"A parameter cannot be found that matches parameter name 'AllowPrerelease'"_, then please upgrade the version of PowershellGet module on your system by running the command below.
  ```text
  Install-Module -Name PowershellGet,PackageManagement -force -confirm:$false -verbose
  ```
