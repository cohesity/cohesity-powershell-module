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
        /// <param name="hdfsEntityId">Specifies the entity id of the HDFS source for this Hive.</param>
        /// <param name="kerberosPrincipal">Specifies the kerberos principal..</param>
        /// <param name="metastore">Specifies the Hive metastore host..</param>
        /// <param name="thriftPort">Specifies the Hive metastore thrift Port.</param>
        public HiveConnectParams(long? hdfsEntityId = default(long?), string kerberosPrincipal = default(string), string metastore = default(string), int? thriftPort = default(int?))
        {
            this.HdfsEntityId = hdfsEntityId;
            this.KerberosPrincipal = kerberosPrincipal;
            this.Metastore = metastore;
            this.ThriftPort = thriftPort;
        }
        
        /// <summary>
        /// Specifies the entity id of the HDFS source for this Hive
        /// </summary>
        /// <value>Specifies the entity id of the HDFS source for this Hive</value>
        [DataMember(Name="hdfsEntityId", EmitDefaultValue=false)]
        public long? HdfsEntityId { get; set; }

        /// <summary>
        /// Specifies the kerberos principal.
        /// </summary>
        /// <value>Specifies the kerberos principal.</value>
        [DataMember(Name="kerberosPrincipal", EmitDefaultValue=false)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Specifies the Hive metastore host.
        /// </summary>
        /// <value>Specifies the Hive metastore host.</value>
        [DataMember(Name="metastore", EmitDefaultValue=false)]
        public string Metastore { get; set; }

        /// <summary>
        /// Specifies the Hive metastore thrift Port
        /// </summary>
        /// <value>Specifies the Hive metastore thrift Port</value>
        [DataMember(Name="thriftPort", EmitDefaultValue=false)]
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
                    this.HdfsEntityId == input.HdfsEntityId ||
                    (this.HdfsEntityId != null &&
                    this.HdfsEntityId.Equals(input.HdfsEntityId))
                ) && 
                (
                    this.KerberosPrincipal == input.KerberosPrincipal ||
                    (this.KerberosPrincipal != null &&
                    this.KerberosPrincipal.Equals(input.KerberosPrincipal))
                ) && 
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
                if (this.HdfsEntityId != null)
                    hashCode = hashCode * 59 + this.HdfsEntityId.GetHashCode();
                if (this.KerberosPrincipal != null)
                    hashCode = hashCode * 59 + this.KerberosPrincipal.GetHashCode();
                if (this.Metastore != null)
                    hashCode = hashCode * 59 + this.Metastore.GetHashCode();
                if (this.ThriftPort != null)
                    hashCode = hashCode * 59 + this.ThriftPort.GetHashCode();
                return hashCode;
            }
        }

    }

}

