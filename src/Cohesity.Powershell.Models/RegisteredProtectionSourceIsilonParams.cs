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
    /// Specifies the Isilon specific Registered Protection Source params. This definition is used to send isilion source params in update protection source params to magneto.
    /// </summary>
    [DataContract]
    public partial class RegisteredProtectionSourceIsilonParams :  IEquatable<RegisteredProtectionSourceIsilonParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredProtectionSourceIsilonParams" /> class.
        /// </summary>
        /// <param name="zoneConfigList">List of access zone info in an Isilion Cluster..</param>
        public RegisteredProtectionSourceIsilonParams(List<ZoneConfig> zoneConfigList = default(List<ZoneConfig>))
        {
            this.ZoneConfigList = zoneConfigList;
            this.ZoneConfigList = zoneConfigList;
        }
        
        /// <summary>
        /// List of access zone info in an Isilion Cluster.
        /// </summary>
        /// <value>List of access zone info in an Isilion Cluster.</value>
        [DataMember(Name="zoneConfigList", EmitDefaultValue=true)]
        public List<ZoneConfig> ZoneConfigList { get; set; }

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
            return this.Equals(input as RegisteredProtectionSourceIsilonParams);
        }

        /// <summary>
        /// Returns true if RegisteredProtectionSourceIsilonParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredProtectionSourceIsilonParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredProtectionSourceIsilonParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneConfigList == input.ZoneConfigList ||
                    this.ZoneConfigList != null &&
                    input.ZoneConfigList != null &&
                    this.ZoneConfigList.SequenceEqual(input.ZoneConfigList)
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
                if (this.ZoneConfigList != null)
                    hashCode = hashCode * 59 + this.ZoneConfigList.GetHashCode();
                return hashCode;
            }
        }

    }

}

