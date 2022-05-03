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
    /// DownwardAPIVolumeSource represents a volume containing downward API info.
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoDownwardAPI :  IEquatable<PodInfoPodSpecVolumeInfoDownwardAPI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoDownwardAPI" /> class.
        /// </summary>
        /// <param name="defaultMode">defaultMode.</param>
        /// <param name="items">items.</param>
        public PodInfoPodSpecVolumeInfoDownwardAPI(int? defaultMode = default(int?), List<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile> items = default(List<PodInfoPodSpecVolumeInfoDownwardAPIVolumeFile>))
        {
            this.DefaultMode = defaultMode;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets DefaultMode
        /// </summary>
        [DataMember(Name="defaultMode", EmitDefaultValue=false)]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
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
            return this.Equals(input as PodInfoPodSpecVolumeInfoDownwardAPI);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoDownwardAPI instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoDownwardAPI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoDownwardAPI input)
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
                    this.Items == input.Items ||
                    this.Items != null &&
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
                if (this.DefaultMode != null)
                    hashCode = hashCode * 59 + this.DefaultMode.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

    }

}

