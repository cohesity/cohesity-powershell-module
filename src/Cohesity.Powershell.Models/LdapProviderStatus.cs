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
    /// LDAP provider status struct.
    /// </summary>
    [DataContract]
    public partial class LdapProviderStatus :  IEquatable<LdapProviderStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapProviderStatus" /> class.
        /// </summary>
        /// <param name="statusMessage">Specifies the connection status message of an LDAP provider..</param>
        public LdapProviderStatus(string statusMessage = default(string))
        {
            this.StatusMessage = statusMessage;
            this.StatusMessage = statusMessage;
        }
        
        /// <summary>
        /// Specifies the connection status message of an LDAP provider.
        /// </summary>
        /// <value>Specifies the connection status message of an LDAP provider.</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=true)]
        public string StatusMessage { get; set; }

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
            return this.Equals(input as LdapProviderStatus);
        }

        /// <summary>
        /// Returns true if LdapProviderStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of LdapProviderStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LdapProviderStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
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
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                return hashCode;
            }
        }

    }

}

