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
    /// RestoreStandbyTaskStateProto
    /// </summary>
    [DataContract]
    public partial class RestoreStandbyTaskStateProto :  IEquatable<RestoreStandbyTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreStandbyTaskStateProto" /> class.
        /// </summary>
        /// <param name="standbyRestoreComplete">This indicates if standby restore task to update standby resource state is completed or not..</param>
        public RestoreStandbyTaskStateProto(bool? standbyRestoreComplete = default(bool?))
        {
            this.StandbyRestoreComplete = standbyRestoreComplete;
        }
        
        /// <summary>
        /// This indicates if standby restore task to update standby resource state is completed or not.
        /// </summary>
        /// <value>This indicates if standby restore task to update standby resource state is completed or not.</value>
        [DataMember(Name="standbyRestoreComplete", EmitDefaultValue=false)]
        public bool? StandbyRestoreComplete { get; set; }

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
            return this.Equals(input as RestoreStandbyTaskStateProto);
        }

        /// <summary>
        /// Returns true if RestoreStandbyTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreStandbyTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreStandbyTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StandbyRestoreComplete == input.StandbyRestoreComplete ||
                    (this.StandbyRestoreComplete != null &&
                    this.StandbyRestoreComplete.Equals(input.StandbyRestoreComplete))
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
                if (this.StandbyRestoreComplete != null)
                    hashCode = hashCode * 59 + this.StandbyRestoreComplete.GetHashCode();
                return hashCode;
            }
        }

    }

}

