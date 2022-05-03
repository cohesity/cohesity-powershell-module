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
    /// Message defining the different criteria to exclude EBS volumes from backup. This is used to specify both object-level (BackupSourceParams) and job-level (EnvBackupParams) exclusion criteria. If a criterion is specified at both object-level and job-level, then job-level setting will be ignored.
    /// </summary>
    [DataContract]
    public partial class EBSVolumeExclusionParams :  IEquatable<EBSVolumeExclusionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EBSVolumeExclusionParams" /> class.
        /// </summary>
        /// <param name="deviceNameVec">List of device names to exclude. Eg - /dev/sda1, /dev/xvdb..</param>
        /// <param name="maxVolumeSizeBytes">Any volume larger than this size will be excluded..</param>
        /// <param name="volumeIdVec">List of volume IDs to exclude. This field is only for object-level exclusions..</param>
        /// <param name="volumeTypeVec">List of volume types to exclude. Eg - gp2, gp3, io1..</param>
        public EBSVolumeExclusionParams(List<string> deviceNameVec = default(List<string>), long? maxVolumeSizeBytes = default(long?), List<string> volumeIdVec = default(List<string>), List<string> volumeTypeVec = default(List<string>))
        {
            this.DeviceNameVec = deviceNameVec;
            this.MaxVolumeSizeBytes = maxVolumeSizeBytes;
            this.VolumeIdVec = volumeIdVec;
            this.VolumeTypeVec = volumeTypeVec;
        }
        
        /// <summary>
        /// List of device names to exclude. Eg - /dev/sda1, /dev/xvdb.
        /// </summary>
        /// <value>List of device names to exclude. Eg - /dev/sda1, /dev/xvdb.</value>
        [DataMember(Name="deviceNameVec", EmitDefaultValue=false)]
        public List<string> DeviceNameVec { get; set; }

        /// <summary>
        /// Any volume larger than this size will be excluded.
        /// </summary>
        /// <value>Any volume larger than this size will be excluded.</value>
        [DataMember(Name="maxVolumeSizeBytes", EmitDefaultValue=false)]
        public long? MaxVolumeSizeBytes { get; set; }

        /// <summary>
        /// List of volume IDs to exclude. This field is only for object-level exclusions.
        /// </summary>
        /// <value>List of volume IDs to exclude. This field is only for object-level exclusions.</value>
        [DataMember(Name="volumeIdVec", EmitDefaultValue=false)]
        public List<string> VolumeIdVec { get; set; }

        /// <summary>
        /// List of volume types to exclude. Eg - gp2, gp3, io1.
        /// </summary>
        /// <value>List of volume types to exclude. Eg - gp2, gp3, io1.</value>
        [DataMember(Name="volumeTypeVec", EmitDefaultValue=false)]
        public List<string> VolumeTypeVec { get; set; }

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
            return this.Equals(input as EBSVolumeExclusionParams);
        }

        /// <summary>
        /// Returns true if EBSVolumeExclusionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of EBSVolumeExclusionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EBSVolumeExclusionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceNameVec == input.DeviceNameVec ||
                    this.DeviceNameVec != null &&
                    this.DeviceNameVec.Equals(input.DeviceNameVec)
                ) && 
                (
                    this.MaxVolumeSizeBytes == input.MaxVolumeSizeBytes ||
                    (this.MaxVolumeSizeBytes != null &&
                    this.MaxVolumeSizeBytes.Equals(input.MaxVolumeSizeBytes))
                ) && 
                (
                    this.VolumeIdVec == input.VolumeIdVec ||
                    this.VolumeIdVec != null &&
                    this.VolumeIdVec.Equals(input.VolumeIdVec)
                ) && 
                (
                    this.VolumeTypeVec == input.VolumeTypeVec ||
                    this.VolumeTypeVec != null &&
                    this.VolumeTypeVec.Equals(input.VolumeTypeVec)
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
                if (this.DeviceNameVec != null)
                    hashCode = hashCode * 59 + this.DeviceNameVec.GetHashCode();
                if (this.MaxVolumeSizeBytes != null)
                    hashCode = hashCode * 59 + this.MaxVolumeSizeBytes.GetHashCode();
                if (this.VolumeIdVec != null)
                    hashCode = hashCode * 59 + this.VolumeIdVec.GetHashCode();
                if (this.VolumeTypeVec != null)
                    hashCode = hashCode * 59 + this.VolumeTypeVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

