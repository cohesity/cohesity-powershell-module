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
    /// SmbConnection
    /// </summary>
    [DataContract]
    public partial class SmbConnection :  IEquatable<SmbConnection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbConnection" /> class.
        /// </summary>
        /// <param name="clientIp">Specifies the Client IP address of the connection..</param>
        /// <param name="domainName">Domain name of the corresponding user..</param>
        /// <param name="nodeIp">Specifies a Node IP address where the connection request is received..</param>
        /// <param name="path">Mount path..</param>
        /// <param name="serverIp">Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster..</param>
        /// <param name="sessionId">Session id..</param>
        /// <param name="sids">List of SIDs in the SMB session token..</param>
        /// <param name="userName">User name used to login for this session..</param>
        /// <param name="viewId">Specifies the id of the view..</param>
        /// <param name="viewName">Specifies the name of the view..</param>
        public SmbConnection(string clientIp = default(string), string domainName = default(string), string nodeIp = default(string), string path = default(string), string serverIp = default(string), long? sessionId = default(long?), List<string> sids = default(List<string>), string userName = default(string), long? viewId = default(long?), string viewName = default(string))
        {
            this.ClientIp = clientIp;
            this.DomainName = domainName;
            this.NodeIp = nodeIp;
            this.Path = path;
            this.ServerIp = serverIp;
            this.SessionId = sessionId;
            this.Sids = sids;
            this.UserName = userName;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the Client IP address of the connection.
        /// </summary>
        /// <value>Specifies the Client IP address of the connection.</value>
        [DataMember(Name="clientIp", EmitDefaultValue=true)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Domain name of the corresponding user.
        /// </summary>
        /// <value>Domain name of the corresponding user.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies a Node IP address where the connection request is received.
        /// </summary>
        /// <value>Specifies a Node IP address where the connection request is received.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=true)]
        public string NodeIp { get; set; }

        /// <summary>
        /// Mount path.
        /// </summary>
        /// <value>Mount path.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster.
        /// </summary>
        /// <value>Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster.</value>
        [DataMember(Name="serverIp", EmitDefaultValue=true)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Session id.
        /// </summary>
        /// <value>Session id.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=true)]
        public long? SessionId { get; set; }

        /// <summary>
        /// List of SIDs in the SMB session token.
        /// </summary>
        /// <value>List of SIDs in the SMB session token.</value>
        [DataMember(Name="sids", EmitDefaultValue=true)]
        public List<string> Sids { get; set; }

        /// <summary>
        /// User name used to login for this session.
        /// </summary>
        /// <value>User name used to login for this session.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies the id of the view.
        /// </summary>
        /// <value>Specifies the id of the view.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies the name of the view.
        /// </summary>
        /// <value>Specifies the name of the view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as SmbConnection);
        }

        /// <summary>
        /// Returns true if SmbConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbConnection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                    this.Sids == input.Sids ||
                    this.Sids != null &&
                    input.Sids != null &&
                    this.Sids.Equals(input.Sids)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Sids != null)
                    hashCode = hashCode * 59 + this.Sids.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

