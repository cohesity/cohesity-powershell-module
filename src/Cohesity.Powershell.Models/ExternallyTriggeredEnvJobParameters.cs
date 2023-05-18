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
    /// ExternallyTriggeredEnvJobParameters
    /// </summary>
    [DataContract]
    public partial class ExternallyTriggeredEnvJobParameters :  IEquatable<ExternallyTriggeredEnvJobParameters>
    {
        /// <summary>
        /// Specifies the client type of the externally triggered job kGeneric implies generic externally triggered backups. kSbt implies externally triggered backups for SBT.
        /// </summary>
        /// <value>Specifies the client type of the externally triggered job kGeneric implies generic externally triggered backups. kSbt implies externally triggered backups for SBT.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClientTypeEnum
        {
            /// <summary>
            /// Enum KGeneric for value: kGeneric
            /// </summary>
            [EnumMember(Value = "kGeneric")]
            KGeneric = 1,

            /// <summary>
            /// Enum KSbt for value: kSbt
            /// </summary>
            [EnumMember(Value = "kSbt")]
            KSbt = 2

        }

        /// <summary>
        /// Specifies the client type of the externally triggered job kGeneric implies generic externally triggered backups. kSbt implies externally triggered backups for SBT.
        /// </summary>
        /// <value>Specifies the client type of the externally triggered job kGeneric implies generic externally triggered backups. kSbt implies externally triggered backups for SBT.</value>
        [DataMember(Name="clientType", EmitDefaultValue=true)]
        public ClientTypeEnum? ClientType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternallyTriggeredEnvJobParameters" /> class.
        /// </summary>
        /// <param name="clientType">Specifies the client type of the externally triggered job kGeneric implies generic externally triggered backups. kSbt implies externally triggered backups for SBT..</param>
        /// <param name="sbtParams">sbtParams.</param>
        public ExternallyTriggeredEnvJobParameters(ClientTypeEnum? clientType = default(ClientTypeEnum?), ExternallyTriggeredSbtParameters sbtParams = default(ExternallyTriggeredSbtParameters))
        {
            this.ClientType = clientType;
            this.ClientType = clientType;
            this.SbtParams = sbtParams;
        }
        
        /// <summary>
        /// Gets or Sets SbtParams
        /// </summary>
        [DataMember(Name="sbtParams", EmitDefaultValue=false)]
        public ExternallyTriggeredSbtParameters SbtParams { get; set; }

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
            return this.Equals(input as ExternallyTriggeredEnvJobParameters);
        }

        /// <summary>
        /// Returns true if ExternallyTriggeredEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternallyTriggeredEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternallyTriggeredEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientType == input.ClientType ||
                    this.ClientType.Equals(input.ClientType)
                ) && 
                (
                    this.SbtParams == input.SbtParams ||
                    (this.SbtParams != null &&
                    this.SbtParams.Equals(input.SbtParams))
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
                hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.SbtParams != null)
                    hashCode = hashCode * 59 + this.SbtParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

