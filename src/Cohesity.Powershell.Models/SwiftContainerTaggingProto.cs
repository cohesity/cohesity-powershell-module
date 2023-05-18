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
    /// SwiftContainerTaggingProto
    /// </summary>
    [DataContract]
    public partial class SwiftContainerTaggingProto :  IEquatable<SwiftContainerTaggingProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwiftContainerTaggingProto" /> class.
        /// </summary>
        /// <param name="aclRootUser">aclRootUser.</param>
        /// <param name="projectTag">projectTag.</param>
        public SwiftContainerTaggingProto(User aclRootUser = default(User), Project projectTag = default(Project))
        {
            this.AclRootUser = aclRootUser;
            this.ProjectTag = projectTag;
        }
        
        /// <summary>
        /// Gets or Sets AclRootUser
        /// </summary>
        [DataMember(Name="aclRootUser", EmitDefaultValue=false)]
        public User AclRootUser { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTag
        /// </summary>
        [DataMember(Name="projectTag", EmitDefaultValue=false)]
        public Project ProjectTag { get; set; }

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
            return this.Equals(input as SwiftContainerTaggingProto);
        }

        /// <summary>
        /// Returns true if SwiftContainerTaggingProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SwiftContainerTaggingProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwiftContainerTaggingProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AclRootUser == input.AclRootUser ||
                    (this.AclRootUser != null &&
                    this.AclRootUser.Equals(input.AclRootUser))
                ) && 
                (
                    this.ProjectTag == input.ProjectTag ||
                    (this.ProjectTag != null &&
                    this.ProjectTag.Equals(input.ProjectTag))
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
                if (this.AclRootUser != null)
                    hashCode = hashCode * 59 + this.AclRootUser.GetHashCode();
                if (this.ProjectTag != null)
                    hashCode = hashCode * 59 + this.ProjectTag.GetHashCode();
                return hashCode;
            }
        }

    }

}

