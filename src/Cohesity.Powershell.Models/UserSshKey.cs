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
    /// UserSshKey specifies username and ssh key.
    /// </summary>
    [DataContract]
    public partial class UserSshKey :  IEquatable<UserSshKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSshKey" /> class.
        /// </summary>
        /// <param name="sshKey">Specifies SSH key needed to be added to the username passed..</param>
        /// <param name="username">Specifies name of the user to add..</param>
        public UserSshKey(string sshKey = default(string), string username = default(string))
        {
            this.SshKey = sshKey;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies SSH key needed to be added to the username passed.
        /// </summary>
        /// <value>Specifies SSH key needed to be added to the username passed.</value>
        [DataMember(Name="sshKey", EmitDefaultValue=false)]
        public string SshKey { get; set; }

        /// <summary>
        /// Specifies name of the user to add.
        /// </summary>
        /// <value>Specifies name of the user to add.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as UserSshKey);
        }

        /// <summary>
        /// Returns true if UserSshKey instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSshKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSshKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SshKey == input.SshKey ||
                    (this.SshKey != null &&
                    this.SshKey.Equals(input.SshKey))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.SshKey != null)
                    hashCode = hashCode * 59 + this.SshKey.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

