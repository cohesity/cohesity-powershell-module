---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name:
online version:
schema: 2.0.0
---

# Set-CohesityProtectionJobRun

## SYNOPSIS
Update how long Protection Job Runs and their snapshots are retained on the Cohesity Cluster.

## SYNTAX

```
Set-CohesityProtectionJobRun -JobRuns <UpdateProtectionJobRun[]> [<CommonParameters>]
```

## DESCRIPTION
Update the expiration date (retention period) for the specified Protection Job Runs and their snapshots.
After an expiration time is reached, the Job Run and its snapshots are deleted.
If an expiration time of 0 is specified, a Job Run and its snapshots are immediately deleted.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -JobRuns
Specifies the Job Runs to update with a new expiration times.

```yaml
Type: UpdateProtectionJobRun[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
