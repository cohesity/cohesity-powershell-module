# get protection job details that includes protection policy and protected object name

$jobs = Get-CohesityProtectionJob
foreach($job in $jobs) {
	$environment = $job.environment
	$policyObject = Get-CohesityProtectionPolicy -Ids $job.policyId
	$policyName = $policyObject.name
	write-host "Job name :" $job.name "(Policy: $policyName)(Environment : $environment)"
	# the sourceIds contains source object ids
	foreach($sourceId in $job.sourceIds) {
		# get the details for each of the object
		$sourceObject = Get-CohesityProtectionSource -Id $sourceId
		write-host $sourceObject.name
	}
	write-host "=================="
}
