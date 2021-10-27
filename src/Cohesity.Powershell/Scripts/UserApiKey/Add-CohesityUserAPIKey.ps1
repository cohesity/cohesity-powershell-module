function Add-CohesityUserAPIKey {
    <#
        .SYNOPSIS
        Add a user api key (supported 6.5.1d onwards).
        .DESCRIPTION
        The Add-CohesityUserAPIKey function is used to add user api key.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Add-CohesityUserAPIKey -UserName "user1" -APIKeyName "myKey1"
    #>
    [OutputType('System.Array')]
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
            $userSID = $userObject.sid
            $cohesityClusterURL = '/irisservices/api/v1/public/users/'+$userSID+'/apiKeys'
            $payload = @{
                            isActive = $true
                            name = $APIKeyName
            }
            $payloadJson  = $payload | ConvertTo-Json -Depth 100
            $userAPIKeyObject = Invoke-RestApi -Method 'POST' -Uri $cohesityClusterURL -Body $payloadJson
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($userAPIKeyObject | Add-Member -TypeName 'System.Object#UserAPIKeyObject' -PassThru)
        }
    }
}
