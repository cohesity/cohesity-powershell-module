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
    /// Specifies the user input parameters.
    /// </summary>
    [DataContract]
    public partial class UpdateLinuxPasswordReqParams :  IEquatable<UpdateLinuxPasswordReqParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLinuxPasswordReqParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateLinuxPasswordReqParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLinuxPasswordReqParams" /> class.
        /// </summary>
		/// <param name="clusterId">If cluster ID is specified, then the password is updated for all the nodes in the cluster. Optional Field..</param>
        /// <param name="linuxCurrentPassword">Specifies the current password..</param>
        /// <param name="linuxPassword">Specifies the new linux password. (required).</param>
        /// <param name="linuxUsername">Specifies the linux username for which the password will be updated. (required).</param>
        /// <param name="nodeIps">Specifies the node IP address on which the linux password will be updated. Optional Field..</param>
		/// <param name="verifyPassword">True if request is only to verify if current password matches with set password..</param>
        public UpdateLinuxPasswordReqParams(long? clusterId = default(long?), string linuxCurrentPassword = default(string), string linuxPassword = default(string), string linuxUsername = default(string), List<string> nodeIps = default(List<string>), bool? verifyPassword = default(bool?))
        {
            this.ClusterId = clusterId;
            this.LinuxPassword = linuxPassword;
            this.LinuxUsername = linuxUsername;
            this.NodeIps = nodeIps;
        }
		
		/// <summary>
        /// If cluster ID is specified, then the password is updated for all the nodes in the cluster. Optional Field.
        /// </summary>
        /// <value>If cluster ID is specified, then the password is updated for all the nodes in the cluster. Optional Field.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }
        
        /// <summary>
        /// Specifies the current password.
        /// </summary>
        /// <value>Specifies the current password.</value>
        [DataMember(Name="linuxCurrentPassword", EmitDefaultValue=true)]
        public string LinuxCurrentPassword { get; set; }

        /// <summary>
        /// Specifies the new linux password.
        /// </summary>
        /// <value>Specifies the new linux password.</value>
        [DataMember(Name="linuxPassword", EmitDefaultValue=true)]
        public string LinuxPassword { get; set; }

        /// <summary>
        /// Specifies the linux username for which the password will be updated.
        /// </summary>
        /// <value>Specifies the linux username for which the password will be updated.</value>
        [DataMember(Name="linuxUsername", EmitDefaultValue=true)]
        public string LinuxUsername { get; set; }
		
		/// <summary>
        /// Specifies the node IP address on which the linux password will be updated. Optional Field.
        /// </summary>
        /// <value>Specifies the node IP address on which the linux password will be updated. Optional Field.</value>
        [DataMember(Name="nodeIps", EmitDefaultValue=true)]
        public List<string> NodeIps { get; set; }

        /// <summary>
        /// True if request is only to verify if current password matches with set password.
        /// </summary>
        /// <value>True if request is only to verify if current password matches with set password.</value>
        [DataMember(Name="verifyPassword", EmitDefaultValue=true)]
        public bool? VerifyPassword { get; set; }

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
            return this.Equals(input as UpdateLinuxPasswordReqParams);
        }

        /// <summary>
        /// Returns true if UpdateLinuxPasswordReqParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLinuxPasswordReqParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLinuxPasswordReqParams input)
        {
            if (input == null)
                return false;

            return 
			    (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.LinuxCurrentPassword == input.LinuxCurrentPassword ||
                    (this.LinuxCurrentPassword != null &&
                    this.LinuxCurrentPassword.Equals(input.LinuxCurrentPassword))
                ) && 
                (
                    this.LinuxPassword == input.LinuxPassword ||
                    (this.LinuxPassword != null &&
                    this.LinuxPassword.Equals(input.LinuxPassword))
                ) && 
                (
                    this.LinuxUsername == input.LinuxUsername ||
                    (this.LinuxUsername != null &&
                    this.LinuxUsername.Equals(input.LinuxUsername))
                ) && 
                (
                    this.NodeIps == input.NodeIps ||
                    this.NodeIps != null &&
                    input.NodeIps != null &&
                    this.NodeIps.SequenceEqual(input.NodeIps)
                ) && 
                (
                    this.VerifyPassword == input.VerifyPassword ||
                    (this.VerifyPassword != null &&
                    this.VerifyPassword.Equals(input.VerifyPassword))
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
				if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.LinuxCurrentPassword != null)
                    hashCode = hashCode * 59 + this.LinuxCurrentPassword.GetHashCode();
                if (this.LinuxPassword != null)
                    hashCode = hashCode * 59 + this.LinuxPassword.GetHashCode();
                if (this.LinuxUsername != null)
                    hashCode = hashCode * 59 + this.LinuxUsername.GetHashCode();
				if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                if (this.VerifyPassword != null)
                    hashCode = hashCode * 59 + this.VerifyPassword.GetHashCode();
                return hashCode;
            }
        }

    }

}

