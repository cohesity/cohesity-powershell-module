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
    /// Specifies the settings for cloning an existing View.
    /// </summary>
    [DataContract]
    public partial class CloneViewRequest :  IEquatable<CloneViewRequest>
    {
        /// <summary>
        /// Specifies the supported Protocols for the View.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolAccessEnum
        {
            
            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 1,
            
            /// <summary>
            /// Enum KNFSOnly for value: kNFSOnly
            /// </summary>
            [EnumMember(Value = "kNFSOnly")]
            KNFSOnly = 2,
            
            /// <summary>
            /// Enum KSMBOnly for value: kSMBOnly
            /// </summary>
            [EnumMember(Value = "kSMBOnly")]
            KSMBOnly = 3,
            
            /// <summary>
            /// Enum KS3Only for value: kS3Only
            /// </summary>
            [EnumMember(Value = "kS3Only")]
            KS3Only = 4
        }

        /// <summary>
        /// Specifies the supported Protocols for the View.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View.</value>
        [DataMember(Name="protocolAccess", EmitDefaultValue=false)]
        public ProtocolAccessEnum? ProtocolAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneViewRequest" /> class.
        /// </summary>
        /// <param name="accessSids">Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View..</param>
        /// <param name="cloneViewName">Specifies the name of the new View that is cloned from the source View..</param>
        /// <param name="dataLockExpiryUsecs">DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time..</param>
        /// <param name="description">Specifies an optional text description about the View..</param>
        /// <param name="enableFilerAuditLogging">Specifies if Filer Audit Logging is enabled for this view..</param>
        /// <param name="enableMixedModePermissions">If set, mixed mode (NFS and SMB) access is enabled for this view..</param>
        /// <param name="enableSmbAccessBasedEnumeration">Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view for SMB..</param>
        /// <param name="fileExtensionFilter">Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files..</param>
        /// <param name="logicalQuota">logicalQuota.</param>
        /// <param name="protocolAccess">Specifies the supported Protocols for the View..</param>
        /// <param name="qos">Specifies the Quality of Service (QoS) Policy for the View..</param>
        /// <param name="smbPermissionsInfo">Specifies the SMB permissions for the View..</param>
        /// <param name="sourceViewName">Specifies the name of the source View that will be cloned..</param>
        /// <param name="storagePolicyOverride">Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View..</param>
        /// <param name="subnetWhitelist">Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.).</param>
        public CloneViewRequest(List<string> accessSids = default(List<string>), string cloneViewName = default(string), long? dataLockExpiryUsecs = default(long?), string description = default(string), bool? enableFilerAuditLogging = default(bool?), bool? enableMixedModePermissions = default(bool?), bool? enableSmbAccessBasedEnumeration = default(bool?), bool? enableSmbViewDiscovery = default(bool?), FileExtensionFilter fileExtensionFilter = default(FileExtensionFilter), QuotaPolicy logicalQuota = default(QuotaPolicy), ProtocolAccessEnum? protocolAccess = default(ProtocolAccessEnum?), QoS qos = default(QoS), SmbPermissionsInfo smbPermissionsInfo = default(SmbPermissionsInfo), string sourceViewName = default(string), StoragePolicyOverride storagePolicyOverride = default(StoragePolicyOverride), List<Subnet> subnetWhitelist = default(List<Subnet>))
        {
            this.AccessSids = accessSids;
            this.CloneViewName = cloneViewName;
            this.DataLockExpiryUsecs = dataLockExpiryUsecs;
            this.Description = description;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.FileExtensionFilter = fileExtensionFilter;
            this.LogicalQuota = logicalQuota;
            this.ProtocolAccess = protocolAccess;
            this.Qos = qos;
            this.SmbPermissionsInfo = smbPermissionsInfo;
            this.SourceViewName = sourceViewName;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.SubnetWhitelist = subnetWhitelist;
        }
        
        /// <summary>
        /// Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.
        /// </summary>
        /// <value>Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.</value>
        [DataMember(Name="accessSids", EmitDefaultValue=false)]
        public List<string> AccessSids { get; set; }

        /// <summary>
        /// Specifies the name of the new View that is cloned from the source View.
        /// </summary>
        /// <value>Specifies the name of the new View that is cloned from the source View.</value>
        [DataMember(Name="cloneViewName", EmitDefaultValue=false)]
        public string CloneViewName { get; set; }

        /// <summary>
        /// DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.
        /// </summary>
        /// <value>DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.</value>
        [DataMember(Name="dataLockExpiryUsecs", EmitDefaultValue=false)]
        public long? DataLockExpiryUsecs { get; set; }

        /// <summary>
        /// Specifies an optional text description about the View.
        /// </summary>
        /// <value>Specifies an optional text description about the View.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if Filer Audit Logging is enabled for this view.
        /// </summary>
        /// <value>Specifies if Filer Audit Logging is enabled for this view.</value>
        [DataMember(Name="enableFilerAuditLogging", EmitDefaultValue=false)]
        public bool? EnableFilerAuditLogging { get; set; }

        /// <summary>
        /// If set, mixed mode (NFS and SMB) access is enabled for this view.
        /// </summary>
        /// <value>If set, mixed mode (NFS and SMB) access is enabled for this view.</value>
        [DataMember(Name="enableMixedModePermissions", EmitDefaultValue=false)]
        public bool? EnableMixedModePermissions { get; set; }

        /// <summary>
        /// Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.
        /// </summary>
        /// <value>Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.</value>
        [DataMember(Name="enableSmbAccessBasedEnumeration", EmitDefaultValue=false)]
        public bool? EnableSmbAccessBasedEnumeration { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=false)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files.
        /// </summary>
        /// <value>Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files.</value>
        [DataMember(Name="fileExtensionFilter", EmitDefaultValue=false)]
        public FileExtensionFilter FileExtensionFilter { get; set; }

        /// <summary>
        /// Gets or Sets LogicalQuota
        /// </summary>
        [DataMember(Name="logicalQuota", EmitDefaultValue=false)]
        public QuotaPolicy LogicalQuota { get; set; }


        /// <summary>
        /// Specifies the Quality of Service (QoS) Policy for the View.
        /// </summary>
        /// <value>Specifies the Quality of Service (QoS) Policy for the View.</value>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public QoS Qos { get; set; }

        /// <summary>
        /// Specifies the SMB permissions for the View.
        /// </summary>
        /// <value>Specifies the SMB permissions for the View.</value>
        [DataMember(Name="smbPermissionsInfo", EmitDefaultValue=false)]
        public SmbPermissionsInfo SmbPermissionsInfo { get; set; }

        /// <summary>
        /// Specifies the name of the source View that will be cloned.
        /// </summary>
        /// <value>Specifies the name of the source View that will be cloned.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=false)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View.
        /// </summary>
        /// <value>Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View.</value>
        [DataMember(Name="storagePolicyOverride", EmitDefaultValue=false)]
        public StoragePolicyOverride StoragePolicyOverride { get; set; }

        /// <summary>
        /// Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)
        /// </summary>
        /// <value>Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=false)]
        public List<Subnet> SubnetWhitelist { get; set; }

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
            return this.Equals(input as CloneViewRequest);
        }

        /// <summary>
        /// Returns true if CloneViewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneViewRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessSids == input.AccessSids ||
                    this.AccessSids != null &&
                    this.AccessSids.SequenceEqual(input.AccessSids)
                ) && 
                (
                    this.CloneViewName == input.CloneViewName ||
                    (this.CloneViewName != null &&
                    this.CloneViewName.Equals(input.CloneViewName))
                ) && 
                (
                    this.DataLockExpiryUsecs == input.DataLockExpiryUsecs ||
                    (this.DataLockExpiryUsecs != null &&
                    this.DataLockExpiryUsecs.Equals(input.DataLockExpiryUsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableFilerAuditLogging == input.EnableFilerAuditLogging ||
                    (this.EnableFilerAuditLogging != null &&
                    this.EnableFilerAuditLogging.Equals(input.EnableFilerAuditLogging))
                ) && 
                (
                    this.EnableMixedModePermissions == input.EnableMixedModePermissions ||
                    (this.EnableMixedModePermissions != null &&
                    this.EnableMixedModePermissions.Equals(input.EnableMixedModePermissions))
                ) && 
                (
                    this.EnableSmbAccessBasedEnumeration == input.EnableSmbAccessBasedEnumeration ||
                    (this.EnableSmbAccessBasedEnumeration != null &&
                    this.EnableSmbAccessBasedEnumeration.Equals(input.EnableSmbAccessBasedEnumeration))
                ) && 
                (
                    this.EnableSmbViewDiscovery == input.EnableSmbViewDiscovery ||
                    (this.EnableSmbViewDiscovery != null &&
                    this.EnableSmbViewDiscovery.Equals(input.EnableSmbViewDiscovery))
                ) && 
                (
                    this.FileExtensionFilter == input.FileExtensionFilter ||
                    (this.FileExtensionFilter != null &&
                    this.FileExtensionFilter.Equals(input.FileExtensionFilter))
                ) && 
                (
                    this.LogicalQuota == input.LogicalQuota ||
                    (this.LogicalQuota != null &&
                    this.LogicalQuota.Equals(input.LogicalQuota))
                ) && 
                (
                    this.ProtocolAccess == input.ProtocolAccess ||
                    (this.ProtocolAccess != null &&
                    this.ProtocolAccess.Equals(input.ProtocolAccess))
                ) && 
                (
                    this.Qos == input.Qos ||
                    (this.Qos != null &&
                    this.Qos.Equals(input.Qos))
                ) && 
                (
                    this.SmbPermissionsInfo == input.SmbPermissionsInfo ||
                    (this.SmbPermissionsInfo != null &&
                    this.SmbPermissionsInfo.Equals(input.SmbPermissionsInfo))
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
                ) && 
                (
                    this.StoragePolicyOverride == input.StoragePolicyOverride ||
                    (this.StoragePolicyOverride != null &&
                    this.StoragePolicyOverride.Equals(input.StoragePolicyOverride))
                ) && 
                (
                    this.SubnetWhitelist == input.SubnetWhitelist ||
                    this.SubnetWhitelist != null &&
                    this.SubnetWhitelist.SequenceEqual(input.SubnetWhitelist)
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
                if (this.AccessSids != null)
                    hashCode = hashCode * 59 + this.AccessSids.GetHashCode();
                if (this.CloneViewName != null)
                    hashCode = hashCode * 59 + this.CloneViewName.GetHashCode();
                if (this.DataLockExpiryUsecs != null)
                    hashCode = hashCode * 59 + this.DataLockExpiryUsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnableFilerAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableFilerAuditLogging.GetHashCode();
                if (this.EnableMixedModePermissions != null)
                    hashCode = hashCode * 59 + this.EnableMixedModePermissions.GetHashCode();
                if (this.EnableSmbAccessBasedEnumeration != null)
                    hashCode = hashCode * 59 + this.EnableSmbAccessBasedEnumeration.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.FileExtensionFilter != null)
                    hashCode = hashCode * 59 + this.FileExtensionFilter.GetHashCode();
                if (this.LogicalQuota != null)
                    hashCode = hashCode * 59 + this.LogicalQuota.GetHashCode();
                if (this.ProtocolAccess != null)
                    hashCode = hashCode * 59 + this.ProtocolAccess.GetHashCode();
                if (this.Qos != null)
                    hashCode = hashCode * 59 + this.Qos.GetHashCode();
                if (this.SmbPermissionsInfo != null)
                    hashCode = hashCode * 59 + this.SmbPermissionsInfo.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

