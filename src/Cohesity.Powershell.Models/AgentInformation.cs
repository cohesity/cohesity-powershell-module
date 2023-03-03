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
    /// Specifies information about the Agent software running on the server or the Virtual Machine.
    /// </summary>
    [DataContract]
    public partial class AgentInformation :  IEquatable<AgentInformation>
    {
        /// <summary>
        /// Specifies the host type where the agent is running. This is only set for persistent agents. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the host type where the agent is running. This is only set for persistent agents. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
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
        /// Specifies the host type where the agent is running. This is only set for persistent agents. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the host type where the agent is running. This is only set for persistent agents. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.
        /// </summary>
        /// <value>Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
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
        /// Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.
        /// </summary>
        /// <value>Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.
        /// </summary>
        /// <value>Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.</value>
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
        /// Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.
        /// </summary>
        /// <value>Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades.</value>
        [DataMember(Name="upgradability", EmitDefaultValue=true)]
        public UpgradabilityEnum? Upgradability { get; set; }
        /// <summary>
        /// Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.
        /// </summary>
        /// <value>Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpgradeStatusEnum
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
        /// Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.
        /// </summary>
        /// <value>Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade.</value>
        [DataMember(Name="upgradeStatus", EmitDefaultValue=true)]
        public UpgradeStatusEnum? UpgradeStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInformation" /> class.
        /// </summary>
        /// <param name="cbmrVersion">Specifies the version if Cristie BMR product is installed on the host..</param>
        /// <param name="fileCbtInfo">fileCbtInfo.</param>
        /// <param name="hostType">Specifies the host type where the agent is running. This is only set for persistent agents. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="id">Specifies the agent&#39;s id..</param>
        /// <param name="name">Specifies the agent&#39;s name..</param>
        /// <param name="oracleMultiNodeChannelSupported">Specifies whether oracle multi node multi channel is supported or not..</param>
        /// <param name="registrationInfo">registrationInfo.</param>
        /// <param name="sourceSideDedupEnabled">Specifies whether source side dedup is enabled or not..</param>
        /// <param name="status">Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state..</param>
        /// <param name="statusMessage">Specifies additional details about the agent status..</param>
        /// <param name="upgradability">Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades..</param>
        /// <param name="upgradeStatus">Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. &#39;kScheduled&#39; indicates that the Agent is scheduled for upgrade..</param>
        /// <param name="upgradeStatusMessage">Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade..</param>
        /// <param name="version">Specifies the version of the Agent software..</param>
        /// <param name="volCbtInfo">volCbtInfo.</param>
        public AgentInformation(string cbmrVersion = default(string), CbtInfo fileCbtInfo = default(CbtInfo), HostTypeEnum? hostType = default(HostTypeEnum?), long? id = default(long?), string name = default(string), bool? oracleMultiNodeChannelSupported = default(bool?), RegisteredSourceInfo registrationInfo = default(RegisteredSourceInfo), bool? sourceSideDedupEnabled = default(bool?), StatusEnum? status = default(StatusEnum?), string statusMessage = default(string), UpgradabilityEnum? upgradability = default(UpgradabilityEnum?), UpgradeStatusEnum? upgradeStatus = default(UpgradeStatusEnum?), string upgradeStatusMessage = default(string), string version = default(string), CbtInfo volCbtInfo = default(CbtInfo))
        {
            this.CbmrVersion = cbmrVersion;
            this.HostType = hostType;
            this.Id = id;
            this.Name = name;
            this.OracleMultiNodeChannelSupported = oracleMultiNodeChannelSupported;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Upgradability = upgradability;
            this.UpgradeStatus = upgradeStatus;
            this.UpgradeStatusMessage = upgradeStatusMessage;
            this.Version = version;
            this.CbmrVersion = cbmrVersion;
            this.FileCbtInfo = fileCbtInfo;
            this.HostType = hostType;
            this.Id = id;
            this.Name = name;
            this.OracleMultiNodeChannelSupported = oracleMultiNodeChannelSupported;
            this.RegistrationInfo = registrationInfo;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Upgradability = upgradability;
            this.UpgradeStatus = upgradeStatus;
            this.UpgradeStatusMessage = upgradeStatusMessage;
            this.Version = version;
            this.VolCbtInfo = volCbtInfo;
        }
        
        /// <summary>
        /// Specifies the version if Cristie BMR product is installed on the host.
        /// </summary>
        /// <value>Specifies the version if Cristie BMR product is installed on the host.</value>
        [DataMember(Name="cbmrVersion", EmitDefaultValue=true)]
        public string CbmrVersion { get; set; }

        /// <summary>
        /// Gets or Sets FileCbtInfo
        /// </summary>
        [DataMember(Name="fileCbtInfo", EmitDefaultValue=false)]
        public CbtInfo FileCbtInfo { get; set; }

        /// <summary>
        /// Specifies the agent&#39;s id.
        /// </summary>
        /// <value>Specifies the agent&#39;s id.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the agent&#39;s name.
        /// </summary>
        /// <value>Specifies the agent&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether oracle multi node multi channel is supported or not.
        /// </summary>
        /// <value>Specifies whether oracle multi node multi channel is supported or not.</value>
        [DataMember(Name="oracleMultiNodeChannelSupported", EmitDefaultValue=true)]
        public bool? OracleMultiNodeChannelSupported { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationInfo
        /// </summary>
        [DataMember(Name="registrationInfo", EmitDefaultValue=false)]
        public RegisteredSourceInfo RegistrationInfo { get; set; }

        /// <summary>
        /// Specifies whether source side dedup is enabled or not.
        /// </summary>
        /// <value>Specifies whether source side dedup is enabled or not.</value>
        [DataMember(Name="sourceSideDedupEnabled", EmitDefaultValue=true)]
        public bool? SourceSideDedupEnabled { get; set; }

        /// <summary>
        /// Specifies additional details about the agent status.
        /// </summary>
        /// <value>Specifies additional details about the agent status.</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=true)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade.
        /// </summary>
        /// <value>Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade.</value>
        [DataMember(Name="upgradeStatusMessage", EmitDefaultValue=true)]
        public string UpgradeStatusMessage { get; set; }

        /// <summary>
        /// Specifies the version of the Agent software.
        /// </summary>
        /// <value>Specifies the version of the Agent software.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets VolCbtInfo
        /// </summary>
        [DataMember(Name="volCbtInfo", EmitDefaultValue=false)]
        public CbtInfo VolCbtInfo { get; set; }

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
            return this.Equals(input as AgentInformation);
        }

        /// <summary>
        /// Returns true if AgentInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of AgentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CbmrVersion == input.CbmrVersion ||
                    (this.CbmrVersion != null &&
                    this.CbmrVersion.Equals(input.CbmrVersion))
                ) && 
                (
                    this.FileCbtInfo == input.FileCbtInfo ||
                    (this.FileCbtInfo != null &&
                    this.FileCbtInfo.Equals(input.FileCbtInfo))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OracleMultiNodeChannelSupported == input.OracleMultiNodeChannelSupported ||
                    (this.OracleMultiNodeChannelSupported != null &&
                    this.OracleMultiNodeChannelSupported.Equals(input.OracleMultiNodeChannelSupported))
                ) && 
                (
                    this.RegistrationInfo == input.RegistrationInfo ||
                    (this.RegistrationInfo != null &&
                    this.RegistrationInfo.Equals(input.RegistrationInfo))
                ) && 
                (
                    this.SourceSideDedupEnabled == input.SourceSideDedupEnabled ||
                    (this.SourceSideDedupEnabled != null &&
                    this.SourceSideDedupEnabled.Equals(input.SourceSideDedupEnabled))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.Upgradability == input.Upgradability ||
                    this.Upgradability.Equals(input.Upgradability)
                ) && 
                (
                    this.UpgradeStatus == input.UpgradeStatus ||
                    this.UpgradeStatus.Equals(input.UpgradeStatus)
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
                ) && 
                (
                    this.VolCbtInfo == input.VolCbtInfo ||
                    (this.VolCbtInfo != null &&
                    this.VolCbtInfo.Equals(input.VolCbtInfo))
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
                if (this.CbmrVersion != null)
                    hashCode = hashCode * 59 + this.CbmrVersion.GetHashCode();
                if (this.FileCbtInfo != null)
                    hashCode = hashCode * 59 + this.FileCbtInfo.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OracleMultiNodeChannelSupported != null)
                    hashCode = hashCode * 59 + this.OracleMultiNodeChannelSupported.GetHashCode();
                if (this.RegistrationInfo != null)
                    hashCode = hashCode * 59 + this.RegistrationInfo.GetHashCode();
                if (this.SourceSideDedupEnabled != null)
                    hashCode = hashCode * 59 + this.SourceSideDedupEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                hashCode = hashCode * 59 + this.Upgradability.GetHashCode();
                hashCode = hashCode * 59 + this.UpgradeStatus.GetHashCode();
                if (this.UpgradeStatusMessage != null)
                    hashCode = hashCode * 59 + this.UpgradeStatusMessage.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VolCbtInfo != null)
                    hashCode = hashCode * 59 + this.VolCbtInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

