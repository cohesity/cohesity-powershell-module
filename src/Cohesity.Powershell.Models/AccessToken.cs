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
    /// Specifies an Access Token that provides permissions for a client to access the Cohesity REST API available from a Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class AccessToken :  IEquatable<AccessToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessToken" /> class.
        /// </summary>
        /// <param name="accessToken">Generated access token..</param>
        /// <param name="privileges">Privileges for the user..</param>
        /// <param name="tokenType">Access token type..</param>
        public AccessToken(string accessToken = default(string), List<string> privileges = default(List<string>), string tokenType = default(string))
        {
            this._AccessToken = accessToken;
            this.Privileges = privileges;
            this.TokenType = tokenType;
            this._AccessToken = accessToken;
            this.Privileges = privileges;
            this.TokenType = tokenType;
        }
        
        /// <summary>
        /// Generated access token.
        /// </summary>
        /// <value>Generated access token.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=true)]
        public string _AccessToken { get; set; }

        /// <summary>
        /// Privileges for the user.
        /// </summary>
        /// <value>Privileges for the user.</value>
        [DataMember(Name="privileges", EmitDefaultValue=true)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// Access token type.
        /// </summary>
        /// <value>Access token type.</value>
        [DataMember(Name="tokenType", EmitDefaultValue=true)]
        public string TokenType { get; set; }

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
            return this.Equals(input as AccessToken);
        }

        /// <summary>
        /// Returns true if AccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._AccessToken == input._AccessToken ||
                    (this._AccessToken != null &&
                    this._AccessToken.Equals(input._AccessToken))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    input.Privileges != null &&
                    this.Privileges.Equals(input.Privileges)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this._AccessToken != null)
                    hashCode = hashCode * 59 + this._AccessToken.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                return hashCode;
            }
        }

    }

}

