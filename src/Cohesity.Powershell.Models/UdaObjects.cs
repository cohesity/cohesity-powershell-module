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
    /// UdaObjects
    /// </summary>
    [DataContract]
    public partial class UdaObjects :  IEquatable<UdaObjects>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaObjects" /> class.
        /// </summary>
        /// <param name="id">Magneto entity id.</param>
        /// <param name="name">Name of the object.</param>
        public UdaObjects(long? id = default(long?), string name = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Magneto entity id
        /// </summary>
        /// <value>Magneto entity id</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the object
        /// </summary>
        /// <value>Name of the object</value>
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
            return this.Equals(input as UdaObjects);
        }

        /// <summary>
        /// Returns true if UdaObjects instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaObjects to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaObjects input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

