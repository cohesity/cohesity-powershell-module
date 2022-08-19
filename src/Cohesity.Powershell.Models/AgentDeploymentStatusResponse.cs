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
    /// Specifies the overview of the agent deployment status.
    /// </summary>
    [DataContract]
    public partial class AgentDeploymentStatusResponse :  IEquatable<AgentDeploymentStatusResponse>
    {
        /// <summary>
        /// Specifies the health status of the Cohesity agent. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.
        /// </summary>
        /// <value>Specifies the health status of the Cohesity agent. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HealthStatusEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KUnreachable for value: kUnreachable
            /// </summary>
            [EnumMember(Value = "kUnreachable")]
            KUnreachable = 2,

            /// <summary>
            /// Enum KHealthy for value: kHealthy
            /// </summary>
            [EnumMember(Value = "kHealthy")]
            KHealthy = 3,

            /// <summary>
            /// Enum KDegraded for value: kDegraded
            /// </summary>
            [EnumMember(Value = "kDegraded")]
            KDegraded = 4

        }

        /// <summary>
        /// Specifies the health status of the Cohesity agent. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.
        /// </summary>
        /// <value>Specifies the health status of the Cohesity agent. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.</value>
        [DataMember(Name="healthStatus", EmitDefaultValue=true)]
        public HealthStatusEnum? HealthStatus { get; set; }
        /// <summary>
        /// Specifies the host type on which the agent is installed. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the host type on which the agent is installed. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostOsTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 6,

            /// <summary>
            /// Enum KCockroachDB for value: kCockroachDB
            /// </summary>
            [EnumMember(Value = "kCockroachDB")]
            KCockroachDB = 7,

            /// <summary>
            /// Enum KMySQL for value: kMySQL
            /// </summary>
            [EnumMember(Value = "kMySQL")]
            KMySQL = 8,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 9

        }

        /// <summary>
        /// Specifies the host type on which the agent is installed. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the host type on which the agent is installed. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostOsType", EmitDefaultValue=true)]
        public HostOsTypeEnum? HostOsType { get; set; }
        /// <summary>
        /// Specifies the status of the last upgrade attempt. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.
        /// </summary>
        /// <value>Specifies the status of the last upgrade attempt. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastUpgradeStatusEnum
        {
            /// <summary>
            /// Enum KIdle for value: kIdle
            /// </summary>
            [EnumMember(Value = "kIdle")]
            KIdle = 1,

            /// <summary>
            /// Enum KAccepted for value: kAccepted
            /// </summary>
            [EnumMember(Value = "kAccepted")]
            KAccepted = 2,

            /// <summary>
            /// Enum KStarted for value: kStarted
            /// </summary>
            [EnumMember(Value = "kStarted")]
            KStarted = 3,

            /// <summary>
            /// Enum KFinished for value: kFinished
            /// </summary>
            [EnumMember(Value = "kFinished")]
            KFinished = 4,

            /// <summary>
            /// Enum KScheduled for value: kScheduled
            /// </summary>
            [EnumMember(Value = "kScheduled")]
            KScheduled = 5

        }

        /// <summary>
        /// Specifies the status of the last upgrade attempt. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.
        /// </summary>
        /// <value>Specifies the status of the last upgrade attempt. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.</value>
        [DataMember(Name="lastUpgradeStatus", EmitDefaultValue=true)]
        public LastUpgradeStatusEnum? LastUpgradeStatus { get; set; }
        /// <summary>
        /// Specifies the upgradability of the agent running on the server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.
        /// </summary>
        /// <value>Specifies the upgradability of the agent running on the server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpgradabilityEnum
        {
            /// <summary>
            /// Enum KUpgradable for value: kUpgradable
            /// </summary>
            [EnumMember(Value = "kUpgradable")]
            KUpgradable = 1,

            /// <summary>
            /// Enum KCurrent for value: kCurrent
            /// </summary>
            [EnumMember(Value = "kCurrent")]
            KCurrent = 2,

            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 3,

            /// <summary>
            /// Enum KNonUpgradableInvalidVersion for value: kNonUpgradableInvalidVersion
            /// </summary>
            [EnumMember(Value = "kNonUpgradableInvalidVersion")]
            KNonUpgradableInvalidVersion = 4,

            /// <summary>
            /// Enum KNonUpgradableAgentIsNewer for value: kNonUpgradableAgentIsNewer
            /// </summary>
            [EnumMember(Value = "kNonUpgradableAgentIsNewer")]
            KNonUpgradableAgentIsNewer = 5,

            /// <summary>
            /// Enum KNonUpgradableAgentIsOld for value: kNonUpgradableAgentIsOld
            /// </summary>
            [EnumMember(Value = "kNonUpgradableAgentIsOld")]
            KNonUpgradableAgentIsOld = 6

        }

        /// <summary>
        /// Specifies the upgradability of the agent running on the server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.
        /// </summary>
        /// <value>Specifies the upgradability of the agent running on the server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.</value>
        [DataMember(Name="upgradability", EmitDefaultValue=true)]
        public UpgradabilityEnum? Upgradability { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentStatusResponse" /> class.
        /// </summary>
        /// <param name="compactVersion">Specifies the compact version of Cohesity agent. For example, 6.0.1..</param>
        /// <param name="healthStatus">Specifies the health status of the Cohesity agent. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state..</param>
        /// <param name="hostIp">Specifies the IP of the host on which the agent is installed..</param>
        /// <param name="hostOsType">Specifies the host type on which the agent is installed. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="lastUpgradeStatus">Specifies the status of the last upgrade attempt. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade..</param>
        /// <param name="upgradability">Specifies the upgradability of the agent running on the server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades..</param>
        /// <param name="upgradeStatusMessage">Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade..</param>
        /// <param name="version">Specifies the Cohesity software version of the agent. For example: 6.0.1-release-YYYYMMDD_&lt;hash&gt;.</param>
        public AgentDeploymentStatusResponse(string compactVersion = default(string), HealthStatusEnum? healthStatus = default(HealthStatusEnum?), string hostIp = default(string), HostOsTypeEnum? hostOsType = default(HostOsTypeEnum?), LastUpgradeStatusEnum? lastUpgradeStatus = default(LastUpgradeStatusEnum?), UpgradabilityEnum? upgradability = default(UpgradabilityEnum?), string upgradeStatusMessage = default(string), string version = default(string))
        {
            this.CompactVersion = compactVersion;
            this.HealthStatus = healthStatus;
            this.HostIp = hostIp;
            this.HostOsType = hostOsType;
            this.LastUpgradeStatus = lastUpgradeStatus;
            this.Upgradability = upgradability;
            this.UpgradeStatusMessage = upgradeStatusMessage;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies the compact version of Cohesity agent. For example, 6.0.1.
        /// </summary>
        /// <value>Specifies the compact version of Cohesity agent. For example, 6.0.1.</value>
        [DataMember(Name="compactVersion", EmitDefaultValue=true)]
        public string CompactVersion { get; set; }

        /// <summary>
        /// Specifies the IP of the host on which the agent is installed.
        /// </summary>
        /// <value>Specifies the IP of the host on which the agent is installed.</value>
        [DataMember(Name="hostIp", EmitDefaultValue=true)]
        public string HostIp { get; set; }

        /// <summary>
        /// Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade.
        /// </summary>
        /// <value>Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade.</value>
        [DataMember(Name="upgradeStatusMessage", EmitDefaultValue=true)]
        public string UpgradeStatusMessage { get; set; }

        /// <summary>
        /// Specifies the Cohesity software version of the agent. For example: 6.0.1-release-YYYYMMDD_&lt;hash&gt;
        /// </summary>
        /// <value>Specifies the Cohesity software version of the agent. For example: 6.0.1-release-YYYYMMDD_&lt;hash&gt;</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as AgentDeploymentStatusResponse);
        }

        /// <summary>
        /// Returns true if AgentDeploymentStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AgentDeploymentStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentDeploymentStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompactVersion == input.CompactVersion ||
                    (this.CompactVersion != null &&
                    this.CompactVersion.Equals(input.CompactVersion))
                ) && 
                (
                    this.HealthStatus == input.HealthStatus ||
                    this.HealthStatus.Equals(input.HealthStatus)
                ) && 
                (
                    this.HostIp == input.HostIp ||
                    (this.HostIp != null &&
                    this.HostIp.Equals(input.HostIp))
                ) && 
                (
                    this.HostOsType == input.HostOsType ||
                    this.HostOsType.Equals(input.HostOsType)
                ) && 
                (
                    this.LastUpgradeStatus == input.LastUpgradeStatus ||
                    this.LastUpgradeStatus.Equals(input.LastUpgradeStatus)
                ) && 
                (
                    this.Upgradability == input.Upgradability ||
                    this.Upgradability.Equals(input.Upgradability)
                ) && 
                (
                    this.UpgradeStatusMessage == input.UpgradeStatusMessage ||
                    (this.UpgradeStatusMessage != null &&
                    this.UpgradeStatusMessage.Equals(input.UpgradeStatusMessage))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.CompactVersion != null)
                    hashCode = hashCode * 59 + this.CompactVersion.GetHashCode();
                hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.HostIp != null)
                    hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                hashCode = hashCode * 59 + this.HostOsType.GetHashCode();
                hashCode = hashCode * 59 + this.LastUpgradeStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Upgradability.GetHashCode();
                if (this.UpgradeStatusMessage != null)
                    hashCode = hashCode * 59 + this.UpgradeStatusMessage.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

