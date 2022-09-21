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
    /// Message to specify the prefix/suffix added to rename an object. At least one of prefix or suffix must be specified. Please note that both prefix and suffix can be specified.
    /// </summary>
    [DataContract]
    public partial class RenameObjectParamProto :  IEquatable<RenameObjectParamProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameObjectParamProto" /> class.
        /// </summary>
        /// <param name="prefix">Prefix to be added to a name..</param>
        /// <param name="suffix">Suffix to be added to a name..</param>
        public RenameObjectParamProto(string prefix = default(string), string suffix = default(string))
        {
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.Prefix = prefix;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Prefix to be added to a name.
        /// </summary>
        /// <value>Prefix to be added to a name.</value>
        [DataMember(Name="prefix", EmitDefaultValue=true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Suffix to be added to a name.
        /// </summary>
        /// <value>Suffix to be added to a name.</value>
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
            return this.Equals(input as RenameObjectParamProto);
        }

        /// <summary>
        /// Returns true if RenameObjectParamProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RenameObjectParamProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenameObjectParamProto input)
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

