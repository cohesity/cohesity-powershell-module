function Get-CohesityActiveDirectory {
    <#
        .SYNOPSIS
        Get active directory list.
        .DESCRIPTION
        After a Cohesity Cluster has been joined to an Active Directory domain, the users and groups in
        the domain can be authenticated on the Cohesity Cluster using their Active Directory credentials.
        NOTE: The userName and password fields are not populated by this operation.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityActiveDirectory -DomainNames "cohesity.com","abc.com"
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        # Specifies the domains to fetch active directory entries.
        [string[]]$DomainNames
    )
    Begin {
        $session = CohesityUserProfile
        $server = $session.ClusterUri
        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        if($DomainNames) {
            $domains = $DomainNames -join ","
            $url = $server + '/irisservices/api/v1/public/activeDirectory?domains='+$domains
        } else {
            $url = $server + '/irisservices/api/v1/public/activeDirectory'
        }

        $headers = @{'Authorization' = 'Bearer ' + $token }
        $resp = Invoke-RestApi -Method Get -Uri $url -Headers $headers
        $resp
    }
    End {
    }
}