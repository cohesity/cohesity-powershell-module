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
    /// NoSqlBackupJobParams
    /// </summary>
    [DataContract]
    public partial class NoSqlBackupJobParams :  IEquatable<NoSqlBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlBackupJobParams" /> class.
        /// </summary>
        /// <param name="bandwidthBytesPerSecond">Net bandwidth bytes per second..</param>
        /// <param name="cassandraBackupJobParams">cassandraBackupJobParams.</param>
        /// <param name="compactionJobIntervalSecs">Frequency at which compaction jobs should run in seconds. Will be only applicable for Cassandra, Mongo and Couchbase environment..</param>
        /// <param name="concurrency">Max number of mappers..</param>
        /// <param name="couchbaseBackupJobParams">Contains any additional couchbase environment specific backup params at the job level..</param>
        /// <param name="gcJobIntervalSecs">Frequency at which garbage collection jobs should run in seconds..</param>
        /// <param name="gcRetentionPeriodDays">Retention period for logs of this job in days..</param>
        /// <param name="hbaseBackupJobParams">hbaseBackupJobParams.</param>
        /// <param name="hdfsBackupJobParams">hdfsBackupJobParams.</param>
        /// <param name="hiveBackupJobParams">hiveBackupJobParams.</param>
        /// <param name="immediateAncestorMap">A mapping to the immediate ancestor for each protected entites. This is used in slave to populate immediate_ancestor_entity_id in Imanis EntityProto. The immediate_ancestor_entity_id is used by Imanis to populate entity id of non-leaf objects in yoda (such as databases, keyspaces).</param>
        /// <param name="lastCompactionRunTimeUsecs">The last time (in usecs) when the compaction ran for this jobs..</param>
        /// <param name="lastGcRunTimeUsecs">The last time (in usecs) when the gc ran for this jobs..</param>
        /// <param name="mongodbBackupJobParams">mongodbBackupJobParams.</param>
        /// <param name="previousProtectedEntityIdsVec">List of Magneto entity Ids for the entities that were protected in the previous run..</param>
        public NoSqlBackupJobParams(long? bandwidthBytesPerSecond = default(long?), CassandraBackupJobParams cassandraBackupJobParams = default(CassandraBackupJobParams), long? compactionJobIntervalSecs = default(long?), int? concurrency = default(int?), Object couchbaseBackupJobParams = default(Object), long? gcJobIntervalSecs = default(long?), int? gcRetentionPeriodDays = default(int?), HBaseBackupJobParams hbaseBackupJobParams = default(HBaseBackupJobParams), HdfsBackupJobParams hdfsBackupJobParams = default(HdfsBackupJobParams), HiveBackupJobParams hiveBackupJobParams = default(HiveBackupJobParams), List<NoSqlBackupJobParamsImmediateAncestorMapEntry> immediateAncestorMap = default(List<NoSqlBackupJobParamsImmediateAncestorMapEntry>), long? lastCompactionRunTimeUsecs = default(long?), long? lastGcRunTimeUsecs = default(long?), MongoDBBackupJobParams mongodbBackupJobParams = default(MongoDBBackupJobParams), List<long> previousProtectedEntityIdsVec = default(List<long>))
        {
            this.BandwidthBytesPerSecond = bandwidthBytesPerSecond;
            this.CassandraBackupJobParams = cassandraBackupJobParams;
            this.CompactionJobIntervalSecs = compactionJobIntervalSecs;
            this.Concurrency = concurrency;
            this.CouchbaseBackupJobParams = couchbaseBackupJobParams;
            this.GcJobIntervalSecs = gcJobIntervalSecs;
            this.GcRetentionPeriodDays = gcRetentionPeriodDays;
            this.HbaseBackupJobParams = hbaseBackupJobParams;
            this.HdfsBackupJobParams = hdfsBackupJobParams;
            this.HiveBackupJobParams = hiveBackupJobParams;
            this.ImmediateAncestorMap = immediateAncestorMap;
            this.LastCompactionRunTimeUsecs = lastCompactionRunTimeUsecs;
            this.LastGcRunTimeUsecs = lastGcRunTimeUsecs;
            this.MongodbBackupJobParams = mongodbBackupJobParams;
            this.PreviousProtectedEntityIdsVec = previousProtectedEntityIdsVec;
        }
        
        /// <summary>
        /// Net bandwidth bytes per second.
        /// </summary>
        /// <value>Net bandwidth bytes per second.</value>
        [DataMember(Name="bandwidthBytesPerSecond", EmitDefaultValue=true)]
        public long? BandwidthBytesPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets CassandraBackupJobParams
        /// </summary>
        [DataMember(Name="cassandraBackupJobParams", EmitDefaultValue=false)]
        public CassandraBackupJobParams CassandraBackupJobParams { get; set; }

        /// <summary>
        /// Frequency at which compaction jobs should run in seconds. Will be only applicable for Cassandra, Mongo and Couchbase environment.
        /// </summary>
        /// <value>Frequency at which compaction jobs should run in seconds. Will be only applicable for Cassandra, Mongo and Couchbase environment.</value>
        [DataMember(Name="compactionJobIntervalSecs", EmitDefaultValue=true)]
        public long? CompactionJobIntervalSecs { get; set; }

        /// <summary>
        /// Max number of mappers.
        /// </summary>
        /// <value>Max number of mappers.</value>
        [DataMember(Name="concurrency", EmitDefaultValue=true)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Contains any additional couchbase environment specific backup params at the job level.
        /// </summary>
        /// <value>Contains any additional couchbase environment specific backup params at the job level.</value>
        [DataMember(Name="couchbaseBackupJobParams", EmitDefaultValue=false)]
        public Object CouchbaseBackupJobParams { get; set; }

        /// <summary>
        /// Frequency at which garbage collection jobs should run in seconds.
        /// </summary>
        /// <value>Frequency at which garbage collection jobs should run in seconds.</value>
        [DataMember(Name="gcJobIntervalSecs", EmitDefaultValue=true)]
        public long? GcJobIntervalSecs { get; set; }

        /// <summary>
        /// Retention period for logs of this job in days.
        /// </summary>
        /// <value>Retention period for logs of this job in days.</value>
        [DataMember(Name="gcRetentionPeriodDays", EmitDefaultValue=true)]
        public int? GcRetentionPeriodDays { get; set; }

        /// <summary>
        /// Gets or Sets HbaseBackupJobParams
        /// </summary>
        [DataMember(Name="hbaseBackupJobParams", EmitDefaultValue=false)]
        public HBaseBackupJobParams HbaseBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets HdfsBackupJobParams
        /// </summary>
        [DataMember(Name="hdfsBackupJobParams", EmitDefaultValue=false)]
        public HdfsBackupJobParams HdfsBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets HiveBackupJobParams
        /// </summary>
        [DataMember(Name="hiveBackupJobParams", EmitDefaultValue=false)]
        public HiveBackupJobParams HiveBackupJobParams { get; set; }

        /// <summary>
        /// A mapping to the immediate ancestor for each protected entites. This is used in slave to populate immediate_ancestor_entity_id in Imanis EntityProto. The immediate_ancestor_entity_id is used by Imanis to populate entity id of non-leaf objects in yoda (such as databases, keyspaces)
        /// </summary>
        /// <value>A mapping to the immediate ancestor for each protected entites. This is used in slave to populate immediate_ancestor_entity_id in Imanis EntityProto. The immediate_ancestor_entity_id is used by Imanis to populate entity id of non-leaf objects in yoda (such as databases, keyspaces)</value>
        [DataMember(Name="immediateAncestorMap", EmitDefaultValue=true)]
        public List<NoSqlBackupJobParamsImmediateAncestorMapEntry> ImmediateAncestorMap { get; set; }

        /// <summary>
        /// The last time (in usecs) when the compaction ran for this jobs.
        /// </summary>
        /// <value>The last time (in usecs) when the compaction ran for this jobs.</value>
        [DataMember(Name="lastCompactionRunTimeUsecs", EmitDefaultValue=true)]
        public long? LastCompactionRunTimeUsecs { get; set; }

        /// <summary>
        /// The last time (in usecs) when the gc ran for this jobs.
        /// </summary>
        /// <value>The last time (in usecs) when the gc ran for this jobs.</value>
        [DataMember(Name="lastGcRunTimeUsecs", EmitDefaultValue=true)]
        public long? LastGcRunTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets MongodbBackupJobParams
        /// </summary>
        [DataMember(Name="mongodbBackupJobParams", EmitDefaultValue=false)]
        public MongoDBBackupJobParams MongodbBackupJobParams { get; set; }

        /// <summary>
        /// List of Magneto entity Ids for the entities that were protected in the previous run.
        /// </summary>
        /// <value>List of Magneto entity Ids for the entities that were protected in the previous run.</value>
        [DataMember(Name="previousProtectedEntityIdsVec", EmitDefaultValue=true)]
        public List<long> PreviousProtectedEntityIdsVec { get; set; }

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
            return this.Equals(input as NoSqlBackupJobParams);
        }

        /// <summary>
        /// Returns true if NoSqlBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthBytesPerSecond == input.BandwidthBytesPerSecond ||
                    (this.BandwidthBytesPerSecond != null &&
                    this.BandwidthBytesPerSecond.Equals(input.BandwidthBytesPerSecond))
                ) && 
                (
                    this.CassandraBackupJobParams == input.CassandraBackupJobParams ||
                    (this.CassandraBackupJobParams != null &&
                    this.CassandraBackupJobParams.Equals(input.CassandraBackupJobParams))
                ) && 
                (
                    this.CompactionJobIntervalSecs == input.CompactionJobIntervalSecs ||
                    (this.CompactionJobIntervalSecs != null &&
                    this.CompactionJobIntervalSecs.Equals(input.CompactionJobIntervalSecs))
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.CouchbaseBackupJobParams == input.CouchbaseBackupJobParams ||
                    (this.CouchbaseBackupJobParams != null &&
                    this.CouchbaseBackupJobParams.Equals(input.CouchbaseBackupJobParams))
                ) && 
                (
                    this.GcJobIntervalSecs == input.GcJobIntervalSecs ||
                    (this.GcJobIntervalSecs != null &&
                    this.GcJobIntervalSecs.Equals(input.GcJobIntervalSecs))
                ) && 
                (
                    this.GcRetentionPeriodDays == input.GcRetentionPeriodDays ||
                    (this.GcRetentionPeriodDays != null &&
                    this.GcRetentionPeriodDays.Equals(input.GcRetentionPeriodDays))
                ) && 
                (
                    this.HbaseBackupJobParams == input.HbaseBackupJobParams ||
                    (this.HbaseBackupJobParams != null &&
                    this.HbaseBackupJobParams.Equals(input.HbaseBackupJobParams))
                ) && 
                (
                    this.HdfsBackupJobParams == input.HdfsBackupJobParams ||
                    (this.HdfsBackupJobParams != null &&
                    this.HdfsBackupJobParams.Equals(input.HdfsBackupJobParams))
                ) && 
                (
                    this.HiveBackupJobParams == input.HiveBackupJobParams ||
                    (this.HiveBackupJobParams != null &&
                    this.HiveBackupJobParams.Equals(input.HiveBackupJobParams))
                ) && 
                (
                    this.ImmediateAncestorMap == input.ImmediateAncestorMap ||
                    this.ImmediateAncestorMap != null &&
                    input.ImmediateAncestorMap != null &&
                    this.ImmediateAncestorMap.Equals(input.ImmediateAncestorMap)
                ) && 
                (
                    this.LastCompactionRunTimeUsecs == input.LastCompactionRunTimeUsecs ||
                    (this.LastCompactionRunTimeUsecs != null &&
                    this.LastCompactionRunTimeUsecs.Equals(input.LastCompactionRunTimeUsecs))
                ) && 
                (
                    this.LastGcRunTimeUsecs == input.LastGcRunTimeUsecs ||
                    (this.LastGcRunTimeUsecs != null &&
                    this.LastGcRunTimeUsecs.Equals(input.LastGcRunTimeUsecs))
                ) && 
                (
                    this.MongodbBackupJobParams == input.MongodbBackupJobParams ||
                    (this.MongodbBackupJobParams != null &&
                    this.MongodbBackupJobParams.Equals(input.MongodbBackupJobParams))
                ) && 
                (
                    this.PreviousProtectedEntityIdsVec == input.PreviousProtectedEntityIdsVec ||
                    this.PreviousProtectedEntityIdsVec != null &&
                    input.PreviousProtectedEntityIdsVec != null &&
                    this.PreviousProtectedEntityIdsVec.Equals(input.PreviousProtectedEntityIdsVec)
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
                if (this.BandwidthBytesPerSecond != null)
                    hashCode = hashCode * 59 + this.BandwidthBytesPerSecond.GetHashCode();
                if (this.CassandraBackupJobParams != null)
                    hashCode = hashCode * 59 + this.CassandraBackupJobParams.GetHashCode();
                if (this.CompactionJobIntervalSecs != null)
                    hashCode = hashCode * 59 + this.CompactionJobIntervalSecs.GetHashCode();
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.CouchbaseBackupJobParams != null)
                    hashCode = hashCode * 59 + this.CouchbaseBackupJobParams.GetHashCode();
                if (this.GcJobIntervalSecs != null)
                    hashCode = hashCode * 59 + this.GcJobIntervalSecs.GetHashCode();
                if (this.GcRetentionPeriodDays != null)
                    hashCode = hashCode * 59 + this.GcRetentionPeriodDays.GetHashCode();
                if (this.HbaseBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HbaseBackupJobParams.GetHashCode();
                if (this.HdfsBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HdfsBackupJobParams.GetHashCode();
                if (this.HiveBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HiveBackupJobParams.GetHashCode();
                if (this.ImmediateAncestorMap != null)
                    hashCode = hashCode * 59 + this.ImmediateAncestorMap.GetHashCode();
                if (this.LastCompactionRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastCompactionRunTimeUsecs.GetHashCode();
                if (this.LastGcRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastGcRunTimeUsecs.GetHashCode();
                if (this.MongodbBackupJobParams != null)
                    hashCode = hashCode * 59 + this.MongodbBackupJobParams.GetHashCode();
                if (this.PreviousProtectedEntityIdsVec != null)
                    hashCode = hashCode * 59 + this.PreviousProtectedEntityIdsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

