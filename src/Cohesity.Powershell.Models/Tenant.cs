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
    /// Specifies details about a tenant.
    /// </summary>
    [DataContract]
    public partial class Tenant :  IEquatable<Tenant>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        /// <param name="activeDirectories">Specifies the active directories this tenant is associated to..</param>
        /// <param name="bifrostEnabled">Specifies whether bifrost (Ambassador proxy) is enabled for tenant..</param>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the tenant account was created on the Cohesity Cluster..</param>
        /// <param name="deleted">Specifies if the Tenant is deleted..</param>
        /// <param name="deletedTimeMsecs">Specifies the timestamp at which the tenant was deleted..</param>
        /// <param name="deletionFinished">Specifies if the object collection is complete for the tenant..</param>
        /// <param name="deletionInfoVec">Specifies the current deletion state of object categories..</param>
        /// <param name="description">Specifies the description of this tenant..</param>
        /// <param name="entityIds">Specifies the EntityIds this tenant is associated to..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the tenant account was last modified on the Cohesity Cluster..</param>
        /// <param name="ldapProviders">Specifies the ldap providers this tenant is associated to..</param>
        /// <param name="name">Specifies the name of the tenant..</param>
        /// <param name="orgSuffix">Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc..</param>
        /// <param name="parentTenantId">Specifies the parent tenant of this tenant if available..</param>
        /// <param name="policyIds">Specifies the PolicyIds this tenant is associated to..</param>
        /// <param name="protectionJobs">Specifies the ProtectionJobs this tenant is associated to..</param>
        /// <param name="subscribeToAlertEmails">Service provider can optionally unsubscribe from the Tenant Alert Emails..</param>
        /// <param name="tenantId">Specifies the unique id of the tenant..</param>
        /// <param name="viewBoxIds">Specifies the ViewBoxIds this tenant is associated to..</param>
        /// <param name="views">Specifies the Views this tenant is associated to..</param>
        /// <param name="vlanIfaceNames">Specifies the VlanIfaceNames this tenant is associated to, in the format of bond1.200..</param>
        public Tenant(List<ActiveDirectoryEntry> activeDirectories = default(List<ActiveDirectoryEntry>), bool? bifrostEnabled = default(bool?), long? createdTimeMsecs = default(long?), bool? deleted = default(bool?), long? deletedTimeMsecs = default(long?), bool? deletionFinished = default(bool?), List<TenantDeletionInfo> deletionInfoVec = default(List<TenantDeletionInfo>), string description = default(string), List<long> entityIds = default(List<long>), long? lastUpdatedTimeMsecs = default(long?), List<LdapProviderResponse> ldapProviders = default(List<LdapProviderResponse>), string name = default(string), string orgSuffix = default(string), string parentTenantId = default(string), List<string> policyIds = default(List<string>), List<BackupJobProto> protectionJobs = default(List<BackupJobProto>), bool? subscribeToAlertEmails = default(bool?), string tenantId = default(string), List<long> viewBoxIds = default(List<long>), List<View> views = default(List<View>), List<string> vlanIfaceNames = default(List<string>))
        {
            this.ActiveDirectories = activeDirectories;
            this.BifrostEnabled = bifrostEnabled;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Deleted = deleted;
            this.DeletedTimeMsecs = deletedTimeMsecs;
            this.DeletionFinished = deletionFinished;
            this.DeletionInfoVec = deletionInfoVec;
            this.Description = description;
            this.EntityIds = entityIds;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.LdapProviders = ldapProviders;
            this.Name = name;
            this.OrgSuffix = orgSuffix;
            this.ParentTenantId = parentTenantId;
            this.PolicyIds = policyIds;
            this.ProtectionJobs = protectionJobs;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
            this.TenantId = tenantId;
            this.ViewBoxIds = viewBoxIds;
            this.Views = views;
            this.VlanIfaceNames = vlanIfaceNames;
            this.ActiveDirectories = activeDirectories;
            this.BifrostEnabled = bifrostEnabled;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Deleted = deleted;
            this.DeletedTimeMsecs = deletedTimeMsecs;
            this.DeletionFinished = deletionFinished;
            this.DeletionInfoVec = deletionInfoVec;
            this.Description = description;
            this.EntityIds = entityIds;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.LdapProviders = ldapProviders;
            this.Name = name;
            this.OrgSuffix = orgSuffix;
            this.ParentTenantId = parentTenantId;
            this.PolicyIds = policyIds;
            this.ProtectionJobs = protectionJobs;
            this.SubscribeToAlertEmails = subscribeToAlertEmails;
            this.TenantId = tenantId;
            this.ViewBoxIds = viewBoxIds;
            this.Views = views;
            this.VlanIfaceNames = vlanIfaceNames;
        }
        
        /// <summary>
        /// Specifies the active directories this tenant is associated to.
        /// </summary>
        /// <value>Specifies the active directories this tenant is associated to.</value>
        [DataMember(Name="activeDirectories", EmitDefaultValue=true)]
        public List<ActiveDirectoryEntry> ActiveDirectories { get; set; }

        /// <summary>
        /// Specifies whether bifrost (Ambassador proxy) is enabled for tenant.
        /// </summary>
        /// <value>Specifies whether bifrost (Ambassador proxy) is enabled for tenant.</value>
        [DataMember(Name="bifrostEnabled", EmitDefaultValue=true)]
        public bool? BifrostEnabled { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant account was created on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant account was created on the Cohesity Cluster.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies if the Tenant is deleted.
        /// </summary>
        /// <value>Specifies if the Tenant is deleted.</value>
        [DataMember(Name="deleted", EmitDefaultValue=true)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Specifies the timestamp at which the tenant was deleted.
        /// </summary>
        /// <value>Specifies the timestamp at which the tenant was deleted.</value>
        [DataMember(Name="deletedTimeMsecs", EmitDefaultValue=true)]
        public long? DeletedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies if the object collection is complete for the tenant.
        /// </summary>
        /// <value>Specifies if the object collection is complete for the tenant.</value>
        [DataMember(Name="deletionFinished", EmitDefaultValue=true)]
        public bool? DeletionFinished { get; set; }

        /// <summary>
        /// Specifies the current deletion state of object categories.
        /// </summary>
        /// <value>Specifies the current deletion state of object categories.</value>
        [DataMember(Name="deletionInfoVec", EmitDefaultValue=true)]
        public List<TenantDeletionInfo> DeletionInfoVec { get; set; }

        /// <summary>
        /// Specifies the description of this tenant.
        /// </summary>
        /// <value>Specifies the description of this tenant.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the EntityIds this tenant is associated to.
        /// </summary>
        /// <value>Specifies the EntityIds this tenant is associated to.</value>
        [DataMember(Name="entityIds", EmitDefaultValue=true)]
        public List<long> EntityIds { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the tenant account was last modified on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the tenant account was last modified on the Cohesity Cluster.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the ldap providers this tenant is associated to.
        /// </summary>
        /// <value>Specifies the ldap providers this tenant is associated to.</value>
        [DataMember(Name="ldapProviders", EmitDefaultValue=true)]
        public List<LdapProviderResponse> LdapProviders { get; set; }

        /// <summary>
        /// Specifies the name of the tenant.
        /// </summary>
        /// <value>Specifies the name of the tenant.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc.
        /// </summary>
        /// <value>Specifies the organization suffix needed to construct tenant id. Tenant id is not completely auto generated rather chosen by tenant/SP admin as we needed same tenant id on multiple clusters to support replication across clusters, etc.</value>
        [DataMember(Name="orgSuffix", EmitDefaultValue=true)]
        public string OrgSuffix { get; set; }

        /// <summary>
        /// Specifies the parent tenant of this tenant if available.
        /// </summary>
        /// <value>Specifies the parent tenant of this tenant if available.</value>
        [DataMember(Name="parentTenantId", EmitDefaultValue=true)]
        public string ParentTenantId { get; set; }

        /// <summary>
        /// Specifies the PolicyIds this tenant is associated to.
        /// </summary>
        /// <value>Specifies the PolicyIds this tenant is associated to.</value>
        [DataMember(Name="policyIds", EmitDefaultValue=true)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// Specifies the ProtectionJobs this tenant is associated to.
        /// </summary>
        /// <value>Specifies the ProtectionJobs this tenant is associated to.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=true)]
        public List<BackupJobProto> ProtectionJobs { get; set; }

        /// <summary>
        /// Service provider can optionally unsubscribe from the Tenant Alert Emails.
        /// </summary>
        /// <value>Service provider can optionally unsubscribe from the Tenant Alert Emails.</value>
        [DataMember(Name="subscribeToAlertEmails", EmitDefaultValue=true)]
        public bool? SubscribeToAlertEmails { get; set; }

        /// <summary>
        /// Specifies the unique id of the tenant.
        /// </summary>
        /// <value>Specifies the unique id of the tenant.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies the ViewBoxIds this tenant is associated to.
        /// </summary>
        /// <value>Specifies the ViewBoxIds this tenant is associated to.</value>
        [DataMember(Name="viewBoxIds", EmitDefaultValue=true)]
        public List<long> ViewBoxIds { get; set; }

        /// <summary>
        /// Specifies the Views this tenant is associated to.
        /// </summary>
        /// <value>Specifies the Views this tenant is associated to.</value>
        [DataMember(Name="views", EmitDefaultValue=true)]
        public List<View> Views { get; set; }

        /// <summary>
        /// Specifies the VlanIfaceNames this tenant is associated to, in the format of bond1.200.
        /// </summary>
        /// <value>Specifies the VlanIfaceNames this tenant is associated to, in the format of bond1.200.</value>
        [DataMember(Name="vlanIfaceNames", EmitDefaultValue=true)]
        public List<string> VlanIfaceNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tenant {\n");
            sb.Append("  ActiveDirectories: ").Append(ActiveDirectories).Append("\n");
            sb.Append("  BifrostEnabled: ").Append(BifrostEnabled).Append("\n");
            sb.Append("  CreatedTimeMsecs: ").Append(CreatedTimeMsecs).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  DeletedTimeMsecs: ").Append(DeletedTimeMsecs).Append("\n");
            sb.Append("  DeletionFinished: ").Append(DeletionFinished).Append("\n");
            sb.Append("  DeletionInfoVec: ").Append(DeletionInfoVec).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EntityIds: ").Append(EntityIds).Append("\n");
            sb.Append("  LastUpdatedTimeMsecs: ").Append(LastUpdatedTimeMsecs).Append("\n");
            sb.Append("  LdapProviders: ").Append(LdapProviders).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgSuffix: ").Append(OrgSuffix).Append("\n");
            sb.Append("  ParentTenantId: ").Append(ParentTenantId).Append("\n");
            sb.Append("  PolicyIds: ").Append(PolicyIds).Append("\n");
            sb.Append("  ProtectionJobs: ").Append(ProtectionJobs).Append("\n");
            sb.Append("  SubscribeToAlertEmails: ").Append(SubscribeToAlertEmails).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ViewBoxIds: ").Append(ViewBoxIds).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  VlanIfaceNames: ").Append(VlanIfaceNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as Tenant);
        }

        /// <summary>
        /// Returns true if Tenant instances are equal
        /// </summary>
        /// <param name="input">Instance of Tenant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tenant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveDirectories == input.ActiveDirectories ||
                    this.ActiveDirectories != null &&
                    input.ActiveDirectories != null &&
                    this.ActiveDirectories.SequenceEqual(input.ActiveDirectories)
                ) && 
                (
                    this.BifrostEnabled == input.BifrostEnabled ||
                    (this.BifrostEnabled != null &&
                    this.BifrostEnabled.Equals(input.BifrostEnabled))
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.DeletedTimeMsecs == input.DeletedTimeMsecs ||
                    (this.DeletedTimeMsecs != null &&
                    this.DeletedTimeMsecs.Equals(input.DeletedTimeMsecs))
                ) && 
                (
                    this.DeletionFinished == input.DeletionFinished ||
                    (this.DeletionFinished != null &&
                    this.DeletionFinished.Equals(input.DeletionFinished))
                ) && 
                (
                    this.DeletionInfoVec == input.DeletionInfoVec ||
                    this.DeletionInfoVec != null &&
                    input.DeletionInfoVec != null &&
                    this.DeletionInfoVec.SequenceEqual(input.DeletionInfoVec)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EntityIds == input.EntityIds ||
                    this.EntityIds != null &&
                    input.EntityIds != null &&
                    this.EntityIds.SequenceEqual(input.EntityIds)
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.LdapProviders == input.LdapProviders ||
                    this.LdapProviders != null &&
                    input.LdapProviders != null &&
                    this.LdapProviders.SequenceEqual(input.LdapProviders)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrgSuffix == input.OrgSuffix ||
                    (this.OrgSuffix != null &&
                    this.OrgSuffix.Equals(input.OrgSuffix))
                ) && 
                (
                    this.ParentTenantId == input.ParentTenantId ||
                    (this.ParentTenantId != null &&
                    this.ParentTenantId.Equals(input.ParentTenantId))
                ) && 
                (
                    this.PolicyIds == input.PolicyIds ||
                    this.PolicyIds != null &&
                    input.PolicyIds != null &&
                    this.PolicyIds.SequenceEqual(input.PolicyIds)
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    input.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
                ) && 
                (
                    this.SubscribeToAlertEmails == input.SubscribeToAlertEmails ||
                    (this.SubscribeToAlertEmails != null &&
                    this.SubscribeToAlertEmails.Equals(input.SubscribeToAlertEmails))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ViewBoxIds == input.ViewBoxIds ||
                    this.ViewBoxIds != null &&
                    input.ViewBoxIds != null &&
                    this.ViewBoxIds.SequenceEqual(input.ViewBoxIds)
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    input.Views != null &&
                    this.Views.SequenceEqual(input.Views)
                ) && 
                (
                    this.VlanIfaceNames == input.VlanIfaceNames ||
                    this.VlanIfaceNames != null &&
                    input.VlanIfaceNames != null &&
                    this.VlanIfaceNames.SequenceEqual(input.VlanIfaceNames)
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
                if (this.ActiveDirectories != null)
                    hashCode = hashCode * 59 + this.ActiveDirectories.GetHashCode();
                if (this.BifrostEnabled != null)
                    hashCode = hashCode * 59 + this.BifrostEnabled.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.DeletedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.DeletedTimeMsecs.GetHashCode();
                if (this.DeletionFinished != null)
                    hashCode = hashCode * 59 + this.DeletionFinished.GetHashCode();
                if (this.DeletionInfoVec != null)
                    hashCode = hashCode * 59 + this.DeletionInfoVec.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EntityIds != null)
                    hashCode = hashCode * 59 + this.EntityIds.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                if (this.LdapProviders != null)
                    hashCode = hashCode * 59 + this.LdapProviders.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrgSuffix != null)
                    hashCode = hashCode * 59 + this.OrgSuffix.GetHashCode();
                if (this.ParentTenantId != null)
                    hashCode = hashCode * 59 + this.ParentTenantId.GetHashCode();
                if (this.PolicyIds != null)
                    hashCode = hashCode * 59 + this.PolicyIds.GetHashCode();
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
                if (this.SubscribeToAlertEmails != null)
                    hashCode = hashCode * 59 + this.SubscribeToAlertEmails.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ViewBoxIds != null)
                    hashCode = hashCode * 59 + this.ViewBoxIds.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.VlanIfaceNames != null)
                    hashCode = hashCode * 59 + this.VlanIfaceNames.GetHashCode();
                return hashCode;
            }
        }

    }

}
