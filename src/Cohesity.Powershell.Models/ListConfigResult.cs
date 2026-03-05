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
    /// Specifies the list of NoSQL adapters&#39; configs for each ConfigType.
    /// </summary>
    [DataContract]
    public partial class ListConfigResult :  IEquatable<ListConfigResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigResult" /> class.
        /// </summary>
        /// <param name="configValuesResultList">Specifies the list of NoSQL configs..</param>
        public ListConfigResult(List<ConfigValuesResult> configValuesResultList = default(List<ConfigValuesResult>))
        {
            this.ConfigValuesResultList = configValuesResultList;
            this.ConfigValuesResultList = configValuesResultList;
        }
        
        /// <summary>
        /// Specifies the list of NoSQL configs.
        /// </summary>
        /// <value>Specifies the list of NoSQL configs.</value>
        [DataMember(Name="configValuesResultList", EmitDefaultValue=true)]
        public List<ConfigValuesResult> ConfigValuesResultList { get; set; }

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
            return this.Equals(input as ListConfigResult);
        }

        /// <summary>
        /// Returns true if ListConfigResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConfigResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConfigResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigValuesResultList == input.ConfigValuesResultList ||
                    this.ConfigValuesResultList != null &&
                    input.ConfigValuesResultList != null &&
                    this.ConfigValuesResultList.SequenceEqual(input.ConfigValuesResultList)
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
                if (this.ConfigValuesResultList != null)
                    hashCode = hashCode * 59 + this.ConfigValuesResultList.GetHashCode();
                return hashCode;
            }
        }

    }

}

