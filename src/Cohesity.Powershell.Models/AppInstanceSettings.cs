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
    /// AppInstanceSettings provides settings used while launching an app instance. Current settings include QoSTier to be used for the instance and views allowed to be accessed by the instance.
    /// </summary>
    [DataContract]
    public partial class AppInstanceSettings :  IEquatable<AppInstanceSettings>
    {
        /// <summary>
        /// Specifies QoSTier of the app instance. Specifies QoS Tier for an app instance. App instances are allocated resources such as memory, CPU and IO based on their QoS Tier. kLow - Low QoS Tier. kMedium - Medium QoS Tier. kHigh - High QoS Tier.
        /// </summary>
        /// <value>Specifies QoSTier of the app instance. Specifies QoS Tier for an app instance. App instances are allocated resources such as memory, CPU and IO based on their QoS Tier. kLow - Low QoS Tier. kMedium - Medium QoS Tier. kHigh - High QoS Tier.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QosTierEnum
        {
            /// <summary>
            /// Enum KLow for value: kLow
            /// </summary>
            [EnumMember(Value = "kLow")]
            KLow = 1,

            /// <summary>
            /// Enum KMedium for value: kMedium
            /// </summary>
            [EnumMember(Value = "kMedium")]
            KMedium = 2,

            /// <summary>
            /// Enum KHigh for value: kHigh
            /// </summary>
            [EnumMember(Value = "kHigh")]
            KHigh = 3

        }

        /// <summary>
        /// Specifies QoSTier of the app instance. Specifies QoS Tier for an app instance. App instances are allocated resources such as memory, CPU and IO based on their QoS Tier. kLow - Low QoS Tier. kMedium - Medium QoS Tier. kHigh - High QoS Tier.
        /// </summary>
        /// <value>Specifies QoSTier of the app instance. Specifies QoS Tier for an app instance. App instances are allocated resources such as memory, CPU and IO based on their QoS Tier. kLow - Low QoS Tier. kMedium - Medium QoS Tier. kHigh - High QoS Tier.</value>
        [DataMember(Name="qosTier", EmitDefaultValue=true)]
        public QosTierEnum? QosTier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceSettings" /> class.
        /// </summary>
        /// <param name="qosTier">Specifies QoSTier of the app instance. Specifies QoS Tier for an app instance. App instances are allocated resources such as memory, CPU and IO based on their QoS Tier. kLow - Low QoS Tier. kMedium - Medium QoS Tier. kHigh - High QoS Tier..</param>
        /// <param name="readViewPrivileges">readViewPrivileges.</param>
        /// <param name="readWriteViewPrivileges">readWriteViewPrivileges.</param>
        public AppInstanceSettings(QosTierEnum? qosTier = default(QosTierEnum?), ViewPrivileges readViewPrivileges = default(ViewPrivileges), ViewPrivileges readWriteViewPrivileges = default(ViewPrivileges))
        {
            this.QosTier = qosTier;
            this.QosTier = qosTier;
            this.ReadViewPrivileges = readViewPrivileges;
            this.ReadWriteViewPrivileges = readWriteViewPrivileges;
        }
        
        /// <summary>
        /// Gets or Sets ReadViewPrivileges
        /// </summary>
        [DataMember(Name="readViewPrivileges", EmitDefaultValue=false)]
        public ViewPrivileges ReadViewPrivileges { get; set; }

        /// <summary>
        /// Gets or Sets ReadWriteViewPrivileges
        /// </summary>
        [DataMember(Name="readWriteViewPrivileges", EmitDefaultValue=false)]
        public ViewPrivileges ReadWriteViewPrivileges { get; set; }

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
            return this.Equals(input as AppInstanceSettings);
        }

        /// <summary>
        /// Returns true if AppInstanceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInstanceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInstanceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QosTier == input.QosTier ||
                    this.QosTier.Equals(input.QosTier)
                ) && 
                (
                    this.ReadViewPrivileges == input.ReadViewPrivileges ||
                    (this.ReadViewPrivileges != null &&
                    this.ReadViewPrivileges.Equals(input.ReadViewPrivileges))
                ) && 
                (
                    this.ReadWriteViewPrivileges == input.ReadWriteViewPrivileges ||
                    (this.ReadWriteViewPrivileges != null &&
                    this.ReadWriteViewPrivileges.Equals(input.ReadWriteViewPrivileges))
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
                hashCode = hashCode * 59 + this.QosTier.GetHashCode();
                if (this.ReadViewPrivileges != null)
                    hashCode = hashCode * 59 + this.ReadViewPrivileges.GetHashCode();
                if (this.ReadWriteViewPrivileges != null)
                    hashCode = hashCode * 59 + this.ReadWriteViewPrivileges.GetHashCode();
                return hashCode;
            }
        }

    }

}

