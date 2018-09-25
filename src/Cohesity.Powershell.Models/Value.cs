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
    /// Specifies a data type and data field used to store data.
    /// </summary>
    [DataContract]
    public partial class Value :  IEquatable<Value>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="type">Specifies the type of value. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes..</param>
        public Value(ValueData data = default(ValueData), int? type = default(int?))
        {
            this.Data = data;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public ValueData Data { get; set; }

        /// <summary>
        /// Specifies the type of value. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes.
        /// </summary>
        /// <value>Specifies the type of value. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as Value);
        }

        /// <summary>
        /// Returns true if Value instances are equal
        /// </summary>
        /// <param name="input">Instance of Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Value input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

