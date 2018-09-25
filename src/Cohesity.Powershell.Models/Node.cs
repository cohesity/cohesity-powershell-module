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
    /// Node
    /// </summary>
    [DataContract]
    public partial class Node :  IEquatable<Node>
    {
        /// <summary>
        /// RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalStateEnum
        {
            
            /// <summary>
            /// Enum KDontRemove for value: kDontRemove
            /// </summary>
            [EnumMember(Value = "kDontRemove")]
            KDontRemove = 1,
            
            /// <summary>
            /// Enum KMarkedForRemoval for value: kMarkedForRemoval
            /// </summary>
            [EnumMember(Value = "kMarkedForRemoval")]
            KMarkedForRemoval = 2,
            
            /// <summary>
            /// Enum KOkToRemove for value: kOkToRemove
            /// </summary>
            [EnumMember(Value = "kOkToRemove")]
            KOkToRemove = 3
        }

        /// <summary>
        /// RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.
        /// </summary>
        /// <value>RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster.</value>
        [DataMember(Name="removalState", EmitDefaultValue=false)]
        public RemovalStateEnum? RemovalState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Node" /> class.
        /// </summary>
        /// <param name="capacityByTier">capacityByTier.</param>
        /// <param name="chassisInfo">ChassisInfo describes the information for the chassis of the node..</param>
        /// <param name="clusterPartitionId">ClusterPartitionId is the Id of the cluster partition to which the Node belongs..</param>
        /// <param name="clusterPartitionName">ClusterPartitionName is the name of the cluster to which the Node belongs..</param>
        /// <param name="diskCount">DiskCount is the number of disks in a node..</param>
        /// <param name="id">Id is the Id of the Node..</param>
        /// <param name="ip">Ip is the IP address of the Node..</param>
        /// <param name="isMarkedForRemoval">IsMarkedForRemoval specifies whether the node has been marked for removal..</param>
        /// <param name="maxPhysicalCapacityBytes">MaxPhysicalCapacityBytes specifies the maximum physical capacity of the node in bytes..</param>
        /// <param name="nodeHardwareInfo">HardwareInfo describes the hardware of the node..</param>
        /// <param name="nodeIncarnationId">NodeIncarnationId is the incarnation id  of this node. The incarnation id is changed every time the data is wiped from the node. Various services on a node is only run if incarnation id of the node matches the incarnation id of the cluster. Whenever a mismatch is detected, Nexus will stop all services and clean the data from the node. After clean operation is completed, Nexus will set the node incarnation id to cluster incarnation id and start the services..</param>
        /// <param name="nodeSoftwareVersion">NodeSoftwareVersion is the current version of Cohesity software installed on a node..</param>
        /// <param name="offlineMountPathsOfDisks">OfflineMountPathsOfDisks provides the corresponding mount paths for direct attached disks that are currently offline - access to these were detected to hang sometime in the past. After these disks have been fixed, their mount paths needs to be removed from the following list before these will be accessed again..</param>
        /// <param name="removalState">RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster..</param>
        /// <param name="stats">Stats describes the node stats..</param>
        /// <param name="systemDisks">systemDisks.</param>
        public Node(List<CapacityByTier> capacityByTier = default(List<CapacityByTier>), ChassisInfo chassisInfo = default(ChassisInfo), long? clusterPartitionId = default(long?), string clusterPartitionName = default(string), long? diskCount = default(long?), long? id = default(long?), string ip = default(string), bool? isMarkedForRemoval = default(bool?), long? maxPhysicalCapacityBytes = default(long?), NodeHardwareInfo nodeHardwareInfo = default(NodeHardwareInfo), long? nodeIncarnationId = default(long?), string nodeSoftwareVersion = default(string), List<string> offlineMountPathsOfDisks = default(List<string>), RemovalStateEnum? removalState = default(RemovalStateEnum?), NodeStats stats = default(NodeStats), List<NodeSystemDiskInfo> systemDisks = default(List<NodeSystemDiskInfo>))
        {
            this.CapacityByTier = capacityByTier;
            this.ChassisInfo = chassisInfo;
            this.ClusterPartitionId = clusterPartitionId;
            this.ClusterPartitionName = clusterPartitionName;
            this.DiskCount = diskCount;
            this.Id = id;
            this.Ip = ip;
            this.IsMarkedForRemoval = isMarkedForRemoval;
            this.MaxPhysicalCapacityBytes = maxPhysicalCapacityBytes;
            this.NodeHardwareInfo = nodeHardwareInfo;
            this.NodeIncarnationId = nodeIncarnationId;
            this.NodeSoftwareVersion = nodeSoftwareVersion;
            this.OfflineMountPathsOfDisks = offlineMountPathsOfDisks;
            this.RemovalState = removalState;
            this.Stats = stats;
            this.SystemDisks = systemDisks;
        }
        
        /// <summary>
        /// Gets or Sets CapacityByTier
        /// </summary>
        [DataMember(Name="capacityByTier", EmitDefaultValue=false)]
        public List<CapacityByTier> CapacityByTier { get; set; }

        /// <summary>
        /// ChassisInfo describes the information for the chassis of the node.
        /// </summary>
        /// <value>ChassisInfo describes the information for the chassis of the node.</value>
        [DataMember(Name="chassisInfo", EmitDefaultValue=false)]
        public ChassisInfo ChassisInfo { get; set; }

        /// <summary>
        /// ClusterPartitionId is the Id of the cluster partition to which the Node belongs.
        /// </summary>
        /// <value>ClusterPartitionId is the Id of the cluster partition to which the Node belongs.</value>
        [DataMember(Name="clusterPartitionId", EmitDefaultValue=false)]
        public long? ClusterPartitionId { get; set; }

        /// <summary>
        /// ClusterPartitionName is the name of the cluster to which the Node belongs.
        /// </summary>
        /// <value>ClusterPartitionName is the name of the cluster to which the Node belongs.</value>
        [DataMember(Name="clusterPartitionName", EmitDefaultValue=false)]
        public string ClusterPartitionName { get; set; }

        /// <summary>
        /// DiskCount is the number of disks in a node.
        /// </summary>
        /// <value>DiskCount is the number of disks in a node.</value>
        [DataMember(Name="diskCount", EmitDefaultValue=false)]
        public long? DiskCount { get; set; }

        /// <summary>
        /// Id is the Id of the Node.
        /// </summary>
        /// <value>Id is the Id of the Node.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Ip is the IP address of the Node.
        /// </summary>
        /// <value>Ip is the IP address of the Node.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// IsMarkedForRemoval specifies whether the node has been marked for removal.
        /// </summary>
        /// <value>IsMarkedForRemoval specifies whether the node has been marked for removal.</value>
        [DataMember(Name="isMarkedForRemoval", EmitDefaultValue=false)]
        public bool? IsMarkedForRemoval { get; set; }

        /// <summary>
        /// MaxPhysicalCapacityBytes specifies the maximum physical capacity of the node in bytes.
        /// </summary>
        /// <value>MaxPhysicalCapacityBytes specifies the maximum physical capacity of the node in bytes.</value>
        [DataMember(Name="maxPhysicalCapacityBytes", EmitDefaultValue=false)]
        public long? MaxPhysicalCapacityBytes { get; set; }

        /// <summary>
        /// HardwareInfo describes the hardware of the node.
        /// </summary>
        /// <value>HardwareInfo describes the hardware of the node.</value>
        [DataMember(Name="nodeHardwareInfo", EmitDefaultValue=false)]
        public NodeHardwareInfo NodeHardwareInfo { get; set; }

        /// <summary>
        /// NodeIncarnationId is the incarnation id  of this node. The incarnation id is changed every time the data is wiped from the node. Various services on a node is only run if incarnation id of the node matches the incarnation id of the cluster. Whenever a mismatch is detected, Nexus will stop all services and clean the data from the node. After clean operation is completed, Nexus will set the node incarnation id to cluster incarnation id and start the services.
        /// </summary>
        /// <value>NodeIncarnationId is the incarnation id  of this node. The incarnation id is changed every time the data is wiped from the node. Various services on a node is only run if incarnation id of the node matches the incarnation id of the cluster. Whenever a mismatch is detected, Nexus will stop all services and clean the data from the node. After clean operation is completed, Nexus will set the node incarnation id to cluster incarnation id and start the services.</value>
        [DataMember(Name="nodeIncarnationId", EmitDefaultValue=false)]
        public long? NodeIncarnationId { get; set; }

        /// <summary>
        /// NodeSoftwareVersion is the current version of Cohesity software installed on a node.
        /// </summary>
        /// <value>NodeSoftwareVersion is the current version of Cohesity software installed on a node.</value>
        [DataMember(Name="nodeSoftwareVersion", EmitDefaultValue=false)]
        public string NodeSoftwareVersion { get; set; }

        /// <summary>
        /// OfflineMountPathsOfDisks provides the corresponding mount paths for direct attached disks that are currently offline - access to these were detected to hang sometime in the past. After these disks have been fixed, their mount paths needs to be removed from the following list before these will be accessed again.
        /// </summary>
        /// <value>OfflineMountPathsOfDisks provides the corresponding mount paths for direct attached disks that are currently offline - access to these were detected to hang sometime in the past. After these disks have been fixed, their mount paths needs to be removed from the following list before these will be accessed again.</value>
        [DataMember(Name="offlineMountPathsOfDisks", EmitDefaultValue=false)]
        public List<string> OfflineMountPathsOfDisks { get; set; }


        /// <summary>
        /// Stats describes the node stats.
        /// </summary>
        /// <value>Stats describes the node stats.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public NodeStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets SystemDisks
        /// </summary>
        [DataMember(Name="systemDisks", EmitDefaultValue=false)]
        public List<NodeSystemDiskInfo> SystemDisks { get; set; }

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
            return this.Equals(input as Node);
        }

        /// <summary>
        /// Returns true if Node instances are equal
        /// </summary>
        /// <param name="input">Instance of Node to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Node input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityByTier == input.CapacityByTier ||
                    this.CapacityByTier != null &&
                    this.CapacityByTier.SequenceEqual(input.CapacityByTier)
                ) && 
                (
                    this.ChassisInfo == input.ChassisInfo ||
                    (this.ChassisInfo != null &&
                    this.ChassisInfo.Equals(input.ChassisInfo))
                ) && 
                (
                    this.ClusterPartitionId == input.ClusterPartitionId ||
                    (this.ClusterPartitionId != null &&
                    this.ClusterPartitionId.Equals(input.ClusterPartitionId))
                ) && 
                (
                    this.ClusterPartitionName == input.ClusterPartitionName ||
                    (this.ClusterPartitionName != null &&
                    this.ClusterPartitionName.Equals(input.ClusterPartitionName))
                ) && 
                (
                    this.DiskCount == input.DiskCount ||
                    (this.DiskCount != null &&
                    this.DiskCount.Equals(input.DiskCount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.IsMarkedForRemoval == input.IsMarkedForRemoval ||
                    (this.IsMarkedForRemoval != null &&
                    this.IsMarkedForRemoval.Equals(input.IsMarkedForRemoval))
                ) && 
                (
                    this.MaxPhysicalCapacityBytes == input.MaxPhysicalCapacityBytes ||
                    (this.MaxPhysicalCapacityBytes != null &&
                    this.MaxPhysicalCapacityBytes.Equals(input.MaxPhysicalCapacityBytes))
                ) && 
                (
                    this.NodeHardwareInfo == input.NodeHardwareInfo ||
                    (this.NodeHardwareInfo != null &&
                    this.NodeHardwareInfo.Equals(input.NodeHardwareInfo))
                ) && 
                (
                    this.NodeIncarnationId == input.NodeIncarnationId ||
                    (this.NodeIncarnationId != null &&
                    this.NodeIncarnationId.Equals(input.NodeIncarnationId))
                ) && 
                (
                    this.NodeSoftwareVersion == input.NodeSoftwareVersion ||
                    (this.NodeSoftwareVersion != null &&
                    this.NodeSoftwareVersion.Equals(input.NodeSoftwareVersion))
                ) && 
                (
                    this.OfflineMountPathsOfDisks == input.OfflineMountPathsOfDisks ||
                    this.OfflineMountPathsOfDisks != null &&
                    this.OfflineMountPathsOfDisks.SequenceEqual(input.OfflineMountPathsOfDisks)
                ) && 
                (
                    this.RemovalState == input.RemovalState ||
                    (this.RemovalState != null &&
                    this.RemovalState.Equals(input.RemovalState))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.SystemDisks == input.SystemDisks ||
                    this.SystemDisks != null &&
                    this.SystemDisks.SequenceEqual(input.SystemDisks)
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
                if (this.CapacityByTier != null)
                    hashCode = hashCode * 59 + this.CapacityByTier.GetHashCode();
                if (this.ChassisInfo != null)
                    hashCode = hashCode * 59 + this.ChassisInfo.GetHashCode();
                if (this.ClusterPartitionId != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionId.GetHashCode();
                if (this.ClusterPartitionName != null)
                    hashCode = hashCode * 59 + this.ClusterPartitionName.GetHashCode();
                if (this.DiskCount != null)
                    hashCode = hashCode * 59 + this.DiskCount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.IsMarkedForRemoval != null)
                    hashCode = hashCode * 59 + this.IsMarkedForRemoval.GetHashCode();
                if (this.MaxPhysicalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.MaxPhysicalCapacityBytes.GetHashCode();
                if (this.NodeHardwareInfo != null)
                    hashCode = hashCode * 59 + this.NodeHardwareInfo.GetHashCode();
                if (this.NodeIncarnationId != null)
                    hashCode = hashCode * 59 + this.NodeIncarnationId.GetHashCode();
                if (this.NodeSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.NodeSoftwareVersion.GetHashCode();
                if (this.OfflineMountPathsOfDisks != null)
                    hashCode = hashCode * 59 + this.OfflineMountPathsOfDisks.GetHashCode();
                if (this.RemovalState != null)
                    hashCode = hashCode * 59 + this.RemovalState.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.SystemDisks != null)
                    hashCode = hashCode * 59 + this.SystemDisks.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

