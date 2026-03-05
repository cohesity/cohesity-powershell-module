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
    /// EntityStorageClassInfo
    /// </summary>
    [DataContract]
    public partial class EntityStorageClassInfo :  IEquatable<EntityStorageClassInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStorageClassInfo" /> class.
        /// </summary>
        /// <param name="name">Name of the storage class..</param>
        /// <param name="provisioner">Name of the storage provisioner..</param>
        public EntityStorageClassInfo(string name = default(string), string provisioner = default(string))
        {
            this.Name = name;
            this.Provisioner = provisioner;
            this.Name = name;
            this.Provisioner = provisioner;
        }
        
        /// <summary>
        /// Name of the storage class.
        /// </summary>
        /// <value>Name of the storage class.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the storage provisioner.
        /// </summary>
        /// <value>Name of the storage provisioner.</value>
        [DataMember(Name="provisioner", EmitDefaultValue=true)]
        public string Provisioner { get; set; }

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
            return this.Equals(input as EntityStorageClassInfo);
        }

        /// <summary>
        /// Returns true if EntityStorageClassInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityStorageClassInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityStorageClassInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Provisioner == input.Provisioner ||
                    (this.Provisioner != null &&
                    this.Provisioner.Equals(input.Provisioner))
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
                if (this.Provisioner != null)
                    hashCode = hashCode * 59 + this.Provisioner.GetHashCode();
                return hashCode;
            }
        }

    }

}

