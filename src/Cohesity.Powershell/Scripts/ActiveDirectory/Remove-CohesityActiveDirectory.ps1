#### USAGE ####
#	********************** Using Function *********************
#   Remove-CohesityActiveDirectory -DomainName cohesity.com
#   Remove-CohesityActiveDirectory -DomainName cohesity.com -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force)) -Confirm:$false
###############
function Remove-CohesityActiveDirectory {
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        $DomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNull()]
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        $Credential
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
        $UserName = $Credential.UserName
        $PlainPassword = $Credential.GetNetworkCredential().Password

        $url = $server + '/irisservices/api/v1/public/activeDirectory'

        $headers = @{'Authorization' = 'Bearer ' + $token}
        if ($PSCmdlet.ShouldProcess($Name)) {

            $payload = @{
                domainName                 = $DomainName
                machineAccounts            = @($MachineAccounts)
                preferredDomainControllers = @(@{domainName = $DomainName})
                trustedDomainsEnabled      = $false
                userIdMapping              = @{ }
                userName                   = $UserName
                password                   = $PlainPassword
            }
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method Delete -Uri $url -Headers $headers -Body $payloadJson
            if ($resp) {
                $errorMsg = "Active Directory : $DomainName deleted."
                Write-Output $errorMsg
                CSLog -Message $errorMsg
				$resp
            }
            else {
                $errorMsg = "Active Directory : $DomainName could not be deleted"
                Write-Output $errorMsg
                CSLog -Message $errorMsg
            }
        }
    }
    End {
    }
}