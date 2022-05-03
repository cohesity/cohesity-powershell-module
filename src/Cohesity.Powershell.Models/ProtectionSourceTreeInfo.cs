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
    /// Specifies the registration and protection information of a registered Protection Source Tree on the Cohesity Cluster.  Many different Protection Source trees are supported such as &#39;kVMware&#39;, &#39;kAcropolis&#39;, &#39;kPhysical&#39; etc.,
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceTreeInfo :  IEquatable<ProtectionSourceTreeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceTreeInfo" /> class.
        /// </summary>
        /// <param name="applications">Array of applications hierarchy registered on this node.  Specifies the application type and the list of instances of the application objects. For example for SQL Server, this list provides the SQL Server instances running on a VM or a Physical Server..</param>
        /// <param name="entityPermissionInfo">entityPermissionInfo.</param>
        /// <param name="logicalSizeBytes">Specifies the logical size of the Protection Source in bytes..</param>
        /// <param name="registrationInfo">Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server..</param>
        /// <param name="rootNode">Specifies the Protection Source for the root node of the Protection Source tree..</param>
        /// <param name="stats">Specifies the stats of protection for a Protection Source Tree..</param>
        /// <param name="statsByEnv">Specifies the breakdown of the stats of protection by environment. overrideDescription: true.</param>
        /// <param name="totalDowntieredSizeInBytes">Specifies the total bytes downtiered from the source so far..</param>
        /// <param name="totalUptieredSizeInBytes">Specifies the total bytes uptiered to the source so far..</param>
        public ProtectionSourceTreeInfo(List<ApplicationInfo> applications = default(List<ApplicationInfo>), EntityPermissionInformation entityPermissionInfo = default(EntityPermissionInformation), long? logicalSizeBytes = default(long?), RegisteredSourceInfo registrationInfo = default(RegisteredSourceInfo), ProtectionSource rootNode = default(ProtectionSource), ProtectionSummary stats = default(ProtectionSummary), List<ProtectionSummaryByEnv> statsByEnv = default(List<ProtectionSummaryByEnv>), long? totalDowntieredSizeInBytes = default(long?), long? totalUptieredSizeInBytes = default(long?))
        {
            this.Applications = applications;
            this.EntityPermissionInfo = entityPermissionInfo;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.RegistrationInfo = registrationInfo;
            this.RootNode = rootNode;
            this.Stats = stats;
            this.StatsByEnv = statsByEnv;
            this.TotalDowntieredSizeInBytes = totalDowntieredSizeInBytes;
            this.TotalUptieredSizeInBytes = totalUptieredSizeInBytes;
        }
        
        /// <summary>
        /// Array of applications hierarchy registered on this node.  Specifies the application type and the list of instances of the application objects. For example for SQL Server, this list provides the SQL Server instances running on a VM or a Physical Server.
        /// </summary>
        /// <value>Array of applications hierarchy registered on this node.  Specifies the application type and the list of instances of the application objects. For example for SQL Server, this list provides the SQL Server instances running on a VM or a Physical Server.</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<ApplicationInfo> Applications { get; set; }

        /// <summary>
        /// Gets or Sets EntityPermissionInfo
        /// </summary>
        [DataMember(Name="entityPermissionInfo", EmitDefaultValue=false)]
        public EntityPermissionInformation EntityPermissionInfo { get; set; }

        /// <summary>
        /// Specifies the logical size of the Protection Source in bytes.
        /// </summary>
        /// <value>Specifies the logical size of the Protection Source in bytes.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=false)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server.
        /// </summary>
        /// <value>Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server.</value>
        [DataMember(Name="registrationInfo", EmitDefaultValue=false)]
        public RegisteredSourceInfo RegistrationInfo { get; set; }

        /// <summary>
        /// Specifies the Protection Source for the root node of the Protection Source tree.
        /// </summary>
        /// <value>Specifies the Protection Source for the root node of the Protection Source tree.</value>
        [DataMember(Name="rootNode", EmitDefaultValue=false)]
        public ProtectionSource RootNode { get; set; }

        /// <summary>
        /// Specifies the stats of protection for a Protection Source Tree.
        /// </summary>
        /// <value>Specifies the stats of protection for a Protection Source Tree.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummary Stats { get; set; }

        /// <summary>
        /// Specifies the breakdown of the stats of protection by environment. overrideDescription: true
        /// </summary>
        /// <value>Specifies the breakdown of the stats of protection by environment. overrideDescription: true</value>
        [DataMember(Name="statsByEnv", EmitDefaultValue=false)]
        public List<ProtectionSummaryByEnv> StatsByEnv { get; set; }

        /// <summary>
        /// Specifies the total bytes downtiered from the source so far.
        /// </summary>
        /// <value>Specifies the total bytes downtiered from the source so far.</value>
        [DataMember(Name="totalDowntieredSizeInBytes", EmitDefaultValue=false)]
        public long? TotalDowntieredSizeInBytes { get; set; }

        /// <summary>
        /// Specifies the total bytes uptiered to the source so far.
        /// </summary>
        /// <value>Specifies the total bytes uptiered to the source so far.</value>
        [DataMember(Name="totalUptieredSizeInBytes", EmitDefaultValue=false)]
        public long? TotalUptieredSizeInBytes { get; set; }

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
            return this.Equals(input as ProtectionSourceTreeInfo);
        }

        /// <summary>
        /// Returns true if ProtectionSourceTreeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceTreeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceTreeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    this.Applications.Equals(input.Applications)
                ) && 
                (
                    this.EntityPermissionInfo == input.EntityPermissionInfo ||
                    (this.EntityPermissionInfo != null &&
                    this.EntityPermissionInfo.Equals(input.EntityPermissionInfo))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.RegistrationInfo == input.RegistrationInfo ||
                    this.RegistrationInfo != null &&
                    this.RegistrationInfo.Equals(input.RegistrationInfo)
                ) && 
                (
                    this.RootNode == input.RootNode ||
                    this.RootNode != null &&
                    this.RootNode.Equals(input.RootNode)
                ) && 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(input.Stats)
                ) && 
                (
                    this.StatsByEnv == input.StatsByEnv ||
                    this.StatsByEnv != null &&
                    this.StatsByEnv.Equals(input.StatsByEnv)
                ) && 
                (
                    this.TotalDowntieredSizeInBytes == input.TotalDowntieredSizeInBytes ||
                    (this.TotalDowntieredSizeInBytes != null &&
                    this.TotalDowntieredSizeInBytes.Equals(input.TotalDowntieredSizeInBytes))
                ) && 
                (
                    this.TotalUptieredSizeInBytes == input.TotalUptieredSizeInBytes ||
                    (this.TotalUptieredSizeInBytes != null &&
                    this.TotalUptieredSizeInBytes.Equals(input.TotalUptieredSizeInBytes))
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.EntityPermissionInfo != null)
                    hashCode = hashCode * 59 + this.EntityPermissionInfo.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.RegistrationInfo != null)
                    hashCode = hashCode * 59 + this.RegistrationInfo.GetHashCode();
                if (this.RootNode != null)
                    hashCode = hashCode * 59 + this.RootNode.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StatsByEnv != null)
                    hashCode = hashCode * 59 + this.StatsByEnv.GetHashCode();
                if (this.TotalDowntieredSizeInBytes != null)
                    hashCode = hashCode * 59 + this.TotalDowntieredSizeInBytes.GetHashCode();
                if (this.TotalUptieredSizeInBytes != null)
                    hashCode = hashCode * 59 + this.TotalUptieredSizeInBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

