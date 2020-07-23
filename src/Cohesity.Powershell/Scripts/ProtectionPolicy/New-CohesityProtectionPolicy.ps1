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
        New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-ONLY
        .EXAMPLE
        New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -IncrementalSchedule INCREMENTAL-FULL
        .EXAMPLE
        New-CohesityProtectionPolicy -PolicyName <string> -BackupInHours 14 -RetainInDays 25 -VaultName <string>
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$PolicyName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$BackupInHours,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [int]$RetainInDays,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("INCREMENTAL-ONLY", "INCREMENTAL-FULL")]
        [string]$IncrementalSchedule = "INCREMENTAL-ONLY",
        [Parameter(Mandatory = $false)]
        $VaultName = $null
    )
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        if ($PSCmdlet.ShouldProcess($PolicyName)) {
            $url = $server + '/irisservices/api/v1/public/protectionPolicies'

            $headers = @{'Authorization' = 'Bearer ' + $token }

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
            $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
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