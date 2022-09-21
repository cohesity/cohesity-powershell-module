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
    /// Specifies an Object containing information about a Cassandra Keyspace.
    /// </summary>
    [DataContract]
    public partial class CassandraKeyspace :  IEquatable<CassandraKeyspace>
    {
        /// <summary>
        /// Replication stragegy for the keyspace. Specifies the type of an Cassandra source entity.
        /// </summary>
        /// <value>Replication stragegy for the keyspace. Specifies the type of an Cassandra source entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReplicationStrategyEnum
        {
            /// <summary>
            /// Enum KSimple for value: kSimple
            /// </summary>
            [EnumMember(Value = "kSimple")]
            KSimple = 1,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 2,

            /// <summary>
            /// Enum KUnsupported for value: kUnsupported
            /// </summary>
            [EnumMember(Value = "kUnsupported")]
            KUnsupported = 3

        }

        /// <summary>
        /// Replication stragegy for the keyspace. Specifies the type of an Cassandra source entity.
        /// </summary>
        /// <value>Replication stragegy for the keyspace. Specifies the type of an Cassandra source entity.</value>
        [DataMember(Name="replicationStrategy", EmitDefaultValue=true)]
        public ReplicationStrategyEnum? ReplicationStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraKeyspace" /> class.
        /// </summary>
        /// <param name="childrenCount">Number of documents in this bucket..</param>
        /// <param name="dcList">If the replication strategy is set as kNetwork, then dc_list will have a list of data centers to which the keyspace is being replicated to..</param>
        /// <param name="replicationStrategy">Replication stragegy for the keyspace. Specifies the type of an Cassandra source entity..</param>
        public CassandraKeyspace(int? childrenCount = default(int?), List<string> dcList = default(List<string>), ReplicationStrategyEnum? replicationStrategy = default(ReplicationStrategyEnum?))
        {
            this.ChildrenCount = childrenCount;
            this.DcList = dcList;
            this.ReplicationStrategy = replicationStrategy;
        }
        
        /// <summary>
        /// Number of documents in this bucket.
        /// </summary>
        /// <value>Number of documents in this bucket.</value>
        [DataMember(Name="childrenCount", EmitDefaultValue=true)]
        public int? ChildrenCount { get; set; }

        /// <summary>
        /// If the replication strategy is set as kNetwork, then dc_list will have a list of data centers to which the keyspace is being replicated to.
        /// </summary>
        /// <value>If the replication strategy is set as kNetwork, then dc_list will have a list of data centers to which the keyspace is being replicated to.</value>
        [DataMember(Name="dcList", EmitDefaultValue=true)]
        public List<string> DcList { get; set; }

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
            return this.Equals(input as CassandraKeyspace);
        }

        /// <summary>
        /// Returns true if CassandraKeyspace instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraKeyspace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraKeyspace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildrenCount == input.ChildrenCount ||
                    (this.ChildrenCount != null &&
                    this.ChildrenCount.Equals(input.ChildrenCount))
                ) && 
                (
                    this.DcList == input.DcList ||
                    this.DcList != null &&
                    input.DcList != null &&
                    this.DcList.Equals(input.DcList)
                ) && 
                (
                    this.ReplicationStrategy == input.ReplicationStrategy ||
                    this.ReplicationStrategy.Equals(input.ReplicationStrategy)
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
                if (this.ChildrenCount != null)
                    hashCode = hashCode * 59 + this.ChildrenCount.GetHashCode();
                if (this.DcList != null)
                    hashCode = hashCode * 59 + this.DcList.GetHashCode();
                if (this.DcList != null)
					hashCode = hashCode * 59 + this.ReplicationStrategy.GetHashCode();
                return hashCode;
            }
        }

    }

}

