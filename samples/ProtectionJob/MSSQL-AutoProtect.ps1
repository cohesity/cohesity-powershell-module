# Auto protect virtual machines
$serverIP = "10.14.31.156"
Connect-CohesityCluster -Server $serverIP -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "admin", (ConvertTo-SecureString -AsPlainText 'admin' -Force))

# Filter out the non-database resources
$nonDBs = (Get-CohesityProtectionSourceObject -Environments KSQL ) | Where-Object {$_.sqlProtectionSource.type -ne "kDatabase"}


# Find the source(in this case 773) from $nonDBs to be auto protected
$job = Get-CohesityProtectionJob -Names "mssql-auto-protect"
# Ensure that the $job.sourceSpecialParameters[0].sourceId and the parent of 773 is same
$job.sourceSpecialParameters[0].sqlSpecialParameters.applicationEntityIds += 773


# Now the job object is ready to be updated
Set-CohesityProtectionJob -ProtectionJob $job
