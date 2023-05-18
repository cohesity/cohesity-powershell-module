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
    /// Specifies an Object containing information about a Universal Data Adapter object.
    /// </summary>
    [DataContract]
    public partial class UdaObject :  IEquatable<UdaObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaObject" /> class.
        /// </summary>
        /// <param name="isLeaf">Indicates whether this object is is a leaf object.</param>
        /// <param name="objectType">Type of this object.</param>
        public UdaObject(bool? isLeaf = default(bool?), string objectType = default(string))
        {
            this.IsLeaf = isLeaf;
            this.ObjectType = objectType;
            this.IsLeaf = isLeaf;
            this.ObjectType = objectType;
        }
        
        /// <summary>
        /// Indicates whether this object is is a leaf object
        /// </summary>
        /// <value>Indicates whether this object is is a leaf object</value>
        [DataMember(Name="isLeaf", EmitDefaultValue=true)]
        public bool? IsLeaf { get; set; }

        /// <summary>
        /// Type of this object
        /// </summary>
        /// <value>Type of this object</value>
        [DataMember(Name="objectType", EmitDefaultValue=true)]
        public string ObjectType { get; set; }

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
            return this.Equals(input as UdaObject);
        }

        /// <summary>
        /// Returns true if UdaObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLeaf == input.IsLeaf ||
                    (this.IsLeaf != null &&
                    this.IsLeaf.Equals(input.IsLeaf))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
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
                if (this.IsLeaf != null)
                    hashCode = hashCode * 59 + this.IsLeaf.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                return hashCode;
            }
        }

    }

}

