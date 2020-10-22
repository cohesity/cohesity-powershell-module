function Get-CohesityProtectionPolicy {
    <#
        .SYNOPSIS
        Get protection source.
        .DESCRIPTION
        The Get-CohesityProtectionPolicy function is used to get protection source.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionPolicy -Environments KPhysical
        .EXAMPLE
        Get-CohesityProtectionPolicy -Names Test-Policy
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [Cohesity.Model.ProtectionJob+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false)]
        [string[]]$Ids,
        [Parameter(Mandatory = $false)]
        [string[]]$Names
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
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $url = '/irisservices/api/v1/public/protectionPolicies'
        $filter = ""
        if ($Environments) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $envList = @()
            foreach ($item in $Environments) {
                # converting KVMware to kVMware
                $envText = $item.ToString()
                $envList += $envText.SubString(0, 1).ToLower() + $envText.SubString(1, $envText.Length - 1)
            }
            $filter += "environments=" + ($envList -join ",")
        }
        if ($Ids) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "ids=" + ($Ids -join ",")
        }
        if ($Names) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "names=" + ($Names -join ",")
        }
        if ($filter -ne "") {
            $url += ("?" + $filter)
        }
        $cohesityUrl = $cohesityServer + $url
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
        if($resp) {
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($resp | Add-Member -TypeName 'System.Object#ProtectionPolicy' -PassThru)
        }
    }

    End {
    }
}
