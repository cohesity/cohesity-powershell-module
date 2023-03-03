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
    /// SessionUser
    /// </summary>
    [DataContract]
    public partial class SessionUser :  IEquatable<SessionUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUser" /> class.
        /// </summary>
        /// <param name="groupSids">SIDs of the groups the user is a member of..</param>
        /// <param name="isNodeInCluster">Whether node is in cluster..</param>
        /// <param name="privileges">Privileges is the array of privileges the current user has..</param>
        /// <param name="user">user.</param>
        public SessionUser(List<string> groupSids = default(List<string>), bool? isNodeInCluster = default(bool?), List<string> privileges = default(List<string>), User user = default(User))
        {
            this.GroupSids = groupSids;
            this.IsNodeInCluster = isNodeInCluster;
            this.Privileges = privileges;
            this.GroupSids = groupSids;
            this.IsNodeInCluster = isNodeInCluster;
            this.Privileges = privileges;
            this.User = user;
        }
        
        /// <summary>
        /// SIDs of the groups the user is a member of.
        /// </summary>
        /// <value>SIDs of the groups the user is a member of.</value>
        [DataMember(Name="groupSids", EmitDefaultValue=true)]
        public List<string> GroupSids { get; set; }

        /// <summary>
        /// Whether node is in cluster.
        /// </summary>
        /// <value>Whether node is in cluster.</value>
        [DataMember(Name="isNodeInCluster", EmitDefaultValue=true)]
        public bool? IsNodeInCluster { get; set; }

        /// <summary>
        /// Privileges is the array of privileges the current user has.
        /// </summary>
        /// <value>Privileges is the array of privileges the current user has.</value>
        [DataMember(Name="privileges", EmitDefaultValue=true)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

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
            return this.Equals(input as SessionUser);
        }

        /// <summary>
        /// Returns true if SessionUser instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupSids == input.GroupSids ||
                    this.GroupSids != null &&
                    input.GroupSids != null &&
                    this.GroupSids.SequenceEqual(input.GroupSids)
                ) && 
                (
                    this.IsNodeInCluster == input.IsNodeInCluster ||
                    (this.IsNodeInCluster != null &&
                    this.IsNodeInCluster.Equals(input.IsNodeInCluster))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    input.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.GroupSids != null)
                    hashCode = hashCode * 59 + this.GroupSids.GetHashCode();
                if (this.IsNodeInCluster != null)
                    hashCode = hashCode * 59 + this.IsNodeInCluster.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }

    }

}

