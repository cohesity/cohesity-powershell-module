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
    /// Specifies struct with basic group details.
    /// </summary>
    [DataContract]
    public partial class GroupInfo :  IEquatable<GroupInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupInfo" /> class.
        /// </summary>
        /// <param name="domain">Specifies domain name of the user..</param>
        /// <param name="groupName">Specifies group name of the group..</param>
        /// <param name="sid">Specifies unique Security ID (SID) of the user..</param>
        public GroupInfo(string domain = default(string), string groupName = default(string), string sid = default(string))
        {
            this.Domain = domain;
            this.GroupName = groupName;
            this.Sid = sid;
            this.Domain = domain;
            this.GroupName = groupName;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies domain name of the user.
        /// </summary>
        /// <value>Specifies domain name of the user.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies group name of the group.
        /// </summary>
        /// <value>Specifies group name of the group.</value>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Specifies unique Security ID (SID) of the user.
        /// </summary>
        /// <value>Specifies unique Security ID (SID) of the user.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupInfo {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as GroupInfo);
        }

        /// <summary>
        /// Returns true if GroupInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}
