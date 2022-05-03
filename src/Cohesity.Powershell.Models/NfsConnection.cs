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
    /// NfsConnection
    /// </summary>
    [DataContract]
    public partial class NfsConnection :  IEquatable<NfsConnection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsConnection" /> class.
        /// </summary>
        /// <param name="clientIp">Specifies the Client IP address of the connection..</param>
        /// <param name="nodeIp">Specifies a Node IP address where the connection request is received..</param>
        /// <param name="serverIp">Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster..</param>
        /// <param name="viewId">Specifies the id of the view..</param>
        /// <param name="viewName">Specifies the name of the view..</param>
        public NfsConnection(string clientIp = default(string), string nodeIp = default(string), string serverIp = default(string), long? viewId = default(long?), string viewName = default(string))
        {
            this.ClientIp = clientIp;
            this.NodeIp = nodeIp;
            this.ServerIp = serverIp;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the Client IP address of the connection.
        /// </summary>
        /// <value>Specifies the Client IP address of the connection.</value>
        [DataMember(Name="clientIp", EmitDefaultValue=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Specifies a Node IP address where the connection request is received.
        /// </summary>
        /// <value>Specifies a Node IP address where the connection request is received.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=false)]
        public string NodeIp { get; set; }

        /// <summary>
        /// Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster.
        /// </summary>
        /// <value>Specifies the Server IP address of the connection. This could be a VIP, VLAN IP, or node IP on the Cluster.</value>
        [DataMember(Name="serverIp", EmitDefaultValue=false)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Specifies the id of the view.
        /// </summary>
        /// <value>Specifies the id of the view.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies the name of the view.
        /// </summary>
        /// <value>Specifies the name of the view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
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
            return this.Equals(input as NfsConnection);
        }

        /// <summary>
        /// Returns true if NfsConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsConnection input)
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
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
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
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

