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
    /// PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector :  IEquatable<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector" /> class.
        /// </summary>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="fieldPath">fieldPath.</param>
        public PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector(string apiVersion = default(string), string fieldPath = default(string))
        {
            this.ApiVersion = apiVersion;
            this.FieldPath = fieldPath;
        }
        
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets FieldPath
        /// </summary>
        [DataMember(Name="fieldPath", EmitDefaultValue=false)]
        public string FieldPath { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileObjectFieldSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.FieldPath == input.FieldPath ||
                    (this.FieldPath != null &&
                    this.FieldPath.Equals(input.FieldPath))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.FieldPath != null)
                    hashCode = hashCode * 59 + this.FieldPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

