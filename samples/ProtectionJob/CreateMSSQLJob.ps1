###
# Use the generic cmdlet to create an MSSQL protection job
###

# get the protection policy detail
$policy = Get-CohesityProtectionPolicy -Names Bronze
$policyId = $policy.id
# get the storage domain details
$storageDomain = Get-CohesityStorageDomain -Names DefaultStorageDomain
$storageDomainId = $storageDomain.id
# get the necessary info about the SQL servers
$rootObject = Get-CohesityMSSQLObject | Where-Object {$_.parentId -eq $null}
# get all database info
$dbObjects = Get-CohesityMSSQLObject
# select a database
$dbId = $dbObjects[1].id
# identify the instance id of the database
$instanceId = $dbObjects[1].ParentId

# construct the source special parameters
$sourceSpecialParam = [Cohesity.Model.SourceSpecialParameter]::new()
$sourceSpecialParam.SourceId = $instanceId
$sourceSpecialParam.SqlSpecialParameters = [Cohesity.Model.ApplicationSpecialParameters]::new()
$sourceSpecialParam.SqlSpecialParameters.ApplicationEntityIds = New-Object 'System.Collections.Generic.List[int64]'
$sourceSpecialParam.SqlSpecialParameters.ApplicationEntityIds.Add($dbId)


# now we have all the info to create an MSSQL proteciton job object
$protectionJobObject = [Cohesity.Model.ProtectionJob]::new()
$protectionJobObject.name = "mssql-job"
$protectionJobObject.policyId = "$policyId"
$protectionJobObject.viewBoxId = $storageDomainId
$protectionJobObject.timezone = "America/Los_Angeles"
$protectionJobObject.environment = "kSQL"
$protectionJobObject.sourceIds = New-Object 'System.Collections.Generic.List[int64]'
$protectionJobObject.sourceIds.Add($instanceId)
$protectionJobObject.parentSourceId = $rootObject.Id
$protectionJobObject.sourceSpecialParameters = New-Object 'System.Collections.Generic.List[Cohesity.Model.SourceSpecialParameter]'
$protectionJobObject.sourceSpecialParameters.Add($sourceSpecialParam)

$environmentParams = [Cohesity.Model.EnvironmentTypeJobParameters]::new()
$sqlParameters = [Cohesity.Model.SqlEnvJobParameters]::new()
$sqlParameters.userDatabasePreference = "kBackupAllDatabases"
$sqlParameters.numStreams = 1
$sqlParameters.backupSystemDatabases = $true
$sqlParameters.backupType = "kSqlNative"
$sqlParameters.withClause = ""
$sqlParameters.isCopyOnlyFull = $true
$sqlParameters.aagPreference = "kPrimaryReplicaOnly"
$sqlParameters.backupType = "kSqlVSSVolume"
$environmentParams.sqlParameters = $sqlParameters
$protectionJobObject.environmentParameters = $environmentParams

# use the generic protection job cmdlet to create an MSSQL protection job
New-CohesityGenericProtectionJob -ProtectionJobObject $protectionJobObject -Confirm:$false
