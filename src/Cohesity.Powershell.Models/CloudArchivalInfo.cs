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
    /// Specifies the cloud archival for active and finished tasks.
    /// </summary>
    [DataContract]
    public partial class CloudArchivalInfo :  IEquatable<CloudArchivalInfo>
    {
        /// <summary>
        /// Specifies the public status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the public status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PublicStatusEnum
        {
            /// <summary>
            /// Enum KAccepted for value: kAccepted
            /// </summary>
            [EnumMember(Value = "kAccepted")]
            KAccepted = 1,

            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,

            /// <summary>
            /// Enum KCanceling for value: kCanceling
            /// </summary>
            [EnumMember(Value = "kCanceling")]
            KCanceling = 3,

            /// <summary>
            /// Enum KCanceled for value: kCanceled
            /// </summary>
            [EnumMember(Value = "kCanceled")]
            KCanceled = 4,

            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 5,

            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 6,

            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 7,

            /// <summary>
            /// Enum KOnHold for value: kOnHold
            /// </summary>
            [EnumMember(Value = "kOnHold")]
            KOnHold = 8,

            /// <summary>
            /// Enum KMissed for value: kMissed
            /// </summary>
            [EnumMember(Value = "kMissed")]
            KMissed = 9,

            /// <summary>
            /// Enum KFinalizing for value: kFinalizing
            /// </summary>
            [EnumMember(Value = "kFinalizing")]
            KFinalizing = 10

        }

        /// <summary>
        /// Specifies the public status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the public status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
        [DataMember(Name="publicStatus", EmitDefaultValue=true)]
        public PublicStatusEnum? PublicStatus { get; set; }
        /// <summary>
        /// Specifies the status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum KAccepted for value: kAccepted
            /// </summary>
            [EnumMember(Value = "kAccepted")]
            KAccepted = 1,

            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,

            /// <summary>
            /// Enum KCanceling for value: kCanceling
            /// </summary>
            [EnumMember(Value = "kCanceling")]
            KCanceling = 3,

            /// <summary>
            /// Enum KCanceled for value: kCanceled
            /// </summary>
            [EnumMember(Value = "kCanceled")]
            KCanceled = 4,

            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 5,

            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 6,

            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 7,

            /// <summary>
            /// Enum KOnHold for value: kOnHold
            /// </summary>
            [EnumMember(Value = "kOnHold")]
            KOnHold = 8,

            /// <summary>
            /// Enum KMissed for value: kMissed
            /// </summary>
            [EnumMember(Value = "kMissed")]
            KMissed = 9,

            /// <summary>
            /// Enum KFinalizing for value: kFinalizing
            /// </summary>
            [EnumMember(Value = "kFinalizing")]
            KFinalizing = 10

        }

        /// <summary>
        /// Specifies the status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).
        /// </summary>
        /// <value>Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultTypeEnum
        {
            /// <summary>
            /// Enum KCloud for value: kCloud
            /// </summary>
            [EnumMember(Value = "kCloud")]
            KCloud = 1,

            /// <summary>
            /// Enum KTape for value: kTape
            /// </summary>
            [EnumMember(Value = "kTape")]
            KTape = 2,

            /// <summary>
            /// Enum KNas for value: kNas
            /// </summary>
            [EnumMember(Value = "kNas")]
            KNas = 3

        }

        /// <summary>
        /// Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).
        /// </summary>
        /// <value>Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas).</value>
        [DataMember(Name="vaultType", EmitDefaultValue=true)]
        public VaultTypeEnum? VaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudArchivalInfo" /> class.
        /// </summary>
        /// <param name="isActiveTask">Specifies if the task if active or finished..</param>
        /// <param name="publicStatus">Specifies the public status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing..</param>
        /// <param name="status">Specifies the status type. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing..</param>
        /// <param name="vaultId">Specifies the id of Archival Vault assigned by the Cohesity Cluster..</param>
        /// <param name="vaultName">Name of the Archival Vault..</param>
        /// <param name="vaultType">Specifies the type of the Archival External Target such as &#39;kCloud&#39;, &#39;kTape&#39; or &#39;kNas&#39;. &#39;kCloud&#39; indicates the archival location as Cloud. &#39;kTape&#39; indicates the archival location as Tape. &#39;kNas&#39; indicates the archival location as Network Attached Storage (Nas)..</param>
        public CloudArchivalInfo(bool? isActiveTask = default(bool?), PublicStatusEnum? publicStatus = default(PublicStatusEnum?), StatusEnum? status = default(StatusEnum?), long? vaultId = default(long?), string vaultName = default(string), VaultTypeEnum? vaultType = default(VaultTypeEnum?))
        {
            this.IsActiveTask = isActiveTask;
            this.PublicStatus = publicStatus;
            this.Status = status;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.VaultType = vaultType;
            this.IsActiveTask = isActiveTask;
            this.PublicStatus = publicStatus;
            this.Status = status;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
            this.VaultType = vaultType;
        }
        
        /// <summary>
        /// Specifies if the task if active or finished.
        /// </summary>
        /// <value>Specifies if the task if active or finished.</value>
        [DataMember(Name="isActiveTask", EmitDefaultValue=true)]
        public bool? IsActiveTask { get; set; }

        /// <summary>
        /// Specifies the id of Archival Vault assigned by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the id of Archival Vault assigned by the Cohesity Cluster.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Name of the Archival Vault.
        /// </summary>
        /// <value>Name of the Archival Vault.</value>
        [DataMember(Name="vaultName", EmitDefaultValue=true)]
        public string VaultName { get; set; }

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
            return this.Equals(input as CloudArchivalInfo);
        }

        /// <summary>
        /// Returns true if CloudArchivalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudArchivalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudArchivalInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsActiveTask == input.IsActiveTask ||
                    (this.IsActiveTask != null &&
                    this.IsActiveTask.Equals(input.IsActiveTask))
                ) && 
                (
                    this.PublicStatus == input.PublicStatus ||
                    this.PublicStatus.Equals(input.PublicStatus)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
                ) && 
                (
                    this.VaultType == input.VaultType ||
                    this.VaultType.Equals(input.VaultType)
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
                if (this.IsActiveTask != null)
                    hashCode = hashCode * 59 + this.IsActiveTask.GetHashCode();
                hashCode = hashCode * 59 + this.PublicStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                hashCode = hashCode * 59 + this.VaultType.GetHashCode();
                return hashCode;
            }
        }

    }

}

