# Copyright 2018 Cohesity Inc.
#
# Module manifest for 'Cohesity PowerShell Module'

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Cohesity.PowerShell.Core.dll'

# Version number of this module.
ModuleVersion = '1.1.2'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '2f696e30-e0b3-4094-ab8e-7c6ace1d3860'

# Author of this module
Author = 'Cohesity'

# Company or vendor of this module
CompanyName = 'Cohesity'

# Copyright statement for this module
Copyright = '(c) 2019 Cohesity. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Cohesity PowerShell Module provides cmdlets to manage and create workflows using Cohesity DataPlatform.'

# Minimum version of the Windows PowerShell engine required by this module
# PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = '4.5.1'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @('Newtonsoft.Json.dll')

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = @('Cohesity.format.ps1xml')

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Cohesity.PowerShell.psm1')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @(
                      'Download-CohesityFile',
                      'Get-CohesityActiveDirectory',
                      'Get-CohesityCmdletConfig',
                      'Get-CohesityInterfaceGroup',
                      'Get-CohesityOrganization',
                      'Get-CohesityProtectionJobStatus',
                      'Get-CohesityStorageDomain',
                      'Get-CohesityVault',
                      'Get-CohesityVirtualIP',
                      'Get-CohesityVlan',
                      'New-CohesityActiveDirectory',
                      'New-CohesityHypervProtectionJob'
                      'New-CohesityProtectionPolicy',
                      'New-CohesityStorageDomain',
                      'New-CohesityVirtualIP',
                      'New-CohesityVlan',
                      'Recover-CohesityBackupToView',
                      'Register-CohesityProtectionSourceHyperV',
                      'Register-CohesityProtectionSourceIsilon',
                      'Register-CohesityProtectionSourceO365',
                      'Remove-CohesityActiveDirectory'
                      'Remove-CohesityUser',
                      'Remove-CohesityVirtualIP',
                      'Remove-CohesityVlan',
                      'Set-CohesityAlertResolutions',
                      'Set-CohesityCmdletConfig',
                      'Set-CohesityStorageDomain',
                      'Update-CohesityActiveDirectory',
                      'Update-CohesityProtectionJobRun',
                      'Update-CohesityVlan'
                      )

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @('Add-CohesityViewShare',
                    'Connect-CohesityCluster',
                    'Convert-CohesityDateTimeToUsecs'
                    'Convert-CohesityUsecsToDateTime',
                    'Copy-CohesityMSSQLObject',
                    'Copy-CohesityView',
                    'Copy-CohesityVMwareVM',
                    'Disable-CohesityProtectionJob',
                    'Disconnect-CohesityCluster',
                    'Dismount-CohesityVolume',
                    'Enable-CohesityProtectionJob',
                    'Find-CohesityFilesForRestore',
                    'Find-CohesityObjectsForRestore',
                    'Get-CohesityAlert',
                    'Get-CohesityAlertResolution',
                    'Get-CohesityAuditLog',
                    'Get-CohesityCluster',
                    'Get-CohesityClusterConfiguration',
                    'Get-CohesityClusterPartition',
                    'Get-CohesityMSSQLObject',
                    'Get-CohesityPhysicalAgent',
                    'Get-CohesityPrivilege',
                    'Get-CohesityProtectionJob',
                    'Get-CohesityProtectionJobRun',
                    'Get-CohesityProtectionPolicy',
                    'Get-CohesityProtectionSource',
                    'Get-CohesityProtectionSourceObject',
                    'Get-CohesityRemoteCluster',
                    'Get-CohesityRestoreTask',
                    'Get-CohesityRole',
                    'Get-CohesityStorageDomain',
                    'Get-CohesityUser',
                    'Get-CohesityView',
                    'Get-CohesityViewShare',
                    'Get-CohesityVMwareVM',
                    'Mount-CohesityVolume',
                    'New-CohesityProtectionJob',
                    'New-CohesityReplicationEncryptionKey',
                    'New-CohesityUser',
                    'New-CohesityView',
                    'Register-CohesityProtectionSourceAcropolis',
                    'Register-CohesityProtectionSourceHyperV',
                    'Register-CohesityProtectionSourceMSSQL',
                    'Register-CohesityProtectionSourceNetApp',
                    'Register-CohesityProtectionSourceNFS',
                    'Register-CohesityProtectionSourcePhysical',
                    'Register-CohesityProtectionSourcePureStorageArray',
                    'Register-CohesityProtectionSourceSMB',
                    'Register-CohesityProtectionSourceVMware',
                    'Register-CohesityRemoteCluster',
                    'Remove-CohesityClone',
                    'Remove-CohesityProtectionJob',
                    'Remove-CohesityProtectionPolicy',
                    'Remove-CohesitySnapshot',
                    'Remove-CohesityView',
                    'Remove-CohesityViewShare',
                    'Restore-CohesityAcropolisVM',
                    'Restore-CohesityFile',
                    'Restore-CohesityHyperVVM',
                    'Restore-CohesityMSSQLObject',
                    'Restore-CohesityVMwareVM',
                    'Resume-CohesityProtectionJob',
                    'Set-CohesityClusterConfiguration',
                    'Set-CohesityProtectionJob',
                    'Set-CohesityProtectionPolicy',
                    'Set-CohesityRemoteCluster',
                    'Set-CohesitySnapshotRetention',
                    'Set-CohesityStorageDomain',
                    'Set-CohesityView',
                    'Start-CohesityProtectionJob',
                    'Stop-CohesityProtectionJob',
                    'Stop-CohesityRestoreTask',
                    'Suspend-CohesityProtectionJob',
                    'Unregister-CohesityApplicationServer',
                    'Unregister-CohesityProtectionSource',
                    'Unregister-CohesityRemoteCluster',
                    'Update-CohesityPhysicalAgent',
                    'Update-CohesityProtectionSource'
                    )

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = @('Cohesity', 'DataPlatform', 'Backup', 'Recovery', 'DevOps', 'DataProtection')

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/cohesity/cohesity-powershell-module/blob/master/LICENSE'

        # A URL to the main website for this project.
        ProjectUri = 'https://cohesity.github.io/cohesity-powershell-module'

        # A URL to an icon representing this module.
        IconUri = 'https://i.imgur.com/ZbvCiaC.png'

		#Prerelease = 'alpha2'

        # ReleaseNotes of this module
        ReleaseNotes = 'https://cohesity.github.io/cohesity-powershell-module'

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
