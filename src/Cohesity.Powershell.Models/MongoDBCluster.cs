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
    /// Specifies an Object containing information about a mongodb cluster.
    /// </summary>
    [DataContract]
    public partial class MongoDBCluster :  IEquatable<MongoDBCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBCluster" /> class.
        /// </summary>
        /// <param name="seeds">Seeds of this MongoDB Cluster..</param>
        public MongoDBCluster(List<string> seeds = default(List<string>))
        {
            this.Seeds = seeds;
        }
        
        /// <summary>
        /// Seeds of this MongoDB Cluster.
        /// </summary>
        /// <value>Seeds of this MongoDB Cluster.</value>
        [DataMember(Name="seeds", EmitDefaultValue=false)]
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
            return this.Equals(input as MongoDBCluster);
        }

        /// <summary>
        /// Returns true if MongoDBCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Seeds == input.Seeds ||
                    this.Seeds != null &&
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
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                return hashCode;
            }
        }

    }

}

