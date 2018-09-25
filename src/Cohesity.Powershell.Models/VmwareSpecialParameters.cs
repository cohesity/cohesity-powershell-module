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
    /// Specifies additional special settings applicable for a Protection Source of &#39;kVMware&#39; type in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class VmwareSpecialParameters :  IEquatable<VmwareSpecialParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareSpecialParameters" /> class.
        /// </summary>
        /// <param name="applicationParameters">Specifies parameters that are related to applications running on the Protection Source..</param>
        /// <param name="excludedDisks">Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job..</param>
        /// <param name="vmCredentials">vmCredentials.</param>
        public VmwareSpecialParameters(ApplicationParameters applicationParameters = default(ApplicationParameters), List<DiskUnit> excludedDisks = default(List<DiskUnit>), VMCredentials1 vmCredentials = default(VMCredentials1))
        {
            this.ApplicationParameters = applicationParameters;
            this.ExcludedDisks = excludedDisks;
            this.VmCredentials = vmCredentials;
        }
        
        /// <summary>
        /// Specifies parameters that are related to applications running on the Protection Source.
        /// </summary>
        /// <value>Specifies parameters that are related to applications running on the Protection Source.</value>
        [DataMember(Name="applicationParameters", EmitDefaultValue=false)]
        public ApplicationParameters ApplicationParameters { get; set; }

        /// <summary>
        /// Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.
        /// </summary>
        /// <value>Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.</value>
        [DataMember(Name="excludedDisks", EmitDefaultValue=false)]
        public List<DiskUnit> ExcludedDisks { get; set; }

        /// <summary>
        /// Gets or Sets VmCredentials
        /// </summary>
        [DataMember(Name="vmCredentials", EmitDefaultValue=false)]
        public VMCredentials1 VmCredentials { get; set; }

        ///// <summary>
        ///// Returns the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class VmwareSpecialParameters {\n");
        //    sb.Append("  ApplicationParameters: ").Append(ApplicationParameters).Append("\n");
        //    sb.Append("  ExcludedDisks: ").Append(ExcludedDisks).Append("\n");
        //    sb.Append("  VmCredentials: ").Append(VmCredentials).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}
  
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
            return this.Equals(input as VmwareSpecialParameters);
        }

        /// <summary>
        /// Returns true if VmwareSpecialParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareSpecialParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareSpecialParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationParameters == input.ApplicationParameters ||
                    (this.ApplicationParameters != null &&
                    this.ApplicationParameters.Equals(input.ApplicationParameters))
                ) && 
                (
                    this.ExcludedDisks == input.ExcludedDisks ||
                    this.ExcludedDisks != null &&
                    this.ExcludedDisks.SequenceEqual(input.ExcludedDisks)
                ) && 
                (
                    this.VmCredentials == input.VmCredentials ||
                    (this.VmCredentials != null &&
                    this.VmCredentials.Equals(input.VmCredentials))
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
                if (this.ApplicationParameters != null)
                    hashCode = hashCode * 59 + this.ApplicationParameters.GetHashCode();
                if (this.ExcludedDisks != null)
                    hashCode = hashCode * 59 + this.ExcludedDisks.GetHashCode();
                if (this.VmCredentials != null)
                    hashCode = hashCode * 59 + this.VmCredentials.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

