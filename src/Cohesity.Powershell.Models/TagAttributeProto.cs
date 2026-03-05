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
    /// Specifies information about tags associated with an entity. The tag can be user-defined or system generated (see below). The tags correspond to tag entities as specified in entity_id field. The tags can be used for UI display purposes as well as indexing an entity to be discoverable by tag key/value.
    /// </summary>
    [DataContract]
    public partial class TagAttributeProto :  IEquatable<TagAttributeProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagAttributeProto" /> class.
        /// </summary>
        /// <param name="entityId">entityId.</param>
        /// <param name="key">Key of the tag..</param>
        /// <param name="type">Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up)..</param>
        /// <param name="uuid">The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud..</param>
        /// <param name="value">Value of the tag..</param>
        public TagAttributeProto(EntityIdProto entityId = default(EntityIdProto), string key = default(string), int? type = default(int?), string uuid = default(string), string value = default(string))
        {
            this.Key = key;
            this.Type = type;
            this.Uuid = uuid;
            this.Value = value;
            this.EntityId = entityId;
            this.Key = key;
            this.Type = type;
            this.Uuid = uuid;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public EntityIdProto EntityId { get; set; }

        /// <summary>
        /// Key of the tag.
        /// </summary>
        /// <value>Key of the tag.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up).
        /// </summary>
        /// <value>Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up).</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud.
        /// </summary>
        /// <value>The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Value of the tag.
        /// </summary>
        /// <value>Value of the tag.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

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
            return this.Equals(input as TagAttributeProto);
        }

        /// <summary>
        /// Returns true if TagAttributeProto instances are equal
        /// </summary>
        /// <param name="input">Instance of TagAttributeProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagAttributeProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

