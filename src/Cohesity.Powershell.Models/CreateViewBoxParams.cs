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
        /// <param name="clusterPartitionId">Specifies the Cluster Partition id where the Storage Domain (View Box) is located. (required).</param>
        /// <param name="defaultUserQuotaPolicy">defaultUserQuotaPolicy.</param>
        /// <param name="defaultViewQuotaPolicy">defaultViewQuotaPolicy.</param>
        /// <param name="name">Specifies the name of the Storage Domain (View Box). (required).</param>
        /// <param name="physicalQuota">physicalQuota.</param>
        /// <param name="s3BucketsAllowed">Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed..</param>
        /// <param name="storagePolicy">Specifies the storage options applied to the Storage Domain (View Box)..</param>
        public CreateViewBoxParams(string adDomainName = default(string), long? clusterPartitionId = default(long?), QuotaPolicy1 defaultUserQuotaPolicy = default(QuotaPolicy1), QuotaPolicy2 defaultViewQuotaPolicy = default(QuotaPolicy2), string name = default(string), QuotaPolicy3 physicalQuota = default(QuotaPolicy3), bool? s3BucketsAllowed = default(bool?), StoragePolicy storagePolicy = default(StoragePolicy))
        {
            // to ensure "clusterPartitionId" is required (not null)
            if (clusterPartitionId == null)
            {
                throw new InvalidDataException("clusterPartitionId is a required property for CreateViewBoxParams and cannot be null");
            }
            else
            {
                this.ClusterPartitionId = clusterPartitionId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateViewBoxParams and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.AdDomainName = adDomainName;
            this.DefaultUserQuotaPolicy = defaultUserQuotaPolicy;
            this.DefaultViewQuotaPolicy = defaultViewQuotaPolicy;
            this.PhysicalQuota = physicalQuota;
            this.S3BucketsAllowed = s3BucketsAllowed;
            this.StoragePolicy = storagePolicy;
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
        /// Specifies the storage options applied to the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the storage options applied to the Storage Domain (View Box).</value>
        [DataMember(Name="storagePolicy", EmitDefaultValue=false)]
        public StoragePolicy StoragePolicy { get; set; }

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
                if (this.DefaultUserQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultUserQuotaPolicy.GetHashCode();
                if (this.DefaultViewQuotaPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultViewQuotaPolicy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhysicalQuota != null)
                    hashCode = hashCode * 59 + this.PhysicalQuota.GetHashCode();
                if (this.S3BucketsAllowed != null)
                    hashCode = hashCode * 59 + this.S3BucketsAllowed.GetHashCode();
                if (this.StoragePolicy != null)
                    hashCode = hashCode * 59 + this.StoragePolicy.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

