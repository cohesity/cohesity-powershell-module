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
    /// Specifies the update LDAP provider params.
    /// </summary>
    [DataContract]
    public partial class UpdateLdapProviderParam :  IEquatable<UpdateLdapProviderParam>
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
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLdapProviderParam" /> class.
        /// </summary>
        /// <param name="adDomainName">Specifies the domain name of an Active Directory which is mapped to this LDAP provider.</param>
        /// <param name="attributeCommonName">Name of the LDAP attribute used for common name of an object..</param>
        /// <param name="attributeGid">Name of the attribute used to lookup unix GID of an LDAP user..</param>
        /// <param name="attributeMemberOf">Name of the LDAP attribute used to lookup members of a group..</param>
        /// <param name="attributeUid">Name of the attribute used to lookup unix UID of an LDAP user..</param>
        /// <param name="attributeUserName">Name of the LDAP attribute used to lookup a user by user ID..</param>
        /// <param name="authType">Specifies the authentication type used while connecting to LDAP servers. Authentication level. &#39;kAnonymous&#39; indicates LDAP authentication type &#39;Anonymous&#39; &#39;kSimple&#39; indicates LDAP authentication type &#39;Simple&#39;.</param>
        /// <param name="baseDistinguishedName">Specifies the base distinguished name used as the base for LDAP search requests..</param>
        /// <param name="domainName">Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored..</param>
        /// <param name="id">Specifies the ID of the LDAP provider..</param>
        /// <param name="name">Specifies the name of the LDAP provider..</param>
        /// <param name="objectClassGroup">Name of the LDAP group object class for user accounts..</param>
        /// <param name="objectClassUser">Name of the LDAP user object class for user accounts..</param>
        /// <param name="port">Specifies LDAP server port..</param>
        /// <param name="preferredLdapServerList">Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="useSsl">Specifies whether to use SSL for LDAP connections..</param>
        /// <param name="userDistinguishedName">Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl..</param>
        /// <param name="userPassword">Specifies the user password that is used for LDAP authentication..</param>
        public UpdateLdapProviderParam(string adDomainName = default(string), string attributeCommonName = default(string), string attributeGid = default(string), string attributeMemberOf = default(string), string attributeUid = default(string), string attributeUserName = default(string), AuthTypeEnum? authType = default(AuthTypeEnum?), string baseDistinguishedName = default(string), string domainName = default(string), long? id = default(long?), string name = default(string), string objectClassGroup = default(string), string objectClassUser = default(string), int? port = default(int?), List<string> preferredLdapServerList = default(List<string>), string tenantId = default(string), bool? useSsl = default(bool?), string userDistinguishedName = default(string), string userPassword = default(string))
        {
            this.AdDomainName = adDomainName;
            this.AttributeCommonName = attributeCommonName;
            this.AttributeGid = attributeGid;
            this.AttributeMemberOf = attributeMemberOf;
            this.AttributeUid = attributeUid;
            this.AttributeUserName = attributeUserName;
            this.AuthType = authType;
            this.BaseDistinguishedName = baseDistinguishedName;
            this.DomainName = domainName;
            this.Id = id;
            this.Name = name;
            this.ObjectClassGroup = objectClassGroup;
            this.ObjectClassUser = objectClassUser;
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
        [DataMember(Name="adDomainName", EmitDefaultValue=false)]
        public string AdDomainName { get; set; }

        /// <summary>
        /// Name of the LDAP attribute used for common name of an object.
        /// </summary>
        /// <value>Name of the LDAP attribute used for common name of an object.</value>
        [DataMember(Name="attributeCommonName", EmitDefaultValue=false)]
        public string AttributeCommonName { get; set; }

        /// <summary>
        /// Name of the attribute used to lookup unix GID of an LDAP user.
        /// </summary>
        /// <value>Name of the attribute used to lookup unix GID of an LDAP user.</value>
        [DataMember(Name="attributeGid", EmitDefaultValue=false)]
        public string AttributeGid { get; set; }

        /// <summary>
        /// Name of the LDAP attribute used to lookup members of a group.
        /// </summary>
        /// <value>Name of the LDAP attribute used to lookup members of a group.</value>
        [DataMember(Name="attributeMemberOf", EmitDefaultValue=false)]
        public string AttributeMemberOf { get; set; }

        /// <summary>
        /// Name of the attribute used to lookup unix UID of an LDAP user.
        /// </summary>
        /// <value>Name of the attribute used to lookup unix UID of an LDAP user.</value>
        [DataMember(Name="attributeUid", EmitDefaultValue=false)]
        public string AttributeUid { get; set; }

        /// <summary>
        /// Name of the LDAP attribute used to lookup a user by user ID.
        /// </summary>
        /// <value>Name of the LDAP attribute used to lookup a user by user ID.</value>
        [DataMember(Name="attributeUserName", EmitDefaultValue=false)]
        public string AttributeUserName { get; set; }


        /// <summary>
        /// Specifies the base distinguished name used as the base for LDAP search requests.
        /// </summary>
        /// <value>Specifies the base distinguished name used as the base for LDAP search requests.</value>
        [DataMember(Name="baseDistinguishedName", EmitDefaultValue=false)]
        public string BaseDistinguishedName { get; set; }

        /// <summary>
        /// Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored.
        /// </summary>
        /// <value>Specifies the name of the domain name to be used for querying LDAP servers from DNS. If PreferredLdapServerList is set, then DomainName field is ignored.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the ID of the LDAP provider.
        /// </summary>
        /// <value>Specifies the ID of the LDAP provider.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the LDAP provider.
        /// </summary>
        /// <value>Specifies the name of the LDAP provider.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the LDAP group object class for user accounts.
        /// </summary>
        /// <value>Name of the LDAP group object class for user accounts.</value>
        [DataMember(Name="objectClassGroup", EmitDefaultValue=false)]
        public string ObjectClassGroup { get; set; }

        /// <summary>
        /// Name of the LDAP user object class for user accounts.
        /// </summary>
        /// <value>Name of the LDAP user object class for user accounts.</value>
        [DataMember(Name="objectClassUser", EmitDefaultValue=false)]
        public string ObjectClassUser { get; set; }

        /// <summary>
        /// Specifies LDAP server port.
        /// </summary>
        /// <value>Specifies LDAP server port.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses.
        /// </summary>
        /// <value>Specifies the preferred LDAP servers. Server names should be either in fully qualified domain name (FQDN) format or IP addresses.</value>
        [DataMember(Name="preferredLdapServerList", EmitDefaultValue=false)]
        public List<string> PreferredLdapServerList { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies whether to use SSL for LDAP connections.
        /// </summary>
        /// <value>Specifies whether to use SSL for LDAP connections.</value>
        [DataMember(Name="useSsl", EmitDefaultValue=false)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl.
        /// </summary>
        /// <value>Specifies the user distinguished name that is used for LDAP authentication. It should be provided if the AuthType is set to either kSimple or kSasl.</value>
        [DataMember(Name="userDistinguishedName", EmitDefaultValue=false)]
        public string UserDistinguishedName { get; set; }

        /// <summary>
        /// Specifies the user password that is used for LDAP authentication.
        /// </summary>
        /// <value>Specifies the user password that is used for LDAP authentication.</value>
        [DataMember(Name="userPassword", EmitDefaultValue=false)]
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
            return this.Equals(input as UpdateLdapProviderParam);
        }

        /// <summary>
        /// Returns true if UpdateLdapProviderParam instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLdapProviderParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLdapProviderParam input)
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
                    this.AttributeCommonName == input.AttributeCommonName ||
                    (this.AttributeCommonName != null &&
                    this.AttributeCommonName.Equals(input.AttributeCommonName))
                ) && 
                (
                    this.AttributeGid == input.AttributeGid ||
                    (this.AttributeGid != null &&
                    this.AttributeGid.Equals(input.AttributeGid))
                ) && 
                (
                    this.AttributeMemberOf == input.AttributeMemberOf ||
                    (this.AttributeMemberOf != null &&
                    this.AttributeMemberOf.Equals(input.AttributeMemberOf))
                ) && 
                (
                    this.AttributeUid == input.AttributeUid ||
                    (this.AttributeUid != null &&
                    this.AttributeUid.Equals(input.AttributeUid))
                ) && 
                (
                    this.AttributeUserName == input.AttributeUserName ||
                    (this.AttributeUserName != null &&
                    this.AttributeUserName.Equals(input.AttributeUserName))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ObjectClassGroup == input.ObjectClassGroup ||
                    (this.ObjectClassGroup != null &&
                    this.ObjectClassGroup.Equals(input.ObjectClassGroup))
                ) && 
                (
                    this.ObjectClassUser == input.ObjectClassUser ||
                    (this.ObjectClassUser != null &&
                    this.ObjectClassUser.Equals(input.ObjectClassUser))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.PreferredLdapServerList == input.PreferredLdapServerList ||
                    this.PreferredLdapServerList != null &&
                    this.PreferredLdapServerList.Equals(input.PreferredLdapServerList)
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
                if (this.AttributeCommonName != null)
                    hashCode = hashCode * 59 + this.AttributeCommonName.GetHashCode();
                if (this.AttributeGid != null)
                    hashCode = hashCode * 59 + this.AttributeGid.GetHashCode();
                if (this.AttributeMemberOf != null)
                    hashCode = hashCode * 59 + this.AttributeMemberOf.GetHashCode();
                if (this.AttributeUid != null)
                    hashCode = hashCode * 59 + this.AttributeUid.GetHashCode();
                if (this.AttributeUserName != null)
                    hashCode = hashCode * 59 + this.AttributeUserName.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.BaseDistinguishedName != null)
                    hashCode = hashCode * 59 + this.BaseDistinguishedName.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObjectClassGroup != null)
                    hashCode = hashCode * 59 + this.ObjectClassGroup.GetHashCode();
                if (this.ObjectClassUser != null)
                    hashCode = hashCode * 59 + this.ObjectClassUser.GetHashCode();
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

