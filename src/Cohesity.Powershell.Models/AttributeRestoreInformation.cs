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
    /// Represents the details about the restore of the AD attribute.
    /// </summary>
    [DataContract]
    public partial class AttributeRestoreInformation :  IEquatable<AttributeRestoreInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeRestoreInformation" /> class.
        /// </summary>
        /// <param name="errorMessage">Specifes the error messages corresponding to restore of the attribute..</param>
        /// <param name="name">Specifies the name of the attribute of the AD object..</param>
        public AttributeRestoreInformation(List<string> errorMessage = default(List<string>), string name = default(string))
        {
            this.ErrorMessage = errorMessage;
            this.Name = name;
            this.ErrorMessage = errorMessage;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifes the error messages corresponding to restore of the attribute.
        /// </summary>
        /// <value>Specifes the error messages corresponding to restore of the attribute.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public List<string> ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the name of the attribute of the AD object.
        /// </summary>
        /// <value>Specifies the name of the attribute of the AD object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as AttributeRestoreInformation);
        }

        /// <summary>
        /// Returns true if AttributeRestoreInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeRestoreInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeRestoreInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    this.ErrorMessage != null &&
                    input.ErrorMessage != null &&
                    this.ErrorMessage.SequenceEqual(input.ErrorMessage)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

