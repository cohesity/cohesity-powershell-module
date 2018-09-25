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
    /// Specifies the attributes and the latest statistics about an entity.
    /// </summary>
    [DataContract]
    public partial class EntityProto :  IEquatable<EntityProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityProto" /> class.
        /// </summary>
        /// <param name="attributeVec">List of attributes of an entity..</param>
        /// <param name="entityId">Specifies a globally unique identifier of an entity..</param>
        /// <param name="latestMetricVec">List of the latest statistics for all metrics defined in the schema that this entity belongs to. If statistics for a metric is not available, then that data point is not returned..</param>
        public EntityProto(List<KeyValuePair> attributeVec = default(List<KeyValuePair>), EntityIdentifier entityId = default(EntityIdentifier), List<MetricValue> latestMetricVec = default(List<MetricValue>))
        {
            this.AttributeVec = attributeVec;
            this.EntityId = entityId;
            this.LatestMetricVec = latestMetricVec;
        }
        
        /// <summary>
        /// List of attributes of an entity.
        /// </summary>
        /// <value>List of attributes of an entity.</value>
        [DataMember(Name="attributeVec", EmitDefaultValue=false)]
        public List<KeyValuePair> AttributeVec { get; set; }

        /// <summary>
        /// Specifies a globally unique identifier of an entity.
        /// </summary>
        /// <value>Specifies a globally unique identifier of an entity.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public EntityIdentifier EntityId { get; set; }

        /// <summary>
        /// List of the latest statistics for all metrics defined in the schema that this entity belongs to. If statistics for a metric is not available, then that data point is not returned.
        /// </summary>
        /// <value>List of the latest statistics for all metrics defined in the schema that this entity belongs to. If statistics for a metric is not available, then that data point is not returned.</value>
        [DataMember(Name="latestMetricVec", EmitDefaultValue=false)]
        public List<MetricValue> LatestMetricVec { get; set; }

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
            return this.Equals(input as EntityProto);
        }

        /// <summary>
        /// Returns true if EntityProto instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeVec == input.AttributeVec ||
                    this.AttributeVec != null &&
                    this.AttributeVec.SequenceEqual(input.AttributeVec)
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.LatestMetricVec == input.LatestMetricVec ||
                    this.LatestMetricVec != null &&
                    this.LatestMetricVec.SequenceEqual(input.LatestMetricVec)
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
                if (this.AttributeVec != null)
                    hashCode = hashCode * 59 + this.AttributeVec.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.LatestMetricVec != null)
                    hashCode = hashCode * 59 + this.LatestMetricVec.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

