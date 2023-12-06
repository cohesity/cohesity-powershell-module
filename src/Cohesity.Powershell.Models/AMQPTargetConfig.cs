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
    /// AMQPTargetConfig
    /// </summary>
    [DataContract]
    public partial class AMQPTargetConfig :  IEquatable<AMQPTargetConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AMQPTargetConfig" /> class.
        /// </summary>
        /// <param name="certificate">Specifies the certificate..</param>
        /// <param name="exchange">Specifies the exchange..</param>
        /// <param name="filerId">Specifies the filer id..</param>
        /// <param name="password">Specifies the password..</param>
        /// <param name="serverIp">Specifies the server ip..</param>
        /// <param name="username">Specifies the username..</param>
        /// <param name="virtualHost">Specifies the virtual host..</param>
        public AMQPTargetConfig(string certificate = default(string), string exchange = default(string), long? filerId = default(long?), string password = default(string), string serverIp = default(string), string username = default(string), string virtualHost = default(string))
        {
            this.Certificate = certificate;
            this.Exchange = exchange;
            this.FilerId = filerId;
            this.Password = password;
            this.ServerIp = serverIp;
            this.Username = username;
            this.VirtualHost = virtualHost;
            this.Certificate = certificate;
            this.Exchange = exchange;
            this.FilerId = filerId;
            this.Password = password;
            this.ServerIp = serverIp;
            this.Username = username;
            this.VirtualHost = virtualHost;
        }
        
        /// <summary>
        /// Specifies the certificate.
        /// </summary>
        /// <value>Specifies the certificate.</value>
        [DataMember(Name="certificate", EmitDefaultValue=true)]
        public string Certificate { get; set; }

        /// <summary>
        /// Specifies the exchange.
        /// </summary>
        /// <value>Specifies the exchange.</value>
        [DataMember(Name="exchange", EmitDefaultValue=true)]
        public string Exchange { get; set; }

        /// <summary>
        /// Specifies the filer id.
        /// </summary>
        /// <value>Specifies the filer id.</value>
        [DataMember(Name="filerId", EmitDefaultValue=true)]
        public long? FilerId { get; set; }

        /// <summary>
        /// Specifies the password.
        /// </summary>
        /// <value>Specifies the password.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the server ip.
        /// </summary>
        /// <value>Specifies the server ip.</value>
        [DataMember(Name="serverIp", EmitDefaultValue=true)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Specifies the username.
        /// </summary>
        /// <value>Specifies the username.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Specifies the virtual host.
        /// </summary>
        /// <value>Specifies the virtual host.</value>
        [DataMember(Name="virtualHost", EmitDefaultValue=true)]
        public string VirtualHost { get; set; }

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
            return this.Equals(input as AMQPTargetConfig);
        }

        /// <summary>
        /// Returns true if AMQPTargetConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AMQPTargetConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AMQPTargetConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.FilerId == input.FilerId ||
                    (this.FilerId != null &&
                    this.FilerId.Equals(input.FilerId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VirtualHost == input.VirtualHost ||
                    (this.VirtualHost != null &&
                    this.VirtualHost.Equals(input.VirtualHost))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.FilerId != null)
                    hashCode = hashCode * 59 + this.FilerId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VirtualHost != null)
                    hashCode = hashCode * 59 + this.VirtualHost.GetHashCode();
                return hashCode;
            }
        }

    }

}

