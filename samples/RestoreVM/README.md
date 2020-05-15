### Restore a VM on the alternate vcenter
./restoreRemoteVM.ps1 -VIP 10.2.37.144 -UserName admin  -JobName "repl-2" -VMName "gary-flr-ubuntu" -Prefix "test-4" -Suffix "-tail" -TargetParentId 4 -TargetResourcePoolId 43 -TargetDatastoreId 16 -TargetVMFolderId 9
