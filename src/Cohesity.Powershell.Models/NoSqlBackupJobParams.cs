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
        /// <param name="bandwidthBytesPerSecond">Net bandwidth bytes per second.</param>
        /// <param name="cassandraBackupJobParams">cassandraBackupJobParams.</param>
        /// <param name="concurrency">Max number of mappers.</param>
        /// <param name="couchbaseBackupJobParams">Contains any additional couchbase environment specific backup params at the job level..</param>
        /// <param name="hbaseBackupJobParams">hbaseBackupJobParams.</param>
        /// <param name="hdfsBackupJobParams">hdfsBackupJobParams.</param>
        /// <param name="hiveBackupJobParams">hiveBackupJobParams.</param>
        /// <param name="mongodbBackupJobParams">mongodbBackupJobParams.</param>
        public NoSqlBackupJobParams(long? bandwidthBytesPerSecond = default(long?), CassandraBackupJobParams cassandraBackupJobParams = default(CassandraBackupJobParams), int? concurrency = default(int?), Object couchbaseBackupJobParams = default(Object), HBaseBackupJobParams hbaseBackupJobParams = default(HBaseBackupJobParams), HdfsBackupJobParams hdfsBackupJobParams = default(HdfsBackupJobParams), HiveBackupJobParams hiveBackupJobParams = default(HiveBackupJobParams), MongoDBBackupJobParams mongodbBackupJobParams = default(MongoDBBackupJobParams))
        {
            this.BandwidthBytesPerSecond = bandwidthBytesPerSecond;
            this.Concurrency = concurrency;
            this.BandwidthBytesPerSecond = bandwidthBytesPerSecond;
            this.CassandraBackupJobParams = cassandraBackupJobParams;
            this.Concurrency = concurrency;
            this.CouchbaseBackupJobParams = couchbaseBackupJobParams;
            this.HbaseBackupJobParams = hbaseBackupJobParams;
            this.HdfsBackupJobParams = hdfsBackupJobParams;
            this.HiveBackupJobParams = hiveBackupJobParams;
            this.MongodbBackupJobParams = mongodbBackupJobParams;
        }
        
        /// <summary>
        /// Net bandwidth bytes per second
        /// </summary>
        /// <value>Net bandwidth bytes per second</value>
        [DataMember(Name="bandwidthBytesPerSecond", EmitDefaultValue=true)]
        public long? BandwidthBytesPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets CassandraBackupJobParams
        /// </summary>
        [DataMember(Name="cassandraBackupJobParams", EmitDefaultValue=false)]
        public CassandraBackupJobParams CassandraBackupJobParams { get; set; }

        /// <summary>
        /// Max number of mappers
        /// </summary>
        /// <value>Max number of mappers</value>
        [DataMember(Name="concurrency", EmitDefaultValue=true)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Contains any additional couchbase environment specific backup params at the job level.
        /// </summary>
        /// <value>Contains any additional couchbase environment specific backup params at the job level.</value>
        [DataMember(Name="couchbaseBackupJobParams", EmitDefaultValue=false)]
        public Object CouchbaseBackupJobParams { get; set; }

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
        /// Gets or Sets MongodbBackupJobParams
        /// </summary>
        [DataMember(Name="mongodbBackupJobParams", EmitDefaultValue=false)]
        public MongoDBBackupJobParams MongodbBackupJobParams { get; set; }

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
                    this.MongodbBackupJobParams == input.MongodbBackupJobParams ||
                    (this.MongodbBackupJobParams != null &&
                    this.MongodbBackupJobParams.Equals(input.MongodbBackupJobParams))
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
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.CouchbaseBackupJobParams != null)
                    hashCode = hashCode * 59 + this.CouchbaseBackupJobParams.GetHashCode();
                if (this.HbaseBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HbaseBackupJobParams.GetHashCode();
                if (this.HdfsBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HdfsBackupJobParams.GetHashCode();
                if (this.HiveBackupJobParams != null)
                    hashCode = hashCode * 59 + this.HiveBackupJobParams.GetHashCode();
                if (this.MongodbBackupJobParams != null)
                    hashCode = hashCode * 59 + this.MongodbBackupJobParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

