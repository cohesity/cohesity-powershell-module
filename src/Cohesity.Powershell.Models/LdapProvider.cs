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
    /// Specifies the configuration settings for an LDAP provider.
    /// </summary>
    [DataContract]
    public partial class LdapProvider :  IEquatable<LdapProvider>
    {
        /// <summary>
        /// Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;
        /// </summary>
        /// <value>Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum KAnonymous for value: kAnonymous
            /// </summary>
            [EnumMember(Value = "kAnonymous")]
            KAnonymous = 1,

            /// <summary>
            /// Enum KSimple for value: kSimple
            /// </summary>
            [EnumMember(Value = "kSimple")]
            KSimple = 2

        }

        /// <summary>
        /// Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;
        /// </summary>
        /// <value>Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;</value>
        [DataMember(Name="authType", EmitDefaultValue=true)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapProvider" /> class.
        /// </summary>
        /// <param name="adDomainName">Specifies the domain name of an Active Directory which is mapped to this LDAP provider.</param>
        /// <param name="authType">Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;.</param>
        /// <param name="baseDistinguishedName">Specifies the base distinguished name used as the base for LDAP search requests..</param>
        /// <param name="domainName">Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored..</param>
        /// <param name="name">Specifies the name of the LDAP provider..</param>
        /// <param name="port">Specifies LDAP server port..</param>
        /// <param name="preferredLdapServerList">Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="useSsl">Specifies whether to use SSL for LDAP connections..</param>
        /// <param name="userDistinguishedName">Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl..</param>
        /// <param name="userPassword">Specifies the user password that is used for LDAP authentication..</param>
        public LdapProvider(string adDomainName = default(string), AuthTypeEnum? authType = default(AuthTypeEnum?), string baseDistinguishedName = default(string), string domainName = default(string), string name = default(string), int? port = default(int?), List<string> preferredLdapServerList = default(List<string>), string tenantId = default(string), bool? useSsl = default(bool?), string userDistinguishedName = default(string), string userPassword = default(string))
        {
            this.AdDomainName = adDomainName;
            this.AuthType = authType;
            this.BaseDistinguishedName = baseDistinguishedName;
            this.DomainName = domainName;
            this.Name = name;
            this.Port = port;
            this.PreferredLdapServerList = preferredLdapServerList;
            this.TenantId = tenantId;
            this.UseSsl = useSsl;
            this.UserDistinguishedName = userDistinguishedName;
            this.UserPassword = userPassword;
            this.AdDomainName = adDomainName;
            this.AuthType = authType;
            this.BaseDistinguishedName = baseDistinguishedName;
            this.DomainName = domainName;
            this.Name = name;
            this.Port = port;
            this.PreferredLdapServerList = preferredLdapServerList;
            this.TenantId = tenantId;
            this.UseSsl = useSsl;
            this.UserDistinguishedName = userDistinguishedName;
            this.UserPassword = userPassword;
        }
        
        /// <summary>
        /// Specifies the domain name of an Active Directory which is mapped to this LDAP provider
        /// </summary>
        /// <value>Specifies the domain name of an Active Directory which is mapped to this LDAP provider</value>
        [DataMember(Name="adDomainName", EmitDefaultValue=true)]
        public string AdDomainName { get; set; }

        /// <summary>
        /// Specifies the base distinguished name used as the base for LDAP search requests.
        /// </summary>
        /// <value>Specifies the base distinguished name used as the base for LDAP search requests.</value>
        [DataMember(Name="baseDistinguishedName", EmitDefaultValue=true)]
        public string BaseDistinguishedName { get; set; }

        /// <summary>
        /// Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored.
        /// </summary>
        /// <value>Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the name of the LDAP provider.
        /// </summary>
        /// <value>Specifies the name of the LDAP provider.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies LDAP server port.
        /// </summary>
        /// <value>Specifies LDAP server port.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

        /// <summary>
        /// Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses.
        /// </summary>
        /// <value>Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses.</value>
        [DataMember(Name="preferredLdapServerList", EmitDefaultValue=true)]
        public List<string> PreferredLdapServerList { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies whether to use SSL for LDAP connections.
        /// </summary>
        /// <value>Specifies whether to use SSL for LDAP connections.</value>
        [DataMember(Name="useSsl", EmitDefaultValue=true)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl.
        /// </summary>
        /// <value>Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl.</value>
        [DataMember(Name="userDistinguishedName", EmitDefaultValue=true)]
        public string UserDistinguishedName { get; set; }

        /// <summary>
        /// Specifies the user password that is used for LDAP authentication.
        /// </summary>
        /// <value>Specifies the user password that is used for LDAP authentication.</value>
        [DataMember(Name="userPassword", EmitDefaultValue=true)]
        public string UserPassword { get; set; }

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
            return this.Equals(input as LdapProvider);
        }

        /// <summary>
        /// Returns true if LdapProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapProvider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdDomainName == input.AdDomainName ||
                    (this.AdDomainName != null &&
                    this.AdDomainName.Equals(input.AdDomainName))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.BaseDistinguishedName == input.BaseDistinguishedName ||
                    (this.BaseDistinguishedName != null &&
                    this.BaseDistinguishedName.Equals(input.BaseDistinguishedName))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.PreferredLdapServerList == input.PreferredLdapServerList ||
                    this.PreferredLdapServerList != null &&
                    input.PreferredLdapServerList != null &&
                    this.PreferredLdapServerList.SequenceEqual(input.PreferredLdapServerList)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.UseSsl == input.UseSsl ||
                    (this.UseSsl != null &&
                    this.UseSsl.Equals(input.UseSsl))
                ) && 
                (
                    this.UserDistinguishedName == input.UserDistinguishedName ||
                    (this.UserDistinguishedName != null &&
                    this.UserDistinguishedName.Equals(input.UserDistinguishedName))
                ) && 
                (
                    this.UserPassword == input.UserPassword ||
                    (this.UserPassword != null &&
                    this.UserPassword.Equals(input.UserPassword))
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
                if (this.AdDomainName != null)
                    hashCode = hashCode * 59 + this.AdDomainName.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.BaseDistinguishedName != null)
                    hashCode = hashCode * 59 + this.BaseDistinguishedName.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PreferredLdapServerList != null)
                    hashCode = hashCode * 59 + this.PreferredLdapServerList.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UseSsl != null)
                    hashCode = hashCode * 59 + this.UseSsl.GetHashCode();
                if (this.UserDistinguishedName != null)
                    hashCode = hashCode * 59 + this.UserDistinguishedName.GetHashCode();
                if (this.UserPassword != null)
                    hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                return hashCode;
            }
        }

    }

}

