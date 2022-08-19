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
    /// Specifies an Object containing information about a registered mongodb source.
    /// </summary>
    [DataContract]
    public partial class MongoDBConnectParams :  IEquatable<MongoDBConnectParams>
    {
        /// <summary>
        /// Specifies whether authentication is configured on this MongoDB cluster. Specifies the type of an MongoDB source entity. &#39;SCRAM&#39; &#39;LDAP&#39; &#39;NONE&#39; &#39;KERBEROS&#39;
        /// </summary>
        /// <value>Specifies whether authentication is configured on this MongoDB cluster. Specifies the type of an MongoDB source entity. &#39;SCRAM&#39; &#39;LDAP&#39; &#39;NONE&#39; &#39;KERBEROS&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum SCRAM for value: SCRAM
            /// </summary>
            [EnumMember(Value = "SCRAM")]
            SCRAM = 1,

            /// <summary>
            /// Enum LDAP for value: LDAP
            /// </summary>
            [EnumMember(Value = "LDAP")]
            LDAP = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3,

            /// <summary>
            /// Enum KERBEROS for value: KERBEROS
            /// </summary>
            [EnumMember(Value = "KERBEROS")]
            KERBEROS = 4

        }

        /// <summary>
        /// Specifies whether authentication is configured on this MongoDB cluster. Specifies the type of an MongoDB source entity. &#39;SCRAM&#39; &#39;LDAP&#39; &#39;NONE&#39; &#39;KERBEROS&#39;
        /// </summary>
        /// <value>Specifies whether authentication is configured on this MongoDB cluster. Specifies the type of an MongoDB source entity. &#39;SCRAM&#39; &#39;LDAP&#39; &#39;NONE&#39; &#39;KERBEROS&#39;</value>
        [DataMember(Name="authType", EmitDefaultValue=true)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBConnectParams" /> class.
        /// </summary>
        /// <param name="authType">Specifies whether authentication is configured on this MongoDB cluster. Specifies the type of an MongoDB source entity. &#39;SCRAM&#39; &#39;LDAP&#39; &#39;NONE&#39; &#39;KERBEROS&#39;.</param>
        /// <param name="authenticatingDatabaseName">Specifies the Authenticating Database for this MongoDB cluster..</param>
        /// <param name="hasAuthentication">Specifies whether authentication is configured on this MongoDB cluster..</param>
        /// <param name="requiresSsl">Specifies whether connection is allowed through SSL only in this cluster..</param>
        /// <param name="secondaryNodeTag">MongoDB Secondary node tag. Required only if &#39;useSecondaryForBackup&#39; is true. The system will use this to identify the secondary nodes for reading backup data..</param>
        /// <param name="seeds">Specifies the seeds of this MongoDB Cluster..</param>
        /// <param name="useSecondaryForBackup">Set this to true if you want the system to peform backups from secondary nodes..</param>
        public MongoDBConnectParams(AuthTypeEnum? authType = default(AuthTypeEnum?), string authenticatingDatabaseName = default(string), bool? hasAuthentication = default(bool?), bool? requiresSsl = default(bool?), string secondaryNodeTag = default(string), List<string> seeds = default(List<string>), bool? useSecondaryForBackup = default(bool?))
        {
            this.AuthType = authType;
            this.AuthenticatingDatabaseName = authenticatingDatabaseName;
            this.HasAuthentication = hasAuthentication;
            this.RequiresSsl = requiresSsl;
            this.SecondaryNodeTag = secondaryNodeTag;
            this.Seeds = seeds;
            this.UseSecondaryForBackup = useSecondaryForBackup;
        }
        
        /// <summary>
        /// Specifies the Authenticating Database for this MongoDB cluster.
        /// </summary>
        /// <value>Specifies the Authenticating Database for this MongoDB cluster.</value>
        [DataMember(Name="authenticatingDatabaseName", EmitDefaultValue=true)]
        public string AuthenticatingDatabaseName { get; set; }

        /// <summary>
        /// Specifies whether authentication is configured on this MongoDB cluster.
        /// </summary>
        /// <value>Specifies whether authentication is configured on this MongoDB cluster.</value>
        [DataMember(Name="hasAuthentication", EmitDefaultValue=true)]
        public bool? HasAuthentication { get; set; }

        /// <summary>
        /// Specifies whether connection is allowed through SSL only in this cluster.
        /// </summary>
        /// <value>Specifies whether connection is allowed through SSL only in this cluster.</value>
        [DataMember(Name="requiresSsl", EmitDefaultValue=true)]
        public bool? RequiresSsl { get; set; }

        /// <summary>
        /// MongoDB Secondary node tag. Required only if &#39;useSecondaryForBackup&#39; is true. The system will use this to identify the secondary nodes for reading backup data.
        /// </summary>
        /// <value>MongoDB Secondary node tag. Required only if &#39;useSecondaryForBackup&#39; is true. The system will use this to identify the secondary nodes for reading backup data.</value>
        [DataMember(Name="secondaryNodeTag", EmitDefaultValue=true)]
        public string SecondaryNodeTag { get; set; }

        /// <summary>
        /// Specifies the seeds of this MongoDB Cluster.
        /// </summary>
        /// <value>Specifies the seeds of this MongoDB Cluster.</value>
        [DataMember(Name="seeds", EmitDefaultValue=true)]
        public List<string> Seeds { get; set; }

        /// <summary>
        /// Set this to true if you want the system to peform backups from secondary nodes.
        /// </summary>
        /// <value>Set this to true if you want the system to peform backups from secondary nodes.</value>
        [DataMember(Name="useSecondaryForBackup", EmitDefaultValue=true)]
        public bool? UseSecondaryForBackup { get; set; }

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
            return this.Equals(input as MongoDBConnectParams);
        }

        /// <summary>
        /// Returns true if MongoDBConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.AuthenticatingDatabaseName == input.AuthenticatingDatabaseName ||
                    (this.AuthenticatingDatabaseName != null &&
                    this.AuthenticatingDatabaseName.Equals(input.AuthenticatingDatabaseName))
                ) && 
                (
                    this.HasAuthentication == input.HasAuthentication ||
                    (this.HasAuthentication != null &&
                    this.HasAuthentication.Equals(input.HasAuthentication))
                ) && 
                (
                    this.RequiresSsl == input.RequiresSsl ||
                    (this.RequiresSsl != null &&
                    this.RequiresSsl.Equals(input.RequiresSsl))
                ) && 
                (
                    this.SecondaryNodeTag == input.SecondaryNodeTag ||
                    (this.SecondaryNodeTag != null &&
                    this.SecondaryNodeTag.Equals(input.SecondaryNodeTag))
                ) && 
                (
                    this.Seeds == input.Seeds ||
                    this.Seeds != null &&
                    input.Seeds != null &&
                    this.Seeds.Equals(input.Seeds)
                ) && 
                (
                    this.UseSecondaryForBackup == input.UseSecondaryForBackup ||
                    (this.UseSecondaryForBackup != null &&
                    this.UseSecondaryForBackup.Equals(input.UseSecondaryForBackup))
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
                if (this.AuthType != null)
					hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthenticatingDatabaseName != null)
                    hashCode = hashCode * 59 + this.AuthenticatingDatabaseName.GetHashCode();
                if (this.HasAuthentication != null)
                    hashCode = hashCode * 59 + this.HasAuthentication.GetHashCode();
                if (this.RequiresSsl != null)
                    hashCode = hashCode * 59 + this.RequiresSsl.GetHashCode();
                if (this.SecondaryNodeTag != null)
                    hashCode = hashCode * 59 + this.SecondaryNodeTag.GetHashCode();
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                if (this.UseSecondaryForBackup != null)
                    hashCode = hashCode * 59 + this.UseSecondaryForBackup.GetHashCode();
                return hashCode;
            }
        }

    }

}

