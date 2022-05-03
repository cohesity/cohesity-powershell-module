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
    /// Specifies the cluster level IPMI user credentials and/or Node level IPMI user credentials.
    /// </summary>
    [DataContract]
    public partial class ClusterUpdateIpmiUsersParameters :  IEquatable<ClusterUpdateIpmiUsersParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterUpdateIpmiUsersParameters" /> class.
        /// </summary>
        /// <param name="clusterIpmiUser">Cluster level IPMI User name..</param>
        /// <param name="ipmiPassword">Cluster level IPMI Password..</param>
        /// <param name="nodeIpmiUsers">Node level IPMI User config..</param>
        public ClusterUpdateIpmiUsersParameters(string clusterIpmiUser = default(string), string ipmiPassword = default(string), List<NodeIpmiUser> nodeIpmiUsers = default(List<NodeIpmiUser>))
        {
            this.ClusterIpmiUser = clusterIpmiUser;
            this.IpmiPassword = ipmiPassword;
            this.NodeIpmiUsers = nodeIpmiUsers;
        }
        
        /// <summary>
        /// Cluster level IPMI User name.
        /// </summary>
        /// <value>Cluster level IPMI User name.</value>
        [DataMember(Name="clusterIpmiUser", EmitDefaultValue=false)]
        public string ClusterIpmiUser { get; set; }

        /// <summary>
        /// Cluster level IPMI Password.
        /// </summary>
        /// <value>Cluster level IPMI Password.</value>
        [DataMember(Name="ipmiPassword", EmitDefaultValue=false)]
        public string IpmiPassword { get; set; }

        /// <summary>
        /// Node level IPMI User config.
        /// </summary>
        /// <value>Node level IPMI User config.</value>
        [DataMember(Name="nodeIpmiUsers", EmitDefaultValue=false)]
        public List<NodeIpmiUser> NodeIpmiUsers { get; set; }

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
            return this.Equals(input as ClusterUpdateIpmiUsersParameters);
        }

        /// <summary>
        /// Returns true if ClusterUpdateIpmiUsersParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterUpdateIpmiUsersParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterUpdateIpmiUsersParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterIpmiUser == input.ClusterIpmiUser ||
                    (this.ClusterIpmiUser != null &&
                    this.ClusterIpmiUser.Equals(input.ClusterIpmiUser))
                ) && 
                (
                    this.IpmiPassword == input.IpmiPassword ||
                    (this.IpmiPassword != null &&
                    this.IpmiPassword.Equals(input.IpmiPassword))
                ) && 
                (
                    this.NodeIpmiUsers == input.NodeIpmiUsers ||
                    this.NodeIpmiUsers != null &&
                    this.NodeIpmiUsers.Equals(input.NodeIpmiUsers)
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
                if (this.ClusterIpmiUser != null)
                    hashCode = hashCode * 59 + this.ClusterIpmiUser.GetHashCode();
                if (this.IpmiPassword != null)
                    hashCode = hashCode * 59 + this.IpmiPassword.GetHashCode();
                if (this.NodeIpmiUsers != null)
                    hashCode = hashCode * 59 + this.NodeIpmiUsers.GetHashCode();
                return hashCode;
            }
        }

    }

}

