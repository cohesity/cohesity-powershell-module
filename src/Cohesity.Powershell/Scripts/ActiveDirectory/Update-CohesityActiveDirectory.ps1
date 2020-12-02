function Update-CohesityActiveDirectory {
    <#
        .SYNOPSIS
		Updates active directory entities.
        .DESCRIPTION
        Updates the user id mapping info of an Active Directory.
		Updates the list of trusted domains to be ignored during trusted domain discovery of an 
		Active Directory.
		Updates the LDAP provide Id for an Active Directory domain.
		Updates the preferred domain controllers of an Active Directory

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
		.EXAMPLE
		Update-CohesityActiveDirectory -DomainName cohesity.com -IdMappingInfo $mappingObject
		.EXAMPLE
		Update-CohesityActiveDirectory -DomainName cohesity.com -PreferredDomainControllers $dcObject
		.EXAMPLE
		Update-CohesityActiveDirectory -DomainName cohesity.com -LdapProvider $ldapObject
		.EXAMPLE
		Update-CohesityActiveDirectory -DomainName cohesity.com -IgnoredTrustedDomains $itdObject
    #>

    [CmdletBinding(DefaultParameterSetName = 'IdMappingInfo', SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [ValidateNotNullOrEmpty()]
        [Parameter(Mandatory = $true, ParameterSetName = 'DomainOnly', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'IdMappingInfo', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'IgnoredTrustedDomains', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'LdapProvider', Position = 0)]
        [Parameter(Mandatory = $true, ParameterSetName = 'PreferredDomainControllers', Position = 0)]
		# Specifies the Active Directory Domain Name.
        $DomainName,
        [Parameter(Mandatory = $true, ParameterSetName = 'IdMappingInfo', Position = 1)]
		# Specifies how the Unix and Windows users are mapped in an Active Directory.
        $IdMappingInfo,
        [Parameter(Mandatory = $true, ParameterSetName = 'IgnoredTrustedDomains', Position = 1)]
		#  Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.
        $IgnoredTrustedDomains,
        [Parameter(Mandatory = $true, ParameterSetName = 'LdapProvider', Position = 1)]
		# Specifies the LDAP provider which is map to this Active Directory
        $LdapProvider,
        [Parameter(Mandatory = $true, ParameterSetName = 'PreferredDomainControllers', Position = 1)]
		# Specifies Map of Active Directory domain names to its preferred domain controllers.
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
        if ($PSCmdlet.ShouldProcess($DomainName)) {
            $url = $server + '/irisservices/api/v1/public/activeDirectory/' + $DomainName
            switch ($PsCmdlet.ParameterSetName) {
                "IdMappingInfo" {
                    Write-Output $IdMappingInfo
                    $url = $url + '/idMappingInfo'
                    $payload = $IdMappingInfo
                }
                "IgnoredTrustedDomains" {
                    Write-Output $IgnoredTrustedDomains
                    $url = $url + '/ignoredTrustedDomains'
                    $payload = $IgnoredTrustedDomains
                }
                "LdapProvider" {
                    Write-Output $LdapProvider
                    $url = $url + '/ldapProvider'
                    $payload = $LdapProvider
                }
                "PreferredDomainControllers" {
                    Write-Output $PreferredDomainControllers
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
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}