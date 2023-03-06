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
    /// Flocker volumes
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfoFlocker :  IEquatable<PodInfoPodSpecVolumeInfoFlocker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfoFlocker" /> class.
        /// </summary>
        /// <param name="datasetName">datasetName.</param>
        public PodInfoPodSpecVolumeInfoFlocker(string datasetName = default(string))
        {
            this.DatasetName = datasetName;
            this.DatasetName = datasetName;
        }
        
        /// <summary>
        /// Gets or Sets DatasetName
        /// </summary>
        [DataMember(Name="datasetName", EmitDefaultValue=true)]
        public string DatasetName { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfoFlocker);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfoFlocker instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfoFlocker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfoFlocker input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatasetName == input.DatasetName ||
                    (this.DatasetName != null &&
                    this.DatasetName.Equals(input.DatasetName))
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
                if (this.DatasetName != null)
                    hashCode = hashCode * 59 + this.DatasetName.GetHashCode();
                return hashCode;
            }
        }

    }

}

