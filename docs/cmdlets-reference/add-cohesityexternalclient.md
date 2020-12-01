# Add-CohesityExternalClient

## SYNOPSIS
Add an external client IP.

## SYNTAX

```
Add-CohesityExternalClient [-IP4] <Object> [-NetmaskIP4] <Object> [[-NFSRootSquash] <Boolean>]
 [[-NFSAccess] <Object>] [[-NFSAllSquash] <Boolean>] [[-SMBAccess] <Object>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The Add-CohesityExternalClient function is used to add external client (global whitelist) IP.

## EXAMPLES

### EXAMPLE 1
```
Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0"
```

Add an external client as the global whitelist IP(s)

### EXAMPLE 2
```
Add-CohesityExternalClient -IP4 "1.1.1.1" -NetmaskIP4 "255.255.255.0" -NFSRootSquash:$false -NFSAccess "kReadWrite" -NFSAllSquash:$false -SMBAccess "kReadWrite"
```

Add an external client as the global whitelist IP(s) with optional parameters

## PARAMETERS

### -IP4
Specifies an IPv4 address.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetmaskIP4
Specifies the netmask using an IP4 address.
The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NFSRootSquash
Specifies whether clients from this subnet can mount as root on NFS.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -NFSAccess
Specifies whether clients from this subnet can mount using NFS protocol.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: KReadWrite
Accept pipeline input: False
Accept wildcard characters: False
```

### -NFSAllSquash
Specifies whether all clients from this subnet can map view with view_all_squash_uid/view_all_squash_gid configured in the view.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SMBAccess
Specifies whether clients from this subnet can mount using SMB protocol.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: KReadWrite
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

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

### System.Collections.ArrayList
## NOTES
Published by Cohesity

## RELATED LINKS

[https://cohesity.github.io/cohesity-powershell-module/#/README](https://cohesity.github.io/cohesity-powershell-module/#/README)

