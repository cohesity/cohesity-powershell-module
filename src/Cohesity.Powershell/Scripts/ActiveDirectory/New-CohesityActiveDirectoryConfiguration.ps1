#### USAGE ####
#	********************** Using Function *********************
#   New-CohesityActiveDirectoryConfiguration -DomainName cohesity.com -UserName administrator -MachineAccounts "Test"
#   New-CohesityActiveDirectoryConfiguration -DomainName cohesity.com -UserName administrator -MachineAccounts "Test" -Password (ConvertTo-SecureString "secret" -AsPlainText -Force)
###############
function New-CohesityActiveDirectoryConfiguration {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $DomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        $UserName,
        [Parameter(Mandatory = $true)]
        [SecureString]$Password,
        [Parameter(Mandatory = $true)]
        [string[]]$MachineAccounts
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
        $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            $errorMessage = "Failed to create, active directory configuration"
            Write-Host $errorMessage
            CSLog -Message $errorMessage
        }
    }
    End {
    }
}