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
    /// Specifies the storage statistics of the cluster.
    /// </summary>
    [DataContract]
    public partial class StorageStats :  IEquatable<StorageStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageStats" /> class.
        /// </summary>
        /// <param name="dataProtectionLogicalUsageBytes">Specifies the logical size of protected objects in bytes..</param>
        /// <param name="dataProtectionPhysicalUsageBytes">Specifies the physical size of protected objects in bytes..</param>
        /// <param name="fileServicesLogicalUsageBytes">Specifies the logical size consumed by file services in bytes..</param>
        /// <param name="fileServicesPhysicalUsageBytes">Specifies the physical size consumed by file services in bytes..</param>
        /// <param name="localAvailableBytes">Specifies the local storage currently available on the cluster in bytes..</param>
        /// <param name="localUsageBytes">Specifies the local storage currently in use on the cluster in bytes..</param>
        /// <param name="totalCapacityBytes">Specifies the total capacity of the cluster in bytes..</param>
        /// <param name="viewBackupLogicalUsageBytes">Specifies the logical size consumed by the external view backups..</param>
        /// <param name="viewBackupPhysicalUsageBytes">Specifies the physical size consumed by the external view backups..</param>
        public StorageStats(long? dataProtectionLogicalUsageBytes = default(long?), long? dataProtectionPhysicalUsageBytes = default(long?), long? fileServicesLogicalUsageBytes = default(long?), long? fileServicesPhysicalUsageBytes = default(long?), long? localAvailableBytes = default(long?), long? localUsageBytes = default(long?), long? totalCapacityBytes = default(long?), long? viewBackupLogicalUsageBytes = default(long?), long? viewBackupPhysicalUsageBytes = default(long?))
        {
            this.DataProtectionLogicalUsageBytes = dataProtectionLogicalUsageBytes;
            this.DataProtectionPhysicalUsageBytes = dataProtectionPhysicalUsageBytes;
            this.FileServicesLogicalUsageBytes = fileServicesLogicalUsageBytes;
            this.FileServicesPhysicalUsageBytes = fileServicesPhysicalUsageBytes;
            this.LocalAvailableBytes = localAvailableBytes;
            this.LocalUsageBytes = localUsageBytes;
            this.TotalCapacityBytes = totalCapacityBytes;
            this.ViewBackupLogicalUsageBytes = viewBackupLogicalUsageBytes;
            this.ViewBackupPhysicalUsageBytes = viewBackupPhysicalUsageBytes;
        }
        
        /// <summary>
        /// Specifies the logical size of protected objects in bytes.
        /// </summary>
        /// <value>Specifies the logical size of protected objects in bytes.</value>
        [DataMember(Name="dataProtectionLogicalUsageBytes", EmitDefaultValue=true)]
        public long? DataProtectionLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the physical size of protected objects in bytes.
        /// </summary>
        /// <value>Specifies the physical size of protected objects in bytes.</value>
        [DataMember(Name="dataProtectionPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? DataProtectionPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the logical size consumed by file services in bytes.
        /// </summary>
        /// <value>Specifies the logical size consumed by file services in bytes.</value>
        [DataMember(Name="fileServicesLogicalUsageBytes", EmitDefaultValue=true)]
        public long? FileServicesLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the physical size consumed by file services in bytes.
        /// </summary>
        /// <value>Specifies the physical size consumed by file services in bytes.</value>
        [DataMember(Name="fileServicesPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? FileServicesPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the local storage currently available on the cluster in bytes.
        /// </summary>
        /// <value>Specifies the local storage currently available on the cluster in bytes.</value>
        [DataMember(Name="localAvailableBytes", EmitDefaultValue=true)]
        public long? LocalAvailableBytes { get; set; }

        /// <summary>
        /// Specifies the local storage currently in use on the cluster in bytes.
        /// </summary>
        /// <value>Specifies the local storage currently in use on the cluster in bytes.</value>
        [DataMember(Name="localUsageBytes", EmitDefaultValue=true)]
        public long? LocalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the total capacity of the cluster in bytes.
        /// </summary>
        /// <value>Specifies the total capacity of the cluster in bytes.</value>
        [DataMember(Name="totalCapacityBytes", EmitDefaultValue=true)]
        public long? TotalCapacityBytes { get; set; }

        /// <summary>
        /// Specifies the logical size consumed by the external view backups.
        /// </summary>
        /// <value>Specifies the logical size consumed by the external view backups.</value>
        [DataMember(Name="viewBackupLogicalUsageBytes", EmitDefaultValue=true)]
        public long? ViewBackupLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies the physical size consumed by the external view backups.
        /// </summary>
        /// <value>Specifies the physical size consumed by the external view backups.</value>
        [DataMember(Name="viewBackupPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? ViewBackupPhysicalUsageBytes { get; set; }

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
            return this.Equals(input as StorageStats);
        }

        /// <summary>
        /// Returns true if StorageStats instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataProtectionLogicalUsageBytes == input.DataProtectionLogicalUsageBytes ||
                    (this.DataProtectionLogicalUsageBytes != null &&
                    this.DataProtectionLogicalUsageBytes.Equals(input.DataProtectionLogicalUsageBytes))
                ) && 
                (
                    this.DataProtectionPhysicalUsageBytes == input.DataProtectionPhysicalUsageBytes ||
                    (this.DataProtectionPhysicalUsageBytes != null &&
                    this.DataProtectionPhysicalUsageBytes.Equals(input.DataProtectionPhysicalUsageBytes))
                ) && 
                (
                    this.FileServicesLogicalUsageBytes == input.FileServicesLogicalUsageBytes ||
                    (this.FileServicesLogicalUsageBytes != null &&
                    this.FileServicesLogicalUsageBytes.Equals(input.FileServicesLogicalUsageBytes))
                ) && 
                (
                    this.FileServicesPhysicalUsageBytes == input.FileServicesPhysicalUsageBytes ||
                    (this.FileServicesPhysicalUsageBytes != null &&
                    this.FileServicesPhysicalUsageBytes.Equals(input.FileServicesPhysicalUsageBytes))
                ) && 
                (
                    this.LocalAvailableBytes == input.LocalAvailableBytes ||
                    (this.LocalAvailableBytes != null &&
                    this.LocalAvailableBytes.Equals(input.LocalAvailableBytes))
                ) && 
                (
                    this.LocalUsageBytes == input.LocalUsageBytes ||
                    (this.LocalUsageBytes != null &&
                    this.LocalUsageBytes.Equals(input.LocalUsageBytes))
                ) && 
                (
                    this.TotalCapacityBytes == input.TotalCapacityBytes ||
                    (this.TotalCapacityBytes != null &&
                    this.TotalCapacityBytes.Equals(input.TotalCapacityBytes))
                ) && 
                (
                    this.ViewBackupLogicalUsageBytes == input.ViewBackupLogicalUsageBytes ||
                    (this.ViewBackupLogicalUsageBytes != null &&
                    this.ViewBackupLogicalUsageBytes.Equals(input.ViewBackupLogicalUsageBytes))
                ) && 
                (
                    this.ViewBackupPhysicalUsageBytes == input.ViewBackupPhysicalUsageBytes ||
                    (this.ViewBackupPhysicalUsageBytes != null &&
                    this.ViewBackupPhysicalUsageBytes.Equals(input.ViewBackupPhysicalUsageBytes))
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
                if (this.DataProtectionLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.DataProtectionLogicalUsageBytes.GetHashCode();
                if (this.DataProtectionPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.DataProtectionPhysicalUsageBytes.GetHashCode();
                if (this.FileServicesLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.FileServicesLogicalUsageBytes.GetHashCode();
                if (this.FileServicesPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.FileServicesPhysicalUsageBytes.GetHashCode();
                if (this.LocalAvailableBytes != null)
                    hashCode = hashCode * 59 + this.LocalAvailableBytes.GetHashCode();
                if (this.LocalUsageBytes != null)
                    hashCode = hashCode * 59 + this.LocalUsageBytes.GetHashCode();
                if (this.TotalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.TotalCapacityBytes.GetHashCode();
                if (this.ViewBackupLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.ViewBackupLogicalUsageBytes.GetHashCode();
                if (this.ViewBackupPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.ViewBackupPhysicalUsageBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

