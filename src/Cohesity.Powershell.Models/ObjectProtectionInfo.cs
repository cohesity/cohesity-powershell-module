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
    /// ObjectProtectionInfo
    /// </summary>
    [DataContract]
    public partial class ObjectProtectionInfo :  IEquatable<ObjectProtectionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectProtectionInfo" /> class.
        /// </summary>
        /// <param name="autoProtectParentId">Specifies the auto protect parent id if this entity is protected based on auto protection. This is only specified for leaf entities..</param>
        /// <param name="entityId">Specifies the entity id..</param>
        /// <param name="hasActiveObjectProtectionSpec">Specifies if the entity is under object protection.</param>
        public ObjectProtectionInfo(long? autoProtectParentId = default(long?), long? entityId = default(long?), bool? hasActiveObjectProtectionSpec = default(bool?))
        {
            this.AutoProtectParentId = autoProtectParentId;
            this.EntityId = entityId;
            this.HasActiveObjectProtectionSpec = hasActiveObjectProtectionSpec;
            this.AutoProtectParentId = autoProtectParentId;
            this.EntityId = entityId;
            this.HasActiveObjectProtectionSpec = hasActiveObjectProtectionSpec;
        }
        
        /// <summary>
        /// Specifies the auto protect parent id if this entity is protected based on auto protection. This is only specified for leaf entities.
        /// </summary>
        /// <value>Specifies the auto protect parent id if this entity is protected based on auto protection. This is only specified for leaf entities.</value>
        [DataMember(Name="autoProtectParentId", EmitDefaultValue=true)]
        public long? AutoProtectParentId { get; set; }

        /// <summary>
        /// Specifies the entity id.
        /// </summary>
        /// <value>Specifies the entity id.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies if the entity is under object protection
        /// </summary>
        /// <value>Specifies if the entity is under object protection</value>
        [DataMember(Name="hasActiveObjectProtectionSpec", EmitDefaultValue=true)]
        public bool? HasActiveObjectProtectionSpec { get; set; }

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
            return this.Equals(input as ObjectProtectionInfo);
        }

        /// <summary>
        /// Returns true if ObjectProtectionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectProtectionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectProtectionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoProtectParentId == input.AutoProtectParentId ||
                    (this.AutoProtectParentId != null &&
                    this.AutoProtectParentId.Equals(input.AutoProtectParentId))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.HasActiveObjectProtectionSpec == input.HasActiveObjectProtectionSpec ||
                    (this.HasActiveObjectProtectionSpec != null &&
                    this.HasActiveObjectProtectionSpec.Equals(input.HasActiveObjectProtectionSpec))
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
                if (this.AutoProtectParentId != null)
                    hashCode = hashCode * 59 + this.AutoProtectParentId.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.HasActiveObjectProtectionSpec != null)
                    hashCode = hashCode * 59 + this.HasActiveObjectProtectionSpec.GetHashCode();
                return hashCode;
            }
        }

    }

}

