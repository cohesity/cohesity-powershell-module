$local = [Cohesity.Model.RunJobSnapshotTarget]::new()
$local.type = [Cohesity.Model.RunJobSnapshotTarget+TypeEnum]::KLocal
$local.daysToKeep = 10

$vault = (Get-CohesityVault)[0]
# select a vault
$archivalTarget = [Cohesity.Model.ArchivalExternalTarget]::new()
$archivalTarget.VaultType = $vault.externalTargetType
$archivalTarget.VaultId = $vault.id
$archivalTarget.VaultName = $vault.name


$replication = (Get-CohesityRemoteCluster)[0]
# set the target for replication
$replicationTarget = [Cohesity.Model.ReplicationTargetSettings]::new()
$replicationTarget.ClusterId = $replication.ClusterId
$replicationTarget.ClusterName = $replication.Name

$copyRunTargets = @()

$targetArchive = [Cohesity.Model.RunJobSnapshotTarget]::new()
$targetArchive.Type = [Cohesity.Model.RunJobSnapshotTarget+TypeEnum]::KArchival
$targetArchive.DaysToKeep = 30
$targetArchive.ArchivalTarget = $archivalTarget

$targetReplication = [Cohesity.Model.RunJobSnapshotTarget]::new()
$targetReplication.Type = [Cohesity.Model.RunJobSnapshotTarget+TypeEnum]::KRemote
$targetReplication.DaysToKeep = 20
$targetReplication.ReplicationTarget = $replicationTarget

$copyRunTargets += $local
$copyRunTargets += $targetArchive
$copyRunTargets += $targetReplication

Start-CohesityProtectionJob -Id 2930 -CopyRunTargets $copyRunTargets