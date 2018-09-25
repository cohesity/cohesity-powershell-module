// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies job parameters applicable for all &#39;kHyperV&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class HypervEnvJobParameters :  IEquatable<HypervEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HypervEnvJobParameters" /> class.
        /// </summary>
        /// <param name="fallbackToCrashConsistent">If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed. By default, this field is set to false..</param>
        public HypervEnvJobParameters(bool? fallbackToCrashConsistent = default(bool?))
        {
            this.FallbackToCrashConsistent = fallbackToCrashConsistent;
        }
        
        /// <summary>
        /// If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed. By default, this field is set to false.
        /// </summary>
        /// <value>If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed. By default, this field is set to false.</value>
        [DataMember(Name="fallbackToCrashConsistent", EmitDefaultValue=false)]
        public bool? FallbackToCrashConsistent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as HypervEnvJobParameters);
        }

        /// <summary>
        /// Returns true if HypervEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of HypervEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypervEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FallbackToCrashConsistent == input.FallbackToCrashConsistent ||
                    (this.FallbackToCrashConsistent != null &&
                    this.FallbackToCrashConsistent.Equals(input.FallbackToCrashConsistent))
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
                if (this.FallbackToCrashConsistent != null)
                    hashCode = hashCode * 59 + this.FallbackToCrashConsistent.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

