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
    /// GCPNativeObjectParams
    /// </summary>
    [DataContract]
    public partial class GCPNativeObjectParams :  IEquatable<GCPNativeObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPNativeObjectParams" /> class.
        /// </summary>
        /// <param name="diskExclusionParams">diskExclusionParams.</param>
        public GCPNativeObjectParams(GCPDiskExclusionObjectParams diskExclusionParams = default(GCPDiskExclusionObjectParams))
        {
            this.DiskExclusionParams = diskExclusionParams;
        }
        
        /// <summary>
        /// Gets or Sets DiskExclusionParams
        /// </summary>
        [DataMember(Name="diskExclusionParams", EmitDefaultValue=false)]
        public GCPDiskExclusionObjectParams DiskExclusionParams { get; set; }

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
            return this.Equals(input as GCPNativeObjectParams);
        }

        /// <summary>
        /// Returns true if GCPNativeObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPNativeObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPNativeObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskExclusionParams == input.DiskExclusionParams ||
                    (this.DiskExclusionParams != null &&
                    this.DiskExclusionParams.Equals(input.DiskExclusionParams))
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
                if (this.DiskExclusionParams != null)
                    hashCode = hashCode * 59 + this.DiskExclusionParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

