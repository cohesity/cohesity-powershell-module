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
    /// Specifies the custom attributes when mapping type is set to &#39;kCustomAttributes&#39;. It defines the attribute names to derive the mapping for a user of an Active Directory domain.
    /// </summary>
    [DataContract]
    public partial class CustomUnixIdAttributes :  IEquatable<CustomUnixIdAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomUnixIdAttributes" /> class.
        /// </summary>
        /// <param name="gidAttrName">Specifies the custom field name in Active Directory user properties to get the GID..</param>
        /// <param name="uidAttrName">Specifies the custom field name in Active Directory user properties to get the UID..</param>
        public CustomUnixIdAttributes(string gidAttrName = default(string), string uidAttrName = default(string))
        {
            this.GidAttrName = gidAttrName;
            this.UidAttrName = uidAttrName;
        }
        
        /// <summary>
        /// Specifies the custom field name in Active Directory user properties to get the GID.
        /// </summary>
        /// <value>Specifies the custom field name in Active Directory user properties to get the GID.</value>
        [DataMember(Name="gidAttrName", EmitDefaultValue=false)]
        public string GidAttrName { get; set; }

        /// <summary>
        /// Specifies the custom field name in Active Directory user properties to get the UID.
        /// </summary>
        /// <value>Specifies the custom field name in Active Directory user properties to get the UID.</value>
        [DataMember(Name="uidAttrName", EmitDefaultValue=false)]
        public string UidAttrName { get; set; }

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
            return this.Equals(input as CustomUnixIdAttributes);
        }

        /// <summary>
        /// Returns true if CustomUnixIdAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomUnixIdAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomUnixIdAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GidAttrName == input.GidAttrName ||
                    (this.GidAttrName != null &&
                    this.GidAttrName.Equals(input.GidAttrName))
                ) && 
                (
                    this.UidAttrName == input.UidAttrName ||
                    (this.UidAttrName != null &&
                    this.UidAttrName.Equals(input.UidAttrName))
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
                if (this.GidAttrName != null)
                    hashCode = hashCode * 59 + this.GidAttrName.GetHashCode();
                if (this.UidAttrName != null)
                    hashCode = hashCode * 59 + this.UidAttrName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

