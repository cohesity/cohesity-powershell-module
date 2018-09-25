// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the credentials required to mount directories on the NetApp server if given.
    /// </summary>
    [DataContract]
    public partial class NASServerCredentials_ :  IEquatable<NASServerCredentials_>
    {
        /// <summary>
        /// Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NasProtocolEnum
        {
            
            /// <summary>
            /// Enum KNfs3 for value: kNfs3
            /// </summary>
            [EnumMember(Value = "kNfs3")]
            KNfs3 = 1,
            
            /// <summary>
            /// Enum KCifs1 for value: kCifs1
            /// </summary>
            [EnumMember(Value = "kCifs1")]
            KCifs1 = 2
        }

        /// <summary>
        /// Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [DataMember(Name="nasProtocol", EmitDefaultValue=false)]
        public NasProtocolEnum? NasProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NASServerCredentials_" /> class.
        /// </summary>
        /// <param name="domain">Specifies the domain in which this credential is valid..</param>
        /// <param name="nasProtocol">Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol..</param>
        /// <param name="password">Specifies the password for the username to use for mounting the NAS..</param>
        /// <param name="username">Specifies a username to use for mounting the NAS..</param>
        public NASServerCredentials_(string domain = default(string), NasProtocolEnum? nasProtocol = default(NasProtocolEnum?), string password = default(string), string username = default(string))
        {
            this.Domain = domain;
            this.NasProtocol = nasProtocol;
            this.Password = password;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the domain in which this credential is valid.
        /// </summary>
        /// <value>Specifies the domain in which this credential is valid.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }


        /// <summary>
        /// Specifies the password for the username to use for mounting the NAS.
        /// </summary>
        /// <value>Specifies the password for the username to use for mounting the NAS.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies a username to use for mounting the NAS.
        /// </summary>
        /// <value>Specifies a username to use for mounting the NAS.</value>
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
            return this.Equals(input as NASServerCredentials_);
        }

        /// <summary>
        /// Returns true if NASServerCredentials_ instances are equal
        /// </summary>
        /// <param name="input">Instance of NASServerCredentials_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NASServerCredentials_ input)
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
                    this.NasProtocol == input.NasProtocol ||
                    (this.NasProtocol != null &&
                    this.NasProtocol.Equals(input.NasProtocol))
                ) && 
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.NasProtocol != null)
                    hashCode = hashCode * 59 + this.NasProtocol.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

