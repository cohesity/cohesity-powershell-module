# Setup

## Steps to install

You can install Cohesity PowerShell Module directly using the [PowerShell Gallery](https://www.powershellgallery.com/packages?q=cohesity).

  > **Tip:** Please follow the steps based on the flavor of PowerShell that you are running.
  * If installing on `MacOS` and `Linux` you must use the steps for `PowerShell Core`.
  * If installing on `Windows` you should use the steps for `Windows PowerShell`, unless you are running `PowerShell Core`.
<!-- tabs:start -->

#### ** PowerShell Core **

  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```

#### ** Windows PowerShell **

  ```powershell
  Install-Module -Name Cohesity.PowerShell
  ```

<!-- tabs:end -->

  > **Note:** If you are running PowerShell as a user without elevated privileges (non-admin user), you may need to add `-Scope CurrentUser` to the commands below. In some cases, you may also need to run `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser` to set the execution policy that allows import of the module.

## Steps to upgrade

> **Tip:** It's recommended to always use the latest version of the Cohesity PowerShell Module to get the new features and bug-fixes.

You can uninstall the previous version of the Cohesity PowerShell Module using the uninstall steps mentioned below and then install the new version.

Alternatively, you can also use the steps below to upgrade to the latest version of the module. Note that using `Update-Module` can cause multiple versions of this module on your system. You may later need to remove older versions of the module manually.

<!-- tabs:start -->

#### ** PowerShell Core **

  ```powershell
  Update-Module -Name Cohesity.PowerShell.Core
  ```

#### ** Windows PowerShell **

  ```powershell
  Update-Module -Name Cohesity.PowerShell
  ```

<!-- tabs:end -->

## Steps to uninstall

<!-- tabs:start -->

#### ** PowerShell Core **

  ```powershell
  Uninstall-Module -Name Cohesity.PowerShell.Core
  ```

#### ** Windows PowerShell **

  ```powershell
  Uninstall-Module -Name Cohesity.PowerShell
  ```

<!-- tabs:end -->
