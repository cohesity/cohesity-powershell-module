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
    /// Specifies the ConfigType and the corresponding count of NoSQL configs.
    /// </summary>
    [DataContract]
    public partial class ConfigCountResult :  IEquatable<ConfigCountResult>
    {
        /// <summary>
        /// Specifies the ConfigType to which ConfigCounts belong to. &#39;kSite&#39; Specifies configs in site related xml files.
        /// </summary>
        /// <value>Specifies the ConfigType to which ConfigCounts belong to. &#39;kSite&#39; Specifies configs in site related xml files.</value>
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
        /// Specifies the ConfigType to which ConfigCounts belong to. &#39;kSite&#39; Specifies configs in site related xml files.
        /// </summary>
        /// <value>Specifies the ConfigType to which ConfigCounts belong to. &#39;kSite&#39; Specifies configs in site related xml files.</value>
        [DataMember(Name="configType", EmitDefaultValue=true)]
        public ConfigTypeEnum? ConfigType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigCountResult" /> class.
        /// </summary>
        /// <param name="configCount">Specifies the count of NoSQL configs..</param>
        /// <param name="configType">Specifies the ConfigType to which ConfigCounts belong to. &#39;kSite&#39; Specifies configs in site related xml files..</param>
        public ConfigCountResult(long? configCount = default(long?), ConfigTypeEnum? configType = default(ConfigTypeEnum?))
        {
            this.ConfigCount = configCount;
            this.ConfigType = configType;
            this.ConfigCount = configCount;
            this.ConfigType = configType;
        }
        
        /// <summary>
        /// Specifies the count of NoSQL configs.
        /// </summary>
        /// <value>Specifies the count of NoSQL configs.</value>
        [DataMember(Name="configCount", EmitDefaultValue=true)]
        public long? ConfigCount { get; set; }

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
            return this.Equals(input as ConfigCountResult);
        }

        /// <summary>
        /// Returns true if ConfigCountResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigCountResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigCountResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigCount == input.ConfigCount ||
                    (this.ConfigCount != null &&
                    this.ConfigCount.Equals(input.ConfigCount))
                ) && 
                (
                    this.ConfigType == input.ConfigType ||
                    this.ConfigType.Equals(input.ConfigType)
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
                if (this.ConfigCount != null)
                    hashCode = hashCode * 59 + this.ConfigCount.GetHashCode();
                hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                return hashCode;
            }
        }

    }

}

