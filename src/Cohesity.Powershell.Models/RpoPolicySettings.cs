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
    /// Specifies all the additional settings that are applicable only to an RPO policy. This can include storage domain, settings of different environments, etc.
    /// </summary>
    [DataContract]
    public partial class RpoPolicySettings :  IEquatable<RpoPolicySettings>
    {
        /// <summary>
        /// Defines AlertingPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertingPolicyEnum
        {
            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 1,

            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 2,

            /// <summary>
            /// Enum KSlaViolation for value: kSlaViolation
            /// </summary>
            [EnumMember(Value = "kSlaViolation")]
            KSlaViolation = 3

        }


        /// <summary>
        /// Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.
        /// </summary>
        /// <value>Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.</value>
        [DataMember(Name="alertingPolicy", EmitDefaultValue=true)]
        public List<AlertingPolicyEnum> AlertingPolicy { get; set; }
        /// <summary>
        /// Specifies the QoS policy type to use. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. &#39;kTestAndDevHigh&#39; indicated the test and dev workload. &#39;kBackupAll&#39; indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.
        /// </summary>
        /// <value>Specifies the QoS policy type to use. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. &#39;kTestAndDevHigh&#39; indicated the test and dev workload. &#39;kBackupAll&#39; indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QosTypeEnum
        {
            /// <summary>
            /// Enum KBackupHDD for value: kBackupHDD
            /// </summary>
            [EnumMember(Value = "kBackupHDD")]
            KBackupHDD = 1,

            /// <summary>
            /// Enum KBackupSSD for value: kBackupSSD
            /// </summary>
            [EnumMember(Value = "kBackupSSD")]
            KBackupSSD = 2,

            /// <summary>
            /// Enum KTestAndDevHigh for value: kTestAndDevHigh
            /// </summary>
            [EnumMember(Value = "kTestAndDevHigh")]
            KTestAndDevHigh = 3,

            /// <summary>
            /// Enum KBackupAll for value: kBackupAll
            /// </summary>
            [EnumMember(Value = "kBackupAll")]
            KBackupAll = 4

        }

        /// <summary>
        /// Specifies the QoS policy type to use. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. &#39;kTestAndDevHigh&#39; indicated the test and dev workload. &#39;kBackupAll&#39; indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.
        /// </summary>
        /// <value>Specifies the QoS policy type to use. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. &#39;kTestAndDevHigh&#39; indicated the test and dev workload. &#39;kBackupAll&#39; indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job.</value>
        [DataMember(Name="qosType", EmitDefaultValue=true)]
        public QosTypeEnum? QosType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpoPolicySettings" /> class.
        /// </summary>
        /// <param name="alertingConfig">alertingConfig.</param>
        /// <param name="alertingPolicy">Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA..</param>
        /// <param name="environmentTypeJobParams">environmentTypeJobParams.</param>
        /// <param name="indexingPolicy">indexingPolicy.</param>
        /// <param name="qosType">Specifies the QoS policy type to use. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. &#39;kTestAndDevHigh&#39; indicated the test and dev workload. &#39;kBackupAll&#39; indicates the Cohesity Cluster writes data directly to the HDD tier and the SSD tier for this Protection Job..</param>
        /// <param name="storageDomainId">Specifies the Storage Domain to which data will be written..</param>
        public RpoPolicySettings(AlertingConfig alertingConfig = default(AlertingConfig), List<AlertingPolicyEnum> alertingPolicy = default(List<AlertingPolicyEnum>), EnvironmentTypeJobParameters environmentTypeJobParams = default(EnvironmentTypeJobParameters), IndexingPolicy indexingPolicy = default(IndexingPolicy), QosTypeEnum? qosType = default(QosTypeEnum?), long? storageDomainId = default(long?))
        {
            this.AlertingConfig = alertingConfig;
            this.AlertingPolicy = alertingPolicy;
            this.EnvironmentTypeJobParams = environmentTypeJobParams;
            this.IndexingPolicy = indexingPolicy;
            this.QosType = qosType;
            this.StorageDomainId = storageDomainId;
        }
        
        /// <summary>
        /// Gets or Sets AlertingConfig
        /// </summary>
        [DataMember(Name="alertingConfig", EmitDefaultValue=false)]
        public AlertingConfig AlertingConfig { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentTypeJobParams
        /// </summary>
        [DataMember(Name="environmentTypeJobParams", EmitDefaultValue=false)]
        public EnvironmentTypeJobParameters EnvironmentTypeJobParams { get; set; }

        /// <summary>
        /// Gets or Sets IndexingPolicy
        /// </summary>
        [DataMember(Name="indexingPolicy", EmitDefaultValue=false)]
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        /// Specifies the Storage Domain to which data will be written.
        /// </summary>
        /// <value>Specifies the Storage Domain to which data will be written.</value>
        [DataMember(Name="storageDomainId", EmitDefaultValue=true)]
        public long? StorageDomainId { get; set; }

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
            return this.Equals(input as RpoPolicySettings);
        }

        /// <summary>
        /// Returns true if RpoPolicySettings instances are equal
        /// </summary>
        /// <param name="input">Instance of RpoPolicySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpoPolicySettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertingConfig == input.AlertingConfig ||
                    (this.AlertingConfig != null &&
                    this.AlertingConfig.Equals(input.AlertingConfig))
                ) && 
                (
                    this.AlertingPolicy == input.AlertingPolicy ||
                    this.AlertingPolicy.Equals(input.AlertingPolicy)
                ) && 
                (
                    this.EnvironmentTypeJobParams == input.EnvironmentTypeJobParams ||
                    (this.EnvironmentTypeJobParams != null &&
                    this.EnvironmentTypeJobParams.Equals(input.EnvironmentTypeJobParams))
                ) && 
                (
                    this.IndexingPolicy == input.IndexingPolicy ||
                    (this.IndexingPolicy != null &&
                    this.IndexingPolicy.Equals(input.IndexingPolicy))
                ) && 
                (
                    this.QosType == input.QosType ||
                    this.QosType.Equals(input.QosType)
                ) && 
                (
                    this.StorageDomainId == input.StorageDomainId ||
                    (this.StorageDomainId != null &&
                    this.StorageDomainId.Equals(input.StorageDomainId))
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
                if (this.AlertingConfig != null)
                    hashCode = hashCode * 59 + this.AlertingConfig.GetHashCode();
                hashCode = hashCode * 59 + this.AlertingPolicy.GetHashCode();
                if (this.EnvironmentTypeJobParams != null)
                    hashCode = hashCode * 59 + this.EnvironmentTypeJobParams.GetHashCode();
                if (this.IndexingPolicy != null)
                    hashCode = hashCode * 59 + this.IndexingPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.QosType.GetHashCode();
                if (this.StorageDomainId != null)
                    hashCode = hashCode * 59 + this.StorageDomainId.GetHashCode();
                return hashCode;
            }
        }

    }

}

