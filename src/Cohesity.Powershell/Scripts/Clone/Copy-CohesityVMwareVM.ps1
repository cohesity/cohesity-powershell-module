function Copy-CohesityVMwareVM {
    <#
        .SYNOPSIS
        Clones the specified VMware virtual machine.
        .DESCRIPTION
        Clones the specified VMware virtual machine. The cmdlet can copy VM from remote cluster as well.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Copy-CohesityVMwareVM -TaskName "test-clone-task" -SourceId 883 -TargetViewName "test-vm-datastore" -JobId 49402 -VmNamePrefix "clone-" -DisableNetwork -PoweredOn -ResourcePoolId 893
        Clones the VMware virtual machine with the given source id using the latest run of job id 49402.
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the name of the clone task.
        [string]$TaskName = "Copy-VMware-VM-" + (Get-Date -Format "dddd-MM-dd-yyyy-HH-mm-ss").ToString(),
        [Parameter(Mandatory = $true)]
        # Specifies the name of the View where the cloned VM is stored.
        [string]$TargetViewName,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the source id of the VM to be cloned.
        [long]$SourceId,
        [Parameter(Mandatory = $true)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job id that backed up this VM and will be used for cloning.
        [long]$JobId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the job run id that captured the snapshot for this VM. If not specified the latest run is used.
        [long]$JobRunId,
        [Parameter(Mandatory = $false)]
        # Specifies the time when the Job Run starts capturing a snapshot.
        # Specified as a Unix epoch Timestamp (in microseconds).
        # This must be specified if job run id is specified.
        [long]$StartTime,
        [Parameter(Mandatory = $false)]
        # Specifies the prefix to add to the name of the cloned VM.
        [string]$VmNamePrefix,
        [Parameter(Mandatory = $false)]
        # Specifies the suffix to add to the name of the cloned VM.
        [string]$VmNameSuffix,
        [Parameter(Mandatory = $false)]
        # Specifies whether the network should be left in disabled state.
        [switch]$DisableNetwork,
        [Parameter(Mandatory = $false)]
        # Specifies the power state of the cloned VM.
        # By default, the VM is powered off.
        [switch]$PoweredOn,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the folder where the datastore should be created when the VM is being cloned.
        [long]$DatastoreFolderId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned VM.
        # By default, original network configuration is preserved if the VM is cloned under the same parent source and the same resource pool.
        # Original network configuration is detached if the VM is cloned under a different vCenter or a different resource pool.
        [long]$NetworkId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the resource pool where the VM should be cloned.
        [long]$ResourcePoolId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies the folder where the VM should be cloned.
        # This is applicable only when the VM is being cloned to an alternate location.
        [long]$VmFolderId,
        [Parameter(Mandatory = $false)]
        [ValidateRange(1, [long]::MaxValue)]
        # Specifies a new parent source such as vCenter to clone the VM.
        # If not specified, the VM is cloned to its original parent source.
        [long]$NewParentId
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $cohesityUrl = $cohesityServer + '/irisservices/api/v1/public/restore/clone'
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        if ($PSCmdlet.ShouldProcess($Param1)) {
            $payload = @{}
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "VMwareVM : Failed to copy."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
        else {
            return
        }
    }

    End {
    }
}
