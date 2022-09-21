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
    /// Specifies an Object containing information about a registered Hdfs source.
    /// </summary>
    [DataContract]
    public partial class HdfsConnectParams :  IEquatable<HdfsConnectParams>
    {
        /// <summary>
        /// Specifies the Hadoop Distribution. Hadoop distribution.  &#39;CDH&#39; indicates Hadoop distribution type Cloudera. &#39;HDP&#39; indicates Hadoop distribution type Hortonworks.
        /// </summary>
        /// <value>Specifies the Hadoop Distribution. Hadoop distribution.  &#39;CDH&#39; indicates Hadoop distribution type Cloudera. &#39;HDP&#39; indicates Hadoop distribution type Hortonworks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HadoopDistributionEnum
        {
            /// <summary>
            /// Enum CDH for value: CDH
            /// </summary>
            [EnumMember(Value = "CDH")]
            CDH = 1,

            /// <summary>
            /// Enum HDP for value: HDP
            /// </summary>
            [EnumMember(Value = "HDP")]
            HDP = 2

        }

        /// <summary>
        /// Specifies the Hadoop Distribution. Hadoop distribution.  &#39;CDH&#39; indicates Hadoop distribution type Cloudera. &#39;HDP&#39; indicates Hadoop distribution type Hortonworks.
        /// </summary>
        /// <value>Specifies the Hadoop Distribution. Hadoop distribution.  &#39;CDH&#39; indicates Hadoop distribution type Cloudera. &#39;HDP&#39; indicates Hadoop distribution type Hortonworks.</value>
        [DataMember(Name="hadoopDistribution", EmitDefaultValue=true)]
        public HadoopDistributionEnum? HadoopDistribution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HdfsConnectParams" /> class.
        /// </summary>
        /// <param name="hadoopDistribution">Specifies the Hadoop Distribution. Hadoop distribution.  &#39;CDH&#39; indicates Hadoop distribution type Cloudera. &#39;HDP&#39; indicates Hadoop distribution type Hortonworks..</param>
        /// <param name="hadoopVersion">Specifies the Hadoop version.</param>
        /// <param name="kerberosPrincipal">Specifies the kerberos principal..</param>
        /// <param name="namenode">Specifies the Namenode host or Nameservice..</param>
        /// <param name="port">Specifies the Webhdfs Port.</param>
        public HdfsConnectParams(HadoopDistributionEnum? hadoopDistribution = default(HadoopDistributionEnum?), string hadoopVersion = default(string), string kerberosPrincipal = default(string), string namenode = default(string), int? port = default(int?))
        {
            this.HadoopDistribution = hadoopDistribution;
            this.HadoopVersion = hadoopVersion;
            this.KerberosPrincipal = kerberosPrincipal;
            this.Namenode = namenode;
            this.Port = port;
        }
        
        /// <summary>
        /// Specifies the Hadoop version
        /// </summary>
        /// <value>Specifies the Hadoop version</value>
        [DataMember(Name="hadoopVersion", EmitDefaultValue=true)]
        public string HadoopVersion { get; set; }

        /// <summary>
        /// Specifies the kerberos principal.
        /// </summary>
        /// <value>Specifies the kerberos principal.</value>
        [DataMember(Name="kerberosPrincipal", EmitDefaultValue=true)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Specifies the Namenode host or Nameservice.
        /// </summary>
        /// <value>Specifies the Namenode host or Nameservice.</value>
        [DataMember(Name="namenode", EmitDefaultValue=true)]
        public string Namenode { get; set; }

        /// <summary>
        /// Specifies the Webhdfs Port
        /// </summary>
        /// <value>Specifies the Webhdfs Port</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

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
            return this.Equals(input as HdfsConnectParams);
        }

        /// <summary>
        /// Returns true if HdfsConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HdfsConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HdfsConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HadoopDistribution == input.HadoopDistribution ||
                    this.HadoopDistribution.Equals(input.HadoopDistribution)
                ) && 
                (
                    this.HadoopVersion == input.HadoopVersion ||
                    (this.HadoopVersion != null &&
                    this.HadoopVersion.Equals(input.HadoopVersion))
                ) && 
                (
                    this.KerberosPrincipal == input.KerberosPrincipal ||
                    (this.KerberosPrincipal != null &&
                    this.KerberosPrincipal.Equals(input.KerberosPrincipal))
                ) && 
                (
                    this.Namenode == input.Namenode ||
                    (this.Namenode != null &&
                    this.Namenode.Equals(input.Namenode))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                hashCode = hashCode * 59 + this.HadoopDistribution.GetHashCode();
                if (this.HadoopVersion != null)
                    hashCode = hashCode * 59 + this.HadoopVersion.GetHashCode();
                if (this.KerberosPrincipal != null)
                    hashCode = hashCode * 59 + this.KerberosPrincipal.GetHashCode();
                if (this.Namenode != null)
                    hashCode = hashCode * 59 + this.Namenode.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }

    }

}

