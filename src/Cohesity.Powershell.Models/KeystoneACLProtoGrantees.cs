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
    /// KeystoneACLProtoGrantees
    /// </summary>
    [DataContract]
    public partial class KeystoneACLProtoGrantees :  IEquatable<KeystoneACLProtoGrantees>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeystoneACLProtoGrantees" /> class.
        /// </summary>
        /// <param name="allUsers">This field indicates if all users are granted ACL permission..</param>
        /// <param name="projectIdVec">This field holds a list of Keystone project ids whose users are granted ACL permission..</param>
        /// <param name="projectUsersMap">projectUsersMap.</param>
        /// <param name="roleNameVec">This field holds a list of Keystone roles for which any Keystone user with one (or more) of the roles on the project containing the swift container holding this KeystoneACLProto is granted ACL permission..</param>
        /// <param name="userIdVec">This field holds a list of keystone user ids who are granted ACL permission..</param>
        public KeystoneACLProtoGrantees(bool? allUsers = default(bool?), List<string> projectIdVec = default(List<string>), List<KeystoneACLProtoGranteesProjectUsersMapEntry> projectUsersMap = default(List<KeystoneACLProtoGranteesProjectUsersMapEntry>), List<string> roleNameVec = default(List<string>), List<string> userIdVec = default(List<string>))
        {
            this.AllUsers = allUsers;
            this.ProjectIdVec = projectIdVec;
            this.ProjectUsersMap = projectUsersMap;
            this.RoleNameVec = roleNameVec;
            this.UserIdVec = userIdVec;
        }
        
        /// <summary>
        /// This field indicates if all users are granted ACL permission.
        /// </summary>
        /// <value>This field indicates if all users are granted ACL permission.</value>
        [DataMember(Name="allUsers", EmitDefaultValue=false)]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// This field holds a list of Keystone project ids whose users are granted ACL permission.
        /// </summary>
        /// <value>This field holds a list of Keystone project ids whose users are granted ACL permission.</value>
        [DataMember(Name="projectIdVec", EmitDefaultValue=false)]
        public List<string> ProjectIdVec { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUsersMap
        /// </summary>
        [DataMember(Name="projectUsersMap", EmitDefaultValue=false)]
        public List<KeystoneACLProtoGranteesProjectUsersMapEntry> ProjectUsersMap { get; set; }

        /// <summary>
        /// This field holds a list of Keystone roles for which any Keystone user with one (or more) of the roles on the project containing the swift container holding this KeystoneACLProto is granted ACL permission.
        /// </summary>
        /// <value>This field holds a list of Keystone roles for which any Keystone user with one (or more) of the roles on the project containing the swift container holding this KeystoneACLProto is granted ACL permission.</value>
        [DataMember(Name="roleNameVec", EmitDefaultValue=false)]
        public List<string> RoleNameVec { get; set; }

        /// <summary>
        /// This field holds a list of keystone user ids who are granted ACL permission.
        /// </summary>
        /// <value>This field holds a list of keystone user ids who are granted ACL permission.</value>
        [DataMember(Name="userIdVec", EmitDefaultValue=false)]
        public List<string> UserIdVec { get; set; }

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
            return this.Equals(input as KeystoneACLProtoGrantees);
        }

        /// <summary>
        /// Returns true if KeystoneACLProtoGrantees instances are equal
        /// </summary>
        /// <param name="input">Instance of KeystoneACLProtoGrantees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeystoneACLProtoGrantees input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllUsers == input.AllUsers ||
                    (this.AllUsers != null &&
                    this.AllUsers.Equals(input.AllUsers))
                ) && 
                (
                    this.ProjectIdVec == input.ProjectIdVec ||
                    this.ProjectIdVec != null &&
                    this.ProjectIdVec.Equals(input.ProjectIdVec)
                ) && 
                (
                    this.ProjectUsersMap == input.ProjectUsersMap ||
                    this.ProjectUsersMap != null &&
                    this.ProjectUsersMap.Equals(input.ProjectUsersMap)
                ) && 
                (
                    this.RoleNameVec == input.RoleNameVec ||
                    this.RoleNameVec != null &&
                    this.RoleNameVec.Equals(input.RoleNameVec)
                ) && 
                (
                    this.UserIdVec == input.UserIdVec ||
                    this.UserIdVec != null &&
                    this.UserIdVec.Equals(input.UserIdVec)
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
                if (this.AllUsers != null)
                    hashCode = hashCode * 59 + this.AllUsers.GetHashCode();
                if (this.ProjectIdVec != null)
                    hashCode = hashCode * 59 + this.ProjectIdVec.GetHashCode();
                if (this.ProjectUsersMap != null)
                    hashCode = hashCode * 59 + this.ProjectUsersMap.GetHashCode();
                if (this.RoleNameVec != null)
                    hashCode = hashCode * 59 + this.RoleNameVec.GetHashCode();
                if (this.UserIdVec != null)
                    hashCode = hashCode * 59 + this.UserIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

