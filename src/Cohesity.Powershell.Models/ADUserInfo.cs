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
    /// Specifies an AD User&#39;s information logged in using an active directory. This information is not stored on the Cluster.
    /// </summary>
    [DataContract]
    public partial class ADUserInfo :  IEquatable<ADUserInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADUserInfo" /> class.
        /// </summary>
        /// <param name="groupSids">Specifies the SIDs of the groups..</param>
        /// <param name="groups">Specifies the groups this user is a part of..</param>
        /// <param name="isFloatingUser">Specifies whether this is a floating user or not..</param>
        public ADUserInfo(List<string> groupSids = default(List<string>), List<string> groups = default(List<string>), bool? isFloatingUser = default(bool?))
        {
            this.GroupSids = groupSids;
            this.Groups = groups;
            this.IsFloatingUser = isFloatingUser;
            this.GroupSids = groupSids;
            this.Groups = groups;
            this.IsFloatingUser = isFloatingUser;
        }
        
        /// <summary>
        /// Specifies the SIDs of the groups.
        /// </summary>
        /// <value>Specifies the SIDs of the groups.</value>
        [DataMember(Name="groupSids", EmitDefaultValue=true)]
        public List<string> GroupSids { get; set; }

        /// <summary>
        /// Specifies the groups this user is a part of.
        /// </summary>
        /// <value>Specifies the groups this user is a part of.</value>
        [DataMember(Name="groups", EmitDefaultValue=true)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Specifies whether this is a floating user or not.
        /// </summary>
        /// <value>Specifies whether this is a floating user or not.</value>
        [DataMember(Name="isFloatingUser", EmitDefaultValue=true)]
        public bool? IsFloatingUser { get; set; }

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
            return this.Equals(input as ADUserInfo);
        }

        /// <summary>
        /// Returns true if ADUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ADUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADUserInfo input)
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
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.IsFloatingUser == input.IsFloatingUser ||
                    (this.IsFloatingUser != null &&
                    this.IsFloatingUser.Equals(input.IsFloatingUser))
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IsFloatingUser != null)
                    hashCode = hashCode * 59 + this.IsFloatingUser.GetHashCode();
                return hashCode;
            }
        }

    }

}

