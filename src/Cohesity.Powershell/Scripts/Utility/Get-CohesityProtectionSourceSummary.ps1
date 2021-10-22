function Get-CohesityProtectionSourceSummary {
    <#
        .SYNOPSIS
        Get the summary of protection sources.
        .DESCRIPTION
        The Get-CohesityProtectionSourceSummary is used to get the summary of protected and unprotected sources, for example the VMs, databases, volumes, physical servers etc.
        .EXAMPLE
        Get-CohesityProtectionSourceSummary
        Returns summary of protected and unprotected sources.
        .EXAMPLE
        Get-CohesityProtectionSourceSummary -BasicSummary:$true
        Returns summary of all protection sources, for example,
        envType              : kSQL
        protectedCount       : 8
        protected size(GB)   : 0.09
        unprotectedCount     : 53
        unprotected size(GB) : 0.7

        envType              : kGenericNas
        protected size(GB)   : 0
        unprotectedCount     : 1
        unprotected size(GB) : 0

        envType              : kVMware
        protectedCount       : 3
        protected size(GB)   : 8.09
        unprotectedCount     : 237
        unprotected size(GB) : 5809.45

        envType              : kPhysical
        protectedCount       : 0
        protected size(GB)   : 0
        unprotectedCount     : 3
        unprotected size(GB) : 120

        envType              : Total
        protectedCount       : 11
        protected size(GB)   : 8.17
        unprotectedCount     : 294
        unprotected size(GB) : 5930.15
    #>
    [CmdletBinding()]
    param(
        [Parameter(Mandatory = $false)]
        # Returns basic summary of protection sources.
        [switch]$BasicSummary
    )

    Begin {
    }

    Process {
        $clusterConfig = Get-CohesityClusterConfiguration
        $cohesityClusterURL = '/irisservices/api/v1/public/dashboard?clusterId=' + $clusterConfig.id
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL
        if ($resp) {
            if($true -eq $BasicSummary) {
                $result = ($resp.dashboard.protectedObjects | Select-Object -ExpandProperty objectsProtected)
                $summary = @{
                    envType = "Total"
                    protectedCount = $resp.dashboard.protectedObjects.protectedCount
                    protectedSizeBytes = $resp.dashboard.protectedObjects.protectedSizeBytes
                    unprotectedCount = $resp.dashboard.protectedObjects.unprotectedCount
                    unprotectedSizeBytes = $resp.dashboard.protectedObjects.unprotectedSizeBytes
                }
                $result += $summary
                ($result  |Select-Object envType,protectedCount, `
                @{Name="protected size(GB)"; Expression={[math]::round($_.protectedSizeBytes/1GB, 2)}}, `
                unprotectedCount, @{Name="unprotected size(GB)"; Expression={[math]::round($_.unprotectedSizeBytes/1GB, 2)}})
            } else {
                $resp
            }
        }
        else {
            $errorMsg = "Protection source summary : Failed to get"
            Write-Output $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {

    }
}