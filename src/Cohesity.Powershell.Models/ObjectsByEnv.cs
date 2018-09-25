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
    /// ObjectsByEnv
    /// </summary>
    [DataContract]
    public partial class ObjectsByEnv :  IEquatable<ObjectsByEnv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsByEnv" /> class.
        /// </summary>
        /// <param name="envType">Environment Type..</param>
        /// <param name="numObjects">Number of Objects..</param>
        public ObjectsByEnv(string envType = default(string), int? numObjects = default(int?))
        {
            this.EnvType = envType;
            this.NumObjects = numObjects;
        }
        
        /// <summary>
        /// Environment Type.
        /// </summary>
        /// <value>Environment Type.</value>
        [DataMember(Name="envType", EmitDefaultValue=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// Number of Objects.
        /// </summary>
        /// <value>Number of Objects.</value>
        [DataMember(Name="numObjects", EmitDefaultValue=false)]
        public int? NumObjects { get; set; }

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
            return this.Equals(input as ObjectsByEnv);
        }

        /// <summary>
        /// Returns true if ObjectsByEnv instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectsByEnv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectsByEnv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnvType == input.EnvType ||
                    (this.EnvType != null &&
                    this.EnvType.Equals(input.EnvType))
                ) && 
                (
                    this.NumObjects == input.NumObjects ||
                    (this.NumObjects != null &&
                    this.NumObjects.Equals(input.NumObjects))
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
                if (this.EnvType != null)
                    hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.NumObjects != null)
                    hashCode = hashCode * 59 + this.NumObjects.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

