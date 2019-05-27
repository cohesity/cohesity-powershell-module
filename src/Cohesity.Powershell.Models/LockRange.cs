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
    /// LockRange
    /// </summary>
    [DataContract]
    public partial class LockRange :  IEquatable<LockRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockRange" /> class.
        /// </summary>
        /// <param name="isExclusive">isExclusive.</param>
        /// <param name="length">length.</param>
        /// <param name="offset">offset.</param>
        public LockRange(bool? isExclusive = default(bool?), int? length = default(int?), int? offset = default(int?))
        {
            this.IsExclusive = isExclusive;
            this.Length = length;
            this.Offset = offset;
            this.IsExclusive = isExclusive;
            this.Length = length;
            this.Offset = offset;
        }
        
        /// <summary>
        /// Gets or Sets IsExclusive
        /// </summary>
        [DataMember(Name="isExclusive", EmitDefaultValue=true)]
        public bool? IsExclusive { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=true)]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=true)]
        public int? Offset { get; set; }

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
            return this.Equals(input as LockRange);
        }

        /// <summary>
        /// Returns true if LockRange instances are equal
        /// </summary>
        /// <param name="input">Instance of LockRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsExclusive == input.IsExclusive ||
                    (this.IsExclusive != null &&
                    this.IsExclusive.Equals(input.IsExclusive))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.IsExclusive != null)
                    hashCode = hashCode * 59 + this.IsExclusive.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }

    }

}

