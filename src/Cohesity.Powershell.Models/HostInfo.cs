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
    /// Specifies the list of all hosts on which the certificate is deployed.
    /// </summary>
    [DataContract]
    public partial class HostInfo :  IEquatable<HostInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostInfo" /> class.
        /// </summary>
        /// <param name="password">Specifies the password of the host to establish SSH connection. The certificate is copied to the host after generating the certificate on the cluster..</param>
        /// <param name="serverName">Specifies the servername of the host where certificate is to be deployed..</param>
        /// <param name="target">Specifies the target location on the host where the certificate is deployed..</param>
        /// <param name="userName">Specifies the username of the host..</param>
        public HostInfo(string password = default(string), string serverName = default(string), string target = default(string), string userName = default(string))
        {
            this.Password = password;
            this.ServerName = serverName;
            this.Target = target;
            this.UserName = userName;
            this.Password = password;
            this.ServerName = serverName;
            this.Target = target;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Specifies the password of the host to establish SSH connection. The certificate is copied to the host after generating the certificate on the cluster.
        /// </summary>
        /// <value>Specifies the password of the host to establish SSH connection. The certificate is copied to the host after generating the certificate on the cluster.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the servername of the host where certificate is to be deployed.
        /// </summary>
        /// <value>Specifies the servername of the host where certificate is to be deployed.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

        /// <summary>
        /// Specifies the target location on the host where the certificate is deployed.
        /// </summary>
        /// <value>Specifies the target location on the host where the certificate is deployed.</value>
        [DataMember(Name="target", EmitDefaultValue=true)]
        public string Target { get; set; }

        /// <summary>
        /// Specifies the username of the host.
        /// </summary>
        /// <value>Specifies the username of the host.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

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
            return this.Equals(input as HostInfo);
        }

        /// <summary>
        /// Returns true if HostInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HostInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

    }

}

