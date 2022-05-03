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
    /// PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector :  IEquatable<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector" /> class.
        /// </summary>
        /// <param name="containerName">containerName.</param>
        /// <param name="divisor">divisor.</param>
        /// <param name="resource">resource.</param>
        public PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector(string containerName = default(string), string divisor = default(string), string resource = default(string))
        {
            this.ContainerName = containerName;
            this.Divisor = divisor;
            this.Resource = resource;
        }
        
        /// <summary>
        /// Gets or Sets ContainerName
        /// </summary>
        [DataMember(Name="containerName", EmitDefaultValue=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or Sets Divisor
        /// </summary>
        [DataMember(Name="divisor", EmitDefaultValue=false)]
        public string Divisor { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoDownwardAPIVolumeFileResourceFieldSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerName == input.ContainerName ||
                    (this.ContainerName != null &&
                    this.ContainerName.Equals(input.ContainerName))
                ) && 
                (
                    this.Divisor == input.Divisor ||
                    (this.Divisor != null &&
                    this.Divisor.Equals(input.Divisor))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.ContainerName != null)
                    hashCode = hashCode * 59 + this.ContainerName.GetHashCode();
                if (this.Divisor != null)
                    hashCode = hashCode * 59 + this.Divisor.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }

    }

}

