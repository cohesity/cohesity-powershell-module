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
    /// InfectedFileParam
    /// </summary>
    [DataContract]
    public partial class InfectedFileParam :  IEquatable<InfectedFileParam>
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
        /// Initializes a new instance of the <see cref="InfectedFileParam" /> class.
        /// </summary>
        /// <param name="entityId">Specifies the entity id of the infected file..</param>
        /// <param name="remediationState">Specifies the remediation state of the file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset..</param>
        /// <param name="rootInodeId">Specifies the root inode id of the file system that infected file belongs to..</param>
        /// <param name="viewId">Specifies the id of the View the infected file belongs to..</param>
        public InfectedFileParam(long? entityId = default(long?), RemediationStateEnum? remediationState = default(RemediationStateEnum?), long? rootInodeId = default(long?), long? viewId = default(long?))
        {
            this.EntityId = entityId;
            this.RemediationState = remediationState;
            this.RootInodeId = rootInodeId;
            this.ViewId = viewId;
            this.EntityId = entityId;
            this.RemediationState = remediationState;
            this.RootInodeId = rootInodeId;
            this.ViewId = viewId;
        }
        
        /// <summary>
        /// Specifies the entity id of the infected file.
        /// </summary>
        /// <value>Specifies the entity id of the infected file.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies the root inode id of the file system that infected file belongs to.
        /// </summary>
        /// <value>Specifies the root inode id of the file system that infected file belongs to.</value>
        [DataMember(Name="rootInodeId", EmitDefaultValue=true)]
        public long? RootInodeId { get; set; }

        /// <summary>
        /// Specifies the id of the View the infected file belongs to.
        /// </summary>
        /// <value>Specifies the id of the View the infected file belongs to.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfectedFileParam {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  RemediationState: ").Append(RemediationState).Append("\n");
            sb.Append("  RootInodeId: ").Append(RootInodeId).Append("\n");
            sb.Append("  ViewId: ").Append(ViewId).Append("\n");
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
            return this.Equals(input as InfectedFileParam);
        }

        /// <summary>
        /// Returns true if InfectedFileParam instances are equal
        /// </summary>
        /// <param name="input">Instance of InfectedFileParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfectedFileParam input)
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
                    this.RemediationState == input.RemediationState ||
                    this.RemediationState.Equals(input.RemediationState)
                ) && 
                (
                    this.RootInodeId == input.RootInodeId ||
                    (this.RootInodeId != null &&
                    this.RootInodeId.Equals(input.RootInodeId))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
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
                hashCode = hashCode * 59 + this.RemediationState.GetHashCode();
                if (this.RootInodeId != null)
                    hashCode = hashCode * 59 + this.RootInodeId.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}
