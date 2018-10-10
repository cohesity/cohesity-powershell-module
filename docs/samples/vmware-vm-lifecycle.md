# VMware protection - Example Workflow

## Connect to the Cohesity Cluster
First make sure that you are connected to a Cohesity Cluster
```powershell
Connect-CohesityCluster -Server cohesity-cluster -Credential (Get-Credential)
```

## Register a new vCenter with Cohesity
```powershell
$vcenter = Register-CohesityProtectionSourceVMware -Server vcenter-server -Type KVCenter -Credential (Get-Credential)
$vcenter
```

## Get a list of VMware VMs on the newly registered vCenter
```powershell
Get-CohesityVMwareVM -ParentSourceId $vcenter.Id
```

If you want to narrow down the selection by matching a pattern, you may do something like:
```powershell
$vms = Get-CohesityVMwareVM | Where-Object {$_.Name -match "linux"}
$vms
```

## Create a new protection job to protect the selected VMs
```powershell
New-CohesityProtectionJob -Name "linux-vms" -Description "Backup linux vms" -PolicyName "Bronze" -StorageDomainName "DefaultIddStorageDomain" -ParentSourceId $vms[0].ParentId -SourceIds ($vms).Id -Environment kVMware
```

We can check that the job was created properly
```powershell
$job = Get-CohesityProtectionJob -Names "linux-vms"
$job
```
The job would run automatically after it is created, by default.

You can monitor the job run using below:
```powershell
Get-CohesityProtectionJobRun -JobId $job.Id
```

## Restore the backed up VM to the original location
After the backup run is successful, we can restore a VM to its original location as shown below:
```powershell
$task = Restore-CohesityVMwareVM -TaskName "restore-task-linux" -SourceId $vms[0].Id -JobId $job.Id -VmNamePrefix "copy-"
$task
```

## Monitor the progress of the restore
```powershell
Get-CohesityRestoreTask -Ids $task.Id
```
