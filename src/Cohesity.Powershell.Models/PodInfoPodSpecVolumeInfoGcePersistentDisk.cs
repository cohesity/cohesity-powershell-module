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
    /// PodInfoPodSpecVolumeInfoGcePersistentDisk
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoGcePersistentDisk :  IEquatable<PodInfoPodSpecVolumeInfoGcePersistentDisk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoGcePersistentDisk" /> class.
        /// </summary>
        /// <param name="fsType">fsType.</param>
        /// <param name="pdName">pdName.</param>
        public PodInfoPodSpecVolumeInfoGcePersistentDisk(string fsType = default(string), string pdName = default(string))
        {
            this.FsType = fsType;
            this.PdName = pdName;
            this.FsType = fsType;
            this.PdName = pdName;
        }
        
        /// <summary>
        /// Gets or Sets FsType
        /// </summary>
        [DataMember(Name="fsType", EmitDefaultValue=true)]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or Sets PdName
        /// </summary>
        [DataMember(Name="pdName", EmitDefaultValue=true)]
        public string PdName { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoGcePersistentDisk);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoGcePersistentDisk instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoGcePersistentDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoGcePersistentDisk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FsType == input.FsType ||
                    (this.FsType != null &&
                    this.FsType.Equals(input.FsType))
                ) && 
                (
                    this.PdName == input.PdName ||
                    (this.PdName != null &&
                    this.PdName.Equals(input.PdName))
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
                if (this.FsType != null)
                    hashCode = hashCode * 59 + this.FsType.GetHashCode();
                if (this.PdName != null)
                    hashCode = hashCode * 59 + this.PdName.GetHashCode();
                return hashCode;
            }
        }

    }

}

