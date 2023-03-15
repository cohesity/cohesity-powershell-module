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
    /// NodeToTieredStorageDirectoriesMap
    /// </summary>
    [DataContract]
    public partial class NodeToTieredStorageDirectoriesMap :  IEquatable<NodeToTieredStorageDirectoriesMap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeToTieredStorageDirectoriesMap" /> class.
        /// </summary>
        /// <param name="cassandraNodeName">Name of the Cassandra node..</param>
        /// <param name="tieredStorageDirectoriesVec">Array of tiered storage directories..</param>
        public NodeToTieredStorageDirectoriesMap(string cassandraNodeName = default(string), List<string> tieredStorageDirectoriesVec = default(List<string>))
        {
            this.CassandraNodeName = cassandraNodeName;
            this.TieredStorageDirectoriesVec = tieredStorageDirectoriesVec;
            this.CassandraNodeName = cassandraNodeName;
            this.TieredStorageDirectoriesVec = tieredStorageDirectoriesVec;
        }
        
        /// <summary>
        /// Name of the Cassandra node.
        /// </summary>
        /// <value>Name of the Cassandra node.</value>
        [DataMember(Name="cassandraNodeName", EmitDefaultValue=true)]
        public string CassandraNodeName { get; set; }

        /// <summary>
        /// Array of tiered storage directories.
        /// </summary>
        /// <value>Array of tiered storage directories.</value>
        [DataMember(Name="tieredStorageDirectoriesVec", EmitDefaultValue=true)]
        public List<string> TieredStorageDirectoriesVec { get; set; }

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
            return this.Equals(input as NodeToTieredStorageDirectoriesMap);
        }

        /// <summary>
        /// Returns true if NodeToTieredStorageDirectoriesMap instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeToTieredStorageDirectoriesMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeToTieredStorageDirectoriesMap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraNodeName == input.CassandraNodeName ||
                    (this.CassandraNodeName != null &&
                    this.CassandraNodeName.Equals(input.CassandraNodeName))
                ) && 
                (
                    this.TieredStorageDirectoriesVec == input.TieredStorageDirectoriesVec ||
                    this.TieredStorageDirectoriesVec != null &&
                    input.TieredStorageDirectoriesVec != null &&
                    this.TieredStorageDirectoriesVec.SequenceEqual(input.TieredStorageDirectoriesVec)
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
                if (this.CassandraNodeName != null)
                    hashCode = hashCode * 59 + this.CassandraNodeName.GetHashCode();
                if (this.TieredStorageDirectoriesVec != null)
                    hashCode = hashCode * 59 + this.TieredStorageDirectoriesVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

