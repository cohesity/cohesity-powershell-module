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
    /// Specifies an Object containing information about a Cassandra cluster.
    /// </summary>
    [DataContract]
    public partial class CassandraCluster :  IEquatable<CassandraCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraCluster" /> class.
        /// </summary>
        /// <param name="primaryHost">Primary host from this Cassandra cluster..</param>
        /// <param name="seeds">Seeds of this Cassandra Cluster..</param>
        public CassandraCluster(string primaryHost = default(string), List<string> seeds = default(List<string>))
        {
            this.PrimaryHost = primaryHost;
            this.Seeds = seeds;
            this.PrimaryHost = primaryHost;
            this.Seeds = seeds;
        }
        
        /// <summary>
        /// Primary host from this Cassandra cluster.
        /// </summary>
        /// <value>Primary host from this Cassandra cluster.</value>
        [DataMember(Name="primaryHost", EmitDefaultValue=true)]
        public string PrimaryHost { get; set; }

        /// <summary>
        /// Seeds of this Cassandra Cluster.
        /// </summary>
        /// <value>Seeds of this Cassandra Cluster.</value>
        [DataMember(Name="seeds", EmitDefaultValue=true)]
        public List<string> Seeds { get; set; }

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
            return this.Equals(input as CassandraCluster);
        }

        /// <summary>
        /// Returns true if CassandraCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryHost == input.PrimaryHost ||
                    (this.PrimaryHost != null &&
                    this.PrimaryHost.Equals(input.PrimaryHost))
                ) && 
                (
                    this.Seeds == input.Seeds ||
                    this.Seeds != null &&
                    input.Seeds != null &&
                    this.Seeds.Equals(input.Seeds)
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
                if (this.PrimaryHost != null)
                    hashCode = hashCode * 59 + this.PrimaryHost.GetHashCode();
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                return hashCode;
            }
        }

    }

}

