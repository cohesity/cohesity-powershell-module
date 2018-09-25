// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the join settings for a Microsoft Active Directory domain.
    /// </summary>
    [DataContract]
    public partial class ActiveDirectoryEntry :  IEquatable<ActiveDirectoryEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryEntry" /> class.
        /// </summary>
        /// <param name="domainName">Specifies the fully qualified domain name (FQDN) of an Active Directory..</param>
        /// <param name="fallbackUserIdMappingInfo">Specifies the fallback id mapping info which is used when an ID mapping for a user is not found via the above IdMappingInfo. Only supported for two types of fallback mapping types - &#39;kRid&#39; and &#39;kFixed&#39;..</param>
        /// <param name="machineAccounts">Specifies an array of computer names used to identify the Cohesity Cluster on the domain..</param>
        /// <param name="ouName">Specifies an optional Organizational Unit name..</param>
        /// <param name="password">Specifies the password for the specified userName..</param>
        /// <param name="unixRootSid">Specifies the SID of the Active Directory domain user to be mapped to Unix root user..</param>
        /// <param name="userIdMappingInfo">Specifies the information about how the Unix and Windows users are mapped for this domain..</param>
        /// <param name="userName">Specifies a userName that has administrative privileges in the domain..</param>
        /// <param name="workgroup">Specifies an optional Workgroup name..</param>
        public ActiveDirectoryEntry(string domainName = default(string), UserIdMapping fallbackUserIdMappingInfo = default(UserIdMapping), List<string> machineAccounts = default(List<string>), string ouName = default(string), string password = default(string), string unixRootSid = default(string), UserIdMapping userIdMappingInfo = default(UserIdMapping), string userName = default(string), string workgroup = default(string))
        {
            this.DomainName = domainName;
            this.FallbackUserIdMappingInfo = fallbackUserIdMappingInfo;
            this.MachineAccounts = machineAccounts;
            this.OuName = ouName;
            this.Password = password;
            this.UnixRootSid = unixRootSid;
            this.UserIdMappingInfo = userIdMappingInfo;
            this.UserName = userName;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the fallback id mapping info which is used when an ID mapping for a user is not found via the above IdMappingInfo. Only supported for two types of fallback mapping types - &#39;kRid&#39; and &#39;kFixed&#39;.
        /// </summary>
        /// <value>Specifies the fallback id mapping info which is used when an ID mapping for a user is not found via the above IdMappingInfo. Only supported for two types of fallback mapping types - &#39;kRid&#39; and &#39;kFixed&#39;.</value>
        [DataMember(Name="fallbackUserIdMappingInfo", EmitDefaultValue=false)]
        public UserIdMapping FallbackUserIdMappingInfo { get; set; }

        /// <summary>
        /// Specifies an array of computer names used to identify the Cohesity Cluster on the domain.
        /// </summary>
        /// <value>Specifies an array of computer names used to identify the Cohesity Cluster on the domain.</value>
        [DataMember(Name="machineAccounts", EmitDefaultValue=false)]
        public List<string> MachineAccounts { get; set; }

        /// <summary>
        /// Specifies an optional Organizational Unit name.
        /// </summary>
        /// <value>Specifies an optional Organizational Unit name.</value>
        [DataMember(Name="ouName", EmitDefaultValue=false)]
        public string OuName { get; set; }

        /// <summary>
        /// Specifies the password for the specified userName.
        /// </summary>
        /// <value>Specifies the password for the specified userName.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets TrustedDomains
        /// </summary>
        [DataMember(Name="trustedDomains", EmitDefaultValue=false)]
        public List<string> TrustedDomains { get; private set; }

        /// <summary>
        /// Specifies the SID of the Active Directory domain user to be mapped to Unix root user.
        /// </summary>
        /// <value>Specifies the SID of the Active Directory domain user to be mapped to Unix root user.</value>
        [DataMember(Name="unixRootSid", EmitDefaultValue=false)]
        public string UnixRootSid { get; set; }

        /// <summary>
        /// Specifies the information about how the Unix and Windows users are mapped for this domain.
        /// </summary>
        /// <value>Specifies the information about how the Unix and Windows users are mapped for this domain.</value>
        [DataMember(Name="userIdMappingInfo", EmitDefaultValue=false)]
        public UserIdMapping UserIdMappingInfo { get; set; }

        /// <summary>
        /// Specifies a userName that has administrative privileges in the domain.
        /// </summary>
        /// <value>Specifies a userName that has administrative privileges in the domain.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies an optional Workgroup name.
        /// </summary>
        /// <value>Specifies an optional Workgroup name.</value>
        [DataMember(Name="workgroup", EmitDefaultValue=false)]
        public string Workgroup { get; set; }

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
            return this.Equals(input as ActiveDirectoryEntry);
        }

        /// <summary>
        /// Returns true if ActiveDirectoryEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveDirectoryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveDirectoryEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.FallbackUserIdMappingInfo == input.FallbackUserIdMappingInfo ||
                    (this.FallbackUserIdMappingInfo != null &&
                    this.FallbackUserIdMappingInfo.Equals(input.FallbackUserIdMappingInfo))
                ) && 
                (
                    this.MachineAccounts == input.MachineAccounts ||
                    this.MachineAccounts != null &&
                    this.MachineAccounts.SequenceEqual(input.MachineAccounts)
                ) && 
                (
                    this.OuName == input.OuName ||
                    (this.OuName != null &&
                    this.OuName.Equals(input.OuName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.TrustedDomains == input.TrustedDomains ||
                    this.TrustedDomains != null &&
                    this.TrustedDomains.SequenceEqual(input.TrustedDomains)
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
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Workgroup == input.Workgroup ||
                    (this.Workgroup != null &&
                    this.Workgroup.Equals(input.Workgroup))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.FallbackUserIdMappingInfo != null)
                    hashCode = hashCode * 59 + this.FallbackUserIdMappingInfo.GetHashCode();
                if (this.MachineAccounts != null)
                    hashCode = hashCode * 59 + this.MachineAccounts.GetHashCode();
                if (this.OuName != null)
                    hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TrustedDomains != null)
                    hashCode = hashCode * 59 + this.TrustedDomains.GetHashCode();
                if (this.UnixRootSid != null)
                    hashCode = hashCode * 59 + this.UnixRootSid.GetHashCode();
                if (this.UserIdMappingInfo != null)
                    hashCode = hashCode * 59 + this.UserIdMappingInfo.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
                return hashCode;
            }
        }

    }

}

