# Disable-CohesityProtectionJob

## SYNOPSIS
Deactivates the specified protection job.

## SYNTAX

### UNNAMED_PARAMETER_SET_1
```
Disable-CohesityProtectionJob -Id <long> [-PowerOffVms] [<CommonParameters>]
```

### UNNAMED_PARAMETER_SET_2
```
Disable-CohesityProtectionJob -Name <string> [-PowerOffVms] [<CommonParameters>]
```

## DESCRIPTION
Deactivates the specified protection job.
This is used for failover to a remote cluster.

## EXAMPLES

### EXAMPLE 1
```
Disable-CohesityProtectionJob -Id 1234
```

Deactivates the protection job with the Id of 1234.

### EXAMPLE 2
```
Disable-CohesityProtectionJob -Name "vm-replication-job" -PowerOffVms
```

Deactivates the protection job with the name "vm-replication-job" and also powers off the associated VMs in VMware environment.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

```yaml
Type: long
Parameter Sets: UNNAMED_PARAMETER_SET_1
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specifies the name of the protection job.

```yaml
Type: string
Parameter Sets: UNNAMED_PARAMETER_SET_2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PowerOffVms
Specifies whether to power off the VMs in VMware environment.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64
Specifies the unique id of the protection job.

## OUTPUTS

## NOTES

## RELATED LINKS
