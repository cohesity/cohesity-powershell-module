// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the states of mounting all the volumes onto a mount target for a &#39;kRecoverVMs&#39; Restore Task.
    /// </summary>
    [DataContract]
    public partial class MountVolumesState :  IEquatable<MountVolumesState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesState" /> class.
        /// </summary>
        /// <param name="bringDisksOnline">Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This option is only significant for VMs..</param>
        /// <param name="mountVolumeResults">Specifies the results of mounting each specified volume..</param>
        /// <param name="otherError">otherError.</param>
        /// <param name="targetSourceId">Specifies the target Protection Source Id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster..</param>
        /// <param name="username">Specifies the username to access the mount target..</param>
        public MountVolumesState(bool? bringDisksOnline = default(bool?), List<MountVolumeResult> mountVolumeResults = default(List<MountVolumeResult>), NonmountError_ otherError = default(NonmountError_), long? targetSourceId = default(long?), string username = default(string))
        {
            this.BringDisksOnline = bringDisksOnline;
            this.MountVolumeResults = mountVolumeResults;
            this.OtherError = otherError;
            this.TargetSourceId = targetSourceId;
            this.Username = username;
        }
        
        /// <summary>
        /// Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This option is only significant for VMs.
        /// </summary>
        /// <value>Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This option is only significant for VMs.</value>
        [DataMember(Name="bringDisksOnline", EmitDefaultValue=false)]
        public bool? BringDisksOnline { get; set; }

        /// <summary>
        /// Specifies the results of mounting each specified volume.
        /// </summary>
        /// <value>Specifies the results of mounting each specified volume.</value>
        [DataMember(Name="mountVolumeResults", EmitDefaultValue=false)]
        public List<MountVolumeResult> MountVolumeResults { get; set; }

        /// <summary>
        /// Gets or Sets OtherError
        /// </summary>
        [DataMember(Name="otherError", EmitDefaultValue=false)]
        public NonmountError_ OtherError { get; set; }

        /// <summary>
        /// Specifies the target Protection Source Id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the target Protection Source Id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster.</value>
        [DataMember(Name="targetSourceId", EmitDefaultValue=false)]
        public long? TargetSourceId { get; set; }

        /// <summary>
        /// Specifies the username to access the mount target.
        /// </summary>
        /// <value>Specifies the username to access the mount target.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as MountVolumesState);
        }

        /// <summary>
        /// Returns true if MountVolumesState instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BringDisksOnline == input.BringDisksOnline ||
                    (this.BringDisksOnline != null &&
                    this.BringDisksOnline.Equals(input.BringDisksOnline))
                ) && 
                (
                    this.MountVolumeResults == input.MountVolumeResults ||
                    this.MountVolumeResults != null &&
                    this.MountVolumeResults.SequenceEqual(input.MountVolumeResults)
                ) && 
                (
                    this.OtherError == input.OtherError ||
                    (this.OtherError != null &&
                    this.OtherError.Equals(input.OtherError))
                ) && 
                (
                    this.TargetSourceId == input.TargetSourceId ||
                    (this.TargetSourceId != null &&
                    this.TargetSourceId.Equals(input.TargetSourceId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.BringDisksOnline != null)
                    hashCode = hashCode * 59 + this.BringDisksOnline.GetHashCode();
                if (this.MountVolumeResults != null)
                    hashCode = hashCode * 59 + this.MountVolumeResults.GetHashCode();
                if (this.OtherError != null)
                    hashCode = hashCode * 59 + this.OtherError.GetHashCode();
                if (this.TargetSourceId != null)
                    hashCode = hashCode * 59 + this.TargetSourceId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

