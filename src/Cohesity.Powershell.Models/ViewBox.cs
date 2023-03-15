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
    /// Provides details about a Storage Domain (View Box).
    /// </summary>
    [DataContract]
    public partial class ViewBox :  IEquatable<ViewBox>
    {
        /// <summary>
        /// Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalStateEnum
        {
            /// <summary>
            /// Enum KDontRemove for value: kDontRemove
            /// </summary>
            [EnumMember(Value = "kDontRemove")]
            KDontRemove = 1,

            /// <summary>
            /// Enum KMarkedForRemoval for value: kMarkedForRemoval
            /// </summary>
            [EnumMember(Value = "kMarkedForRemoval")]
            KMarkedForRemoval = 2,

            /// <summary>
            /// Enum KOkToRemove for value: kOkToRemove
            /// </summary>
            [EnumMember(Value = "kOkToRemove")]
            KOkToRemove = 3

        }

        /// <summary>
        /// Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [DataMember(Name="removalState", EmitDefaultValue=true)]
        public RemovalStateEnum? RemovalState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBox" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViewBox() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBox" /> class.
        /// </summary>
        /// <param name="adDomainName">Specifies an active directory domain that this view box is mapped to..</param>
        /// <param name="brickSize">Specifies the default brick size used by the viewbox..</param>
        /// <param name="clientSubnetWhiteList">Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests..</param>
        /// <param name="cloudDomainId">Specifies the associated cloud domain Id..</param>
        /// <param name="cloudDownWaterfallThresholdPct">Specifies the cloud down water-fall threshold percentage. This indicates how full should a viewbox at least be before we down water-fall its data to cloud tier. If this field is set, the physical quota limit must be set also and will be used as viewbox capacity..</param>
        /// <param name="cloudDownWaterfallThresholdSecs">Specifies the cloud down water-fall threshold seconds. This indicates what&#39;s the time threshold on water-falling data to cloud tier..</param>
        /// <param name="clusterPartitionId">Specifies the Cluster Partition id where the Storage Domain (View Box) is located. (required).</param>
        /// <param name="defaultUserQuotaPolicy">Specifies an optional quota policy/limits that are inherited by all users within the views in this viewbox..</param>
        /// <param name="defaultViewQuotaPolicy">Specifies an optional default logical quota limit (in bytes) for the Views in this Storage Domain (View Box). (Logical data is when the data is fully hydrated and expanded.) However, this inherited quota can be overwritten at the View level. A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="dekRotationEnabled">Specifies whether DEK(Data Encryption Key) rotation is enabled for this viewbox. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed..</param>
        /// <param name="directArchiveEnabled">Specifies whether this viewbox can be used as a staging area while copying a largedataset that can&#39;t fit on the cluster to an external target. The amount of data that can be stored on the viewbox can be specified using &#39;physical_quota&#39;..</param>
        /// <param name="id">Specifies the Id of the Storage Domain (View Box)..</param>
        /// <param name="isRecommended">Recommendation for the view if the template id was passed during query. We say the view is to be recommended, if the dedup and inlinecompression both are same as the template&#39;s property..</param>
        /// <param name="kerberosRealmName">Specifies the Kerberos domain that this view box is mapped to..</param>
        /// <param name="kmsServerId">Specifies the associated KMS Server ID..</param>
        /// <param name="ldapProviderId">When set, the following provides the LDAP provider the view box is mapped to. For any view from this view box, when accessed via NFS the following LDAP provider is looked up for getting Unix IDs of the corresponding user. Similarly, when a view is accessed via SMB and if the AD user&#39;s domain matches with the view box&#39;s AD, the following LDAP provider will be used to lookup Unix IDs for the corresponding AD user. Additionally there is also a mapping between LDAP provider and AD domain that is stored in AD provider config. It will be used if AD is not set on the view box..</param>
        /// <param name="name">Specifies the name of the Storage Domain (View Box). (required).</param>
        /// <param name="nisDomainNameVec">Specifies the NIS domain that this view box is mapped to..</param>
        /// <param name="physicalQuota">Specifies an optional quota limit (in bytes) for the physical usage of this Storage Domain (View Box). This quota limit defines a physical limit for size of the data that can be physically stored on the Storage Domain (View Box), after the data has been reduced by change block tracking, compression and deduplication. The physical usage is the aggregate sum of the data stored for this Storage Domain (View Box) on all disks in the Cluster. (The usage includes Cloud Tier data and user data.) A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the Storage Domain (View Box), as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="removalState">Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster..</param>
        /// <param name="s3BucketsAllowed">Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed..</param>
        /// <param name="schemaInfoList">Specifies the time series schema info of the view box..</param>
        /// <param name="stats">stats.</param>
        /// <param name="storagePolicy">storagePolicy.</param>
        /// <param name="tenantIdVec">Optional ids for the tenants that this view box belongs. This must be checked before granting access to users. Unless the cluster enables view box sharing between tenants is allowed, there shall be at most one item in this list. Note that if all tenant may be deleted - such viewboxes must be garbage collected. This is currently done by a background thread in iris..</param>
        /// <param name="treatFileSyncAsDataSync">If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance..</param>
        /// <param name="updatedBrickSize">Specifies the brick size to be used by the viewbox for creating any new blobs..</param>
        /// <param name="vaultId">Specifies the associated vault Id..</param>
        public ViewBox(string adDomainName = default(string), int? brickSize = default(int?), List<Subnet> clientSubnetWhiteList = default(List<Subnet>), long? cloudDomainId = default(long?), int? cloudDownWaterfallThresholdPct = default(int?), int? cloudDownWaterfallThresholdSecs = default(int?), long? clusterPartitionId = default(long?), QuotaPolicy defaultUserQuotaPolicy = default(QuotaPolicy), QuotaPolicy defaultViewQuotaPolicy = default(QuotaPolicy), bool? dekRotationEnabled = default(bool?), bool? directArchiveEnabled = default(bool?), long? id = default(long?), bool? isRecommended = default(bool?), string kerberosRealmName = default(string), long? kmsServerId = default(long?), long? ldapProviderId = default(long?), string name = default(string), List<string> nisDomainNameVec = default(List<string>), QuotaPolicy physicalQuota = default(QuotaPolicy), RemovalStateEnum? removalState = default(RemovalStateEnum?), bool? s3BucketsAllowed = default(bool?), List<SchemaInfo> schemaInfoList = default(List<SchemaInfo>), ViewBoxStats stats = default(ViewBoxStats), StoragePolicy storagePolicy = default(StoragePolicy), List<string> tenantIdVec = default(List<string>), bool? treatFileSyncAsDataSync = default(bool?), int? updatedBrickSize = default(int?), long? vaultId = default(long?))
        {
            this.AdDomainName = adDomainName;
            this.BrickSize = brickSize;
            this.ClientSubnetWhiteList = clientSubnetWhiteList;
            this.CloudDomainId = cloudDomainId;
            this.CloudDownWaterfallThresholdPct = cloudDownWaterfallThresholdPct;
            this.CloudDownWaterfallThresholdSecs = cloudDownWaterfallThresholdSecs;
            this.ClusterPartitionId = clusterPartitionId;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.DekRotationEnabled = dekRotationEnabled;
            this.DirectArchiveEnabled = directArchiveEnabled;
            this.Id = id;
            this.IsRecommended = isRecommended;
            this.KerberosRealmName = kerberosRealmName;
            this.KmsServerId = kmsServerId;
            this.LdapProviderId = ldapProviderId;
            this.Name = name;
            this.NisDomainNameVec = nisDomainNameVec;
            this.PhysicalQuota = physicalQuota;
            this.RemovalState = removalState;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.SchemaInfoList = schemaInfoList;
            this.TenantIdVec = tenantIdVec;
            this.TreatFileSyncAsDataSync = treatFileSyncAsDataSync;
            this.UpdatedBrickSize = updatedBrickSize;
            this.VaultId = vaultId;
            this.AdDomainName = adDomainName;
            this.BrickSize = brickSize;
            this.ClientSubnetWhiteList = clientSubnetWhiteList;
            this.CloudDomainId = cloudDomainId;
            this.CloudDownWaterfallThresholdPct = cloudDownWaterfallThresholdPct;
            this.CloudDownWaterfallThresholdSecs = cloudDownWaterfallThresholdSecs;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.DekRotationEnabled = dekRotationEnabled;
            this.DirectArchiveEnabled = directArchiveEnabled;
            this.Id = id;
            this.IsRecommended = isRecommended;
            this.KerberosRealmName = kerberosRealmName;
            this.KmsServerId = kmsServerId;
            this.LdapProviderId = ldapProviderId;
            this.NisDomainNameVec = nisDomainNameVec;
            this.PhysicalQuota = physicalQuota;
            this.RemovalState = removalState;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.SchemaInfoList = schemaInfoList;
            this.Stats = stats;
            this.StoragePolicy = storagePolicy;
            this.TenantIdVec = tenantIdVec;
            this.TreatFileSyncAsDataSync = treatFileSyncAsDataSync;
            this.UpdatedBrickSize = updatedBrickSize;
            this.VaultId = vaultId;
        }
        
        /// <summary>
        /// Specifies an active directory domain that this view box is mapped to.
        /// </summary>
        /// <value>Specifies an active directory domain that this view box is mapped to.</value>
        [DataMember(Name="adDomainName", EmitDefaultValue=true)]
        public string AdDomainName { get; set; }

        /// <summary>
        /// Specifies the default brick size used by the viewbox.
        /// </summary>
        /// <value>Specifies the default brick size used by the viewbox.</value>
        [DataMember(Name="brickSize", EmitDefaultValue=true)]
        public int? BrickSize { get; set; }

        /// <summary>
        /// Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests.
        /// </summary>
        /// <value>Array of Subnets.  Specifies the Subnets from which this Storage Domain (View Box) accepts requests.</value>
        [DataMember(Name="clientSubnetWhiteList", EmitDefaultValue=true)]
        public List<Subnet> ClientSubnetWhiteList { get; set; }

        /// <summary>
        /// Specifies the associated cloud domain Id.
        /// </summary>
        /// <value>Specifies the associated cloud domain Id.</value>
        [DataMember(Name="cloudDomainId", EmitDefaultValue=true)]
        public long? CloudDomainId { get; set; }

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
        /// Specifies the Cohesity Cluster name where the Storage Domain (View Box) is located.
        /// </summary>
        /// <value>Specifies the Cohesity Cluster name where the Storage Domain (View Box) is located.</value>
        [DataMember(Name="clusterPartitionName", EmitDefaultValue=true)]
        public string ClusterPartitionName { get; private set; }

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
        /// Specifies whether DEK(Data Encryption Key) rotation is enabled for this viewbox. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed.
        /// </summary>
        /// <value>Specifies whether DEK(Data Encryption Key) rotation is enabled for this viewbox. This is applicable only when the viewbox uses AWS or similar KMS in which the KEK (Key Encryption Key) is not created and maintained by Cohesity. For Internal KMS and keys stored in Safenet servers, DEK rotation will not be performed.</value>
        [DataMember(Name="dekRotationEnabled", EmitDefaultValue=true)]
        public bool? DekRotationEnabled { get; set; }

        /// <summary>
        /// Specifies whether this viewbox can be used as a staging area while copying a largedataset that can&#39;t fit on the cluster to an external target. The amount of data that can be stored on the viewbox can be specified using &#39;physical_quota&#39;.
        /// </summary>
        /// <value>Specifies whether this viewbox can be used as a staging area while copying a largedataset that can&#39;t fit on the cluster to an external target. The amount of data that can be stored on the viewbox can be specified using &#39;physical_quota&#39;.</value>
        [DataMember(Name="directArchiveEnabled", EmitDefaultValue=true)]
        public bool? DirectArchiveEnabled { get; set; }

        /// <summary>
        /// Specifies the Id of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the Id of the Storage Domain (View Box).</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Recommendation for the view if the template id was passed during query. We say the view is to be recommended, if the dedup and inlinecompression both are same as the template&#39;s property.
        /// </summary>
        /// <value>Recommendation for the view if the template id was passed during query. We say the view is to be recommended, if the dedup and inlinecompression both are same as the template&#39;s property.</value>
        [DataMember(Name="isRecommended", EmitDefaultValue=true)]
        public bool? IsRecommended { get; set; }

        /// <summary>
        /// Specifies the Kerberos domain that this view box is mapped to.
        /// </summary>
        /// <value>Specifies the Kerberos domain that this view box is mapped to.</value>
        [DataMember(Name="kerberosRealmName", EmitDefaultValue=true)]
        public string KerberosRealmName { get; set; }

        /// <summary>
        /// Specifies the associated KMS Server ID.
        /// </summary>
        /// <value>Specifies the associated KMS Server ID.</value>
        [DataMember(Name="kmsServerId", EmitDefaultValue=true)]
        public long? KmsServerId { get; set; }

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
        /// Specifies the NIS domain that this view box is mapped to.
        /// </summary>
        /// <value>Specifies the NIS domain that this view box is mapped to.</value>
        [DataMember(Name="nisDomainNameVec", EmitDefaultValue=true)]
        public List<string> NisDomainNameVec { get; set; }

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
        /// Specifies the time series schema info of the view box.
        /// </summary>
        /// <value>Specifies the time series schema info of the view box.</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<SchemaInfo> SchemaInfoList { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ViewBoxStats Stats { get; set; }

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
        /// If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance.
        /// </summary>
        /// <value>If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance.</value>
        [DataMember(Name="treatFileSyncAsDataSync", EmitDefaultValue=true)]
        public bool? TreatFileSyncAsDataSync { get; set; }

        /// <summary>
        /// Specifies the brick size to be used by the viewbox for creating any new blobs.
        /// </summary>
        /// <value>Specifies the brick size to be used by the viewbox for creating any new blobs.</value>
        [DataMember(Name="updatedBrickSize", EmitDefaultValue=true)]
        public int? UpdatedBrickSize { get; set; }

        /// <summary>
        /// Specifies the associated vault Id.
        /// </summary>
        /// <value>Specifies the associated vault Id.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

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
            return this.Equals(input as ViewBox);
        }

        /// <summary>
        /// Returns true if ViewBox instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewBox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewBox input)
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
                    this.BrickSize == input.BrickSize ||
                    (this.BrickSize != null &&
                    this.BrickSize.Equals(input.BrickSize))
                ) && 
                (
                    this.ClientSubnetWhiteList == input.ClientSubnetWhiteList ||
                    this.ClientSubnetWhiteList != null &&
                    input.ClientSubnetWhiteList != null &&
                    this.ClientSubnetWhiteList.SequenceEqual(input.ClientSubnetWhiteList)
                ) && 
                (
                    this.CloudDomainId == input.CloudDomainId ||
                    (this.CloudDomainId != null &&
                    this.CloudDomainId.Equals(input.CloudDomainId))
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
                    this.ClusterPartitionName == input.ClusterPartitionName ||
                    (this.ClusterPartitionName != null &&
                    this.ClusterPartitionName.Equals(input.ClusterPartitionName))
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
                    this.DekRotationEnabled == input.DekRotationEnabled ||
                    (this.DekRotationEnabled != null &&
                    this.DekRotationEnabled.Equals(input.DekRotationEnabled))
                ) && 
                (
                    this.DirectArchiveEnabled == input.DirectArchiveEnabled ||
                    (this.DirectArchiveEnabled != null &&
                    this.DirectArchiveEnabled.Equals(input.DirectArchiveEnabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsRecommended == input.IsRecommended ||
                    (this.IsRecommended != null &&
                    this.IsRecommended.Equals(input.IsRecommended))
                ) && 
                (
                    this.KerberosRealmName == input.KerberosRealmName ||
                    (this.KerberosRealmName != null &&
                    this.KerberosRealmName.Equals(input.KerberosRealmName))
                ) && 
                (
                    this.KmsServerId == input.KmsServerId ||
                    (this.KmsServerId != null &&
                    this.KmsServerId.Equals(input.KmsServerId))
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
                    this.NisDomainNameVec == input.NisDomainNameVec ||
                    this.NisDomainNameVec != null &&
                    input.NisDomainNameVec != null &&
                    this.NisDomainNameVec.SequenceEqual(input.NisDomainNameVec)
                ) && 
                (
                    this.PhysicalQuota == input.PhysicalQuota ||
                    (this.PhysicalQuota != null &&
                    this.PhysicalQuota.Equals(input.PhysicalQuota))
                ) && 
                (
                    this.RemovalState == input.RemovalState ||
                    this.RemovalState.Equals(input.RemovalState)
                ) && 
                (
                    this.S3BucketsAllowed == input.S3BucketsAllowed ||
                    (this.S3BucketsAllowed != null &&
                    this.S3BucketsAllowed.Equals(input.S3BucketsAllowed))
                ) && 
                (
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    input.SchemaInfoList != null &&
                    this.SchemaInfoList.SequenceEqual(input.SchemaInfoList)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                ) && 
                (
                    this.TreatFileSyncAsDataSync == input.TreatFileSyncAsDataSync ||
                    (this.TreatFileSyncAsDataSync != null &&
                    this.TreatFileSyncAsDataSync.Equals(input.TreatFileSyncAsDataSync))
                ) && 
                (
                    this.UpdatedBrickSize == input.UpdatedBrickSize ||
                    (this.UpdatedBrickSize != null &&
                    this.UpdatedBrickSize.Equals(input.UpdatedBrickSize))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.BrickSize != null)
                    hashCode = hashCode * 59 + this.BrickSize.GetHashCode();
                if (this.ClientSubnetWhiteList != null)
                    hashCode = hashCode * 59 + this.ClientSubnetWhiteList.GetHashCode();
                if (this.CloudDomainId != null)
                    hashCode = hashCode * 59 + this.CloudDomainId.GetHashCode();
                if (this.CloudDownWaterfallThresholdPct != null)
                    hashCode = hashCode * 59 + this.CloudDownWaterfallThresholdPct.GetHashCode();
                if (this.CloudDownWaterfallThresholdSecs != null)
                    hashCode = hashCode * 59 + this.CloudDownWaterfallThresholdSecs.GetHashCode();
                if (this.ClusterPartitionId != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionId.GetHashCode();
                if (this.ClusterPartitionName != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionName.GetHashCode();
                if (this.DefaultUserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultUserQuotaPolicy.GetHashCode();
                if (this.DefaultViewQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultViewQuotaPolicy.GetHashCode();
                if (this.DekRotationEnabled != null)
                    hashCode = hashCode * 59 + this.DekRotationEnabled.GetHashCode();
                if (this.DirectArchiveEnabled != null)
                    hashCode = hashCode * 59 + this.DirectArchiveEnabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsRecommended != null)
                    hashCode = hashCode * 59 + this.IsRecommended.GetHashCode();
                if (this.KerberosRealmName != null)
                    hashCode = hashCode * 59 + this.KerberosRealmName.GetHashCode();
                if (this.KmsServerId != null)
                    hashCode = hashCode * 59 + this.KmsServerId.GetHashCode();
                if (this.LdapProviderId != null)
                    hashCode = hashCode * 59 + this.LdapProviderId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NisDomainNameVec != null)
                    hashCode = hashCode * 59 + this.NisDomainNameVec.GetHashCode();
                if (this.PhysicalQuota != null)
                    hashCode = hashCode * 59 + this.PhysicalQuota.GetHashCode();
                hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.S3BucketsAllowed != null)
                    hashCode = hashCode * 59 + this.S3BucketsAllowed.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StoragePolicy != null)
                    hashCode = hashCode * 59 + this.StoragePolicy.GetHashCode();
                if (this.TenantIdVec != null)
                    hashCode = hashCode * 59 + this.TenantIdVec.GetHashCode();
                if (this.TreatFileSyncAsDataSync != null)
                    hashCode = hashCode * 59 + this.TreatFileSyncAsDataSync.GetHashCode();
                if (this.UpdatedBrickSize != null)
                    hashCode = hashCode * 59 + this.UpdatedBrickSize.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }

    }

}

