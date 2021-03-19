## Use the script to get the cluster details

### Query all the protection job from helios.
```
./ClusterInfo.ps1 -HeliosServer "https://helios.mycompany.com" -HeliosAPIKey "YOUR_API_KEY"
```

### Query all the protection job from helios with verbose detail.
```
./ClusterInfo.ps1 -HeliosServer "https://helios.mycompany.com" -HeliosAPIKey "YOUR_API_KEY" -Verbose
```

### Filter protection jobs with inactive and deleted jobs.
```
./ClusterInfo.ps1 -HeliosServer "https://helios.mycompany.com" -HeliosAPIKey "YOUR_API_KEY" -SkipInactiveJobs -SkipDeletedJobs
```

### Filter items with given object cluster names.
```
./ClusterInfo.ps1 -HeliosServer "https://helios.mycompany.com" -HeliosAPIKey "YOUR_API_KEY" -VMwareObjectClusterNames "Cluster1", "Cluster2"
```

The details will be available in the following format
Cohesity_Cluster_Name    |	  Protection_ Job/Group_Name  	|   VMware_Object_Cluster_Name  	 | VMware_Source_vCenter_Name  
