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
    /// Specifies the ConfigType and the corresponding list of NoSQL configs.
    /// </summary>
    [DataContract]
    public partial class ConfigValuesResult :  IEquatable<ConfigValuesResult>
    {
        /// <summary>
        /// Specifies the ConfigType to which ConfigValues belong to. &#39;kSite&#39; Specifies configs in site related xml files.
        /// </summary>
        /// <value>Specifies the ConfigType to which ConfigValues belong to. &#39;kSite&#39; Specifies configs in site related xml files.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfigTypeEnum
        {
            /// <summary>
            /// Enum KSite for value: kSite
            /// </summary>
            [EnumMember(Value = "kSite")]
            KSite = 1

        }

        /// <summary>
        /// Specifies the ConfigType to which ConfigValues belong to. &#39;kSite&#39; Specifies configs in site related xml files.
        /// </summary>
        /// <value>Specifies the ConfigType to which ConfigValues belong to. &#39;kSite&#39; Specifies configs in site related xml files.</value>
        [DataMember(Name="configType", EmitDefaultValue=true)]
        public ConfigTypeEnum? ConfigType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigValuesResult" /> class.
        /// </summary>
        /// <param name="configType">Specifies the ConfigType to which ConfigValues belong to. &#39;kSite&#39; Specifies configs in site related xml files..</param>
        /// <param name="configValues">Specifies the list of NoSQL configs..</param>
        public ConfigValuesResult(ConfigTypeEnum? configType = default(ConfigTypeEnum?), List<NoSqlAppConfig> configValues = default(List<NoSqlAppConfig>))
        {
            this.ConfigType = configType;
            this.ConfigValues = configValues;
            this.ConfigType = configType;
            this.ConfigValues = configValues;
        }
        
        /// <summary>
        /// Specifies the list of NoSQL configs.
        /// </summary>
        /// <value>Specifies the list of NoSQL configs.</value>
        [DataMember(Name="configValues", EmitDefaultValue=true)]
        public List<NoSqlAppConfig> ConfigValues { get; set; }

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
            return this.Equals(input as ConfigValuesResult);
        }

        /// <summary>
        /// Returns true if ConfigValuesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigValuesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigValuesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigType == input.ConfigType ||
                    this.ConfigType.Equals(input.ConfigType)
                ) && 
                (
                    this.ConfigValues == input.ConfigValues ||
                    this.ConfigValues != null &&
                    input.ConfigValues != null &&
                    this.ConfigValues.SequenceEqual(input.ConfigValues)
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
                hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.ConfigValues != null)
                    hashCode = hashCode * 59 + this.ConfigValues.GetHashCode();
                return hashCode;
            }
        }

    }

}

