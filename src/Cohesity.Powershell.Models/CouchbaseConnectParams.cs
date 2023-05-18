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
    /// Specifies an Object containing information about a registered couchbase source.
    /// </summary>
    [DataContract]
    public partial class CouchbaseConnectParams :  IEquatable<CouchbaseConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouchbaseConnectParams" /> class.
        /// </summary>
        /// <param name="carrierDirectPort">Specifies the Carrier direct/sll port..</param>
        /// <param name="httpDirectPort">Specifies the HTTP direct/sll port..</param>
        /// <param name="requiresSsl">Specifies whether this cluster allows connection through SSL only..</param>
        /// <param name="seeds">Specifies the Seeds of this Couchbase Cluster..</param>
        public CouchbaseConnectParams(int? carrierDirectPort = default(int?), int? httpDirectPort = default(int?), bool? requiresSsl = default(bool?), List<string> seeds = default(List<string>))
        {
            this.CarrierDirectPort = carrierDirectPort;
            this.HttpDirectPort = httpDirectPort;
            this.RequiresSsl = requiresSsl;
            this.Seeds = seeds;
            this.CarrierDirectPort = carrierDirectPort;
            this.HttpDirectPort = httpDirectPort;
            this.RequiresSsl = requiresSsl;
            this.Seeds = seeds;
        }
        
        /// <summary>
        /// Specifies the Carrier direct/sll port.
        /// </summary>
        /// <value>Specifies the Carrier direct/sll port.</value>
        [DataMember(Name="carrierDirectPort", EmitDefaultValue=true)]
        public int? CarrierDirectPort { get; set; }

        /// <summary>
        /// Specifies the HTTP direct/sll port.
        /// </summary>
        /// <value>Specifies the HTTP direct/sll port.</value>
        [DataMember(Name="httpDirectPort", EmitDefaultValue=true)]
        public int? HttpDirectPort { get; set; }

        /// <summary>
        /// Specifies whether this cluster allows connection through SSL only.
        /// </summary>
        /// <value>Specifies whether this cluster allows connection through SSL only.</value>
        [DataMember(Name="requiresSsl", EmitDefaultValue=true)]
        public bool? RequiresSsl { get; set; }

        /// <summary>
        /// Specifies the Seeds of this Couchbase Cluster.
        /// </summary>
        /// <value>Specifies the Seeds of this Couchbase Cluster.</value>
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
            return this.Equals(input as CouchbaseConnectParams);
        }

        /// <summary>
        /// Returns true if CouchbaseConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CouchbaseConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouchbaseConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierDirectPort == input.CarrierDirectPort ||
                    (this.CarrierDirectPort != null &&
                    this.CarrierDirectPort.Equals(input.CarrierDirectPort))
                ) && 
                (
                    this.HttpDirectPort == input.HttpDirectPort ||
                    (this.HttpDirectPort != null &&
                    this.HttpDirectPort.Equals(input.HttpDirectPort))
                ) && 
                (
                    this.RequiresSsl == input.RequiresSsl ||
                    (this.RequiresSsl != null &&
                    this.RequiresSsl.Equals(input.RequiresSsl))
                ) && 
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
                if (this.CarrierDirectPort != null)
                    hashCode = hashCode * 59 + this.CarrierDirectPort.GetHashCode();
                if (this.HttpDirectPort != null)
                    hashCode = hashCode * 59 + this.HttpDirectPort.GetHashCode();
                if (this.RequiresSsl != null)
                    hashCode = hashCode * 59 + this.RequiresSsl.GetHashCode();
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                return hashCode;
            }
        }

    }

}

