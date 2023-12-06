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
    /// Specifies information about a Sfdc Object Field.
    /// </summary>
    [DataContract]
    public partial class SfdcObjectFields :  IEquatable<SfdcObjectFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcObjectFields" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of a Salesforce Object Field..</param>
        public SfdcObjectFields(string name = default(string))
        {
            this.Name = name;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the name of a Salesforce Object Field.
        /// </summary>
        /// <value>Specifies the name of a Salesforce Object Field.</value>
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
            return this.Equals(input as SfdcObjectFields);
        }

        /// <summary>
        /// Returns true if SfdcObjectFields instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcObjectFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcObjectFields input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

