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
    /// Specifies information about a NutanixFS Prism Element Protection Source.
    /// </summary>
    [DataContract]
    public partial class NutanixFSPrismElementInfo :  IEquatable<NutanixFSPrismElementInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutanixFSPrismElementInfo" /> class.
        /// </summary>
        /// <param name="extId">Specifies information about the contact for the NutanixFS Prism Element such as a name, phone number, and email address..</param>
        /// <param name="name">Specifies where this NutanixFS Prism Element is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Element hostname or IP address..</param>
        /// <param name="version">Specifies the serial number of the NutanixFS Prism Element in the format: x-xx-xxxxxx..</param>
        public NutanixFSPrismElementInfo(string extId = default(string), string name = default(string), string version = default(string))
        {
            this.ExtId = extId;
            this.Name = name;
            this.Version = version;
            this.ExtId = extId;
            this.Name = name;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies information about the contact for the NutanixFS Prism Element such as a name, phone number, and email address.
        /// </summary>
        /// <value>Specifies information about the contact for the NutanixFS Prism Element such as a name, phone number, and email address.</value>
        [DataMember(Name="extId", EmitDefaultValue=true)]
        public string ExtId { get; set; }

        /// <summary>
        /// Specifies where this NutanixFS Prism Element is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Element hostname or IP address.
        /// </summary>
        /// <value>Specifies where this NutanixFS Prism Element is located. This location identification string is configured by the NutanixFS system administrator. This field does not contain the NutanixFS Prism Element hostname or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the serial number of the NutanixFS Prism Element in the format: x-xx-xxxxxx.
        /// </summary>
        /// <value>Specifies the serial number of the NutanixFS Prism Element in the format: x-xx-xxxxxx.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as NutanixFSPrismElementInfo);
        }

        /// <summary>
        /// Returns true if NutanixFSPrismElementInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NutanixFSPrismElementInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutanixFSPrismElementInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ExtId != null)
                    hashCode = hashCode * 59 + this.ExtId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

