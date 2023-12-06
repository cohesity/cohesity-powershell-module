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
    /// Specifies information about the Cbt Driver associated with agent.
    /// </summary>
    [DataContract]
    public partial class CbtInfo :  IEquatable<CbtInfo>
    {
        /// <summary>
        /// Specifies the reboot status of the host post cbt driver installation. Only applicable for volcbt driver. Specifies the reboot status of the source post volcbt driver installation. &#39;kRebooted&#39; indicates the source has been rebooted post volcbt driver installation. &#39;kNeedsReboot&#39; indicates the source has not been rebooted post volcbt driver installation. &#39;kInternalError&#39; indicates that there was an error while fetching reboot status from source.
        /// </summary>
        /// <value>Specifies the reboot status of the host post cbt driver installation. Only applicable for volcbt driver. Specifies the reboot status of the source post volcbt driver installation. &#39;kRebooted&#39; indicates the source has been rebooted post volcbt driver installation. &#39;kNeedsReboot&#39; indicates the source has not been rebooted post volcbt driver installation. &#39;kInternalError&#39; indicates that there was an error while fetching reboot status from source.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RebootStatusEnum
        {
            /// <summary>
            /// Enum KRebooted for value: kRebooted
            /// </summary>
            [EnumMember(Value = "kRebooted")]
            KRebooted = 1,

            /// <summary>
            /// Enum KNeedsReboot for value: kNeedsReboot
            /// </summary>
            [EnumMember(Value = "kNeedsReboot")]
            KNeedsReboot = 2,

            /// <summary>
            /// Enum KInternalError for value: kInternalError
            /// </summary>
            [EnumMember(Value = "kInternalError")]
            KInternalError = 3

        }

        /// <summary>
        /// Specifies the reboot status of the host post cbt driver installation. Only applicable for volcbt driver. Specifies the reboot status of the source post volcbt driver installation. &#39;kRebooted&#39; indicates the source has been rebooted post volcbt driver installation. &#39;kNeedsReboot&#39; indicates the source has not been rebooted post volcbt driver installation. &#39;kInternalError&#39; indicates that there was an error while fetching reboot status from source.
        /// </summary>
        /// <value>Specifies the reboot status of the host post cbt driver installation. Only applicable for volcbt driver. Specifies the reboot status of the source post volcbt driver installation. &#39;kRebooted&#39; indicates the source has been rebooted post volcbt driver installation. &#39;kNeedsReboot&#39; indicates the source has not been rebooted post volcbt driver installation. &#39;kInternalError&#39; indicates that there was an error while fetching reboot status from source.</value>
        [DataMember(Name="rebootStatus", EmitDefaultValue=true)]
        public RebootStatusEnum? RebootStatus { get; set; }
        /// <summary>
        /// Specifies the status of the cbt driver. Specifies the service state of the cbt driver. &#39;kRunning&#39; indicates the cbt driver is running. &#39;kStopped&#39; indicates the service is stopped. &#39;kPaused&#39; indicates the service is paused (it is a Windows-specific state). &#39;kUnknown&#39; indicates the service with the specified name is not known on the system.
        /// </summary>
        /// <value>Specifies the status of the cbt driver. Specifies the service state of the cbt driver. &#39;kRunning&#39; indicates the cbt driver is running. &#39;kStopped&#39; indicates the service is stopped. &#39;kPaused&#39; indicates the service is paused (it is a Windows-specific state). &#39;kUnknown&#39; indicates the service with the specified name is not known on the system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceStateEnum
        {
            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 1,

            /// <summary>
            /// Enum KStopped for value: kStopped
            /// </summary>
            [EnumMember(Value = "kStopped")]
            KStopped = 2,

            /// <summary>
            /// Enum KPaused for value: kPaused
            /// </summary>
            [EnumMember(Value = "kPaused")]
            KPaused = 3,

            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 4

        }

        /// <summary>
        /// Specifies the status of the cbt driver. Specifies the service state of the cbt driver. &#39;kRunning&#39; indicates the cbt driver is running. &#39;kStopped&#39; indicates the service is stopped. &#39;kPaused&#39; indicates the service is paused (it is a Windows-specific state). &#39;kUnknown&#39; indicates the service with the specified name is not known on the system.
        /// </summary>
        /// <value>Specifies the status of the cbt driver. Specifies the service state of the cbt driver. &#39;kRunning&#39; indicates the cbt driver is running. &#39;kStopped&#39; indicates the service is stopped. &#39;kPaused&#39; indicates the service is paused (it is a Windows-specific state). &#39;kUnknown&#39; indicates the service with the specified name is not known on the system.</value>
        [DataMember(Name="serviceState", EmitDefaultValue=true)]
        public ServiceStateEnum? ServiceState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CbtInfo" /> class.
        /// </summary>
        /// <param name="isInstalled">Specifies whether the cbt driver is installed or not..</param>
        /// <param name="rebootStatus">Specifies the reboot status of the host post cbt driver installation. Only applicable for volcbt driver. Specifies the reboot status of the source post volcbt driver installation. &#39;kRebooted&#39; indicates the source has been rebooted post volcbt driver installation. &#39;kNeedsReboot&#39; indicates the source has not been rebooted post volcbt driver installation. &#39;kInternalError&#39; indicates that there was an error while fetching reboot status from source..</param>
        /// <param name="serviceState">Specifies the status of the cbt driver. Specifies the service state of the cbt driver. &#39;kRunning&#39; indicates the cbt driver is running. &#39;kStopped&#39; indicates the service is stopped. &#39;kPaused&#39; indicates the service is paused (it is a Windows-specific state). &#39;kUnknown&#39; indicates the service with the specified name is not known on the system..</param>
        public CbtInfo(bool? isInstalled = default(bool?), RebootStatusEnum? rebootStatus = default(RebootStatusEnum?), ServiceStateEnum? serviceState = default(ServiceStateEnum?))
        {
            this.IsInstalled = isInstalled;
            this.RebootStatus = rebootStatus;
            this.ServiceState = serviceState;
            this.IsInstalled = isInstalled;
            this.RebootStatus = rebootStatus;
            this.ServiceState = serviceState;
        }
        
        /// <summary>
        /// Specifies whether the cbt driver is installed or not.
        /// </summary>
        /// <value>Specifies whether the cbt driver is installed or not.</value>
        [DataMember(Name="isInstalled", EmitDefaultValue=true)]
        public bool? IsInstalled { get; set; }

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
            return this.Equals(input as CbtInfo);
        }

        /// <summary>
        /// Returns true if CbtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CbtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CbtInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsInstalled == input.IsInstalled ||
                    (this.IsInstalled != null &&
                    this.IsInstalled.Equals(input.IsInstalled))
                ) && 
                (
                    this.RebootStatus == input.RebootStatus ||
                    this.RebootStatus.Equals(input.RebootStatus)
                ) && 
                (
                    this.ServiceState == input.ServiceState ||
                    this.ServiceState.Equals(input.ServiceState)
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
                if (this.IsInstalled != null)
                    hashCode = hashCode * 59 + this.IsInstalled.GetHashCode();
                hashCode = hashCode * 59 + this.RebootStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceState.GetHashCode();
                return hashCode;
            }
        }

    }

}

