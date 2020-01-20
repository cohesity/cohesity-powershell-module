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
    /// Specifies the state of licensing workflow.
    /// </summary>
    [DataContract]
    public partial class LicenseState :  IEquatable<LicenseState>
    {
        /// <summary>
        /// Specifies the current state of licensing workflow. LicenseStateType specifies the licenseState type. &#39;kInProgressNewCluster&#39; indicates licensing server claim is in progress for &#39;New&#39; Cluster. &#39;kInProgressOldCluster&#39; indicates licensing server claim is in progress for &#39;Old&#39; Cluster. &#39;kClaimed&#39; indicates licensing server is claimed. &#39;kSkipped&#39; indicates licensing workflow has been skipped. &#39;kStarted&#39; indicates licensing UI workflow has started.
        /// </summary>
        /// <value>Specifies the current state of licensing workflow. LicenseStateType specifies the licenseState type. &#39;kInProgressNewCluster&#39; indicates licensing server claim is in progress for &#39;New&#39; Cluster. &#39;kInProgressOldCluster&#39; indicates licensing server claim is in progress for &#39;Old&#39; Cluster. &#39;kClaimed&#39; indicates licensing server is claimed. &#39;kSkipped&#39; indicates licensing workflow has been skipped. &#39;kStarted&#39; indicates licensing UI workflow has started.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum KInProgressNewCluster for value: kInProgressNewCluster
            /// </summary>
            [EnumMember(Value = "kInProgressNewCluster")]
            KInProgressNewCluster = 1,

            /// <summary>
            /// Enum KInProgressOldCluster for value: kInProgressOldCluster
            /// </summary>
            [EnumMember(Value = "kInProgressOldCluster")]
            KInProgressOldCluster = 2,

            /// <summary>
            /// Enum KClaimed for value: kClaimed
            /// </summary>
            [EnumMember(Value = "kClaimed")]
            KClaimed = 3,

            /// <summary>
            /// Enum KSkipped for value: kSkipped
            /// </summary>
            [EnumMember(Value = "kSkipped")]
            KSkipped = 4,

            /// <summary>
            /// Enum KStarted for value: kStarted
            /// </summary>
            [EnumMember(Value = "kStarted")]
            KStarted = 5

        }

        /// <summary>
        /// Specifies the current state of licensing workflow. LicenseStateType specifies the licenseState type. &#39;kInProgressNewCluster&#39; indicates licensing server claim is in progress for &#39;New&#39; Cluster. &#39;kInProgressOldCluster&#39; indicates licensing server claim is in progress for &#39;Old&#39; Cluster. &#39;kClaimed&#39; indicates licensing server is claimed. &#39;kSkipped&#39; indicates licensing workflow has been skipped. &#39;kStarted&#39; indicates licensing UI workflow has started.
        /// </summary>
        /// <value>Specifies the current state of licensing workflow. LicenseStateType specifies the licenseState type. &#39;kInProgressNewCluster&#39; indicates licensing server claim is in progress for &#39;New&#39; Cluster. &#39;kInProgressOldCluster&#39; indicates licensing server claim is in progress for &#39;Old&#39; Cluster. &#39;kClaimed&#39; indicates licensing server is claimed. &#39;kSkipped&#39; indicates licensing workflow has been skipped. &#39;kStarted&#39; indicates licensing UI workflow has started.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseState" /> class.
        /// </summary>
        /// <param name="failedAttempts">Specifies no of failed attempts at claiming the license server.</param>
        /// <param name="state">Specifies the current state of licensing workflow. LicenseStateType specifies the licenseState type. &#39;kInProgressNewCluster&#39; indicates licensing server claim is in progress for &#39;New&#39; Cluster. &#39;kInProgressOldCluster&#39; indicates licensing server claim is in progress for &#39;Old&#39; Cluster. &#39;kClaimed&#39; indicates licensing server is claimed. &#39;kSkipped&#39; indicates licensing workflow has been skipped. &#39;kStarted&#39; indicates licensing UI workflow has started..</param>
        public LicenseState(long? failedAttempts = default(long?), StateEnum? state = default(StateEnum?))
        {
            this.FailedAttempts = failedAttempts;
            this.State = state;
            this.FailedAttempts = failedAttempts;
            this.State = state;
        }
        
        /// <summary>
        /// Specifies no of failed attempts at claiming the license server
        /// </summary>
        /// <value>Specifies no of failed attempts at claiming the license server</value>
        [DataMember(Name="failedAttempts", EmitDefaultValue=true)]
        public long? FailedAttempts { get; set; }

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
            return this.Equals(input as LicenseState);
        }

        /// <summary>
        /// Returns true if LicenseState instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailedAttempts == input.FailedAttempts ||
                    (this.FailedAttempts != null &&
                    this.FailedAttempts.Equals(input.FailedAttempts))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.FailedAttempts != null)
                    hashCode = hashCode * 59 + this.FailedAttempts.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}

