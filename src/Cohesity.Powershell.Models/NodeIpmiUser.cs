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
    /// NodeIpmiUser
    /// </summary>
    [DataContract]
    public partial class NodeIpmiUser :  IEquatable<NodeIpmiUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeIpmiUser" /> class.
        /// </summary>
        /// <param name="ipmiPassword">In request, IPMI password is entered by the user. In response, it is is set to empty and hence will be omitted..</param>
        /// <param name="ipmiUser">ipmiUser.</param>
        /// <param name="nodeIp">nodeIp.</param>
        public NodeIpmiUser(string ipmiPassword = default(string), string ipmiUser = default(string), string nodeIp = default(string))
        {
            this.IpmiPassword = ipmiPassword;
            this.IpmiUser = ipmiUser;
            this.NodeIp = nodeIp;
        }
        
        /// <summary>
        /// In request, IPMI password is entered by the user. In response, it is is set to empty and hence will be omitted.
        /// </summary>
        /// <value>In request, IPMI password is entered by the user. In response, it is is set to empty and hence will be omitted.</value>
        [DataMember(Name="ipmiPassword", EmitDefaultValue=false)]
        public string IpmiPassword { get; set; }

        /// <summary>
        /// Gets or Sets IpmiUser
        /// </summary>
        [DataMember(Name="ipmiUser", EmitDefaultValue=false)]
        public string IpmiUser { get; set; }

        /// <summary>
        /// Gets or Sets NodeIp
        /// </summary>
        [DataMember(Name="nodeIp", EmitDefaultValue=false)]
        public string NodeIp { get; set; }

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
            return this.Equals(input as NodeIpmiUser);
        }

        /// <summary>
        /// Returns true if NodeIpmiUser instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeIpmiUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeIpmiUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpmiPassword == input.IpmiPassword ||
                    (this.IpmiPassword != null &&
                    this.IpmiPassword.Equals(input.IpmiPassword))
                ) && 
                (
                    this.IpmiUser == input.IpmiUser ||
                    (this.IpmiUser != null &&
                    this.IpmiUser.Equals(input.IpmiUser))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
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
                if (this.IpmiPassword != null)
                    hashCode = hashCode * 59 + this.IpmiPassword.GetHashCode();
                if (this.IpmiUser != null)
                    hashCode = hashCode * 59 + this.IpmiUser.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                return hashCode;
            }
        }

    }

}

