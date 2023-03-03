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
    /// Specifies an Object containing information about a couchbase cluster.
    /// </summary>
    [DataContract]
    public partial class CouchbaseCluster :  IEquatable<CouchbaseCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouchbaseCluster" /> class.
        /// </summary>
        /// <param name="seeds">Seeds of this Couchbase Cluster..</param>
        public CouchbaseCluster(List<string> seeds = default(List<string>))
        {
            this.Seeds = seeds;
            this.Seeds = seeds;
        }
        
        /// <summary>
        /// Seeds of this Couchbase Cluster.
        /// </summary>
        /// <value>Seeds of this Couchbase Cluster.</value>
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
            return this.Equals(input as CouchbaseCluster);
        }

        /// <summary>
        /// Returns true if CouchbaseCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of CouchbaseCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouchbaseCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Seeds == input.Seeds ||
                    this.Seeds != null &&
                    input.Seeds != null &&
                    this.Seeds.SequenceEqual(input.Seeds)
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
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                return hashCode;
            }
        }

    }

}

