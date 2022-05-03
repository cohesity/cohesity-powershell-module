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
    /// RestoreADAppObjectParams
    /// </summary>
    [DataContract]
    public partial class RestoreADAppObjectParams :  IEquatable<RestoreADAppObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreADAppObjectParams" /> class.
        /// </summary>
        /// <param name="adRestoreStatusVec">Status of the AD object/attribute restore operation..</param>
        /// <param name="adUpdateOptions">adUpdateOptions.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="ldapPort">The ldap port on which the AD domain controller&#39;s NTDS database will be mounted..</param>
        /// <param name="numFailed">Number of AD objects whose restore failed. Includes both AD object and attribute restored..</param>
        /// <param name="numRunning">Number of AD objects whose restores are currently running. Includes both AD object and attribute recoveries..</param>
        /// <param name="numSuccessfull">Number of AD objects restored successfully. Includes both AD object and attribute restored..</param>
        /// <param name="shouldMountAndRestore">The following field is set if user wants to mount AD, restore AD objects and destory AD mount in single task..</param>
        public RestoreADAppObjectParams(List<ADRestoreStatus> adRestoreStatusVec = default(List<ADRestoreStatus>), ADUpdateRestoreTaskOptions adUpdateOptions = default(ADUpdateRestoreTaskOptions), Credentials credentials = default(Credentials), int? ldapPort = default(int?), int? numFailed = default(int?), int? numRunning = default(int?), int? numSuccessfull = default(int?), bool? shouldMountAndRestore = default(bool?))
        {
            this.AdRestoreStatusVec = adRestoreStatusVec;
            this.AdUpdateOptions = adUpdateOptions;
            this.Credentials = credentials;
            this.LdapPort = ldapPort;
            this.NumFailed = numFailed;
            this.NumRunning = numRunning;
            this.NumSuccessfull = numSuccessfull;
            this.ShouldMountAndRestore = shouldMountAndRestore;
        }
        
        /// <summary>
        /// Status of the AD object/attribute restore operation.
        /// </summary>
        /// <value>Status of the AD object/attribute restore operation.</value>
        [DataMember(Name="adRestoreStatusVec", EmitDefaultValue=false)]
        public List<ADRestoreStatus> AdRestoreStatusVec { get; set; }

        /// <summary>
        /// Gets or Sets AdUpdateOptions
        /// </summary>
        [DataMember(Name="adUpdateOptions", EmitDefaultValue=false)]
        public ADUpdateRestoreTaskOptions AdUpdateOptions { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// The ldap port on which the AD domain controller&#39;s NTDS database will be mounted.
        /// </summary>
        /// <value>The ldap port on which the AD domain controller&#39;s NTDS database will be mounted.</value>
        [DataMember(Name="ldapPort", EmitDefaultValue=false)]
        public int? LdapPort { get; set; }

        /// <summary>
        /// Number of AD objects whose restore failed. Includes both AD object and attribute restored.
        /// </summary>
        /// <value>Number of AD objects whose restore failed. Includes both AD object and attribute restored.</value>
        [DataMember(Name="numFailed", EmitDefaultValue=false)]
        public int? NumFailed { get; set; }

        /// <summary>
        /// Number of AD objects whose restores are currently running. Includes both AD object and attribute recoveries.
        /// </summary>
        /// <value>Number of AD objects whose restores are currently running. Includes both AD object and attribute recoveries.</value>
        [DataMember(Name="numRunning", EmitDefaultValue=false)]
        public int? NumRunning { get; set; }

        /// <summary>
        /// Number of AD objects restored successfully. Includes both AD object and attribute restored.
        /// </summary>
        /// <value>Number of AD objects restored successfully. Includes both AD object and attribute restored.</value>
        [DataMember(Name="numSuccessfull", EmitDefaultValue=false)]
        public int? NumSuccessfull { get; set; }

        /// <summary>
        /// The following field is set if user wants to mount AD, restore AD objects and destory AD mount in single task.
        /// </summary>
        /// <value>The following field is set if user wants to mount AD, restore AD objects and destory AD mount in single task.</value>
        [DataMember(Name="shouldMountAndRestore", EmitDefaultValue=false)]
        public bool? ShouldMountAndRestore { get; set; }

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
            return this.Equals(input as RestoreADAppObjectParams);
        }

        /// <summary>
        /// Returns true if RestoreADAppObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreADAppObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreADAppObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdRestoreStatusVec == input.AdRestoreStatusVec ||
                    this.AdRestoreStatusVec != null &&
                    this.AdRestoreStatusVec.Equals(input.AdRestoreStatusVec)
                ) && 
                (
                    this.AdUpdateOptions == input.AdUpdateOptions ||
                    (this.AdUpdateOptions != null &&
                    this.AdUpdateOptions.Equals(input.AdUpdateOptions))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.LdapPort == input.LdapPort ||
                    (this.LdapPort != null &&
                    this.LdapPort.Equals(input.LdapPort))
                ) && 
                (
                    this.NumFailed == input.NumFailed ||
                    (this.NumFailed != null &&
                    this.NumFailed.Equals(input.NumFailed))
                ) && 
                (
                    this.NumRunning == input.NumRunning ||
                    (this.NumRunning != null &&
                    this.NumRunning.Equals(input.NumRunning))
                ) && 
                (
                    this.NumSuccessfull == input.NumSuccessfull ||
                    (this.NumSuccessfull != null &&
                    this.NumSuccessfull.Equals(input.NumSuccessfull))
                ) && 
                (
                    this.ShouldMountAndRestore == input.ShouldMountAndRestore ||
                    (this.ShouldMountAndRestore != null &&
                    this.ShouldMountAndRestore.Equals(input.ShouldMountAndRestore))
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
                if (this.AdRestoreStatusVec != null)
                    hashCode = hashCode * 59 + this.AdRestoreStatusVec.GetHashCode();
                if (this.AdUpdateOptions != null)
                    hashCode = hashCode * 59 + this.AdUpdateOptions.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.LdapPort != null)
                    hashCode = hashCode * 59 + this.LdapPort.GetHashCode();
                if (this.NumFailed != null)
                    hashCode = hashCode * 59 + this.NumFailed.GetHashCode();
                if (this.NumRunning != null)
                    hashCode = hashCode * 59 + this.NumRunning.GetHashCode();
                if (this.NumSuccessfull != null)
                    hashCode = hashCode * 59 + this.NumSuccessfull.GetHashCode();
                if (this.ShouldMountAndRestore != null)
                    hashCode = hashCode * 59 + this.ShouldMountAndRestore.GetHashCode();
                return hashCode;
            }
        }

    }

}

