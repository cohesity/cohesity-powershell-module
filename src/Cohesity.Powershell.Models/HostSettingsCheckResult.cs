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
    /// Specifies the result of various checks performed internally on host.
    /// </summary>
    [DataContract]
    public partial class HostSettingsCheckResult :  IEquatable<HostSettingsCheckResult>
    {
        /// <summary>
        /// Specifies the type of the check internally performed. Specifies the type of the host check performed internally. &#39;kIsAgentPortAccessible&#39; indicates the check for agent port access. &#39;kIsAgentRunning&#39; indicates the status for the Cohesity agent service. &#39;kIsSQLWriterRunningCheck&#39; indicates the status for SQLWriter service. &#39;kAreSQLInstancesRunning&#39; indicates the run status for for all the SQL instances in the host. &#39;kCheckServiceLoginsConfig&#39; checks the privileges and sysadmin status of the logins used by the SQL instance services, Cohesity agent service and the SQLWriter service.
        /// </summary>
        /// <value>Specifies the type of the check internally performed. Specifies the type of the host check performed internally. &#39;kIsAgentPortAccessible&#39; indicates the check for agent port access. &#39;kIsAgentRunning&#39; indicates the status for the Cohesity agent service. &#39;kIsSQLWriterRunningCheck&#39; indicates the status for SQLWriter service. &#39;kAreSQLInstancesRunning&#39; indicates the run status for for all the SQL instances in the host. &#39;kCheckServiceLoginsConfig&#39; checks the privileges and sysadmin status of the logins used by the SQL instance services, Cohesity agent service and the SQLWriter service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CheckTypeEnum
        {
            /// <summary>
            /// Enum KIsAgentPortAccessible for value: kIsAgentPortAccessible
            /// </summary>
            [EnumMember(Value = "kIsAgentPortAccessible")]
            KIsAgentPortAccessible = 1,

            /// <summary>
            /// Enum KIsAgentRunning for value: kIsAgentRunning
            /// </summary>
            [EnumMember(Value = "kIsAgentRunning")]
            KIsAgentRunning = 2,

            /// <summary>
            /// Enum KIsSQLWriterRunningCheck for value: kIsSQLWriterRunningCheck
            /// </summary>
            [EnumMember(Value = "kIsSQLWriterRunningCheck")]
            KIsSQLWriterRunningCheck = 3,

            /// <summary>
            /// Enum KAreSQLInstancesRunning for value: kAreSQLInstancesRunning
            /// </summary>
            [EnumMember(Value = "kAreSQLInstancesRunning")]
            KAreSQLInstancesRunning = 4,

            /// <summary>
            /// Enum KCheckServiceLoginsConfig for value: kCheckServiceLoginsConfig
            /// </summary>
            [EnumMember(Value = "kCheckServiceLoginsConfig")]
            KCheckServiceLoginsConfig = 5

        }

        /// <summary>
        /// Specifies the type of the check internally performed. Specifies the type of the host check performed internally. &#39;kIsAgentPortAccessible&#39; indicates the check for agent port access. &#39;kIsAgentRunning&#39; indicates the status for the Cohesity agent service. &#39;kIsSQLWriterRunningCheck&#39; indicates the status for SQLWriter service. &#39;kAreSQLInstancesRunning&#39; indicates the run status for for all the SQL instances in the host. &#39;kCheckServiceLoginsConfig&#39; checks the privileges and sysadmin status of the logins used by the SQL instance services, Cohesity agent service and the SQLWriter service.
        /// </summary>
        /// <value>Specifies the type of the check internally performed. Specifies the type of the host check performed internally. &#39;kIsAgentPortAccessible&#39; indicates the check for agent port access. &#39;kIsAgentRunning&#39; indicates the status for the Cohesity agent service. &#39;kIsSQLWriterRunningCheck&#39; indicates the status for SQLWriter service. &#39;kAreSQLInstancesRunning&#39; indicates the run status for for all the SQL instances in the host. &#39;kCheckServiceLoginsConfig&#39; checks the privileges and sysadmin status of the logins used by the SQL instance services, Cohesity agent service and the SQLWriter service.</value>
        [DataMember(Name="checkType", EmitDefaultValue=true)]
        public CheckTypeEnum? CheckType { get; set; }
        /// <summary>
        /// Specifies the type of the result returned after performing the internal host check. Specifies the type of the host check result performed internally. &#39;kPass&#39; indicates that the respective check was successful. &#39;kFail&#39; indicates that the respective check failed as some mandatory setting is not met &#39;kWarning&#39; indicates that the respective check has warning as certain non-mandatory setting is not met.
        /// </summary>
        /// <value>Specifies the type of the result returned after performing the internal host check. Specifies the type of the host check result performed internally. &#39;kPass&#39; indicates that the respective check was successful. &#39;kFail&#39; indicates that the respective check failed as some mandatory setting is not met &#39;kWarning&#39; indicates that the respective check has warning as certain non-mandatory setting is not met.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultTypeEnum
        {
            /// <summary>
            /// Enum KPass for value: kPass
            /// </summary>
            [EnumMember(Value = "kPass")]
            KPass = 1,

            /// <summary>
            /// Enum KFail for value: kFail
            /// </summary>
            [EnumMember(Value = "kFail")]
            KFail = 2,

            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 3

        }

        /// <summary>
        /// Specifies the type of the result returned after performing the internal host check. Specifies the type of the host check result performed internally. &#39;kPass&#39; indicates that the respective check was successful. &#39;kFail&#39; indicates that the respective check failed as some mandatory setting is not met &#39;kWarning&#39; indicates that the respective check has warning as certain non-mandatory setting is not met.
        /// </summary>
        /// <value>Specifies the type of the result returned after performing the internal host check. Specifies the type of the host check result performed internally. &#39;kPass&#39; indicates that the respective check was successful. &#39;kFail&#39; indicates that the respective check failed as some mandatory setting is not met &#39;kWarning&#39; indicates that the respective check has warning as certain non-mandatory setting is not met.</value>
        [DataMember(Name="resultType", EmitDefaultValue=true)]
        public ResultTypeEnum? ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostSettingsCheckResult" /> class.
        /// </summary>
        /// <param name="checkType">Specifies the type of the check internally performed. Specifies the type of the host check performed internally. &#39;kIsAgentPortAccessible&#39; indicates the check for agent port access. &#39;kIsAgentRunning&#39; indicates the status for the Cohesity agent service. &#39;kIsSQLWriterRunningCheck&#39; indicates the status for SQLWriter service. &#39;kAreSQLInstancesRunning&#39; indicates the run status for for all the SQL instances in the host. &#39;kCheckServiceLoginsConfig&#39; checks the privileges and sysadmin status of the logins used by the SQL instance services, Cohesity agent service and the SQLWriter service..</param>
        /// <param name="resultType">Specifies the type of the result returned after performing the internal host check. Specifies the type of the host check result performed internally. &#39;kPass&#39; indicates that the respective check was successful. &#39;kFail&#39; indicates that the respective check failed as some mandatory setting is not met &#39;kWarning&#39; indicates that the respective check has warning as certain non-mandatory setting is not met..</param>
        /// <param name="userMessage">Specifies a descriptive message for failed/warning types..</param>
        public HostSettingsCheckResult(CheckTypeEnum? checkType = default(CheckTypeEnum?), ResultTypeEnum? resultType = default(ResultTypeEnum?), string userMessage = default(string))
        {
            this.CheckType = checkType;
            this.ResultType = resultType;
            this.UserMessage = userMessage;
            this.CheckType = checkType;
            this.ResultType = resultType;
            this.UserMessage = userMessage;
        }
        
        /// <summary>
        /// Specifies a descriptive message for failed/warning types.
        /// </summary>
        /// <value>Specifies a descriptive message for failed/warning types.</value>
        [DataMember(Name="userMessage", EmitDefaultValue=true)]
        public string UserMessage { get; set; }

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
            return this.Equals(input as HostSettingsCheckResult);
        }

        /// <summary>
        /// Returns true if HostSettingsCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HostSettingsCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostSettingsCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckType == input.CheckType ||
                    this.CheckType.Equals(input.CheckType)
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    this.ResultType.Equals(input.ResultType)
                ) && 
                (
                    this.UserMessage == input.UserMessage ||
                    (this.UserMessage != null &&
                    this.UserMessage.Equals(input.UserMessage))
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
                hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                hashCode = hashCode * 59 + this.ResultType.GetHashCode();
                if (this.UserMessage != null)
                    hashCode = hashCode * 59 + this.UserMessage.GetHashCode();
                return hashCode;
            }
        }

    }

}

