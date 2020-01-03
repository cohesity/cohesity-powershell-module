#### USAGE ####
#   Get-Command -Name Update-CohesityActiveDirectory -Syntax
#	********************** Using Function *********************
#   Update-CohesityActiveDirectory -DomainName cohesity.com
#   Update-CohesityActiveDirectory -DomainName cohesity.com -IdMappingInfo <Object>
#   Update-CohesityActiveDirectory -DomainName cohesity.com -PreferredDomainControllers <Object>
#   Update-CohesityActiveDirectory -DomainName cohesity.com -LdapProvider <Object>
#   Update-CohesityActiveDirectory -DomainName cohesity.com -IgnoredTrustedDomains <Object>
###############
function Update-CohesityActiveDirectory {
    [CmdletBinding(DefaultParameterSetName = 'IdMappingInfo')]
    Param(
        [ValidateNotNullOrEmpty()]
        [Parameter(Mandatory = $true, ParameterSetName = 'DomainOnly', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'IdMappingInfo', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'IgnoredTrustedDomains', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'LdapProvider', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'PreferredDomainControllers', Position = 0)]
        $DomainName,
        [Parameter(Mandatory = $true, ParameterSetName = 'IdMappingInfo', Position = 1)]
        $IdMappingInfo,
        [Parameter(Mandatory = $true, ParameterSetName = 'IgnoredTrustedDomains', Position = 1)]
        $IgnoredTrustedDomains,
        [Parameter(Mandatory = $true, ParameterSetName = 'LdapProvider', Position = 1)]
        $LdapProvider,
        [Parameter(Mandatory = $true, ParameterSetName = 'PreferredDomainControllers', Position = 1)]
        $PreferredDomainControllers
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
        $url = $server + '/irisservices/api/v1/public/activeDirectory/' + $DomainName
        switch ($PsCmdlet.ParameterSetName) {
            "IdMappingInfo" {
                Write-Host $IdMappingInfo
                $url = $url + '/idMappingInfo'
                $payload = $IdMappingInfo
            }
            "IgnoredTrustedDomains" {
                Write-Host $IgnoredTrustedDomains
                $url = $url + '/ignoredTrustedDomains'
                $payload = $IgnoredTrustedDomains
            }
            "LdapProvider" {
                Write-Host $LdapProvider
                $url = $url + '/ldapProvider'
                $payload = $LdapProvider
            }
            "PreferredDomainControllers" {
                Write-Host $PreferredDomainControllers
                $url = $url + '/preferredDomainControllers'
                $payload = $PreferredDomainControllers
            }
        }
        $headers = @{'Authorization' = 'Bearer ' + $token }
        $payloadJson = $payload | ConvertTo-Json
        $resp = Invoke-RestApi -Method Put -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMsg = "Active Directory : $DomainName, Failed to update"
            Write-Host $errorMsg
            CSLog -Message $errorMsg
        }
    }
    End {
    }
}