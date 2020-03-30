<#

Backup-VMAttributes - Fetches VM custom attributes from vCenter server and stores them to a json file
Usage: .\Backup-VMAttributes.ps1 -vcenter 10.2.145.20 -vmnames win2k16-srv1,win2k16-srv2,win2k16-srv3 -credential (Get-Credential) -filepath "c:\out.json" -EnableVerbose

Assumptions:
- If "vmnames" is not specified gets all the VMs in vCenter

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
    [Parameter(Mandatory = $False)][ValidateNotNullOrEmpty()]
    [string[]]$vmnames, # Names of the VMs to fetch custom attributes for
    [Parameter(Mandatory = $False)][ValidateNotNullOrEmpty()]
    [string]$filepath, # Save output to this file
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
    # Connect to vCenter
    Connect-VIServer -server $vcenter -Credential $credential | Out-Null

    $vms = @()
    # Get specified VMs in vCenter
    if($vmnames) {
        foreach ($vmname in $vmnames) {
            $vm = Get-VM -Name $vmname
            if(!$vm.Id) {
                Write-Verbose "Could not find VM with name: $vmname"
            } else {
                Write-Verbose "Found VM with name: $vmname"
                $vms += $vm
            }
        }
    } else {
        # Get all VMs in vCenter
        $vms = Get-VM
    }

    $vmObjects = @()
    $vms | % {

        $vmObject = New-Object pscustomobject
        $vmObject | Add-Member -NotePropertyName Name -NotePropertyValue $_.Name
        $vmObject | Add-Member -NotePropertyName ObjectRef -NotePropertyValue $_.Id
        $vmObject | Add-Member -NotePropertyName Uuid -NotePropertyValue (Get-View $_.Id).config.UUID
        $vmObject | Add-Member -NotePropertyName Moref -NotePropertyValue $_.Id
        
        $vmattributes = @()
        $attributes = $_ | Get-Annotation
        foreach($attribute in $attributes) {
            $vmattribute = New-Object pscustomobject
            $vmattribute | Add-Member -NotePropertyName Name -NotePropertyValue $attribute.Name
            $vmattribute | Add-Member -NotePropertyName Value -NotePropertyValue $attribute.Value
            $vmattributes += $vmattribute
        }

        $vmObject | Add-Member -NotePropertyName CustomAttributes -NotePropertyValue $vmattributes
        $vmObjects += $vmObject
    }

    if($filepath) {
        $vmObjects | ConvertTo-Json -Depth 100 | Out-File -FilePath $filepath
    } else {
        $vmObjects | ConvertTo-Json -Depth 100
    }
}

End {
    if ($EnableVerbose) {
        $VerbosePreference = $oldverbose
    }
}
