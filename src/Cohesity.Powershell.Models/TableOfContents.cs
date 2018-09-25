// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Returned by ImportList.
    /// </summary>
    [DataContract]
    public partial class TableOfContents :  IEquatable<TableOfContents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableOfContents" /> class.
        /// </summary>
        /// <param name="activeDirectory">activeDirectory.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="group">group.</param>
        /// <param name="partition">partition.</param>
        /// <param name="principalSource">principalSource.</param>
        /// <param name="protectionJob">protectionJob.</param>
        /// <param name="protectionPolicy">protectionPolicy.</param>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="remoteCluster">remoteCluster.</param>
        /// <param name="role">role.</param>
        /// <param name="sql">sql.</param>
        /// <param name="user">user.</param>
        /// <param name="vault">vault.</param>
        /// <param name="view">view.</param>
        /// <param name="viewBox">viewBox.</param>
        public TableOfContents(List<string> activeDirectory = default(List<string>), List<long?> cluster = default(List<long?>), List<string> group = default(List<string>), List<long?> partition = default(List<long?>), List<string> principalSource = default(List<string>), List<long?> protectionJob = default(List<long?>), List<string> protectionPolicy = default(List<string>), List<long?> protectionSource = default(List<long?>), List<long?> remoteCluster = default(List<long?>), List<string> role = default(List<string>), List<long?> sql = default(List<long?>), List<string> user = default(List<string>), List<long?> vault = default(List<long?>), List<long?> view = default(List<long?>), List<long?> viewBox = default(List<long?>))
        {
            this.ActiveDirectory = activeDirectory;
            this.Cluster = cluster;
            this.Group = group;
            this.Partition = partition;
            this.PrincipalSource = principalSource;
            this.ProtectionJob = protectionJob;
            this.ProtectionPolicy = protectionPolicy;
            this.ProtectionSource = protectionSource;
            this.RemoteCluster = remoteCluster;
            this.Role = role;
            this.Sql = sql;
            this.User = user;
            this.Vault = vault;
            this.View = view;
            this.ViewBox = viewBox;
        }
        
        /// <summary>
        /// Gets or Sets ActiveDirectory
        /// </summary>
        [DataMember(Name="activeDirectory", EmitDefaultValue=false)]
        public List<string> ActiveDirectory { get; set; }

        /// <summary>
        /// Gets or Sets Cluster
        /// </summary>
        [DataMember(Name="cluster", EmitDefaultValue=false)]
        public List<long?> Cluster { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<string> Group { get; set; }

        /// <summary>
        /// Gets or Sets Partition
        /// </summary>
        [DataMember(Name="partition", EmitDefaultValue=false)]
        public List<long?> Partition { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalSource
        /// </summary>
        [DataMember(Name="principalSource", EmitDefaultValue=false)]
        public List<string> PrincipalSource { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionJob
        /// </summary>
        [DataMember(Name="protectionJob", EmitDefaultValue=false)]
        public List<long?> ProtectionJob { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionPolicy
        /// </summary>
        [DataMember(Name="protectionPolicy", EmitDefaultValue=false)]
        public List<string> ProtectionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public List<long?> ProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets RemoteCluster
        /// </summary>
        [DataMember(Name="remoteCluster", EmitDefaultValue=false)]
        public List<long?> RemoteCluster { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public List<string> Role { get; set; }

        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public List<long?> Sql { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public List<string> User { get; set; }

        /// <summary>
        /// Gets or Sets Vault
        /// </summary>
        [DataMember(Name="vault", EmitDefaultValue=false)]
        public List<long?> Vault { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public List<long?> View { get; set; }

        /// <summary>
        /// Gets or Sets ViewBox
        /// </summary>
        [DataMember(Name="viewBox", EmitDefaultValue=false)]
        public List<long?> ViewBox { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as TableOfContents);
        }

        /// <summary>
        /// Returns true if TableOfContents instances are equal
        /// </summary>
        /// <param name="input">Instance of TableOfContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableOfContents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveDirectory == input.ActiveDirectory ||
                    this.ActiveDirectory != null &&
                    this.ActiveDirectory.SequenceEqual(input.ActiveDirectory)
                ) && 
                (
                    this.Cluster == input.Cluster ||
                    this.Cluster != null &&
                    this.Cluster.SequenceEqual(input.Cluster)
                ) && 
                (
                    this.Group == input.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(input.Group)
                ) && 
                (
                    this.Partition == input.Partition ||
                    this.Partition != null &&
                    this.Partition.SequenceEqual(input.Partition)
                ) && 
                (
                    this.PrincipalSource == input.PrincipalSource ||
                    this.PrincipalSource != null &&
                    this.PrincipalSource.SequenceEqual(input.PrincipalSource)
                ) && 
                (
                    this.ProtectionJob == input.ProtectionJob ||
                    this.ProtectionJob != null &&
                    this.ProtectionJob.SequenceEqual(input.ProtectionJob)
                ) && 
                (
                    this.ProtectionPolicy == input.ProtectionPolicy ||
                    this.ProtectionPolicy != null &&
                    this.ProtectionPolicy.SequenceEqual(input.ProtectionPolicy)
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    this.ProtectionSource != null &&
                    this.ProtectionSource.SequenceEqual(input.ProtectionSource)
                ) && 
                (
                    this.RemoteCluster == input.RemoteCluster ||
                    this.RemoteCluster != null &&
                    this.RemoteCluster.SequenceEqual(input.RemoteCluster)
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role != null &&
                    this.Role.SequenceEqual(input.Role)
                ) && 
                (
                    this.Sql == input.Sql ||
                    this.Sql != null &&
                    this.Sql.SequenceEqual(input.Sql)
                ) && 
                (
                    this.User == input.User ||
                    this.User != null &&
                    this.User.SequenceEqual(input.User)
                ) && 
                (
                    this.Vault == input.Vault ||
                    this.Vault != null &&
                    this.Vault.SequenceEqual(input.Vault)
                ) && 
                (
                    this.View == input.View ||
                    this.View != null &&
                    this.View.SequenceEqual(input.View)
                ) && 
                (
                    this.ViewBox == input.ViewBox ||
                    this.ViewBox != null &&
                    this.ViewBox.SequenceEqual(input.ViewBox)
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
                if (this.ActiveDirectory != null)
                    hashCode = hashCode * 59 + this.ActiveDirectory.GetHashCode();
                if (this.Cluster != null)
                    hashCode = hashCode * 59 + this.Cluster.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.PrincipalSource != null)
                    hashCode = hashCode * 59 + this.PrincipalSource.GetHashCode();
                if (this.ProtectionJob != null)
                    hashCode = hashCode * 59 + this.ProtectionJob.GetHashCode();
                if (this.ProtectionPolicy != null)
                    hashCode = hashCode * 59 + this.ProtectionPolicy.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.RemoteCluster != null)
                    hashCode = hashCode * 59 + this.RemoteCluster.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Sql != null)
                    hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Vault != null)
                    hashCode = hashCode * 59 + this.Vault.GetHashCode();
                if (this.View != null)
                    hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.ViewBox != null)
                    hashCode = hashCode * 59 + this.ViewBox.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

