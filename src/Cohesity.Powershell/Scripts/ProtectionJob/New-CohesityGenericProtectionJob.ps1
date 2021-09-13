function New-CohesityGenericProtectionJob {
    <#
        .SYNOPSIS
        Create a new protection job.
        .DESCRIPTION
        The New-CohesityGenericProtectionJob function is used to create a protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityGenericProtectionJob -ProtectionJobObject $protectionJobObject
        Create a protection job by explicitly constructing the protection job object,
        Construct the object as follows,
        $protectionJobObject = [Cohesity.Model.ProtectionJob]::new()
        $protectionJobObject.Name = "job-rds4"
        $protectionJobObject.Environment = [Cohesity.Model.ProtectionJob+EnvironmentEnum]::KRDSSnapshotManager
        $protectionJobObject.PolicyId = "6572875819740094:1631076508923:3"
        $protectionJobObject.viewBoxId = 4
        $protectionJobObject.parentSourceId = 731
        $sourceIds = New-Object Collections.Generic.List[long]
        $sourceIds.Add(4791)
        $protectionJobObject.sourceIds = $sourceIds
        $protectionJobObject.startTime = [Cohesity.Model.TimeOfDay]::new(13,52)
        $protectionJobObject.timezone = "America/Los_Angeles"

        .EXAMPLE
        For reference, another example available in link below.
        eg; https://www.postman.com/cohesity/workspace/cohesity/request/14330502-4ebd5a6e-a772-4d7e-a23b-2dd335670d0e
    #>
    [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = "High")]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the object for the protection job.
        [Cohesity.Model.ProtectionJob]$ProtectionJobObject
    )

    Begin {
        $session = CohesityUserProfile
        $server = $session.ClusterUri
        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        if (-not $ProtectionJobObject.Environment) {
            Write-Output "Please specify the environment."
            return
        }
        if ($PSCmdlet.ShouldProcess("Generic Protection Job")) {

            $environment = $ProtectionJobObject.environment.ToString()
            $environment = "k" + $environment.Substring(1, $environment.Length - 1)
            #  ConvertTo-Json of environment to string gives the enum number, therefore converting back to PSCustomObject
            $pJobJson = $ProtectionJobObject | ConvertTo-Json -Depth 100
            $pJobObject = $pJobJson | ConvertFrom-Json
            $pJobObject.environment = $environment

            $url = $server + '/irisservices/api/v1/public/protectionJobs'
            $headers = @{'Authorization' = 'Bearer ' + $token }
            $payloadJson = $pJobObject | ConvertTo-Json -Depth 100
            $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
            if (201 -eq $Global:CohesityAPIStatus.StatusCode) {
                Start-CohesityProtectionJob -Id $resp.Id | Out-Null
                $resp
            }
            else {
                Write-Output "Protection job : Failed to create job"
                Write-Output $Global:CohesityAPIError
            }
        }
    }
    End {
    }
}