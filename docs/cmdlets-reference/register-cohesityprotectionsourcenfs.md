# Register-CohesityProtectionSourceNFS

## SYNOPSIS
Registers a new NFS mount point as protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceNFS -MountPath <string> [<CommonParameters>]
```

## DESCRIPTION
Registers a new NFS mount point as protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceNFS -MountPath "file-server.example.com:/sourcevol"
```

Registers a new NFS mount point with mount path "file-server.example.com:/sourcevol" with the Cohesity Cluster.

## PARAMETERS

### -MountPath
NFS Mount path.

```yaml
Type: string
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

### Cohesity.Models.ProtectionSource
## NOTES

## RELATED LINKS
