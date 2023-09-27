function Find-CohesityRemoteFileSnapshot {
    <#
        .SYNOPSIS
        Get the information about snapshots from an external target that contain the specified file or folder. In addition, information about the file or folder is provided.
        .DESCRIPTION
        Get the information about snapshots from an external target that contain the specified file or folder. In addition, information about the file or folder is provided.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Find-CohesityRemoteFileSnapshot -FileName "abc.txt" -SourceId 123 -JobId 11
        .EXAMPLE
        Find-CohesityRemoteFileSnapshot -FileName "abc.txt" -SourceId 123 -JobId 11 -DoNotIncludeIndexedSnapshots
    #>

    [OutputType('System.Array')]
    [CmdletBinding()]
    Param(
        # Specifies the name of the file or folder to find in the snapshots. This field is required.
        [string]$FileName,
        [Parameter(Mandatory = $true)]
        # Specifies the name of the Restore Task.Specifies the id of the Job that captured the snapshots. These snapshots are searched for the specified files or folders. This field is required.
        [long]$JobId,
        [Parameter(Mandatory = $true)]
        # Specifies the id of the Protection Source object (such as a VM) to search. When a Job Run executes, snapshots of the specified Protection Source object are captured. This operation searches the snapshots of the object for the file or folder. This field is required.
        [long]$SourceId,
        [Parameter(Mandatory = $false)]
        # Specifies whether to return indexed snapshots or not. In an indexed snapshots file are guaranteed to exist, while in a non-indexed snapshots file may not exist.
        [switch]$DoNotIncludeIndexedSnapshots
    )
    Begin {
    }

    Process {
        # Get the cluster info
        $clusterURL = '/v2/clusters'
        $clusterResult = Invoke-RestApi -Method Get -Uri $clusterURL
        $clusterId = $clusterResult.id
        $clusterIncarnationId = $clusterResult.incarnationId

        $protectionJobId = "${clusterId}:${clusterIncarnationId}:${jobId}"
        $snapshotURL = '/v2/data-protect/objects/' + $SourceId + '/protection-groups/' + $protectionJobId + '/indexed-objects/snapshots'

        $filter = ""
        if ($FileName) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "indexedObjectName=$FileName"
        }

        if ($DoNotIncludeIndexedSnapshots.IsPresent) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "includeIndexedSnapshotsOnly=false"
        } else {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "includeIndexedSnapshotsOnly=true"
        }

        if ($filter -ne "") {
            $snapshotURL += "?" + $filter
        }

        $snapshotResp = Invoke-RestApi -Method Get -Uri $snapshotURL
        if ($snapshotResp -and $snapshotResp.snapshots) {
            $filteredSnapshotObj =  $snapshotResp.snapshots | Where-Object { $null -ne $_.externalTargetInfo }
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($filteredSnapshotObj | Add-Member -TypeName 'System.Object#IndexedObjectSnapshot' -PassThru)
        }
    }

    End {
    }
}