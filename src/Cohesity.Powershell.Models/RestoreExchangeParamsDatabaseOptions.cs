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
    /// RestoreExchangeParamsDatabaseOptions
    /// </summary>
    [DataContract]
    public partial class RestoreExchangeParamsDatabaseOptions :  IEquatable<RestoreExchangeParamsDatabaseOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreExchangeParamsDatabaseOptions" /> class.
        /// </summary>
        /// <param name="entityId">The windows machine to which the database will be restored..</param>
        public RestoreExchangeParamsDatabaseOptions(long? entityId = default(long?))
        {
            this.EntityId = entityId;
        }
        
        /// <summary>
        /// The windows machine to which the database will be restored.
        /// </summary>
        /// <value>The windows machine to which the database will be restored.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public long? EntityId { get; set; }

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
            return this.Equals(input as RestoreExchangeParamsDatabaseOptions);
        }

        /// <summary>
        /// Returns true if RestoreExchangeParamsDatabaseOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreExchangeParamsDatabaseOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreExchangeParamsDatabaseOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                return hashCode;
            }
        }

    }

}

