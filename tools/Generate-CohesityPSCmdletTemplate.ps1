
    <#
        .SYNOPSIS
    Creates a powershell cmdlet template. 
    .DESCRIPTION
    Creates a powershell cmdlet's script template based on the given method type and feature. In case if the user doesn't provide the file path, it will create a file in the current directory.
    .LINK
    https://cohesity.github.io/cohesity-powershell-module/#/README
    .EXAMPLE
    Generate-CohesityPSCmdletTemplate -ActionType <string> -Feature <string>
    Generate-CohesityPSCmdletTemplate -ActionType Get -Feature ProtectionJob 
    Creates a template file for the given feature and Method type in the current location.
    .EXAMPLE
    Generate-CohesityPSCmdletTemplate -ActionType <string> -Feature <string> -FilePath <Path>
    Generate-CohesityPSCmdletTemplate -ActionType Get -Feature ProtectionJob -FilePath /home/Cohesity/
    Creates a template file for the given feature and Method type in the location passed in the FilePath.
    #>

    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateSet("GET", "POST", "PUT", "DELETE", "REGISTER", "COPY")]
        [string]$ActionType,
        [Parameter(Mandatory = $true)]
        [string]$Feature,
        [Parameter(Mandatory = $false)]
        [string]$FilePath = $null
    )

    Begin {
    }

    Process {
        $ActionType = $ActionType.toLower()

        switch -exact ($ActionType) {
            "get" {
                $filePrefix = "Get"
                $httpMethod = "Get"
                $errorMessage = "`"$Feature : Failed to fetch.`""
                break
            }
            "put" {
                $filePrefix = "Update"
                $httpMethod = "Put"
                $errorMessage = "`"$Feature : Failed to update.`""
                break
            }
            "post" {
                $filePrefix = "New"
                $httpMethod = "Post"
                $errorMessage = "`"$Feature : Failed to create.`""
                break
            }
            "delete" {
                $filePrefix = "Remove"
                $httpMethod = "Delete"
                $errorMessage = "`"$Feature : Failed to remove.`""
                break
            }
            "register" {
                $filePrefix = "Register"
                $httpMethod = "Post"
                $errorMessage = "`"$Feature : Failed to register.`""
                break
            }
            "copy" {
                $filePrefix = "Copy"
                $httpMethod = "Post"
                $errorMessage = "`"$Feature : Failed to copy.`""
                break
            }
        }

        # Creating file name of the new template file based on the method type and feature provided by the user like Register-CohesityProtectionJob.ps1 
        $fileName = $filePrefix + '-Cohesity' + $feature + '.ps1'

        # If file path is not provided by the user, current location is taken.
        if (!$FilePath) {
            $fileLoc = "$((Get-Location).Path)/$fileName"
        }
        else {
            $fileLoc = "$FilePath/$fileName"
        }

        # Creating the new file.
        New-item $fileLoc
        $processBlock = $null

        $responseBlock = @"
            if (`$resp) {
                `$resp
            }
            else {
                `$errorMsg = $errorMessage
                Write-Output `$errorMsg
                CSLog -Message `$errorMsg
            }
"@
        if ($ActionType -eq "get") {
            # Creating Process block for template file without body payload part for Get and Delete operation
            $processBlock = @"
           `$resp = Invoke-RestApi -Method $httpMethod -Uri `$cohesityUrl -Headers `$cohesityHeaders
            $responseBlock
"@
        }
        else {
            # Creating Process block for template file with body payload part for Post, Put, Register operation
            $processBlock = @"
            if(`$PSCmdlet.ShouldProcess(`$Param1)) {
               `$payload = @{}
               `$payloadJson = `$payload | ConvertTo-Json -Depth 100
               `$resp = Invoke-RestApi -Method $httpMethod -Uri `$cohesityUrl -Headers `$cohesityHeaders -Body `$payloadJson
                $responseBlock
            }
            else {
                return
            }
"@
        }

# Creating the template body here.
@"
function $filePrefix-Cohesity$Feature {
    <#
        .SYNOPSIS
        <string>.
        .DESCRIPTION
        <string>.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        $filePrefix-Cohesity$Feature -Param1 <string>
    #>
    [CmdletBinding($(if($ActionType -ne "get"){'SupportsShouldProcess = $True, ConfirmImpact = "High"'}))]
    Param(
        [Parameter(Mandatory = `$false)]
        # Description about Param1
        `$Param1
    )
    Begin {
        `$cohesitySession = CohesityUserProfile
        `$cohesityCluster = `$cohesitySession.ClusterUri
        `$cohesityToken = `$cohesitySession.Accesstoken.Accesstoken
    }

    Process {
        #       Append the url with your ActionType accordingly.
        `$cohesityUrl = `$cohesityCluster + '/irisservices/api/v1/public/'
        `$cohesityHeaders = @{'Authorization' = 'Bearer ' + `$cohesityToken }
        $processBlock
    }

    End {
    }
}
"@ | out-file $fileLoc -Force:$true # Writing the content of the template into the new created file.
    }

    End {
    }
