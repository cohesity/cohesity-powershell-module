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
    /// Specifies the params required to update the user id mapping info of an Active Directory.
    /// </summary>
    [DataContract]
    public partial class IdMappingInfo :  IEquatable<IdMappingInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdMappingInfo" /> class.
        /// </summary>
        /// <param name="fallbackUserIdMappingInfo">fallbackUserIdMappingInfo.</param>
        /// <param name="unixRootSid">Specifies the SID of the Active Directory domain user to be mapped to Unix root user..</param>
        /// <param name="userIdMappingInfo">userIdMappingInfo.</param>
        public IdMappingInfo(UserIdMapping fallbackUserIdMappingInfo = default(UserIdMapping), string unixRootSid = default(string), UserIdMapping userIdMappingInfo = default(UserIdMapping))
        {
            this.UnixRootSid = unixRootSid;
            this.FallbackUserIdMappingInfo = fallbackUserIdMappingInfo;
            this.UnixRootSid = unixRootSid;
            this.UserIdMappingInfo = userIdMappingInfo;
        }
        
        /// <summary>
        /// Gets or Sets FallbackUserIdMappingInfo
        /// </summary>
        [DataMember(Name="fallbackUserIdMappingInfo", EmitDefaultValue=false)]
        public UserIdMapping FallbackUserIdMappingInfo { get; set; }

        /// <summary>
        /// Specifies the SID of the Active Directory domain user to be mapped to Unix root user.
        /// </summary>
        /// <value>Specifies the SID of the Active Directory domain user to be mapped to Unix root user.</value>
        [DataMember(Name="unixRootSid", EmitDefaultValue=true)]
        public string UnixRootSid { get; set; }

        /// <summary>
        /// Gets or Sets UserIdMappingInfo
        /// </summary>
        [DataMember(Name="userIdMappingInfo", EmitDefaultValue=false)]
        public UserIdMapping UserIdMappingInfo { get; set; }

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
            return this.Equals(input as IdMappingInfo);
        }

        /// <summary>
        /// Returns true if IdMappingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IdMappingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdMappingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FallbackUserIdMappingInfo == input.FallbackUserIdMappingInfo ||
                    (this.FallbackUserIdMappingInfo != null &&
                    this.FallbackUserIdMappingInfo.Equals(input.FallbackUserIdMappingInfo))
                ) && 
                (
                    this.UnixRootSid == input.UnixRootSid ||
                    (this.UnixRootSid != null &&
                    this.UnixRootSid.Equals(input.UnixRootSid))
                ) && 
                (
                    this.UserIdMappingInfo == input.UserIdMappingInfo ||
                    (this.UserIdMappingInfo != null &&
                    this.UserIdMappingInfo.Equals(input.UserIdMappingInfo))
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
                if (this.FallbackUserIdMappingInfo != null)
                    hashCode = hashCode * 59 + this.FallbackUserIdMappingInfo.GetHashCode();
                if (this.UnixRootSid != null)
                    hashCode = hashCode * 59 + this.UnixRootSid.GetHashCode();
                if (this.UserIdMappingInfo != null)
                    hashCode = hashCode * 59 + this.UserIdMappingInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

