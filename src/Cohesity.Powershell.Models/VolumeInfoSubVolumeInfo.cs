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
    /// The proto is used only for storing BTRFS subvolume fields. This is required for handling of mountable subvolume.
    /// </summary>
    [DataContract]
    public partial class VolumeInfoSubVolumeInfo :  IEquatable<VolumeInfoSubVolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfoSubVolumeInfo" /> class.
        /// </summary>
        /// <param name="subvolumeName">Name of subvolume. Used to provide relevant mount options..</param>
        public VolumeInfoSubVolumeInfo(string subvolumeName = default(string))
        {
            this.SubvolumeName = subvolumeName;
        }
        
        /// <summary>
        /// Name of subvolume. Used to provide relevant mount options.
        /// </summary>
        /// <value>Name of subvolume. Used to provide relevant mount options.</value>
        [DataMember(Name="subvolumeName", EmitDefaultValue=false)]
        public string SubvolumeName { get; set; }

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
            return this.Equals(input as VolumeInfoSubVolumeInfo);
        }

        /// <summary>
        /// Returns true if VolumeInfoSubVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfoSubVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfoSubVolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubvolumeName == input.SubvolumeName ||
                    (this.SubvolumeName != null &&
                    this.SubvolumeName.Equals(input.SubvolumeName))
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
                if (this.SubvolumeName != null)
                    hashCode = hashCode * 59 + this.SubvolumeName.GetHashCode();
                return hashCode;
            }
        }

    }

}

