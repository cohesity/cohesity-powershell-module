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
    /// Represents a directed relationship (edge) from a child entity node to its parent node. This defines the structure of the entity DAG.
    /// </summary>
    [DataContract]
    public partial class EntityDAGProtoEntityDAGEdge :  IEquatable<EntityDAGProtoEntityDAGEdge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDAGProtoEntityDAGEdge" /> class.
        /// </summary>
        /// <param name="childEntityId">The integer ID of the child node (source of the edge)..</param>
        /// <param name="parentEntityId">The integer ID of the parent entities (destination of the edge)..</param>
        public EntityDAGProtoEntityDAGEdge(long? childEntityId = default(long?), long? parentEntityId = default(long?))
        {
            this.ChildEntityId = childEntityId;
            this.ParentEntityId = parentEntityId;
            this.ChildEntityId = childEntityId;
            this.ParentEntityId = parentEntityId;
        }
        
        /// <summary>
        /// The integer ID of the child node (source of the edge).
        /// </summary>
        /// <value>The integer ID of the child node (source of the edge).</value>
        [DataMember(Name="childEntityId", EmitDefaultValue=true)]
        public long? ChildEntityId { get; set; }

        /// <summary>
        /// The integer ID of the parent entities (destination of the edge).
        /// </summary>
        /// <value>The integer ID of the parent entities (destination of the edge).</value>
        [DataMember(Name="parentEntityId", EmitDefaultValue=true)]
        public long? ParentEntityId { get; set; }

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
            return this.Equals(input as EntityDAGProtoEntityDAGEdge);
        }

        /// <summary>
        /// Returns true if EntityDAGProtoEntityDAGEdge instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityDAGProtoEntityDAGEdge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityDAGProtoEntityDAGEdge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildEntityId == input.ChildEntityId ||
                    (this.ChildEntityId != null &&
                    this.ChildEntityId.Equals(input.ChildEntityId))
                ) && 
                (
                    this.ParentEntityId == input.ParentEntityId ||
                    (this.ParentEntityId != null &&
                    this.ParentEntityId.Equals(input.ParentEntityId))
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
                if (this.ChildEntityId != null)
                    hashCode = hashCode * 59 + this.ChildEntityId.GetHashCode();
                if (this.ParentEntityId != null)
                    hashCode = hashCode * 59 + this.ParentEntityId.GetHashCode();
                return hashCode;
            }
        }

    }

}

