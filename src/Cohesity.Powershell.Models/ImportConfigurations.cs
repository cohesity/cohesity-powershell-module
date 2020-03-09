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
    /// ImportConfigurations struct used for ImportConfig endpoint. This is the form of the request.
    /// </summary>
    [DataContract]
    public partial class ImportConfigurations :  IEquatable<ImportConfigurations>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConfigurations" /> class.
        /// </summary>
        /// <param name="activeDirectories">Selective import of active directories..</param>
        /// <param name="all">List of which entities to import all..</param>
        /// <param name="clusters">Selective import certain cluster..</param>
        /// <param name="file">File is the config file..</param>
        /// <param name="groups">Selective import certain groups..</param>
        /// <param name="partitions">Selective import of Partition..</param>
        /// <param name="principalSources">Selective import of principal sources..</param>
        /// <param name="protectionJobs">Selective import of protection jobs..</param>
        /// <param name="protectionPolicies">Selective import of protection policies..</param>
        /// <param name="protectionSources">Selective import of protection sources..</param>
        /// <param name="remoteClusters">Selective import certain remote clusters..</param>
        /// <param name="roles">Selective import certain roles (by username)..</param>
        /// <param name="sql">Selective import of sql..</param>
        /// <param name="users">Selective import certain users..</param>
        /// <param name="vaults">Selective import certain vaults..</param>
        /// <param name="viewBoxes">Selective import certain Storage Domains (View Boxes)..</param>
        /// <param name="views">Selective import of views..</param>
        public ImportConfigurations(List<string> activeDirectories = default(List<string>), List<string> all = default(List<string>), List<long> clusters = default(List<long>), string file = default(string), List<string> groups = default(List<string>), List<long> partitions = default(List<long>), List<string> principalSources = default(List<string>), List<long> protectionJobs = default(List<long>), List<string> protectionPolicies = default(List<string>), List<long> protectionSources = default(List<long>), List<long> remoteClusters = default(List<long>), List<string> roles = default(List<string>), List<long> sql = default(List<long>), List<string> users = default(List<string>), List<long> vaults = default(List<long>), List<long> viewBoxes = default(List<long>), List<long> views = default(List<long>))
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
        /// Selective import of active directories.
        /// </summary>
        /// <value>Selective import of active directories.</value>
        [DataMember(Name="activeDirectories", EmitDefaultValue=true)]
        public List<string> ActiveDirectories { get; set; }

        /// <summary>
        /// List of which entities to import all.
        /// </summary>
        /// <value>List of which entities to import all.</value>
        [DataMember(Name="all", EmitDefaultValue=true)]
        public List<string> All { get; set; }

        /// <summary>
        /// Selective import certain cluster.
        /// </summary>
        /// <value>Selective import certain cluster.</value>
        [DataMember(Name="clusters", EmitDefaultValue=true)]
        public List<long> Clusters { get; set; }

        /// <summary>
        /// File is the config file.
        /// </summary>
        /// <value>File is the config file.</value>
        [DataMember(Name="file", EmitDefaultValue=true)]
        public string File { get; set; }

        /// <summary>
        /// Selective import certain groups.
        /// </summary>
        /// <value>Selective import certain groups.</value>
        [DataMember(Name="groups", EmitDefaultValue=true)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Selective import of Partition.
        /// </summary>
        /// <value>Selective import of Partition.</value>
        [DataMember(Name="partitions", EmitDefaultValue=true)]
        public List<long> Partitions { get; set; }

        /// <summary>
        /// Selective import of principal sources.
        /// </summary>
        /// <value>Selective import of principal sources.</value>
        [DataMember(Name="principalSources", EmitDefaultValue=true)]
        public List<string> PrincipalSources { get; set; }

        /// <summary>
        /// Selective import of protection jobs.
        /// </summary>
        /// <value>Selective import of protection jobs.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=true)]
        public List<long> ProtectionJobs { get; set; }

        /// <summary>
        /// Selective import of protection policies.
        /// </summary>
        /// <value>Selective import of protection policies.</value>
        [DataMember(Name="protectionPolicies", EmitDefaultValue=true)]
        public List<string> ProtectionPolicies { get; set; }

        /// <summary>
        /// Selective import of protection sources.
        /// </summary>
        /// <value>Selective import of protection sources.</value>
        [DataMember(Name="protectionSources", EmitDefaultValue=true)]
        public List<long> ProtectionSources { get; set; }

        /// <summary>
        /// Selective import certain remote clusters.
        /// </summary>
        /// <value>Selective import certain remote clusters.</value>
        [DataMember(Name="remoteClusters", EmitDefaultValue=true)]
        public List<long> RemoteClusters { get; set; }

        /// <summary>
        /// Selective import certain roles (by username).
        /// </summary>
        /// <value>Selective import certain roles (by username).</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Selective import of sql.
        /// </summary>
        /// <value>Selective import of sql.</value>
        [DataMember(Name="sql", EmitDefaultValue=true)]
        public List<long> Sql { get; set; }

        /// <summary>
        /// Selective import certain users.
        /// </summary>
        /// <value>Selective import certain users.</value>
        [DataMember(Name="users", EmitDefaultValue=true)]
        public List<string> Users { get; set; }

        /// <summary>
        /// Selective import certain vaults.
        /// </summary>
        /// <value>Selective import certain vaults.</value>
        [DataMember(Name="vaults", EmitDefaultValue=true)]
        public List<long> Vaults { get; set; }

        /// <summary>
        /// Selective import certain Storage Domains (View Boxes).
        /// </summary>
        /// <value>Selective import certain Storage Domains (View Boxes).</value>
        [DataMember(Name="viewBoxes", EmitDefaultValue=true)]
        public List<long> ViewBoxes { get; set; }

        /// <summary>
        /// Selective import of views.
        /// </summary>
        /// <value>Selective import of views.</value>
        [DataMember(Name="views", EmitDefaultValue=true)]
        public List<long> Views { get; set; }

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
                    input.ActiveDirectories != null &&
                    this.ActiveDirectories.SequenceEqual(input.ActiveDirectories)
                ) && 
                (
                    this.All == input.All ||
                    this.All != null &&
                    input.All != null &&
                    this.All.SequenceEqual(input.All)
                ) && 
                (
                    this.Clusters == input.Clusters ||
                    this.Clusters != null &&
                    input.Clusters != null &&
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
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Partitions == input.Partitions ||
                    this.Partitions != null &&
                    input.Partitions != null &&
                    this.Partitions.SequenceEqual(input.Partitions)
                ) && 
                (
                    this.PrincipalSources == input.PrincipalSources ||
                    this.PrincipalSources != null &&
                    input.PrincipalSources != null &&
                    this.PrincipalSources.SequenceEqual(input.PrincipalSources)
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    input.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
                ) && 
                (
                    this.ProtectionPolicies == input.ProtectionPolicies ||
                    this.ProtectionPolicies != null &&
                    input.ProtectionPolicies != null &&
                    this.ProtectionPolicies.SequenceEqual(input.ProtectionPolicies)
                ) && 
                (
                    this.ProtectionSources == input.ProtectionSources ||
                    this.ProtectionSources != null &&
                    input.ProtectionSources != null &&
                    this.ProtectionSources.SequenceEqual(input.ProtectionSources)
                ) && 
                (
                    this.RemoteClusters == input.RemoteClusters ||
                    this.RemoteClusters != null &&
                    input.RemoteClusters != null &&
                    this.RemoteClusters.SequenceEqual(input.RemoteClusters)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Sql == input.Sql ||
                    this.Sql != null &&
                    input.Sql != null &&
                    this.Sql.SequenceEqual(input.Sql)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Vaults == input.Vaults ||
                    this.Vaults != null &&
                    input.Vaults != null &&
                    this.Vaults.SequenceEqual(input.Vaults)
                ) && 
                (
                    this.ViewBoxes == input.ViewBoxes ||
                    this.ViewBoxes != null &&
                    input.ViewBoxes != null &&
                    this.ViewBoxes.SequenceEqual(input.ViewBoxes)
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    input.Views != null &&
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

