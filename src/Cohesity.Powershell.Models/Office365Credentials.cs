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
    /// Specifies the credentials to authenticate with Office365 account.
    /// </summary>
    [DataContract]
    public partial class Office365Credentials :  IEquatable<Office365Credentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Office365Credentials" /> class.
        /// </summary>
        /// <param name="clientId">Specifies the application ID that the registration portal (apps.dev.microsoft.com) assigned..</param>
        /// <param name="clientSecret">Specifies the application secret that was created in app registration portal..</param>
        /// <param name="grantType">Specifies the application grant type. eg: For client credentials flow, set this to \&quot;client_credentials\&quot;; For refreshing access-token, set this to \&quot;refresh_token\&quot;..</param>
        /// <param name="scope">Specifies a space separated list of scopes/permissions for the user. eg: Incase of MS Graph APIs for Office365, scope is set to default: https://graph.microsoft.com/.default.</param>
        /// <param name="useOAuthForExchangeOnline">This field is deprecated from here and placed in RegisteredSourceInfo and ProtectionSourceParameters. deprecated: true.</param>
        public Office365Credentials(string clientId = default(string), string clientSecret = default(string), string grantType = default(string), string scope = default(string), bool? useOAuthForExchangeOnline = default(bool?))
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.GrantType = grantType;
            this.Scope = scope;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.GrantType = grantType;
            this.Scope = scope;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
        }
        
        /// <summary>
        /// Specifies the application ID that the registration portal (apps.dev.microsoft.com) assigned.
        /// </summary>
        /// <value>Specifies the application ID that the registration portal (apps.dev.microsoft.com) assigned.</value>
        [DataMember(Name="clientId", EmitDefaultValue=true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies the application secret that was created in app registration portal.
        /// </summary>
        /// <value>Specifies the application secret that was created in app registration portal.</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Specifies the application grant type. eg: For client credentials flow, set this to \&quot;client_credentials\&quot;; For refreshing access-token, set this to \&quot;refresh_token\&quot;.
        /// </summary>
        /// <value>Specifies the application grant type. eg: For client credentials flow, set this to \&quot;client_credentials\&quot;; For refreshing access-token, set this to \&quot;refresh_token\&quot;.</value>
        [DataMember(Name="grantType", EmitDefaultValue=true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Specifies a space separated list of scopes/permissions for the user. eg: Incase of MS Graph APIs for Office365, scope is set to default: https://graph.microsoft.com/.default
        /// </summary>
        /// <value>Specifies a space separated list of scopes/permissions for the user. eg: Incase of MS Graph APIs for Office365, scope is set to default: https://graph.microsoft.com/.default</value>
        [DataMember(Name="scope", EmitDefaultValue=true)]
        public string Scope { get; set; }

        /// <summary>
        /// This field is deprecated from here and placed in RegisteredSourceInfo and ProtectionSourceParameters. deprecated: true
        /// </summary>
        /// <value>This field is deprecated from here and placed in RegisteredSourceInfo and ProtectionSourceParameters. deprecated: true</value>
        [DataMember(Name="useOAuthForExchangeOnline", EmitDefaultValue=true)]
        public bool? UseOAuthForExchangeOnline { get; set; }

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
            return this.Equals(input as Office365Credentials);
        }

        /// <summary>
        /// Returns true if Office365Credentials instances are equal
        /// </summary>
        /// <param name="input">Instance of Office365Credentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office365Credentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.UseOAuthForExchangeOnline == input.UseOAuthForExchangeOnline ||
                    (this.UseOAuthForExchangeOnline != null &&
                    this.UseOAuthForExchangeOnline.Equals(input.UseOAuthForExchangeOnline))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.GrantType != null)
                    hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.UseOAuthForExchangeOnline != null)
                    hashCode = hashCode * 59 + this.UseOAuthForExchangeOnline.GetHashCode();
                return hashCode;
            }
        }

    }

}

