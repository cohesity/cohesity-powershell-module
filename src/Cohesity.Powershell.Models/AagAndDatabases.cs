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
    /// Specifies an AAG and the database members of the AAG.
    /// </summary>
    [DataContract]
    public partial class AagAndDatabases :  IEquatable<AagAndDatabases>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AagAndDatabases" /> class.
        /// </summary>
        /// <param name="aag">aag.</param>
        /// <param name="databases">Specifies databases found that are members of the AAG..</param>
        public AagAndDatabases(ProtectionSource aag = default(ProtectionSource), List<ProtectionSource> databases = default(List<ProtectionSource>))
        {
            this.Databases = databases;
            this.Aag = aag;
            this.Databases = databases;
        }
        
        /// <summary>
        /// Gets or Sets Aag
        /// </summary>
        [DataMember(Name="aag", EmitDefaultValue=false)]
        public ProtectionSource Aag { get; set; }

        /// <summary>
        /// Specifies databases found that are members of the AAG.
        /// </summary>
        /// <value>Specifies databases found that are members of the AAG.</value>
        [DataMember(Name="databases", EmitDefaultValue=true)]
        public List<ProtectionSource> Databases { get; set; }

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
            return this.Equals(input as AagAndDatabases);
        }

        /// <summary>
        /// Returns true if AagAndDatabases instances are equal
        /// </summary>
        /// <param name="input">Instance of AagAndDatabases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AagAndDatabases input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aag == input.Aag ||
                    (this.Aag != null &&
                    this.Aag.Equals(input.Aag))
                ) && 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.SequenceEqual(input.Databases)
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
                if (this.Aag != null)
                    hashCode = hashCode * 59 + this.Aag.GetHashCode();
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }

    }

}

