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
    /// Specifies an Object containing information about a Postgres cluster.
    /// </summary>
    [DataContract]
    public partial class PostgresCluster :  IEquatable<PostgresCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresCluster" /> class.
        /// </summary>
        /// <param name="hosts">Hosts of this Postgres Cluster..</param>
        public PostgresCluster(List<string> hosts = default(List<string>))
        {
            this.Hosts = hosts;
            this.Hosts = hosts;
        }
        
        /// <summary>
        /// Hosts of this Postgres Cluster.
        /// </summary>
        /// <value>Hosts of this Postgres Cluster.</value>
        [DataMember(Name="hosts", EmitDefaultValue=true)]
        public List<string> Hosts { get; set; }

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
            return this.Equals(input as PostgresCluster);
        }

        /// <summary>
        /// Returns true if PostgresCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of PostgresCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostgresCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
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
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                return hashCode;
            }
        }

    }

}

