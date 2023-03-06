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
    /// DestroyClonedEntityInfoProtoClonedEntity
    /// </summary>
    [DataContract]
    public partial class DestroyClonedEntityInfoProtoClonedEntity :  IEquatable<DestroyClonedEntityInfoProtoClonedEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyClonedEntityInfoProtoClonedEntity" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="relativeRestorePathVec">Path of all files created by the clone operation. Each path is relative to the clone view..</param>
        public DestroyClonedEntityInfoProtoClonedEntity(EntityProto entity = default(EntityProto), List<string> relativeRestorePathVec = default(List<string>))
        {
            this.RelativeRestorePathVec = relativeRestorePathVec;
            this.Entity = entity;
            this.RelativeRestorePathVec = relativeRestorePathVec;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// Path of all files created by the clone operation. Each path is relative to the clone view.
        /// </summary>
        /// <value>Path of all files created by the clone operation. Each path is relative to the clone view.</value>
        [DataMember(Name="relativeRestorePathVec", EmitDefaultValue=true)]
        public List<string> RelativeRestorePathVec { get; set; }

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
            return this.Equals(input as DestroyClonedEntityInfoProtoClonedEntity);
        }

        /// <summary>
        /// Returns true if DestroyClonedEntityInfoProtoClonedEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyClonedEntityInfoProtoClonedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyClonedEntityInfoProtoClonedEntity input)
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
                    this.RelativeRestorePathVec == input.RelativeRestorePathVec ||
                    this.RelativeRestorePathVec != null &&
                    input.RelativeRestorePathVec != null &&
                    this.RelativeRestorePathVec.SequenceEqual(input.RelativeRestorePathVec)
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
                if (this.RelativeRestorePathVec != null)
                    hashCode = hashCode * 59 + this.RelativeRestorePathVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

