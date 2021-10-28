function Remove-CohesityUserAPIKey {
    <#
        .SYNOPSIS
        Remove a user api key (supported 6.5.1d onwards).
        .DESCRIPTION
        The Remove-CohesityUserAPIKey function is used to remove user api key.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Remove-CohesityUserAPIKey -UserName "user1" -APIKeyName "myKey1"
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies user name.
        [string]$UserName,
        [Parameter(Mandatory = $true)]
        # Specifies api key name.
        [string]$APIKeyName
    )

    Begin {
    }

    Process {
        if ($PSCmdlet.ShouldProcess($APIKeyName)) {
            $userObject = Get-CohesityUser -Names $UserName
            if (-not $userObject) {
                Write-Output "Invalid user name '$UserName'."
                return
            }
            $apiKeyObject = Get-CohesityUserAPIKey | where-object {$_.name -eq $APIKeyName}
            if (-not $apiKeyObject) {
                Write-Output "Invalid api key name '$APIKeyName'."
                return
            }
            $userSID = $userObject.sid
            $apiKeyId = $apiKeyObject.id
            $cohesityClusterURL = '/irisservices/api/v1/public/users/'+$userSID+'/apiKeys/'+$apiKeyId
            $resp = Invoke-RestApi -Method 'Delete' -Uri $cohesityClusterURL
            $resp
        }
    }
}
