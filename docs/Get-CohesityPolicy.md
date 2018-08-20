---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version:
schema: 2.0.0
---

# Get-CohesityPolicy

## SYNOPSIS
Gets a list of Protection Policies filtered by some parameters.

## SYNTAX

```
Get-CohesityPolicy [[-Environments] <EnvironmentEnum[]>] [[-IDs] <String[]>] [[-Names] <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
If no parameters are specified, all Protection Policies currently on the Cohesity Cluster are returned.
Specifying parameters filters the results that are returned.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -Environments
Filter by Environment type.
Only Policies protecting the specified environment type are returned.
NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IDs
Filter by a list of Protection Policy ids.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Filter by a list of Protection Policy names.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionPolicy
## NOTES

## RELATED LINKS
