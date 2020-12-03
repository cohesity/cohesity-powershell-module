function Save-CohesityFile {
    <#
        .SYNOPSIS
        Request to download the specified file from the specified server.
        .DESCRIPTION
        The Save-CohesityFile function is used to download specific file using REST API from the specified server under tthe specified target folder.
        .NOTES
        If target path is not specified, then file will be downloaded under home folder
        .EXAMPLE
        Save-CohesityFile -FileName sfile1 -ServerName server1 -OutFile dfile1
        Download the specified file from the server under specified target path
        .EXAMPLE
        Save-CohesityFile -FileName sfile1 -ServerName server1
        Download the specified file from the server under home path
        .NOTES
        *** Only files can be downloaded
        *** If multiple files found for the specified file search, then the first occured file of the specified server (in search result) will be downloaded
        *** The latest snapshot will be used for downloading the file
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        # Specifies the name of the file.
        $FileName,
        [Parameter(Mandatory = $false)]
        # Specifies the output file.
        $OutFile = $null,
        [Parameter(Mandatory = $true)]
        # Specifies the name of the server.
        $ServerName
    )

    Begin {
        if (-not (Test-Path -Path "$HOME/.cohesity")) {
            throw "Failed to authenticate. Please connect to the Cohesity Cluster using 'Connect-CohesityCluster'"
        }
        $session = Get-Content -Path $HOME/.cohesity | ConvertFrom-Json

        $server = $session.ClusterUri

        $token = $session.Accesstoken.Accesstoken
    }

    Process {
        # Search for file/folder and fetch entity info
        $EncodedFileName = [System.Web.HttpUtility]::UrlEncode($FileName)
        $searchUrl = $server + '/irisservices/api/v1/public/restore/files?search=' + $EncodedFileName
        $headers = @{'Authorization' = 'Bearer ' + $token }
        $rfObj = Invoke-RestApi -Method 'Get' -Uri $searchUrl -Headers $headers

        $entityInfo = $null
        if ($rfObj.files) {
            # Fetch the first appeared file in the response for the specified server
            # Note: Only file can be downloaded
            $entityInfo = $rfObj.files | Where-Object { $_.protectionSource.name -eq $ServerName -and !$_.isFolder }

            if ($entityInfo) {
                $AbsolutePath = $entityInfo[0].filename
                $EncodedFileName = [System.Web.HttpUtility]::UrlEncode($AbsolutePath)
                $SourceId = $entityInfo[0].sourceId
                $JobId = $entityInfo[0].jobId
                $ClusterId = $entityInfo[0].jobUid.clusterId
                $ClusterIncarnationId = $entityInfo[0].jobUid.clusterIncarnationId
                $ViewBoxId = $entityInfo[0].viewBoxId

                # Get the information for fetching the snapshots info of the specified file
                #   In addition, information about the specified file for downloading workflow
                $queryParam = [ordered]@{}
                $queryParam.Add('jobId', $JobId)
                $queryParam.Add('clusterId', $clusterId)
                $queryParam.Add('clusterIncarnationId', $ClusterIncarnationId)
                $queryParam.Add('sourceId', $SourceId)
                $queryParam.Add('filename', $EncodedFileName)
                $queryString = '?' + ($queryParam.Keys.ForEach( { "$_=$($queryParam.$_)" }) -join '&')

                $snapshotUrl = $server + '/irisservices/api/v1/public/restore/files/snapshotsInformation' + $queryString
                $snapshotObj = Invoke-RestApi -Method 'Get' -Uri $snapshotUrl -Headers $headers

                # Get the required information for downloading the file
                # By default, the latest snapshot will be considered for downloading the file
                $latestSnapshot = $snapshotObj[0]
                $dwldParam = [ordered]@{}
                $dwldParam.Add('attemptNum', $latestSnapshot.snapshot.attemptNumber)
                $dwldParam.Add('clusterId', $clusterId)
                $dwldParam.Add('clusterIncarnationId', $ClusterIncarnationId)
                $dwldParam.Add('entityId', $SourceId)
                $dwldParam.Add('filepath', $EncodedFileName)
                $dwldParam.Add('jobId', $JobId)
                $dwldParam.Add('jobInstanceId', $latestSnapshot.snapshot.jobRunId)
                $dwldParam.Add('jobStartTimeUsecs', $latestSnapshot.snapshot.startedTimeUsecs)
                $dwldParam.Add('viewBoxId', $ViewBoxId)

                $dwldQS = '?' + ($dwldParam.Keys.ForEach( { "$_=$($dwldParam.$_)" }) -join '&')
                $downloadUrl = $server + '/irisservices/api/v1/downloadfiles' + $dwldQS

                # Perform web request to download the file from the cluster
                $fn = Split-Path -Path $AbsolutePath -Leaf
                $OutFile = Join-Path $(if ($OutFile) { $OutFile } else { $Home }) $fn
                $resp = Invoke-RestApi -Method 'Get' -Uri $downloadUrl -Headers $headers -OutFile "$OutFile"

                if ($resp) {
                    Write-Output "Successfully downloaded the file in '$OutFile'." -ForegroundColor Green
                }
            }
            else {
                $warnMsg = "Server '$ServerName' not found."
                Write-Warning $warnMsg
                CSLog -Message $warnMsg
            }
        }
        else {
            if ($Global:CohesityAPIError) {
                if ($Global:CohesityAPIError.StatusCode -ne 'Unauthorized') {
                    $errorMsg = "Failed to fetch information for the file '$FileName'."
                    Write-Error $errorMsg
                    CSLog -Message $errorMsg
                }
            }
            else {
                $warnMsg = "No files found with specified name."
                Write-Warning $warnMsg
                CSLog -Message $warnMsg
            }
        }
    } # End of process
} # End of function
