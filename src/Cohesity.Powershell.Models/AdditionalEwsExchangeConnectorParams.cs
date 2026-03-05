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
    /// Message that encapsulates the additional connector params for the EWS Exchange environment.
    /// </summary>
    [DataContract]
    public partial class AdditionalEwsExchangeConnectorParams :  IEquatable<AdditionalEwsExchangeConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalEwsExchangeConnectorParams" /> class.
        /// </summary>
        /// <param name="authMethod">The authentication method to be used to login to the server..</param>
        /// <param name="useProxy">Specifies whether to use the cluster config proxy settings..</param>
        public AdditionalEwsExchangeConnectorParams(int? authMethod = default(int?), bool? useProxy = default(bool?))
        {
            this.AuthMethod = authMethod;
            this.UseProxy = useProxy;
            this.AuthMethod = authMethod;
            this.UseProxy = useProxy;
        }
        
        /// <summary>
        /// The authentication method to be used to login to the server.
        /// </summary>
        /// <value>The authentication method to be used to login to the server.</value>
        [DataMember(Name="authMethod", EmitDefaultValue=true)]
        public int? AuthMethod { get; set; }

        /// <summary>
        /// Specifies whether to use the cluster config proxy settings.
        /// </summary>
        /// <value>Specifies whether to use the cluster config proxy settings.</value>
        [DataMember(Name="useProxy", EmitDefaultValue=true)]
        public bool? UseProxy { get; set; }

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
            return this.Equals(input as AdditionalEwsExchangeConnectorParams);
        }

        /// <summary>
        /// Returns true if AdditionalEwsExchangeConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalEwsExchangeConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalEwsExchangeConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
                ) && 
                (
                    this.UseProxy == input.UseProxy ||
                    (this.UseProxy != null &&
                    this.UseProxy.Equals(input.UseProxy))
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
                if (this.AuthMethod != null)
                    hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.UseProxy != null)
                    hashCode = hashCode * 59 + this.UseProxy.GetHashCode();
                return hashCode;
            }
        }

    }

}

