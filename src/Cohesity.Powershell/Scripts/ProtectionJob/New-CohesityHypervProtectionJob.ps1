function New-CohesityHypervProtectionJob {
    <#
        .SYNOPSIS
        Create a new protection job for HyperV source.
        .DESCRIPTION
        The New-CohesityHypervProtectionJob function is used to create a protection job.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        New-CohesityHypervProtectionJob -Name <string> -PolicyName <string> -StorageDomainName <string> -SourceName <string>
    #>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        $Name,
        [Parameter(Mandatory = $true)]
        $PolicyName,
        [Parameter(Mandatory = $true)]
        $StorageDomainName,
        [Parameter(Mandatory = $true)]
        $SourceName
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
        $timeZone = Get-TimeZone
        $protectionPolicyObject = Get-CohesityProtectionPolicy | Where-Object {$_.name -eq $PolicyName}
        if($null -eq $protectionPolicyObject) {
            Write-Host "Incorrect protection policy name '$PolicyName'"
            return
        }

        $storageDomainObject = Get-CohesityStorageDomain | Where-Object {$_.name -eq $StorageDomainName}
        if($null -eq $storageDomainObject) {
            Write-Host "Incorrect storage domain name '$StorageDomainName'"
            return
        }

        $protectionSourceObject = Get-CohesityProtectionSourceObject | Where-Object {$_.name -eq $SourceName}
        if($null -eq $protectionSourceObject) {
            Write-Host "There are no source found with the name '$SourceName'"
            return
        }
        if("System.Array" -eq $protectionSourceObject.GetType().BaseType.ToString()) {
            # In case the name of the object is same across different registered sources
            Write-Host "There are multiple objects found for the search item, selecting the first item as source"
            $protectionSourceObject = $protectionSourceObject[0]
        }

        $url = $server + '/irisservices/api/v1/public/protectionJobs'

        $headers = @{'Authorization' = 'Bearer ' + $token }
        $payload = @{
            name           = $PolicyName
            policyId       = $protectionPolicyObject.Id
            _policyName    = $protectionPolicyObject.Name
            viewBoxId      = $storageDomainObject.Id
            _viewBoxName   = $storageDomainObject.Name
            timezone       = $timeZone.Id
            environment    = "kHyperVVSS"
            sourceIds      = @($protectionSourceObject.Id)
            parentSourceId = $protectionSourceObject.ParentId
        }
        $payloadJson = $payload | ConvertTo-Json -Depth 100
        $resp = Invoke-RestApi -Method Post -Uri $url -Headers $headers -Body $payloadJson
        if ($resp) {
            $resp
        }
        else {
            Write-Host "Protection job : Failed to create job for HyperV"
            Write-Host $Global:CohesityAPIError
        }
    }
    End {
    }
}