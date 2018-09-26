# See most recent unresolved Alerts
You can simply use `Get-CohesityAlert` cmdlet to achieve this task.

### Example
```powershell
Get-CohesityAlert -MaxAlerts 100 -AlertStates kOpen
```
