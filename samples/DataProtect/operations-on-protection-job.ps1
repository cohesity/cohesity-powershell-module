#connect the cluster
Connect-CohesityCluster -Server 10.2.148.61 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "admin", (ConvertTo-SecureString -AsPlainText "admin" -Force))

#prepare to get all the mandatory items to generate a proteciton job
# 1. Create a protection source object to protect, otherwise query with Get-CohesityProtectionSourceObject 
$respProtectionSource = New-CohesityView -Name "TestView1" -AccessProtocol KS3Only -StorageDomainName "DefaultStorageDomain"

# 2. Get the protection policy
$respProtectionPolicy = Get-CohesityProtectionPolicy -Names "Gold"

# 3. Get the storage domain (view box)
$respStorageDomain = Get-CohesityStorageDomain -Names "DefaultStorageDomain"

# 4. Its time to create the protection job
$resp = New-CohesityProtectionJob -Name "sample-protection-job" -Description 'This is a sample job' -PolicyId $respProtectionPolicy.id -Environment kView -ViewName $respProtectionSource.Name -StorageDomainId $respStorageDomain.id

#the job has been created, give enough time for the cluster to initialize the job
Write-Host "Let the job gets initialized"
Start-Sleep -s 5

#get the latest job detail
$respProtectionJob = Get-CohesityProtectionJob  -Ids $resp.id

#get the latest job run details
$respJobRun = Get-CohesityProtectionJobRun -JobId $respProtectionJob.id

#make an attempt to stop the job
#$resp = Stop-CohesityProtectionJob -Id $protectionJobId -JobRunId $respJobRun.backupRun.jobRunId

#or suspend the job
$resp = Suspend-CohesityProtectionJob -Id $respProtectionJob.id

#wait for few seconds
Write-Host "Wait for a moment before resuming job"
Start-Sleep -s 5

#resume the operation
$resp = Resume-CohesityProtectionJob -Id $respProtectionJob.id

#update the job
$respProtectionJob.Description = "Updating the job"
$respProtectionJob | Set-CohesityProtectionJob

#will cleanup the job
$resp = Remove-CohesityProtectionJob -Id $respProtectionJob.id -Confirm:$false

#remove the view from the cluster
Remove-CohesityView -Name $respProtectionSource.Name -Confirm:$false