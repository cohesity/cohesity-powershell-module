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
    /// Provides details about the Storage Domain (View Box).
    /// </summary>
    [DataContract]
    public partial class CreateViewBoxParams :  IEquatable<CreateViewBoxParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateViewBoxParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateViewBoxParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateViewBoxParams" /> class.
        /// </summary>
        /// <param name="adDomainName">Specifies an active directory domain that this view box is mapped to..</param>
        /// <param name="clientSubnetWhiteList">Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests..</param>
        /// <param name="cloudDownWaterfallThresholdPct">Specifies the cloud down water-fall threshold percentage. This indicates how full should a viewbox at least be before we down water-fall its data to cloud tier. If this field is set, the physical quota limit must be set also and will be used as viewbox capacity..</param>
        /// <param name="cloudDownWaterfallThresholdSecs">Specifies the cloud down water-fall threshold seconds. This indicates what&#39;s the time threshold on water-falling data to cloud tier..</param>
        /// <param name="clusterPartitionId">Specifies the Cluster Partition id where the Storage Domain (View Box) is located. (required).</param>
        /// <param name="defaultUserQuotaPolicy">Specifies an optional quota policy/limits that are inherited by all users within the views in this viewbox..</param>
        /// <param name="defaultViewQuotaPolicy">Specifies an optional default logical quota limit (in bytes) for the Views in this Storage Domain (View Box). (Logical data is when the data is fully hydrated and expanded.) However, this inherited quota can be overwritten at the View level. A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="ldapProviderId">When set, the following provides the LDAP provider the view box is mapped to. For any view from this view box, when accessed via NFS the following LDAP provider is looked up for getting Unix IDs of the corresponding user. Similarly, when a view is accessed via SMB and if the AD user&#39;s domain matches with the view box&#39;s AD, the following LDAP provider will be used to lookup Unix IDs for the corresponding AD user. Additionally there is also a mapping between LDAP provider and AD domain that is stored in AD provider config. It will be used if AD is not set on the view box..</param>
        /// <param name="name">Specifies the name of the Storage Domain (View Box). (required).</param>
        /// <param name="physicalQuota">Specifies an optional quota limit (in bytes) for the physical usage of this Storage Domain (View Box). This quota limit defines a physical limit for size of the data that can be physically stored on the Storage Domain (View Box), after the data has been reduced by change block tracking, compression and deduplication. The physical usage is the aggregate sum of the data stored for this Storage Domain (View Box) on all disks in the Cluster. (The usage includes Cloud Tier data and user data.) A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="s3BucketsAllowed">Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed..</param>
        /// <param name="storagePolicy">storagePolicy.</param>
        /// <param name="tenantIdVec">Optional ids for the tenants that this view box belongs. This must be checked before granting access to users. Unless the cluster enables view box sharing between tenants is allowed, there shall be at most one item in this list. Note that if all tenant may be deleted - such viewboxes must be garbage collected. This is currently done by a background thread in iris..</param>
        public CreateViewBoxParams(string adDomainName = default(string), List<Subnet> clientSubnetWhiteList = default(List<Subnet>), int? cloudDownWaterfallThresholdPct = default(int?), int? cloudDownWaterfallThresholdSecs = default(int?), long? clusterPartitionId = default(long?), QuotaPolicy defaultUserQuotaPolicy = default(QuotaPolicy), QuotaPolicy defaultViewQuotaPolicy = default(QuotaPolicy), long? ldapProviderId = default(long?), string name = default(string), QuotaPolicy physicalQuota = default(QuotaPolicy), bool? s3BucketsAllowed = default(bool?), StoragePolicy storagePolicy = default(StoragePolicy), List<string> tenantIdVec = default(List<string>))
        {
            this.AdDomainName = adDomainName;
            this.ClientSubnetWhiteList = clientSubnetWhiteList;
            this.CloudDownWaterfallThresholdPct = cloudDownWaterfallThresholdPct;
            this.CloudDownWaterfallThresholdSecs = cloudDownWaterfallThresholdSecs;
            this.ClusterPartitionId = clusterPartitionId;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.LdapProviderId = ldapProviderId;
            this.Name = name;
            this.PhysicalQuota = physicalQuota;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.TenantIdVec = tenantIdVec;
            this.AdDomainName = adDomainName;
            this.ClientSubnetWhiteList = clientSubnetWhiteList;
            this.CloudDownWaterfallThresholdPct = cloudDownWaterfallThresholdPct;
            this.CloudDownWaterfallThresholdSecs = cloudDownWaterfallThresholdSecs;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.LdapProviderId = ldapProviderId;
            this.PhysicalQuota = physicalQuota;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.StoragePolicy = storagePolicy;
            this.TenantIdVec = tenantIdVec;
        }
        
        /// <summary>
        /// Specifies an active directory domain that this view box is mapped to.
        /// </summary>
        /// <value>Specifies an active directory domain that this view box is mapped to.</value>
        [DataMember(Name="adDomainName", EmitDefaultValue=true)]
        public string AdDomainName { get; set; }

        /// <summary>
        /// Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests.
        /// </summary>
        /// <value>Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests.</value>
        [DataMember(Name="clientSubnetWhiteList", EmitDefaultValue=true)]
        public List<Subnet> ClientSubnetWhiteList { get; set; }

        /// <summary>
        /// Specifies the cloud down water-fall threshold percentage. This indicates how full should a viewbox at least be before we down water-fall its data to cloud tier. If this field is set, the physical quota limit must be set also and will be used as viewbox capacity.
        /// </summary>
        /// <value>Specifies the cloud down water-fall threshold percentage. This indicates how full should a viewbox at least be before we down water-fall its data to cloud tier. If this field is set, the physical quota limit must be set also and will be used as viewbox capacity.</value>
        [DataMember(Name="cloudDownWaterfallThresholdPct", EmitDefaultValue=true)]
        public int? CloudDownWaterfallThresholdPct { get; set; }

        /// <summary>
        /// Specifies the cloud down water-fall threshold seconds. This indicates what&#39;s the time threshold on water-falling data to cloud tier.
        /// </summary>
        /// <value>Specifies the cloud down water-fall threshold seconds. This indicates what&#39;s the time threshold on water-falling data to cloud tier.</value>
        [DataMember(Name="cloudDownWaterfallThresholdSecs", EmitDefaultValue=true)]
        public int? CloudDownWaterfallThresholdSecs { get; set; }

        /// <summary>
        /// Specifies the Cluster Partition id where the Storage Domain (View Box) is located.
        /// </summary>
        /// <value>Specifies the Cluster Partition id where the Storage Domain (View Box) is located.</value>
        [DataMember(Name="clusterPartitionId", EmitDefaultValue=true)]
        public long? ClusterPartitionId { get; set; }

        /// <summary>
        /// Specifies an optional quota policy/limits that are inherited by all users within the views in this viewbox.
        /// </summary>
        /// <value>Specifies an optional quota policy/limits that are inherited by all users within the views in this viewbox.</value>
        [DataMember(Name="defaultUserQuotaPolicy", EmitDefaultValue=true)]
        public QuotaPolicy DefaultUserQuotaPolicy { get; set; }

        /// <summary>
        /// Specifies an optional default logical quota limit (in bytes) for the Views in this Storage Domain (View Box). (Logical data is when the data is fully hydrated and expanded.) However, this inherited quota can be overwritten at the View level. A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes.
        /// </summary>
        /// <value>Specifies an optional default logical quota limit (in bytes) for the Views in this Storage Domain (View Box). (Logical data is when the data is fully hydrated and expanded.) However, this inherited quota can be overwritten at the View level. A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes.</value>
        [DataMember(Name="defaultViewQuotaPolicy", EmitDefaultValue=true)]
        public QuotaPolicy DefaultViewQuotaPolicy { get; set; }

        /// <summary>
        /// When set, the following provides the LDAP provider the view box is mapped to. For any view from this view box, when accessed via NFS the following LDAP provider is looked up for getting Unix IDs of the corresponding user. Similarly, when a view is accessed via SMB and if the AD user&#39;s domain matches with the view box&#39;s AD, the following LDAP provider will be used to lookup Unix IDs for the corresponding AD user. Additionally there is also a mapping between LDAP provider and AD domain that is stored in AD provider config. It will be used if AD is not set on the view box.
        /// </summary>
        /// <value>When set, the following provides the LDAP provider the view box is mapped to. For any view from this view box, when accessed via NFS the following LDAP provider is looked up for getting Unix IDs of the corresponding user. Similarly, when a view is accessed via SMB and if the AD user&#39;s domain matches with the view box&#39;s AD, the following LDAP provider will be used to lookup Unix IDs for the corresponding AD user. Additionally there is also a mapping between LDAP provider and AD domain that is stored in AD provider config. It will be used if AD is not set on the view box.</value>
        [DataMember(Name="ldapProviderId", EmitDefaultValue=true)]
        public long? LdapProviderId { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box).</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies an optional quota limit (in bytes) for the physical usage of this Storage Domain (View Box). This quota limit defines a physical limit for size of the data that can be physically stored on the Storage Domain (View Box), after the data has been reduced by change block tracking, compression and deduplication. The physical usage is the aggregate sum of the data stored for this Storage Domain (View Box) on all disks in the Cluster. (The usage includes Cloud Tier data and user data.) A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes.
        /// </summary>
        /// <value>Specifies an optional quota limit (in bytes) for the physical usage of this Storage Domain (View Box). This quota limit defines a physical limit for size of the data that can be physically stored on the Storage Domain (View Box), after the data has been reduced by change block tracking, compression and deduplication. The physical usage is the aggregate sum of the data stored for this Storage Domain (View Box) on all disks in the Cluster. (The usage includes Cloud Tier data and user data.) A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes.</value>
        [DataMember(Name="physicalQuota", EmitDefaultValue=true)]
        public QuotaPolicy PhysicalQuota { get; set; }

        /// <summary>
        /// Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed.
        /// </summary>
        /// <value>Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed.</value>
        [DataMember(Name="s3BucketsAllowed", EmitDefaultValue=true)]
        public bool? S3BucketsAllowed { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicy
        /// </summary>
        [DataMember(Name="storagePolicy", EmitDefaultValue=false)]
        public StoragePolicy StoragePolicy { get; set; }

        /// <summary>
        /// Optional ids for the tenants that this view box belongs. This must be checked before granting access to users. Unless the cluster enables view box sharing between tenants is allowed, there shall be at most one item in this list. Note that if all tenant may be deleted - such viewboxes must be garbage collected. This is currently done by a background thread in iris.
        /// </summary>
        /// <value>Optional ids for the tenants that this view box belongs. This must be checked before granting access to users. Unless the cluster enables view box sharing between tenants is allowed, there shall be at most one item in this list. Note that if all tenant may be deleted - such viewboxes must be garbage collected. This is currently done by a background thread in iris.</value>
        [DataMember(Name="tenantIdVec", EmitDefaultValue=true)]
        public List<string> TenantIdVec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateViewBoxParams {\n");
            sb.Append("  AdDomainName: ").Append(AdDomainName).Append("\n");
            sb.Append("  ClientSubnetWhiteList: ").Append(ClientSubnetWhiteList).Append("\n");
            sb.Append("  CloudDownWaterfallThresholdPct: ").Append(CloudDownWaterfallThresholdPct).Append("\n");
            sb.Append("  CloudDownWaterfallThresholdSecs: ").Append(CloudDownWaterfallThresholdSecs).Append("\n");
            sb.Append("  ClusterPartitionId: ").Append(ClusterPartitionId).Append("\n");
            sb.Append("  DefaultUserQuotaPolicy: ").Append(DefaultUserQuotaPolicy).Append("\n");
            sb.Append("  DefaultViewQuotaPolicy: ").Append(DefaultViewQuotaPolicy).Append("\n");
            sb.Append("  LdapProviderId: ").Append(LdapProviderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhysicalQuota: ").Append(PhysicalQuota).Append("\n");
            sb.Append("  S3BucketsAllowed: ").Append(S3BucketsAllowed).Append("\n");
            sb.Append("  StoragePolicy: ").Append(StoragePolicy).Append("\n");
            sb.Append("  TenantIdVec: ").Append(TenantIdVec).Append("\n");
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
            return this.Equals(input as CreateViewBoxParams);
        }

        /// <summary>
        /// Returns true if CreateViewBoxParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateViewBoxParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateViewBoxParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdDomainName == input.AdDomainName ||
                    (this.AdDomainName != null &&
                    this.AdDomainName.Equals(input.AdDomainName))
                ) && 
                (
                    this.ClientSubnetWhiteList == input.ClientSubnetWhiteList ||
                    this.ClientSubnetWhiteList != null &&
                    input.ClientSubnetWhiteList != null &&
                    this.ClientSubnetWhiteList.SequenceEqual(input.ClientSubnetWhiteList)
                ) && 
                (
                    this.CloudDownWaterfallThresholdPct == input.CloudDownWaterfallThresholdPct ||
                    (this.CloudDownWaterfallThresholdPct != null &&
                    this.CloudDownWaterfallThresholdPct.Equals(input.CloudDownWaterfallThresholdPct))
                ) && 
                (
                    this.CloudDownWaterfallThresholdSecs == input.CloudDownWaterfallThresholdSecs ||
                    (this.CloudDownWaterfallThresholdSecs != null &&
                    this.CloudDownWaterfallThresholdSecs.Equals(input.CloudDownWaterfallThresholdSecs))
                ) && 
                (
                    this.ClusterPartitionId == input.ClusterPartitionId ||
                    (this.ClusterPartitionId != null &&
                    this.ClusterPartitionId.Equals(input.ClusterPartitionId))
                ) && 
                (
                    this.DefaultUserQuotaPolicy == input.DefaultUserQuotaPolicy ||
                    (this.DefaultUserQuotaPolicy != null &&
                    this.DefaultUserQuotaPolicy.Equals(input.DefaultUserQuotaPolicy))
                ) && 
                (
                    this.DefaultViewQuotaPolicy == input.DefaultViewQuotaPolicy ||
                    (this.DefaultViewQuotaPolicy != null &&
                    this.DefaultViewQuotaPolicy.Equals(input.DefaultViewQuotaPolicy))
                ) && 
                (
                    this.LdapProviderId == input.LdapProviderId ||
                    (this.LdapProviderId != null &&
                    this.LdapProviderId.Equals(input.LdapProviderId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PhysicalQuota == input.PhysicalQuota ||
                    (this.PhysicalQuota != null &&
                    this.PhysicalQuota.Equals(input.PhysicalQuota))
                ) && 
                (
                    this.S3BucketsAllowed == input.S3BucketsAllowed ||
                    (this.S3BucketsAllowed != null &&
                    this.S3BucketsAllowed.Equals(input.S3BucketsAllowed))
                ) && 
                (
                    this.StoragePolicy == input.StoragePolicy ||
                    (this.StoragePolicy != null &&
                    this.StoragePolicy.Equals(input.StoragePolicy))
                ) && 
                (
                    this.TenantIdVec == input.TenantIdVec ||
                    this.TenantIdVec != null &&
                    input.TenantIdVec != null &&
                    this.TenantIdVec.SequenceEqual(input.TenantIdVec)
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
                if (this.AdDomainName != null)
                    hashCode = hashCode * 59 + this.AdDomainName.GetHashCode();
                if (this.ClientSubnetWhiteList != null)
                    hashCode = hashCode * 59 + this.ClientSubnetWhiteList.GetHashCode();
                if (this.CloudDownWaterfallThresholdPct != null)
                    hashCode = hashCode * 59 + this.CloudDownWaterfallThresholdPct.GetHashCode();
                if (this.CloudDownWaterfallThresholdSecs != null)
                    hashCode = hashCode * 59 + this.CloudDownWaterfallThresholdSecs.GetHashCode();
                if (this.ClusterPartitionId != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionId.GetHashCode();
                if (this.DefaultUserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultUserQuotaPolicy.GetHashCode();
                if (this.DefaultViewQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultViewQuotaPolicy.GetHashCode();
                if (this.LdapProviderId != null)
                    hashCode = hashCode * 59 + this.LdapProviderId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhysicalQuota != null)
                    hashCode = hashCode * 59 + this.PhysicalQuota.GetHashCode();
                if (this.S3BucketsAllowed != null)
                    hashCode = hashCode * 59 + this.S3BucketsAllowed.GetHashCode();
                if (this.StoragePolicy != null)
                    hashCode = hashCode * 59 + this.StoragePolicy.GetHashCode();
                if (this.TenantIdVec != null)
                    hashCode = hashCode * 59 + this.TenantIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}
