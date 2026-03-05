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
    /// Data handling related to Experimental Adapter protection source used in public APIs. This should be kept in sync with Entity in adapter GenericEntityProto for adapters.
    /// </summary>
    [DataContract]
    public partial class ExperimentalAdapterProtectionSource :  IEquatable<ExperimentalAdapterProtectionSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalAdapterProtectionSource" /> class.
        /// </summary>
        /// <param name="displayName">Specifies the UUID for the Experimental Adapter entity..</param>
        /// <param name="entityType">Specifies the type of the managed Object in Experimental Adapter Protection Source..</param>
        /// <param name="entityTypeId">Specifies the entity id..</param>
        /// <param name="fullName">Specifies the instance name of the Experimental Adapter entity..</param>
        /// <param name="isLeafEntity">Set to true if this is a leaf entity type..</param>
        /// <param name="isTaskableEntity">Set to true if this is a taskable entity..</param>
        /// <param name="isTopLevelEntity">Set to true if this is a top level entity..</param>
        /// <param name="parentIds">Adapter assigned entity identifier protos for the list of parent entities..</param>
        public ExperimentalAdapterProtectionSource(string displayName = default(string), string entityType = default(string), int? entityTypeId = default(int?), string fullName = default(string), bool? isLeafEntity = default(bool?), bool? isTaskableEntity = default(bool?), bool? isTopLevelEntity = default(bool?), List<ExperimentalAdapterEntityIdentifier> parentIds = default(List<ExperimentalAdapterEntityIdentifier>))
        {
            this.DisplayName = displayName;
            this.EntityType = entityType;
            this.EntityTypeId = entityTypeId;
            this.FullName = fullName;
            this.IsLeafEntity = isLeafEntity;
            this.IsTaskableEntity = isTaskableEntity;
            this.IsTopLevelEntity = isTopLevelEntity;
            this.ParentIds = parentIds;
            this.DisplayName = displayName;
            this.EntityType = entityType;
            this.EntityTypeId = entityTypeId;
            this.FullName = fullName;
            this.IsLeafEntity = isLeafEntity;
            this.IsTaskableEntity = isTaskableEntity;
            this.IsTopLevelEntity = isTopLevelEntity;
            this.ParentIds = parentIds;
        }
        
        /// <summary>
        /// Specifies the UUID for the Experimental Adapter entity.
        /// </summary>
        /// <value>Specifies the UUID for the Experimental Adapter entity.</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Specifies the type of the managed Object in Experimental Adapter Protection Source.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Experimental Adapter Protection Source.</value>
        [DataMember(Name="entityType", EmitDefaultValue=true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Specifies the entity id.
        /// </summary>
        /// <value>Specifies the entity id.</value>
        [DataMember(Name="entityTypeId", EmitDefaultValue=true)]
        public int? EntityTypeId { get; set; }

        /// <summary>
        /// Specifies the instance name of the Experimental Adapter entity.
        /// </summary>
        /// <value>Specifies the instance name of the Experimental Adapter entity.</value>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }

        /// <summary>
        /// Set to true if this is a leaf entity type.
        /// </summary>
        /// <value>Set to true if this is a leaf entity type.</value>
        [DataMember(Name="isLeafEntity", EmitDefaultValue=true)]
        public bool? IsLeafEntity { get; set; }

        /// <summary>
        /// Set to true if this is a taskable entity.
        /// </summary>
        /// <value>Set to true if this is a taskable entity.</value>
        [DataMember(Name="isTaskableEntity", EmitDefaultValue=true)]
        public bool? IsTaskableEntity { get; set; }

        /// <summary>
        /// Set to true if this is a top level entity.
        /// </summary>
        /// <value>Set to true if this is a top level entity.</value>
        [DataMember(Name="isTopLevelEntity", EmitDefaultValue=true)]
        public bool? IsTopLevelEntity { get; set; }

        /// <summary>
        /// Adapter assigned entity identifier protos for the list of parent entities.
        /// </summary>
        /// <value>Adapter assigned entity identifier protos for the list of parent entities.</value>
        [DataMember(Name="parentIds", EmitDefaultValue=true)]
        public List<ExperimentalAdapterEntityIdentifier> ParentIds { get; set; }

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
            return this.Equals(input as ExperimentalAdapterProtectionSource);
        }

        /// <summary>
        /// Returns true if ExperimentalAdapterProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ExperimentalAdapterProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperimentalAdapterProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EntityTypeId == input.EntityTypeId ||
                    (this.EntityTypeId != null &&
                    this.EntityTypeId.Equals(input.EntityTypeId))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.IsLeafEntity == input.IsLeafEntity ||
                    (this.IsLeafEntity != null &&
                    this.IsLeafEntity.Equals(input.IsLeafEntity))
                ) && 
                (
                    this.IsTaskableEntity == input.IsTaskableEntity ||
                    (this.IsTaskableEntity != null &&
                    this.IsTaskableEntity.Equals(input.IsTaskableEntity))
                ) && 
                (
                    this.IsTopLevelEntity == input.IsTopLevelEntity ||
                    (this.IsTopLevelEntity != null &&
                    this.IsTopLevelEntity.Equals(input.IsTopLevelEntity))
                ) && 
                (
                    this.ParentIds == input.ParentIds ||
                    this.ParentIds != null &&
                    input.ParentIds != null &&
                    this.ParentIds.SequenceEqual(input.ParentIds)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.EntityTypeId != null)
                    hashCode = hashCode * 59 + this.EntityTypeId.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.IsLeafEntity != null)
                    hashCode = hashCode * 59 + this.IsLeafEntity.GetHashCode();
                if (this.IsTaskableEntity != null)
                    hashCode = hashCode * 59 + this.IsTaskableEntity.GetHashCode();
                if (this.IsTopLevelEntity != null)
                    hashCode = hashCode * 59 + this.IsTopLevelEntity.GetHashCode();
                if (this.ParentIds != null)
                    hashCode = hashCode * 59 + this.ParentIds.GetHashCode();
                return hashCode;
            }
        }

    }

}

