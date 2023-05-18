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
    /// This defines the restore Shell environment.
    /// </summary>
    [DataContract]
    public partial class RestoreOracleAppObjectParamsKeyValuePair :  IEquatable<RestoreOracleAppObjectParamsKeyValuePair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOracleAppObjectParamsKeyValuePair" /> class.
        /// </summary>
        /// <param name="xKey">Name of the key..</param>
        /// <param name="xValue">Value of the key..</param>
        public RestoreOracleAppObjectParamsKeyValuePair(string xKey = default(string), string xValue = default(string))
        {
            this.XKey = xKey;
            this.XValue = xValue;
            this.XKey = xKey;
            this.XValue = xValue;
        }
        
        /// <summary>
        /// Name of the key.
        /// </summary>
        /// <value>Name of the key.</value>
        [DataMember(Name="xKey", EmitDefaultValue=true)]
        public string XKey { get; set; }

        /// <summary>
        /// Value of the key.
        /// </summary>
        /// <value>Value of the key.</value>
        [DataMember(Name="xValue", EmitDefaultValue=true)]
        public string XValue { get; set; }

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
            return this.Equals(input as RestoreOracleAppObjectParamsKeyValuePair);
        }

        /// <summary>
        /// Returns true if RestoreOracleAppObjectParamsKeyValuePair instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOracleAppObjectParamsKeyValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOracleAppObjectParamsKeyValuePair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XKey == input.XKey ||
                    (this.XKey != null &&
                    this.XKey.Equals(input.XKey))
                ) && 
                (
                    this.XValue == input.XValue ||
                    (this.XValue != null &&
                    this.XValue.Equals(input.XValue))
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
                if (this.XKey != null)
                    hashCode = hashCode * 59 + this.XKey.GetHashCode();
                if (this.XValue != null)
                    hashCode = hashCode * 59 + this.XValue.GetHashCode();
                return hashCode;
            }
        }

    }

}

