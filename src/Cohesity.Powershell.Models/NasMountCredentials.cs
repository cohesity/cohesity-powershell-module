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
    /// NasMountCredentials
    /// </summary>
    [DataContract]
    public partial class NasMountCredentials :  IEquatable<NasMountCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NasMountCredentials" /> class.
        /// </summary>
        /// <param name="domainName">The name of the domain which the NAS mount credentials belong to..</param>
        /// <param name="encryptedPassword">AES256 encrypted password. The key for encryption should be obtained from KMS..</param>
        /// <param name="kdc">KDC hostname or IP for krb5 authentication. KDC stores secret keys for a smb user and provides the krb5 tickets for authentication..</param>
        /// <param name="password">The password field is only populated in RPCs. On disk, instances of this proto should not have this field set, except for legacy records.  TODO(oleg): Change this field type to bytes.j.</param>
        /// <param name="protocol">The protocol of the NAS mount..</param>
        /// <param name="username">The username and password to use for mounting the NAS..</param>
        public NasMountCredentials(string domainName = default(string), List<int> encryptedPassword = default(List<int>), string kdc = default(string), string password = default(string), int? protocol = default(int?), string username = default(string))
        {
            this.DomainName = domainName;
            this.EncryptedPassword = encryptedPassword;
            this.Kdc = kdc;
            this.Password = password;
            this.Protocol = protocol;
            this.Username = username;
            this.DomainName = domainName;
            this.EncryptedPassword = encryptedPassword;
            this.Kdc = kdc;
            this.Password = password;
            this.Protocol = protocol;
            this.Username = username;
        }
        
        /// <summary>
        /// The name of the domain which the NAS mount credentials belong to.
        /// </summary>
        /// <value>The name of the domain which the NAS mount credentials belong to.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// AES256 encrypted password. The key for encryption should be obtained from KMS.
        /// </summary>
        /// <value>AES256 encrypted password. The key for encryption should be obtained from KMS.</value>
        [DataMember(Name="encryptedPassword", EmitDefaultValue=true)]
        public List<int> EncryptedPassword { get; set; }

        /// <summary>
        /// KDC hostname or IP for krb5 authentication. KDC stores secret keys for a smb user and provides the krb5 tickets for authentication.
        /// </summary>
        /// <value>KDC hostname or IP for krb5 authentication. KDC stores secret keys for a smb user and provides the krb5 tickets for authentication.</value>
        [DataMember(Name="kdc", EmitDefaultValue=true)]
        public string Kdc { get; set; }

        /// <summary>
        /// The password field is only populated in RPCs. On disk, instances of this proto should not have this field set, except for legacy records.  TODO(oleg): Change this field type to bytes.j
        /// </summary>
        /// <value>The password field is only populated in RPCs. On disk, instances of this proto should not have this field set, except for legacy records.  TODO(oleg): Change this field type to bytes.j</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// The protocol of the NAS mount.
        /// </summary>
        /// <value>The protocol of the NAS mount.</value>
        [DataMember(Name="protocol", EmitDefaultValue=true)]
        public int? Protocol { get; set; }

        /// <summary>
        /// The username and password to use for mounting the NAS.
        /// </summary>
        /// <value>The username and password to use for mounting the NAS.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
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
            return this.Equals(input as NasMountCredentials);
        }

        /// <summary>
        /// Returns true if NasMountCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of NasMountCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasMountCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.EncryptedPassword == input.EncryptedPassword ||
                    this.EncryptedPassword != null &&
                    input.EncryptedPassword != null &&
                    this.EncryptedPassword.SequenceEqual(input.EncryptedPassword)
                ) && 
                (
                    this.Kdc == input.Kdc ||
                    (this.Kdc != null &&
                    this.Kdc.Equals(input.Kdc))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EncryptedPassword != null)
                    hashCode = hashCode * 59 + this.EncryptedPassword.GetHashCode();
                if (this.Kdc != null)
                    hashCode = hashCode * 59 + this.Kdc.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

