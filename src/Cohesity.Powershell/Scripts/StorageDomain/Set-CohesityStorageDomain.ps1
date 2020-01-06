#### USAGE ####
#   Set-CohesityStorageDomain -Name newmanStorage
#   Get-CohesityStorageDomain | Set-CohesityStorageDomain -Name newmanStorage
#   Get-CohesityStorageDomain -Names newmanStorage | Set-CohesityStorageDomain
#   Get-CohesityStorageDomain | Set-CohesityStorageDomain
###############

function Set-CohesityStorageDomain {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory=$False)]
        [string]$Name = $null,
        [Parameter(ValueFromPipeline=$True, DontShow=$True)]
		[object[]]$StorageDomains = $null
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
        $StorageDomain = $null

        if ($StorageDomains -ne $null) {
            $StorageDomain = $StorageDomains
            if ($Name) {
                $StorageDomain = $StorageDomains | Where-Object {$_.name -eq $Name}
            }
        }

        # Construct URL & header
        $StorageDomainUrl = $server + '/irisservices/api/v1/public/viewBoxes'
        $headers = @{'Authorization' = 'Bearer ' + $token }

        if ($StorageDomains -eq $null) {
            if (!$Name) {
                Write-Warning 'Please provide the Storage domain name that to be updated'
                return
            }
            $getUrl = $StorageDomainUrl + '?names=' + $Name
            $StorageDomain = Invoke-RestApi -Method 'Get' -Uri $getUrl -Headers $headers
        }

        # Update the specified Storage domain
        if ($StorageDomain -ne $null) {
            $StorageDomainId = $StorageDomain.id
            $StorageDomainName = $StorageDomain.name
            $StorageDomain = $StorageDomain | ConvertTo-Json

            $updateUrl = $StorageDomainUrl + "/" + $StorageDomainId
            $StorageDomainObj = Invoke-RestApi -Method 'Put' -Uri $updateUrl -Headers $headers -Body $StorageDomain

            if ($StorageDomainObj) {
                Write-Host "Updated '$StorageDomainName' Storage Domain Successfully"
                $StorageDomainObj
            }
        }
    }
    End {
    }
}