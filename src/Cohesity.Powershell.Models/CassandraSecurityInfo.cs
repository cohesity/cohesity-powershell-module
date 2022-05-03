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
    /// Specifies an Object containing information on Cassandra security.
    /// </summary>
    [DataContract]
    public partial class CassandraSecurityInfo :  IEquatable<CassandraSecurityInfo>
    {
        /// <summary>
        /// Cassandra Authentication type. Enum: [PASSWORD KERBEROS LDAP] Specifies the Cassandra auth type. &#39;PASSWORD&#39; &#39;KERBEROS&#39; &#39;LDAP&#39;
        /// </summary>
        /// <value>Cassandra Authentication type. Enum: [PASSWORD KERBEROS LDAP] Specifies the Cassandra auth type. &#39;PASSWORD&#39; &#39;KERBEROS&#39; &#39;LDAP&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CassandraAuthTypeEnum
        {
            /// <summary>
            /// Enum PASSWORD for value: PASSWORD
            /// </summary>
            [EnumMember(Value = "PASSWORD")]
            PASSWORD = 1,

            /// <summary>
            /// Enum KERBEROS for value: KERBEROS
            /// </summary>
            [EnumMember(Value = "KERBEROS")]
            KERBEROS = 2,

            /// <summary>
            /// Enum LDAP for value: LDAP
            /// </summary>
            [EnumMember(Value = "LDAP")]
            LDAP = 3

        }

        /// <summary>
        /// Cassandra Authentication type. Enum: [PASSWORD KERBEROS LDAP] Specifies the Cassandra auth type. &#39;PASSWORD&#39; &#39;KERBEROS&#39; &#39;LDAP&#39;
        /// </summary>
        /// <value>Cassandra Authentication type. Enum: [PASSWORD KERBEROS LDAP] Specifies the Cassandra auth type. &#39;PASSWORD&#39; &#39;KERBEROS&#39; &#39;LDAP&#39;</value>
        [DataMember(Name="cassandraAuthType", EmitDefaultValue=false)]
        public CassandraAuthTypeEnum? CassandraAuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraSecurityInfo" /> class.
        /// </summary>
        /// <param name="cassandraAuthRequired">Is Cassandra authentication required ?.</param>
        /// <param name="cassandraAuthType">Cassandra Authentication type. Enum: [PASSWORD KERBEROS LDAP] Specifies the Cassandra auth type. &#39;PASSWORD&#39; &#39;KERBEROS&#39; &#39;LDAP&#39;.</param>
        /// <param name="cassandraAuthorizer">Cassandra Authenticator/Authorizer..</param>
        /// <param name="clientEncryption">Is Client Encryption enabled for this cluster ?.</param>
        /// <param name="dseAuthorization">Is DSE Authorization enabled for this cluster ?.</param>
        /// <param name="serverEncryptionReqClientAuth">Is &#39;Server encryption request client authentication&#39; enabled for this cluster ?.</param>
        /// <param name="serverInternodeEncryptionType">&#39;Server internal node Encryption&#39; type for this cluster..</param>
        public CassandraSecurityInfo(bool? cassandraAuthRequired = default(bool?), CassandraAuthTypeEnum? cassandraAuthType = default(CassandraAuthTypeEnum?), string cassandraAuthorizer = default(string), bool? clientEncryption = default(bool?), bool? dseAuthorization = default(bool?), bool? serverEncryptionReqClientAuth = default(bool?), string serverInternodeEncryptionType = default(string))
        {
            this.CassandraAuthRequired = cassandraAuthRequired;
            this.CassandraAuthType = cassandraAuthType;
            this.CassandraAuthorizer = cassandraAuthorizer;
            this.ClientEncryption = clientEncryption;
            this.DseAuthorization = dseAuthorization;
            this.ServerEncryptionReqClientAuth = serverEncryptionReqClientAuth;
            this.ServerInternodeEncryptionType = serverInternodeEncryptionType;
        }
        
        /// <summary>
        /// Is Cassandra authentication required ?
        /// </summary>
        /// <value>Is Cassandra authentication required ?</value>
        [DataMember(Name="cassandraAuthRequired", EmitDefaultValue=false)]
        public bool? CassandraAuthRequired { get; set; }


        /// <summary>
        /// Cassandra Authenticator/Authorizer.
        /// </summary>
        /// <value>Cassandra Authenticator/Authorizer.</value>
        [DataMember(Name="cassandraAuthorizer", EmitDefaultValue=false)]
        public string CassandraAuthorizer { get; set; }

        /// <summary>
        /// Is Client Encryption enabled for this cluster ?
        /// </summary>
        /// <value>Is Client Encryption enabled for this cluster ?</value>
        [DataMember(Name="clientEncryption", EmitDefaultValue=false)]
        public bool? ClientEncryption { get; set; }

        /// <summary>
        /// Is DSE Authorization enabled for this cluster ?
        /// </summary>
        /// <value>Is DSE Authorization enabled for this cluster ?</value>
        [DataMember(Name="dseAuthorization", EmitDefaultValue=false)]
        public bool? DseAuthorization { get; set; }

        /// <summary>
        /// Is &#39;Server encryption request client authentication&#39; enabled for this cluster ?
        /// </summary>
        /// <value>Is &#39;Server encryption request client authentication&#39; enabled for this cluster ?</value>
        [DataMember(Name="serverEncryptionReqClientAuth", EmitDefaultValue=false)]
        public bool? ServerEncryptionReqClientAuth { get; set; }

        /// <summary>
        /// &#39;Server internal node Encryption&#39; type for this cluster.
        /// </summary>
        /// <value>&#39;Server internal node Encryption&#39; type for this cluster.</value>
        [DataMember(Name="serverInternodeEncryptionType", EmitDefaultValue=false)]
        public string ServerInternodeEncryptionType { get; set; }

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
            return this.Equals(input as CassandraSecurityInfo);
        }

        /// <summary>
        /// Returns true if CassandraSecurityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraSecurityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraSecurityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraAuthRequired == input.CassandraAuthRequired ||
                    (this.CassandraAuthRequired != null &&
                    this.CassandraAuthRequired.Equals(input.CassandraAuthRequired))
                ) && 
                (
                    this.CassandraAuthType == input.CassandraAuthType ||
                    (this.CassandraAuthType != null &&
                    this.CassandraAuthType.Equals(input.CassandraAuthType))
                ) && 
                (
                    this.CassandraAuthorizer == input.CassandraAuthorizer ||
                    (this.CassandraAuthorizer != null &&
                    this.CassandraAuthorizer.Equals(input.CassandraAuthorizer))
                ) && 
                (
                    this.ClientEncryption == input.ClientEncryption ||
                    (this.ClientEncryption != null &&
                    this.ClientEncryption.Equals(input.ClientEncryption))
                ) && 
                (
                    this.DseAuthorization == input.DseAuthorization ||
                    (this.DseAuthorization != null &&
                    this.DseAuthorization.Equals(input.DseAuthorization))
                ) && 
                (
                    this.ServerEncryptionReqClientAuth == input.ServerEncryptionReqClientAuth ||
                    (this.ServerEncryptionReqClientAuth != null &&
                    this.ServerEncryptionReqClientAuth.Equals(input.ServerEncryptionReqClientAuth))
                ) && 
                (
                    this.ServerInternodeEncryptionType == input.ServerInternodeEncryptionType ||
                    (this.ServerInternodeEncryptionType != null &&
                    this.ServerInternodeEncryptionType.Equals(input.ServerInternodeEncryptionType))
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
                if (this.CassandraAuthRequired != null)
                    hashCode = hashCode * 59 + this.CassandraAuthRequired.GetHashCode();
                if (this.CassandraAuthType != null)
                    hashCode = hashCode * 59 + this.CassandraAuthType.GetHashCode();
                if (this.CassandraAuthorizer != null)
                    hashCode = hashCode * 59 + this.CassandraAuthorizer.GetHashCode();
                if (this.ClientEncryption != null)
                    hashCode = hashCode * 59 + this.ClientEncryption.GetHashCode();
                if (this.DseAuthorization != null)
                    hashCode = hashCode * 59 + this.DseAuthorization.GetHashCode();
                if (this.ServerEncryptionReqClientAuth != null)
                    hashCode = hashCode * 59 + this.ServerEncryptionReqClientAuth.GetHashCode();
                if (this.ServerInternodeEncryptionType != null)
                    hashCode = hashCode * 59 + this.ServerInternodeEncryptionType.GetHashCode();
                return hashCode;
            }
        }

    }

}

