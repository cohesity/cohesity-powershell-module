function Find-CohesityObjectSnapshot {
    <#
        .SYNOPSIS
        List the snapshots for a given object.
        .DESCRIPTION
        List the snapshots for a given object.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Find-CohesityObjectSnapshot -ObjectId 12
        Returns list of snapshot information of specified object with id 12.
        .EXAMPLE
        Find-CohesityObjectSnapshot -ObjectId 12 -ProtectionGroupIds 1111:2222:12
        Returns list of snapshot information of specified object with id 12, which is protected through specified protection job.
    #>

    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        # Specifies the id of the Object.
        [Parameter(Mandatory = $true)]
        [string]$ObjectId,
        # List of protection group id. If specified, this returns only the snapshots of the specified object ID, which belong to the provided protection group IDs.
        [Parameter(Mandatory = $false)]
        [string[]]$ProtectionGroupIds
    )
    Begin {
    }

    Process {
        $snapshotURL = '/v2/data-protect/objects/' + $ObjectId + '/snapshots'

        $filter = ""
        if ($JobId) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "protectionGroupIds=$ProtectionGroupIds"
        }

        if ($filter -ne "") {
            $snapshotURL += "?" + $filter
        }

        $snapshotResp = Invoke-RestApi -Method Get -Uri $snapshotURL

        if ($snapshotResp -and $snapshotResp.snapshots) {
            $snapshotObj =  $snapshotResp.snapshots
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($snapshotObj | Add-Member -TypeName 'System.Object#ObjectSnapshot' -PassThru)
        }
    }

    End {
    }
}