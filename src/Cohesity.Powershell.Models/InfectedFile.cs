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
    /// Specifies the Result parameters for all infected files.
    /// </summary>
    [DataContract]
    public partial class InfectedFile :  IEquatable<InfectedFile>
    {
        /// <summary>
        /// Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.
        /// </summary>
        /// <value>Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemediationStateEnum
        {
            /// <summary>
            /// Enum KQuarantine for value: kQuarantine
            /// </summary>
            [EnumMember(Value = "kQuarantine")]
            KQuarantine = 1,

            /// <summary>
            /// Enum KUnquarantine for value: kUnquarantine
            /// </summary>
            [EnumMember(Value = "kUnquarantine")]
            KUnquarantine = 2

        }

        /// <summary>
        /// Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.
        /// </summary>
        /// <value>Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.</value>
        [DataMember(Name="remediationState", EmitDefaultValue=true)]
        public RemediationStateEnum? RemediationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfectedFile" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the entity id of the infected file..</param>
        /// <param name="filePath">Specifies file path of the infected file..</param>
        /// <param name="infectionDetectionTimestamp">Specifies unix epoch timestamp (in microseconds) at which these threats were detected..</param>
        /// <param name="modifiedTimestampUsecs">Specifies unix epoch timestamp (in microseconds) at which this file is modified..</param>
        /// <param name="remediationState">Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset..</param>
        /// <param name="rootInodeId">Specifies the root inode id of the file system that infected file belongs to..</param>
        /// <param name="scanTimestampUsecs">Specifies unix epoch timestamp (in microseconds) at which inode was scanned for viruses..</param>
        /// <param name="serviceIcapUri">Specifies the instance of an antivirus ICAP server in the cluster config that detected these threats..</param>
        /// <param name="threatDescriptions">Specifies the list of virus threat descriptions found in the file..</param>
        /// <param name="viewId">Specifies the id of the View the infected file belongs to..</param>
        /// <param name="viewName">Specifies the View name corresponding to above view id..</param>
        public InfectedFile(long? entityId = default(long?), string filePath = default(string), long? infectionDetectionTimestamp = default(long?), long? modifiedTimestampUsecs = default(long?), RemediationStateEnum? remediationState = default(RemediationStateEnum?), long? rootInodeId = default(long?), long? scanTimestampUsecs = default(long?), string serviceIcapUri = default(string), List<string> threatDescriptions = default(List<string>), long? viewId = default(long?), string viewName = default(string))
        {
            this.EntityId = entityId;
            this.FilePath = filePath;
            this.InfectionDetectionTimestamp = infectionDetectionTimestamp;
            this.ModifiedTimestampUsecs = modifiedTimestampUsecs;
            this.RemediationState = remediationState;
            this.RootInodeId = rootInodeId;
            this.ScanTimestampUsecs = scanTimestampUsecs;
            this.ServiceIcapUri = serviceIcapUri;
            this.ThreatDescriptions = threatDescriptions;
            this.ViewId = viewId;
            this.ViewName = viewName;
            this.EntityId = entityId;
            this.FilePath = filePath;
            this.InfectionDetectionTimestamp = infectionDetectionTimestamp;
            this.ModifiedTimestampUsecs = modifiedTimestampUsecs;
            this.RemediationState = remediationState;
            this.RootInodeId = rootInodeId;
            this.ScanTimestampUsecs = scanTimestampUsecs;
            this.ServiceIcapUri = serviceIcapUri;
            this.ThreatDescriptions = threatDescriptions;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the entity id of the infected file.
        /// </summary>
        /// <value>Specifies the entity id of the infected file.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies file path of the infected file.
        /// </summary>
        /// <value>Specifies file path of the infected file.</value>
        [DataMember(Name="filePath", EmitDefaultValue=true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Specifies unix epoch timestamp (in microseconds) at which these threats were detected.
        /// </summary>
        /// <value>Specifies unix epoch timestamp (in microseconds) at which these threats were detected.</value>
        [DataMember(Name="infectionDetectionTimestamp", EmitDefaultValue=true)]
        public long? InfectionDetectionTimestamp { get; set; }

        /// <summary>
        /// Specifies unix epoch timestamp (in microseconds) at which this file is modified.
        /// </summary>
        /// <value>Specifies unix epoch timestamp (in microseconds) at which this file is modified.</value>
        [DataMember(Name="modifiedTimestampUsecs", EmitDefaultValue=true)]
        public long? ModifiedTimestampUsecs { get; set; }

        /// <summary>
        /// Specifies the root inode id of the file system that infected file belongs to.
        /// </summary>
        /// <value>Specifies the root inode id of the file system that infected file belongs to.</value>
        [DataMember(Name="rootInodeId", EmitDefaultValue=true)]
        public long? RootInodeId { get; set; }

        /// <summary>
        /// Specifies unix epoch timestamp (in microseconds) at which inode was scanned for viruses.
        /// </summary>
        /// <value>Specifies unix epoch timestamp (in microseconds) at which inode was scanned for viruses.</value>
        [DataMember(Name="scanTimestampUsecs", EmitDefaultValue=true)]
        public long? ScanTimestampUsecs { get; set; }

        /// <summary>
        /// Specifies the instance of an antivirus ICAP server in the cluster config that detected these threats.
        /// </summary>
        /// <value>Specifies the instance of an antivirus ICAP server in the cluster config that detected these threats.</value>
        [DataMember(Name="serviceIcapUri", EmitDefaultValue=true)]
        public string ServiceIcapUri { get; set; }

        /// <summary>
        /// Specifies the list of virus threat descriptions found in the file.
        /// </summary>
        /// <value>Specifies the list of virus threat descriptions found in the file.</value>
        [DataMember(Name="threatDescriptions", EmitDefaultValue=true)]
        public List<string> ThreatDescriptions { get; set; }

        /// <summary>
        /// Specifies the id of the View the infected file belongs to.
        /// </summary>
        /// <value>Specifies the id of the View the infected file belongs to.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies the View name corresponding to above view id.
        /// </summary>
        /// <value>Specifies the View name corresponding to above view id.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfectedFile {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  InfectionDetectionTimestamp: ").Append(InfectionDetectionTimestamp).Append("\n");
            sb.Append("  ModifiedTimestampUsecs: ").Append(ModifiedTimestampUsecs).Append("\n");
            sb.Append("  RemediationState: ").Append(RemediationState).Append("\n");
            sb.Append("  RootInodeId: ").Append(RootInodeId).Append("\n");
            sb.Append("  ScanTimestampUsecs: ").Append(ScanTimestampUsecs).Append("\n");
            sb.Append("  ServiceIcapUri: ").Append(ServiceIcapUri).Append("\n");
            sb.Append("  ThreatDescriptions: ").Append(ThreatDescriptions).Append("\n");
            sb.Append("  ViewId: ").Append(ViewId).Append("\n");
            sb.Append("  ViewName: ").Append(ViewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as InfectedFile);
        }

        /// <summary>
        /// Returns true if InfectedFile instances are equal
        /// </summary>
        /// <param name="input">Instance of InfectedFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfectedFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.InfectionDetectionTimestamp == input.InfectionDetectionTimestamp ||
                    (this.InfectionDetectionTimestamp != null &&
                    this.InfectionDetectionTimestamp.Equals(input.InfectionDetectionTimestamp))
                ) && 
                (
                    this.ModifiedTimestampUsecs == input.ModifiedTimestampUsecs ||
                    (this.ModifiedTimestampUsecs != null &&
                    this.ModifiedTimestampUsecs.Equals(input.ModifiedTimestampUsecs))
                ) && 
                (
                    this.RemediationState == input.RemediationState ||
                    this.RemediationState.Equals(input.RemediationState)
                ) && 
                (
                    this.RootInodeId == input.RootInodeId ||
                    (this.RootInodeId != null &&
                    this.RootInodeId.Equals(input.RootInodeId))
                ) && 
                (
                    this.ScanTimestampUsecs == input.ScanTimestampUsecs ||
                    (this.ScanTimestampUsecs != null &&
                    this.ScanTimestampUsecs.Equals(input.ScanTimestampUsecs))
                ) && 
                (
                    this.ServiceIcapUri == input.ServiceIcapUri ||
                    (this.ServiceIcapUri != null &&
                    this.ServiceIcapUri.Equals(input.ServiceIcapUri))
                ) && 
                (
                    this.ThreatDescriptions == input.ThreatDescriptions ||
                    this.ThreatDescriptions != null &&
                    input.ThreatDescriptions != null &&
                    this.ThreatDescriptions.SequenceEqual(input.ThreatDescriptions)
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.InfectionDetectionTimestamp != null)
                    hashCode = hashCode * 59 + this.InfectionDetectionTimestamp.GetHashCode();
                if (this.ModifiedTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.ModifiedTimestampUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.RemediationState.GetHashCode();
                if (this.RootInodeId != null)
                    hashCode = hashCode * 59 + this.RootInodeId.GetHashCode();
                if (this.ScanTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.ScanTimestampUsecs.GetHashCode();
                if (this.ServiceIcapUri != null)
                    hashCode = hashCode * 59 + this.ServiceIcapUri.GetHashCode();
                if (this.ThreatDescriptions != null)
                    hashCode = hashCode * 59 + this.ThreatDescriptions.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}
