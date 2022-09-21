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
    /// PodInfoPodSpecVolumeInfoProjected
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoProjected :  IEquatable<PodInfoPodSpecVolumeInfoProjected>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoProjected" /> class.
        /// </summary>
        /// <param name="defaultMode">defaultMode.</param>
        /// <param name="sources">sources.</param>
        public PodInfoPodSpecVolumeInfoProjected(int? defaultMode = default(int?), List<PodInfoPodSpecVolumeInfoProjectedVolumeProjection> sources = default(List<PodInfoPodSpecVolumeInfoProjectedVolumeProjection>))
        {
            this.DefaultMode = defaultMode;
            this.Sources = sources;
            this.DefaultMode = defaultMode;
            this.Sources = sources;
        }
        
        /// <summary>
        /// Gets or Sets DefaultMode
        /// </summary>
        [DataMember(Name="defaultMode", EmitDefaultValue=true)]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name="sources", EmitDefaultValue=true)]
        public List<PodInfoPodSpecVolumeInfoProjectedVolumeProjection> Sources { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoProjected);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoProjected instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoProjected to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoProjected input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultMode == input.DefaultMode ||
                    (this.DefaultMode != null &&
                    this.DefaultMode.Equals(input.DefaultMode))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.Equals(input.Sources)
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
                if (this.DefaultMode != null)
                    hashCode = hashCode * 59 + this.DefaultMode.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                return hashCode;
            }
        }

    }

}

