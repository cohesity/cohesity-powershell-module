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
    /// Specifies the information required for recovering kubernetes entities.
    /// </summary>
    [DataContract]
    public partial class KubernetesRestoreParameters :  IEquatable<KubernetesRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesRestoreParameters" /> class.
        /// </summary>
        /// <param name="prefix">Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="suffix">Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        public KubernetesRestoreParameters(string prefix = default(string), string suffix = default(string))
        {
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.Prefix = prefix;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="prefix", EmitDefaultValue=true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

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
            return this.Equals(input as KubernetesRestoreParameters);
        }

        /// <summary>
        /// Returns true if KubernetesRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

