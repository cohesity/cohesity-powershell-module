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
    /// Contains additional parameters required by the agents to backup data from Cassandra.
    /// </summary>
    [DataContract]
    public partial class CassandraAdditionalParams :  IEquatable<CassandraAdditionalParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraAdditionalParams" /> class.
        /// </summary>
        /// <param name="cassandraClasspathSuffix">Cassandra classpath suffix..</param>
        /// <param name="cassandraPartitioner">Required in compaction..</param>
        /// <param name="cassandraVersion">Cassandra and DSE Versions. Discovery code will attempt to discover the versions..</param>
        /// <param name="dataCenterVec">Data center information is required for backup and recovery..</param>
        /// <param name="dseSolrInfo">dseSolrInfo.</param>
        /// <param name="dseVersion">dseVersion.</param>
        /// <param name="tieredStorageDirsMap">Map of nodes to tiered storage directories.</param>
        public CassandraAdditionalParams(string cassandraClasspathSuffix = default(string), string cassandraPartitioner = default(string), string cassandraVersion = default(string), List<string> dataCenterVec = default(List<string>), DSESolrInfo dseSolrInfo = default(DSESolrInfo), string dseVersion = default(string), List<NodeToTieredStorageDirectoriesMap> tieredStorageDirsMap = default(List<NodeToTieredStorageDirectoriesMap>))
        {
            this.CassandraClasspathSuffix = cassandraClasspathSuffix;
            this.CassandraPartitioner = cassandraPartitioner;
            this.CassandraVersion = cassandraVersion;
            this.DataCenterVec = dataCenterVec;
            this.DseSolrInfo = dseSolrInfo;
            this.DseVersion = dseVersion;
            this.TieredStorageDirsMap = tieredStorageDirsMap;
        }
        
        /// <summary>
        /// Cassandra classpath suffix.
        /// </summary>
        /// <value>Cassandra classpath suffix.</value>
        [DataMember(Name="cassandraClasspathSuffix", EmitDefaultValue=false)]
        public string CassandraClasspathSuffix { get; set; }

        /// <summary>
        /// Required in compaction.
        /// </summary>
        /// <value>Required in compaction.</value>
        [DataMember(Name="cassandraPartitioner", EmitDefaultValue=false)]
        public string CassandraPartitioner { get; set; }

        /// <summary>
        /// Cassandra and DSE Versions. Discovery code will attempt to discover the versions.
        /// </summary>
        /// <value>Cassandra and DSE Versions. Discovery code will attempt to discover the versions.</value>
        [DataMember(Name="cassandraVersion", EmitDefaultValue=false)]
        public string CassandraVersion { get; set; }

        /// <summary>
        /// Data center information is required for backup and recovery.
        /// </summary>
        /// <value>Data center information is required for backup and recovery.</value>
        [DataMember(Name="dataCenterVec", EmitDefaultValue=false)]
        public List<string> DataCenterVec { get; set; }

        /// <summary>
        /// Gets or Sets DseSolrInfo
        /// </summary>
        [DataMember(Name="dseSolrInfo", EmitDefaultValue=false)]
        public DSESolrInfo DseSolrInfo { get; set; }

        /// <summary>
        /// Gets or Sets DseVersion
        /// </summary>
        [DataMember(Name="dseVersion", EmitDefaultValue=false)]
        public string DseVersion { get; set; }

        /// <summary>
        /// Map of nodes to tiered storage directories
        /// </summary>
        /// <value>Map of nodes to tiered storage directories</value>
        [DataMember(Name="tieredStorageDirsMap", EmitDefaultValue=false)]
        public List<NodeToTieredStorageDirectoriesMap> TieredStorageDirsMap { get; set; }

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
            return this.Equals(input as CassandraAdditionalParams);
        }

        /// <summary>
        /// Returns true if CassandraAdditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraAdditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraAdditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraClasspathSuffix == input.CassandraClasspathSuffix ||
                    (this.CassandraClasspathSuffix != null &&
                    this.CassandraClasspathSuffix.Equals(input.CassandraClasspathSuffix))
                ) && 
                (
                    this.CassandraPartitioner == input.CassandraPartitioner ||
                    (this.CassandraPartitioner != null &&
                    this.CassandraPartitioner.Equals(input.CassandraPartitioner))
                ) && 
                (
                    this.CassandraVersion == input.CassandraVersion ||
                    (this.CassandraVersion != null &&
                    this.CassandraVersion.Equals(input.CassandraVersion))
                ) && 
                (
                    this.DataCenterVec == input.DataCenterVec ||
                    this.DataCenterVec != null &&
                    this.DataCenterVec.Equals(input.DataCenterVec)
                ) && 
                (
                    this.DseSolrInfo == input.DseSolrInfo ||
                    (this.DseSolrInfo != null &&
                    this.DseSolrInfo.Equals(input.DseSolrInfo))
                ) && 
                (
                    this.DseVersion == input.DseVersion ||
                    (this.DseVersion != null &&
                    this.DseVersion.Equals(input.DseVersion))
                ) && 
                (
                    this.TieredStorageDirsMap == input.TieredStorageDirsMap ||
                    this.TieredStorageDirsMap != null &&
                    this.TieredStorageDirsMap.Equals(input.TieredStorageDirsMap)
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
                if (this.CassandraClasspathSuffix != null)
                    hashCode = hashCode * 59 + this.CassandraClasspathSuffix.GetHashCode();
                if (this.CassandraPartitioner != null)
                    hashCode = hashCode * 59 + this.CassandraPartitioner.GetHashCode();
                if (this.CassandraVersion != null)
                    hashCode = hashCode * 59 + this.CassandraVersion.GetHashCode();
                if (this.DataCenterVec != null)
                    hashCode = hashCode * 59 + this.DataCenterVec.GetHashCode();
                if (this.DseSolrInfo != null)
                    hashCode = hashCode * 59 + this.DseSolrInfo.GetHashCode();
                if (this.DseVersion != null)
                    hashCode = hashCode * 59 + this.DseVersion.GetHashCode();
                if (this.TieredStorageDirsMap != null)
                    hashCode = hashCode * 59 + this.TieredStorageDirsMap.GetHashCode();
                return hashCode;
            }
        }

    }

}

