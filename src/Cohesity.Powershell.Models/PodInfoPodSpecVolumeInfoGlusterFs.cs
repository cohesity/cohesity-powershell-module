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
    /// Volume provided by Gluster file system
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoGlusterFs :  IEquatable<PodInfoPodSpecVolumeInfoGlusterFs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoGlusterFs" /> class.
        /// </summary>
        /// <param name="endpoints">endpoints.</param>
        /// <param name="path">path.</param>
        public PodInfoPodSpecVolumeInfoGlusterFs(string endpoints = default(string), string path = default(string))
        {
            this.Endpoints = endpoints;
            this.Path = path;
            this.Endpoints = endpoints;
            this.Path = path;
        }
        
        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [DataMember(Name="endpoints", EmitDefaultValue=true)]
        public string Endpoints { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoGlusterFs);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoGlusterFs instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoGlusterFs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoGlusterFs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoints == input.Endpoints ||
                    (this.Endpoints != null &&
                    this.Endpoints.Equals(input.Endpoints))
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
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}

