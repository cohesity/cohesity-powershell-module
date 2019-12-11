function Get-CohesityActiveDirectoryConfiguration {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $false)]
        [string[]]$DomainNames
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
        if($DomainNames) {
            $domains = $DomainNames -join ","
            $url = $server + '/irisservices/api/v1/public/activeDirectory?domains='+$domains
        } else {
            $url = $server + '/irisservices/api/v1/public/activeDirectory'
        }

        $headers = @{'Authorization' = 'Bearer ' + $token }
        $resp = Invoke-RestApi -Method Get -Uri $url -Headers $headers
        if ($DomainNames) {
            foreach($domainName in $DomainNames) {
                $domainDetails = $null
                $foundDomainName = $false
                foreach($item in $resp) {
                    if($item.domainName -eq $domainName) {
                        $foundDomainName = $true
                        $domainDetails = $item
                    }
                }
                if($foundDomainName) {
                    $domainDetails
                } else {
                    Write-Host "Active Directory domain name '$domainName' not found"
                }
            }
        }
        else {
            $resp
        }
    }
    End {
    }
}