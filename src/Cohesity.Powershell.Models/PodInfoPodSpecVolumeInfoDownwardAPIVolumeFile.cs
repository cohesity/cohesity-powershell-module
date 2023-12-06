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
    /// DownwardAPIVolumeFile represents information to create the file containing the pod field.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile :  IEquatable<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile" /> class.
        /// </summary>
        /// <param name="fieldRef">fieldRef.</param>
        /// <param name="mode">mode.</param>
        /// <param name="path">path.</param>
        /// <param name="resourceFieldRef">resourceFieldRef.</param>
        public PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector fieldRef = default(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector), int? mode = default(int?), string path = default(string), PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector resourceFieldRef = default(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector))
        {
            this.Mode = mode;
            this.Path = path;
            this.FieldRef = fieldRef;
            this.Mode = mode;
            this.Path = path;
            this.ResourceFieldRef = resourceFieldRef;
        }
        
        /// <summary>
        /// Gets or Sets FieldRef
        /// </summary>
        [DataMember(Name="fieldRef", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector FieldRef { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public int? Mode { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets ResourceFieldRef
        /// </summary>
        [DataMember(Name="resourceFieldRef", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector ResourceFieldRef { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldRef == input.FieldRef ||
                    (this.FieldRef != null &&
                    this.FieldRef.Equals(input.FieldRef))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ResourceFieldRef == input.ResourceFieldRef ||
                    (this.ResourceFieldRef != null &&
                    this.ResourceFieldRef.Equals(input.ResourceFieldRef))
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
                if (this.FieldRef != null)
                    hashCode = hashCode * 59 + this.FieldRef.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ResourceFieldRef != null)
                    hashCode = hashCode * 59 + this.ResourceFieldRef.GetHashCode();
                return hashCode;
            }
        }

    }

}

