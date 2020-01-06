# Request to update Storage Domain (View Box) configuration.
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
		[object[]]$StorageDomain = $null
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
        $payload = $null

        if ($StorageDomain -ne $null) {
            $payload = $StorageDomain
            if ($Name) {
                $payload = $StorageDomain | Where-Object {$_.name -eq $Name}
            }
        }

        # Construct URL & header
        $StorageDomainUrl = $server + '/irisservices/api/v1/public/viewBoxes'
        $headers = @{'Authorization' = 'Bearer ' + $token }

        if ($StorageDomain -eq $null) {
            if (!$Name) {
                Write-Warning 'Please provide the Storage domain name that to be updated'
                return
            }
            $getUrl = $StorageDomainUrl + '?names=' + $Name
            $payload = Invoke-RestApi -Method 'Get' -Uri $getUrl -Headers $headers
        }

        # Update the specified Storage domain
        if ($payload -ne $null) {
            $StorageDomainId = $payload.id
            $StorageDomainName = $payload.name
            $payloadJson = $payload | ConvertTo-Json

            $updateUrl = $StorageDomainUrl + "/" + $StorageDomainId
            $StorageDomainObj = Invoke-RestApi -Method 'Put' -Uri $updateUrl -Headers $headers -Body $payloadJson

            if ($StorageDomainObj) {
                Write-Host "Updated '$StorageDomainName' Storage Domain Successfully"
                $StorageDomainObj
            }
        }
    }
    End {
    }
}