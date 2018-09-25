// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// RestoreCountByObjectType
    /// </summary>
    [DataContract]
    public partial class RestoreCountByObjectType :  IEquatable<RestoreCountByObjectType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreCountByObjectType" /> class.
        /// </summary>
        /// <param name="objectCount">Specifies the number of restores of the object type..</param>
        /// <param name="objectType">Specifies the type of the restored object..</param>
        public RestoreCountByObjectType(int? objectCount = default(int?), string objectType = default(string))
        {
            this.ObjectCount = objectCount;
            this.ObjectType = objectType;
        }
        
        /// <summary>
        /// Specifies the number of restores of the object type.
        /// </summary>
        /// <value>Specifies the number of restores of the object type.</value>
        [DataMember(Name="objectCount", EmitDefaultValue=false)]
        public int? ObjectCount { get; set; }

        /// <summary>
        /// Specifies the type of the restored object.
        /// </summary>
        /// <value>Specifies the type of the restored object.</value>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as RestoreCountByObjectType);
        }

        /// <summary>
        /// Returns true if RestoreCountByObjectType instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreCountByObjectType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreCountByObjectType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectCount == input.ObjectCount ||
                    (this.ObjectCount != null &&
                    this.ObjectCount.Equals(input.ObjectCount))
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
                if (this.ObjectCount != null)
                    hashCode = hashCode * 59 + this.ObjectCount.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

