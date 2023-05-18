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
    /// Specifies an Object containing information about a registered cassandra source.
    /// </summary>
    [DataContract]
    public partial class CassandraConnectParams :  IEquatable<CassandraConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraConnectParams" /> class.
        /// </summary>
        /// <param name="cassandraPortsInfo">cassandraPortsInfo.</param>
        /// <param name="cassandraSecurityInfo">cassandraSecurityInfo.</param>
        /// <param name="cassandraVersion">Cassandra version.</param>
        /// <param name="commitLogBackupLocation">Specifies the commit log archival location for cassandra node.</param>
        /// <param name="configDirectory">Specifies the Directory path containing Config YAML for discovery..</param>
        /// <param name="dataCenters">Specifies the List of all physical data center or virtual data center. In most cases, the data centers will be listed after discovery operation however, if they are not listed, you must manually type the data center names. Leaving the field blank will disallow data center-specific backup or restore. Entering a subset of all data centers may cause problems in data movement..</param>
        /// <param name="dseConfigDirectory">Specifies the Directory from where DSE specific configuration can be read..</param>
        /// <param name="isDseAuthenticator">Specifies whether this cluster has DSE Authenticator..</param>
        /// <param name="isDseTieredStorage">Specifies whether this cluster has DSE tiered storage..</param>
        /// <param name="isJmxAuthEnable">Specifies if JMX Authentication enabled in this cluster..</param>
        /// <param name="kerberosPrincipal">Specifies the Kerberos Principal for Kerberos connection.</param>
        /// <param name="primaryHost">Specifies the Primary Host for the Cassandra cluster..</param>
        /// <param name="seeds">Specifies the Seed nodes of this Cassandra cluster..</param>
        /// <param name="solrNodes">Specifies the Solr node IP Addresses.</param>
        /// <param name="solrPort">Specifies the Solr node Port..</param>
        public CassandraConnectParams(CassandraPortsInfo cassandraPortsInfo = default(CassandraPortsInfo), CassandraSecurityInfo cassandraSecurityInfo = default(CassandraSecurityInfo), string cassandraVersion = default(string), string commitLogBackupLocation = default(string), string configDirectory = default(string), List<string> dataCenters = default(List<string>), string dseConfigDirectory = default(string), bool? isDseAuthenticator = default(bool?), bool? isDseTieredStorage = default(bool?), bool? isJmxAuthEnable = default(bool?), string kerberosPrincipal = default(string), string primaryHost = default(string), List<string> seeds = default(List<string>), List<string> solrNodes = default(List<string>), int? solrPort = default(int?))
        {
            this.CassandraVersion = cassandraVersion;
            this.CommitLogBackupLocation = commitLogBackupLocation;
            this.ConfigDirectory = configDirectory;
            this.DataCenters = dataCenters;
            this.DseConfigDirectory = dseConfigDirectory;
            this.IsDseAuthenticator = isDseAuthenticator;
            this.IsDseTieredStorage = isDseTieredStorage;
            this.IsJmxAuthEnable = isJmxAuthEnable;
            this.KerberosPrincipal = kerberosPrincipal;
            this.PrimaryHost = primaryHost;
            this.Seeds = seeds;
            this.SolrNodes = solrNodes;
            this.SolrPort = solrPort;
            this.CassandraPortsInfo = cassandraPortsInfo;
            this.CassandraSecurityInfo = cassandraSecurityInfo;
            this.CassandraVersion = cassandraVersion;
            this.CommitLogBackupLocation = commitLogBackupLocation;
            this.ConfigDirectory = configDirectory;
            this.DataCenters = dataCenters;
            this.DseConfigDirectory = dseConfigDirectory;
            this.IsDseAuthenticator = isDseAuthenticator;
            this.IsDseTieredStorage = isDseTieredStorage;
            this.IsJmxAuthEnable = isJmxAuthEnable;
            this.KerberosPrincipal = kerberosPrincipal;
            this.PrimaryHost = primaryHost;
            this.Seeds = seeds;
            this.SolrNodes = solrNodes;
            this.SolrPort = solrPort;
        }
        
        /// <summary>
        /// Gets or Sets CassandraPortsInfo
        /// </summary>
        [DataMember(Name="cassandraPortsInfo", EmitDefaultValue=false)]
        public CassandraPortsInfo CassandraPortsInfo { get; set; }

        /// <summary>
        /// Gets or Sets CassandraSecurityInfo
        /// </summary>
        [DataMember(Name="cassandraSecurityInfo", EmitDefaultValue=false)]
        public CassandraSecurityInfo CassandraSecurityInfo { get; set; }

        /// <summary>
        /// Cassandra version
        /// </summary>
        /// <value>Cassandra version</value>
        [DataMember(Name="cassandraVersion", EmitDefaultValue=true)]
        public string CassandraVersion { get; set; }

        /// <summary>
        /// Specifies the commit log archival location for cassandra node
        /// </summary>
        /// <value>Specifies the commit log archival location for cassandra node</value>
        [DataMember(Name="commitLogBackupLocation", EmitDefaultValue=true)]
        public string CommitLogBackupLocation { get; set; }

        /// <summary>
        /// Specifies the Directory path containing Config YAML for discovery.
        /// </summary>
        /// <value>Specifies the Directory path containing Config YAML for discovery.</value>
        [DataMember(Name="configDirectory", EmitDefaultValue=true)]
        public string ConfigDirectory { get; set; }

        /// <summary>
        /// Specifies the List of all physical data center or virtual data center. In most cases, the data centers will be listed after discovery operation however, if they are not listed, you must manually type the data center names. Leaving the field blank will disallow data center-specific backup or restore. Entering a subset of all data centers may cause problems in data movement.
        /// </summary>
        /// <value>Specifies the List of all physical data center or virtual data center. In most cases, the data centers will be listed after discovery operation however, if they are not listed, you must manually type the data center names. Leaving the field blank will disallow data center-specific backup or restore. Entering a subset of all data centers may cause problems in data movement.</value>
        [DataMember(Name="dataCenters", EmitDefaultValue=true)]
        public List<string> DataCenters { get; set; }

        /// <summary>
        /// Specifies the Directory from where DSE specific configuration can be read.
        /// </summary>
        /// <value>Specifies the Directory from where DSE specific configuration can be read.</value>
        [DataMember(Name="dseConfigDirectory", EmitDefaultValue=true)]
        public string DseConfigDirectory { get; set; }

        /// <summary>
        /// Specifies whether this cluster has DSE Authenticator.
        /// </summary>
        /// <value>Specifies whether this cluster has DSE Authenticator.</value>
        [DataMember(Name="isDseAuthenticator", EmitDefaultValue=true)]
        public bool? IsDseAuthenticator { get; set; }

        /// <summary>
        /// Specifies whether this cluster has DSE tiered storage.
        /// </summary>
        /// <value>Specifies whether this cluster has DSE tiered storage.</value>
        [DataMember(Name="isDseTieredStorage", EmitDefaultValue=true)]
        public bool? IsDseTieredStorage { get; set; }

        /// <summary>
        /// Specifies if JMX Authentication enabled in this cluster.
        /// </summary>
        /// <value>Specifies if JMX Authentication enabled in this cluster.</value>
        [DataMember(Name="isJmxAuthEnable", EmitDefaultValue=true)]
        public bool? IsJmxAuthEnable { get; set; }

        /// <summary>
        /// Specifies the Kerberos Principal for Kerberos connection
        /// </summary>
        /// <value>Specifies the Kerberos Principal for Kerberos connection</value>
        [DataMember(Name="kerberosPrincipal", EmitDefaultValue=true)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Specifies the Primary Host for the Cassandra cluster.
        /// </summary>
        /// <value>Specifies the Primary Host for the Cassandra cluster.</value>
        [DataMember(Name="primaryHost", EmitDefaultValue=true)]
        public string PrimaryHost { get; set; }

        /// <summary>
        /// Specifies the Seed nodes of this Cassandra cluster.
        /// </summary>
        /// <value>Specifies the Seed nodes of this Cassandra cluster.</value>
        [DataMember(Name="seeds", EmitDefaultValue=true)]
        public List<string> Seeds { get; set; }

        /// <summary>
        /// Specifies the Solr node IP Addresses
        /// </summary>
        /// <value>Specifies the Solr node IP Addresses</value>
        [DataMember(Name="solrNodes", EmitDefaultValue=true)]
        public List<string> SolrNodes { get; set; }

        /// <summary>
        /// Specifies the Solr node Port.
        /// </summary>
        /// <value>Specifies the Solr node Port.</value>
        [DataMember(Name="solrPort", EmitDefaultValue=true)]
        public int? SolrPort { get; set; }

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
            return this.Equals(input as CassandraConnectParams);
        }

        /// <summary>
        /// Returns true if CassandraConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraPortsInfo == input.CassandraPortsInfo ||
                    (this.CassandraPortsInfo != null &&
                    this.CassandraPortsInfo.Equals(input.CassandraPortsInfo))
                ) && 
                (
                    this.CassandraSecurityInfo == input.CassandraSecurityInfo ||
                    (this.CassandraSecurityInfo != null &&
                    this.CassandraSecurityInfo.Equals(input.CassandraSecurityInfo))
                ) && 
                (
                    this.CassandraVersion == input.CassandraVersion ||
                    (this.CassandraVersion != null &&
                    this.CassandraVersion.Equals(input.CassandraVersion))
                ) && 
                (
                    this.CommitLogBackupLocation == input.CommitLogBackupLocation ||
                    (this.CommitLogBackupLocation != null &&
                    this.CommitLogBackupLocation.Equals(input.CommitLogBackupLocation))
                ) && 
                (
                    this.ConfigDirectory == input.ConfigDirectory ||
                    (this.ConfigDirectory != null &&
                    this.ConfigDirectory.Equals(input.ConfigDirectory))
                ) && 
                (
                    this.DataCenters == input.DataCenters ||
                    this.DataCenters != null &&
                    input.DataCenters != null &&
                    this.DataCenters.SequenceEqual(input.DataCenters)
                ) && 
                (
                    this.DseConfigDirectory == input.DseConfigDirectory ||
                    (this.DseConfigDirectory != null &&
                    this.DseConfigDirectory.Equals(input.DseConfigDirectory))
                ) && 
                (
                    this.IsDseAuthenticator == input.IsDseAuthenticator ||
                    (this.IsDseAuthenticator != null &&
                    this.IsDseAuthenticator.Equals(input.IsDseAuthenticator))
                ) && 
                (
                    this.IsDseTieredStorage == input.IsDseTieredStorage ||
                    (this.IsDseTieredStorage != null &&
                    this.IsDseTieredStorage.Equals(input.IsDseTieredStorage))
                ) && 
                (
                    this.IsJmxAuthEnable == input.IsJmxAuthEnable ||
                    (this.IsJmxAuthEnable != null &&
                    this.IsJmxAuthEnable.Equals(input.IsJmxAuthEnable))
                ) && 
                (
                    this.KerberosPrincipal == input.KerberosPrincipal ||
                    (this.KerberosPrincipal != null &&
                    this.KerberosPrincipal.Equals(input.KerberosPrincipal))
                ) && 
                (
                    this.PrimaryHost == input.PrimaryHost ||
                    (this.PrimaryHost != null &&
                    this.PrimaryHost.Equals(input.PrimaryHost))
                ) && 
                (
                    this.Seeds == input.Seeds ||
                    this.Seeds != null &&
                    input.Seeds != null &&
                    this.Seeds.SequenceEqual(input.Seeds)
                ) && 
                (
                    this.SolrNodes == input.SolrNodes ||
                    this.SolrNodes != null &&
                    input.SolrNodes != null &&
                    this.SolrNodes.SequenceEqual(input.SolrNodes)
                ) && 
                (
                    this.SolrPort == input.SolrPort ||
                    (this.SolrPort != null &&
                    this.SolrPort.Equals(input.SolrPort))
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
                if (this.CassandraPortsInfo != null)
                    hashCode = hashCode * 59 + this.CassandraPortsInfo.GetHashCode();
                if (this.CassandraSecurityInfo != null)
                    hashCode = hashCode * 59 + this.CassandraSecurityInfo.GetHashCode();
                if (this.CassandraVersion != null)
                    hashCode = hashCode * 59 + this.CassandraVersion.GetHashCode();
                if (this.CommitLogBackupLocation != null)
                    hashCode = hashCode * 59 + this.CommitLogBackupLocation.GetHashCode();
                if (this.ConfigDirectory != null)
                    hashCode = hashCode * 59 + this.ConfigDirectory.GetHashCode();
                if (this.DataCenters != null)
                    hashCode = hashCode * 59 + this.DataCenters.GetHashCode();
                if (this.DseConfigDirectory != null)
                    hashCode = hashCode * 59 + this.DseConfigDirectory.GetHashCode();
                if (this.IsDseAuthenticator != null)
                    hashCode = hashCode * 59 + this.IsDseAuthenticator.GetHashCode();
                if (this.IsDseTieredStorage != null)
                    hashCode = hashCode * 59 + this.IsDseTieredStorage.GetHashCode();
                if (this.IsJmxAuthEnable != null)
                    hashCode = hashCode * 59 + this.IsJmxAuthEnable.GetHashCode();
                if (this.KerberosPrincipal != null)
                    hashCode = hashCode * 59 + this.KerberosPrincipal.GetHashCode();
                if (this.PrimaryHost != null)
                    hashCode = hashCode * 59 + this.PrimaryHost.GetHashCode();
                if (this.Seeds != null)
                    hashCode = hashCode * 59 + this.Seeds.GetHashCode();
                if (this.SolrNodes != null)
                    hashCode = hashCode * 59 + this.SolrNodes.GetHashCode();
                if (this.SolrPort != null)
                    hashCode = hashCode * 59 + this.SolrPort.GetHashCode();
                return hashCode;
            }
        }

    }

}

