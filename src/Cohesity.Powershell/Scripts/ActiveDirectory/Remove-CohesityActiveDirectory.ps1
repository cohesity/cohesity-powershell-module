function Remove-CohesityActiveDirectory {
    <#
        .SYNOPSIS
        Remove active directory from the cohesity cluster.
        .DESCRIPTION
        Deletes the join of the Cohesity Cluster to the specified
        Active Directory domain. After the deletion, the Cohesity Cluster
        no longer has access to the principals on the Active Directory.
        For example, you can no longer log in to the Cohesity Cluster
        with a user defined in a principal group of the Active Directory domain.

        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityActiveDirectory -DomainName cohesity.com
        .EXAMPLE
        Remove-CohesityActiveDirectory -DomainName cohesity.com -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "Administrator", (ConvertTo-SecureString -AsPlainText "secret" -Force)) -Confirm:$false
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the Active Directory Domain Name.
        $DomainName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNull()]
        [System.Management.Automation.PSCredential]
        [System.Management.Automation.Credential()]
        # Specifies the Active Directory credential.
        $Credential
    )
    Begin {
    }

    Process {
        $UserName = $Credential.UserName
        $PlainPassword = $Credential.GetNetworkCredential().Password

        $url = '/irisservices/api/v1/public/activeDirectory'

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
            $resp = Invoke-RestApi -Method Delete -Uri $url -Body $payloadJson
            if ($resp) {
                $errorMsg = "Active Directory : $DomainName deleted."
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