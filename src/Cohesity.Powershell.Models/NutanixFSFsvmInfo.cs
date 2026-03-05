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
    /// Specifies information about a NutanixFS File Server VM (FSVM) in a NutanixFS Protection Source.
    /// </summary>
    [DataContract]
    public partial class NutanixFSFsvmInfo :  IEquatable<NutanixFSFsvmInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutanixFSFsvmInfo" /> class.
        /// </summary>
        /// <param name="fsvmExtId">Specifies the string ID of this file server VM..</param>
        /// <param name="fsvmUuid">Specifies the UUID of this file server VM..</param>
        /// <param name="ipAddress">Specifies the IP addresses of this file server VM..</param>
        /// <param name="name">Specifies the name of this file server VM..</param>
        public NutanixFSFsvmInfo(string fsvmExtId = default(string), string fsvmUuid = default(string), List<string> ipAddress = default(List<string>), string name = default(string))
        {
            this.FsvmExtId = fsvmExtId;
            this.FsvmUuid = fsvmUuid;
            this.IpAddress = ipAddress;
            this.Name = name;
            this.FsvmExtId = fsvmExtId;
            this.FsvmUuid = fsvmUuid;
            this.IpAddress = ipAddress;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the string ID of this file server VM.
        /// </summary>
        /// <value>Specifies the string ID of this file server VM.</value>
        [DataMember(Name="fsvmExtId", EmitDefaultValue=true)]
        public string FsvmExtId { get; set; }

        /// <summary>
        /// Specifies the UUID of this file server VM.
        /// </summary>
        /// <value>Specifies the UUID of this file server VM.</value>
        [DataMember(Name="fsvmUuid", EmitDefaultValue=true)]
        public string FsvmUuid { get; set; }

        /// <summary>
        /// Specifies the IP addresses of this file server VM.
        /// </summary>
        /// <value>Specifies the IP addresses of this file server VM.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=true)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// Specifies the name of this file server VM.
        /// </summary>
        /// <value>Specifies the name of this file server VM.</value>
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
            return this.Equals(input as NutanixFSFsvmInfo);
        }

        /// <summary>
        /// Returns true if NutanixFSFsvmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NutanixFSFsvmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutanixFSFsvmInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FsvmExtId == input.FsvmExtId ||
                    (this.FsvmExtId != null &&
                    this.FsvmExtId.Equals(input.FsvmExtId))
                ) && 
                (
                    this.FsvmUuid == input.FsvmUuid ||
                    (this.FsvmUuid != null &&
                    this.FsvmUuid.Equals(input.FsvmUuid))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    this.IpAddress != null &&
                    input.IpAddress != null &&
                    this.IpAddress.SequenceEqual(input.IpAddress)
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
                if (this.FsvmExtId != null)
                    hashCode = hashCode * 59 + this.FsvmExtId.GetHashCode();
                if (this.FsvmUuid != null)
                    hashCode = hashCode * 59 + this.FsvmUuid.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

