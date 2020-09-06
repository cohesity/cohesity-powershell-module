## Top of the script

# Stop on any error
$ErrorActionPreference = "Stop"      

filter leftside{
    param(
            [Parameter(Position=0, Mandatory=$true,ValueFromPipeline = $true)]
            [ValidateNotNullOrEmpty()]
            [PSCustomObject]
            $obj
        )
    
        $obj | Where-Object{$_.sideindicator -eq '<='}
    
    }

filter rightside{
        param(
                [Parameter(Position=0, Mandatory=$true,ValueFromPipeline = $true)]
                [ValidateNotNullOrEmpty()]
                [PSCustomObject]
                $obj
            )
        
            $obj | Where-Object{$_.sideindicator -eq '=>'}
        
        }

function pause($operation){ $null = Read-Host "Enter to continue the $operation of $roleName..." }

function Manage-User-Roles {
    <#
    This function will create a user named "cohesity_backup_user" and a role named 
    "cohesity_data_protection_
role". If option 2 is selected, it will take a userName from user
    executing the script and apply the cohesity_data_protection_
role to the collected user
    #>
    param (
        [string]$Title = 'Role and User Management'
    )
    Write-Host "=========================== $Title ============================"
    Write-Host "1: Press '1' to create a 'cohesity_backup_user' user and assign the 'cohesity_data_protection_role'"
    Write-Host "2: Press '2' to use an existing user and assign the 'cohesity_data_protection_ role'"
    Write-Host "Q: Press 'Q' to quit."
}

function Show-MainMenu {
    <#
    This displays the main menu. 
    Option 1: Applies all privileges to the user 
    Option 2: Provides more option
    #>
    param (
        [string]$Title = 'Give Cohesity vCenter User permission'
    )
    Write-Host "==================================== $Title ===================================="
            
    Write-Host "Press '1' for Silent Install (Storage Snapshot Integration + Datastore Adaptive Throttling + Encrypted VMs)"
    Write-Host "Press '2' for Interactive."
    Write-Host "Press 'Q' to quit."
}
      

function Show-InteractiveMenu {
    <#
    This displays the interactive menu. 
    The options are pretty self explanatory
    #>
    param (
        [string]$Title = 'Select type of permission you want to assign'
    )
    write-host "`n"
    Write-Host "==================================== $Title ===================================="
            
    Write-Host "Press '1' VMware Snapshot only"
    Write-Host "Press '2' VMware Snapshot + Encrypted VMs"
    Write-Host "Press '3' VMware Snapshot + Datastore Adaptive Throttling"
    Write-Host "Press '4' VMware Snapshot + Datastore Adaptive Throttling + Encrypted VMs"
    Write-Host "Press '5' Storage Snapshot Integration only"
    Write-Host "Press '6' Storage Snapshot Integration + Encrypted VMs"
    Write-Host "Press '7' Storage Snapshot Integration + Datastore Adaptive Throttling"
    Write-Host "Press '8' Storage Snapshot Integration + Datastore Adaptive Throttling + Encrypted VMs"
    Write-Host "Press 'Q' to quit."
}

function RoleManagement($privilegeList) {
    <#
    This funtion creates or updates the cohesity_data_protection_role depending on $roleExits Flag 
    #>

    if($roleExists -ne $null){
        $existingPrivileges = Get-VIPrivilege -Role $roleName | Select-Object -Property Id
        $existingStringPrivileges = $existingPrivileges | ForEach-Object{($_.Id)}                            
        $deletePrivilegesObj = Compare-Object -ReferenceObject $existingStringPrivileges -DifferenceObject $privilegeList | leftside
        $addPrivilegesObj = Compare-Object -ReferenceObject $existingStringPrivileges -DifferenceObject $privilegeList | rightside
        $deletePrivileges = $deletePrivilegesObj | ForEach-Object {$_.InputObject} 
        $addPrivileges = $addPrivilegesObj | ForEach-Object {$_.InputObject} 

        if(($addPrivileges.Length -eq 0) -and ($deletePrivileges.Length -eq 0 )){
            Write-Host "====================== No updated needed to the privileges =====================" -ForegroundColor Yellow
            Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"   
            exit
        }
        elseif(($addPrivileges.Length -eq 0) -and ($deletePrivileges.Length -ge 0 )){
            Write-Host "====================== Removing the following privileges =======================" -ForegroundColor Yellow
            $deletePrivileges
            Write-Host "================================================================================" -ForegroundColor Yellow
            Set-VIRole -Role (Get-VIRole -Name $roleName) -RemovePrivilege (Get-VIPrivilege -id $deletePrivileges -Server $vc)
            exit
        }
        elseif(($addPrivileges.Length -ge 0) -and ($deletePrivileges.Length -eq 0 )){
            Write-Host "======================= Adding the following privileges ========================" -ForegroundColor Yellow
            $addPrivileges
            Write-Host "================================================================================" -ForegroundColor Yellow
            Set-VIRole -Role (Get-VIRole -Name $roleName) -AddPrivilege (Get-VIPrivilege -id $addPrivileges -Server $vc) 
            exit
        }
        else{
            Write-Host "======================= Adding the following privileges ========================" -ForegroundColor Yellow
            $addPrivileges
            Write-Host "================================================================================" -ForegroundColor Yellow
            Write-Host "======================= Removing the following privileges ======================" -ForegroundColor Yellow
            $deletePrivileges
            Write-Host "================================================================================" -ForegroundColor Yellow
            Set-VIRole -Role (Get-VIRole -Name $roleName) -RemovePrivilege (Get-VIPrivilege -id $deletePrivileges -Server $vc)
            Set-VIRole -Role (Get-VIRole -Name $roleName) -AddPrivilege (Get-VIPrivilege -id $addPrivileges -Server $vc)
            exit
        }
        $rootFolder = Get-Folder -NoRecursion
        Set-VIPermission -Role $roleName -Permission (Get-VIPermission -Principal $userName)
        Write-Host "================ Updated $roleName. Check logs for more details ================" -ForegroundColor Green
        Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"   
        exit
    }
    else{
        New-VIRole -Name $roleName -Privilege (Get-VIPrivilege -id $privilegeList -Server $vc)
        $rootFolder = Get-Folder -NoRecursion
        New-VIPermission -Entity $rootFolder -Principal $userName -Role $roleName
        Write-Host "================== Assigning $roleName to $userName sucessful.==================" -ForegroundColor Green
        Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"   
        exit
    }
    
}

# Variables that store privileges for different options
$VMwareSnapshot = @()
$VMwareSnapshotEncryptVM = @()
$VMwareSnapshotAdptThrot = @()
$VMwareSnapshotAdptThrotEncyptVM = @()
$StorageSnapshotIntegration = @()
$StorageSnapshotIntegrationEncryptVM = @()
$StorageSnapshotIntegrationAdptThrot = @()
$StorageSnapshotIntegrationAdptThrotEncryptVM = @()

# Get root path and find full path of json and log file for OS independent directory
$RootPath = $PSScriptRoot
$LogFile = Join-Path -Path $RootPath -ChildPath "privilege.log"
$privilegeJson = Join-Path -Path $RootPath -ChildPath "privilege.json"

# Read the privileges json file to populate the different privileges arrays
try{
    $json = Get-Content $privilegeJson | Out-String | ConvertFrom-Json
}
catch {
    Add-Content $LogFile  "Reading Json file failed."       
}
$VMwareSnapshot = $json.VMwareSnapshot
$VMwareSnapshotEncryptVM = $json.VMwareSnapshot + $json.EncryptVM
$VMwareSnapshotAdptThrot = $json.VMwareSnapshot + $json.AdaptiveThrottling
$VMwareSnapshotAdptThrotEncyptVM = $json.VMwareSnapshot + $json.EncryptVM +$json.AdaptiveThrottling
$StorageSnapshotIntegration = $json.VMwareSnapshot + $json.StorageSnapshotIntegration
$StorageSnapshotIntegrationEncryptVM = $json.VMwareSnapshot + $json.StorageSnapshotIntegration + $json.EncryptVM 
$StorageSnapshotIntegrationAdptThrot = $json.VMwareSnapshot + $json.StorageSnapshotIntegration + $json.AdaptiveThrottling
$StorageSnapshotIntegrationAdptThrotEncryptVM = $json.VMwareSnapshot + $json.StorageSnapshotIntegration + $json.EncryptVM + $json.AdaptiveThrottling

Add-Content $LogFile  "$((Get-Date).ToString()): Starting script."

Set-PowerCLIConfiguration -InvalidCertificateAction ignore -confirm:$False
Clear-Host
$vCenterServer = Read-Host "Enter the vCenter FQDN or IP here: "  
$vCenterUserName = Read-Host "Enter the vCenterUserName here: "  
$credentials= Get-Credential -UserName $vCenterUserName  -Message "Enter your vCenter password"

try{
    # Connecting to vCenter
    Clear-Host
    Write-Host "============================== Connect to vCenter =============================="
    $vc = Connect-VIServer -Server $vCenterServer -Credential $credentials
}
catch{
    Add-Content $LogFile  "Cannot connect to $vCenterServer. "    
}

# Read Rolename from user
$defaultRoleName = "cohesity_data_protection_role"
if (!($roleName = Read-Host "Enter a role name which you want to create/update [$defaultRoleName]")) { $roleName = $defaultRoleName }

try{
    # Check if role already exists
    $roleExists = Get-VIRole -Name $roleName

    if($roleExists -ne $null){
        Write-Host ""
        Write-Host "Role already present Updating role $roleName" -ForegroundColor Yellow
        Write-Host ""
        pause("updation")
    }
    
}
catch{
    Add-Content $LogFile $_
    Write-Host ""
    Write-Host "Role not present already. Creating role $roleName" -ForegroundColor Yellow
    Write-Host ""
    pause("creation")
}

Write-Host ""
$userName = Read-Host "Enter the user name who will be assigend role $roleName (DOMAIN\username) "  
write-host "`n"
  
#Main menu to collect user preference for applying role to the account user
do {
    
    Show-MainMenu
    $MainMenuSelection = Read-Host "Please make a selection"
    switch ($MainMenuSelection) {
        '1' {
            # Apply all roles to the user
            Write-Host "====================== Assigning $roleName to $userName.  ======================"
            try{
                RoleManagement($StorageSnapshotIntegrationAdptThrotEncryptVM)
            }
            catch{
                Add-Content $LogFile $_
                Write-Host $_ -ForegroundColor Red
            }
            
                
        } '2' {
            Show-InteractiveMenu
            $InteractiveMenuselection = Read-Host "Please make a selection"
            switch ($InteractiveMenuselection) {
                '1' {
                    # Apply VMwareSnapshot roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($VMwareSnapshot)
                    }
                    catch{
                        Add-Content $LogFile $_
                        Write-Host $_ -ForegroundColor Red
                    }
                    
                    
                } '2' {
                    # Apply VMwareSnapshot + Datastore Adaptive throttling roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($VMwareSnapshotEncryptVM)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
                    
                        
                } 
                '3' {
                    # Apply VMwareSnapshot + Datastore Adaptive throttling + Encryption roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($VMwareSnapshotAdptThrot)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
                    
                    
                } '4' {
                    # Apply Storage Snapshot Integration roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($VMwareSnapshotAdptThrotEncyptVM)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
                    
                        
                } 
                '5' {
                    # Apply Storage Snapshot Integration + Datastore Adaptive throttling roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($StorageSnapshotIntegration)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
                    
                    
                } '6' {
                    # Apply Storage Snapshot Integration + Datastore Adaptive throttling + Encryption roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($StorageSnapshotIntegrationEncryptVM)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
 
                } '7' {
                    # Apply Storage Snapshot Integration + Datastore Adaptive throttling + Encryption roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($StorageSnapshotIntegrationAdptThrot)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
 
                }'8' {
                    # Apply Storage Snapshot Integration + Datastore Adaptive throttling + Encryption roles to the user
                    write-host "`n"
                    Write-Host "====================== Assigning $roleName to $userName.  ======================"
                    try{
                        RoleManagement($StorageSnapshotIntegrationAdptThrotEncryptVM)
                    }
                    catch{
                        Write-Host $_ -ForegroundColor Red
                        Add-Content $LogFile $_
                    }
 
                }'Q' {
                    Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"    
                    exit
                } 'q' {
                    Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"    
                    exit
                }
                default {
                    write-host "`n"
                    Write-Host "===================== Incorrect Selection Please try again =====================" -ForegroundColor Red
                    Show-InteractiveMenu
                }
            }

        } '3'{
            Write-Host "================= Reading privilege.json to get new privileges =================" 

        } 'Q' {
            Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"    
            exit
        } 'q' {
            Add-Content $LogFile  "$((Get-Date).ToString()): Exiting the script"    
            exit
        }
        default {
            write-host "`n"
            Write-Host "===================== Incorrect Selection Please try again =====================" -ForegroundColor Red
            Show-MainMenu
        } 
    }
    
}
until ($MainMenuSelection -eq 'q')
# SIG # Begin signature block
# MIIfGgYJKoZIhvcNAQcCoIIfCzCCHwcCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQUQk+gb58tru/Gbxej1C4T5BdM
# y4WgggxXMIIFmjCCBIKgAwIBAgIQBXZRnowunICAj+w3wa840zANBgkqhkiG9w0B
# AQUFADBlMQswCQYDVQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYD
# VQQLExB3d3cuZGlnaWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBFViBDb2Rl
# IFNpZ25pbmcgQ0EwHhcNMTkwNjE2MDAwMDAwWhcNMjExMjE1MTIwMDAwWjCBxDET
# MBEGCysGAQQBgjc8AgEDEwJVUzEZMBcGCysGAQQBgjc8AgECEwhEZWxhd2FyZTEd
# MBsGA1UEDwwUUHJpdmF0ZSBPcmdhbml6YXRpb24xEDAOBgNVBAUTBzUzNDU2NzAx
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpDYWxpZm9ybmlhMREwDwYDVQQHEwhTYW4g
# Sm9zZTEVMBMGA1UEChMMQ29oZXNpdHkgSW5jMRUwEwYDVQQDEwxDb2hlc2l0eSBJ
# bmMwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDNi7qZLTg3eaaei8JO
# qRz8tcHzON5lYcUi299kV8/A39JRNqAqPkWWiikJu+AOMd/YXY2S/EZb9ujI7FER
# mi6ymkDzz6JCnvRZEe2yFcqmemZXu2lrCX6o7j+ZknDtp21JiqQ7DkjmaPhPH6z/
# KmjDFFI95/feNX4jAQ7P6/nRs6ADhJqFEM0nPoiMV6DJNY5BEUEDn3znwK6MzNyP
# TcDPBdIk9ko13CDxQb/CwmPiSY5/VwQSEKgQ1kXnBf7yP9DDhauQgtkLT3GFHGr4
# MvFwy/Bw7v2QLCUg1BNlWp52ng4pibNC9/W8am2EH06edNL4DdecwIVgaXd0elEQ
# hwzrAgMBAAGjggHkMIIB4DAfBgNVHSMEGDAWgBStaQZw/IAbFrOpGJRrlAKGXvcn
# jDAdBgNVHQ4EFgQUdRGo2oxYATtIMCPtRa3S65GnS/MwLgYDVR0RBCcwJaAjBggr
# BgEFBQcIA6AXMBUME1VTLURFTEFXQVJFLTUzNDU2NzAwDgYDVR0PAQH/BAQDAgeA
# MBMGA1UdJQQMMAoGCCsGAQUFBwMDMHMGA1UdHwRsMGowM6AxoC+GLWh0dHA6Ly9j
# cmwzLmRpZ2ljZXJ0LmNvbS9FVkNvZGVTaWduaW5nLWcxLmNybDAzoDGgL4YtaHR0
# cDovL2NybDQuZGlnaWNlcnQuY29tL0VWQ29kZVNpZ25pbmctZzEuY3JsMEsGA1Ud
# IAREMEIwNwYJYIZIAYb9bAMCMCowKAYIKwYBBQUHAgEWHGh0dHBzOi8vd3d3LmRp
# Z2ljZXJ0LmNvbS9DUFMwBwYFZ4EMAQMweQYIKwYBBQUHAQEEbTBrMCQGCCsGAQUF
# BzABhhhodHRwOi8vb2NzcC5kaWdpY2VydC5jb20wQwYIKwYBBQUHMAKGN2h0dHA6
# Ly9jYWNlcnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEVWQ29kZVNpZ25pbmdDQS5j
# cnQwDAYDVR0TAQH/BAIwADANBgkqhkiG9w0BAQUFAAOCAQEAZMFWh84A4UN+ceFn
# tTf/Grc/Y8bWSmJE5D9ocv25gaN+hHlyMH1T/zF75iOPBCsun3uy/quw7SumCrCr
# 4e62E7hMfx+UOme2+Zuy+PXrFnuhDdlAsAJ3s8nnQl0oNQkRr9EWwGjNU1BRWOSg
# b3ancepbNTSmUJYldiW5uDYfY8U/cp7P5aSMUujkrHZE8nkO8KrxxY9zKMKNYQL7
# itYo1rQc51a9rLfTJZvEcbYGr9me6XqZ0noW2xp4hl8+pllXKElAnKGO1FIAFBS3
# Zl7H2BMhudMXi3dQAPXbDsImVKxDamw1egHifX5Gnbwnb+ATT6SO1cd9sAWlNt1z
# xHe2LzCCBrUwggWdoAMCAQICEA3Q4zdKyVvb+mtDSypI7AYwDQYJKoZIhvcNAQEF
# BQAwbDELMAkGA1UEBhMCVVMxFTATBgNVBAoTDERpZ2lDZXJ0IEluYzEZMBcGA1UE
# CxMQd3d3LmRpZ2ljZXJ0LmNvbTErMCkGA1UEAxMiRGlnaUNlcnQgSGlnaCBBc3N1
# cmFuY2UgRVYgUm9vdCBDQTAeFw0xMjA0MTgxMjAwMDBaFw0yNzA0MTgxMjAwMDBa
# MGUxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsT
# EHd3dy5kaWdpY2VydC5jb20xJDAiBgNVBAMTG0RpZ2lDZXJ0IEVWIENvZGUgU2ln
# bmluZyBDQTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBALkGdBxdtCCq
# qSGoKkJGqyUgFyXLIo+QoqAxa4MFda+yDnwSSXtqhmSED4PcZLmxbhYFPhyVuefn
# iG24YoGQedTd9eKW+cO1iCNXShrPcSnpCACPtZjjpzL9rC649JNT9Ao5Q5Gv1Wvo
# 1J9GvY49q+L5K9TqAEBmJLfof7REdY14mq4xwTfPTh9b+EVK1z/CyZIGZL7eBoqv
# 0OiKsfAsiABvC9yFp0zLBr/WLioybilxr44i8w/Q2JhILagIy7aLI8Jj4LZz6299
# Jk+L9zQ9N4YMt3gn9MKG20NrWvg9PfTosGJWxufteKH7/XpyTzJlxHzDxHegBDIy
# 7Y8/r4bdftECAwEAAaOCA1gwggNUMBIGA1UdEwEB/wQIMAYBAf8CAQAwDgYDVR0P
# AQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMDMH8GCCsGAQUFBwEBBHMwcTAk
# BggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEkGCCsGAQUFBzAC
# hj1odHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRIaWdoQXNzdXJh
# bmNlRVZSb290Q0EuY3J0MIGPBgNVHR8EgYcwgYQwQKA+oDyGOmh0dHA6Ly9jcmwz
# LmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEhpZ2hBc3N1cmFuY2VFVlJvb3RDQS5jcmww
# QKA+oDyGOmh0dHA6Ly9jcmw0LmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEhpZ2hBc3N1
# cmFuY2VFVlJvb3RDQS5jcmwwggHEBgNVHSAEggG7MIIBtzCCAbMGCWCGSAGG/WwD
# AjCCAaQwOgYIKwYBBQUHAgEWLmh0dHA6Ly93d3cuZGlnaWNlcnQuY29tL3NzbC1j
# cHMtcmVwb3NpdG9yeS5odG0wggFkBggrBgEFBQcCAjCCAVYeggFSAEEAbgB5ACAA
# dQBzAGUAIABvAGYAIAB0AGgAaQBzACAAQwBlAHIAdABpAGYAaQBjAGEAdABlACAA
# YwBvAG4AcwB0AGkAdAB1AHQAZQBzACAAYQBjAGMAZQBwAHQAYQBuAGMAZQAgAG8A
# ZgAgAHQAaABlACAARABpAGcAaQBDAGUAcgB0ACAAQwBQAC8AQwBQAFMAIABhAG4A
# ZAAgAHQAaABlACAAUgBlAGwAeQBpAG4AZwAgAFAAYQByAHQAeQAgAEEAZwByAGUA
# ZQBtAGUAbgB0ACAAdwBoAGkAYwBoACAAbABpAG0AaQB0ACAAbABpAGEAYgBpAGwA
# aQB0AHkAIABhAG4AZAAgAGEAcgBlACAAaQBuAGMAbwByAHAAbwByAGEAdABlAGQA
# IABoAGUAcgBlAGkAbgAgAGIAeQAgAHIAZQBmAGUAcgBlAG4AYwBlAC4wHQYDVR0O
# BBYEFK1pBnD8gBsWs6kYlGuUAoZe9yeMMB8GA1UdIwQYMBaAFLE+w2kD+L9HAdSY
# JhoIAu9jZCvDMA0GCSqGSIb3DQEBBQUAA4IBAQCeW5Y6LhKIrKsBbaSfdeQBh6Ol
# Mte8uql+o9YUF/fCE2t8c48rauUPJllosI4lm2zv+myTkgjBTc9FnpxG1h50oZsU
# o/oBL0qxAeFyQEgRE2i5Np2RS9fCORIQwcTcu2IUFCphXU84fGYfxhv/rb5Pf5Rb
# c0MAD01zt1HPDvZ3wFvNNIzZYxOqDmER1vKOJ/y0e7i5ESCRhnjqDtQo/yrVJDjo
# N7LslrufvEoWUOFev1F9I6Ayx8GUnnrJwCaizCWHoBJ+dJ8tjbHI54S+udHp3rtq
# TohzceEiOMskh+lzflGy/5jrTn4v4MoO+rNe0boFQqhIn4P2P8TKqN9ooFBhMYIS
# LTCCEikCAQEweTBlMQswCQYDVQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5j
# MRkwFwYDVQQLExB3d3cuZGlnaWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBF
# ViBDb2RlIFNpZ25pbmcgQ0ECEAV2UZ6MLpyAgI/sN8GvONMwCQYFKw4DAhoFAKBw
# MBAGCisGAQQBgjcCAQwxAjAAMBkGCSqGSIb3DQEJAzEMBgorBgEEAYI3AgEEMBwG
# CisGAQQBgjcCAQsxDjAMBgorBgEEAYI3AgEVMCMGCSqGSIb3DQEJBDEWBBTb6Vum
# OcrO80xjH8LG+W1jpeJvejANBgkqhkiG9w0BAQEFAASCAQCn+brvciqn6ZKFhaE4
# Tbjy/CCXqkzZ7ClZIkzR2NIIrhb2OjDPEXB27rtL0MPmAKsKKKEDtpyZLwRa0voX
# fKuyVfoSuiutx2F5d1l3PE18fRWOs7Kqbk04DG+rwFkN1LYFPMh1PJxKDQyapKV0
# F2TprQ/IpI7kbG/Kf5itVyO0HTHQlLJ3ZLy6enw4pwfJuQVV6++o3okvmA0wmzqK
# GEF1J30yNY78ednls/yPTi8BGdM7Pxwh4LwCL2r64IZqYNFQHCZZUQEzYQ4Wo7xX
# GJmWpweLxy1WlHOJbOCTu8b7fJMQCw+hd3RyWWNR0z6EW62gjlW/QYHA5SWWYB5s
# nf0BoYIQFzCCEBMGCisGAQQBgjcDAwExghADMIIP/wYJKoZIhvcNAQcCoIIP8DCC
# D+wCAQMxCzAJBgUrDgMCGgUAMGcGCyqGSIb3DQEJEAEEoFgEVjBUAgEBBglghkgB
# hv1sBwEwITAJBgUrDgMCGgUABBSoUE65ZQI2loYeMU3e79Ozlry38AIQSp8fgWsQ
# GtGcvGgy8uZf9BgPMjAyMDA2MzAyMzQyMTdaoIINPzCCBmowggVSoAMCAQICEAMB
# mgI6/1ixa9bV6uYX8GYwDQYJKoZIhvcNAQEFBQAwYjELMAkGA1UEBhMCVVMxFTAT
# BgNVBAoTDERpZ2lDZXJ0IEluYzEZMBcGA1UECxMQd3d3LmRpZ2ljZXJ0LmNvbTEh
# MB8GA1UEAxMYRGlnaUNlcnQgQXNzdXJlZCBJRCBDQS0xMB4XDTE0MTAyMjAwMDAw
# MFoXDTI0MTAyMjAwMDAwMFowRzELMAkGA1UEBhMCVVMxETAPBgNVBAoTCERpZ2lD
# ZXJ0MSUwIwYDVQQDExxEaWdpQ2VydCBUaW1lc3RhbXAgUmVzcG9uZGVyMIIBIjAN
# BgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAo2Rd/Hyz4II14OD2xirmSXU7zG7g
# U6mfH2RZ5nxrf2uMnVX4kuOe1VpjWwJJUNmDzm9m7t3LhelfpfnUh3SIRDsZyeX1
# kZ/GFDmsJOqoSyyRicxeKPRktlC39RKzc5YKZ6O+YZ+u8/0SeHUOplsU/UUjjoZE
# VX0YhgWMVYd5SEb3yg6Np95OX+Koti1ZAmGIYXIYaLm4fO7m5zQvMXeBMB+7NgGN
# 7yfj95rwTDFkjePr+hmHqH7P7IwMNlt6wXq4eMfJBi5GEMiN6ARg27xzdPpO2P6q
# QPGyznBGg+naQKFZOtkVCVeZVjCT88lhzNAIzGvsYkKRrALA76TwiRGPdwIDAQAB
# o4IDNTCCAzEwDgYDVR0PAQH/BAQDAgeAMAwGA1UdEwEB/wQCMAAwFgYDVR0lAQH/
# BAwwCgYIKwYBBQUHAwgwggG/BgNVHSAEggG2MIIBsjCCAaEGCWCGSAGG/WwHATCC
# AZIwKAYIKwYBBQUHAgEWHGh0dHBzOi8vd3d3LmRpZ2ljZXJ0LmNvbS9DUFMwggFk
# BggrBgEFBQcCAjCCAVYeggFSAEEAbgB5ACAAdQBzAGUAIABvAGYAIAB0AGgAaQBz
# ACAAQwBlAHIAdABpAGYAaQBjAGEAdABlACAAYwBvAG4AcwB0AGkAdAB1AHQAZQBz
# ACAAYQBjAGMAZQBwAHQAYQBuAGMAZQAgAG8AZgAgAHQAaABlACAARABpAGcAaQBD
# AGUAcgB0ACAAQwBQAC8AQwBQAFMAIABhAG4AZAAgAHQAaABlACAAUgBlAGwAeQBp
# AG4AZwAgAFAAYQByAHQAeQAgAEEAZwByAGUAZQBtAGUAbgB0ACAAdwBoAGkAYwBo
# ACAAbABpAG0AaQB0ACAAbABpAGEAYgBpAGwAaQB0AHkAIABhAG4AZAAgAGEAcgBl
# ACAAaQBuAGMAbwByAHAAbwByAGEAdABlAGQAIABoAGUAcgBlAGkAbgAgAGIAeQAg
# AHIAZQBmAGUAcgBlAG4AYwBlAC4wCwYJYIZIAYb9bAMVMB8GA1UdIwQYMBaAFBUA
# EisTmLKZB+0e36K+Vw0rZwLNMB0GA1UdDgQWBBRhWk0ktkkynUoqeRqDS/QeicHK
# fTB9BgNVHR8EdjB0MDigNqA0hjJodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGln
# aUNlcnRBc3N1cmVkSURDQS0xLmNybDA4oDagNIYyaHR0cDovL2NybDQuZGlnaWNl
# cnQuY29tL0RpZ2lDZXJ0QXNzdXJlZElEQ0EtMS5jcmwwdwYIKwYBBQUHAQEEazBp
# MCQGCCsGAQUFBzABhhhodHRwOi8vb2NzcC5kaWdpY2VydC5jb20wQQYIKwYBBQUH
# MAKGNWh0dHA6Ly9jYWNlcnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEFzc3VyZWRJ
# RENBLTEuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCdJX4bM02yJoFcm4bOIyAPgIfl
# iP//sdRqLDHtOhcZcRfNqRu8WhY5AJ3jbITkWkD73gYBjDf6m7GdJH7+IKRXrVu3
# mrBgJuppVyFdNC8fcbCDlBkFazWQEKB7l8f2P+fiEUGmvWLZ8Cc9OB0obzpSCfDs
# cGLTYkuw4HOmksDTjjHYL+NtFxMG7uQDthSr849Dp3GdId0UyhVdkkHa+Q+B0Zl0
# DSbEDn8btfWg8cZ3BigV6diT5VUW8LsKqxzbXEgnZsijiwoc5ZXarsQuWaBh3drz
# baJh6YoLbewSGL33VVRAA5Ira8JRwgpIr7DUbuD0FAo6G+OPPcqvao173NhEMIIG
# zTCCBbWgAwIBAgIQBv35A5YDreoACus/J7u6GzANBgkqhkiG9w0BAQUFADBlMQsw
# CQYDVQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cu
# ZGlnaWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBBc3N1cmVkIElEIFJvb3Qg
# Q0EwHhcNMDYxMTEwMDAwMDAwWhcNMjExMTEwMDAwMDAwWjBiMQswCQYDVQQGEwJV
# UzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGlnaWNlcnQu
# Y29tMSEwHwYDVQQDExhEaWdpQ2VydCBBc3N1cmVkIElEIENBLTEwggEiMA0GCSqG
# SIb3DQEBAQUAA4IBDwAwggEKAoIBAQDogi2Z+crCQpWlgHNAcNKeVlRcqcTSQQaP
# yTP8TUWRXIGf7Syc+BZZ3561JBXCmLm0d0ncicQK2q/LXmvtrbBxMevPOkAMRk2T
# 7It6NggDqww0/hhJgv7HxzFIgHweog+SDlDJxofrNj/YMMP/pvf7os1vcyP+rFYF
# kPAyIRaJxnCI+QWXfaPHQ90C6Ds97bFBo+0/vtuVSMTuHrPyvAwrmdDGXRJCgeGD
# boJzPyZLFJCuWWYKxI2+0s4Grq2Eb0iEm09AufFM8q+Y+/bOQF1c9qjxL6/siSLy
# axhlscFzrdfx2M8eCnRcQrhofrfVdwonVnwPYqQ/MhRglf0HBKIJAgMBAAGjggN6
# MIIDdjAOBgNVHQ8BAf8EBAMCAYYwOwYDVR0lBDQwMgYIKwYBBQUHAwEGCCsGAQUF
# BwMCBggrBgEFBQcDAwYIKwYBBQUHAwQGCCsGAQUFBwMIMIIB0gYDVR0gBIIByTCC
# AcUwggG0BgpghkgBhv1sAAEEMIIBpDA6BggrBgEFBQcCARYuaHR0cDovL3d3dy5k
# aWdpY2VydC5jb20vc3NsLWNwcy1yZXBvc2l0b3J5Lmh0bTCCAWQGCCsGAQUFBwIC
# MIIBVh6CAVIAQQBuAHkAIAB1AHMAZQAgAG8AZgAgAHQAaABpAHMAIABDAGUAcgB0
# AGkAZgBpAGMAYQB0AGUAIABjAG8AbgBzAHQAaQB0AHUAdABlAHMAIABhAGMAYwBl
# AHAAdABhAG4AYwBlACAAbwBmACAAdABoAGUAIABEAGkAZwBpAEMAZQByAHQAIABD
# AFAALwBDAFAAUwAgAGEAbgBkACAAdABoAGUAIABSAGUAbAB5AGkAbgBnACAAUABh
# AHIAdAB5ACAAQQBnAHIAZQBlAG0AZQBuAHQAIAB3AGgAaQBjAGgAIABsAGkAbQBp
# AHQAIABsAGkAYQBiAGkAbABpAHQAeQAgAGEAbgBkACAAYQByAGUAIABpAG4AYwBv
# AHIAcABvAHIAYQB0AGUAZAAgAGgAZQByAGUAaQBuACAAYgB5ACAAcgBlAGYAZQBy
# AGUAbgBjAGUALjALBglghkgBhv1sAxUwEgYDVR0TAQH/BAgwBgEB/wIBADB5Bggr
# BgEFBQcBAQRtMGswJAYIKwYBBQUHMAGGGGh0dHA6Ly9vY3NwLmRpZ2ljZXJ0LmNv
# bTBDBggrBgEFBQcwAoY3aHR0cDovL2NhY2VydHMuZGlnaWNlcnQuY29tL0RpZ2lD
# ZXJ0QXNzdXJlZElEUm9vdENBLmNydDCBgQYDVR0fBHoweDA6oDigNoY0aHR0cDov
# L2NybDMuZGlnaWNlcnQuY29tL0RpZ2lDZXJ0QXNzdXJlZElEUm9vdENBLmNybDA6
# oDigNoY0aHR0cDovL2NybDQuZGlnaWNlcnQuY29tL0RpZ2lDZXJ0QXNzdXJlZElE
# Um9vdENBLmNybDAdBgNVHQ4EFgQUFQASKxOYspkH7R7for5XDStnAs0wHwYDVR0j
# BBgwFoAUReuir/SSy4IxLVGLp6chnfNtyA8wDQYJKoZIhvcNAQEFBQADggEBAEZQ
# Psm3KCSnOB22WymvUs9S6TFHq1Zce9UNC0Gz7+x1H3Q48rJcYaKclcNQ5IK5I9G6
# OoZyrTh4rHVdFxc0ckeFlFbR67s2hHfMJKXzBBlVqefj56tizfuLLZDCwNK1lL1e
# T7EF0g49GqkUW6aGMWKoqDPkmzmnxPXOHXh2lCVz5Cqrz5x2S+1fwksW5EtwTACJ
# HvzFebxMElf+X+EevAJdqP77BzhPDcZdkbkPZ0XN1oPt55INjbFpjE/7WeAjD9Kq
# rgB87pxCDs+R1ye3Fu4Pw718CqDuLAhVhSK46xgaTfwqIa1JMYNHlXdx3LEbS0sc
# EJx3FMGdTy9alQgpECYxggIsMIICKAIBATB2MGIxCzAJBgNVBAYTAlVTMRUwEwYD
# VQQKEwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xITAf
# BgNVBAMTGERpZ2lDZXJ0IEFzc3VyZWQgSUQgQ0EtMQIQAwGaAjr/WLFr1tXq5hfw
# ZjAJBgUrDgMCGgUAoIGMMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRABBDAcBgkq
# hkiG9w0BCQUxDxcNMjAwNjMwMjM0MjE3WjAjBgkqhkiG9w0BCQQxFgQUb7/VTfeB
# UI2/SDBcW9cCpEWzqHYwKwYLKoZIhvcNAQkQAgwxHDAaMBgwFgQUYU0nHZEC4wFp
# giSH/eXeAKNSsB0wDQYJKoZIhvcNAQEBBQAEggEACONarTED1TdouOxesXY/F5ZC
# dAL3cdosfnZPnNsc9rvEujokNf1xGA68JGGEUz0LNaFCt4pECeNN2o+zgnkAtBqF
# YcoiYgjQvekAW0fjAQcr9HPM0LeSUUhiUcRUZB4EV3WDdkPRed/qUeRyhpLmQonk
# rRCzdky9nW9ClevPRBYX1AH3Yh/IY4lKkg4g2gmUNFpN7+sCdobdAUDiFR1oW217
# m++dNfE9bm5TH/wDakmQRsZIdoBbTezWqcZAYBm1qh1+/asPpZeCy+gBIwc7kT85
# jL/XVhZKwudd2EBTWgPl/p2KFLaopxot/wvFZzOlSMVmOYV7EJLHX+Qo2TeQyg==
# SIG # End signature block
