function New-CohesityProtectionPolicy {
    <#
        .SYNOPSIS
        Create a new protection policy.
        .DESCRIPTION
        The New-CohesityProtectionPolicy function is used to create a protection new protection policy.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-ONLY
        .EXAMPLE
        New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-FULL
        .EXAMPLE
        New-CohesityProtectionPolicy -PolicyName policy1 -BackupInHours 14 -RetainInDays 25 -VaultName vault1
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the policy for the protection job.
        [string]$PolicyName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the no. of hours after which backup has to run.
        [int]$BackupInHours,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the number of days for retainment.
        [int]$RetainInDays,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("INCREMENTAL-ONLY", "INCREMENTAL-FULL")]
        # Specifies the type of incremental schedule.
        [string]$IncrementalSchedule = "INCREMENTAL-ONLY",
        [Parameter(Mandatory = $false)]
        # Specifies the name of the vault.
        $VaultName = $null
    )
    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($PolicyName)) {
            $url = '/irisservices/api/v1/public/protectionPolicies'

            $snapshotArchivalCopyPolicies = $null
            if ($VaultName) {
                $resp = Get-CohesityVault -VaultName $VaultName
                if ($null -eq $resp) {
                    Write-Output "Vault (external target) name '$VaultName' does not exists"
                    return
                }
                # Except the vault info all the default values referenced from cohesity UI
                $snapshotArchivalCopyPolicies = @(
                    @{
                        copyPartial = $true
                        daysToKeep  = 90
                        multiplier  = 1
                        periodicity = "kDay"
                        target      = @{
                            vaultId   = $resp.Id
                            vaultName = $resp.Name
                            vaultType = "kCloud"
                        }
                    }
                )
            }
            $fullSchedule = $null
            if ("INCREMENTAL-FULL" -eq $IncrementalSchedule) {
                $fullSchedule = @{
                    periodicity   = "kDaily"
                    dailySchedule = @{
                        days = @()
                    }
                }
            }
            $payload = @{
                name                         = $PolicyName
                incrementalSchedulingPolicy  = @{
                    periodicity        = "kContinuous"
                    continuousSchedule = @{
                        # convert to minutes
                        backupIntervalMins = $BackupInHours * 60
                    }
                }
                daysToKeep                   = $RetainInDays
                fullSchedulingPolicy         = $fullSchedule
                snapshotArchivalCopyPolicies = $snapshotArchivalCopyPolicies
            }
            $payloadJson = $payload | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $url -Body $payloadJson
            if ($resp) {
                $resp
            }
            else {
                $errorMsg = "Protection Policy : Failed to create"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}