function Get-CohesityViewShareWhitelist {
    <#
        .SYNOPSIS
        Get whitelist IP(s) for a given share.
        .DESCRIPTION
        Get whitelist IP(s) for a given share.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityViewShareWhitelist -ShareName share1
        Get the whitelist for share1.
    #>

    [OutputType('System.Collections.ArrayList')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies view name.
        [string]$ShareName
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/shares?shareName=' + $ShareName
        $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
        $resp = Invoke-RestApi -Method 'Get' -Uri $cohesityClusterURL -Headers $cohesityHeaders
        $resp
    }

    End {
    }
}