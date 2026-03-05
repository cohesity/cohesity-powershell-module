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
    /// Specifies the attributes of a app config.
    /// </summary>
    [DataContract]
    public partial class NoSqlAppConfig :  IEquatable<NoSqlAppConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlAppConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoSqlAppConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlAppConfig" /> class.
        /// </summary>
        /// <param name="name">Specifies name of the config. (required).</param>
        /// <param name="value">Specifies value of the config. (required).</param>
        public NoSqlAppConfig(string name = default(string), string value = default(string))
        {
            this.Name = name;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies name of the config.
        /// </summary>
        /// <value>Specifies name of the config.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies value of the config.
        /// </summary>
        /// <value>Specifies value of the config.</value>
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
            return this.Equals(input as NoSqlAppConfig);
        }

        /// <summary>
        /// Returns true if NoSqlAppConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlAppConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlAppConfig input)
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
                return hashCode;
            }
        }

    }

}

