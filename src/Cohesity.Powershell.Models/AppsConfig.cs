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
    /// AppsConfig
    /// </summary>
    [DataContract]
    public partial class AppsConfig :  IEquatable<AppsConfig>
    {
        /// <summary>
        /// Specifies the various modes for running apps. &#39;kDisabled&#39; specifies that apps are disabled. &#39;kBareMetal&#39; specifies that apps could only run in containers on the node (no VM). &#39;kVmOnly&#39; specifies that apps could only run in containers on a VM hosted by the node.
        /// </summary>
        /// <value>Specifies the various modes for running apps. &#39;kDisabled&#39; specifies that apps are disabled. &#39;kBareMetal&#39; specifies that apps could only run in containers on the node (no VM). &#39;kVmOnly&#39; specifies that apps could only run in containers on a VM hosted by the node.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppsModeEnum
        {
            /// <summary>
            /// Enum KDisabled for value: kDisabled
            /// </summary>
            [EnumMember(Value = "kDisabled")]
            KDisabled = 1,

            /// <summary>
            /// Enum KBareMetal for value: kBareMetal
            /// </summary>
            [EnumMember(Value = "kBareMetal")]
            KBareMetal = 2,

            /// <summary>
            /// Enum KVmOnly for value: kVmOnly
            /// </summary>
            [EnumMember(Value = "kVmOnly")]
            KVmOnly = 3

        }

        /// <summary>
        /// Specifies the various modes for running apps. &#39;kDisabled&#39; specifies that apps are disabled. &#39;kBareMetal&#39; specifies that apps could only run in containers on the node (no VM). &#39;kVmOnly&#39; specifies that apps could only run in containers on a VM hosted by the node.
        /// </summary>
        /// <value>Specifies the various modes for running apps. &#39;kDisabled&#39; specifies that apps are disabled. &#39;kBareMetal&#39; specifies that apps could only run in containers on the node (no VM). &#39;kVmOnly&#39; specifies that apps could only run in containers on a VM hosted by the node.</value>
        [DataMember(Name="appsMode", EmitDefaultValue=true)]
        public AppsModeEnum? AppsMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppsConfig" /> class.
        /// </summary>
        /// <param name="allowExternalTraffic">Whether to allow pod external traffic..</param>
        /// <param name="allowUnrestictedViewAccess">Whether to allow apps unrestricted view access..</param>
        /// <param name="appsMode">Specifies the various modes for running apps. &#39;kDisabled&#39; specifies that apps are disabled. &#39;kBareMetal&#39; specifies that apps could only run in containers on the node (no VM). &#39;kVmOnly&#39; specifies that apps could only run in containers on a VM hosted by the node..</param>
        /// <param name="appsSubnet">appsSubnet.</param>
        /// <param name="overcommitMemoryPct">The system memory to overcommit for apps..</param>
        /// <param name="reservedCpuMillicores">The CPU millicores to reserve for apps..</param>
        /// <param name="reservedMemoryPct">The system memory to reserve for apps..</param>
        public AppsConfig(bool? allowExternalTraffic = default(bool?), bool? allowUnrestictedViewAccess = default(bool?), AppsModeEnum? appsMode = default(AppsModeEnum?), Subnet appsSubnet = default(Subnet), int? overcommitMemoryPct = default(int?), int? reservedCpuMillicores = default(int?), int? reservedMemoryPct = default(int?))
        {
            this.AllowExternalTraffic = allowExternalTraffic;
            this.AllowUnrestictedViewAccess = allowUnrestictedViewAccess;
            this.AppsMode = appsMode;
            this.OvercommitMemoryPct = overcommitMemoryPct;
            this.ReservedCpuMillicores = reservedCpuMillicores;
            this.ReservedMemoryPct = reservedMemoryPct;
            this.AllowExternalTraffic = allowExternalTraffic;
            this.AllowUnrestictedViewAccess = allowUnrestictedViewAccess;
            this.AppsMode = appsMode;
            this.AppsSubnet = appsSubnet;
            this.OvercommitMemoryPct = overcommitMemoryPct;
            this.ReservedCpuMillicores = reservedCpuMillicores;
            this.ReservedMemoryPct = reservedMemoryPct;
        }
        
        /// <summary>
        /// Whether to allow pod external traffic.
        /// </summary>
        /// <value>Whether to allow pod external traffic.</value>
        [DataMember(Name="allowExternalTraffic", EmitDefaultValue=true)]
        public bool? AllowExternalTraffic { get; set; }

        /// <summary>
        /// Whether to allow apps unrestricted view access.
        /// </summary>
        /// <value>Whether to allow apps unrestricted view access.</value>
        [DataMember(Name="allowUnrestictedViewAccess", EmitDefaultValue=true)]
        public bool? AllowUnrestictedViewAccess { get; set; }

        /// <summary>
        /// Gets or Sets AppsSubnet
        /// </summary>
        [DataMember(Name="appsSubnet", EmitDefaultValue=false)]
        public Subnet AppsSubnet { get; set; }

        /// <summary>
        /// The system memory to overcommit for apps.
        /// </summary>
        /// <value>The system memory to overcommit for apps.</value>
        [DataMember(Name="overcommitMemoryPct", EmitDefaultValue=true)]
        public int? OvercommitMemoryPct { get; set; }

        /// <summary>
        /// The CPU millicores to reserve for apps.
        /// </summary>
        /// <value>The CPU millicores to reserve for apps.</value>
        [DataMember(Name="reservedCpuMillicores", EmitDefaultValue=true)]
        public int? ReservedCpuMillicores { get; set; }

        /// <summary>
        /// The system memory to reserve for apps.
        /// </summary>
        /// <value>The system memory to reserve for apps.</value>
        [DataMember(Name="reservedMemoryPct", EmitDefaultValue=true)]
        public int? ReservedMemoryPct { get; set; }

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
            return this.Equals(input as AppsConfig);
        }

        /// <summary>
        /// Returns true if AppsConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AppsConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowExternalTraffic == input.AllowExternalTraffic ||
                    (this.AllowExternalTraffic != null &&
                    this.AllowExternalTraffic.Equals(input.AllowExternalTraffic))
                ) && 
                (
                    this.AllowUnrestictedViewAccess == input.AllowUnrestictedViewAccess ||
                    (this.AllowUnrestictedViewAccess != null &&
                    this.AllowUnrestictedViewAccess.Equals(input.AllowUnrestictedViewAccess))
                ) && 
                (
                    this.AppsMode == input.AppsMode ||
                    this.AppsMode.Equals(input.AppsMode)
                ) && 
                (
                    this.AppsSubnet == input.AppsSubnet ||
                    (this.AppsSubnet != null &&
                    this.AppsSubnet.Equals(input.AppsSubnet))
                ) && 
                (
                    this.OvercommitMemoryPct == input.OvercommitMemoryPct ||
                    (this.OvercommitMemoryPct != null &&
                    this.OvercommitMemoryPct.Equals(input.OvercommitMemoryPct))
                ) && 
                (
                    this.ReservedCpuMillicores == input.ReservedCpuMillicores ||
                    (this.ReservedCpuMillicores != null &&
                    this.ReservedCpuMillicores.Equals(input.ReservedCpuMillicores))
                ) && 
                (
                    this.ReservedMemoryPct == input.ReservedMemoryPct ||
                    (this.ReservedMemoryPct != null &&
                    this.ReservedMemoryPct.Equals(input.ReservedMemoryPct))
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
                if (this.AllowExternalTraffic != null)
                    hashCode = hashCode * 59 + this.AllowExternalTraffic.GetHashCode();
                if (this.AllowUnrestictedViewAccess != null)
                    hashCode = hashCode * 59 + this.AllowUnrestictedViewAccess.GetHashCode();
                hashCode = hashCode * 59 + this.AppsMode.GetHashCode();
                if (this.AppsSubnet != null)
                    hashCode = hashCode * 59 + this.AppsSubnet.GetHashCode();
                if (this.OvercommitMemoryPct != null)
                    hashCode = hashCode * 59 + this.OvercommitMemoryPct.GetHashCode();
                if (this.ReservedCpuMillicores != null)
                    hashCode = hashCode * 59 + this.ReservedCpuMillicores.GetHashCode();
                if (this.ReservedMemoryPct != null)
                    hashCode = hashCode * 59 + this.ReservedMemoryPct.GetHashCode();
                return hashCode;
            }
        }

    }

}

