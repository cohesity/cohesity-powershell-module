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
    /// Specifies a list of attributes about an entity.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProtoAttributesDescriptor :  IEquatable<EntitySchemaProtoAttributesDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProtoAttributesDescriptor" /> class.
        /// </summary>
        /// <param name="attributeVec">List of attributes about an entity..</param>
        /// <param name="keyAttributeNameIndex">Specifies the attribute to use as a unique identifier for the entity. This value is returned in entityId when the GET public/statistics/entities operation is run..</param>
        public EntitySchemaProtoAttributesDescriptor(List<EntitySchemaProtoKeyValueDescriptor> attributeVec = default(List<EntitySchemaProtoKeyValueDescriptor>), int? keyAttributeNameIndex = default(int?))
        {
            this.AttributeVec = attributeVec;
            this.KeyAttributeNameIndex = keyAttributeNameIndex;
        }
        
        /// <summary>
        /// List of attributes about an entity.
        /// </summary>
        /// <value>List of attributes about an entity.</value>
        [DataMember(Name="attributeVec", EmitDefaultValue=false)]
        public List<EntitySchemaProtoKeyValueDescriptor> AttributeVec { get; set; }

        /// <summary>
        /// Specifies the attribute to use as a unique identifier for the entity. This value is returned in entityId when the GET public/statistics/entities operation is run.
        /// </summary>
        /// <value>Specifies the attribute to use as a unique identifier for the entity. This value is returned in entityId when the GET public/statistics/entities operation is run.</value>
        [DataMember(Name="keyAttributeNameIndex", EmitDefaultValue=false)]
        public int? KeyAttributeNameIndex { get; set; }

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
            return this.Equals(input as EntitySchemaProtoAttributesDescriptor);
        }

        /// <summary>
        /// Returns true if EntitySchemaProtoAttributesDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProtoAttributesDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProtoAttributesDescriptor input)
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
                    this.KeyAttributeNameIndex == input.KeyAttributeNameIndex ||
                    (this.KeyAttributeNameIndex != null &&
                    this.KeyAttributeNameIndex.Equals(input.KeyAttributeNameIndex))
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
                if (this.KeyAttributeNameIndex != null)
                    hashCode = hashCode * 59 + this.KeyAttributeNameIndex.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

