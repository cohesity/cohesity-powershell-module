#### USAGE ####
#	********************** Using Function *********************
#   Remove-CohesityActiveDirectoryConfiguration -DomainName cohesity.com -UserName administrator
#   Remove-CohesityActiveDirectoryConfiguration -DomainName cohesity.com -UserName administrator -Password (ConvertTo-SecureString "secret" -AsPlainText -Force)
###############
function Remove-CohesityActiveDirectoryConfiguration {
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        $DomainName,
        [Parameter(Mandatory = $true)]
        $UserName,
        [Parameter(Mandatory = $true)]
        [SecureString]$Password
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
        $BSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($Password)
        $PlainPassword = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR)
            
        $url = $server + '/irisservices/api/v1/public/activeDirectory'

        $headers = @{'Authorization' = 'Bearer ' + $token }
        if ($PSCmdlet.ShouldProcess($Name)) {

            $payload = @{
                domainName                 = $DomainName
                machineAccounts            = @($MachineAccounts)
                preferredDomainControllers = @(@{domainName = $DomainName })
                trustedDomainsEnabled      = $false
                userIdMapping              = @{ }
                userName                   = $UserName
                password                   = $PlainPassword
            }
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method Delete -Uri $url -Headers $headers -Body $payloadJson
            # no response for a delete operation 
            $errorMessage = "Operation was executed for the active directory configuration for domain : " + $DomainName
            Write-Host $errorMessage
            CSLog -Message $errorMessage
        }
        else {
            $errorMessage = "Operation did not succeed for active directory configuration"
            Write-Host $errorMessage
            CSLog -Message $errorMessage
        }
    }
    End {
    }
}