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
    /// Structure to hold Airgap Configuration
    /// </summary>
    [DataContract]
    public partial class AirgapConfig :  IEquatable<AirgapConfig>
    {
        /// <summary>
        /// Airgap Status &#39;kEnable&#39; indicates that Airgap is enbaled &#39;kDisable&#39; indicates that Airgap is disabled
        /// </summary>
        /// <value>Airgap Status &#39;kEnable&#39; indicates that Airgap is enbaled &#39;kDisable&#39; indicates that Airgap is disabled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AirgapStatusEnum
        {
            /// <summary>
            /// Enum KEnable for value: kEnable
            /// </summary>
            [EnumMember(Value = "kEnable")]
            KEnable = 1,

            /// <summary>
            /// Enum KDisable for value: kDisable
            /// </summary>
            [EnumMember(Value = "kDisable")]
            KDisable = 2

        }

        /// <summary>
        /// Airgap Status &#39;kEnable&#39; indicates that Airgap is enbaled &#39;kDisable&#39; indicates that Airgap is disabled
        /// </summary>
        /// <value>Airgap Status &#39;kEnable&#39; indicates that Airgap is enbaled &#39;kDisable&#39; indicates that Airgap is disabled</value>
        [DataMember(Name="airgapStatus", EmitDefaultValue=true)]
        public AirgapStatusEnum? AirgapStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirgapConfig" /> class.
        /// </summary>
        /// <param name="airgapStatus">Airgap Status &#39;kEnable&#39; indicates that Airgap is enbaled &#39;kDisable&#39; indicates that Airgap is disabled.</param>
        /// <param name="exceptionProfiles">Exception firewall profile names.</param>
        public AirgapConfig(AirgapStatusEnum? airgapStatus = default(AirgapStatusEnum?), List<string> exceptionProfiles = default(List<string>))
        {
            this.AirgapStatus = airgapStatus;
            this.ExceptionProfiles = exceptionProfiles;
            this.AirgapStatus = airgapStatus;
            this.ExceptionProfiles = exceptionProfiles;
        }
        
        /// <summary>
        /// Exception firewall profile names
        /// </summary>
        /// <value>Exception firewall profile names</value>
        [DataMember(Name="exceptionProfiles", EmitDefaultValue=true)]
        public List<string> ExceptionProfiles { get; set; }

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
            return this.Equals(input as AirgapConfig);
        }

        /// <summary>
        /// Returns true if AirgapConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AirgapConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirgapConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AirgapStatus == input.AirgapStatus ||
                    this.AirgapStatus.Equals(input.AirgapStatus)
                ) && 
                (
                    this.ExceptionProfiles == input.ExceptionProfiles ||
                    this.ExceptionProfiles != null &&
                    input.ExceptionProfiles != null &&
                    this.ExceptionProfiles.SequenceEqual(input.ExceptionProfiles)
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
                hashCode = hashCode * 59 + this.AirgapStatus.GetHashCode();
                if (this.ExceptionProfiles != null)
                    hashCode = hashCode * 59 + this.ExceptionProfiles.GetHashCode();
                return hashCode;
            }
        }

    }

}

