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
    /// Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment. This field is deprecated. Use the field in VmCredentials inside source specific parameter. deprecated: true
    /// </summary>
    [DataContract]
    public partial class VMCredentials_ :  IEquatable<VMCredentials_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMCredentials_" /> class.
        /// </summary>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        public VMCredentials_(string password = default(string), string username = default(string))
        {
            this.Password = password;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as VMCredentials_);
        }

        /// <summary>
        /// Returns true if VMCredentials_ instances are equal
        /// </summary>
        /// <param name="input">Instance of VMCredentials_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMCredentials_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

