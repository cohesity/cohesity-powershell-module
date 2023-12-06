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
    /// NoSqlConnectParams
    /// </summary>
    [DataContract]
    public partial class NoSqlConnectParams :  IEquatable<NoSqlConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlConnectParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalParams">cassandraAdditionalParams.</param>
        /// <param name="cassandraConnectParams">cassandraConnectParams.</param>
        /// <param name="couchbaseConnectParams">couchbaseConnectParams.</param>
        /// <param name="hbaseConnectParams">hbaseConnectParams.</param>
        /// <param name="hdfsConnectParams">hdfsConnectParams.</param>
        /// <param name="hiveConnectParams">hiveConnectParams.</param>
        /// <param name="mongodbAdditionalParams">mongodbAdditionalParams.</param>
        /// <param name="mongodbConnectParams">mongodbConnectParams.</param>
        public NoSqlConnectParams(CassandraAdditionalParams cassandraAdditionalParams = default(CassandraAdditionalParams), CassandraConnectParams cassandraConnectParams = default(CassandraConnectParams), CouchbaseConnectParams couchbaseConnectParams = default(CouchbaseConnectParams), HBaseConnectParams hbaseConnectParams = default(HBaseConnectParams), HdfsConnectParams hdfsConnectParams = default(HdfsConnectParams), HiveConnectParams hiveConnectParams = default(HiveConnectParams), MongoDBAdditionalParams mongodbAdditionalParams = default(MongoDBAdditionalParams), MongoDBConnectParams mongodbConnectParams = default(MongoDBConnectParams))
        {
            this.CassandraAdditionalParams = cassandraAdditionalParams;
            this.CassandraConnectParams = cassandraConnectParams;
            this.CouchbaseConnectParams = couchbaseConnectParams;
            this.HbaseConnectParams = hbaseConnectParams;
            this.HdfsConnectParams = hdfsConnectParams;
            this.HiveConnectParams = hiveConnectParams;
            this.MongodbAdditionalParams = mongodbAdditionalParams;
            this.MongodbConnectParams = mongodbConnectParams;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalParams
        /// </summary>
        [DataMember(Name="cassandraAdditionalParams", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalParams { get; set; }

        /// <summary>
        /// Gets or Sets CassandraConnectParams
        /// </summary>
        [DataMember(Name="cassandraConnectParams", EmitDefaultValue=false)]
        public CassandraConnectParams CassandraConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets CouchbaseConnectParams
        /// </summary>
        [DataMember(Name="couchbaseConnectParams", EmitDefaultValue=false)]
        public CouchbaseConnectParams CouchbaseConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets HbaseConnectParams
        /// </summary>
        [DataMember(Name="hbaseConnectParams", EmitDefaultValue=false)]
        public HBaseConnectParams HbaseConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets HdfsConnectParams
        /// </summary>
        [DataMember(Name="hdfsConnectParams", EmitDefaultValue=false)]
        public HdfsConnectParams HdfsConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets HiveConnectParams
        /// </summary>
        [DataMember(Name="hiveConnectParams", EmitDefaultValue=false)]
        public HiveConnectParams HiveConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets MongodbAdditionalParams
        /// </summary>
        [DataMember(Name="mongodbAdditionalParams", EmitDefaultValue=false)]
        public MongoDBAdditionalParams MongodbAdditionalParams { get; set; }

        /// <summary>
        /// Gets or Sets MongodbConnectParams
        /// </summary>
        [DataMember(Name="mongodbConnectParams", EmitDefaultValue=false)]
        public MongoDBConnectParams MongodbConnectParams { get; set; }

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
            return this.Equals(input as NoSqlConnectParams);
        }

        /// <summary>
        /// Returns true if NoSqlConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraAdditionalParams == input.CassandraAdditionalParams ||
                    (this.CassandraAdditionalParams != null &&
                    this.CassandraAdditionalParams.Equals(input.CassandraAdditionalParams))
                ) && 
                (
                    this.CassandraConnectParams == input.CassandraConnectParams ||
                    (this.CassandraConnectParams != null &&
                    this.CassandraConnectParams.Equals(input.CassandraConnectParams))
                ) && 
                (
                    this.CouchbaseConnectParams == input.CouchbaseConnectParams ||
                    (this.CouchbaseConnectParams != null &&
                    this.CouchbaseConnectParams.Equals(input.CouchbaseConnectParams))
                ) && 
                (
                    this.HbaseConnectParams == input.HbaseConnectParams ||
                    (this.HbaseConnectParams != null &&
                    this.HbaseConnectParams.Equals(input.HbaseConnectParams))
                ) && 
                (
                    this.HdfsConnectParams == input.HdfsConnectParams ||
                    (this.HdfsConnectParams != null &&
                    this.HdfsConnectParams.Equals(input.HdfsConnectParams))
                ) && 
                (
                    this.HiveConnectParams == input.HiveConnectParams ||
                    (this.HiveConnectParams != null &&
                    this.HiveConnectParams.Equals(input.HiveConnectParams))
                ) && 
                (
                    this.MongodbAdditionalParams == input.MongodbAdditionalParams ||
                    (this.MongodbAdditionalParams != null &&
                    this.MongodbAdditionalParams.Equals(input.MongodbAdditionalParams))
                ) && 
                (
                    this.MongodbConnectParams == input.MongodbConnectParams ||
                    (this.MongodbConnectParams != null &&
                    this.MongodbConnectParams.Equals(input.MongodbConnectParams))
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
                if (this.CassandraAdditionalParams != null)
                    hashCode = hashCode * 59 + this.CassandraAdditionalParams.GetHashCode();
                if (this.CassandraConnectParams != null)
                    hashCode = hashCode * 59 + this.CassandraConnectParams.GetHashCode();
                if (this.CouchbaseConnectParams != null)
                    hashCode = hashCode * 59 + this.CouchbaseConnectParams.GetHashCode();
                if (this.HbaseConnectParams != null)
                    hashCode = hashCode * 59 + this.HbaseConnectParams.GetHashCode();
                if (this.HdfsConnectParams != null)
                    hashCode = hashCode * 59 + this.HdfsConnectParams.GetHashCode();
                if (this.HiveConnectParams != null)
                    hashCode = hashCode * 59 + this.HiveConnectParams.GetHashCode();
                if (this.MongodbAdditionalParams != null)
                    hashCode = hashCode * 59 + this.MongodbAdditionalParams.GetHashCode();
                if (this.MongodbConnectParams != null)
                    hashCode = hashCode * 59 + this.MongodbConnectParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

