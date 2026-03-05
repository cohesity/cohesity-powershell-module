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
    /// ObjectStringIdentifier
    /// </summary>
    [DataContract]
    public partial class ObjectStringIdentifier :  IEquatable<ObjectStringIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectStringIdentifier" /> class.
        /// </summary>
        /// <param name="intId">Specifies the unique integer entity id. This is unique across one cluster. Two different Cohesity clusters may have same int_id for two different entities..</param>
        /// <param name="stringIds">stringIds.</param>
        public ObjectStringIdentifier(long? intId = default(long?), StringEntityIds stringIds = default(StringEntityIds))
        {
            this.IntId = intId;
            this.IntId = intId;
            this.StringIds = stringIds;
        }
        
        /// <summary>
        /// Specifies the unique integer entity id. This is unique across one cluster. Two different Cohesity clusters may have same int_id for two different entities.
        /// </summary>
        /// <value>Specifies the unique integer entity id. This is unique across one cluster. Two different Cohesity clusters may have same int_id for two different entities.</value>
        [DataMember(Name="intId", EmitDefaultValue=true)]
        public long? IntId { get; set; }

        /// <summary>
        /// Gets or Sets StringIds
        /// </summary>
        [DataMember(Name="stringIds", EmitDefaultValue=false)]
        public StringEntityIds StringIds { get; set; }

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
            return this.Equals(input as ObjectStringIdentifier);
        }

        /// <summary>
        /// Returns true if ObjectStringIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectStringIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectStringIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntId == input.IntId ||
                    (this.IntId != null &&
                    this.IntId.Equals(input.IntId))
                ) && 
                (
                    this.StringIds == input.StringIds ||
                    (this.StringIds != null &&
                    this.StringIds.Equals(input.StringIds))
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
                if (this.IntId != null)
                    hashCode = hashCode * 59 + this.IntId.GetHashCode();
                if (this.StringIds != null)
                    hashCode = hashCode * 59 + this.StringIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

