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
    /// Specifies the information required for mounting volumes. Only required for Restore Tasks of type &#39;kMountVolumes&#39;. At a minimum, the targetSourceId must be specified for &#39;kMountVolumes&#39; Restore Tasks. If only targetSourceId is specified, all disks are attached but may not be mounted. The mount target must be registered on the Cohesity Cluster. If the mount target is a VM, VMware Tools must be installed. If the mount target is a physical server, a Cohesity Agent must be be installed. See the Cohesity Dashboard help documentation for details. In the username and password fields, specify the credentials to access the mount target.
    /// </summary>
    [DataContract]
    public partial class MountVolumesParameters :  IEquatable<MountVolumesParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesParameters" /> class.
        /// </summary>
        /// <param name="bringDisksOnline">Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This field is only set for VMs. The Cohesity Cluster always attempts to mount Physical servers. If true and the mount target is a VM, to mount the volumes VMware Tools must be installed on the guest operating system of the VM and login credentials to the mount target must be specified. NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="targetSourceId">Specifies the target Protection Source id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="volumeNames">Optionally specify the names of volumes to mount. If none are specified, all volumes of the Server are mounted on the target. To get the names of the volumes, call the GET /public/restore/vms/volumesInformation operation..</param>
        public MountVolumesParameters(bool? bringDisksOnline = default(bool?), string password = default(string), long? targetSourceId = default(long?), string username = default(string), List<string> volumeNames = default(List<string>))
        {
            this.BringDisksOnline = bringDisksOnline;
            this.Password = password;
            this.TargetSourceId = targetSourceId;
            this.Username = username;
            this.VolumeNames = volumeNames;
        }
        
        /// <summary>
        /// Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This field is only set for VMs. The Cohesity Cluster always attempts to mount Physical servers. If true and the mount target is a VM, to mount the volumes VMware Tools must be installed on the guest operating system of the VM and login credentials to the mount target must be specified. NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online.
        /// </summary>
        /// <value>Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This field is only set for VMs. The Cohesity Cluster always attempts to mount Physical servers. If true and the mount target is a VM, to mount the volumes VMware Tools must be installed on the guest operating system of the VM and login credentials to the mount target must be specified. NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online.</value>
        [DataMember(Name="bringDisksOnline", EmitDefaultValue=false)]
        public bool? BringDisksOnline { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the target Protection Source id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the target Protection Source id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster.</value>
        [DataMember(Name="targetSourceId", EmitDefaultValue=false)]
        public long? TargetSourceId { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Optionally specify the names of volumes to mount. If none are specified, all volumes of the Server are mounted on the target. To get the names of the volumes, call the GET /public/restore/vms/volumesInformation operation.
        /// </summary>
        /// <value>Optionally specify the names of volumes to mount. If none are specified, all volumes of the Server are mounted on the target. To get the names of the volumes, call the GET /public/restore/vms/volumesInformation operation.</value>
        [DataMember(Name="volumeNames", EmitDefaultValue=false)]
        public List<string> VolumeNames { get; set; }

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
            return this.Equals(input as MountVolumesParameters);
        }

        /// <summary>
        /// Returns true if MountVolumesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesParameters input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                ) && 
                (
                    this.VolumeNames == input.VolumeNames ||
                    this.VolumeNames != null &&
                    this.VolumeNames.SequenceEqual(input.VolumeNames)
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TargetSourceId != null)
                    hashCode = hashCode * 59 + this.TargetSourceId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VolumeNames != null)
                    hashCode = hashCode * 59 + this.VolumeNames.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

