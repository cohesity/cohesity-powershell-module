function Get-CohesityProtectionPolicy {
    <#
        .SYNOPSIS
        Gets a list of protection policies filtered by specified parameters.
        .DESCRIPTION
        If no parameters are specified, all protection policies on the Cohesity Cluster are returned.
        Specifying parameters filters the results that are returned.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityProtectionPolicy -Names Test-Policy
        Displays the protection policy with name "Test-Policy".
        .EXAMPLE
        Get-CohesityProtectionPolicy -Environments KPhysical
    #>
    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Filter by Environment type.
        # Only Policies protecting the specified environment type are returned.
        # NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.
        [Cohesity.Model.ProtectionJob+EnvironmentEnum[]]$Environments,
        [Parameter(Mandatory = $false)]
        # Filter by a list of protection policy ids.
        [string[]]$Ids,
        [Parameter(Mandatory = $false)]
        # Filter by a list of protection policy names.
        [string[]]$Names
    )

    Begin {
        $cohesitySession = CohesityUserProfile
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
