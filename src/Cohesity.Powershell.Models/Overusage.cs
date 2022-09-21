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
    /// Overusage
    /// </summary>
    [DataContract]
    public partial class Overusage :  IEquatable<Overusage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Overusage" /> class.
        /// </summary>
        /// <param name="featureName">Name of feature..</param>
        /// <param name="overusedGiB">Feature overusage by the cluster..</param>
        /// <param name="overusedVm">Number of overused VM spinned..</param>
        public Overusage(string featureName = default(string), long? overusedGiB = default(long?), long? overusedVm = default(long?))
        {
            this.FeatureName = featureName;
            this.OverusedGiB = overusedGiB;
            this.OverusedVm = overusedVm;
        }
        
        /// <summary>
        /// Name of feature.
        /// </summary>
        /// <value>Name of feature.</value>
        [DataMember(Name="featureName", EmitDefaultValue=true)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Feature overusage by the cluster.
        /// </summary>
        /// <value>Feature overusage by the cluster.</value>
        [DataMember(Name="overusedGiB", EmitDefaultValue=true)]
        public long? OverusedGiB { get; set; }

        /// <summary>
        /// Number of overused VM spinned.
        /// </summary>
        /// <value>Number of overused VM spinned.</value>
        [DataMember(Name="overusedVm", EmitDefaultValue=true)]
        public long? OverusedVm { get; set; }

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
            return this.Equals(input as Overusage);
        }

        /// <summary>
        /// Returns true if Overusage instances are equal
        /// </summary>
        /// <param name="input">Instance of Overusage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Overusage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) && 
                (
                    this.OverusedGiB == input.OverusedGiB ||
                    (this.OverusedGiB != null &&
                    this.OverusedGiB.Equals(input.OverusedGiB))
                ) && 
                (
                    this.OverusedVm == input.OverusedVm ||
                    (this.OverusedVm != null &&
                    this.OverusedVm.Equals(input.OverusedVm))
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
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.OverusedGiB != null)
                    hashCode = hashCode * 59 + this.OverusedGiB.GetHashCode();
                if (this.OverusedVm != null)
                    hashCode = hashCode * 59 + this.OverusedVm.GetHashCode();
                return hashCode;
            }
        }

    }

}

