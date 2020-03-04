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
    /// FeatureUsage
    /// </summary>
    [DataContract]
    public partial class FeatureUsage :  IEquatable<FeatureUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureUsage" /> class.
        /// </summary>
        /// <param name="currentUsage">Feature usage by the cluster..</param>
        /// <param name="featureName">Name of feature..</param>
        /// <param name="numVm">Number of VM spinned..</param>
        public FeatureUsage(long? currentUsage = default(long?), string featureName = default(string), long? numVm = default(long?))
        {
            this.CurrentUsage = currentUsage;
            this.FeatureName = featureName;
            this.NumVm = numVm;
            this.CurrentUsage = currentUsage;
            this.FeatureName = featureName;
            this.NumVm = numVm;
        }
        
        /// <summary>
        /// Feature usage by the cluster.
        /// </summary>
        /// <value>Feature usage by the cluster.</value>
        [DataMember(Name="currentUsage", EmitDefaultValue=true)]
        public long? CurrentUsage { get; set; }

        /// <summary>
        /// Name of feature.
        /// </summary>
        /// <value>Name of feature.</value>
        [DataMember(Name="featureName", EmitDefaultValue=true)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Number of VM spinned.
        /// </summary>
        /// <value>Number of VM spinned.</value>
        [DataMember(Name="numVm", EmitDefaultValue=true)]
        public long? NumVm { get; set; }

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
            return this.Equals(input as FeatureUsage);
        }

        /// <summary>
        /// Returns true if FeatureUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentUsage == input.CurrentUsage ||
                    (this.CurrentUsage != null &&
                    this.CurrentUsage.Equals(input.CurrentUsage))
                ) && 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) && 
                (
                    this.NumVm == input.NumVm ||
                    (this.NumVm != null &&
                    this.NumVm.Equals(input.NumVm))
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
                if (this.CurrentUsage != null)
                    hashCode = hashCode * 59 + this.CurrentUsage.GetHashCode();
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.NumVm != null)
                    hashCode = hashCode * 59 + this.NumVm.GetHashCode();
                return hashCode;
            }
        }

    }

}

