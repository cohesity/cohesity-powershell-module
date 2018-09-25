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
    /// Specifies information about a logical volume found a VM.
    /// </summary>
    [DataContract]
    public partial class VmVolumesInformation :  IEquatable<VmVolumesInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmVolumesInformation" /> class.
        /// </summary>
        /// <param name="filesystemVolumes">Specifies information about the filesystem volumes found in a logical volume..</param>
        public VmVolumesInformation(List<FilesystemVolume> filesystemVolumes = default(List<FilesystemVolume>))
        {
            this.FilesystemVolumes = filesystemVolumes;
        }
        
        /// <summary>
        /// Specifies information about the filesystem volumes found in a logical volume.
        /// </summary>
        /// <value>Specifies information about the filesystem volumes found in a logical volume.</value>
        [DataMember(Name="filesystemVolumes", EmitDefaultValue=false)]
        public List<FilesystemVolume> FilesystemVolumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as VmVolumesInformation);
        }

        /// <summary>
        /// Returns true if VmVolumesInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of VmVolumesInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmVolumesInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilesystemVolumes == input.FilesystemVolumes ||
                    this.FilesystemVolumes != null &&
                    this.FilesystemVolumes.SequenceEqual(input.FilesystemVolumes)
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
                if (this.FilesystemVolumes != null)
                    hashCode = hashCode * 59 + this.FilesystemVolumes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

