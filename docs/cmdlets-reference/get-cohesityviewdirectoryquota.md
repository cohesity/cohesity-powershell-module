# Get-CohesityViewDirectoryQuota

## SYNOPSIS
Request to fetch directory quota for a view filtered by specified parameters.

## SYNTAX

```
Get-CohesityViewDirectoryQuota [[-ViewName] <String>] [[-PageCount] <Int32>] [<CommonParameters>]
```

## DESCRIPTION
The Get-CohesityViewDirectoryQuota function is used to fetch directory quota for a view.

## EXAMPLES

### EXAMPLE 1
```
Get-CohesityViewDirectoryQuota -ViewName view1
```

### EXAMPLE 2
```
Get-CohesityViewDirectoryQuota -ViewName view1 -PageCount 10
```

Returns only specified count of view directory quota for each rest api call

## PARAMETERS

### -ViewName
Specifies view name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageCount
Specifies number of views to be returned in each api call

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
