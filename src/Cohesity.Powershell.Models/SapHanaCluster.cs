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
    /// Specifies an Object containing information about a SAP HANA cluster.
    /// </summary>
    [DataContract]
    public partial class SapHanaCluster :  IEquatable<SapHanaCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SapHanaCluster" /> class.
        /// </summary>
        /// <param name="hosts">Hosts of this Universal Data Adapter Cluster..</param>
        public SapHanaCluster(List<string> hosts = default(List<string>))
        {
            this.Hosts = hosts;
            this.Hosts = hosts;
        }
        
        /// <summary>
        /// Hosts of this Universal Data Adapter Cluster.
        /// </summary>
        /// <value>Hosts of this Universal Data Adapter Cluster.</value>
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
            return this.Equals(input as SapHanaCluster);
        }

        /// <summary>
        /// Returns true if SapHanaCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of SapHanaCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SapHanaCluster input)
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

