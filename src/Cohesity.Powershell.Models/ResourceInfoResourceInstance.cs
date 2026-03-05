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
    /// This message defines the information about a resource of the kind mentioned above.
    /// </summary>
    [DataContract]
    public partial class ResourceInfoResourceInstance :  IEquatable<ResourceInfoResourceInstance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInfoResourceInstance" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="entityId">The id of the entity to be backed up or resotred..</param>
        public ResourceInfoResourceInstance(Entity entity = default(Entity), long? entityId = default(long?))
        {
            this.EntityId = entityId;
            this.Entity = entity;
            this.EntityId = entityId;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }

        /// <summary>
        /// The id of the entity to be backed up or resotred.
        /// </summary>
        /// <value>The id of the entity to be backed up or resotred.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
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
            return this.Equals(input as ResourceInfoResourceInstance);
        }

        /// <summary>
        /// Returns true if ResourceInfoResourceInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceInfoResourceInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceInfoResourceInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                return hashCode;
            }
        }

    }

}

