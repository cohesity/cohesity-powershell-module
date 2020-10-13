######################################## CREATE AND CONSTRUCT THE ARCHIVAL TARGET #################################
#create a policy, keep the policy object ready
$policyName = "archival-policy"
New-CohesityProtectionPolicy -PolicyName $policyName -BackupInHours 900 -RetainInDays 999 -Confirm:$false
$customPolicy = Get-CohesityProtectionPolicy -Names $policyName
#identify the target vault for archival
$vault = (Get-CohesityVault)[0]

# set the target for archival
$archivalTarget = [Cohesity.Model.ArchivalExternalTarget]::new()
$archivalTarget.VaultType = $vault.externalTargetType
$archivalTarget.VaultId = $vault.id
$archivalTarget.VaultName = $vault.name

#initialize the archival object
$archivalObject = [Cohesity.Model.SnapshotArchivalCopyPolicy]::new()
$archivalObject.Periodicity = [Cohesity.Model.SnapshotArchivalCopyPolicy+PeriodicityEnum]::KDay
$archivalObject.Target = $archivalTarget

# update the protection policy
$customPolicy.SnapshotArchivalCopyPolicies = @()
$customPolicy.SnapshotArchivalCopyPolicies += $archivalObject
$customPolicy | Set-CohesityProtectionPolicy

# now the protection policy is ready to be used for archival, it can be associated with a protection job
$customPolicy = Get-CohesityProtectionPolicy -Names $policyName
write-host $customPolicy | ConvertTo-Json