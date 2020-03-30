<#

Restore-VMAttributes - Restores VM custom attributes from a previous backup
Usage: .\Restore-VMAttributes.ps1 -vcenter 10.2.145.20 -sourcevm win2k16-srv1 -targetvm win2k16-srv2 -credential (Get-Credential) -filepath "c:\out.json" -EnableVerbose

#>

# For Windows PowerShell
#Requires -Version 5.1
#Requires -Module VMware.VimAutomation.Core
#Requires -PSEdition Desktop

[CmdletBinding()]
param (
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [string]$vcenter, # vCenter Server to connect to (DNS name or IP)
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [System.Management.Automation.PSCredential]$credential, # vCenter credentials
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [string]$sourcevm, # Name of the VM that was backed up
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [string]$targetvm, # Name of the VM to restore the custom attributes to
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [string]$filepath, # Read input from this file
    [Parameter(Mandatory = $True)][ValidateNotNullOrEmpty()]
    [switch]$EnableVerbose
)

Begin {
    if ($EnableVerbose) {
        $oldverbose = $VerbosePreference
        $VerbosePreference = "Continue"
    }
}

Process {
    # Read from the back file
    $vmObjects = Get-Content $filepath | ConvertFrom-Json

    # Check if the source vm is present in the backup file
    if($vmObjects.Name -notcontains $sourcevm) {
        throw "Can't find the source vm: $($sourcevm) in the backup file"
    }

    # Connect to vCenter and check if the target vm is present in vCenter
    Connect-VIServer -server $vcenter -Credential $credential | Out-Null
    $targetVmObject = Get-VM -Name $targetvm
    if(!$targetVmObject)
    {
        throw "Can't find the target vm: $($targetvm) in the vcenter"
    }

    # Read the source vm's attributes from backup file and set attributes on the target vm in vCenter
    $vmObjects | ?{$_.Name -ieq $sourcevm} | % {
        $_.CustomAttributes | % {
            Write-Verbose "Setting attribute $($_.Name):$($_.Value) on $($targetvm)"
            $targetVmObject | Set-Annotation -CustomAttribute $_.Name -Value $_.Value
        }
    }
}

End {
    if ($EnableVerbose) {
        $VerbosePreference = $oldverbose
    }
}
