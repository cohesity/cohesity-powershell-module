function Get-CohesityQOSPolicy {
    <#
        .SYNOPSIS
        Get QOS detail.
        .DESCRIPTION
        The Get-CohesityQOSPolicy function is used to get QOS details.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityQOSPolicy -QOSIds 23,24
        .EXAMPLE
        Get-CohesityQOSPolicy -QOSNames "Backup Target Commvault"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # QOS ids
        [long[]]$QOSIds,
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        # QOS names
        [string[]]$QOSNames
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $url = '/irisservices/api/v1/public/qosPolicies'
        if($QOSIds) {
            $appendIds = "ids="+($QOSIds -join ",")
        }
        if($QOSNames) {
            $appendNames = "names="+($QOSNames -join ",")
        }
        if($appendIds -and $appendNames) {
            $url += "?" + $appendIds + "&" + $appendNames
        } else {
            if($appendIds) {
                $url += "?" + $appendIds
            }
            if($appendNames) {
                $url += "?" + $appendNames
            }
        }
        $cohesityUrl = $cohesityServer + $url
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method Get -Uri $cohesityUrl -Headers $cohesityHeaders
        $resp
    }

    End {
    }
}
