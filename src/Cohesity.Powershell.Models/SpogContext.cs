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
    /// SpogContext specifies all of the information about the user and cluster which is performing action on this cluster.
    /// </summary>
    [DataContract]
    public partial class SpogContext :  IEquatable<SpogContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpogContext" /> class.
        /// </summary>
        /// <param name="primaryClusterId">Specifies the ID of the remote cluster which is accessing this cluster via SPOG..</param>
        /// <param name="primaryClusterUserSid">Specifies the SID of the user who is accessing this cluster via SPOG..</param>
        /// <param name="primaryClusterUsername">Specifies the username of the user who is accessing this cluster via SPOG..</param>
        public SpogContext(long? primaryClusterId = default(long?), string primaryClusterUserSid = default(string), string primaryClusterUsername = default(string))
        {
            this.PrimaryClusterId = primaryClusterId;
            this.PrimaryClusterUserSid = primaryClusterUserSid;
            this.PrimaryClusterUsername = primaryClusterUsername;
            this.PrimaryClusterId = primaryClusterId;
            this.PrimaryClusterUserSid = primaryClusterUserSid;
            this.PrimaryClusterUsername = primaryClusterUsername;
        }
        
        /// <summary>
        /// Specifies the ID of the remote cluster which is accessing this cluster via SPOG.
        /// </summary>
        /// <value>Specifies the ID of the remote cluster which is accessing this cluster via SPOG.</value>
        [DataMember(Name="PrimaryClusterId", EmitDefaultValue=true)]
        public long? PrimaryClusterId { get; set; }

        /// <summary>
        /// Specifies the SID of the user who is accessing this cluster via SPOG.
        /// </summary>
        /// <value>Specifies the SID of the user who is accessing this cluster via SPOG.</value>
        [DataMember(Name="PrimaryClusterUserSid", EmitDefaultValue=true)]
        public string PrimaryClusterUserSid { get; set; }

        /// <summary>
        /// Specifies the username of the user who is accessing this cluster via SPOG.
        /// </summary>
        /// <value>Specifies the username of the user who is accessing this cluster via SPOG.</value>
        [DataMember(Name="PrimaryClusterUsername", EmitDefaultValue=true)]
        public string PrimaryClusterUsername { get; set; }

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
            return this.Equals(input as SpogContext);
        }

        /// <summary>
        /// Returns true if SpogContext instances are equal
        /// </summary>
        /// <param name="input">Instance of SpogContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpogContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryClusterId == input.PrimaryClusterId ||
                    (this.PrimaryClusterId != null &&
                    this.PrimaryClusterId.Equals(input.PrimaryClusterId))
                ) && 
                (
                    this.PrimaryClusterUserSid == input.PrimaryClusterUserSid ||
                    (this.PrimaryClusterUserSid != null &&
                    this.PrimaryClusterUserSid.Equals(input.PrimaryClusterUserSid))
                ) && 
                (
                    this.PrimaryClusterUsername == input.PrimaryClusterUsername ||
                    (this.PrimaryClusterUsername != null &&
                    this.PrimaryClusterUsername.Equals(input.PrimaryClusterUsername))
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
                if (this.PrimaryClusterId != null)
                    hashCode = hashCode * 59 + this.PrimaryClusterId.GetHashCode();
                if (this.PrimaryClusterUserSid != null)
                    hashCode = hashCode * 59 + this.PrimaryClusterUserSid.GetHashCode();
                if (this.PrimaryClusterUsername != null)
                    hashCode = hashCode * 59 + this.PrimaryClusterUsername.GetHashCode();
                return hashCode;
            }
        }

    }

}

