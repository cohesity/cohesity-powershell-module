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
    /// Specifies the join settings for a Microsoft Active Directory domain.
    /// </summary>
    [DataContract]
    public partial class ActiveDirectoryEntry :  IEquatable<ActiveDirectoryEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryEntry" /> class.
        /// </summary>
        /// <param name="domainName">Specifies the fully qualified domain name (FQDN) of an Active Directory..</param>
        /// <param name="fallbackUserIdMappingInfo">fallbackUserIdMappingInfo.</param>
        /// <param name="forceRemove">Specifies if Active Directory entry should be force removed from cluster..</param>
        /// <param name="ignoredTrustedDomains">Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery..</param>
        /// <param name="ldapProviderId">Specifies the LDAP provider id which is map to this Active Directory.</param>
        /// <param name="machineAccounts">Array of Machine Accounts.  Specifies an array of computer names used to identify the Cohesity Cluster on the domain..</param>
        /// <param name="onlyUseWhitelistedDomains">Specifies whether to use &#39;whitelistedDomains&#39; only for authentication..</param>
        /// <param name="ouName">Specifies an optional Organizational Unit name..</param>
        /// <param name="password">Specifies the password for the specified userName..</param>
        /// <param name="preferredDomainControllers">Specifies Map of Active Directory domain names to its preferred domain controllers..</param>
        /// <param name="taskPath">Specifies the task path for AD joining task..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="trustedDomainsEnabled">Specifies whether Trusted Domain discovery is disabled..</param>
        /// <param name="unixRootSid">Specifies the SID of the Active Directory domain user to be mapped to Unix root user..</param>
        /// <param name="userIdMappingInfo">userIdMappingInfo.</param>
        /// <param name="userName">Specifies a userName that has administrative privileges in the domain..</param>
        /// <param name="whitelistedDomains">Specifies the Whitelisted Domains of the Active Directory domain..</param>
        /// <param name="workgroup">Specifies an optional Workgroup name..</param>
        public ActiveDirectoryEntry(string domainName = default(string), UserIdMapping fallbackUserIdMappingInfo = default(UserIdMapping), bool? forceRemove = default(bool?), List<string> ignoredTrustedDomains = default(List<string>), long? ldapProviderId = default(long?), List<string> machineAccounts = default(List<string>), bool? onlyUseWhitelistedDomains = default(bool?), string ouName = default(string), string password = default(string), List<PreferredDomainController> preferredDomainControllers = default(List<PreferredDomainController>), string taskPath = default(string), string tenantId = default(string), bool? trustedDomainsEnabled = default(bool?), string unixRootSid = default(string), UserIdMapping userIdMappingInfo = default(UserIdMapping), string userName = default(string), List<string> whitelistedDomains = default(List<string>), string workgroup = default(string))
        {
            this.DomainName = domainName;
            this.ForceRemove = forceRemove;
            this.IgnoredTrustedDomains = ignoredTrustedDomains;
            this.LdapProviderId = ldapProviderId;
            this.MachineAccounts = machineAccounts;
            this.OnlyUseWhitelistedDomains = onlyUseWhitelistedDomains;
            this.OuName = ouName;
            this.Password = password;
            this.PreferredDomainControllers = preferredDomainControllers;
            this.TaskPath = taskPath;
            this.TenantId = tenantId;
            this.TrustedDomainsEnabled = trustedDomainsEnabled;
            this.UnixRootSid = unixRootSid;
            this.UserName = userName;
            this.WhitelistedDomains = whitelistedDomains;
            this.Workgroup = workgroup;
            this.DomainName = domainName;
            this.FallbackUserIdMappingInfo = fallbackUserIdMappingInfo;
            this.ForceRemove = forceRemove;
            this.IgnoredTrustedDomains = ignoredTrustedDomains;
            this.LdapProviderId = ldapProviderId;
            this.MachineAccounts = machineAccounts;
            this.OnlyUseWhitelistedDomains = onlyUseWhitelistedDomains;
            this.OuName = ouName;
            this.Password = password;
            this.PreferredDomainControllers = preferredDomainControllers;
            this.TaskPath = taskPath;
            this.TenantId = tenantId;
            this.TrustedDomainsEnabled = trustedDomainsEnabled;
            this.UnixRootSid = unixRootSid;
            this.UserIdMappingInfo = userIdMappingInfo;
            this.UserName = userName;
            this.WhitelistedDomains = whitelistedDomains;
            this.Workgroup = workgroup;
        }
        
        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets FallbackUserIdMappingInfo
        /// </summary>
        [DataMember(Name="fallbackUserIdMappingInfo", EmitDefaultValue=false)]
        public UserIdMapping FallbackUserIdMappingInfo { get; set; }

        /// <summary>
        /// Specifies if Active Directory entry should be force removed from cluster.
        /// </summary>
        /// <value>Specifies if Active Directory entry should be force removed from cluster.</value>
        [DataMember(Name="forceRemove", EmitDefaultValue=true)]
        public bool? ForceRemove { get; set; }

        /// <summary>
        /// Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.
        /// </summary>
        /// <value>Specifies the list of trusted domains that were set by the user to be ignored during trusted domain discovery.</value>
        [DataMember(Name="ignoredTrustedDomains", EmitDefaultValue=true)]
        public List<string> IgnoredTrustedDomains { get; set; }

        /// <summary>
        /// Specifies the LDAP provider id which is map to this Active Directory
        /// </summary>
        /// <value>Specifies the LDAP provider id which is map to this Active Directory</value>
        [DataMember(Name="ldapProviderId", EmitDefaultValue=true)]
        public long? LdapProviderId { get; set; }

        /// <summary>
        /// Array of Machine Accounts.  Specifies an array of computer names used to identify the Cohesity Cluster on the domain.
        /// </summary>
        /// <value>Array of Machine Accounts.  Specifies an array of computer names used to identify the Cohesity Cluster on the domain.</value>
        [DataMember(Name="machineAccounts", EmitDefaultValue=true)]
        public List<string> MachineAccounts { get; set; }

        /// <summary>
        /// Specifies whether to use &#39;whitelistedDomains&#39; only for authentication.
        /// </summary>
        /// <value>Specifies whether to use &#39;whitelistedDomains&#39; only for authentication.</value>
        [DataMember(Name="onlyUseWhitelistedDomains", EmitDefaultValue=true)]
        public bool? OnlyUseWhitelistedDomains { get; set; }

        /// <summary>
        /// Specifies an optional Organizational Unit name.
        /// </summary>
        /// <value>Specifies an optional Organizational Unit name.</value>
        [DataMember(Name="ouName", EmitDefaultValue=true)]
        public string OuName { get; set; }

        /// <summary>
        /// Specifies the password for the specified userName.
        /// </summary>
        /// <value>Specifies the password for the specified userName.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies Map of Active Directory domain names to its preferred domain controllers.
        /// </summary>
        /// <value>Specifies Map of Active Directory domain names to its preferred domain controllers.</value>
        [DataMember(Name="preferredDomainControllers", EmitDefaultValue=true)]
        public List<PreferredDomainController> PreferredDomainControllers { get; set; }

        /// <summary>
        /// Specifies the task path for AD joining task.
        /// </summary>
        /// <value>Specifies the task path for AD joining task.</value>
        [DataMember(Name="taskPath", EmitDefaultValue=true)]
        public string TaskPath { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the trusted domains of the Active Directory domain.
        /// </summary>
        /// <value>Specifies the trusted domains of the Active Directory domain.</value>
        [DataMember(Name="trustedDomains", EmitDefaultValue=true)]
        public List<string> TrustedDomains { get; private set; }

        /// <summary>
        /// Specifies whether Trusted Domain discovery is disabled.
        /// </summary>
        /// <value>Specifies whether Trusted Domain discovery is disabled.</value>
        [DataMember(Name="trustedDomainsEnabled", EmitDefaultValue=true)]
        public bool? TrustedDomainsEnabled { get; set; }

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
        /// Specifies a userName that has administrative privileges in the domain.
        /// </summary>
        /// <value>Specifies a userName that has administrative privileges in the domain.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies the Whitelisted Domains of the Active Directory domain.
        /// </summary>
        /// <value>Specifies the Whitelisted Domains of the Active Directory domain.</value>
        [DataMember(Name="whitelistedDomains", EmitDefaultValue=true)]
        public List<string> WhitelistedDomains { get; set; }

        /// <summary>
        /// Specifies an optional Workgroup name.
        /// </summary>
        /// <value>Specifies an optional Workgroup name.</value>
        [DataMember(Name="workgroup", EmitDefaultValue=true)]
        public string Workgroup { get; set; }

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
                    this.ForceRemove == input.ForceRemove ||
                    (this.ForceRemove != null &&
                    this.ForceRemove.Equals(input.ForceRemove))
                ) && 
                (
                    this.IgnoredTrustedDomains == input.IgnoredTrustedDomains ||
                    this.IgnoredTrustedDomains != null &&
                    input.IgnoredTrustedDomains != null &&
                    this.IgnoredTrustedDomains.SequenceEqual(input.IgnoredTrustedDomains)
                ) && 
                (
                    this.LdapProviderId == input.LdapProviderId ||
                    (this.LdapProviderId != null &&
                    this.LdapProviderId.Equals(input.LdapProviderId))
                ) && 
                (
                    this.MachineAccounts == input.MachineAccounts ||
                    this.MachineAccounts != null &&
                    input.MachineAccounts != null &&
                    this.MachineAccounts.SequenceEqual(input.MachineAccounts)
                ) && 
                (
                    this.OnlyUseWhitelistedDomains == input.OnlyUseWhitelistedDomains ||
                    (this.OnlyUseWhitelistedDomains != null &&
                    this.OnlyUseWhitelistedDomains.Equals(input.OnlyUseWhitelistedDomains))
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
                    this.PreferredDomainControllers == input.PreferredDomainControllers ||
                    this.PreferredDomainControllers != null &&
                    input.PreferredDomainControllers != null &&
                    this.PreferredDomainControllers.SequenceEqual(input.PreferredDomainControllers)
                ) && 
                (
                    this.TaskPath == input.TaskPath ||
                    (this.TaskPath != null &&
                    this.TaskPath.Equals(input.TaskPath))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TrustedDomains == input.TrustedDomains ||
                    this.TrustedDomains != null &&
                    input.TrustedDomains != null &&
                    this.TrustedDomains.SequenceEqual(input.TrustedDomains)
                ) && 
                (
                    this.TrustedDomainsEnabled == input.TrustedDomainsEnabled ||
                    (this.TrustedDomainsEnabled != null &&
                    this.TrustedDomainsEnabled.Equals(input.TrustedDomainsEnabled))
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
                    this.WhitelistedDomains == input.WhitelistedDomains ||
                    this.WhitelistedDomains != null &&
                    input.WhitelistedDomains != null &&
                    this.WhitelistedDomains.SequenceEqual(input.WhitelistedDomains)
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
                if (this.ForceRemove != null)
                    hashCode = hashCode * 59 + this.ForceRemove.GetHashCode();
                if (this.IgnoredTrustedDomains != null)
                    hashCode = hashCode * 59 + this.IgnoredTrustedDomains.GetHashCode();
                if (this.LdapProviderId != null)
                    hashCode = hashCode * 59 + this.LdapProviderId.GetHashCode();
                if (this.MachineAccounts != null)
                    hashCode = hashCode * 59 + this.MachineAccounts.GetHashCode();
                if (this.OnlyUseWhitelistedDomains != null)
                    hashCode = hashCode * 59 + this.OnlyUseWhitelistedDomains.GetHashCode();
                if (this.OuName != null)
                    hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PreferredDomainControllers != null)
                    hashCode = hashCode * 59 + this.PreferredDomainControllers.GetHashCode();
                if (this.TaskPath != null)
                    hashCode = hashCode * 59 + this.TaskPath.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TrustedDomains != null)
                    hashCode = hashCode * 59 + this.TrustedDomains.GetHashCode();
                if (this.TrustedDomainsEnabled != null)
                    hashCode = hashCode * 59 + this.TrustedDomainsEnabled.GetHashCode();
                if (this.UnixRootSid != null)
                    hashCode = hashCode * 59 + this.UnixRootSid.GetHashCode();
                if (this.UserIdMappingInfo != null)
                    hashCode = hashCode * 59 + this.UserIdMappingInfo.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.WhitelistedDomains != null)
                    hashCode = hashCode * 59 + this.WhitelistedDomains.GetHashCode();
                if (this.Workgroup != null)
                    hashCode = hashCode * 59 + this.Workgroup.GetHashCode();
                return hashCode;
            }
        }

    }

}

