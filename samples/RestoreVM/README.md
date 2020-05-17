### Restore a VM on the source vcenter
```
./restoreRemoteVM.ps1 -VIP 10.2.37.144 -UserName admin  -JobName "repl-2" -VMName "gary-flr-ubuntu" -Prefix "test-4" -Suffix "-tail"
```

### Restore a VM on the alternate vcenter
```
./restoreRemoteVM.ps1 -VIP 10.2.37.144 -UserName admin  -JobName "repl-2" -VMName "gary-flr-ubuntu" -Prefix "test-4" -Suffix "-tail" -TargetParentId 4 -TargetResourcePoolId 43 -TargetDatastoreId 16 -TargetVMFolderId 9
```

### Parameter details
- VIP : Cohesity cluster IP
- UserName : Cohesity cluster user name
- Domain : Domain of the user (Optional)
- JobName : Job name from which the VM is sought
- VMName : VM name from protected by <JobName>
- Prefix : Renaming target VM with a prefix (Optional)
- Suffix : Renaming target VM with a suffix (Optional)
- JobRunId : Job run id for the protection job (Optional)
- TaskName : Restore task name (Optional)
- ContinueOnError : Continue the restore operation in case of error (Optional)
- PowerOn : Power switch for the VM (Optional)
- TargetParentId : New vcenter id, when the vm is targeted for an alternate vcenter (Optional)
- TargetResourcePoolId : Resourcepool id in the alternate vcenter (Optional)
- TargetDatastoreId : Datastrore id in the alternate vcenter (Optional)
- TargetVMFolderId : VM folder id in the alternate vcenter (Optional)
