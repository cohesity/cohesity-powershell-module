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
    /// PodInfoPodSpecVolumeInfoHostPath
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoHostPath :  IEquatable<PodInfoPodSpecVolumeInfoHostPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoHostPath" /> class.
        /// </summary>
        /// <param name="path">Path of volume on the node on which pod is running..</param>
        public PodInfoPodSpecVolumeInfoHostPath(string path = default(string))
        {
            this.Path = path;
            this.Path = path;
        }
        
        /// <summary>
        /// Path of volume on the node on which pod is running.
        /// </summary>
        /// <value>Path of volume on the node on which pod is running.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoHostPath);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoHostPath instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoHostPath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoHostPath input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

