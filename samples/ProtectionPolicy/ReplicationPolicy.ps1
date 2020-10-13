######################################## CREATE AND CONSTRUCT THE REPLICATION TARGET #################################
#create a policy, keep the policy object ready
$policyName = "replication-policy"
New-CohesityProtectionPolicy -PolicyName $policyName -BackupInHours 900 -RetainInDays 999 -Confirm:$false
$customPolicy = Get-CohesityProtectionPolicy -Names $policyName
#identify the target remote cluster for replication
$replication = (Get-CohesityRemoteCluster)[0]

# set the target for replication
$replicationTarget = [Cohesity.Model.ReplicationTargetSettings]::new()
$replicationTarget.ClusterId = $replication.ClusterId
$replicationTarget.ClusterName = $replication.Name

#initialize the replication object
$replicationObject = [Cohesity.Model.SnapshotReplicationCopyPolicy]::new()
$replicationObject.Periodicity = [Cohesity.Model.SnapshotReplicationCopyPolicy+PeriodicityEnum]::KDay
$replicationObject.Target = $replicationTarget

# update the protection policy
$customPolicy.SnapshotReplicationCopyPolicies = @()
$customPolicy.SnapshotReplicationCopyPolicies += $replicationObject
$customPolicy | Set-CohesityProtectionPolicy

# now the protection policy is ready to be used for replication, it can be associated with a protection job
$customPolicy = Get-CohesityProtectionPolicy -Names $policyName
write-host $customPolicy | ConvertTo-Json