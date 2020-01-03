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
    /// Many different node types are supported such as &#39;kComputeResource&#39; and &#39;kResourcePool&#39;.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceNode :  IEquatable<ProtectionSourceNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceNode" /> class.
        /// </summary>
        /// <param name="applicationNodes">Array of Child Subtrees.  Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM..</param>
        /// <param name="entityPaginationParameters">entityPaginationParameters.</param>
        /// <param name="entityPermissionInfo">entityPermissionInfo.</param>
        /// <param name="logicalSize">Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node..</param>
        /// <param name="nodes">Array of Child Nodes.  Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy..</param>
        /// <param name="protectedSourcesSummary">Array of Protected Objects.  Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector..</param>
        /// <param name="protectionSource">Specifies the Protection Source for the current node..</param>
        /// <param name="registrationInfo">Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server..</param>
        /// <param name="unprotectedSourcesSummary">Array of Unprotected Sources.  Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from..</param>
        public ProtectionSourceNode(List<ProtectionSourceNode> applicationNodes = default(List<ProtectionSourceNode>), PaginationParameters entityPaginationParameters = default(PaginationParameters), EntityPermissionInformation entityPermissionInfo = default(EntityPermissionInformation), long? logicalSize = default(long?), List<ProtectionSourceNode> nodes = default(List<ProtectionSourceNode>), List<AggregatedSubtreeInfo> protectedSourcesSummary = default(List<AggregatedSubtreeInfo>), ProtectionSource protectionSource = default(ProtectionSource), RegisteredSourceInfo registrationInfo = default(RegisteredSourceInfo), List<AggregatedSubtreeInfo> unprotectedSourcesSummary = default(List<AggregatedSubtreeInfo>))
        {
            this.ApplicationNodes = applicationNodes;
            this.LogicalSize = logicalSize;
            this.Nodes = nodes;
            this.ProtectedSourcesSummary = protectedSourcesSummary;
            this.ProtectionSource = protectionSource;
            this.RegistrationInfo = registrationInfo;
            this.UnprotectedSourcesSummary = unprotectedSourcesSummary;
            this.ApplicationNodes = applicationNodes;
            this.EntityPaginationParameters = entityPaginationParameters;
            this.EntityPermissionInfo = entityPermissionInfo;
            this.LogicalSize = logicalSize;
            this.Nodes = nodes;
            this.ProtectedSourcesSummary = protectedSourcesSummary;
            this.ProtectionSource = protectionSource;
            this.RegistrationInfo = registrationInfo;
            this.UnprotectedSourcesSummary = unprotectedSourcesSummary;
        }
        
        /// <summary>
        /// Array of Child Subtrees.  Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.
        /// </summary>
        /// <value>Array of Child Subtrees.  Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.</value>
        [DataMember(Name="applicationNodes", EmitDefaultValue=true)]
        public List<ProtectionSourceNode> ApplicationNodes { get; set; }

        /// <summary>
        /// Gets or Sets EntityPaginationParameters
        /// </summary>
        [DataMember(Name="entityPaginationParameters", EmitDefaultValue=false)]
        public PaginationParameters EntityPaginationParameters { get; set; }

        /// <summary>
        /// Gets or Sets EntityPermissionInfo
        /// </summary>
        [DataMember(Name="entityPermissionInfo", EmitDefaultValue=false)]
        public EntityPermissionInformation EntityPermissionInfo { get; set; }

        /// <summary>
        /// Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node.
        /// </summary>
        /// <value>Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node.</value>
        [DataMember(Name="logicalSize", EmitDefaultValue=true)]
        public long? LogicalSize { get; set; }

        /// <summary>
        /// Array of Child Nodes.  Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy.
        /// </summary>
        /// <value>Array of Child Nodes.  Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy.</value>
        [DataMember(Name="nodes", EmitDefaultValue=true)]
        public List<ProtectionSourceNode> Nodes { get; set; }

        /// <summary>
        /// Array of Protected Objects.  Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector.
        /// </summary>
        /// <value>Array of Protected Objects.  Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector.</value>
        [DataMember(Name="protectedSourcesSummary", EmitDefaultValue=true)]
        public List<AggregatedSubtreeInfo> ProtectedSourcesSummary { get; set; }

        /// <summary>
        /// Specifies the Protection Source for the current node.
        /// </summary>
        /// <value>Specifies the Protection Source for the current node.</value>
        [DataMember(Name="protectionSource", EmitDefaultValue=true)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server.
        /// </summary>
        /// <value>Specifies registration information for a root node in a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server.</value>
        [DataMember(Name="registrationInfo", EmitDefaultValue=true)]
        public RegisteredSourceInfo RegistrationInfo { get; set; }

        /// <summary>
        /// Array of Unprotected Sources.  Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from.
        /// </summary>
        /// <value>Array of Unprotected Sources.  Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from.</value>
        [DataMember(Name="unprotectedSourcesSummary", EmitDefaultValue=true)]
        public List<AggregatedSubtreeInfo> UnprotectedSourcesSummary { get; set; }

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
            return this.Equals(input as ProtectionSourceNode);
        }

        /// <summary>
        /// Returns true if ProtectionSourceNode instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationNodes == input.ApplicationNodes ||
                    this.ApplicationNodes != null &&
                    input.ApplicationNodes != null &&
                    this.ApplicationNodes.SequenceEqual(input.ApplicationNodes)
                ) && 
                (
                    this.EntityPaginationParameters == input.EntityPaginationParameters ||
                    (this.EntityPaginationParameters != null &&
                    this.EntityPaginationParameters.Equals(input.EntityPaginationParameters))
                ) && 
                (
                    this.EntityPermissionInfo == input.EntityPermissionInfo ||
                    (this.EntityPermissionInfo != null &&
                    this.EntityPermissionInfo.Equals(input.EntityPermissionInfo))
                ) && 
                (
                    this.LogicalSize == input.LogicalSize ||
                    (this.LogicalSize != null &&
                    this.LogicalSize.Equals(input.LogicalSize))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.ProtectedSourcesSummary == input.ProtectedSourcesSummary ||
                    this.ProtectedSourcesSummary != null &&
                    input.ProtectedSourcesSummary != null &&
                    this.ProtectedSourcesSummary.SequenceEqual(input.ProtectedSourcesSummary)
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.RegistrationInfo == input.RegistrationInfo ||
                    (this.RegistrationInfo != null &&
                    this.RegistrationInfo.Equals(input.RegistrationInfo))
                ) && 
                (
                    this.UnprotectedSourcesSummary == input.UnprotectedSourcesSummary ||
                    this.UnprotectedSourcesSummary != null &&
                    input.UnprotectedSourcesSummary != null &&
                    this.UnprotectedSourcesSummary.SequenceEqual(input.UnprotectedSourcesSummary)
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
                if (this.ApplicationNodes != null)
                    hashCode = hashCode * 59 + this.ApplicationNodes.GetHashCode();
                if (this.EntityPaginationParameters != null)
                    hashCode = hashCode * 59 + this.EntityPaginationParameters.GetHashCode();
                if (this.EntityPermissionInfo != null)
                    hashCode = hashCode * 59 + this.EntityPermissionInfo.GetHashCode();
                if (this.LogicalSize != null)
                    hashCode = hashCode * 59 + this.LogicalSize.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.ProtectedSourcesSummary != null)
                    hashCode = hashCode * 59 + this.ProtectedSourcesSummary.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.RegistrationInfo != null)
                    hashCode = hashCode * 59 + this.RegistrationInfo.GetHashCode();
                if (this.UnprotectedSourcesSummary != null)
                    hashCode = hashCode * 59 + this.UnprotectedSourcesSummary.GetHashCode();
                return hashCode;
            }
        }

    }

}

