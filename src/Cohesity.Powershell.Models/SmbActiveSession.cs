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
    /// SmbActiveSession
    /// </summary>
    [DataContract]
    public partial class SmbActiveSession :  IEquatable<SmbActiveSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbActiveSession" /> class.
        /// </summary>
        /// <param name="activeOpens">activeOpens.</param>
        /// <param name="clientIp">Specifies the IP address from which the file is still open..</param>
        /// <param name="domain">Specifies the domain of the user..</param>
        /// <param name="serverIp">Specifies the IP address of the server where the file exists..</param>
        /// <param name="sessionId">Specifies the id of the session..</param>
        /// <param name="username">Specifies the username who keeps the file open..</param>
        public SmbActiveSession(List<SmbActiveOpen> activeOpens = default(List<SmbActiveOpen>), string clientIp = default(string), string domain = default(string), string serverIp = default(string), long? sessionId = default(long?), string username = default(string))
        {
            this.ActiveOpens = activeOpens;
            this.ClientIp = clientIp;
            this.Domain = domain;
            this.ServerIp = serverIp;
            this.SessionId = sessionId;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets ActiveOpens
        /// </summary>
        [DataMember(Name="activeOpens", EmitDefaultValue=false)]
        public List<SmbActiveOpen> ActiveOpens { get; set; }

        /// <summary>
        /// Specifies the IP address from which the file is still open.
        /// </summary>
        /// <value>Specifies the IP address from which the file is still open.</value>
        [DataMember(Name="clientIp", EmitDefaultValue=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Specifies the domain of the user.
        /// </summary>
        /// <value>Specifies the domain of the user.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the IP address of the server where the file exists.
        /// </summary>
        /// <value>Specifies the IP address of the server where the file exists.</value>
        [DataMember(Name="serverIp", EmitDefaultValue=false)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Specifies the id of the session.
        /// </summary>
        /// <value>Specifies the id of the session.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public long? SessionId { get; set; }

        /// <summary>
        /// Specifies the username who keeps the file open.
        /// </summary>
        /// <value>Specifies the username who keeps the file open.</value>
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
            return this.Equals(input as SmbActiveSession);
        }

        /// <summary>
        /// Returns true if SmbActiveSession instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbActiveSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbActiveSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveOpens == input.ActiveOpens ||
                    this.ActiveOpens != null &&
                    this.ActiveOpens.SequenceEqual(input.ActiveOpens)
                ) && 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.ActiveOpens != null)
                    hashCode = hashCode * 59 + this.ActiveOpens.GetHashCode();
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

