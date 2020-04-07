#connect the cluster
Connect-CohesityCluster -Server 10.2.148.61 -Credential (New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList "admin", (ConvertTo-SecureString -AsPlainText "admin" -Force))

#create a view "TestView1" in the storage domain (view box) "DefaultStorageDomain"
$respView = New-CohesityView -Name TestView1 -StorageDomainName DefaultStorageDomain

#query the recently created view
$newView = Get-CohesityView -ViewNames $respView.Name

#changing the description of view using pipe
$newView.Description = "Updated the view desc"
$newView | Set-CohesityView

#add a share name for the view
Add-CohesityViewShare -ViewName $newView.Name -ShareName ("share-"+$newView.Name)

#validate that the share has been created
$respViewShare = Get-CohesityViewShare -ViewName $newView.Name

#cleanup the view share
Remove-CohesityViewShare -ShareName $respViewShare.AliasName -Confirm:$false

#remove the view from the cluster
Remove-CohesityView -Name $newView.Name -Confirm:$false