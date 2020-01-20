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
    /// ConsumerStats is the stats of a single consumer. A consumer is a entity which consumes the storage space of a storage domain. A consumer can be a View, Protection Job or a Replication Job.
    /// </summary>
    [DataContract]
    public partial class ConsumerStats :  IEquatable<ConsumerStats>
    {
        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConsumerTypeEnum
        {
            /// <summary>
            /// Enum KViews for value: kViews
            /// </summary>
            [EnumMember(Value = "kViews")]
            KViews = 1,

            /// <summary>
            /// Enum KProtectionRuns for value: kProtectionRuns
            /// </summary>
            [EnumMember(Value = "kProtectionRuns")]
            KProtectionRuns = 2,

            /// <summary>
            /// Enum KReplicationRuns for value: kReplicationRuns
            /// </summary>
            [EnumMember(Value = "kReplicationRuns")]
            KReplicationRuns = 3

        }

        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain).</value>
        [DataMember(Name="consumerType", EmitDefaultValue=true)]
        public ConsumerTypeEnum? ConsumerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerStats" /> class.
        /// </summary>
        /// <param name="consumerType">Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain)..</param>
        /// <param name="groupList">Specifies a list of groups associated to this consumer..</param>
        /// <param name="id">Specifies the id of the consumer..</param>
        /// <param name="name">Specifies the name of the consumer..</param>
        /// <param name="quotaHardLimitBytes">Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view..</param>
        /// <param name="schemaInfoList">Specifies a list of schemaInfos of the consumer..</param>
        /// <param name="stats">stats.</param>
        public ConsumerStats(ConsumerTypeEnum? consumerType = default(ConsumerTypeEnum?), List<StatsGroup> groupList = default(List<StatsGroup>), long? id = default(long?), string name = default(string), long? quotaHardLimitBytes = default(long?), List<UsageSchemaInfo> schemaInfoList = default(List<UsageSchemaInfo>), DataUsageStats stats = default(DataUsageStats))
        {
            this.ConsumerType = consumerType;
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.ConsumerType = consumerType;
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Specifies a list of groups associated to this consumer.
        /// </summary>
        /// <value>Specifies a list of groups associated to this consumer.</value>
        [DataMember(Name="groupList", EmitDefaultValue=true)]
        public List<StatsGroup> GroupList { get; set; }

        /// <summary>
        /// Specifies the id of the consumer.
        /// </summary>
        /// <value>Specifies the id of the consumer.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the consumer.
        /// </summary>
        /// <value>Specifies the name of the consumer.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view.
        /// </summary>
        /// <value>Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view.</value>
        [DataMember(Name="quotaHardLimitBytes", EmitDefaultValue=true)]
        public long? QuotaHardLimitBytes { get; set; }

        /// <summary>
        /// Specifies a list of schemaInfos of the consumer.
        /// </summary>
        /// <value>Specifies a list of schemaInfos of the consumer.</value>
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
            return this.Equals(input as ConsumerStats);
        }

        /// <summary>
        /// Returns true if ConsumerStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerType == input.ConsumerType ||
                    this.ConsumerType.Equals(input.ConsumerType)
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
                hashCode = hashCode * 59 + this.ConsumerType.GetHashCode();
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

