# Copyright 2026 Cohesity Inc.
#
# Unit tests for Get-CohesityProtectionJobRun JobName resolution (ENG-703124 / FI-67546).
# Iris /protectionJobs?names= uses substring match, so names=VM_Small can also return
# VM_Small_Group. The cmdlet must exact-filter and never treat a multi-object result as
# a single [long] JobId.

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

    Context 'When the jobs API returns multiple substring matches (ENG-703124)' {
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