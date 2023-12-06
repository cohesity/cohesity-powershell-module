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
    /// GCPNativeJobParams
    /// </summary>
    [DataContract]
    public partial class GCPNativeJobParams :  IEquatable<GCPNativeJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPNativeJobParams" /> class.
        /// </summary>
        /// <param name="diskExclusionRawQuery">Specifies the disk exclusion raw query used to exclude disks from backup..</param>
        /// <param name="diskExclusionRuleVec">Specifies the different criteria to exclude disks from backup. The values set in disk_exclusion_params will be used for OR operation. For E.g: if disk_exclusion_params has values [(Balanced-Persistant &amp;&amp; instance1-disk),((k1:v1) &amp;&amp; (k2:v2))] then the exclusion criteria will be (Balanced-Persistant &amp;&amp; instance1-disk) || ((k1:v1) &amp;&amp; (k2:v2)).</param>
        /// <param name="excludeVmWithoutDisk">Specifies whether to exclude VM without disk..</param>
        public GCPNativeJobParams(string diskExclusionRawQuery = default(string), List<GCPJobDiskExclusionRule> diskExclusionRuleVec = default(List<GCPJobDiskExclusionRule>), bool? excludeVmWithoutDisk = default(bool?))
        {
            this.DiskExclusionRawQuery = diskExclusionRawQuery;
            this.DiskExclusionRuleVec = diskExclusionRuleVec;
            this.ExcludeVmWithoutDisk = excludeVmWithoutDisk;
            this.DiskExclusionRawQuery = diskExclusionRawQuery;
            this.DiskExclusionRuleVec = diskExclusionRuleVec;
            this.ExcludeVmWithoutDisk = excludeVmWithoutDisk;
        }
        
        /// <summary>
        /// Specifies the disk exclusion raw query used to exclude disks from backup.
        /// </summary>
        /// <value>Specifies the disk exclusion raw query used to exclude disks from backup.</value>
        [DataMember(Name="diskExclusionRawQuery", EmitDefaultValue=true)]
        public string DiskExclusionRawQuery { get; set; }

        /// <summary>
        /// Specifies the different criteria to exclude disks from backup. The values set in disk_exclusion_params will be used for OR operation. For E.g: if disk_exclusion_params has values [(Balanced-Persistant &amp;&amp; instance1-disk),((k1:v1) &amp;&amp; (k2:v2))] then the exclusion criteria will be (Balanced-Persistant &amp;&amp; instance1-disk) || ((k1:v1) &amp;&amp; (k2:v2))
        /// </summary>
        /// <value>Specifies the different criteria to exclude disks from backup. The values set in disk_exclusion_params will be used for OR operation. For E.g: if disk_exclusion_params has values [(Balanced-Persistant &amp;&amp; instance1-disk),((k1:v1) &amp;&amp; (k2:v2))] then the exclusion criteria will be (Balanced-Persistant &amp;&amp; instance1-disk) || ((k1:v1) &amp;&amp; (k2:v2))</value>
        [DataMember(Name="diskExclusionRuleVec", EmitDefaultValue=true)]
        public List<GCPJobDiskExclusionRule> DiskExclusionRuleVec { get; set; }

        /// <summary>
        /// Specifies whether to exclude VM without disk.
        /// </summary>
        /// <value>Specifies whether to exclude VM without disk.</value>
        [DataMember(Name="excludeVmWithoutDisk", EmitDefaultValue=true)]
        public bool? ExcludeVmWithoutDisk { get; set; }

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
            return this.Equals(input as GCPNativeJobParams);
        }

        /// <summary>
        /// Returns true if GCPNativeJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPNativeJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPNativeJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskExclusionRawQuery == input.DiskExclusionRawQuery ||
                    (this.DiskExclusionRawQuery != null &&
                    this.DiskExclusionRawQuery.Equals(input.DiskExclusionRawQuery))
                ) && 
                (
                    this.DiskExclusionRuleVec == input.DiskExclusionRuleVec ||
                    this.DiskExclusionRuleVec != null &&
                    input.DiskExclusionRuleVec != null &&
                    this.DiskExclusionRuleVec.SequenceEqual(input.DiskExclusionRuleVec)
                ) && 
                (
                    this.ExcludeVmWithoutDisk == input.ExcludeVmWithoutDisk ||
                    (this.ExcludeVmWithoutDisk != null &&
                    this.ExcludeVmWithoutDisk.Equals(input.ExcludeVmWithoutDisk))
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
                if (this.DiskExclusionRawQuery != null)
                    hashCode = hashCode * 59 + this.DiskExclusionRawQuery.GetHashCode();
                if (this.DiskExclusionRuleVec != null)
                    hashCode = hashCode * 59 + this.DiskExclusionRuleVec.GetHashCode();
                if (this.ExcludeVmWithoutDisk != null)
                    hashCode = hashCode * 59 + this.ExcludeVmWithoutDisk.GetHashCode();
                return hashCode;
            }
        }

    }

}

