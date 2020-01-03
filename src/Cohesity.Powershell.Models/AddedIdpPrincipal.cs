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
    /// Specifies a group or user added to the Cohesity Cluster for an Idp principal.
    /// </summary>
    [DataContract]
    public partial class AddedIdpPrincipal :  IEquatable<AddedIdpPrincipal>
    {
        /// <summary>
        /// Specifies the type of the referenced Idp principal. If &#39;kGroup&#39;, the referenced Idp principal is a group. If &#39;kUser&#39;, the referenced Idp principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class. &#39;kWellKnownPrincipal&#39; specifies a well known principal.
        /// </summary>
        /// <value>Specifies the type of the referenced Idp principal. If &#39;kGroup&#39;, the referenced Idp principal is a group. If &#39;kUser&#39;, the referenced Idp principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class. &#39;kWellKnownPrincipal&#39; specifies a well known principal.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectClassEnum
        {
            /// <summary>
            /// Enum KUser for value: kUser
            /// </summary>
            [EnumMember(Value = "kUser")]
            KUser = 1,

            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 2,

            /// <summary>
            /// Enum KComputer for value: kComputer
            /// </summary>
            [EnumMember(Value = "kComputer")]
            KComputer = 3,

            /// <summary>
            /// Enum KWellKnownPrincipal for value: kWellKnownPrincipal
            /// </summary>
            [EnumMember(Value = "kWellKnownPrincipal")]
            KWellKnownPrincipal = 4

        }

        /// <summary>
        /// Specifies the type of the referenced Idp principal. If &#39;kGroup&#39;, the referenced Idp principal is a group. If &#39;kUser&#39;, the referenced Idp principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class. &#39;kWellKnownPrincipal&#39; specifies a well known principal.
        /// </summary>
        /// <value>Specifies the type of the referenced Idp principal. If &#39;kGroup&#39;, the referenced Idp principal is a group. If &#39;kUser&#39;, the referenced Idp principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class. &#39;kWellKnownPrincipal&#39; specifies a well known principal.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=true)]
        public ObjectClassEnum? ObjectClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedIdpPrincipal" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster..</param>
        /// <param name="domain">Specifies the name of the Idp where the referenced principal is stored..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster..</param>
        /// <param name="objectClass">Specifies the type of the referenced Idp principal. If &#39;kGroup&#39;, the referenced Idp principal is a group. If &#39;kUser&#39;, the referenced Idp principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class. &#39;kWellKnownPrincipal&#39; specifies a well known principal..</param>
        /// <param name="principalName">Specifies the name of the Idp principal, that will be referenced by the group or user. The name of the Idp principal is used for naming the new group or user on the Cohesity Cluster..</param>
        /// <param name="restricted">Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to..</param>
        /// <param name="roles">Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster..</param>
        /// <param name="sid">Specifies the unique Security ID (SID) of the Idp principal associated with this group or user..</param>
        public AddedIdpPrincipal(long? createdTimeMsecs = default(long?), string domain = default(string), long? lastUpdatedTimeMsecs = default(long?), ObjectClassEnum? objectClass = default(ObjectClassEnum?), string principalName = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>), string sid = default(string))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Domain = domain;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Sid = sid;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Domain = domain;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the name of the Idp where the referenced principal is stored.
        /// </summary>
        /// <value>Specifies the name of the Idp where the referenced principal is stored.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the name of the Idp principal, that will be referenced by the group or user. The name of the Idp principal is used for naming the new group or user on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Idp principal, that will be referenced by the group or user. The name of the Idp principal is used for naming the new group or user on the Cohesity Cluster.</value>
        [DataMember(Name="principalName", EmitDefaultValue=true)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=true)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.
        /// </summary>
        /// <value>Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the unique Security ID (SID) of the Idp principal associated with this group or user.
        /// </summary>
        /// <value>Specifies the unique Security ID (SID) of the Idp principal associated with this group or user.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

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
            return this.Equals(input as AddedIdpPrincipal);
        }

        /// <summary>
        /// Returns true if AddedIdpPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of AddedIdpPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddedIdpPrincipal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.ObjectClass == input.ObjectClass ||
                    this.ObjectClass.Equals(input.ObjectClass)
                ) && 
                (
                    this.PrincipalName == input.PrincipalName ||
                    (this.PrincipalName != null &&
                    this.PrincipalName.Equals(input.PrincipalName))
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}

