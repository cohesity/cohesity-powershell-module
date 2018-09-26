# Upgrade the Cohesity agents on registered Physical servers
You can use a combination of `Get-CohesityPhysicalAgent` and `Update-CohesityPhysicalAgent` cmdlets to achieve this task.

### Example
```powershell
Get-CohesityPhysicalAgent | Where-Object { $_.Upgradability -eq "KUpgradable" } | Update-CohesityPhysicalAgent
```
