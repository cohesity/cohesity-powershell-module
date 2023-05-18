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
    /// Message defining the different criteria to exclude GCP disks from object-level backup. All the disk name present here will be excluded.
    /// </summary>
    [DataContract]
    public partial class GCPDiskExclusionObjectParams :  IEquatable<GCPDiskExclusionObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPDiskExclusionObjectParams" /> class.
        /// </summary>
        /// <param name="diskNameVec">List of disk name to exclude. Eg - [instance1-disk, instance2-disk].</param>
        public GCPDiskExclusionObjectParams(List<string> diskNameVec = default(List<string>))
        {
            this.DiskNameVec = diskNameVec;
            this.DiskNameVec = diskNameVec;
        }
        
        /// <summary>
        /// List of disk name to exclude. Eg - [instance1-disk, instance2-disk]
        /// </summary>
        /// <value>List of disk name to exclude. Eg - [instance1-disk, instance2-disk]</value>
        [DataMember(Name="diskNameVec", EmitDefaultValue=true)]
        public List<string> DiskNameVec { get; set; }

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
            return this.Equals(input as GCPDiskExclusionObjectParams);
        }

        /// <summary>
        /// Returns true if GCPDiskExclusionObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPDiskExclusionObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPDiskExclusionObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskNameVec == input.DiskNameVec ||
                    this.DiskNameVec != null &&
                    input.DiskNameVec != null &&
                    this.DiskNameVec.SequenceEqual(input.DiskNameVec)
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
                if (this.DiskNameVec != null)
                    hashCode = hashCode * 59 + this.DiskNameVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

