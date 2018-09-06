# Installation

You can install Cohesity PowerShell Module directly from the [PowerShell Gallery](https://www.powershellgallery.com/items?q=cohesity).

* For Windows PowerShell (Windows Only)

  ```powershell
  Install-Module -Name Cohesity.PowerShell
  ```

* For PowerShell Core (Windows, Mac OS, Linux)

  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```

---

  > **Tip:** For installing a pre-release version, please use the `-AllowPrerelease` option as below.


  ```powershell
  Install-Module -Name Cohesity.PowerShell -AllowPrerelease
   ```
   
  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core -AllowPrerelease
   ```

  > **Note:** If you get this error "A parameter cannot be found that matches parameter name 'AllowPrerelease'", then please upgrade the version of `PowershellGet` module on your system by running the command below.

  ```powershell
  Install-Module -Name PowershellGet,PackageManagement -Force -Confirm:$false -Verbose -AllowClobber
  ```
