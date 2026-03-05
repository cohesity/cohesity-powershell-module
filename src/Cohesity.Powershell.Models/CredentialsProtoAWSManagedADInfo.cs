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
    /// CredentialsProtoAWSManagedADInfo
    /// </summary>
    [DataContract]
    public partial class CredentialsProtoAWSManagedADInfo :  IEquatable<CredentialsProtoAWSManagedADInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsProtoAWSManagedADInfo" /> class.
        /// </summary>
        /// <param name="directoryDnsAddr">Directory DNS Address for the AD..</param>
        /// <param name="realmName">Realm Name refers to the location of the AD account..</param>
        public CredentialsProtoAWSManagedADInfo(string directoryDnsAddr = default(string), string realmName = default(string))
        {
            this.DirectoryDnsAddr = directoryDnsAddr;
            this.RealmName = realmName;
            this.DirectoryDnsAddr = directoryDnsAddr;
            this.RealmName = realmName;
        }
        
        /// <summary>
        /// Directory DNS Address for the AD.
        /// </summary>
        /// <value>Directory DNS Address for the AD.</value>
        [DataMember(Name="directoryDnsAddr", EmitDefaultValue=true)]
        public string DirectoryDnsAddr { get; set; }

        /// <summary>
        /// Realm Name refers to the location of the AD account.
        /// </summary>
        /// <value>Realm Name refers to the location of the AD account.</value>
        [DataMember(Name="realmName", EmitDefaultValue=true)]
        public string RealmName { get; set; }

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
            return this.Equals(input as CredentialsProtoAWSManagedADInfo);
        }

        /// <summary>
        /// Returns true if CredentialsProtoAWSManagedADInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CredentialsProtoAWSManagedADInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialsProtoAWSManagedADInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectoryDnsAddr == input.DirectoryDnsAddr ||
                    (this.DirectoryDnsAddr != null &&
                    this.DirectoryDnsAddr.Equals(input.DirectoryDnsAddr))
                ) && 
                (
                    this.RealmName == input.RealmName ||
                    (this.RealmName != null &&
                    this.RealmName.Equals(input.RealmName))
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
                if (this.DirectoryDnsAddr != null)
                    hashCode = hashCode * 59 + this.DirectoryDnsAddr.GetHashCode();
                if (this.RealmName != null)
                    hashCode = hashCode * 59 + this.RealmName.GetHashCode();
                return hashCode;
            }
        }

    }

}

