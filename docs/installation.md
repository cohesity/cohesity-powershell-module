# Installation

You can install Cohesity PowerShell Module directly from the [PowerShell Gallery](https://www.powershellgallery.com/packages?q=cohesity).

* For `PowerShell Core` (Windows, Mac OS, Linux)

  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```
* For `Windows PowerShell` (Windows Only)

  ```powershell
  Install-Module -Name Cohesity.PowerShell
  ```

---

  > **Tip:** For installing a pre-release version, please use the `-AllowPrerelease` option as below.

* For `PowerShell Core` (Windows, Mac OS, Linux)   
  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core -AllowPrerelease
   ```

* For `Windows PowerShell` (Windows Only)
  ```powershell
  Install-Module -Name Cohesity.PowerShell -AllowPrerelease
   ```

  > **Note:** If you get this error `A parameter cannot be found that matches parameter name 'AllowPrerelease'`, then please upgrade the version of `PowershellGet`,`PackageManagement` modules on your system by running the command below as Administrator.

  ```powershell
  Install-Module -Name PowershellGet,PackageManagement -Force -Confirm:$false -Verbose -AllowClobber -SkipPublisherCheck
  ```
