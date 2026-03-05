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
    /// Message defining the different criteria to exclude Azure disks from backup. This is used to specify both object-level (BackupSourceParams) and job-level (EnvBackupParams) exclusion criteria. If a criterion is specified at both object-level and job-level, then job-level setting will be ignored.
    /// </summary>
    [DataContract]
    public partial class AzureDiskExclusionParams :  IEquatable<AzureDiskExclusionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDiskExclusionParams" /> class.
        /// </summary>
        /// <param name="diskIdVec">List of disk resource IDs to exclude. This field is only for object-level exclusions..</param>
        /// <param name="rawQuery">Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec..</param>
        /// <param name="tagParamsVec">List of Tag Params to exclude Azure disks..</param>
        public AzureDiskExclusionParams(List<string> diskIdVec = default(List<string>), string rawQuery = default(string), List<AzureDiskExclusionParamsTagParams> tagParamsVec = default(List<AzureDiskExclusionParamsTagParams>))
        {
            this.DiskIdVec = diskIdVec;
            this.RawQuery = rawQuery;
            this.TagParamsVec = tagParamsVec;
            this.DiskIdVec = diskIdVec;
            this.RawQuery = rawQuery;
            this.TagParamsVec = tagParamsVec;
        }
        
        /// <summary>
        /// List of disk resource IDs to exclude. This field is only for object-level exclusions.
        /// </summary>
        /// <value>List of disk resource IDs to exclude. This field is only for object-level exclusions.</value>
        [DataMember(Name="diskIdVec", EmitDefaultValue=true)]
        public List<string> DiskIdVec { get; set; }

        /// <summary>
        /// Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec.
        /// </summary>
        /// <value>Raw boolean query given as input by the user to exclude volume based on tags. In the current version, the query contains only tags. Example query 1: \&quot;K1\&quot; &#x3D; \&quot;V1\&quot; AND \&quot;K2\&quot; IN (\&quot;V2\&quot;, \&quot;V3\&quot;) AND \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; Example query 2: \&quot;K1\&quot; !&#x3D; \&quot;V1\&quot; OR \&quot;K2\&quot; NOT IN (\&quot;V2\&quot;, \&quot;V3\&quot;) OR \&quot;K4\&quot; !&#x3D; \&quot;V4\&quot; All Keys and Values must be wrapped inside double quotes. Comparision Operators supported : &#x3D;, !&#x3D;, IN, NOT IN. Logical Operators supported : AND, OR. We cannot have AND, OR together in the query. Only one of them is allowed. The processed form for this query is stored in the above tag_params_vec.</value>
        [DataMember(Name="rawQuery", EmitDefaultValue=true)]
        public string RawQuery { get; set; }

        /// <summary>
        /// List of Tag Params to exclude Azure disks.
        /// </summary>
        /// <value>List of Tag Params to exclude Azure disks.</value>
        [DataMember(Name="tagParamsVec", EmitDefaultValue=true)]
        public List<AzureDiskExclusionParamsTagParams> TagParamsVec { get; set; }

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
            return this.Equals(input as AzureDiskExclusionParams);
        }

        /// <summary>
        /// Returns true if AzureDiskExclusionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureDiskExclusionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureDiskExclusionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskIdVec == input.DiskIdVec ||
                    this.DiskIdVec != null &&
                    input.DiskIdVec != null &&
                    this.DiskIdVec.SequenceEqual(input.DiskIdVec)
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
                if (this.DiskIdVec != null)
                    hashCode = hashCode * 59 + this.DiskIdVec.GetHashCode();
                if (this.RawQuery != null)
                    hashCode = hashCode * 59 + this.RawQuery.GetHashCode();
                if (this.TagParamsVec != null)
                    hashCode = hashCode * 59 + this.TagParamsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

