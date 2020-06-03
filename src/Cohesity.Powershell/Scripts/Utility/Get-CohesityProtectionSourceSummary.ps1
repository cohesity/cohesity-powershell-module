function Get-CohesityProtectionSourceSummary {
    <#
		.SYNOPSIS
		Get the summary of protection sources.
		.DESCRIPTION
		The Get-CohesityProtectionSourceSummary is used to get the summary of protected and unprotected sources, for example the VMs, databases, volumes, physical servers etc.
		.EXAMPLE
		Get-CohesityProtectionSourceSummary
	#>
    [CmdletBinding()]
    param(
    )
    
    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $clusterConfig = Get-CohesityClusterConfiguration
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/dashboard?clusterId=' + $clusterConfig.id
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method Get -Uri $cohesityClusterURL -Headers $cohesityHeaders
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Protection source summary : Failed to get"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }

    End {

    }
}