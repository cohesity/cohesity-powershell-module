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
    /// UpdateInfectedFileParams
    /// </summary>
    [DataContract]
    public partial class UpdateInfectedFileParams :  IEquatable<UpdateInfectedFileParams>
    {
        /// <summary>
        /// Specifies the remediation state of the file. Not setting any value to remediation state will reset the infected file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.
        /// </summary>
        /// <value>Specifies the remediation state of the file. Not setting any value to remediation state will reset the infected file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.</value>
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
        /// Specifies the remediation state of the file. Not setting any value to remediation state will reset the infected file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.
        /// </summary>
        /// <value>Specifies the remediation state of the file. Not setting any value to remediation state will reset the infected file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset.</value>
        [DataMember(Name="remediationState", EmitDefaultValue=true)]
        public RemediationStateEnum? RemediationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInfectedFileParams" /> class.
        /// </summary>
        /// <param name="infectedFileIds">Specifies the list of infected file identifiers..</param>
        /// <param name="remediationState">Specifies the remediation state of the file. Not setting any value to remediation state will reset the infected file. Remediation State. &#39;kQuarantine&#39; indicates &#39;Quarantine&#39; state of the file. This state blocks the client access. The administrator will have to manually delete, rescan or unquarantine the file. &#39;kUnquarantine&#39; indicates &#39;Unquarantine&#39; state of the file. The administrator has manually moved files from quarantined to the unquarantined state to allow client access. Unquarantined files are not scanned for virus until manually reset..</param>
        public UpdateInfectedFileParams(List<InfectedFileParam> infectedFileIds = default(List<InfectedFileParam>), RemediationStateEnum? remediationState = default(RemediationStateEnum?))
        {
            this.InfectedFileIds = infectedFileIds;
            this.RemediationState = remediationState;
            this.InfectedFileIds = infectedFileIds;
            this.RemediationState = remediationState;
        }
        
        /// <summary>
        /// Specifies the list of infected file identifiers.
        /// </summary>
        /// <value>Specifies the list of infected file identifiers.</value>
        [DataMember(Name="infectedFileIds", EmitDefaultValue=true)]
        public List<InfectedFileParam> InfectedFileIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInfectedFileParams {\n");
            sb.Append("  InfectedFileIds: ").Append(InfectedFileIds).Append("\n");
            sb.Append("  RemediationState: ").Append(RemediationState).Append("\n");
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
            return this.Equals(input as UpdateInfectedFileParams);
        }

        /// <summary>
        /// Returns true if UpdateInfectedFileParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInfectedFileParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInfectedFileParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InfectedFileIds == input.InfectedFileIds ||
                    this.InfectedFileIds != null &&
                    input.InfectedFileIds != null &&
                    this.InfectedFileIds.SequenceEqual(input.InfectedFileIds)
                ) && 
                (
                    this.RemediationState == input.RemediationState ||
                    this.RemediationState.Equals(input.RemediationState)
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
                if (this.InfectedFileIds != null)
                    hashCode = hashCode * 59 + this.InfectedFileIds.GetHashCode();
                hashCode = hashCode * 59 + this.RemediationState.GetHashCode();
                return hashCode;
            }
        }

    }

}
