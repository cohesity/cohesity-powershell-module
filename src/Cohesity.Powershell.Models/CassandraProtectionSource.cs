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
    /// Specifies an Object representing Cassandra.
    /// </summary>
    [DataContract]
    public partial class CassandraProtectionSource :  IEquatable<CassandraProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Cassandra Protection Source. Replication strategy options for a keyspace. &#39;kCluster&#39; indicates a Cassandra cluster distributed over several physical nodes. &#39;kKeyspace&#39; indicates a Keyspace enclosing one or more tables. &#39;kTable&#39; indicates a Table in the Cassandra environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Cassandra Protection Source. Replication strategy options for a keyspace. &#39;kCluster&#39; indicates a Cassandra cluster distributed over several physical nodes. &#39;kKeyspace&#39; indicates a Keyspace enclosing one or more tables. &#39;kTable&#39; indicates a Table in the Cassandra environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KKeyspace for value: kKeyspace
            /// </summary>
            [EnumMember(Value = "kKeyspace")]
            KKeyspace = 2,

            /// <summary>
            /// Enum KTable for value: kTable
            /// </summary>
            [EnumMember(Value = "kTable")]
            KTable = 3

        }

        /// <summary>
        /// Specifies the type of the managed Object in Cassandra Protection Source. Replication strategy options for a keyspace. &#39;kCluster&#39; indicates a Cassandra cluster distributed over several physical nodes. &#39;kKeyspace&#39; indicates a Keyspace enclosing one or more tables. &#39;kTable&#39; indicates a Table in the Cassandra environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Cassandra Protection Source. Replication strategy options for a keyspace. &#39;kCluster&#39; indicates a Cassandra cluster distributed over several physical nodes. &#39;kKeyspace&#39; indicates a Keyspace enclosing one or more tables. &#39;kTable&#39; indicates a Table in the Cassandra environment.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraProtectionSource" /> class.
        /// </summary>
        /// <param name="clusterInfo">clusterInfo.</param>
        /// <param name="keyspaceInfo">keyspaceInfo.</param>
        /// <param name="name">Specifies the instance name of the Cassandra entity..</param>
        /// <param name="type">Specifies the type of the managed Object in Cassandra Protection Source. Replication strategy options for a keyspace. &#39;kCluster&#39; indicates a Cassandra cluster distributed over several physical nodes. &#39;kKeyspace&#39; indicates a Keyspace enclosing one or more tables. &#39;kTable&#39; indicates a Table in the Cassandra environment..</param>
        /// <param name="uuid">Specifies the UUID for the Cassandra entity. Note : For each entity an ID unique within top level entity should be assigned by imanis backend. Example, UUID for a table can be the string &lt;keyspace_name&gt;.&lt;table_name&gt;.</param>
        public CassandraProtectionSource(CassandraCluster clusterInfo = default(CassandraCluster), CassandraKeyspace keyspaceInfo = default(CassandraKeyspace), string name = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.ClusterInfo = clusterInfo;
            this.KeyspaceInfo = keyspaceInfo;
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets ClusterInfo
        /// </summary>
        [DataMember(Name="clusterInfo", EmitDefaultValue=false)]
        public CassandraCluster ClusterInfo { get; set; }

        /// <summary>
        /// Gets or Sets KeyspaceInfo
        /// </summary>
        [DataMember(Name="keyspaceInfo", EmitDefaultValue=false)]
        public CassandraKeyspace KeyspaceInfo { get; set; }

        /// <summary>
        /// Specifies the instance name of the Cassandra entity.
        /// </summary>
        /// <value>Specifies the instance name of the Cassandra entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Specifies the UUID for the Cassandra entity. Note : For each entity an ID unique within top level entity should be assigned by imanis backend. Example, UUID for a table can be the string &lt;keyspace_name&gt;.&lt;table_name&gt;
        /// </summary>
        /// <value>Specifies the UUID for the Cassandra entity. Note : For each entity an ID unique within top level entity should be assigned by imanis backend. Example, UUID for a table can be the string &lt;keyspace_name&gt;.&lt;table_name&gt;</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

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
            return this.Equals(input as CassandraProtectionSource);
        }

        /// <summary>
        /// Returns true if CassandraProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterInfo == input.ClusterInfo ||
                    (this.ClusterInfo != null &&
                    this.ClusterInfo.Equals(input.ClusterInfo))
                ) && 
                (
                    this.KeyspaceInfo == input.KeyspaceInfo ||
                    (this.KeyspaceInfo != null &&
                    this.KeyspaceInfo.Equals(input.KeyspaceInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.KeyspaceInfo != null)
                    hashCode = hashCode * 59 + this.KeyspaceInfo.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

