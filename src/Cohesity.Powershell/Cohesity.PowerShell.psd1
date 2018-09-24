# Copyright 2018 Cohesity Inc.
#
# Module manifest for 'Cohesity PowerShell Module'

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Cohesity.PowerShell.dll'

# Version number of this module.
ModuleVersion = '1.0.1'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '10ae6fbb-808d-4194-b134-5edf0d22572f'

# Author of this module
Author = 'Cohesity'

# Company or vendor of this module
CompanyName = 'Cohesity'

# Copyright statement for this module
Copyright = '(c) 2018 Cohesity. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Cohesity PowerShell Module provides cmdlets to manage and create workflows using Cohesity Data Platform.'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

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
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @('Get-CohesityAlert',
					'Get-CohesityAlertResolution',
					'Get-CohesityAuditLog',
					'Connect-CohesityCluster',
                    'Disconnect-CohesityCluster',
					'Get-CohesityCluster',
					'Get-CohesityClusterConfiguration',
					'Get-CohesityClusterPartition',
					'Set-CohesityClusterConfiguration',
					'Get-CohesityPrivilege',
					'Get-CohesityProtectionJob',
					'New-CohesityProtectionJob',
					'Remove-CohesityProtectionJob',
					'Resume-CohesityProtectionJob',
					'Set-CohesityProtectionJob',
					'Start-CohesityProtectionJob',
					'Suspend-CohesityProtectionJob',
					'Get-CohesityProtectionJobRun',
					'Stop-CohesityProtectionJobRun',
					'Get-CohesityProtectionPolicy',
					'Set-CohesityProtectionPolicy',
					'Remove-CohesityProtectionPolicy',
					'Get-CohesityProtectionSource',
					'Get-CohesityProtectionSourceObject',
					'Get-CohesityVMwareVM',
					'Register-CohesityProtectionSourceAcropolis',
					'Register-CohesityProtectionSourceHyperV',
					'Register-CohesityProtectionSourceIsilon',
					'Register-CohesityProtectionSourceNetApp',
					'Register-CohesityProtectionSourceNFS',
					'Register-CohesityProtectionSourceSMB',
					'Register-CohesityProtectionSourcePhysical',
					'Register-CohesityProtectionSourceVMware',
					'Update-CohesityProtectionSource',
					'Get-CohesityPhysicalAgent',
					'Update-CohesityPhysicalAgent',
					'Find-CohesityFilesForRestore',
					'Get-CohesityRestoreTask',
					'Restore-CohesityVMwareVM',
					'Stop-CohesityRestoreTask',
					'Get-CohesityStorageDomain',
					'Set-CohesityStorageDomain',
					'Get-CohesityView',
					'Remove-CohesityView',
					'Convert-CohesityUsecsToDateTime',
					'Convert-CohesityDateTimeToUsecs'
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
        ProjectUri = 'https://github.com/cohesity/cohesity-powershell-module'

        # A URL to an icon representing this module.
        IconUri = 'https://i.imgur.com/ZbvCiaC.png'
 
		Prerelease = 'alpha2'
		
        # ReleaseNotes of this module
        ReleaseNotes = 'https://cohesity.github.io/cohesity-powershell-module'

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

