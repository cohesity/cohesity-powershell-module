function Find-CohesityFileSnapshot {
    <#
        .SYNOPSIS
        Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.
        .DESCRIPTION
        Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Find-CohesityFileSnapshot -FileName "abc.txt" -SourceId 123 -JobId 11
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
        [long]$SourceId
    )
    Begin {
    }

    Process {
        $snapshotURL = '/irisservices/api/v1/public/restore/files/snapshotsInformation'

        $filter = ""
        if ($FileName) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "filename=$FileName"
        }
        if ($JobId) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "jobId=$JobId"
        }
        if ($SourceId) {
            if ($filter -ne "") {
                $filter += "&"
            }
            $filter += "sourceId=$SourceId"
        }

        if ($filter -ne "") {
            $snapshotURL += "?" + $filter
        }

        $snapshotResp = Invoke-RestApi -Method Get -Uri $snapshotURL
        if ($snapshotResp) {
            # tagging reponse for display format ( configured in Cohesity.format.ps1xml )
            @($snapshotResp | Add-Member -TypeName 'System.Object#FileSnapshotInformation' -PassThru)
        }
    }

    End {
    }
}