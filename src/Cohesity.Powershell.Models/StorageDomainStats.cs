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
    /// StorageDomainStats
    /// </summary>
    [DataContract]
    public partial class StorageDomainStats :  IEquatable<StorageDomainStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDomainStats" /> class.
        /// </summary>
        /// <param name="cloudSpillVaultId">Specifies the cloud spill vault id of the view box (storage domain)..</param>
        /// <param name="groupList">Specifies a list of groups associated to this view box (storage domain)..</param>
        /// <param name="id">Specifies the id of the view box (storage domain)..</param>
        /// <param name="name">Specifies the name of the view box (storage domain)..</param>
        /// <param name="quotaHardLimitBytes">Specifies the hard limit of physical quota of the view box (storage domain)..</param>
        /// <param name="schemaInfoList">Specifies a list of schemaInfos of the view box (storage domain)..</param>
        /// <param name="stats">stats.</param>
        public StorageDomainStats(long? cloudSpillVaultId = default(long?), List<StatsGroup> groupList = default(List<StatsGroup>), long? id = default(long?), string name = default(string), long? quotaHardLimitBytes = default(long?), List<UsageSchemaInfo> schemaInfoList = default(List<UsageSchemaInfo>), DataUsageStats stats = default(DataUsageStats))
        {
            this.CloudSpillVaultId = cloudSpillVaultId;
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.CloudSpillVaultId = cloudSpillVaultId;
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Specifies the cloud spill vault id of the view box (storage domain).
        /// </summary>
        /// <value>Specifies the cloud spill vault id of the view box (storage domain).</value>
        [DataMember(Name="cloudSpillVaultId", EmitDefaultValue=true)]
        public long? CloudSpillVaultId { get; set; }

        /// <summary>
        /// Specifies a list of groups associated to this view box (storage domain).
        /// </summary>
        /// <value>Specifies a list of groups associated to this view box (storage domain).</value>
        [DataMember(Name="groupList", EmitDefaultValue=true)]
        public List<StatsGroup> GroupList { get; set; }

        /// <summary>
        /// Specifies the id of the view box (storage domain).
        /// </summary>
        /// <value>Specifies the id of the view box (storage domain).</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the view box (storage domain).
        /// </summary>
        /// <value>Specifies the name of the view box (storage domain).</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the hard limit of physical quota of the view box (storage domain).
        /// </summary>
        /// <value>Specifies the hard limit of physical quota of the view box (storage domain).</value>
        [DataMember(Name="quotaHardLimitBytes", EmitDefaultValue=true)]
        public long? QuotaHardLimitBytes { get; set; }

        /// <summary>
        /// Specifies a list of schemaInfos of the view box (storage domain).
        /// </summary>
        /// <value>Specifies a list of schemaInfos of the view box (storage domain).</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<UsageSchemaInfo> SchemaInfoList { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public DataUsageStats Stats { get; set; }

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
            return this.Equals(input as StorageDomainStats);
        }

        /// <summary>
        /// Returns true if StorageDomainStats instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageDomainStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageDomainStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudSpillVaultId == input.CloudSpillVaultId ||
                    (this.CloudSpillVaultId != null &&
                    this.CloudSpillVaultId.Equals(input.CloudSpillVaultId))
                ) && 
                (
                    this.GroupList == input.GroupList ||
                    this.GroupList != null &&
                    input.GroupList != null &&
                    this.GroupList.SequenceEqual(input.GroupList)
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
                    this.QuotaHardLimitBytes == input.QuotaHardLimitBytes ||
                    (this.QuotaHardLimitBytes != null &&
                    this.QuotaHardLimitBytes.Equals(input.QuotaHardLimitBytes))
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
                if (this.CloudSpillVaultId != null)
                    hashCode = hashCode * 59 + this.CloudSpillVaultId.GetHashCode();
                if (this.GroupList != null)
                    hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.QuotaHardLimitBytes != null)
                    hashCode = hashCode * 59 + this.QuotaHardLimitBytes.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }

    }

}

