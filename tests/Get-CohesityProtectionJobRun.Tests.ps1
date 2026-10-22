# Copyright 2026 Cohesity Inc.
#
# Unit tests for Get-CohesityProtectionJobRun:
# - Exact JobName resolution when Iris returns substring name matches
# - protectionRuns queries when JobId / JobName are not specified (SourceId and other filters)

$ErrorActionPreference = 'Stop'

BeforeAll {
    # Stubs so Pester can Mock them without loading the full Cohesity module / DLL.
    function script:Get-CohesityProtectionJob {
        [CmdletBinding()]
        param(
            [string[]]$Names
        )
    }

    function script:Invoke-RestApi {
        [CmdletBinding()]
        param(
            $Uri,
            $Headers,
            $Method,
            $Body,
            $OutFile
        )
    }

    $cmdletPath = Join-Path $PSScriptRoot '..\src\Cohesity.Powershell\Scripts\ProtectionJobRun\Get-CohesityProtectionJobRun.ps1'
    . (Resolve-Path -LiteralPath $cmdletPath).Path
}

Describe 'Get-CohesityProtectionJobRun JobName resolution' -Tag 'UnitTest' {

    BeforeEach {
        $script:requestedUris = New-Object System.Collections.Generic.List[string]
    }

    Context 'When the jobs API returns multiple substring matches' {
        BeforeEach {
            Mock Get-CohesityProtectionJob {
                @(
                    [pscustomobject]@{ name = 'VM_Small_Group'; id = [long]56 }
                    [pscustomobject]@{ name = 'VM_Small'; id = [long]49226 }
                )
            }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName = 'VM_Small'
                        JobId   = [long]49226
                        BackupRun = [pscustomobject]@{ JobRunId = 1 }
                    }
                )
            }
        }

        It 'does not throw when converting job ids from a multi-object API response' {
            { Get-CohesityProtectionJobRun -JobName 'VM_Small' -NumRuns 5 } | Should -Not -Throw
        }

        It 'queries protectionRuns only for the exact name match (VM_Small / 49226)' {
            $null = Get-CohesityProtectionJobRun -JobName 'VM_Small' -NumRuns 5

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'jobId=49226'
            $script:requestedUris[0] | Should -Not -Match 'jobId=56'
        }

        It 'returns runs only for the exact job name' {
            $runs = @(Get-CohesityProtectionJobRun -JobName 'VM_Small' -NumRuns 5)

            $runs.Count | Should -Be 1
            $runs[0].JobId | Should -Be 49226
            $runs[0].JobName | Should -Be 'VM_Small'
        }
    }

    Context 'When the jobs API returns a single exact match' {
        BeforeEach {
            Mock Get-CohesityProtectionJob {
                @(
                    [pscustomobject]@{ name = 'VM_Small'; id = [long]49226 }
                )
            }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName = 'VM_Small'
                        JobId   = [long]49226
                        BackupRun = [pscustomobject]@{ JobRunId = 11 }
                    }
                    [pscustomobject]@{
                        JobName = 'VM_Small'
                        JobId   = [long]49226
                        BackupRun = [pscustomobject]@{ JobRunId = 12 }
                    }
                )
            }
        }

        It 'queries protectionRuns with that single job id' {
            $runs = @(Get-CohesityProtectionJobRun -JobName 'VM_Small' -NumRuns 5)

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'jobId=49226'
            $runs.Count | Should -Be 2
            ($runs | Select-Object -ExpandProperty JobId -Unique) | Should -Be 49226
        }
    }

    Context 'When no job matches the exact name' {
        BeforeEach {
            Mock Get-CohesityProtectionJob {
                # Substring hits only the longer name — exact filter should drop it.
                @(
                    [pscustomobject]@{ name = 'VM_Small_Group'; id = [long]56 }
                )
            }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @()
            }
        }

        It 'returns no job runs and does not call protectionRuns' {
            $output = @(Get-CohesityProtectionJobRun -JobName 'VM_Small' -NumRuns 5)

            $script:requestedUris.Count | Should -Be 0
            @($output | Where-Object { $_.PSObject.Properties['JobId'] }) | Should -HaveCount 0
            ($output -join ' ') | Should -Match "does not exist"
        }
    }
}

Describe 'Get-CohesityProtectionJobRun without JobId or JobName' -Tag 'UnitTest' {

    BeforeEach {
        $script:requestedUris = New-Object System.Collections.Generic.List[string]
    }

    Context 'When only -SourceId is specified' {
        BeforeEach {
            Mock Get-CohesityProtectionJob { @() }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName   = 'VM_Job'
                        JobId     = [long]100
                        BackupRun = [pscustomobject]@{ JobRunId = 1 }
                    }
                )
            }
        }

        It 'calls protectionRuns once without jobId in the query string' {
            $runs = @(Get-CohesityProtectionJobRun -SourceId 171 -NumRuns 1)

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'sourceId=171'
            $script:requestedUris[0] | Should -Match 'numRuns=1'
            $script:requestedUris[0] | Should -Not -Match 'jobId='
            $runs.Count | Should -Be 1
        }

        It 'still calls protectionRuns when the API returns no runs' {
            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @()
            }

            $runs = @(Get-CohesityProtectionJobRun -SourceId 171 -NumRuns 1)

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'sourceId=171'
            $runs.Count | Should -Be 0
        }

        It 'supports expanding backupRun stats from the response' {
            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName   = 'VM_Job'
                        JobId     = [long]100
                        BackupRun = [pscustomobject]@{
                            JobRunId = 1
                            Stats    = [pscustomobject]@{ startTimeUsecs = [long]9001 }
                        }
                    }
                )
            }

            $startTime = Get-CohesityProtectionJobRun -SourceId 171 -NumRuns 1 |
                Select-Object -ExpandProperty backupRun |
                Select-Object -ExpandProperty stats |
                Select-Object -ExpandProperty startTimeUsecs

            $startTime | Should -Be 9001
        }
    }

    Context 'When protection runs are queried without a job filter' {
        BeforeEach {
            Mock Get-CohesityProtectionJob { @() }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName   = 'Any_Job'
                        JobId     = [long]1
                        BackupRun = [pscustomobject]@{ JobRunId = 1 }
                    }
                )
            }
        }

        It 'calls protectionRuns once with only -NumRuns' {
            $null = Get-CohesityProtectionJobRun -NumRuns 5

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'numRuns=5'
            $script:requestedUris[0] | Should -Not -Match 'jobId='
        }

        It 'calls protectionRuns once when invoked with default NumRuns' {
            $null = Get-CohesityProtectionJobRun

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'numRuns=1000'
            $script:requestedUris[0] | Should -Not -Match 'jobId='
        }

        It 'does not add jobId=0 when JobId was not specified' {
            $null = Get-CohesityProtectionJobRun -SourceId 42 -NumRuns 2

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Not -Match 'jobId=0'
            $script:requestedUris[0] | Should -Not -Match 'jobId='
        }
    }

    Context 'When -SourceId is combined with other query filters' {
        BeforeEach {
            Mock Get-CohesityProtectionJob { @() }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @()
            }
        }

        It 'includes excludeErrorRuns and sourceId without jobId' {
            $null = Get-CohesityProtectionJobRun -SourceId 171 -NumRuns 3 -ExcludeErrorRuns

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'sourceId=171'
            $script:requestedUris[0] | Should -Match 'numRuns=3'
            $script:requestedUris[0] | Should -Match 'excludeErrorRuns=true'
            $script:requestedUris[0] | Should -Not -Match 'jobId='
        }
    }

    Context 'When -JobName and -SourceId are both specified' {
        BeforeEach {
            Mock Get-CohesityProtectionJob {
                @([pscustomobject]@{ name = 'VM_Small'; id = [long]49226 })
            }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName   = 'VM_Small'
                        JobId     = [long]49226
                        BackupRun = [pscustomobject]@{ JobRunId = 1 }
                    }
                )
            }
        }

        It 'queries protectionRuns with both jobId and sourceId' {
            $null = Get-CohesityProtectionJobRun -JobName 'VM_Small' -SourceId 171 -NumRuns 1

            $script:requestedUris.Count | Should -Be 1
            $script:requestedUris[0] | Should -Match 'jobId=49226'
            $script:requestedUris[0] | Should -Match 'sourceId=171'
        }
    }

    Context 'When deleted job runs are excluded' {
        BeforeEach {
            Mock Get-CohesityProtectionJob { @() }

            Mock Invoke-RestApi {
                param($Uri, $Method)
                $script:requestedUris.Add([string]$Uri) | Out-Null
                @(
                    [pscustomobject]@{
                        JobName   = 'Old_Job_DELETED'
                        JobId     = [long]99
                        BackupRun = [pscustomobject]@{ JobRunId = 1 }
                    }
                    [pscustomobject]@{
                        JobName   = 'Active_Job'
                        JobId     = [long]100
                        BackupRun = [pscustomobject]@{ JobRunId = 2 }
                    }
                )
            }
        }

        It 'filters out deleted job names after a SourceId query' {
            $runs = @(Get-CohesityProtectionJobRun -SourceId 171 -NumRuns 10)

            $script:requestedUris.Count | Should -Be 1
            $runs.Count | Should -Be 1
            $runs[0].JobName | Should -Be 'Active_Job'
        }
    }
}