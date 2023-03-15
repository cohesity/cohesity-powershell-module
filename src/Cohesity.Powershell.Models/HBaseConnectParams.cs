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
    /// Specifies an Object containing information about a registered HBase source.
    /// </summary>
    [DataContract]
    public partial class HBaseConnectParams :  IEquatable<HBaseConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HBaseConnectParams" /> class.
        /// </summary>
        /// <param name="hdfsEntityId">The entity id of the HDFS source for this HBase.</param>
        /// <param name="kerberosPrincipal">Specifies the kerberos principal..</param>
        /// <param name="rootDataDirectory">Specifies the HBase data root directory..</param>
        /// <param name="zookeeperQuorum">Specifies the HBase zookeeper quorum..</param>
        public HBaseConnectParams(long? hdfsEntityId = default(long?), string kerberosPrincipal = default(string), string rootDataDirectory = default(string), List<string> zookeeperQuorum = default(List<string>))
        {
            this.HdfsEntityId = hdfsEntityId;
            this.KerberosPrincipal = kerberosPrincipal;
            this.RootDataDirectory = rootDataDirectory;
            this.ZookeeperQuorum = zookeeperQuorum;
            this.HdfsEntityId = hdfsEntityId;
            this.KerberosPrincipal = kerberosPrincipal;
            this.RootDataDirectory = rootDataDirectory;
            this.ZookeeperQuorum = zookeeperQuorum;
        }
        
        /// <summary>
        /// The entity id of the HDFS source for this HBase
        /// </summary>
        /// <value>The entity id of the HDFS source for this HBase</value>
        [DataMember(Name="hdfsEntityId", EmitDefaultValue=true)]
        public long? HdfsEntityId { get; set; }

        /// <summary>
        /// Specifies the kerberos principal.
        /// </summary>
        /// <value>Specifies the kerberos principal.</value>
        [DataMember(Name="kerberosPrincipal", EmitDefaultValue=true)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Specifies the HBase data root directory.
        /// </summary>
        /// <value>Specifies the HBase data root directory.</value>
        [DataMember(Name="rootDataDirectory", EmitDefaultValue=true)]
        public string RootDataDirectory { get; set; }

        /// <summary>
        /// Specifies the HBase zookeeper quorum.
        /// </summary>
        /// <value>Specifies the HBase zookeeper quorum.</value>
        [DataMember(Name="zookeeperQuorum", EmitDefaultValue=true)]
        public List<string> ZookeeperQuorum { get; set; }

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
            return this.Equals(input as HBaseConnectParams);
        }

        /// <summary>
        /// Returns true if HBaseConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HBaseConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HBaseConnectParams input)
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
                    this.RootDataDirectory == input.RootDataDirectory ||
                    (this.RootDataDirectory != null &&
                    this.RootDataDirectory.Equals(input.RootDataDirectory))
                ) && 
                (
                    this.ZookeeperQuorum == input.ZookeeperQuorum ||
                    this.ZookeeperQuorum != null &&
                    input.ZookeeperQuorum != null &&
                    this.ZookeeperQuorum.SequenceEqual(input.ZookeeperQuorum)
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
                if (this.RootDataDirectory != null)
                    hashCode = hashCode * 59 + this.RootDataDirectory.GetHashCode();
                if (this.ZookeeperQuorum != null)
                    hashCode = hashCode * 59 + this.ZookeeperQuorum.GetHashCode();
                return hashCode;
            }
        }

    }

}

