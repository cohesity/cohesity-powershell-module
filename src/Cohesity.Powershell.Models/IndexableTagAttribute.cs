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
    /// Specifies information about tags associated with an entity for this entity to be indexed against for search purposes.
    /// </summary>
    [DataContract]
    public partial class IndexableTagAttribute :  IEquatable<IndexableTagAttribute>
    {
        /// <summary>
        /// Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up). Specifies information about tags associated with an entity. &#39;kSystemTag&#39; represents a system-generated tag. &#39;kUserTag&#39; represents a user-defined tag.
        /// </summary>
        /// <value>Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up). Specifies information about tags associated with an entity. &#39;kSystemTag&#39; represents a system-generated tag. &#39;kUserTag&#39; represents a user-defined tag.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TagTypeEnum
        {
            /// <summary>
            /// Enum KSystemTag for value: kSystemTag
            /// </summary>
            [EnumMember(Value = "kSystemTag")]
            KSystemTag = 1,

            /// <summary>
            /// Enum KUserTag for value: kUserTag
            /// </summary>
            [EnumMember(Value = "kUserTag")]
            KUserTag = 2

        }

        /// <summary>
        /// Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up). Specifies information about tags associated with an entity. &#39;kSystemTag&#39; represents a system-generated tag. &#39;kUserTag&#39; represents a user-defined tag.
        /// </summary>
        /// <value>Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up). Specifies information about tags associated with an entity. &#39;kSystemTag&#39; represents a system-generated tag. &#39;kUserTag&#39; represents a user-defined tag.</value>
        [DataMember(Name="tagType", EmitDefaultValue=true)]
        public TagTypeEnum? TagType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexableTagAttribute" /> class.
        /// </summary>
        /// <param name="entityId">entityId.</param>
        /// <param name="key">Specifies the key of the tag..</param>
        /// <param name="tagType">Type of tag - system tag (i.e. discovered during entity discovery) or user tag (created by cohesity user on cohesity UI - for future use case when this epic is taken up). Specifies information about tags associated with an entity. &#39;kSystemTag&#39; represents a system-generated tag. &#39;kUserTag&#39; represents a user-defined tag..</param>
        /// <param name="uuid">The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud..</param>
        /// <param name="value">Specifies the value of the tag..</param>
        public IndexableTagAttribute(ObjectStringIdentifier entityId = default(ObjectStringIdentifier), string key = default(string), TagTypeEnum? tagType = default(TagTypeEnum?), string uuid = default(string), string value = default(string))
        {
            this.Key = key;
            this.TagType = tagType;
            this.Uuid = uuid;
            this.Value = value;
            this.EntityId = entityId;
            this.Key = key;
            this.TagType = tagType;
            this.Uuid = uuid;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public ObjectStringIdentifier EntityId { get; set; }

        /// <summary>
        /// Specifies the key of the tag.
        /// </summary>
        /// <value>Specifies the key of the tag.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud.
        /// </summary>
        /// <value>The instance UUID for the tag object. For ex. for cloud tag this can be the resource ID of the tag in cloud.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the value of the tag.
        /// </summary>
        /// <value>Specifies the value of the tag.</value>
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
            return this.Equals(input as IndexableTagAttribute);
        }

        /// <summary>
        /// Returns true if IndexableTagAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexableTagAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexableTagAttribute input)
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
                    this.TagType == input.TagType ||
                    this.TagType.Equals(input.TagType)
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
                hashCode = hashCode * 59 + this.TagType.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

