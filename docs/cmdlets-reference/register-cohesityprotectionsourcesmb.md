# Register-CohesityProtectionSourceSMB

## SYNOPSIS
Registers a new SMB file share as protection source with the Cohesity Cluster.

## SYNTAX

```
Register-CohesityProtectionSourceSMB -MountPath <String> -Credential <PSCredential> [-SkipValidation <Boolean>]
 [<CommonParameters>]
```

## DESCRIPTION
Registers a new SMB file share as protection source with the Cohesity Cluster.

## EXAMPLES

### EXAMPLE 1
```
Register-CohesityProtectionSourceSMB -MountPath "\\smb-server.example.com\share -Credential (Get-Credential)"
```

Registers a new SMB file share with mount path "\\\\smb-server.example.com\share" with the Cohesity Cluster.

## PARAMETERS

### -MountPath
NFS Mount path.

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

### -Credential
User credentials for accessing the SMB file share.

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipValidation
Skip SMB validation registration

```yaml
Type: Boolean
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

## OUTPUTS

### Cohesity.Model.ProtectionSource
## NOTES

## RELATED LINKS
