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
    /// Specifies the information about the AAG replica.
    /// </summary>
    [DataContract]
    public partial class AAGReplicaInfo :  IEquatable<AAGReplicaInfo>
    {
        /// <summary>
        /// Specifies the availability mode of the replica.
        /// </summary>
        /// <value>Specifies the availability mode of the replica.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityModeEnum
        {
            /// <summary>
            /// Enum KSync for value: kSync
            /// </summary>
            [EnumMember(Value = "kSync")]
            KSync = 1,

            /// <summary>
            /// Enum KAsync for value: kAsync
            /// </summary>
            [EnumMember(Value = "kAsync")]
            KAsync = 2

        }

        /// <summary>
        /// Specifies the availability mode of the replica.
        /// </summary>
        /// <value>Specifies the availability mode of the replica.</value>
        [DataMember(Name="availabilityMode", EmitDefaultValue=true)]
        public AvailabilityModeEnum? AvailabilityMode { get; set; }
        /// <summary>
        /// Specifies the operational state of the replica. kFailedNoQuorum, kNull
        /// </summary>
        /// <value>Specifies the operational state of the replica. kFailedNoQuorum, kNull</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationalStateEnum
        {
            /// <summary>
            /// Enum KPendingFailover for value: kPendingFailover
            /// </summary>
            [EnumMember(Value = "kPendingFailover")]
            KPendingFailover = 1,

            /// <summary>
            /// Enum KPending for value: kPending
            /// </summary>
            [EnumMember(Value = "kPending")]
            KPending = 2,

            /// <summary>
            /// Enum KOnline for value: kOnline
            /// </summary>
            [EnumMember(Value = "kOnline")]
            KOnline = 3,

            /// <summary>
            /// Enum KOffline for value: kOffline
            /// </summary>
            [EnumMember(Value = "kOffline")]
            KOffline = 4,

            /// <summary>
            /// Enum KFailed for value: kFailed
            /// </summary>
            [EnumMember(Value = "kFailed")]
            KFailed = 5,

            /// <summary>
            /// Enum KFailedNoQuorum for value: kFailedNoQuorum
            /// </summary>
            [EnumMember(Value = "kFailedNoQuorum")]
            KFailedNoQuorum = 6,

            /// <summary>
            /// Enum KNull for value: kNull
            /// </summary>
            [EnumMember(Value = "kNull")]
            KNull = 7

        }

        /// <summary>
        /// Specifies the operational state of the replica. kFailedNoQuorum, kNull
        /// </summary>
        /// <value>Specifies the operational state of the replica. kFailedNoQuorum, kNull</value>
        [DataMember(Name="operationalState", EmitDefaultValue=true)]
        public OperationalStateEnum? OperationalState { get; set; }
        /// <summary>
        /// Specifies what are the types of connections primary role allows.
        /// </summary>
        /// <value>Specifies what are the types of connections primary role allows.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrimaryRoleAllowConnectionsEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 3,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 4

        }

        /// <summary>
        /// Specifies what are the types of connections primary role allows.
        /// </summary>
        /// <value>Specifies what are the types of connections primary role allows.</value>
        [DataMember(Name="primaryRoleAllowConnections", EmitDefaultValue=true)]
        public PrimaryRoleAllowConnectionsEnum? PrimaryRoleAllowConnections { get; set; }
        /// <summary>
        /// Specifies the role of replica.
        /// </summary>
        /// <value>Specifies the role of replica.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum KResolving for value: kResolving
            /// </summary>
            [EnumMember(Value = "kResolving")]
            KResolving = 1,

            /// <summary>
            /// Enum KPrimary for value: kPrimary
            /// </summary>
            [EnumMember(Value = "kPrimary")]
            KPrimary = 2,

            /// <summary>
            /// Enum KSecondary for value: kSecondary
            /// </summary>
            [EnumMember(Value = "kSecondary")]
            KSecondary = 3

        }

        /// <summary>
        /// Specifies the role of replica.
        /// </summary>
        /// <value>Specifies the role of replica.</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Specifies what are the types of connections secondary role allows.
        /// </summary>
        /// <value>Specifies what are the types of connections secondary role allows.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecondaryRoleAllowConnectionsEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 2,

            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 3,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 4

        }

        /// <summary>
        /// Specifies what are the types of connections secondary role allows.
        /// </summary>
        /// <value>Specifies what are the types of connections secondary role allows.</value>
        [DataMember(Name="secondaryRoleAllowConnections", EmitDefaultValue=true)]
        public SecondaryRoleAllowConnectionsEnum? SecondaryRoleAllowConnections { get; set; }
        /// <summary>
        /// Specifies the synchronization health of the replica.
        /// </summary>
        /// <value>Specifies the synchronization health of the replica.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SynchronizationHealthEnum
        {
            /// <summary>
            /// Enum KNotHealthy for value: kNotHealthy
            /// </summary>
            [EnumMember(Value = "kNotHealthy")]
            KNotHealthy = 1,

            /// <summary>
            /// Enum KPartiallyHealthy for value: kPartiallyHealthy
            /// </summary>
            [EnumMember(Value = "kPartiallyHealthy")]
            KPartiallyHealthy = 2,

            /// <summary>
            /// Enum KHealthy for value: kHealthy
            /// </summary>
            [EnumMember(Value = "kHealthy")]
            KHealthy = 3

        }

        /// <summary>
        /// Specifies the synchronization health of the replica.
        /// </summary>
        /// <value>Specifies the synchronization health of the replica.</value>
        [DataMember(Name="synchronizationHealth", EmitDefaultValue=true)]
        public SynchronizationHealthEnum? SynchronizationHealth { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AAGReplicaInfo" /> class.
        /// </summary>
        /// <param name="availabilityMode">Specifies the availability mode of the replica..</param>
        /// <param name="createDateMsecs">Specifies the time when replica is created..</param>
        /// <param name="hostName">Specifies the host name of the replica..</param>
        /// <param name="lastModifiedMsecs">Specifies the backup priority..</param>
        /// <param name="operationalState">Specifies the operational state of the replica. kFailedNoQuorum, kNull.</param>
        /// <param name="primaryRoleAllowConnections">Specifies what are the types of connections primary role allows..</param>
        /// <param name="role">Specifies the role of replica..</param>
        /// <param name="secondaryRoleAllowConnections">Specifies what are the types of connections secondary role allows..</param>
        /// <param name="serverName">Specifies the instance name along with the host name on which the AAG databases are hosted..</param>
        /// <param name="synchronizationHealth">Specifies the synchronization health of the replica..</param>
        public AAGReplicaInfo(AvailabilityModeEnum? availabilityMode = default(AvailabilityModeEnum?), long? createDateMsecs = default(long?), string hostName = default(string), int? lastModifiedMsecs = default(int?), OperationalStateEnum? operationalState = default(OperationalStateEnum?), PrimaryRoleAllowConnectionsEnum? primaryRoleAllowConnections = default(PrimaryRoleAllowConnectionsEnum?), RoleEnum? role = default(RoleEnum?), SecondaryRoleAllowConnectionsEnum? secondaryRoleAllowConnections = default(SecondaryRoleAllowConnectionsEnum?), string serverName = default(string), SynchronizationHealthEnum? synchronizationHealth = default(SynchronizationHealthEnum?))
        {
            this.AvailabilityMode = availabilityMode;
            this.CreateDateMsecs = createDateMsecs;
            this.HostName = hostName;
            this.LastModifiedMsecs = lastModifiedMsecs;
            this.OperationalState = operationalState;
            this.PrimaryRoleAllowConnections = primaryRoleAllowConnections;
            this.Role = role;
            this.SecondaryRoleAllowConnections = secondaryRoleAllowConnections;
            this.ServerName = serverName;
            this.SynchronizationHealth = synchronizationHealth;
            this.AvailabilityMode = availabilityMode;
            this.CreateDateMsecs = createDateMsecs;
            this.HostName = hostName;
            this.LastModifiedMsecs = lastModifiedMsecs;
            this.OperationalState = operationalState;
            this.PrimaryRoleAllowConnections = primaryRoleAllowConnections;
            this.Role = role;
            this.SecondaryRoleAllowConnections = secondaryRoleAllowConnections;
            this.ServerName = serverName;
            this.SynchronizationHealth = synchronizationHealth;
        }
        
        /// <summary>
        /// Specifies the time when replica is created.
        /// </summary>
        /// <value>Specifies the time when replica is created.</value>
        [DataMember(Name="createDateMsecs", EmitDefaultValue=true)]
        public long? CreateDateMsecs { get; set; }

        /// <summary>
        /// Specifies the host name of the replica.
        /// </summary>
        /// <value>Specifies the host name of the replica.</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Specifies the backup priority.
        /// </summary>
        /// <value>Specifies the backup priority.</value>
        [DataMember(Name="lastModifiedMsecs", EmitDefaultValue=true)]
        public int? LastModifiedMsecs { get; set; }

        /// <summary>
        /// Specifies the instance name along with the host name on which the AAG databases are hosted.
        /// </summary>
        /// <value>Specifies the instance name along with the host name on which the AAG databases are hosted.</value>
        [DataMember(Name="serverName", EmitDefaultValue=true)]
        public string ServerName { get; set; }

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
            return this.Equals(input as AAGReplicaInfo);
        }

        /// <summary>
        /// Returns true if AAGReplicaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AAGReplicaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AAGReplicaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityMode == input.AvailabilityMode ||
                    this.AvailabilityMode.Equals(input.AvailabilityMode)
                ) && 
                (
                    this.CreateDateMsecs == input.CreateDateMsecs ||
                    (this.CreateDateMsecs != null &&
                    this.CreateDateMsecs.Equals(input.CreateDateMsecs))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.LastModifiedMsecs == input.LastModifiedMsecs ||
                    (this.LastModifiedMsecs != null &&
                    this.LastModifiedMsecs.Equals(input.LastModifiedMsecs))
                ) && 
                (
                    this.OperationalState == input.OperationalState ||
                    this.OperationalState.Equals(input.OperationalState)
                ) && 
                (
                    this.PrimaryRoleAllowConnections == input.PrimaryRoleAllowConnections ||
                    this.PrimaryRoleAllowConnections.Equals(input.PrimaryRoleAllowConnections)
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) && 
                (
                    this.SecondaryRoleAllowConnections == input.SecondaryRoleAllowConnections ||
                    this.SecondaryRoleAllowConnections.Equals(input.SecondaryRoleAllowConnections)
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.SynchronizationHealth == input.SynchronizationHealth ||
                    this.SynchronizationHealth.Equals(input.SynchronizationHealth)
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
                hashCode = hashCode * 59 + this.AvailabilityMode.GetHashCode();
                if (this.CreateDateMsecs != null)
                    hashCode = hashCode * 59 + this.CreateDateMsecs.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.LastModifiedMsecs != null)
                    hashCode = hashCode * 59 + this.LastModifiedMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.OperationalState.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryRoleAllowConnections.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                hashCode = hashCode * 59 + this.SecondaryRoleAllowConnections.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                hashCode = hashCode * 59 + this.SynchronizationHealth.GetHashCode();
                return hashCode;
            }
        }

    }

}

