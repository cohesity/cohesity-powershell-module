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
    /// Info about hosts of the Cassandra source
    /// </summary>
    [DataContract]
    public partial class CassandraHostInfo :  IEquatable<CassandraHostInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraHostInfo" /> class.
        /// </summary>
        /// <param name="hostId">host_id of the host as returned by Cassandra Server..</param>
        /// <param name="hostIp">IP address of the cassandra host.</param>
        public CassandraHostInfo(string hostId = default(string), string hostIp = default(string))
        {
            this.HostId = hostId;
            this.HostIp = hostIp;
            this.HostId = hostId;
            this.HostIp = hostIp;
        }
        
        /// <summary>
        /// host_id of the host as returned by Cassandra Server.
        /// </summary>
        /// <value>host_id of the host as returned by Cassandra Server.</value>
        [DataMember(Name="hostId", EmitDefaultValue=true)]
        public string HostId { get; set; }

        /// <summary>
        /// IP address of the cassandra host
        /// </summary>
        /// <value>IP address of the cassandra host</value>
        [DataMember(Name="hostIp", EmitDefaultValue=true)]
        public string HostIp { get; set; }

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
            return this.Equals(input as CassandraHostInfo);
        }

        /// <summary>
        /// Returns true if CassandraHostInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraHostInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraHostInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.HostIp == input.HostIp ||
                    (this.HostIp != null &&
                    this.HostIp.Equals(input.HostIp))
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
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.HostIp != null)
                    hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                return hashCode;
            }
        }

    }

}

