# List Protection Job Start Times
You can use `Get-CohesityProtectionJob` cmdlet to achieve this task.

### Example
```powershell
Get-CohesityProtectionJob | ForEach-Object { "{0:d2}:{1:d2}`t{2}" -f ($_.StartTime.Hour, $_.StartTime.Minute, $_.Name) }
```

### Example Output
```powershell
01:00   VM Backup
01:15   SQL VM Backup
01:30   Physical Block-Based Backup
01:45   NAS Backup
02:00   Oracle
02:15   Infrastructure
02:30   TestDB
```
