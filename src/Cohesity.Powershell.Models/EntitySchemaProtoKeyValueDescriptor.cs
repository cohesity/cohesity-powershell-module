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
    /// Specifies a key/value pair.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProtoKeyValueDescriptor :  IEquatable<EntitySchemaProtoKeyValueDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProtoKeyValueDescriptor" /> class.
        /// </summary>
        /// <param name="keyName">Specifies the name of a key..</param>
        /// <param name="valueType">Specifies the type of the value that is associated with the key. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes..</param>
        public EntitySchemaProtoKeyValueDescriptor(string keyName = default(string), int? valueType = default(int?))
        {
            this.KeyName = keyName;
            this.ValueType = valueType;
        }
        
        /// <summary>
        /// Specifies the name of a key.
        /// </summary>
        /// <value>Specifies the name of a key.</value>
        [DataMember(Name="keyName", EmitDefaultValue=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// Specifies the type of the value that is associated with the key. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes.
        /// </summary>
        /// <value>Specifies the type of the value that is associated with the key. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes.</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public int? ValueType { get; set; }

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
            return this.Equals(input as EntitySchemaProtoKeyValueDescriptor);
        }

        /// <summary>
        /// Returns true if EntitySchemaProtoKeyValueDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProtoKeyValueDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProtoKeyValueDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

