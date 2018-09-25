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
    /// Specifies the settings for adding new users and groups for Active Directory principals. These users and groups are added to the Cohesity Cluster. You cannot create users and groups in the default Cohesity domain called &#39;LOCAL&#39; using this operation.
    /// </summary>
    [DataContract]
    public partial class ActiveDirectoryPrincipalsAddParameters :  IEquatable<ActiveDirectoryPrincipalsAddParameters>
    {
        /// <summary>
        /// Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.
        /// </summary>
        /// <value>Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.</value>
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
            KGroup = 2
        }

        /// <summary>
        /// Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.
        /// </summary>
        /// <value>Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=false)]
        public ObjectClassEnum? ObjectClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryPrincipalsAddParameters" /> class.
        /// </summary>
        /// <param name="description">Specifies a description about the user or group..</param>
        /// <param name="domain">Specifies the domain of the Active Directory where the referenced principal is stored..</param>
        /// <param name="objectClass">Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class..</param>
        /// <param name="principalName">Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster..</param>
        /// <param name="restricted">Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to..</param>
        /// <param name="roles">Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster..</param>
        public ActiveDirectoryPrincipalsAddParameters(string description = default(string), string domain = default(string), ObjectClassEnum? objectClass = default(ObjectClassEnum?), string principalName = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>))
        {
            this.Description = description;
            this.Domain = domain;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Restricted = restricted;
            this.Roles = roles;
        }
        
        /// <summary>
        /// Specifies a description about the user or group.
        /// </summary>
        /// <value>Specifies a description about the user or group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the domain of the Active Directory where the referenced principal is stored.
        /// </summary>
        /// <value>Specifies the domain of the Active Directory where the referenced principal is stored.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }


        /// <summary>
        /// Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster.</value>
        [DataMember(Name="principalName", EmitDefaultValue=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

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
            return this.Equals(input as ActiveDirectoryPrincipalsAddParameters);
        }

        /// <summary>
        /// Returns true if ActiveDirectoryPrincipalsAddParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveDirectoryPrincipalsAddParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveDirectoryPrincipalsAddParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.ObjectClass == input.ObjectClass ||
                    (this.ObjectClass != null &&
                    this.ObjectClass.Equals(input.ObjectClass))
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
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.ObjectClass != null)
                    hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }

    }

}

