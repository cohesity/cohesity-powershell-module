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
    /// Specifies information required to connect to CAP to get AWS credentials. C2SAccessPortal(CAP) is AWS commercial cloud service access portal.
    /// </summary>
    [DataContract]
    public partial class C2SAccessPortal :  IEquatable<C2SAccessPortal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="C2SAccessPortal" /> class.
        /// </summary>
        /// <param name="agency">Name of the agency..</param>
        /// <param name="baseUrl">The base url of C2S CAP server..</param>
        /// <param name="clientCertificatePassword">Encrypted password of the client private key..</param>
        /// <param name="mission">Name of the mission..</param>
        /// <param name="role">Role type..</param>
        public C2SAccessPortal(string agency = default(string), string baseUrl = default(string), string clientCertificatePassword = default(string), string mission = default(string), string role = default(string))
        {
            this.Agency = agency;
            this.BaseUrl = baseUrl;
            this.ClientCertificatePassword = clientCertificatePassword;
            this.Mission = mission;
            this.Role = role;
        }
        
        /// <summary>
        /// Name of the agency.
        /// </summary>
        /// <value>Name of the agency.</value>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }

        /// <summary>
        /// The base url of C2S CAP server.
        /// </summary>
        /// <value>The base url of C2S CAP server.</value>
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Encrypted password of the client private key.
        /// </summary>
        /// <value>Encrypted password of the client private key.</value>
        [DataMember(Name="clientCertificatePassword", EmitDefaultValue=false)]
        public string ClientCertificatePassword { get; set; }

        /// <summary>
        /// Name of the mission.
        /// </summary>
        /// <value>Name of the mission.</value>
        [DataMember(Name="mission", EmitDefaultValue=false)]
        public string Mission { get; set; }

        /// <summary>
        /// Role type.
        /// </summary>
        /// <value>Role type.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

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
            return this.Equals(input as C2SAccessPortal);
        }

        /// <summary>
        /// Returns true if C2SAccessPortal instances are equal
        /// </summary>
        /// <param name="input">Instance of C2SAccessPortal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(C2SAccessPortal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agency == input.Agency ||
                    (this.Agency != null &&
                    this.Agency.Equals(input.Agency))
                ) && 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
                ) && 
                (
                    this.ClientCertificatePassword == input.ClientCertificatePassword ||
                    (this.ClientCertificatePassword != null &&
                    this.ClientCertificatePassword.Equals(input.ClientCertificatePassword))
                ) && 
                (
                    this.Mission == input.Mission ||
                    (this.Mission != null &&
                    this.Mission.Equals(input.Mission))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Agency != null)
                    hashCode = hashCode * 59 + this.Agency.GetHashCode();
                if (this.BaseUrl != null)
                    hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.ClientCertificatePassword != null)
                    hashCode = hashCode * 59 + this.ClientCertificatePassword.GetHashCode();
                if (this.Mission != null)
                    hashCode = hashCode * 59 + this.Mission.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                return hashCode;
            }
        }

    }

}

