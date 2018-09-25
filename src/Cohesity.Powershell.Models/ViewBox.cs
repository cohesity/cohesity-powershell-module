// Copyright 2018 Cohesity Inc.

using System;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
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
        [DataMember(Name="removalState", EmitDefaultValue=false)]
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
        /// <param name="clusterPartitionId">Specifies the Cluster Partition id where the Storage Domain (View Box) is located. (required).</param>
        /// <param name="defaultUserQuotaPolicy">defaultUserQuotaPolicy.</param>
        /// <param name="defaultViewQuotaPolicy">defaultViewQuotaPolicy.</param>
        /// <param name="id">Specifies the Id of the Storage Domain (View Box)..</param>
        /// <param name="name">Specifies the name of the Storage Domain (View Box). (required).</param>
        /// <param name="physicalQuota">physicalQuota.</param>
        /// <param name="removalState">Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster..</param>
        /// <param name="s3BucketsAllowed">Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed..</param>
        /// <param name="stats">Specifies statistics about the Storage Domain (View Box). readOnly: true.</param>
        /// <param name="storagePolicy">Specifies the storage options applied to the Storage Domain (View Box)..</param>
        /// <param name="treatFileSyncAsDataSync">If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance..</param>
        public ViewBox(string adDomainName = default(string), long? clusterPartitionId = default(long?), QuotaPolicy1 defaultUserQuotaPolicy = default(QuotaPolicy1), QuotaPolicy2 defaultViewQuotaPolicy = default(QuotaPolicy2), long? id = default(long?), string name = default(string), QuotaPolicy3 physicalQuota = default(QuotaPolicy3), RemovalStateEnum? removalState = default(RemovalStateEnum?), bool? s3BucketsAllowed = default(bool?), ViewBoxStats stats = default(ViewBoxStats), StoragePolicy storagePolicy = default(StoragePolicy), bool? treatFileSyncAsDataSync = default(bool?))
        {
            // to ensure "clusterPartitionId" is required (not null)
            if (clusterPartitionId == null)
            {
                throw new InvalidDataException("clusterPartitionId is a required property for ViewBox and cannot be null");
            }
            else
            {
                this.ClusterPartitionId = clusterPartitionId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ViewBox and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.AdDomainName = adDomainName;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.Id = id;
            this.PhysicalQuota = physicalQuota;
            this.RemovalState = removalState;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.Stats = stats;
            this.StoragePolicy = storagePolicy;
            this.TreatFileSyncAsDataSync = treatFileSyncAsDataSync;
        }
        
        /// <summary>
        /// Specifies an active directory domain that this view box is mapped to.
        /// </summary>
        /// <value>Specifies an active directory domain that this view box is mapped to.</value>
        [DataMember(Name="adDomainName", EmitDefaultValue=false)]
        public string AdDomainName { get; set; }

        /// <summary>
        /// Specifies the Cluster Partition id where the Storage Domain (View Box) is located.
        /// </summary>
        /// <value>Specifies the Cluster Partition id where the Storage Domain (View Box) is located.</value>
        [DataMember(Name="clusterPartitionId", EmitDefaultValue=false)]
        public long? ClusterPartitionId { get; set; }

        /// <summary>
        /// Specifies the Cohesity Cluster name where the Storage Domain (View Box) is located.
        /// </summary>
        /// <value>Specifies the Cohesity Cluster name where the Storage Domain (View Box) is located.</value>
        [DataMember(Name="clusterPartitionName", EmitDefaultValue=false)]
        public string ClusterPartitionName { get; private set; }

        /// <summary>
        /// Gets or Sets DefaultUserQuotaPolicy
        /// </summary>
        [DataMember(Name="defaultUserQuotaPolicy", EmitDefaultValue=false)]
        public QuotaPolicy1 DefaultUserQuotaPolicy { get; set; }

        /// <summary>
        /// Gets or Sets DefaultViewQuotaPolicy
        /// </summary>
        [DataMember(Name="defaultViewQuotaPolicy", EmitDefaultValue=false)]
        public QuotaPolicy2 DefaultViewQuotaPolicy { get; set; }

        /// <summary>
        /// Specifies the Id of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the Id of the Storage Domain (View Box).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the name of the Storage Domain (View Box).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalQuota
        /// </summary>
        [DataMember(Name="physicalQuota", EmitDefaultValue=false)]
        public QuotaPolicy3 PhysicalQuota { get; set; }


        /// <summary>
        /// Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed.
        /// </summary>
        /// <value>Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed.</value>
        [DataMember(Name="s3BucketsAllowed", EmitDefaultValue=false)]
        public bool? S3BucketsAllowed { get; set; }

        /// <summary>
        /// Specifies statistics about the Storage Domain (View Box). readOnly: true
        /// </summary>
        /// <value>Specifies statistics about the Storage Domain (View Box). readOnly: true</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ViewBoxStats Stats { get; set; }

        /// <summary>
        /// Specifies the storage options applied to the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the storage options applied to the Storage Domain (View Box).</value>
        [DataMember(Name="storagePolicy", EmitDefaultValue=false)]
        public StoragePolicy StoragePolicy { get; set; }

        /// <summary>
        /// If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance.
        /// </summary>
        /// <value>If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance.</value>
        [DataMember(Name="treatFileSyncAsDataSync", EmitDefaultValue=false)]
        public bool? TreatFileSyncAsDataSync { get; set; }

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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.RemovalState == input.RemovalState ||
                    (this.RemovalState != null &&
                    this.RemovalState.Equals(input.RemovalState))
                ) && 
                (
                    this.S3BucketsAllowed == input.S3BucketsAllowed ||
                    (this.S3BucketsAllowed != null &&
                    this.S3BucketsAllowed.Equals(input.S3BucketsAllowed))
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
                    this.TreatFileSyncAsDataSync == input.TreatFileSyncAsDataSync ||
                    (this.TreatFileSyncAsDataSync != null &&
                    this.TreatFileSyncAsDataSync.Equals(input.TreatFileSyncAsDataSync))
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
                if (this.ClusterPartitionId != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionId.GetHashCode();
                if (this.ClusterPartitionName != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionName.GetHashCode();
                if (this.DefaultUserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultUserQuotaPolicy.GetHashCode();
                if (this.DefaultViewQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultViewQuotaPolicy.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhysicalQuota != null)
                    hashCode = hashCode * 59 + this.PhysicalQuota.GetHashCode();
                if (this.RemovalState != null)
                    hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.S3BucketsAllowed != null)
                    hashCode = hashCode * 59 + this.S3BucketsAllowed.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StoragePolicy != null)
                    hashCode = hashCode * 59 + this.StoragePolicy.GetHashCode();
                if (this.TreatFileSyncAsDataSync != null)
                    hashCode = hashCode * 59 + this.TreatFileSyncAsDataSync.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

