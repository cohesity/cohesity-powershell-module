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
    /// NoSqlRecoverJobParams
    /// </summary>
    [DataContract]
    public partial class NoSqlRecoverJobParams :  IEquatable<NoSqlRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlRecoverJobParams" /> class.
        /// </summary>
        /// <param name="bandwidthBytesPerSecond">Net bandwidth bytes per second.</param>
        /// <param name="cassandraRecoverJobParams">cassandraRecoverJobParams.</param>
        /// <param name="concurrency">Max number of mappers.</param>
        /// <param name="couchbaseRecoverJobParams">couchbaseRecoverJobParams.</param>
        /// <param name="hbaseRecoverJobParams">hbaseRecoverJobParams.</param>
        /// <param name="hdfsRecoverJobParams">hdfsRecoverJobParams.</param>
        /// <param name="hiveRecoverJobParams">hiveRecoverJobParams.</param>
        /// <param name="mongodbRecoverJobParams">mongodbRecoverJobParams.</param>
        /// <param name="overwrite">Whether to overwrite or keep the object if the object being recovered already exists in the destination..</param>
        public NoSqlRecoverJobParams(long? bandwidthBytesPerSecond = default(long?), CassandraRecoverJobParams cassandraRecoverJobParams = default(CassandraRecoverJobParams), int? concurrency = default(int?), CouchbaseRecoverJobParams couchbaseRecoverJobParams = default(CouchbaseRecoverJobParams), HBaseRecoverJobParams hbaseRecoverJobParams = default(HBaseRecoverJobParams), HdfsRecoverJobParams hdfsRecoverJobParams = default(HdfsRecoverJobParams), HiveRecoverJobParams hiveRecoverJobParams = default(HiveRecoverJobParams), MongoDBRecoverJobParams mongodbRecoverJobParams = default(MongoDBRecoverJobParams), bool? overwrite = default(bool?))
        {
            this.BandwidthBytesPerSecond = bandwidthBytesPerSecond;
            this.Concurrency = concurrency;
            this.Overwrite = overwrite;
            this.BandwidthBytesPerSecond = bandwidthBytesPerSecond;
            this.CassandraRecoverJobParams = cassandraRecoverJobParams;
            this.Concurrency = concurrency;
            this.CouchbaseRecoverJobParams = couchbaseRecoverJobParams;
            this.HbaseRecoverJobParams = hbaseRecoverJobParams;
            this.HdfsRecoverJobParams = hdfsRecoverJobParams;
            this.HiveRecoverJobParams = hiveRecoverJobParams;
            this.MongodbRecoverJobParams = mongodbRecoverJobParams;
            this.Overwrite = overwrite;
        }
        
        /// <summary>
        /// Net bandwidth bytes per second
        /// </summary>
        /// <value>Net bandwidth bytes per second</value>
        [DataMember(Name="bandwidthBytesPerSecond", EmitDefaultValue=true)]
        public long? BandwidthBytesPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets CassandraRecoverJobParams
        /// </summary>
        [DataMember(Name="cassandraRecoverJobParams", EmitDefaultValue=false)]
        public CassandraRecoverJobParams CassandraRecoverJobParams { get; set; }

        /// <summary>
        /// Max number of mappers
        /// </summary>
        /// <value>Max number of mappers</value>
        [DataMember(Name="concurrency", EmitDefaultValue=true)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Gets or Sets CouchbaseRecoverJobParams
        /// </summary>
        [DataMember(Name="couchbaseRecoverJobParams", EmitDefaultValue=false)]
        public CouchbaseRecoverJobParams CouchbaseRecoverJobParams { get; set; }

        /// <summary>
        /// Gets or Sets HbaseRecoverJobParams
        /// </summary>
        [DataMember(Name="hbaseRecoverJobParams", EmitDefaultValue=false)]
        public HBaseRecoverJobParams HbaseRecoverJobParams { get; set; }

        /// <summary>
        /// Gets or Sets HdfsRecoverJobParams
        /// </summary>
        [DataMember(Name="hdfsRecoverJobParams", EmitDefaultValue=false)]
        public HdfsRecoverJobParams HdfsRecoverJobParams { get; set; }

        /// <summary>
        /// Gets or Sets HiveRecoverJobParams
        /// </summary>
        [DataMember(Name="hiveRecoverJobParams", EmitDefaultValue=false)]
        public HiveRecoverJobParams HiveRecoverJobParams { get; set; }

        /// <summary>
        /// Gets or Sets MongodbRecoverJobParams
        /// </summary>
        [DataMember(Name="mongodbRecoverJobParams", EmitDefaultValue=false)]
        public MongoDBRecoverJobParams MongodbRecoverJobParams { get; set; }

        /// <summary>
        /// Whether to overwrite or keep the object if the object being recovered already exists in the destination.
        /// </summary>
        /// <value>Whether to overwrite or keep the object if the object being recovered already exists in the destination.</value>
        [DataMember(Name="overwrite", EmitDefaultValue=true)]
        public bool? Overwrite { get; set; }

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
            return this.Equals(input as NoSqlRecoverJobParams);
        }

        /// <summary>
        /// Returns true if NoSqlRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlRecoverJobParams input)
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
                    this.CassandraRecoverJobParams == input.CassandraRecoverJobParams ||
                    (this.CassandraRecoverJobParams != null &&
                    this.CassandraRecoverJobParams.Equals(input.CassandraRecoverJobParams))
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.CouchbaseRecoverJobParams == input.CouchbaseRecoverJobParams ||
                    (this.CouchbaseRecoverJobParams != null &&
                    this.CouchbaseRecoverJobParams.Equals(input.CouchbaseRecoverJobParams))
                ) && 
                (
                    this.HbaseRecoverJobParams == input.HbaseRecoverJobParams ||
                    (this.HbaseRecoverJobParams != null &&
                    this.HbaseRecoverJobParams.Equals(input.HbaseRecoverJobParams))
                ) && 
                (
                    this.HdfsRecoverJobParams == input.HdfsRecoverJobParams ||
                    (this.HdfsRecoverJobParams != null &&
                    this.HdfsRecoverJobParams.Equals(input.HdfsRecoverJobParams))
                ) && 
                (
                    this.HiveRecoverJobParams == input.HiveRecoverJobParams ||
                    (this.HiveRecoverJobParams != null &&
                    this.HiveRecoverJobParams.Equals(input.HiveRecoverJobParams))
                ) && 
                (
                    this.MongodbRecoverJobParams == input.MongodbRecoverJobParams ||
                    (this.MongodbRecoverJobParams != null &&
                    this.MongodbRecoverJobParams.Equals(input.MongodbRecoverJobParams))
                ) && 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
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
                if (this.CassandraRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.CassandraRecoverJobParams.GetHashCode();
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.CouchbaseRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.CouchbaseRecoverJobParams.GetHashCode();
                if (this.HbaseRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.HbaseRecoverJobParams.GetHashCode();
                if (this.HdfsRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.HdfsRecoverJobParams.GetHashCode();
                if (this.HiveRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.HiveRecoverJobParams.GetHashCode();
                if (this.MongodbRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.MongodbRecoverJobParams.GetHashCode();
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                return hashCode;
            }
        }

    }

}

