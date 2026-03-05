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
    /// ProtectionSummaryForK8sDistributions
    /// </summary>
    [DataContract]
    public partial class ProtectionSummaryForK8sDistributions :  IEquatable<ProtectionSummaryForK8sDistributions>
    {
        /// <summary>
        /// Specifies the type of Kuberentes distribution Determines the K8s distribution. kIKS, kROKS
        /// </summary>
        /// <value>Specifies the type of Kuberentes distribution Determines the K8s distribution. kIKS, kROKS</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistributionEnum
        {
            /// <summary>
            /// Enum KMainline for value: kMainline
            /// </summary>
            [EnumMember(Value = "kMainline")]
            KMainline = 1,

            /// <summary>
            /// Enum KOpenshift for value: kOpenshift
            /// </summary>
            [EnumMember(Value = "kOpenshift")]
            KOpenshift = 2,

            /// <summary>
            /// Enum KRancher for value: kRancher
            /// </summary>
            [EnumMember(Value = "kRancher")]
            KRancher = 3,

            /// <summary>
            /// Enum KEKS for value: kEKS
            /// </summary>
            [EnumMember(Value = "kEKS")]
            KEKS = 4,

            /// <summary>
            /// Enum KGKE for value: kGKE
            /// </summary>
            [EnumMember(Value = "kGKE")]
            KGKE = 5,

            /// <summary>
            /// Enum KAKS for value: kAKS
            /// </summary>
            [EnumMember(Value = "kAKS")]
            KAKS = 6,

            /// <summary>
            /// Enum KVMwareTanzu for value: kVMwareTanzu
            /// </summary>
            [EnumMember(Value = "kVMwareTanzu")]
            KVMwareTanzu = 7

        }

        /// <summary>
        /// Specifies the type of Kuberentes distribution Determines the K8s distribution. kIKS, kROKS
        /// </summary>
        /// <value>Specifies the type of Kuberentes distribution Determines the K8s distribution. kIKS, kROKS</value>
        [DataMember(Name="distribution", EmitDefaultValue=true)]
        public DistributionEnum? Distribution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSummaryForK8sDistributions" /> class.
        /// </summary>
        /// <param name="distribution">Specifies the type of Kuberentes distribution Determines the K8s distribution. kIKS, kROKS.</param>
        /// <param name="protectedCount">Specifies the number of objects that are protected for that distribution.</param>
        /// <param name="protectedSize">Specifies the total size of objects that are protected for that distribution.</param>
        /// <param name="totalRegisteredClusters">Specifies the number of registered clusters for that distribution.</param>
        /// <param name="unprotectedCount">Specifies the number of objects that are not protected for that distribution.</param>
        /// <param name="unprotectedSize">Specifies the total size of objects that are not protected for that distribution.</param>
        public ProtectionSummaryForK8sDistributions(DistributionEnum? distribution = default(DistributionEnum?), long? protectedCount = default(long?), long? protectedSize = default(long?), long? totalRegisteredClusters = default(long?), long? unprotectedCount = default(long?), long? unprotectedSize = default(long?))
        {
            this.Distribution = distribution;
            this.ProtectedCount = protectedCount;
            this.ProtectedSize = protectedSize;
            this.TotalRegisteredClusters = totalRegisteredClusters;
            this.UnprotectedCount = unprotectedCount;
            this.UnprotectedSize = unprotectedSize;
            this.Distribution = distribution;
            this.ProtectedCount = protectedCount;
            this.ProtectedSize = protectedSize;
            this.TotalRegisteredClusters = totalRegisteredClusters;
            this.UnprotectedCount = unprotectedCount;
            this.UnprotectedSize = unprotectedSize;
        }
        
        /// <summary>
        /// Specifies the number of objects that are protected for that distribution
        /// </summary>
        /// <value>Specifies the number of objects that are protected for that distribution</value>
        [DataMember(Name="protectedCount", EmitDefaultValue=true)]
        public long? ProtectedCount { get; set; }

        /// <summary>
        /// Specifies the total size of objects that are protected for that distribution
        /// </summary>
        /// <value>Specifies the total size of objects that are protected for that distribution</value>
        [DataMember(Name="protectedSize", EmitDefaultValue=true)]
        public long? ProtectedSize { get; set; }

        /// <summary>
        /// Specifies the number of registered clusters for that distribution
        /// </summary>
        /// <value>Specifies the number of registered clusters for that distribution</value>
        [DataMember(Name="totalRegisteredClusters", EmitDefaultValue=true)]
        public long? TotalRegisteredClusters { get; set; }

        /// <summary>
        /// Specifies the number of objects that are not protected for that distribution
        /// </summary>
        /// <value>Specifies the number of objects that are not protected for that distribution</value>
        [DataMember(Name="unprotectedCount", EmitDefaultValue=true)]
        public long? UnprotectedCount { get; set; }

        /// <summary>
        /// Specifies the total size of objects that are not protected for that distribution
        /// </summary>
        /// <value>Specifies the total size of objects that are not protected for that distribution</value>
        [DataMember(Name="unprotectedSize", EmitDefaultValue=true)]
        public long? UnprotectedSize { get; set; }

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
            return this.Equals(input as ProtectionSummaryForK8sDistributions);
        }

        /// <summary>
        /// Returns true if ProtectionSummaryForK8sDistributions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSummaryForK8sDistributions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSummaryForK8sDistributions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distribution == input.Distribution ||
                    this.Distribution.Equals(input.Distribution)
                ) && 
                (
                    this.ProtectedCount == input.ProtectedCount ||
                    (this.ProtectedCount != null &&
                    this.ProtectedCount.Equals(input.ProtectedCount))
                ) && 
                (
                    this.ProtectedSize == input.ProtectedSize ||
                    (this.ProtectedSize != null &&
                    this.ProtectedSize.Equals(input.ProtectedSize))
                ) && 
                (
                    this.TotalRegisteredClusters == input.TotalRegisteredClusters ||
                    (this.TotalRegisteredClusters != null &&
                    this.TotalRegisteredClusters.Equals(input.TotalRegisteredClusters))
                ) && 
                (
                    this.UnprotectedCount == input.UnprotectedCount ||
                    (this.UnprotectedCount != null &&
                    this.UnprotectedCount.Equals(input.UnprotectedCount))
                ) && 
                (
                    this.UnprotectedSize == input.UnprotectedSize ||
                    (this.UnprotectedSize != null &&
                    this.UnprotectedSize.Equals(input.UnprotectedSize))
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
                hashCode = hashCode * 59 + this.Distribution.GetHashCode();
                if (this.ProtectedCount != null)
                    hashCode = hashCode * 59 + this.ProtectedCount.GetHashCode();
                if (this.ProtectedSize != null)
                    hashCode = hashCode * 59 + this.ProtectedSize.GetHashCode();
                if (this.TotalRegisteredClusters != null)
                    hashCode = hashCode * 59 + this.TotalRegisteredClusters.GetHashCode();
                if (this.UnprotectedCount != null)
                    hashCode = hashCode * 59 + this.UnprotectedCount.GetHashCode();
                if (this.UnprotectedSize != null)
                    hashCode = hashCode * 59 + this.UnprotectedSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

