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
    /// Specifies a unique Protection Source id across Cohesity Clusters. It is derived from the id of the VMware Protection Source.
    /// </summary>
    [DataContract]
    public partial class VMwareObjectId :  IEquatable<VMwareObjectId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareObjectId" /> class.
        /// </summary>
        /// <param name="morItem">Specifies the Managed Object Reference Item..</param>
        /// <param name="morType">Specifies the Managed Object Reference Type..</param>
        /// <param name="uuid">Specifies a Universally Unique Identifier (UUID) of a VMware Object..</param>
        public VMwareObjectId(string morItem = default(string), string morType = default(string), string uuid = default(string))
        {
            this.MorItem = morItem;
            this.MorType = morType;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the Managed Object Reference Item.
        /// </summary>
        /// <value>Specifies the Managed Object Reference Item.</value>
        [DataMember(Name="morItem", EmitDefaultValue=false)]
        public string MorItem { get; set; }

        /// <summary>
        /// Specifies the Managed Object Reference Type.
        /// </summary>
        /// <value>Specifies the Managed Object Reference Type.</value>
        [DataMember(Name="morType", EmitDefaultValue=false)]
        public string MorType { get; set; }

        /// <summary>
        /// Specifies a Universally Unique Identifier (UUID) of a VMware Object.
        /// </summary>
        /// <value>Specifies a Universally Unique Identifier (UUID) of a VMware Object.</value>
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
            return this.Equals(input as VMwareObjectId);
        }

        /// <summary>
        /// Returns true if VMwareObjectId instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareObjectId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareObjectId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MorItem == input.MorItem ||
                    (this.MorItem != null &&
                    this.MorItem.Equals(input.MorItem))
                ) && 
                (
                    this.MorType == input.MorType ||
                    (this.MorType != null &&
                    this.MorType.Equals(input.MorType))
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
                if (this.MorItem != null)
                    hashCode = hashCode * 59 + this.MorItem.GetHashCode();
                if (this.MorType != null)
                    hashCode = hashCode * 59 + this.MorType.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

