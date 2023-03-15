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
        /// <param name="rawQuery">Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec..</param>
        /// <param name="tagParamsVec">List of Tag Params to exclude EBS volumes..</param>
        /// <param name="volumeIdVec">List of volume IDs to exclude. This field is only for object-level exclusions..</param>
        /// <param name="volumeTypeVec">List of volume types to exclude. Eg - gp2, gp3, io1..</param>
        public EBSVolumeExclusionParams(List<string> deviceNameVec = default(List<string>), long? maxVolumeSizeBytes = default(long?), string rawQuery = default(string), List<EBSVolumeExclusionParamsTagParams> tagParamsVec = default(List<EBSVolumeExclusionParamsTagParams>), List<string> volumeIdVec = default(List<string>), List<string> volumeTypeVec = default(List<string>))
        {
            this.DeviceNameVec = deviceNameVec;
            this.MaxVolumeSizeBytes = maxVolumeSizeBytes;
            this.RawQuery = rawQuery;
            this.TagParamsVec = tagParamsVec;
            this.VolumeIdVec = volumeIdVec;
            this.VolumeTypeVec = volumeTypeVec;
            this.DeviceNameVec = deviceNameVec;
            this.MaxVolumeSizeBytes = maxVolumeSizeBytes;
            this.RawQuery = rawQuery;
            this.TagParamsVec = tagParamsVec;
            this.VolumeIdVec = volumeIdVec;
            this.VolumeTypeVec = volumeTypeVec;
        }
        
        /// <summary>
        /// List of device names to exclude. Eg - /dev/sda1, /dev/xvdb.
        /// </summary>
        /// <value>List of device names to exclude. Eg - /dev/sda1, /dev/xvdb.</value>
        [DataMember(Name="deviceNameVec", EmitDefaultValue=true)]
        public List<string> DeviceNameVec { get; set; }

        /// <summary>
        /// Any volume larger than this size will be excluded.
        /// </summary>
        /// <value>Any volume larger than this size will be excluded.</value>
        [DataMember(Name="maxVolumeSizeBytes", EmitDefaultValue=true)]
        public long? MaxVolumeSizeBytes { get; set; }

        /// <summary>
        /// Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec.
        /// </summary>
        /// <value>Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec.</value>
        [DataMember(Name="rawQuery", EmitDefaultValue=true)]
        public string RawQuery { get; set; }

        /// <summary>
        /// List of Tag Params to exclude EBS volumes.
        /// </summary>
        /// <value>List of Tag Params to exclude EBS volumes.</value>
        [DataMember(Name="tagParamsVec", EmitDefaultValue=true)]
        public List<EBSVolumeExclusionParamsTagParams> TagParamsVec { get; set; }

        /// <summary>
        /// List of volume IDs to exclude. This field is only for object-level exclusions.
        /// </summary>
        /// <value>List of volume IDs to exclude. This field is only for object-level exclusions.</value>
        [DataMember(Name="volumeIdVec", EmitDefaultValue=true)]
        public List<string> VolumeIdVec { get; set; }

        /// <summary>
        /// List of volume types to exclude. Eg - gp2, gp3, io1.
        /// </summary>
        /// <value>List of volume types to exclude. Eg - gp2, gp3, io1.</value>
        [DataMember(Name="volumeTypeVec", EmitDefaultValue=true)]
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
                    input.DeviceNameVec != null &&
                    this.DeviceNameVec.SequenceEqual(input.DeviceNameVec)
                ) && 
                (
                    this.MaxVolumeSizeBytes == input.MaxVolumeSizeBytes ||
                    (this.MaxVolumeSizeBytes != null &&
                    this.MaxVolumeSizeBytes.Equals(input.MaxVolumeSizeBytes))
                ) && 
                (
                    this.RawQuery == input.RawQuery ||
                    (this.RawQuery != null &&
                    this.RawQuery.Equals(input.RawQuery))
                ) && 
                (
                    this.TagParamsVec == input.TagParamsVec ||
                    this.TagParamsVec != null &&
                    input.TagParamsVec != null &&
                    this.TagParamsVec.SequenceEqual(input.TagParamsVec)
                ) && 
                (
                    this.VolumeIdVec == input.VolumeIdVec ||
                    this.VolumeIdVec != null &&
                    input.VolumeIdVec != null &&
                    this.VolumeIdVec.SequenceEqual(input.VolumeIdVec)
                ) && 
                (
                    this.VolumeTypeVec == input.VolumeTypeVec ||
                    this.VolumeTypeVec != null &&
                    input.VolumeTypeVec != null &&
                    this.VolumeTypeVec.SequenceEqual(input.VolumeTypeVec)
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
                if (this.RawQuery != null)
                    hashCode = hashCode * 59 + this.RawQuery.GetHashCode();
                if (this.TagParamsVec != null)
                    hashCode = hashCode * 59 + this.TagParamsVec.GetHashCode();
                if (this.VolumeIdVec != null)
                    hashCode = hashCode * 59 + this.VolumeIdVec.GetHashCode();
                if (this.VolumeTypeVec != null)
                    hashCode = hashCode * 59 + this.VolumeTypeVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

