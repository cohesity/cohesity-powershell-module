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
    /// Specifies an Object containing information about a DB2 cluster.
    /// </summary>
    [DataContract]
    public partial class DB2Cluster :  IEquatable<DB2Cluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DB2Cluster" /> class.
        /// </summary>
        /// <param name="hosts">Hosts of this DB2 Cluster..</param>
        public DB2Cluster(List<string> hosts = default(List<string>))
        {
            this.Hosts = hosts;
            this.Hosts = hosts;
        }
        
        /// <summary>
        /// Hosts of this DB2 Cluster.
        /// </summary>
        /// <value>Hosts of this DB2 Cluster.</value>
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
            return this.Equals(input as DB2Cluster);
        }

        /// <summary>
        /// Returns true if DB2Cluster instances are equal
        /// </summary>
        /// <param name="input">Instance of DB2Cluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DB2Cluster input)
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

