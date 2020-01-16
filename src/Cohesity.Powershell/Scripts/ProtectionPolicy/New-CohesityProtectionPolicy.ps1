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
    #>
    [CmdletBinding()]
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
        [string]$IncrementalSchedule = "INCREMENTAL-ONLY"
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
        $url = $server + '/irisservices/api/v1/public/protectionPolicies'

        $headers = @{'Authorization' = 'Bearer ' + $token }

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
            name                        = $PolicyName
            incrementalSchedulingPolicy = @{
                periodicity        = "kContinuous"
                continuousSchedule = @{
                    # convert to minutes
                    backupIntervalMins = $BackupInHours * 60
                }
            }
            daysToKeep                  = $RetainInDays
            fullSchedulingPolicy        = $fullSchedule
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Protection Policy : Failed to create"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}