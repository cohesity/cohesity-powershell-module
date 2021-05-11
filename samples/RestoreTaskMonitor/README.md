## Use the script to monitor the restore tasks for MSSQL objects.

### Monitor restore tasks.
```
./MonitorRestoreTasks.ps1 -TaskIds 73212
```

### Set the monitor frequency
```
./MonitorRestoreTasks.ps1 -TaskIds 73212 -MonitorFrequencyInSec 5
```

### Use verbose to see the API calls
```
./MonitorRestoreTasks.ps1 -TaskIds 73212 -Verbose
```
