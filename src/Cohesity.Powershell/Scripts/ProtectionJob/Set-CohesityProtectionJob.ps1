function Set-CohesityProtectionJob {
    <#
        .SYNOPSIS
        Updates a protection job.
        .DESCRIPTION
        Returns the updated protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        $job = Get-CohesityProtectionJob -Names "jobnas"
        $job.name = "jobnas1"
        Set-CohesityProtectionJob -ProtectionJob $job
        Updates a protection job with the specified parameters, the object $job can also be piped.
        .EXAMPLE
        $job = Get-CohesityProtectionJob -Names "phy-file" -Environments KPhysicalFiles
        $job.sourceIds += 111165
        $job | Set-CohesityProtectionJob
        Updates a protection job (kPhysicalFiles) with a new physical server.
    #>
    [OutputType('System.Object')]
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        # The updated protection job.
        [object]$ProtectionJob
    )

    Begin {
        $cohesitySession = CohesityUserProfile
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
                                $sourceSpecialParameter.PhysicalSpecialParameters.FilePaths = New-Object 'System.Collections.Generic.List[Cohesity.Model.FilePathParameters]'
                                if ($hostType -eq "kWindows") {
                                    $sourceSpecialParameter.PhysicalSpecialParameters.UsesSkipNestedVolumesVec = $true
                                    $filePath = [Cohesity.Model.FilePathParameters]::new("/C/")
                                    $sourceSpecialParameter.PhysicalSpecialParameters.FilePaths.Add($filePath)
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
