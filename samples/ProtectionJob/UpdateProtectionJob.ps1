# get the job
$job = Get-CohesityProtectionJob -Names job-vmware

#if the attribute does not exists
# $job | Add-Member -NotePropertyName AlertingPolicy -NotePropertyValue @()

# set the alerting policy
$job.alertingPolicy = @("kFailure","kSlaViolation")

# create the alerting config object
$config = [Cohesity.Model.AlertingConfig]::new()
$config.EmailAddresses = @("abc@cohesity.com","xyz@cohesity.com")
# append the member 'AlertingConfig' if it does not exists in $job
$job | Add-Member -NotePropertyName AlertingConfig -NotePropertyValue $config

# the job is ready to be updated
$job | Set-CohesityProtectionJob -Confirm:$false
