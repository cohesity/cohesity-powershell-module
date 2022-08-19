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
    /// Specifies the restore statistics details.
    /// </summary>
    [DataContract]
    public partial class RestoreStats :  IEquatable<RestoreStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreStats" /> class.
        /// </summary>
        /// <param name="numClonedObjects">Specifies the count of cloned objects in the given time frame..</param>
        /// <param name="numRecoveredObjects">Specifies the count of recovered objects in the given time frame..</param>
        /// <param name="statsByEnvironment">Specifies the stats of recovery jobs aggregated by the environment type..</param>
        public RestoreStats(long? numClonedObjects = default(long?), long? numRecoveredObjects = default(long?), List<RestoreEnvStats> statsByEnvironment = default(List<RestoreEnvStats>))
        {
            this.NumClonedObjects = numClonedObjects;
            this.NumRecoveredObjects = numRecoveredObjects;
            this.StatsByEnvironment = statsByEnvironment;
        }
        
        /// <summary>
        /// Specifies the count of cloned objects in the given time frame.
        /// </summary>
        /// <value>Specifies the count of cloned objects in the given time frame.</value>
        [DataMember(Name="numClonedObjects", EmitDefaultValue=true)]
        public long? NumClonedObjects { get; set; }

        /// <summary>
        /// Specifies the count of recovered objects in the given time frame.
        /// </summary>
        /// <value>Specifies the count of recovered objects in the given time frame.</value>
        [DataMember(Name="numRecoveredObjects", EmitDefaultValue=true)]
        public long? NumRecoveredObjects { get; set; }

        /// <summary>
        /// Specifies the stats of recovery jobs aggregated by the environment type.
        /// </summary>
        /// <value>Specifies the stats of recovery jobs aggregated by the environment type.</value>
        [DataMember(Name="statsByEnvironment", EmitDefaultValue=false)]
        public List<RestoreEnvStats> StatsByEnvironment { get; set; }

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
            return this.Equals(input as RestoreStats);
        }

        /// <summary>
        /// Returns true if RestoreStats instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumClonedObjects == input.NumClonedObjects ||
                    (this.NumClonedObjects != null &&
                    this.NumClonedObjects.Equals(input.NumClonedObjects))
                ) && 
                (
                    this.NumRecoveredObjects == input.NumRecoveredObjects ||
                    (this.NumRecoveredObjects != null &&
                    this.NumRecoveredObjects.Equals(input.NumRecoveredObjects))
                ) && 
                (
                    this.StatsByEnvironment == input.StatsByEnvironment ||
                    this.StatsByEnvironment != null &&
                    input.StatsByEnvironment != null &&
                    this.StatsByEnvironment.Equals(input.StatsByEnvironment)
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
                if (this.NumClonedObjects != null)
                    hashCode = hashCode * 59 + this.NumClonedObjects.GetHashCode();
                if (this.NumRecoveredObjects != null)
                    hashCode = hashCode * 59 + this.NumRecoveredObjects.GetHashCode();
                if (this.StatsByEnvironment != null)
                    hashCode = hashCode * 59 + this.StatsByEnvironment.GetHashCode();
                return hashCode;
            }
        }

    }

}

