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
    /// Specifies information about an AD domain controller.
    /// </summary>
    [DataContract]
    public partial class AdDomainController :  IEquatable<AdDomainController>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdDomainController" /> class.
        /// </summary>
        /// <param name="backupSupported">Specifies whether backup of this domain controller is supported..</param>
        /// <param name="backupUnsupportedReasons">Specifies any reason(s) for domain controller backup not supported..</param>
        /// <param name="domain">domain.</param>
        /// <param name="hostName">Specifies FQDN host name of the domain controller..</param>
        /// <param name="isGlobalCatalog">Specifies whether this domain controller is a global catalog server..</param>
        /// <param name="isReadOnly">Specifies whether this domain controller is read only..</param>
        /// <param name="utcOffsetMin">Specifies UTC time offset of this domain controller in minutes..</param>
        public AdDomainController(bool? backupSupported = default(bool?), List<string> backupUnsupportedReasons = default(List<string>), AdDomain domain = default(AdDomain), string hostName = default(string), bool? isGlobalCatalog = default(bool?), bool? isReadOnly = default(bool?), int? utcOffsetMin = default(int?))
        {
            this.BackupSupported = backupSupported;
            this.BackupUnsupportedReasons = backupUnsupportedReasons;
            this.HostName = hostName;
            this.IsGlobalCatalog = isGlobalCatalog;
            this.IsReadOnly = isReadOnly;
            this.UtcOffsetMin = utcOffsetMin;
            this.BackupSupported = backupSupported;
            this.BackupUnsupportedReasons = backupUnsupportedReasons;
            this.Domain = domain;
            this.HostName = hostName;
            this.IsGlobalCatalog = isGlobalCatalog;
            this.IsReadOnly = isReadOnly;
            this.UtcOffsetMin = utcOffsetMin;
        }
        
        /// <summary>
        /// Specifies whether backup of this domain controller is supported.
        /// </summary>
        /// <value>Specifies whether backup of this domain controller is supported.</value>
        [DataMember(Name="backupSupported", EmitDefaultValue=true)]
        public bool? BackupSupported { get; set; }

        /// <summary>
        /// Specifies any reason(s) for domain controller backup not supported.
        /// </summary>
        /// <value>Specifies any reason(s) for domain controller backup not supported.</value>
        [DataMember(Name="backupUnsupportedReasons", EmitDefaultValue=true)]
        public List<string> BackupUnsupportedReasons { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public AdDomain Domain { get; set; }

        /// <summary>
        /// Specifies FQDN host name of the domain controller.
        /// </summary>
        /// <value>Specifies FQDN host name of the domain controller.</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Specifies whether this domain controller is a global catalog server.
        /// </summary>
        /// <value>Specifies whether this domain controller is a global catalog server.</value>
        [DataMember(Name="isGlobalCatalog", EmitDefaultValue=true)]
        public bool? IsGlobalCatalog { get; set; }

        /// <summary>
        /// Specifies whether this domain controller is read only.
        /// </summary>
        /// <value>Specifies whether this domain controller is read only.</value>
        [DataMember(Name="isReadOnly", EmitDefaultValue=true)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Specifies UTC time offset of this domain controller in minutes.
        /// </summary>
        /// <value>Specifies UTC time offset of this domain controller in minutes.</value>
        [DataMember(Name="utcOffsetMin", EmitDefaultValue=true)]
        public int? UtcOffsetMin { get; set; }

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
            return this.Equals(input as AdDomainController);
        }

        /// <summary>
        /// Returns true if AdDomainController instances are equal
        /// </summary>
        /// <param name="input">Instance of AdDomainController to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdDomainController input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupSupported == input.BackupSupported ||
                    (this.BackupSupported != null &&
                    this.BackupSupported.Equals(input.BackupSupported))
                ) && 
                (
                    this.BackupUnsupportedReasons == input.BackupUnsupportedReasons ||
                    this.BackupUnsupportedReasons != null &&
                    input.BackupUnsupportedReasons != null &&
                    this.BackupUnsupportedReasons.SequenceEqual(input.BackupUnsupportedReasons)
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.IsGlobalCatalog == input.IsGlobalCatalog ||
                    (this.IsGlobalCatalog != null &&
                    this.IsGlobalCatalog.Equals(input.IsGlobalCatalog))
                ) && 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.UtcOffsetMin == input.UtcOffsetMin ||
                    (this.UtcOffsetMin != null &&
                    this.UtcOffsetMin.Equals(input.UtcOffsetMin))
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
                if (this.BackupSupported != null)
                    hashCode = hashCode * 59 + this.BackupSupported.GetHashCode();
                if (this.BackupUnsupportedReasons != null)
                    hashCode = hashCode * 59 + this.BackupUnsupportedReasons.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.IsGlobalCatalog != null)
                    hashCode = hashCode * 59 + this.IsGlobalCatalog.GetHashCode();
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.UtcOffsetMin != null)
                    hashCode = hashCode * 59 + this.UtcOffsetMin.GetHashCode();
                return hashCode;
            }
        }

    }

}

