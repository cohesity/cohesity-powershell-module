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
    /// This is extra attribute which uniquely identifies a logical volume in LVM or LDM.
    /// </summary>
    [DataContract]
    public partial class VolumeInfoLogicalVolumeInfo :  IEquatable<VolumeInfoLogicalVolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfoLogicalVolumeInfo" /> class.
        /// </summary>
        /// <param name="deviceTree">deviceTree.</param>
        /// <param name="logicalVolumeName">Logical volume name..</param>
        /// <param name="logicalVolumeUuid">Logical volume uuid..</param>
        /// <param name="volumeGroupName">Volume group name..</param>
        /// <param name="volumeGroupUuid">Volume group uuid..</param>
        public VolumeInfoLogicalVolumeInfo(DeviceTree deviceTree = default(DeviceTree), string logicalVolumeName = default(string), string logicalVolumeUuid = default(string), string volumeGroupName = default(string), string volumeGroupUuid = default(string))
        {
            this.DeviceTree = deviceTree;
            this.LogicalVolumeName = logicalVolumeName;
            this.LogicalVolumeUuid = logicalVolumeUuid;
            this.VolumeGroupName = volumeGroupName;
            this.VolumeGroupUuid = volumeGroupUuid;
        }
        
        /// <summary>
        /// Gets or Sets DeviceTree
        /// </summary>
        [DataMember(Name="deviceTree", EmitDefaultValue=false)]
        public DeviceTree DeviceTree { get; set; }

        /// <summary>
        /// Logical volume name.
        /// </summary>
        /// <value>Logical volume name.</value>
        [DataMember(Name="logicalVolumeName", EmitDefaultValue=false)]
        public string LogicalVolumeName { get; set; }

        /// <summary>
        /// Logical volume uuid.
        /// </summary>
        /// <value>Logical volume uuid.</value>
        [DataMember(Name="logicalVolumeUuid", EmitDefaultValue=false)]
        public string LogicalVolumeUuid { get; set; }

        /// <summary>
        /// Volume group name.
        /// </summary>
        /// <value>Volume group name.</value>
        [DataMember(Name="volumeGroupName", EmitDefaultValue=false)]
        public string VolumeGroupName { get; set; }

        /// <summary>
        /// Volume group uuid.
        /// </summary>
        /// <value>Volume group uuid.</value>
        [DataMember(Name="volumeGroupUuid", EmitDefaultValue=false)]
        public string VolumeGroupUuid { get; set; }

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
            return this.Equals(input as VolumeInfoLogicalVolumeInfo);
        }

        /// <summary>
        /// Returns true if VolumeInfoLogicalVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfoLogicalVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfoLogicalVolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceTree == input.DeviceTree ||
                    (this.DeviceTree != null &&
                    this.DeviceTree.Equals(input.DeviceTree))
                ) && 
                (
                    this.LogicalVolumeName == input.LogicalVolumeName ||
                    (this.LogicalVolumeName != null &&
                    this.LogicalVolumeName.Equals(input.LogicalVolumeName))
                ) && 
                (
                    this.LogicalVolumeUuid == input.LogicalVolumeUuid ||
                    (this.LogicalVolumeUuid != null &&
                    this.LogicalVolumeUuid.Equals(input.LogicalVolumeUuid))
                ) && 
                (
                    this.VolumeGroupName == input.VolumeGroupName ||
                    (this.VolumeGroupName != null &&
                    this.VolumeGroupName.Equals(input.VolumeGroupName))
                ) && 
                (
                    this.VolumeGroupUuid == input.VolumeGroupUuid ||
                    (this.VolumeGroupUuid != null &&
                    this.VolumeGroupUuid.Equals(input.VolumeGroupUuid))
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
                if (this.DeviceTree != null)
                    hashCode = hashCode * 59 + this.DeviceTree.GetHashCode();
                if (this.LogicalVolumeName != null)
                    hashCode = hashCode * 59 + this.LogicalVolumeName.GetHashCode();
                if (this.LogicalVolumeUuid != null)
                    hashCode = hashCode * 59 + this.LogicalVolumeUuid.GetHashCode();
                if (this.VolumeGroupName != null)
                    hashCode = hashCode * 59 + this.VolumeGroupName.GetHashCode();
                if (this.VolumeGroupUuid != null)
                    hashCode = hashCode * 59 + this.VolumeGroupUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

