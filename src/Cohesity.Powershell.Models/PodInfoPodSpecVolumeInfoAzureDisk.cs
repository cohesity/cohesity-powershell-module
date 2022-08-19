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
    /// PodInfoPodSpecVolumeInfoAzureDisk
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoAzureDisk :  IEquatable<PodInfoPodSpecVolumeInfoAzureDisk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoAzureDisk" /> class.
        /// </summary>
        /// <param name="diskName">diskName.</param>
        /// <param name="diskUri">diskUri.</param>
        public PodInfoPodSpecVolumeInfoAzureDisk(string diskName = default(string), string diskUri = default(string))
        {
            this.DiskName = diskName;
            this.DiskUri = diskUri;
            this.DiskName = diskName;
            this.DiskUri = diskUri;
        }
        
        /// <summary>
        /// Gets or Sets DiskName
        /// </summary>
        [DataMember(Name="diskName", EmitDefaultValue=true)]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or Sets DiskUri
        /// </summary>
        [DataMember(Name="diskUri", EmitDefaultValue=true)]
        public string DiskUri { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoAzureDisk);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoAzureDisk instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoAzureDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoAzureDisk input)
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
                    this.DiskUri == input.DiskUri ||
                    (this.DiskUri != null &&
                    this.DiskUri.Equals(input.DiskUri))
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
                if (this.DiskUri != null)
                    hashCode = hashCode * 59 + this.DiskUri.GetHashCode();
                return hashCode;
            }
        }

    }

}

