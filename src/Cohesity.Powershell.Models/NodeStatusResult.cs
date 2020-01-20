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
    /// Specifies the current status of a Node in the cluster.
    /// </summary>
    [DataContract]
    public partial class NodeStatusResult :  IEquatable<NodeStatusResult>
    {
        /// <summary>
        /// Specifies the active operation on the Node if there is one. &#39;kNone&#39; specifies that there is no active operation on the Node. &#39;kDestroyCluster&#39; specifies that the Cluster which the Node is a part of is currently being destroyed. &#39;kUpgradeCluster&#39; specifies that the Cluster which the Node is a part of is currently being upgraded to a new software package. &#39;kRestartCluster&#39; specifies that the Cluster which the Node is a part of is currently being restarted. &#39;kCreateCluster&#39; specifies that the Node is currently being used to create a new Cluster. &#39;kExpandCluster&#39; specifies that the Node is currently being added to a Cluster or being used to assist in adding another Node to a Cluster. &#39;kUpgradeNode&#39; specifies that the Node is currently being upgraded to a new software package. &#39;kRemoveNode&#39; specifies that the Node is currently being removed from a Cluster or that it is assisting in removing another Node from a Cluster. &#39;kAddDisks&#39; specifies that the Node is being used to assist in adding disks to the Cluster. &#39;kMarkDiskOffline&#39; specifies that the Node is being use to assist in marking a disk in the Cluster as offline.
        /// </summary>
        /// <value>Specifies the active operation on the Node if there is one. &#39;kNone&#39; specifies that there is no active operation on the Node. &#39;kDestroyCluster&#39; specifies that the Cluster which the Node is a part of is currently being destroyed. &#39;kUpgradeCluster&#39; specifies that the Cluster which the Node is a part of is currently being upgraded to a new software package. &#39;kRestartCluster&#39; specifies that the Cluster which the Node is a part of is currently being restarted. &#39;kCreateCluster&#39; specifies that the Node is currently being used to create a new Cluster. &#39;kExpandCluster&#39; specifies that the Node is currently being added to a Cluster or being used to assist in adding another Node to a Cluster. &#39;kUpgradeNode&#39; specifies that the Node is currently being upgraded to a new software package. &#39;kRemoveNode&#39; specifies that the Node is currently being removed from a Cluster or that it is assisting in removing another Node from a Cluster. &#39;kAddDisks&#39; specifies that the Node is being used to assist in adding disks to the Cluster. &#39;kMarkDiskOffline&#39; specifies that the Node is being use to assist in marking a disk in the Cluster as offline.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActiveOperationEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KDestroyCluster for value: kDestroyCluster
            /// </summary>
            [EnumMember(Value = "kDestroyCluster")]
            KDestroyCluster = 2,

            /// <summary>
            /// Enum KUpgradeCluster for value: kUpgradeCluster
            /// </summary>
            [EnumMember(Value = "kUpgradeCluster")]
            KUpgradeCluster = 3,

            /// <summary>
            /// Enum KRestartCluster for value: kRestartCluster
            /// </summary>
            [EnumMember(Value = "kRestartCluster")]
            KRestartCluster = 4,

            /// <summary>
            /// Enum KCreateCluster for value: kCreateCluster
            /// </summary>
            [EnumMember(Value = "kCreateCluster")]
            KCreateCluster = 5,

            /// <summary>
            /// Enum KExpandCluster for value: kExpandCluster
            /// </summary>
            [EnumMember(Value = "kExpandCluster")]
            KExpandCluster = 6,

            /// <summary>
            /// Enum KUpgradeNode for value: kUpgradeNode
            /// </summary>
            [EnumMember(Value = "kUpgradeNode")]
            KUpgradeNode = 7,

            /// <summary>
            /// Enum KRemoveNode for value: kRemoveNode
            /// </summary>
            [EnumMember(Value = "kRemoveNode")]
            KRemoveNode = 8,

            /// <summary>
            /// Enum KAddDisks for value: kAddDisks
            /// </summary>
            [EnumMember(Value = "kAddDisks")]
            KAddDisks = 9,

            /// <summary>
            /// Enum KMarkDiskOffline for value: kMarkDiskOffline
            /// </summary>
            [EnumMember(Value = "kMarkDiskOffline")]
            KMarkDiskOffline = 10

        }

        /// <summary>
        /// Specifies the active operation on the Node if there is one. &#39;kNone&#39; specifies that there is no active operation on the Node. &#39;kDestroyCluster&#39; specifies that the Cluster which the Node is a part of is currently being destroyed. &#39;kUpgradeCluster&#39; specifies that the Cluster which the Node is a part of is currently being upgraded to a new software package. &#39;kRestartCluster&#39; specifies that the Cluster which the Node is a part of is currently being restarted. &#39;kCreateCluster&#39; specifies that the Node is currently being used to create a new Cluster. &#39;kExpandCluster&#39; specifies that the Node is currently being added to a Cluster or being used to assist in adding another Node to a Cluster. &#39;kUpgradeNode&#39; specifies that the Node is currently being upgraded to a new software package. &#39;kRemoveNode&#39; specifies that the Node is currently being removed from a Cluster or that it is assisting in removing another Node from a Cluster. &#39;kAddDisks&#39; specifies that the Node is being used to assist in adding disks to the Cluster. &#39;kMarkDiskOffline&#39; specifies that the Node is being use to assist in marking a disk in the Cluster as offline.
        /// </summary>
        /// <value>Specifies the active operation on the Node if there is one. &#39;kNone&#39; specifies that there is no active operation on the Node. &#39;kDestroyCluster&#39; specifies that the Cluster which the Node is a part of is currently being destroyed. &#39;kUpgradeCluster&#39; specifies that the Cluster which the Node is a part of is currently being upgraded to a new software package. &#39;kRestartCluster&#39; specifies that the Cluster which the Node is a part of is currently being restarted. &#39;kCreateCluster&#39; specifies that the Node is currently being used to create a new Cluster. &#39;kExpandCluster&#39; specifies that the Node is currently being added to a Cluster or being used to assist in adding another Node to a Cluster. &#39;kUpgradeNode&#39; specifies that the Node is currently being upgraded to a new software package. &#39;kRemoveNode&#39; specifies that the Node is currently being removed from a Cluster or that it is assisting in removing another Node from a Cluster. &#39;kAddDisks&#39; specifies that the Node is being used to assist in adding disks to the Cluster. &#39;kMarkDiskOffline&#39; specifies that the Node is being use to assist in marking a disk in the Cluster as offline.</value>
        [DataMember(Name="activeOperation", EmitDefaultValue=true)]
        public ActiveOperationEnum? ActiveOperation { get; set; }
        /// <summary>
        /// Specifies the reason for the removal operation if there is a removal operation going on. &#39;kUnknown&#39; specifies that the removal reason is not known. &#39;kAutoHealthCheck&#39; specifies that an internal health check found problems with the Node. &#39;kUserGracefulRemoval&#39; specifies that the user requested a graceful removal. &#39;kUserAvoidAccess&#39; specifies that the user requested to avoid access to this Node. &#39;kUserGracefulNodeRemoval&#39; specifies that the user requested a graceful removal for all of the disks in this Node. &#39;kUserRemoveDownNode&#39; specifies that the user requested a graceful removal of the Node while it is down.
        /// </summary>
        /// <value>Specifies the reason for the removal operation if there is a removal operation going on. &#39;kUnknown&#39; specifies that the removal reason is not known. &#39;kAutoHealthCheck&#39; specifies that an internal health check found problems with the Node. &#39;kUserGracefulRemoval&#39; specifies that the user requested a graceful removal. &#39;kUserAvoidAccess&#39; specifies that the user requested to avoid access to this Node. &#39;kUserGracefulNodeRemoval&#39; specifies that the user requested a graceful removal for all of the disks in this Node. &#39;kUserRemoveDownNode&#39; specifies that the user requested a graceful removal of the Node while it is down.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemovalReasonEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KAutoHealthCheck for value: kAutoHealthCheck
            /// </summary>
            [EnumMember(Value = "kAutoHealthCheck")]
            KAutoHealthCheck = 2,

            /// <summary>
            /// Enum KUserGracefulRemoval for value: kUserGracefulRemoval
            /// </summary>
            [EnumMember(Value = "kUserGracefulRemoval")]
            KUserGracefulRemoval = 3,

            /// <summary>
            /// Enum KUserAvoidAccess for value: kUserAvoidAccess
            /// </summary>
            [EnumMember(Value = "kUserAvoidAccess")]
            KUserAvoidAccess = 4,

            /// <summary>
            /// Enum KUserGracefulNodeRemoval for value: kUserGracefulNodeRemoval
            /// </summary>
            [EnumMember(Value = "kUserGracefulNodeRemoval")]
            KUserGracefulNodeRemoval = 5,

            /// <summary>
            /// Enum KUserRemoveDownNode for value: kUserRemoveDownNode
            /// </summary>
            [EnumMember(Value = "kUserRemoveDownNode")]
            KUserRemoveDownNode = 6

        }

        /// <summary>
        /// Specifies the reason for the removal operation if there is a removal operation going on. &#39;kUnknown&#39; specifies that the removal reason is not known. &#39;kAutoHealthCheck&#39; specifies that an internal health check found problems with the Node. &#39;kUserGracefulRemoval&#39; specifies that the user requested a graceful removal. &#39;kUserAvoidAccess&#39; specifies that the user requested to avoid access to this Node. &#39;kUserGracefulNodeRemoval&#39; specifies that the user requested a graceful removal for all of the disks in this Node. &#39;kUserRemoveDownNode&#39; specifies that the user requested a graceful removal of the Node while it is down.
        /// </summary>
        /// <value>Specifies the reason for the removal operation if there is a removal operation going on. &#39;kUnknown&#39; specifies that the removal reason is not known. &#39;kAutoHealthCheck&#39; specifies that an internal health check found problems with the Node. &#39;kUserGracefulRemoval&#39; specifies that the user requested a graceful removal. &#39;kUserAvoidAccess&#39; specifies that the user requested to avoid access to this Node. &#39;kUserGracefulNodeRemoval&#39; specifies that the user requested a graceful removal for all of the disks in this Node. &#39;kUserRemoveDownNode&#39; specifies that the user requested a graceful removal of the Node while it is down.</value>
        [DataMember(Name="removalReason", EmitDefaultValue=true)]
        public RemovalReasonEnum? RemovalReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusResult" /> class.
        /// </summary>
        /// <param name="activeOperation">Specifies the active operation on the Node if there is one. &#39;kNone&#39; specifies that there is no active operation on the Node. &#39;kDestroyCluster&#39; specifies that the Cluster which the Node is a part of is currently being destroyed. &#39;kUpgradeCluster&#39; specifies that the Cluster which the Node is a part of is currently being upgraded to a new software package. &#39;kRestartCluster&#39; specifies that the Cluster which the Node is a part of is currently being restarted. &#39;kCreateCluster&#39; specifies that the Node is currently being used to create a new Cluster. &#39;kExpandCluster&#39; specifies that the Node is currently being added to a Cluster or being used to assist in adding another Node to a Cluster. &#39;kUpgradeNode&#39; specifies that the Node is currently being upgraded to a new software package. &#39;kRemoveNode&#39; specifies that the Node is currently being removed from a Cluster or that it is assisting in removing another Node from a Cluster. &#39;kAddDisks&#39; specifies that the Node is being used to assist in adding disks to the Cluster. &#39;kMarkDiskOffline&#39; specifies that the Node is being use to assist in marking a disk in the Cluster as offline..</param>
        /// <param name="clusterId">Specifies the Cluster ID if the Node is part of a Cluster..</param>
        /// <param name="id">Specifies the ID of the Node..</param>
        /// <param name="inCluster">Specifies whether or not the Node is part of a Cluster..</param>
        /// <param name="incarnationId">Specifies the Incarnation ID if the Node is part of a Cluster..</param>
        /// <param name="ip">Specifies the IP address of the Node..</param>
        /// <param name="lastUpgradeTimeSecs">Specifies the time of the last upgrade in seconds since the epoch..</param>
        /// <param name="markedForRemoval">Specifies whether or not this node is marked for removal..</param>
        /// <param name="message">Specifies an optional message describing the current state of the Node..</param>
        /// <param name="removalReason">Specifies the reason for the removal operation if there is a removal operation going on. &#39;kUnknown&#39; specifies that the removal reason is not known. &#39;kAutoHealthCheck&#39; specifies that an internal health check found problems with the Node. &#39;kUserGracefulRemoval&#39; specifies that the user requested a graceful removal. &#39;kUserAvoidAccess&#39; specifies that the user requested to avoid access to this Node. &#39;kUserGracefulNodeRemoval&#39; specifies that the user requested a graceful removal for all of the disks in this Node. &#39;kUserRemoveDownNode&#39; specifies that the user requested a graceful removal of the Node while it is down..</param>
        /// <param name="services">Specifies the list of services running on the cluster and their process Ids..</param>
        /// <param name="softwareVersion">Specifies the version of the software running on the Node..</param>
        /// <param name="uptime">Uptime of node..</param>
        public NodeStatusResult(ActiveOperationEnum? activeOperation = default(ActiveOperationEnum?), long? clusterId = default(long?), long? id = default(long?), bool? inCluster = default(bool?), long? incarnationId = default(long?), string ip = default(string), long? lastUpgradeTimeSecs = default(long?), bool? markedForRemoval = default(bool?), string message = default(string), RemovalReasonEnum? removalReason = default(RemovalReasonEnum?), List<ServiceProcessEntry> services = default(List<ServiceProcessEntry>), string softwareVersion = default(string), string uptime = default(string))
        {
            this.ActiveOperation = activeOperation;
            this.ClusterId = clusterId;
            this.Id = id;
            this.InCluster = inCluster;
            this.IncarnationId = incarnationId;
            this.Ip = ip;
            this.LastUpgradeTimeSecs = lastUpgradeTimeSecs;
            this.MarkedForRemoval = markedForRemoval;
            this.Message = message;
            this.RemovalReason = removalReason;
            this.Services = services;
            this.SoftwareVersion = softwareVersion;
            this.Uptime = uptime;
            this.ActiveOperation = activeOperation;
            this.ClusterId = clusterId;
            this.Id = id;
            this.InCluster = inCluster;
            this.IncarnationId = incarnationId;
            this.Ip = ip;
            this.LastUpgradeTimeSecs = lastUpgradeTimeSecs;
            this.MarkedForRemoval = markedForRemoval;
            this.Message = message;
            this.RemovalReason = removalReason;
            this.Services = services;
            this.SoftwareVersion = softwareVersion;
            this.Uptime = uptime;
        }
        
        /// <summary>
        /// Specifies the Cluster ID if the Node is part of a Cluster.
        /// </summary>
        /// <value>Specifies the Cluster ID if the Node is part of a Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the ID of the Node.
        /// </summary>
        /// <value>Specifies the ID of the Node.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies whether or not the Node is part of a Cluster.
        /// </summary>
        /// <value>Specifies whether or not the Node is part of a Cluster.</value>
        [DataMember(Name="inCluster", EmitDefaultValue=true)]
        public bool? InCluster { get; set; }

        /// <summary>
        /// Specifies the Incarnation ID if the Node is part of a Cluster.
        /// </summary>
        /// <value>Specifies the Incarnation ID if the Node is part of a Cluster.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=true)]
        public long? IncarnationId { get; set; }

        /// <summary>
        /// Specifies the IP address of the Node.
        /// </summary>
        /// <value>Specifies the IP address of the Node.</value>
        [DataMember(Name="ip", EmitDefaultValue=true)]
        public string Ip { get; set; }

        /// <summary>
        /// Specifies the time of the last upgrade in seconds since the epoch.
        /// </summary>
        /// <value>Specifies the time of the last upgrade in seconds since the epoch.</value>
        [DataMember(Name="lastUpgradeTimeSecs", EmitDefaultValue=true)]
        public long? LastUpgradeTimeSecs { get; set; }

        /// <summary>
        /// Specifies whether or not this node is marked for removal.
        /// </summary>
        /// <value>Specifies whether or not this node is marked for removal.</value>
        [DataMember(Name="markedForRemoval", EmitDefaultValue=true)]
        public bool? MarkedForRemoval { get; set; }

        /// <summary>
        /// Specifies an optional message describing the current state of the Node.
        /// </summary>
        /// <value>Specifies an optional message describing the current state of the Node.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the list of services running on the cluster and their process Ids.
        /// </summary>
        /// <value>Specifies the list of services running on the cluster and their process Ids.</value>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<ServiceProcessEntry> Services { get; set; }

        /// <summary>
        /// Specifies the version of the software running on the Node.
        /// </summary>
        /// <value>Specifies the version of the software running on the Node.</value>
        [DataMember(Name="softwareVersion", EmitDefaultValue=true)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Uptime of node.
        /// </summary>
        /// <value>Uptime of node.</value>
        [DataMember(Name="uptime", EmitDefaultValue=true)]
        public string Uptime { get; set; }

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
            return this.Equals(input as NodeStatusResult);
        }

        /// <summary>
        /// Returns true if NodeStatusResult instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeStatusResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveOperation == input.ActiveOperation ||
                    this.ActiveOperation.Equals(input.ActiveOperation)
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InCluster == input.InCluster ||
                    (this.InCluster != null &&
                    this.InCluster.Equals(input.InCluster))
                ) && 
                (
                    this.IncarnationId == input.IncarnationId ||
                    (this.IncarnationId != null &&
                    this.IncarnationId.Equals(input.IncarnationId))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.LastUpgradeTimeSecs == input.LastUpgradeTimeSecs ||
                    (this.LastUpgradeTimeSecs != null &&
                    this.LastUpgradeTimeSecs.Equals(input.LastUpgradeTimeSecs))
                ) && 
                (
                    this.MarkedForRemoval == input.MarkedForRemoval ||
                    (this.MarkedForRemoval != null &&
                    this.MarkedForRemoval.Equals(input.MarkedForRemoval))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RemovalReason == input.RemovalReason ||
                    this.RemovalReason.Equals(input.RemovalReason)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
                ) && 
                (
                    this.Uptime == input.Uptime ||
                    (this.Uptime != null &&
                    this.Uptime.Equals(input.Uptime))
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
                hashCode = hashCode * 59 + this.ActiveOperation.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InCluster != null)
                    hashCode = hashCode * 59 + this.InCluster.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.LastUpgradeTimeSecs != null)
                    hashCode = hashCode * 59 + this.LastUpgradeTimeSecs.GetHashCode();
                if (this.MarkedForRemoval != null)
                    hashCode = hashCode * 59 + this.MarkedForRemoval.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.RemovalReason.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.SoftwareVersion != null)
                    hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                if (this.Uptime != null)
                    hashCode = hashCode * 59 + this.Uptime.GetHashCode();
                return hashCode;
            }
        }

    }

}

