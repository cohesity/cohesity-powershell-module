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
    /// RestoreM365CSMParams
    /// </summary>
    [DataContract]
    public partial class RestoreM365CSMParams :  IEquatable<RestoreM365CSMParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreM365CSMParams" /> class.
        /// </summary>
        /// <param name="destinationType">Destination type for the recovery..</param>
        public RestoreM365CSMParams(int? destinationType = default(int?))
        {
            this.DestinationType = destinationType;
            this.DestinationType = destinationType;
        }
        
        /// <summary>
        /// Destination type for the recovery.
        /// </summary>
        /// <value>Destination type for the recovery.</value>
        [DataMember(Name="destinationType", EmitDefaultValue=true)]
        public int? DestinationType { get; set; }

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
            return this.Equals(input as RestoreM365CSMParams);
        }

        /// <summary>
        /// Returns true if RestoreM365CSMParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreM365CSMParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreM365CSMParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
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
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                return hashCode;
            }
        }

    }

}

