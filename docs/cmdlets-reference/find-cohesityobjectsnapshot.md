# Find-CohesityObjectSnapshot

## SYNOPSIS
List the snapshots for a given object using cohesity v2 REST API.

## SYNTAX

```
Find-CohesityObjectSnapshot [-ObjectId <Int64>] [-JobId <String[]>] [<CommonParameters>]
```

## EXAMPLES

### EXAMPLE 1
```
Find-CohesityObjectSnapshot -ObjectId 12
```

Returns list of snapshot information of specified object with id 12.

### EXAMPLE 2
```
Find-CohesityObjectSnapshot -ObjectId 12 -JobId 1111:2222:12
```

Returns list of snapshot information of specified object with id 12, which is protected through specified protection job.

## PARAMETERS

### -ObjectId
Specifies the id of the Object.

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

### -JobId
List of protection group id. If specified, this returns only the snapshots of the specified object ID, which belong to the provided protection group IDs.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Cohesity.Model.ObjectSnapshot
## NOTES

## RELATED LINKS
[Read More](https://cohesity.github.io/cohesity-powershell-module/#/README)
