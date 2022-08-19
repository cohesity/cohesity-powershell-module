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
    /// Represents the details about the status of restore of the AD objects. It also has details about the number of objects whose restore is successfull, failure or in progress.
    /// </summary>
    [DataContract]
    public partial class AdObjectsRestoreStatus :  IEquatable<AdObjectsRestoreStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdObjectsRestoreStatus" /> class.
        /// </summary>
        /// <param name="adObjectsRestoreInfo">Specifies the status of all the AD Objects which were requested to be restored..</param>
        /// <param name="numObjectsFailed">Specifies the number of AD Objects whose restore has failed..</param>
        /// <param name="numObjectsRunning">Specifies the number of AD Objects whose restore is in progress..</param>
        /// <param name="numObjectsSucceeded">Specifies the number of AD Objects whose restore is successfull..</param>
        public AdObjectsRestoreStatus(List<AdObjectRestoreInformation> adObjectsRestoreInfo = default(List<AdObjectRestoreInformation>), int? numObjectsFailed = default(int?), int? numObjectsRunning = default(int?), int? numObjectsSucceeded = default(int?))
        {
            this.AdObjectsRestoreInfo = adObjectsRestoreInfo;
            this.NumObjectsFailed = numObjectsFailed;
            this.NumObjectsRunning = numObjectsRunning;
            this.NumObjectsSucceeded = numObjectsSucceeded;
        }
        
        /// <summary>
        /// Specifies the status of all the AD Objects which were requested to be restored.
        /// </summary>
        /// <value>Specifies the status of all the AD Objects which were requested to be restored.</value>
        [DataMember(Name="adObjectsRestoreInfo", EmitDefaultValue=true)]
        public List<AdObjectRestoreInformation> AdObjectsRestoreInfo { get; set; }

        /// <summary>
        /// Specifies the number of AD Objects whose restore has failed.
        /// </summary>
        /// <value>Specifies the number of AD Objects whose restore has failed.</value>
        [DataMember(Name="numObjectsFailed", EmitDefaultValue=true)]
        public int? NumObjectsFailed { get; set; }

        /// <summary>
        /// Specifies the number of AD Objects whose restore is in progress.
        /// </summary>
        /// <value>Specifies the number of AD Objects whose restore is in progress.</value>
        [DataMember(Name="numObjectsRunning", EmitDefaultValue=true)]
        public int? NumObjectsRunning { get; set; }

        /// <summary>
        /// Specifies the number of AD Objects whose restore is successfull.
        /// </summary>
        /// <value>Specifies the number of AD Objects whose restore is successfull.</value>
        [DataMember(Name="numObjectsSucceeded", EmitDefaultValue=true)]
        public int? NumObjectsSucceeded { get; set; }

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
            return this.Equals(input as AdObjectsRestoreStatus);
        }

        /// <summary>
        /// Returns true if AdObjectsRestoreStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AdObjectsRestoreStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdObjectsRestoreStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdObjectsRestoreInfo == input.AdObjectsRestoreInfo ||
                    this.AdObjectsRestoreInfo != null &&
                    input.AdObjectsRestoreInfo != null &&
                    this.AdObjectsRestoreInfo.Equals(input.AdObjectsRestoreInfo)
                ) && 
                (
                    this.NumObjectsFailed == input.NumObjectsFailed ||
                    (this.NumObjectsFailed != null &&
                    this.NumObjectsFailed.Equals(input.NumObjectsFailed))
                ) && 
                (
                    this.NumObjectsRunning == input.NumObjectsRunning ||
                    (this.NumObjectsRunning != null &&
                    this.NumObjectsRunning.Equals(input.NumObjectsRunning))
                ) && 
                (
                    this.NumObjectsSucceeded == input.NumObjectsSucceeded ||
                    (this.NumObjectsSucceeded != null &&
                    this.NumObjectsSucceeded.Equals(input.NumObjectsSucceeded))
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
                if (this.AdObjectsRestoreInfo != null)
                    hashCode = hashCode * 59 + this.AdObjectsRestoreInfo.GetHashCode();
                if (this.NumObjectsFailed != null)
                    hashCode = hashCode * 59 + this.NumObjectsFailed.GetHashCode();
                if (this.NumObjectsRunning != null)
                    hashCode = hashCode * 59 + this.NumObjectsRunning.GetHashCode();
                if (this.NumObjectsSucceeded != null)
                    hashCode = hashCode * 59 + this.NumObjectsSucceeded.GetHashCode();
                return hashCode;
            }
        }

    }

}

