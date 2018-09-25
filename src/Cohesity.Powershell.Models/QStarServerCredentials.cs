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
    /// Specifies the server credentials to connect to a QStar service to manage the media Vault.
    /// </summary>
    [DataContract]
    public partial class QStarServerCredentials :  IEquatable<QStarServerCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QStarServerCredentials" /> class.
        /// </summary>
        /// <param name="host">Specifies the IP address or DNS name of the server where QStar service is running..</param>
        /// <param name="integralVolumeNames">Specifies a list of existing Integral Volume names available on the QStar server for storing objects..</param>
        /// <param name="password">Specifies the password used to access the QStar host..</param>
        /// <param name="port">Specifies the listening port where QStar WEB API service is running..</param>
        /// <param name="shareType">Specifies the sharing protocol type used by QStar to mount the integral volume. See the Cohesity online help for the recommended protocol for your environment..</param>
        /// <param name="useHttps">Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used..</param>
        /// <param name="username">Specifies the account name used to access the QStar host..</param>
        public QStarServerCredentials(string host = default(string), List<string> integralVolumeNames = default(List<string>), string password = default(string), int? port = default(int?), string shareType = default(string), bool? useHttps = default(bool?), string username = default(string))
        {
            this.Host = host;
            this.IntegralVolumeNames = integralVolumeNames;
            this.Password = password;
            this.Port = port;
            this.ShareType = shareType;
            this.UseHttps = useHttps;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the IP address or DNS name of the server where QStar service is running.
        /// </summary>
        /// <value>Specifies the IP address or DNS name of the server where QStar service is running.</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Specifies a list of existing Integral Volume names available on the QStar server for storing objects.
        /// </summary>
        /// <value>Specifies a list of existing Integral Volume names available on the QStar server for storing objects.</value>
        [DataMember(Name="integralVolumeNames", EmitDefaultValue=false)]
        public List<string> IntegralVolumeNames { get; set; }

        /// <summary>
        /// Specifies the password used to access the QStar host.
        /// </summary>
        /// <value>Specifies the password used to access the QStar host.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the listening port where QStar WEB API service is running.
        /// </summary>
        /// <value>Specifies the listening port where QStar WEB API service is running.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Specifies the sharing protocol type used by QStar to mount the integral volume. See the Cohesity online help for the recommended protocol for your environment.
        /// </summary>
        /// <value>Specifies the sharing protocol type used by QStar to mount the integral volume. See the Cohesity online help for the recommended protocol for your environment.</value>
        [DataMember(Name="shareType", EmitDefaultValue=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used.
        /// </summary>
        /// <value>Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used.</value>
        [DataMember(Name="useHttps", EmitDefaultValue=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// Specifies the account name used to access the QStar host.
        /// </summary>
        /// <value>Specifies the account name used to access the QStar host.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as QStarServerCredentials);
        }

        /// <summary>
        /// Returns true if QStarServerCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of QStarServerCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QStarServerCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.IntegralVolumeNames == input.IntegralVolumeNames ||
                    this.IntegralVolumeNames != null &&
                    this.IntegralVolumeNames.SequenceEqual(input.IntegralVolumeNames)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.ShareType == input.ShareType ||
                    (this.ShareType != null &&
                    this.ShareType.Equals(input.ShareType))
                ) && 
                (
                    this.UseHttps == input.UseHttps ||
                    (this.UseHttps != null &&
                    this.UseHttps.Equals(input.UseHttps))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.IntegralVolumeNames != null)
                    hashCode = hashCode * 59 + this.IntegralVolumeNames.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ShareType != null)
                    hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.UseHttps != null)
                    hashCode = hashCode * 59 + this.UseHttps.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

