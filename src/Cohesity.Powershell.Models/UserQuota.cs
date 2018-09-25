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
    /// UserQuota
    /// </summary>
    [DataContract]
    public partial class UserQuota :  IEquatable<UserQuota>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserQuota" /> class.
        /// </summary>
        /// <param name="quotaPolicy">User quota policy applied to this user..</param>
        /// <param name="sid">If interested in a user via smb_client, include SID. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. The string is of following format - S-1-IdentifierAuthority-SubAuthority1-SubAuthority2-...-SubAuthorityn..</param>
        /// <param name="unixUid">If interested in a user via unix-identifier, include UnixUid. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided..</param>
        public UserQuota(QuotaPolicy quotaPolicy = default(QuotaPolicy), string sid = default(string), int? unixUid = default(int?))
        {
            this.QuotaPolicy = quotaPolicy;
            this.Sid = sid;
            this.UnixUid = unixUid;
        }
        
        /// <summary>
        /// User quota policy applied to this user.
        /// </summary>
        /// <value>User quota policy applied to this user.</value>
        [DataMember(Name="quotaPolicy", EmitDefaultValue=false)]
        public QuotaPolicy QuotaPolicy { get; set; }

        /// <summary>
        /// If interested in a user via smb_client, include SID. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. The string is of following format - S-1-IdentifierAuthority-SubAuthority1-SubAuthority2-...-SubAuthorityn.
        /// </summary>
        /// <value>If interested in a user via smb_client, include SID. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. The string is of following format - S-1-IdentifierAuthority-SubAuthority1-SubAuthority2-...-SubAuthorityn.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// If interested in a user via unix-identifier, include UnixUid. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided.
        /// </summary>
        /// <value>If interested in a user via unix-identifier, include UnixUid. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided.</value>
        [DataMember(Name="unixUid", EmitDefaultValue=false)]
        public int? UnixUid { get; set; }

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
            return this.Equals(input as UserQuota);
        }

        /// <summary>
        /// Returns true if UserQuota instances are equal
        /// </summary>
        /// <param name="input">Instance of UserQuota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserQuota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuotaPolicy == input.QuotaPolicy ||
                    (this.QuotaPolicy != null &&
                    this.QuotaPolicy.Equals(input.QuotaPolicy))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.UnixUid == input.UnixUid ||
                    (this.UnixUid != null &&
                    this.UnixUid.Equals(input.UnixUid))
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
                if (this.QuotaPolicy != null)
                    hashCode = hashCode * 59 + this.QuotaPolicy.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.UnixUid != null)
                    hashCode = hashCode * 59 + this.UnixUid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

