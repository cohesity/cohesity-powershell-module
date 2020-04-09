# VMWare workflow

## Overview

This workflow uses the Cohesity powershell modules along with [PowerCLI](https://www.vmware.com/support/developer/PowerCLI/) to interact with a Cohesity and VMWare cluster to Register a vCenter as a protection source and protect VMs in it. If you want to know all teh steps in the workflow, refer to [steps](#steps) section.

## Table of contents :scroll:

 - [Components](#components)
 - [How to run](#howto)
 - [Steps](#steps)
 - [Suggestions and Feedback](#suggest)
 
## <a name="components"></a> Brief summary of all components used here  :mag:

* `vars.json`: This file contains all the variables that this workflow needs to execute. In case you forget to update any variable here, the workflow will prompt you to enter the parameters.

* `workflow01.ps1`: This file contains the script that executes the workflow using `vars.json` and `Cohesity Powershell Module`.


## <a name="howto"></a> Instructions for executing this workflow :hammer_and_pick:

1.  Update the `vars.json` file with your environment details. You would need your vCenter and Cohesity cluster details along with some other details. 

	> Most of the variables are self explanatory. Other variables are explained below
	
	* `vCenterFolderName`: Folder in vCenter Cluster where your VM will be created. 
	* `VMPrefix`: This prefix will be appended to the VM that gets created. Your VM name will be `VMPrefix-XX` where `XX`is the VM number (01, 02 ..)
	* `SourceVMName`: This VM will be cloned to create New VMs. You need to have VM in vCenter that you want to clone 
	* `ProtectionPolicyName`: An existing policy from Cohesity Cluster that will be applied to the Protection Group that will be created

2. To run the workflow, just open a powershell prompt run `./workflow01.ps1`. This will start executing the script. 

	> The workflow will prompt you to enter vCenter Credentials and Cohesity Credentials

3. Once you run the workflow, you should be able to see a New Protection Group created in the Cohesity Cluster.

## <a name="steps"></a> Detailed Steps in the workflow :book:

The workflow execution includes the following sub taks

1. Import the API cmdlet from utility folder in Cohesity module
2. Read the `vars.json` file
3. Connect to vCenter
4. Connect to Cohesity Cluster
5. Create 3 VMs in vCenter by cloning the `sourceVMName` in vCenter
6. Add the vCenter as a protection source if it not already registered
7. Refresh the vCenter hierarchy tree in Cohesity
8. Create and run a Protection Group using the `ProtectionPolicyName `and add the newly cloned VMs to this Protection Group
9. Clone 2 more VMs using `sourceVMName`
10. Update the Protection Group by adding the 2 VMs created in step 9

	> Note: You need to run the protection group again on Cohesity cluster after adding the 2 new VMs from step 9 to take backup of these VMs


# Cohesity VMware backup restore test validation example

This is an example powershell for simple random recovery test for each VMware Protection Job.

Script will automatically select random virtual machines from each job for recovery. By default number is 2 per job, but this can altered to any other value. Script will clone VMs for recovery testing, and after succesful cloning it will validate VM status with VMware Tools running status.

# Prerequisites

* [PowerShell](https://aka.ms/getps6)
* [Cohesity PowerShell Module](https://cohesity.github.io/cohesity-powershell-module/#/)
* [VMware PowerCLI](https://www.powershellgallery.com/packages/VMware.PowerCLI/)

# How to start using this?


## Credential files

This script uses encrypted credentials for authentication. You can create credentials with simple two commands:

```PowerShell
Get-Credential | Export-Clixml vmware_credentials.xml
Get-Credential | Export-Clixml cohesity_credentials.xml
```

Note: Secure XML files can only be decrypted by the user account that created them.

## Usage
./vmware-recovery-tests.ps1 -cohesityCluster 192.168.1.198 -vmwareEnvironment 192.168.1.200 -cohesityCred 'cohesity_credentials.xml' -vmwareCred 'vmware_credentials.xml' -resourcePool 'Resources' -perjob '10']


# Notes
Jussi Jaurola - <jussi@cohesity.com>
```
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```
