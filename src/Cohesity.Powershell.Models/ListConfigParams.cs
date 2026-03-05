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
    /// Specifies the list of NoSQL Config Types for getting configs.
    /// </summary>
    [DataContract]
    public partial class ListConfigParams :  IEquatable<ListConfigParams>
    {
        /// <summary>
        /// Defines ConfigTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfigTypesEnum
        {
            /// <summary>
            /// Enum KSite for value: kSite
            /// </summary>
            [EnumMember(Value = "kSite")]
            KSite = 1

        }


        /// <summary>
        /// Specifies the list of NoSQL Configs Types. &#39;kSite&#39; Specifies configs in site related xml files.
        /// </summary>
        /// <value>Specifies the list of NoSQL Configs Types. &#39;kSite&#39; Specifies configs in site related xml files.</value>
        [DataMember(Name="configTypes", EmitDefaultValue=true)]
        public List<ConfigTypesEnum> ConfigTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigParams" /> class.
        /// </summary>
        /// <param name="configTypes">Specifies the list of NoSQL Configs Types. &#39;kSite&#39; Specifies configs in site related xml files..</param>
        public ListConfigParams(List<ConfigTypesEnum> configTypes = default(List<ConfigTypesEnum>))
        {
            this.ConfigTypes = configTypes;
            this.ConfigTypes = configTypes;
        }
        
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
            return this.Equals(input as ListConfigParams);
        }

        /// <summary>
        /// Returns true if ListConfigParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConfigParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConfigParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigTypes == input.ConfigTypes ||
                    this.ConfigTypes.SequenceEqual(input.ConfigTypes)
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
                hashCode = hashCode * 59 + this.ConfigTypes.GetHashCode();
                return hashCode;
            }
        }

    }

}

