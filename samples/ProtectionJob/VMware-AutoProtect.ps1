# Auto protect virtual machines
$serverIP = "1.1.1.1"
Connect-CohesityCluster -Server $serverIP -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "admin", (ConvertTo-SecureString -AsPlainText 'admin' -Force))

# Filter out the non-virtual machine resources
$nonVMs = (Get-CohesityProtectionSourceObject -Environments KVMware -IncludeDatastores -IncludeNetworks -IncludeVMFolders) | Where-Object {$_.vmWareProtectionSource.type -ne "kVirtualMachine"}


# Select one of the Ids from $nonVMs(in this case 438) and create a protection job to auto protect.
New-CohesityProtectionJob -Name "auto-protect" -PolicyName Bronze -ParentSourceId 1 -SourceIds 438 -StorageDomainName DefaultStorageDomain -Environment KVMware


# You can also add another source to your protection job. Find another source(in this case 17)
$job = Get-CohesityProtectionJob -Names "auto-protect"
$job.sourceIds += 17

# Now the job object is ready to be updated
Set-CohesityProtectionJob -ProtectionJob $job
