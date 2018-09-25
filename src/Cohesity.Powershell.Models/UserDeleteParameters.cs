// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the users to delete on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class UserDeleteParameters :  IEquatable<UserDeleteParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDeleteParameters" /> class.
        /// </summary>
        /// <param name="domain">Specifies the domain associated with the users to delete. Only users associated with the same domain can be deleted by a single request. If no domain is specified, the specified users are deleted from the LOCAL domain on the Cohesity Cluster. If a non-LOCAL domain is specified, the specified users are deleted on the Cohesity Cluster. However, the referenced user principals on the Active Directory are not deleted..</param>
        /// <param name="users">Specifies the list of users to delete on Cohesity Cluster. Only users from the same domain can be deleted by a single request..</param>
        public UserDeleteParameters(string domain = default(string), List<string> users = default(List<string>))
        {
            this.Domain = domain;
            this.Users = users;
        }
        
        /// <summary>
        /// Specifies the domain associated with the users to delete. Only users associated with the same domain can be deleted by a single request. If no domain is specified, the specified users are deleted from the LOCAL domain on the Cohesity Cluster. If a non-LOCAL domain is specified, the specified users are deleted on the Cohesity Cluster. However, the referenced user principals on the Active Directory are not deleted.
        /// </summary>
        /// <value>Specifies the domain associated with the users to delete. Only users associated with the same domain can be deleted by a single request. If no domain is specified, the specified users are deleted from the LOCAL domain on the Cohesity Cluster. If a non-LOCAL domain is specified, the specified users are deleted on the Cohesity Cluster. However, the referenced user principals on the Active Directory are not deleted.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the list of users to delete on Cohesity Cluster. Only users from the same domain can be deleted by a single request.
        /// </summary>
        /// <value>Specifies the list of users to delete on Cohesity Cluster. Only users from the same domain can be deleted by a single request.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as UserDeleteParameters);
        }

        /// <summary>
        /// Returns true if UserDeleteParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDeleteParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDeleteParameters input)
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
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

