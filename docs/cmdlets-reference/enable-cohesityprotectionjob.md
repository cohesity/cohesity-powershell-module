# Enable-CohesityProtectionJob

## SYNOPSIS
Activates the specified protection job.

## SYNTAX

### ByName (Default)
```
Enable-CohesityProtectionJob -Name <String> -PolicyId <String> -ParentSourceId <Int64> [<CommonParameters>]
```

### ById
```
Enable-CohesityProtectionJob -Id <Int64> -PolicyId <String> -ParentSourceId <Int64> [<CommonParameters>]
```

## DESCRIPTION
Activates the specified protection job.
This is used for failback scenario on remote cluster.

## EXAMPLES

### EXAMPLE 1
```
Enable-CohesityProtectionJob -Id 1234 -PolicyId "437211583895198:1541716981258:3" -ParentSourceId 13
```

Activates a protection job with the id of 1234 and associates it with the specified policy id and source id.

## PARAMETERS

### -Id
Specifies the unique id of the protection job.

```yaml
Type: Int64
Parameter Sets: ById
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
Type: String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyId
Specifies the unique id of the protection policy to be associated with the protection job.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentSourceId
Specifies the unique id of the parent protection source (eg.
a vCenter server) protected by this protection job.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
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
