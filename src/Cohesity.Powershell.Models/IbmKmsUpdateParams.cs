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
    /// IbmKmsUpdateParams
    /// </summary>
    [DataContract]
    public partial class IbmKmsUpdateParams :  IEquatable<IbmKmsUpdateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IbmKmsUpdateParams" /> class.
        /// </summary>
        /// <param name="apiKey">This will be set iff the auth_type is APIKey..</param>
        /// <param name="authType">Specifies the authentication type to be used for API calls..</param>
        /// <param name="tenantCrn">This will be set iff the auth_type is TrustedProfileWithS2S..</param>
        /// <param name="trustedProfileId">This will be set iff the auth_type is TrustedProfile..</param>
        public IbmKmsUpdateParams(string apiKey = default(string), string authType = default(string), string tenantCrn = default(string), string trustedProfileId = default(string))
        {
            this.ApiKey = apiKey;
            this.AuthType = authType;
            this.TenantCrn = tenantCrn;
            this.TrustedProfileId = trustedProfileId;
            this.ApiKey = apiKey;
            this.AuthType = authType;
            this.TenantCrn = tenantCrn;
            this.TrustedProfileId = trustedProfileId;
        }
        
        /// <summary>
        /// This will be set iff the auth_type is APIKey.
        /// </summary>
        /// <value>This will be set iff the auth_type is APIKey.</value>
        [DataMember(Name="apiKey", EmitDefaultValue=true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Specifies the authentication type to be used for API calls.
        /// </summary>
        /// <value>Specifies the authentication type to be used for API calls.</value>
        [DataMember(Name="authType", EmitDefaultValue=true)]
        public string AuthType { get; set; }

        /// <summary>
        /// This will be set iff the auth_type is TrustedProfileWithS2S.
        /// </summary>
        /// <value>This will be set iff the auth_type is TrustedProfileWithS2S.</value>
        [DataMember(Name="tenantCrn", EmitDefaultValue=true)]
        public string TenantCrn { get; set; }

        /// <summary>
        /// This will be set iff the auth_type is TrustedProfile.
        /// </summary>
        /// <value>This will be set iff the auth_type is TrustedProfile.</value>
        [DataMember(Name="trustedProfileId", EmitDefaultValue=true)]
        public string TrustedProfileId { get; set; }

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
            return this.Equals(input as IbmKmsUpdateParams);
        }

        /// <summary>
        /// Returns true if IbmKmsUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of IbmKmsUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IbmKmsUpdateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.TenantCrn == input.TenantCrn ||
                    (this.TenantCrn != null &&
                    this.TenantCrn.Equals(input.TenantCrn))
                ) && 
                (
                    this.TrustedProfileId == input.TrustedProfileId ||
                    (this.TrustedProfileId != null &&
                    this.TrustedProfileId.Equals(input.TrustedProfileId))
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
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.TenantCrn != null)
                    hashCode = hashCode * 59 + this.TenantCrn.GetHashCode();
                if (this.TrustedProfileId != null)
                    hashCode = hashCode * 59 + this.TrustedProfileId.GetHashCode();
                return hashCode;
            }
        }

    }

}

