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
    /// PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection :  IEquatable<PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="name">name.</param>
        /// <param name="optional">optional.</param>
        public PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection(List<PodInfoPodSpecVolumeInfoKeyToPath> items = default(List<PodInfoPodSpecVolumeInfoKeyToPath>), string name = default(string), bool? optional = default(bool?))
        {
            this.Items = items;
            this.Name = name;
            this.Optional = optional;
            this.Items = items;
            this.Name = name;
            this.Optional = optional;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<PodInfoPodSpecVolumeInfoKeyToPath> Items { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name="optional", EmitDefaultValue=true)]
        public bool? Optional { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoProjectedVolumeProjectionConfigMapProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                return hashCode;
            }
        }

    }

}

