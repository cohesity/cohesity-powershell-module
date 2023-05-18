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
    /// Specifies the Node Id, IP and port information to access the postgres database.
    /// </summary>
    [DataContract]
    public partial class PostgresNodeInfo :  IEquatable<PostgresNodeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresNodeInfo" /> class.
        /// </summary>
        /// <param name="defaultPassword">Specifies the default password to access the postgres database..</param>
        /// <param name="defaultUsername">Specifies the default username to access the postgres database..</param>
        /// <param name="nodeId">Specifies the id of the node where postgres database is running..</param>
        /// <param name="nodeIp">Specifies the ip of the node where postgres database is running..</param>
        /// <param name="port">Specifies the information where postgres database is running..</param>
        public PostgresNodeInfo(string defaultPassword = default(string), string defaultUsername = default(string), long? nodeId = default(long?), string nodeIp = default(string), int? port = default(int?))
        {
            this.DefaultPassword = defaultPassword;
            this.DefaultUsername = defaultUsername;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.Port = port;
            this.DefaultPassword = defaultPassword;
            this.DefaultUsername = defaultUsername;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.Port = port;
        }
        
        /// <summary>
        /// Specifies the default password to access the postgres database.
        /// </summary>
        /// <value>Specifies the default password to access the postgres database.</value>
        [DataMember(Name="defaultPassword", EmitDefaultValue=true)]
        public string DefaultPassword { get; set; }

        /// <summary>
        /// Specifies the default username to access the postgres database.
        /// </summary>
        /// <value>Specifies the default username to access the postgres database.</value>
        [DataMember(Name="defaultUsername", EmitDefaultValue=true)]
        public string DefaultUsername { get; set; }

        /// <summary>
        /// Specifies the id of the node where postgres database is running.
        /// </summary>
        /// <value>Specifies the id of the node where postgres database is running.</value>
        [DataMember(Name="nodeId", EmitDefaultValue=true)]
        public long? NodeId { get; set; }

        /// <summary>
        /// Specifies the ip of the node where postgres database is running.
        /// </summary>
        /// <value>Specifies the ip of the node where postgres database is running.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=true)]
        public string NodeIp { get; set; }

        /// <summary>
        /// Specifies the information where postgres database is running.
        /// </summary>
        /// <value>Specifies the information where postgres database is running.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

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
            return this.Equals(input as PostgresNodeInfo);
        }

        /// <summary>
        /// Returns true if PostgresNodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PostgresNodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostgresNodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultPassword == input.DefaultPassword ||
                    (this.DefaultPassword != null &&
                    this.DefaultPassword.Equals(input.DefaultPassword))
                ) && 
                (
                    this.DefaultUsername == input.DefaultUsername ||
                    (this.DefaultUsername != null &&
                    this.DefaultUsername.Equals(input.DefaultUsername))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.DefaultPassword != null)
                    hashCode = hashCode * 59 + this.DefaultPassword.GetHashCode();
                if (this.DefaultUsername != null)
                    hashCode = hashCode * 59 + this.DefaultUsername.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

