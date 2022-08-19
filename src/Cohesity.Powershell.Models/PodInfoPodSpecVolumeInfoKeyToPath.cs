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
    /// PodInfoPodSpecVolumeInfoKeyToPath
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoKeyToPath :  IEquatable<PodInfoPodSpecVolumeInfoKeyToPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoKeyToPath" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="mode">mode.</param>
        /// <param name="path">path.</param>
        public PodInfoPodSpecVolumeInfoKeyToPath(string key = default(string), int? mode = default(int?), string path = default(string))
        {
            this.Key = key;
            this.Mode = mode;
            this.Path = path;
            this.Key = key;
            this.Mode = mode;
            this.Path = path;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoKeyToPath);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoKeyToPath instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoKeyToPath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoKeyToPath input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

