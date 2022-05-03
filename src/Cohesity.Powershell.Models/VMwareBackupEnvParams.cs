// Copyright 2019 Cohesity Inc.


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Model
{
    /// <summary>
    /// Message to capture any additional backup params for a VMware environment.
    /// </summary>
    [DataContract]
    public partial class VMwareBackupEnvParams :  IEquatable<VMwareBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareBackupEnvParams" /> class.
        /// </summary>
        /// <param name="allowCrashConsistentSnapshot">Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails..</param>
        /// <param name="allowNbdsslTransportFallback">Whether to fallback to use NBDSSL transport for backup in case using SAN transport backup fails..</param>
        /// <param name="allowVmsWithPhysicalRdmDisks">Physical RDM disks cannot be backed up using VADP. By default the backups of such VMs will fail. If this is set to true, then such VMs in this backup job will be backed up by excluding the physical RDM disks..</param>
        /// <param name="enableCbtAllowed">Whether the backup job should allow enabling CBT for VM when the backup runs. Currently, by default, the backup run enables CBT for a VM during the backup if it&#39;s not already enabled. However, there may be a case, where customer doesn&#39;t want to enable CBT during the backup. This param will be used to determine that..</param>
        /// <param name="vmwareDiskExclusionInfo">List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.VMwareBackupSourceParams..</param>
        public VMwareBackupEnvParams(bool? allowCrashConsistentSnapshot = default(bool?), bool? allowNbdsslTransportFallback = default(bool?), bool? allowVmsWithPhysicalRdmDisks = default(bool?), bool? enableCbtAllowed = default(bool?), List<VMwareDiskExclusionProto> vmwareDiskExclusionInfo = default(List<VMwareDiskExclusionProto>))
        {
            this.AllowCrashConsistentSnapshot = allowCrashConsistentSnapshot;
            this.AllowNbdsslTransportFallback = allowNbdsslTransportFallback;
            this.AllowVmsWithPhysicalRdmDisks = allowVmsWithPhysicalRdmDisks;
            this.EnableCbtAllowed = enableCbtAllowed;
            this.VmwareDiskExclusionInfo = vmwareDiskExclusionInfo;
        }
        
        /// <summary>
        /// Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.
        /// </summary>
        /// <value>Whether to fallback to take a crash-consistent snapshot incase taking an app-consistent snapshot fails.</value>
        [DataMember(Name="allowCrashConsistentSnapshot", EmitDefaultValue=false)]
        public bool? AllowCrashConsistentSnapshot { get; set; }

        /// <summary>
        /// Whether to fallback to use NBDSSL transport for backup in case using SAN transport backup fails.
        /// </summary>
        /// <value>Whether to fallback to use NBDSSL transport for backup in case using SAN transport backup fails.</value>
        [DataMember(Name="allowNbdsslTransportFallback", EmitDefaultValue=false)]
        public bool? AllowNbdsslTransportFallback { get; set; }

        /// <summary>
        /// Physical RDM disks cannot be backed up using VADP. By default the backups of such VMs will fail. If this is set to true, then such VMs in this backup job will be backed up by excluding the physical RDM disks.
        /// </summary>
        /// <value>Physical RDM disks cannot be backed up using VADP. By default the backups of such VMs will fail. If this is set to true, then such VMs in this backup job will be backed up by excluding the physical RDM disks.</value>
        [DataMember(Name="allowVmsWithPhysicalRdmDisks", EmitDefaultValue=false)]
        public bool? AllowVmsWithPhysicalRdmDisks { get; set; }

        /// <summary>
        /// Whether the backup job should allow enabling CBT for VM when the backup runs. Currently, by default, the backup run enables CBT for a VM during the backup if it&#39;s not already enabled. However, there may be a case, where customer doesn&#39;t want to enable CBT during the backup. This param will be used to determine that.
        /// </summary>
        /// <value>Whether the backup job should allow enabling CBT for VM when the backup runs. Currently, by default, the backup run enables CBT for a VM during the backup if it&#39;s not already enabled. However, there may be a case, where customer doesn&#39;t want to enable CBT during the backup. This param will be used to determine that.</value>
        [DataMember(Name="enableCbtAllowed", EmitDefaultValue=false)]
        public bool? EnableCbtAllowed { get; set; }

        /// <summary>
        /// List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.VMwareBackupSourceParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion list from BackupSourceParams.VMwareBackupSourceParams.</value>
        [DataMember(Name="vmwareDiskExclusionInfo", EmitDefaultValue=false)]
        public List<VMwareDiskExclusionProto> VmwareDiskExclusionInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VMwareBackupEnvParams);
        }

        /// <summary>
        /// Returns true if VMwareBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowCrashConsistentSnapshot == input.AllowCrashConsistentSnapshot ||
                    (this.AllowCrashConsistentSnapshot != null &&
                    this.AllowCrashConsistentSnapshot.Equals(input.AllowCrashConsistentSnapshot))
                ) && 
                (
                    this.AllowNbdsslTransportFallback == input.AllowNbdsslTransportFallback ||
                    (this.AllowNbdsslTransportFallback != null &&
                    this.AllowNbdsslTransportFallback.Equals(input.AllowNbdsslTransportFallback))
                ) && 
                (
                    this.AllowVmsWithPhysicalRdmDisks == input.AllowVmsWithPhysicalRdmDisks ||
                    (this.AllowVmsWithPhysicalRdmDisks != null &&
                    this.AllowVmsWithPhysicalRdmDisks.Equals(input.AllowVmsWithPhysicalRdmDisks))
                ) && 
                (
                    this.EnableCbtAllowed == input.EnableCbtAllowed ||
                    (this.EnableCbtAllowed != null &&
                    this.EnableCbtAllowed.Equals(input.EnableCbtAllowed))
                ) && 
                (
                    this.VmwareDiskExclusionInfo == input.VmwareDiskExclusionInfo ||
                    this.VmwareDiskExclusionInfo != null &&
                    this.VmwareDiskExclusionInfo.Equals(input.VmwareDiskExclusionInfo)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AllowCrashConsistentSnapshot != null)
                    hashCode = hashCode * 59 + this.AllowCrashConsistentSnapshot.GetHashCode();
                if (this.AllowNbdsslTransportFallback != null)
                    hashCode = hashCode * 59 + this.AllowNbdsslTransportFallback.GetHashCode();
                if (this.AllowVmsWithPhysicalRdmDisks != null)
                    hashCode = hashCode * 59 + this.AllowVmsWithPhysicalRdmDisks.GetHashCode();
                if (this.EnableCbtAllowed != null)
                    hashCode = hashCode * 59 + this.EnableCbtAllowed.GetHashCode();
                if (this.VmwareDiskExclusionInfo != null)
                    hashCode = hashCode * 59 + this.VmwareDiskExclusionInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

