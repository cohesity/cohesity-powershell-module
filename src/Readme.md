# Instructions

## Setting up local repo
- Create a directory `C:\Workspace\LocalRepo\LocalPSRepo\Packages\`. This directory will hold all the PS packages hosted locally.
- Update the location of the directory in `Register-LocalPSRepo.ps1` powershell script.
- Execute the script `src\Register-LocalPSRepo.ps1` to register the `LocalPSRepo` repository.

## UnRegister local repo
- Execute the command `UnRegister-PSRepository <repo-name>`

## Publish local change to the local repo
- To publish changes to local repo created above, execute the ps script `src\PublishOnLocalRepo.ps1`
- Ensure you update the `$localRepoPath` variable in the above script to the LocalPSRepo package directory location.
