---
external help file: Cohesity.PowerShell.dll-Help.xml
Module Name: Cohesity
online version: null
schema: 2.0.0
---

# Get-CohesityProtectionSource

## SYNOPSIS

Returns the registered Protection Sources.

## SYNTAX

```text
Get-CohesityProtectionSource [-Environments <EnvironmentEnum[]>] [-Id <Int64>] [<CommonParameters>]
```

## DESCRIPTION

If no parameters are specified, all Protection Sources that are registered on the Cohesity Cluster are returned.

## EXAMPLES

### Example 1

```text
PS C:\> {{ Add example code here }}
```

## PARAMETERS

### -Environments

Return only Protection Sources that match the passed in environment type. For example, set this parameter to 'kVMware' to only return the VMware sources. NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.

```yaml
Type: EnvironmentEnum[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id

Return only the Protection Source that matches the Id.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about\_CommonParameters \([http://go.microsoft.com/fwlink/?LinkID=113216](http://go.microsoft.com/fwlink/?LinkID=113216)\).

## INPUTS

## OUTPUTS

### Cohesity.Models.ProtectionSourceNode

## NOTES

## RELATED LINKS

