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
    /// Message defining the different criteria to exclude GCP disks from job-level backup. The values set will be used for AND operation. For E.g:(Balanced-Persistant &amp;&amp; instance1-disk)
    /// </summary>
    [DataContract]
    public partial class GCPJobDiskExclusionRule :  IEquatable<GCPJobDiskExclusionRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPJobDiskExclusionRule" /> class.
        /// </summary>
        /// <param name="diskName">Disk name to exclude. Eg - instance1-disk.</param>
        /// <param name="diskType">Disk types to exclude. Eg - Balanced-Persistant etc..</param>
        /// <param name="labelVec">Specifies the label vectors used to exclude GCP disks attached to GCP instances at global and object level. E.g., {label_vec: [(K1, V1),  (K2, V2)], &#x3D;&gt; This will exclude a particular disk if it has all the tags in label_vec((K1, V1),  (K2, V2)).</param>
        public GCPJobDiskExclusionRule(string diskName = default(string), string diskType = default(string), List<GCPJobDiskExclusionRuleLabel> labelVec = default(List<GCPJobDiskExclusionRuleLabel>))
        {
            this.DiskName = diskName;
            this.DiskType = diskType;
            this.LabelVec = labelVec;
            this.DiskName = diskName;
            this.DiskType = diskType;
            this.LabelVec = labelVec;
        }
        
        /// <summary>
        /// Disk name to exclude. Eg - instance1-disk
        /// </summary>
        /// <value>Disk name to exclude. Eg - instance1-disk</value>
        [DataMember(Name="diskName", EmitDefaultValue=true)]
        public string DiskName { get; set; }

        /// <summary>
        /// Disk types to exclude. Eg - Balanced-Persistant etc.
        /// </summary>
        /// <value>Disk types to exclude. Eg - Balanced-Persistant etc.</value>
        [DataMember(Name="diskType", EmitDefaultValue=true)]
        public string DiskType { get; set; }

        /// <summary>
        /// Specifies the label vectors used to exclude GCP disks attached to GCP instances at global and object level. E.g., {label_vec: [(K1, V1),  (K2, V2)], &#x3D;&gt; This will exclude a particular disk if it has all the tags in label_vec((K1, V1),  (K2, V2))
        /// </summary>
        /// <value>Specifies the label vectors used to exclude GCP disks attached to GCP instances at global and object level. E.g., {label_vec: [(K1, V1),  (K2, V2)], &#x3D;&gt; This will exclude a particular disk if it has all the tags in label_vec((K1, V1),  (K2, V2))</value>
        [DataMember(Name="labelVec", EmitDefaultValue=true)]
        public List<GCPJobDiskExclusionRuleLabel> LabelVec { get; set; }

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
            return this.Equals(input as GCPJobDiskExclusionRule);
        }

        /// <summary>
        /// Returns true if GCPJobDiskExclusionRule instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPJobDiskExclusionRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPJobDiskExclusionRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskName == input.DiskName ||
                    (this.DiskName != null &&
                    this.DiskName.Equals(input.DiskName))
                ) && 
                (
                    this.DiskType == input.DiskType ||
                    (this.DiskType != null &&
                    this.DiskType.Equals(input.DiskType))
                ) && 
                (
                    this.LabelVec == input.LabelVec ||
                    this.LabelVec != null &&
                    input.LabelVec != null &&
                    this.LabelVec.SequenceEqual(input.LabelVec)
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
                if (this.DiskName != null)
                    hashCode = hashCode * 59 + this.DiskName.GetHashCode();
                if (this.DiskType != null)
                    hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.LabelVec != null)
                    hashCode = hashCode * 59 + this.LabelVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

