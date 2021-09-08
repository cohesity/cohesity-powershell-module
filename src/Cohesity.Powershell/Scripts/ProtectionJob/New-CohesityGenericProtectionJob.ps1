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
		$protectionJobObject.Name = "job-aws"

		.EXAMPLE
		For reference, another example available in link below.
		eg; https://www.postman.com/cohesity/workspace/cohesity/request/14330502-4ebd5a6e-a772-4d7e-a23b-2dd335670d0e
    #>
    [CmdletBinding()]
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
			$url = $server + '/irisservices/api/v1/public/protectionJobs'

			$headers = @{'Authorization' = 'Bearer ' + $token }
			$payload = $ProtectionJobObject
			$payloadJson = $payload | ConvertTo-Json -Depth 100
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
    End {
    }
}