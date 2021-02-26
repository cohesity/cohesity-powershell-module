function Set-CohesityViewDirectoryQuota {
    <#
        .SYNOPSIS
        Request to update directory quota for a view filtered by specified parameters.
        .DESCRIPTION
        The Set-CohesityViewDirectoryQuota function is used to set directory quota for a view.
        .EXAMPLE
        Set-CohesityViewDirectoryQuota -ViewName view1 -DirPath "/"
        .EXAMPLE
        Set-CohesityViewDirectoryQuota -ViewName view1 -DirPath "/" -AlertLimitInGB 45 -HardLimitInGB 50
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the view name.
        [String]$ViewName,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        # Specifies the directory path.
        [String]$DirPath,
        [Parameter(Mandatory = $false)]
        # Specifies the alert limit in GB.
        [long]$AlertLimitInGB,
        [Parameter(Mandatory = $false)]
        # Specifies the hard limit in GB.
        [long]$HardLimitInGB
    )

    Begin {
        $cohesitySession = CohesityUserProfile
        $cohesityCluster = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $view = Get-CohesityView -ViewNames $ViewName
        if (-not $view) {
            Write-Output "The view '$ViewName' does not exists."
            return
        }
        if ($PSCmdlet.ShouldProcess($ViewName)) {
            $cohesityClusterURL = $cohesityCluster + '/irisservices/api/v1/public/viewDirectoryQuotas?viewName=$ViewName'
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $payload = [PSCustomObject]@{
                quota = @{
                    dirPath =  $DirPath
                    policy = @{
                      alertLimitBytes = $AlertLimitInGB * 1024 * 1024 * 1024
                      hardLimitBytes = $HardLimitInGB * 1024 * 1024 * 1024
                    }
                  }
                viewName = $ViewName
            }
            $payloadJson = $payload | ConvertTo-Json
            $resp = Invoke-RestApi -Method 'Put' -Uri $cohesityClusterURL -Headers $cohesityHeaders -Body $payloadJson
            $resp
        }
    }
}
