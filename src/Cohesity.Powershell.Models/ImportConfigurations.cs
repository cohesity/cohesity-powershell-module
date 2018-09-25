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
    /// This is the form of the request.
    /// </summary>
    [DataContract]
    public partial class ImportConfigurations :  IEquatable<ImportConfigurations>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConfigurations" /> class.
        /// </summary>
        /// <param name="activeDirectories">activeDirectories.</param>
        /// <param name="all">all.</param>
        /// <param name="clusters">clusters.</param>
        /// <param name="file">File is the config file..</param>
        /// <param name="groups">groups.</param>
        /// <param name="partitions">partitions.</param>
        /// <param name="principalSources">principalSources.</param>
        /// <param name="protectionJobs">protectionJobs.</param>
        /// <param name="protectionPolicies">protectionPolicies.</param>
        /// <param name="protectionSources">protectionSources.</param>
        /// <param name="remoteClusters">remoteClusters.</param>
        /// <param name="roles">roles.</param>
        /// <param name="sql">sql.</param>
        /// <param name="users">users.</param>
        /// <param name="vaults">vaults.</param>
        /// <param name="viewBoxes">viewBoxes.</param>
        /// <param name="views">views.</param>
        public ImportConfigurations(List<string> activeDirectories = default(List<string>), List<string> all = default(List<string>), List<long?> clusters = default(List<long?>), string file = default(string), List<string> groups = default(List<string>), List<long?> partitions = default(List<long?>), List<string> principalSources = default(List<string>), List<long?> protectionJobs = default(List<long?>), List<string> protectionPolicies = default(List<string>), List<long?> protectionSources = default(List<long?>), List<long?> remoteClusters = default(List<long?>), List<string> roles = default(List<string>), List<long?> sql = default(List<long?>), List<string> users = default(List<string>), List<long?> vaults = default(List<long?>), List<long?> viewBoxes = default(List<long?>), List<long?> views = default(List<long?>))
        {
            this.ActiveDirectories = activeDirectories;
            this.All = all;
            this.Clusters = clusters;
            this.File = file;
            this.Groups = groups;
            this.Partitions = partitions;
            this.PrincipalSources = principalSources;
            this.ProtectionJobs = protectionJobs;
            this.ProtectionPolicies = protectionPolicies;
            this.ProtectionSources = protectionSources;
            this.RemoteClusters = remoteClusters;
            this.Roles = roles;
            this.Sql = sql;
            this.Users = users;
            this.Vaults = vaults;
            this.ViewBoxes = viewBoxes;
            this.Views = views;
        }
        
        /// <summary>
        /// Gets or Sets ActiveDirectories
        /// </summary>
        [DataMember(Name="activeDirectories", EmitDefaultValue=false)]
        public List<string> ActiveDirectories { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public List<string> All { get; set; }

        /// <summary>
        /// Gets or Sets Clusters
        /// </summary>
        [DataMember(Name="clusters", EmitDefaultValue=false)]
        public List<long?> Clusters { get; set; }

        /// <summary>
        /// File is the config file.
        /// </summary>
        /// <value>File is the config file.</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Partitions
        /// </summary>
        [DataMember(Name="partitions", EmitDefaultValue=false)]
        public List<long?> Partitions { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalSources
        /// </summary>
        [DataMember(Name="principalSources", EmitDefaultValue=false)]
        public List<string> PrincipalSources { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionJobs
        /// </summary>
        [DataMember(Name="protectionJobs", EmitDefaultValue=false)]
        public List<long?> ProtectionJobs { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionPolicies
        /// </summary>
        [DataMember(Name="protectionPolicies", EmitDefaultValue=false)]
        public List<string> ProtectionPolicies { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSources
        /// </summary>
        [DataMember(Name="protectionSources", EmitDefaultValue=false)]
        public List<long?> ProtectionSources { get; set; }

        /// <summary>
        /// Gets or Sets RemoteClusters
        /// </summary>
        [DataMember(Name="remoteClusters", EmitDefaultValue=false)]
        public List<long?> RemoteClusters { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public List<long?> Sql { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// Gets or Sets Vaults
        /// </summary>
        [DataMember(Name="vaults", EmitDefaultValue=false)]
        public List<long?> Vaults { get; set; }

        /// <summary>
        /// Gets or Sets ViewBoxes
        /// </summary>
        [DataMember(Name="viewBoxes", EmitDefaultValue=false)]
        public List<long?> ViewBoxes { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<long?> Views { get; set; }

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
            return this.Equals(input as ImportConfigurations);
        }

        /// <summary>
        /// Returns true if ImportConfigurations instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportConfigurations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveDirectories == input.ActiveDirectories ||
                    this.ActiveDirectories != null &&
                    this.ActiveDirectories.SequenceEqual(input.ActiveDirectories)
                ) && 
                (
                    this.All == input.All ||
                    this.All != null &&
                    this.All.SequenceEqual(input.All)
                ) && 
                (
                    this.Clusters == input.Clusters ||
                    this.Clusters != null &&
                    this.Clusters.SequenceEqual(input.Clusters)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Partitions == input.Partitions ||
                    this.Partitions != null &&
                    this.Partitions.SequenceEqual(input.Partitions)
                ) && 
                (
                    this.PrincipalSources == input.PrincipalSources ||
                    this.PrincipalSources != null &&
                    this.PrincipalSources.SequenceEqual(input.PrincipalSources)
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
                ) && 
                (
                    this.ProtectionPolicies == input.ProtectionPolicies ||
                    this.ProtectionPolicies != null &&
                    this.ProtectionPolicies.SequenceEqual(input.ProtectionPolicies)
                ) && 
                (
                    this.ProtectionSources == input.ProtectionSources ||
                    this.ProtectionSources != null &&
                    this.ProtectionSources.SequenceEqual(input.ProtectionSources)
                ) && 
                (
                    this.RemoteClusters == input.RemoteClusters ||
                    this.RemoteClusters != null &&
                    this.RemoteClusters.SequenceEqual(input.RemoteClusters)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Sql == input.Sql ||
                    this.Sql != null &&
                    this.Sql.SequenceEqual(input.Sql)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Vaults == input.Vaults ||
                    this.Vaults != null &&
                    this.Vaults.SequenceEqual(input.Vaults)
                ) && 
                (
                    this.ViewBoxes == input.ViewBoxes ||
                    this.ViewBoxes != null &&
                    this.ViewBoxes.SequenceEqual(input.ViewBoxes)
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.ActiveDirectories != null)
                    hashCode = hashCode * 59 + this.ActiveDirectories.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.Clusters != null)
                    hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Partitions != null)
                    hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                if (this.PrincipalSources != null)
                    hashCode = hashCode * 59 + this.PrincipalSources.GetHashCode();
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
                if (this.ProtectionPolicies != null)
                    hashCode = hashCode * 59 + this.ProtectionPolicies.GetHashCode();
                if (this.ProtectionSources != null)
                    hashCode = hashCode * 59 + this.ProtectionSources.GetHashCode();
                if (this.RemoteClusters != null)
                    hashCode = hashCode * 59 + this.RemoteClusters.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Sql != null)
                    hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Vaults != null)
                    hashCode = hashCode * 59 + this.Vaults.GetHashCode();
                if (this.ViewBoxes != null)
                    hashCode = hashCode * 59 + this.ViewBoxes.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

