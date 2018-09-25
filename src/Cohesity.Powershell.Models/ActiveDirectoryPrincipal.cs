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
    /// Specifies information about a single principal in an Active Directory.
    /// </summary>
    [DataContract]
    public partial class ActiveDirectoryPrincipal :  IEquatable<ActiveDirectoryPrincipal>
    {
        /// <summary>
        /// Specifies the object class of the principal (either &#39;kGroup&#39; or &#39;kUser&#39;). &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.
        /// </summary>
        /// <value>Specifies the object class of the principal (either &#39;kGroup&#39; or &#39;kUser&#39;). &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.</value>
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
        /// Specifies the object class of the principal (either &#39;kGroup&#39; or &#39;kUser&#39;). &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.
        /// </summary>
        /// <value>Specifies the object class of the principal (either &#39;kGroup&#39; or &#39;kUser&#39;). &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=false)]
        public ObjectClassEnum? ObjectClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryPrincipal" /> class.
        /// </summary>
        /// <param name="domain">Specifies the domain name of the where the principal&#39; account is maintained..</param>
        /// <param name="fullName">Specifies the full name (first and last names) of the principal..</param>
        /// <param name="objectClass">Specifies the object class of the principal (either &#39;kGroup&#39; or &#39;kUser&#39;). &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class..</param>
        /// <param name="principalName">Specifies the name of the principal..</param>
        /// <param name="sid">Specifies the unique Security id (SID) of the principal..</param>
        public ActiveDirectoryPrincipal(string domain = default(string), string fullName = default(string), ObjectClassEnum? objectClass = default(ObjectClassEnum?), string principalName = default(string), string sid = default(string))
        {
            this.Domain = domain;
            this.FullName = fullName;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies the domain name of the where the principal&#39; account is maintained.
        /// </summary>
        /// <value>Specifies the domain name of the where the principal&#39; account is maintained.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the full name (first and last names) of the principal.
        /// </summary>
        /// <value>Specifies the full name (first and last names) of the principal.</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }


        /// <summary>
        /// Specifies the name of the principal.
        /// </summary>
        /// <value>Specifies the name of the principal.</value>
        [DataMember(Name="principalName", EmitDefaultValue=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Specifies the unique Security id (SID) of the principal.
        /// </summary>
        /// <value>Specifies the unique Security id (SID) of the principal.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

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
            return this.Equals(input as ActiveDirectoryPrincipal);
        }

        /// <summary>
        /// Returns true if ActiveDirectoryPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveDirectoryPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveDirectoryPrincipal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.ObjectClass != null)
                    hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}

