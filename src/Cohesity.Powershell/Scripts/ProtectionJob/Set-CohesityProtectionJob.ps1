function Set-CohesityProtectionJob {
    <#
        .SYNOPSIS
        Update protection job.
        .DESCRIPTION
        The Set-CohesityProtectionJob function is used to set protection job.
        Updates a protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Set-CohesityProtectionJob -ProtectionJob $job
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [object]$ProtectionJob
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $cohesitySession = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json
        $cohesityServer = $cohesitySession.ClusterUri
        $cohesityToken = $cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        $protectionJobName = $ProtectionJob.Name
        if ($PSCmdlet.ShouldProcess($protectionJobName)) {

            if ($ProtectionJob.Environment -eq "kPhysicalFiles") {
                $job = Get-CohesityProtectionJob -Ids $ProtectionJob.Id
                if ($job) {
                    if ($job.SourceSpecialParameters) {
                        $hostType = $job.LastRun.BackupRun.SourceBackupStatus[0].Source.PhysicalProtectionSource.HostType;
                        $newSourceIds = $ProtectionJob.SourceIds
                        $existingSourceIds = $job.SourceIds
                        $sourceSpecialParameterList = @()
                        foreach ($item in $newSourceIds) {
                            if ( -not ($existingSourceIds -contains $item)) {
                                $sourceSpecialParameter = [Cohesity.Model.SourceSpecialParameter]::new()
                                $sourceSpecialParameter.SourceId = $item
                                $sourceSpecialParameter.PhysicalSpecialParameters = [Cohesity.Model.PhysicalSpecialParameters]::new()
                                $sourceSpecialParameter.PhysicalSpecialParameters.FilePaths = @()
                                if ($hostType -eq "kWindows") {
                                    $sourceSpecialParameter.PhysicalSpecialParameters.UsesSkipNestedVolumesVec = $true
                                    $filePath = [Cohesity.Model.FilePathParameters]::new("/C/")
                                    $sourceSpecialParameter.PhysicalSpecialParameters.FilePaths += $filePath
                                }
                                if ($hostType -eq "kLinux") {
                                    $filePath = [Cohesity.Model.FilePathParameters]::new("/", $null, $true)
                                    $sourceSpecialParameter.PhysicalSpecialParameters.FilePaths += $filePath
                                }
                                $sourceSpecialParameterList += $sourceSpecialParameter
                            }
                        }
                        $ProtectionJob.SourceSpecialParameters += $sourceSpecialParameterList
                    }
                }
            }
            $cohesityHeaders = @{'Authorization' = 'Bearer ' + $cohesityToken }
            $url = '/irisservices/api/v1/public/protectionJobs/' + $ProtectionJob.Id
            $cohesityUrl = $cohesityServer + $url
            $payloadJson = $ProtectionJob | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Put -Uri $cohesityUrl -Headers $cohesityHeaders -Body $payloadJson
            if ($resp) {
                # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
                $resp | Add-Member -TypeName 'System.Object#ProtectionJob' -PassThru
            }
        }
    }

    End {
    }
}