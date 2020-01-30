### usage: ./vmware-recovery-tests.ps1 -cohesityCluster 192.168.1.198 -vmwareEnvironment 192.168.1.200 -cohesityCred 'cohesity_credentials.xml' -vmwareCred 'vmware_credentials.xml' -resourcePool 'Resources' -perjob '10']

###
### Simple backup validation to clone random VMs per job for recovery test - Jussi Jaurola <jussi@cohesity.com>
###
### Uses:
###     - Cohesity PowerShell module
###     - VMware.PowerCLI module
###
### Create credential files with: Get-Credential | Export-Clixml cred.xml
###
[CmdletBinding()]
param (
    [Parameter(Mandatory = $True)][string]$cohesityCluster, #the cluster to connect to (DNS name or IP)
    [Parameter(Mandatory = $True)][string]$vmwareEnvironment, #the vmware environment to connect to (DNS name or IP)
    [Parameter(Mandatory = $True)][string]$cohesityCred, #credentials file for cohesity
    [Parameter(Mandatory = $True)][string]$vmwareCred, #credentials file for cohesity
    [Parameter(Mandatory = $True)][string]$resourcePool, #resourcepool name used for cloning
    [Parameter()][string]$perjob = 2 #number of random VMs per job
)

Write-Host "Importing credentials from credential file $($cohesityCred)" -ForegroundColor Yellow
Write-Host "Connecting to Cohesity Cluster $($cohesityCluster)" -ForegroundColor Yellow

$Credential = Import-Clixml -Path ($cohesityCred)
try {
    Connect-CohesityCluster -Server $cohesityCluster -Credential $Credential
    Write-Host "Connected to Cohesity Cluster $($cohesityCluster)" -ForegroundColor Yellow
} catch {
    write-host "Cannot connect to Cohesity cluster $($cohesityCluster)" -ForegroundColor Yellow
    exit
}

### Connect to VMware vCenter
Write-Host "Importing credentials from credential file $($vmwareCred)" -ForegroundColor Yellow
$vmwareCredential = Import-Clixml -Path ($vmwareCred)
try {
    Connect-VIServer -Server $vmwareEnvironment -Credential $vmwareCredential
    Write-Host "Connected to VMware vCenter $($global:DefaultVIServer.Name)" -ForegroundColor Yellow
} catch {
    write-host "Cannot connect to VMware vCenter $($vmwareEnvironment)" -ForegroundColor Yellow
    exit
}

$protectionJobs = Get-CohesityProtectionJob | Where-Object { $_.Environment -eq 'kVMware'}
[Array]$Script:clones = $null

foreach ($job in $protectionJobs) {
    ### get latest successful run
    $latest = Get-CohesityProtectionJobRun -JobId $($job.Id) -ExcludeNonRestoreableRuns | Select-Object -First 1
    if ($latest) {
        $latestStartTime = Convert-CohesityUsecsToDateTime -Usecs $($latest.backupRun.Stats.StartTimeUsecs)
        [System.Collections.ArrayList]$latestVMs = $($latest.backupRun.SourceBackupStatus.Source)
        Write-Host "Cloning $perjob of $($latestVMs.count) VMs for protectionJob $($job.Name) from $latestStartTime"
        For ($i=0; $i -lt $perjob; $i++) {
            $vmList = $latestVMs[(Get-Random -Maximum ([array]$latestVMs).count)]
            Write-Host "Clonining VM $($vmList.Name)"

            $vmwareSource = Get-CohesityProtectionSourceObject -Environments kVMware | Where-Object Name -eq $vmwareEnvironment 
            $vmwareResourcePool = Get-CohesityProtectionSourceObject -Environments kVMware | Where-Object ParentId -eq $($vmwareSource.Id) | Where-Object Name -eq $resourcePool 

            if (!$vmwareSource) {
                Write-Host "Couldnt find Protection Source $($vmwareEnvironment). Failing tests. Please check!" -ForegroundColor Red
                exit
            }

            if (!$vmwareResourcePool) {
                Write-Host "Couldnt find resourcepool $($resourcePool). Failing tests. Please check!" -ForegroundColor Red
                exit
            }

            $cloneVM = Get-CohesityVMwareVM -name $vmList.Name 
            $taskName = "bTest-" + $($VM.name) 

            if (!$cloneVM) {
                Write-Host "Couldnt find VM $($vmList.name). Failing tests. Please check!" -ForegroundColor Red
                exit
            }

            $cloneTask = Copy-CohesityVMwareVM -TaskName $taskName -PoweredOn:$true -DisableNetwork:$false -Jobid $($job.Id) -SourceId $($cloneVM.id) -TargetViewName $taskName -VmNamePrefix "bTest-" -ResourcePoolId $($vmwareResourcePool.id) -NewParent $($vmwareSource.Id)
            Write-Host "Created cloneTask $($cloneTask.Id) for VM $($VM.name)" -ForegroundColor Yellow
            $Script:clones += $cloneTask

            ### remove cloned VM from array
            $index = [array]::indexof($latestVMs,$vmList)
            $latestVMs.Remove($latestVMs[$index])
        }
    }
}

### wait 1 minute before next steps
Start-Sleep 60

### validate cloned VM(s) status
foreach ($clone in $clones) {
    $sleepCount = 0
    while ($true) {
        $validateTask = (Get-CohesityRestoreTask -Id $clone.Id).Status
        $validatePowerOn = (Get-VM -Name $clone.Name -ErrorAction:SilentlyContinue).PowerState
        Write-Host "VM $($clone.Name) clone status is $validateTask and Power Status is $ValidatePowerOn" -ForegroundColor Yellow
        Start-Sleep 60

        if ($validateTask -eq 'kFinished' -and $validatePowerOn -eq 'PoweredOn') {
            break
        } elseif ($sleepCount -gt '10') {
            Write-Host "Clone of VM $($clone.Name) failed. Failing tests. Other cloned VMs remain cloned status, manual cleanup might needed!" -ForegroundColor Red
            exit
        } else {
            Start-Sleep 30
            $sleepCount++
        }
    }
}

### check the status of VMware Tools in Cloned VMs
$failedTestCount = 0
$sleepCount = 0
foreach ($clone in $clones) {
    while ($true) {
        $toolStatus = (Get-VM -Name $clone.Name).ExtensionData.Guest.ToolsRunningStatus
            
        Write-Host "VM $($clone.Name) VMware Tools Status is $toolStatus" -ForegroundColor Yellow
        if ($toolStatus -ne 'guestToolsRunning') {
            Start-Sleep 30
            $sleepCount++
        } elseif ($sleepCount -gt '10') {
            Write-Host "VM $($clone.Name) recovery test failed (VMwareTools not running. Check manually!" -ForegroundColor Red
            $failedTestCount++
        } else {
            break
        }
    }
}

### remove clones and views
foreach ($clone in $clones) {
    $removeRequest = Remove-CohesityClone -TaskId $clone.id -Confirm:$false
    $removeView = Remove-CohesityView -Name $clone.name -Confirm:$false
}

$runCount = $clones.Count
if ($failedTestCount -gt 0) {
    Write-Host "Recovery tests done! There was $failedTestCount failed VM(s) out of total $($Clone.Count) VM(s) tested." -ForegroundColor Red
} else {
    Write-Host "Recovery test done! $runCount VM(s) recovery was succesful! "
}

