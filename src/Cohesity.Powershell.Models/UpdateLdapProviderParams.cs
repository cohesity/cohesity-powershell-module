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
    /// Specifies the params to update the LDAP provider info.
    /// </summary>
    [DataContract]
    public partial class UpdateLdapProviderParams :  IEquatable<UpdateLdapProviderParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLdapProviderParams" /> class.
        /// </summary>
        /// <param name="ldapProviderId">Specifies the LDAP provider id which is mapped to an Active Directory.</param>
        public UpdateLdapProviderParams(long? ldapProviderId = default(long?))
        {
            this.LdapProviderId = ldapProviderId;
            this.LdapProviderId = ldapProviderId;
        }
        
        /// <summary>
        /// Specifies the LDAP provider id which is mapped to an Active Directory
        /// </summary>
        /// <value>Specifies the LDAP provider id which is mapped to an Active Directory</value>
        [DataMember(Name="ldapProviderId", EmitDefaultValue=true)]
        public long? LdapProviderId { get; set; }

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
            return this.Equals(input as UpdateLdapProviderParams);
        }

        /// <summary>
        /// Returns true if UpdateLdapProviderParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLdapProviderParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLdapProviderParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LdapProviderId == input.LdapProviderId ||
                    (this.LdapProviderId != null &&
                    this.LdapProviderId.Equals(input.LdapProviderId))
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
                if (this.LdapProviderId != null)
                    hashCode = hashCode * 59 + this.LdapProviderId.GetHashCode();
                return hashCode;
            }
        }

    }

}

