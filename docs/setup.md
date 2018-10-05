# Setup

## Steps to install

You can install Cohesity PowerShell Module directly from the [PowerShell Gallery](https://www.powershellgallery.com/packages?q=cohesity).

  > **Note:** If you are running PowerShell as a user without elevated privileges (non-admin user), you may need to add `-Scope CurrentUser` to the command below. In some cases, you may also need to run `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser` to set the execution policy that allows import of the module.

* For `PowerShell Core` (Windows, Mac OS, Linux)

  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```
* For `Windows PowerShell` (Windows Only)

  ```powershell
  Install-Module -Name Cohesity.PowerShell
  ```

## Steps to upgrade

It's recommended to always use the latest version of the Cohesity PowerShell Module to get the new features and bug-fixes.

You can uninstall the previous version of the Cohesity PowerShell Module using the uninstall steps mentioned below and then install the new version.

Alternatively, you can also use the steps below to upgrade to the latest version of the module.

* For `PowerShell Core` (Windows, Mac OS, Linux)

  ```powershell
  Update-Module -Name Cohesity.PowerShell.Core
  ```
* For `Windows PowerShell` (Windows Only)

  ```powershell
  Update-Module -Name Cohesity.PowerShell
  ```
  

## Steps to uninstall

* For `PowerShell Core` (Windows, Mac OS, Linux)

  ```powershell
  Uninstall-Module -Name Cohesity.PowerShell.Core
  ```
* For `Windows PowerShell` (Windows Only)

  ```powershell
  Uninstall-Module -Name Cohesity.PowerShell
  ```
