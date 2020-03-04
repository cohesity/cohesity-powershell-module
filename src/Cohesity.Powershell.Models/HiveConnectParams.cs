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
    /// Specifies an Object containing information about a registered Hive source.
    /// </summary>
    [DataContract]
    public partial class HiveConnectParams :  IEquatable<HiveConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiveConnectParams" /> class.
        /// </summary>
        /// <param name="metastore">Specifies the Hive metastore host..</param>
        /// <param name="thriftPort">Specifies the Hive metastore thrift Port.</param>
        public HiveConnectParams(string metastore = default(string), int? thriftPort = default(int?))
        {
            this.Metastore = metastore;
            this.ThriftPort = thriftPort;
            this.Metastore = metastore;
            this.ThriftPort = thriftPort;
        }
        
        /// <summary>
        /// Specifies the Hive metastore host.
        /// </summary>
        /// <value>Specifies the Hive metastore host.</value>
        [DataMember(Name="metastore", EmitDefaultValue=true)]
        public string Metastore { get; set; }

        /// <summary>
        /// Specifies the Hive metastore thrift Port
        /// </summary>
        /// <value>Specifies the Hive metastore thrift Port</value>
        [DataMember(Name="thriftPort", EmitDefaultValue=true)]
        public int? ThriftPort { get; set; }

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
            return this.Equals(input as HiveConnectParams);
        }

        /// <summary>
        /// Returns true if HiveConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HiveConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiveConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metastore == input.Metastore ||
                    (this.Metastore != null &&
                    this.Metastore.Equals(input.Metastore))
                ) && 
                (
                    this.ThriftPort == input.ThriftPort ||
                    (this.ThriftPort != null &&
                    this.ThriftPort.Equals(input.ThriftPort))
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
                if (this.Metastore != null)
                    hashCode = hashCode * 59 + this.Metastore.GetHashCode();
                if (this.ThriftPort != null)
                    hashCode = hashCode * 59 + this.ThriftPort.GetHashCode();
                return hashCode;
            }
        }

    }

}

