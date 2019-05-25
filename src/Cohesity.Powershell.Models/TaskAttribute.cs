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
    /// This contains a string name, a value, and a type for the value.
    /// </summary>
    [DataContract]
    public partial class TaskAttribute :  IEquatable<TaskAttribute>
    {
        /// <summary>
        /// Specifies the type of the value contained here. All values are returned as pointers to strings, but they can be casted to the type indicated here. &#39;kInt64&#39; indicates that the value stored in the Task Attribute is a 64-bit integer. &#39;kDouble&#39; indicates that the value stored in the Task Attribute is a 64 bit floating point number. &#39;kString&#39; indicates that the value stored in the Task Attribute is a string. &#39;kBytes&#39; indicates that the value stored in the Task Attribute is an array of bytes.
        /// </summary>
        /// <value>Specifies the type of the value contained here. All values are returned as pointers to strings, but they can be casted to the type indicated here. &#39;kInt64&#39; indicates that the value stored in the Task Attribute is a 64-bit integer. &#39;kDouble&#39; indicates that the value stored in the Task Attribute is a 64 bit floating point number. &#39;kString&#39; indicates that the value stored in the Task Attribute is a string. &#39;kBytes&#39; indicates that the value stored in the Task Attribute is an array of bytes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum KInt64 for value: kInt64
            /// </summary>
            [EnumMember(Value = "kInt64")]
            KInt64 = 1,

            /// <summary>
            /// Enum KDouble for value: kDouble
            /// </summary>
            [EnumMember(Value = "kDouble")]
            KDouble = 2,

            /// <summary>
            /// Enum KString for value: kString
            /// </summary>
            [EnumMember(Value = "kString")]
            KString = 3,

            /// <summary>
            /// Enum KBytes for value: kBytes
            /// </summary>
            [EnumMember(Value = "kBytes")]
            KBytes = 4

        }

        /// <summary>
        /// Specifies the type of the value contained here. All values are returned as pointers to strings, but they can be casted to the type indicated here. &#39;kInt64&#39; indicates that the value stored in the Task Attribute is a 64-bit integer. &#39;kDouble&#39; indicates that the value stored in the Task Attribute is a 64 bit floating point number. &#39;kString&#39; indicates that the value stored in the Task Attribute is a string. &#39;kBytes&#39; indicates that the value stored in the Task Attribute is an array of bytes.
        /// </summary>
        /// <value>Specifies the type of the value contained here. All values are returned as pointers to strings, but they can be casted to the type indicated here. &#39;kInt64&#39; indicates that the value stored in the Task Attribute is a 64-bit integer. &#39;kDouble&#39; indicates that the value stored in the Task Attribute is a 64 bit floating point number. &#39;kString&#39; indicates that the value stored in the Task Attribute is a string. &#39;kBytes&#39; indicates that the value stored in the Task Attribute is an array of bytes.</value>
        [DataMember(Name="valueType", EmitDefaultValue=true)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAttribute" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of this Task Attribute..</param>
        /// <param name="value">Specifies the value of this Task Attribute..</param>
        /// <param name="valueType">Specifies the type of the value contained here. All values are returned as pointers to strings, but they can be casted to the type indicated here. &#39;kInt64&#39; indicates that the value stored in the Task Attribute is a 64-bit integer. &#39;kDouble&#39; indicates that the value stored in the Task Attribute is a 64 bit floating point number. &#39;kString&#39; indicates that the value stored in the Task Attribute is a string. &#39;kBytes&#39; indicates that the value stored in the Task Attribute is an array of bytes..</param>
        public TaskAttribute(string name = default(string), string value = default(string), ValueTypeEnum? valueType = default(ValueTypeEnum?))
        {
            this.Name = name;
            this.Value = value;
            this.ValueType = valueType;
            this.Name = name;
            this.Value = value;
            this.ValueType = valueType;
        }
        
        /// <summary>
        /// Specifies the name of this Task Attribute.
        /// </summary>
        /// <value>Specifies the name of this Task Attribute.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the value of this Task Attribute.
        /// </summary>
        /// <value>Specifies the value of this Task Attribute.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAttribute {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as TaskAttribute);
        }

        /// <summary>
        /// Returns true if TaskAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                return hashCode;
            }
        }

    }

}
