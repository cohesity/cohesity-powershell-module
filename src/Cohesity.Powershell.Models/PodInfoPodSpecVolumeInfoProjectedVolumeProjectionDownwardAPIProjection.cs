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
    /// PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection :  IEquatable<PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection(List<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile> items = default(List<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile>))
        {
            this.Items = items;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile> Items { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionDownwardAPIProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.Equals(input.Items)
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

    }

}

