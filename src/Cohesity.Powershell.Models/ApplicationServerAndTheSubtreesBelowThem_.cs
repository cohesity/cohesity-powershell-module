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
    /// Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.
    /// </summary>
    [DataContract]
    public partial class ApplicationServerAndTheSubtreesBelowThem_ :  IEquatable<ApplicationServerAndTheSubtreesBelowThem_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationServerAndTheSubtreesBelowThem_" /> class.
        /// </summary>
        /// <param name="applicationNodes">Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM..</param>
        /// <param name="logicalSize">Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node..</param>
        /// <param name="nodes">Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy..</param>
        /// <param name="protectedSourcesSummary">Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector..</param>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="registrationInfo">registrationInfo.</param>
        /// <param name="unprotectedSourcesSummary">Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from..</param>
        public ApplicationServerAndTheSubtreesBelowThem_(List<ProtectionSourceNode> applicationNodes = default(List<ProtectionSourceNode>), long? logicalSize = default(long?), List<ProtectionSourceNode> nodes = default(List<ProtectionSourceNode>), List<AggregatedSubtreeInfo> protectedSourcesSummary = default(List<AggregatedSubtreeInfo>), ProtectionSource protectionSource = default(ProtectionSource), RegisteredSourceInfo_ registrationInfo = default(RegisteredSourceInfo_), List<AggregatedSubtreeInfo> unprotectedSourcesSummary = default(List<AggregatedSubtreeInfo>))
        {
            this.ApplicationNodes = applicationNodes;
            this.LogicalSize = logicalSize;
            this.Nodes = nodes;
            this.ProtectedSourcesSummary = protectedSourcesSummary;
            this.ProtectionSource = protectionSource;
            this.RegistrationInfo = registrationInfo;
            this.UnprotectedSourcesSummary = unprotectedSourcesSummary;
        }
        
        /// <summary>
        /// Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.
        /// </summary>
        /// <value>Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.</value>
        [DataMember(Name="applicationNodes", EmitDefaultValue=false)]
        public List<ProtectionSourceNode> ApplicationNodes { get; set; }

        /// <summary>
        /// Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node.
        /// </summary>
        /// <value>Specifies the logical size of the data in bytes for the Object on this node. Presence of this field indicates this node is a leaf node.</value>
        [DataMember(Name="logicalSize", EmitDefaultValue=false)]
        public long? LogicalSize { get; set; }

        /// <summary>
        /// Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy.
        /// </summary>
        /// <value>Specifies children of the current node in the Protection Sources hierarchy. When representing Objects in memory, the entire Object subtree hierarchy is represented. You can use this subtree to navigate down the Object hierarchy.</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<ProtectionSourceNode> Nodes { get; set; }

        /// <summary>
        /// Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector.
        /// </summary>
        /// <value>Specifies aggregated information about all the child Objects of this node that are currently protected by a Protection Job. There is one entry for each environment that is being backed up. The aggregated information for the Object hierarchy&#39;s environment will be available at the 0th index of the vector.</value>
        [DataMember(Name="protectedSourcesSummary", EmitDefaultValue=false)]
        public List<AggregatedSubtreeInfo> ProtectedSourcesSummary { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationInfo
        /// </summary>
        [DataMember(Name="registrationInfo", EmitDefaultValue=false)]
        public RegisteredSourceInfo_ RegistrationInfo { get; set; }

        /// <summary>
        /// Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from.
        /// </summary>
        /// <value>Specifies aggregated information about all the child Objects of this node that are not protected by any Protection Jobs. The aggregated information for the Objects hierarchy&#39;s environment will be available at the 0th index of the vector. NOTE: This list includes Objects that were protected at some point in the past but are no longer actively protected. Snapshots containing these Objects may even exist on the Cohesity Cluster and be available to recover from.</value>
        [DataMember(Name="unprotectedSourcesSummary", EmitDefaultValue=false)]
        public List<AggregatedSubtreeInfo> UnprotectedSourcesSummary { get; set; }

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
            return this.Equals(input as ApplicationServerAndTheSubtreesBelowThem_);
        }

        /// <summary>
        /// Returns true if ApplicationServerAndTheSubtreesBelowThem_ instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationServerAndTheSubtreesBelowThem_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationServerAndTheSubtreesBelowThem_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationNodes == input.ApplicationNodes ||
                    this.ApplicationNodes != null &&
                    this.ApplicationNodes.SequenceEqual(input.ApplicationNodes)
                ) && 
                (
                    this.LogicalSize == input.LogicalSize ||
                    (this.LogicalSize != null &&
                    this.LogicalSize.Equals(input.LogicalSize))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.ProtectedSourcesSummary == input.ProtectedSourcesSummary ||
                    this.ProtectedSourcesSummary != null &&
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

