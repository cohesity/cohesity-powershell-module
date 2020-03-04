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
    /// Specifies the parameters required to reset the S3 secret access key for the specified Cohesity user.
    /// </summary>
    [DataContract]
    public partial class ResetS3SecretKeyParameters :  IEquatable<ResetS3SecretKeyParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetS3SecretKeyParameters" /> class.
        /// </summary>
        /// <param name="domain">Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. If not specified, it is assumed to be LOCAL..</param>
        /// <param name="tenantId">Specifies the tenant for which the users are to be deleted..</param>
        /// <param name="username">Specifies the Cohesity user..</param>
        public ResetS3SecretKeyParameters(string domain = default(string), string tenantId = default(string), string username = default(string))
        {
            this.Domain = domain;
            this.TenantId = tenantId;
            this.Username = username;
            this.Domain = domain;
            this.TenantId = tenantId;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. If not specified, it is assumed to be LOCAL.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. If not specified, it is assumed to be LOCAL.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the tenant for which the users are to be deleted.
        /// </summary>
        /// <value>Specifies the tenant for which the users are to be deleted.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the Cohesity user.
        /// </summary>
        /// <value>Specifies the Cohesity user.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
            return this.Equals(input as ResetS3SecretKeyParameters);
        }

        /// <summary>
        /// Returns true if ResetS3SecretKeyParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ResetS3SecretKeyParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetS3SecretKeyParameters input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

