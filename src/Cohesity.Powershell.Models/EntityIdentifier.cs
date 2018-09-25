// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a unique identifier for the entity.
    /// </summary>
    [DataContract]
    public partial class EntityIdentifier :  IEquatable<EntityIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifier" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the unique identifier for the entity in the source Cluster..</param>
        public EntityIdentifier(Value entityId = default(Value))
        {
            this.EntityId = entityId;
        }
        
        /// <summary>
        /// Specifies the unique identifier for the entity in the source Cluster.
        /// </summary>
        /// <value>Specifies the unique identifier for the entity in the source Cluster.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public Value EntityId { get; set; }

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
            return this.Equals(input as EntityIdentifier);
        }

        /// <summary>
        /// Returns true if EntityIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityIdentifier input)
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

