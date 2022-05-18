<!--
  Title: Cohesity PowerShell Module
  Description: This project provides a PowerShell Module for interacting with the Cohesity DataPlatform
  Author: Cohesity Inc
  -->
# Cohesity PowerShell Module
[![License: Apache2](https://img.shields.io/hexpm/l/plug.svg)](https://github.com/cohesity/cohesity-powershell-module/blob/master/LICENSE)
[![GitHub release](https://img.shields.io/github/release/cohesity/cohesity-powershell-module.svg)](https://github.com/cohesity/cohesity-powershell-module/releases/)
{ ![PowerShell](https://img.shields.io/powershellgallery/dt/cohesity.powershell) + 
![PowerShell Core](https://img.shields.io/powershellgallery/dt/cohesity.powershell.core) }
![Maintenance](https://img.shields.io/maintenance/yes/2022)


![](docs/assets/images/cohesity_powershell.png)

## Overview

This project provides a PowerShell Module for interacting with the [Cohesity DataPlatform](https://www.cohesity.com/products/data-platform). It includes cmdlets useful for automating common tasks and orchestrating workflows in your environment. This PowerShell module can be used on Windows, Linux and Mac OS.

## Table of contents :scroll:

 - [Getting Started](#get-started)
 - [Samples](#examples)
 - [Documentation](#doc)
 - [How can you contribute](#contribute)
 - [Installation tips](#tips)
 - [Suggestions and Feedback](#suggest)
 
 

## <a name="get-started"></a> Let's get started :hammer_and_pick:

### Pre-req

The pre-requisites for using the Cohesity PowerShell Module are as below:

* Cohesity Cluster running software version `6.0` or higher and Powershell 5.1 or higher. For more details refer [this](./docs/pre-requisites.md) link

### Online installation

You can install Cohesity PowerShell Module directly using the [PowerShell Gallery](https://www.powershellgallery.com/packages?q=cohesity).

#### ** PowerShell Core (`MacOS` and `Linux`) **

  ```powershell
  Install-Module -Name Cohesity.PowerShell.Core
  ```

#### ** Windows PowerShell (`Windows`) **

  ```powershell
  Install-Module -Name Cohesity.PowerShell
  ```

  ** Note: Windows with powershell version 7 or higher supports only Powershell Core

## <a name="examples"></a> Some samples to get you going :bulb:

* Refer [`samples`](./samples) folder to find more examples.
* More samples can be found [here](https://cohesity.github.io/cohesity-powershell-module/#/samples/list-protectionJob-start-times) under Examples section

## <a name="doc"></a> Documentation :book:

* [Online reference for Cohesity PowerShell Cmdlets](https://cohesity.github.io/cohesity-powershell-module/#/cmdlets-reference/connect-cohesitycluster).
* All the commands have an inline example on how to use the command


## <a name="contribute"></a> Contribute :handshake:

* [Refer our contribution guideline](./CONTRIBUTING.md).

## <a name="tips"></a> Installation tips 

<!-- tabs:end -->

  If you are running PowerShell as a user without elevated privileges (non-admin user), you may need to add `-Scope CurrentUser` to these commands. In some cases, you may also need to run `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser` to set the execution policy that allows import of the module.
  
### Offline installation

* Download the offline package (.zip) from [GitHub release page](https://github.com/cohesity/cohesity-powershell-module/releases)
  * For windows, use `Cohesity.PowerShell.zip`
  * For linux and MacOS, use `Cohesity.PowerShell.Core.zip`
* Copy over this zip file to the target machine
* Unzip the contents of the zip file to one of the directory paths mentioned in the output of `$env:PSModulePath` on the target machine.

### Steps to upgrade

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

### Steps to uninstall

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


## <a name="suggest"></a> Suggestions and Feedback :raised_hand:

We would love to hear from you. Please send your suggestions and feedback to: [cohesity-api-sdks@cohesity.com](mailto:cohesity-api-sdks@cohesity.com)

## License :shield:

Apache 2.0
