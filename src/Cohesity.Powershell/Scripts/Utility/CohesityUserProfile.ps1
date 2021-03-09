function CohesityUserProfile {
    [OutputType('System.Object')]
    [cmdletbinding()]
    param(
        [Parameter(Mandatory = $false)]
        $UserProfileData = $null
	)

	$cohesityUserProfile = "cohesityUserProfile"
	if (-not $UserProfileData) {
		$userProfileJson = [Environment]::GetEnvironmentVariable($cohesityUserProfile, 'Process')
		if (-not $userProfileJson) {
			throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
		}
		return ($userProfileJson | ConvertFrom-Json)
	}
	else {
		$userProfileObject = $UserProfileData | ConvertTo-Json
		[Environment]::SetEnvironmentVariable($cohesityUserProfile, $userProfileObject, 'Process') | Out-Null
	}
}