# Cohesity PowerShell Module

![](docs/assets/cohesity_powershell.png)

## Overview
[![License: Apache2](https://img.shields.io/hexpm/l/plug.svg?style=flat-square)](https://github.com/cohesity/cohesity-powershell-module/blob/master/LICENSE)

This project provides a PowerShell Module for interacting with the [Cohesity DataPlatform](https://www.cohesity.com/products/data-platform). It includes cmdlets useful for automating common tasks and orchestrating workflows in your environment. This PowerShell module can be used on Windows, Linux or Mac OS.

## Pre-requisites

* Requires a Cohesity Cluster running version `6.0` or higher.
* On Windows, both Windows PowerShell and PowerShell Core are supported.
   * For Windows PowerShell, requires version `5.1` or higher.
   * For PowerShell Core, requires `6.0` or higher.
* On Linux and Mac OS, requires PowerShell Core `6.0` or higher.

## Installation

You can install Cohesity PowerShell Module directly from the [PowerShell Gallery](https://www.powershellgallery.com/items?q=cohesity).

* For Windows PowerShell (Windows only)
```
  Install-Module -Name Cohesity.PowerShell
```

* For PowerShell Core (Windows, Mac OS or Linux)
```
  Install-Module -Name Cohesity.PowerShell.Core
```

## Documentation

* [Online reference for Cohesity PowerShell Cmdlets](https://cohesity.github.io/cohesity-powershell-module).
* You can also use `Get-Help <cmdlet>` for offline help.

## Suggestions and Feedback

We would love to hear from you. Please send your suggestions and feedback to: [cohesity-api-sdks@cohesity.com](mailto:cohesity-api-sdks@cohesity.com)

## License

Apache 2.0
