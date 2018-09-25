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
    /// Specifies a VMware tag.
    /// </summary>
    [DataContract]
    public partial class TagAttribute :  IEquatable<TagAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagAttribute" /> class.
        /// </summary>
        /// <param name="id">Specifies the Coheisty id of the VM tag..</param>
        /// <param name="name">Specifies the VMware name of the VM tag..</param>
        /// <param name="uuid">Specifies the VMware Universally Unique Identifier (UUID) of the VM tag..</param>
        public TagAttribute(long? id = default(long?), string name = default(string), string uuid = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the Coheisty id of the VM tag.
        /// </summary>
        /// <value>Specifies the Coheisty id of the VM tag.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the VMware name of the VM tag.
        /// </summary>
        /// <value>Specifies the VMware name of the VM tag.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the VMware Universally Unique Identifier (UUID) of the VM tag.
        /// </summary>
        /// <value>Specifies the VMware Universally Unique Identifier (UUID) of the VM tag.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

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
            return this.Equals(input as TagAttribute);
        }

        /// <summary>
        /// Returns true if TagAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of TagAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagAttribute input)
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
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

