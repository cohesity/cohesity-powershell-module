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
    /// Specifies the View stats per view.
    /// </summary>
    [DataContract]
    public partial class ViewStatInfo :  IEquatable<ViewStatInfo>
    {
        /// <summary>
        /// Defines Protocols
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolsEnum
        {
            /// <summary>
            /// Enum KIscsi for value: kIscsi
            /// </summary>
            [EnumMember(Value = "kIscsi")]
            KIscsi = 1,

            /// <summary>
            /// Enum KS3 for value: kS3
            /// </summary>
            [EnumMember(Value = "kS3")]
            KS3 = 2,

            /// <summary>
            /// Enum KSmb for value: kSmb
            /// </summary>
            [EnumMember(Value = "kSmb")]
            KSmb = 3,

            /// <summary>
            /// Enum KNfs for value: kNfs
            /// </summary>
            [EnumMember(Value = "kNfs")]
            KNfs = 4

        }


        /// <summary>
        /// Specifies the protocols of this view.
        /// </summary>
        /// <value>Specifies the protocols of this view.</value>
        [DataMember(Name="protocols", EmitDefaultValue=false)]
        public List<ProtocolsEnum> Protocols { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewStatInfo" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the cluster Id..</param>
        /// <param name="clusterIncarnationId">Specifies the cluster Incarnation Id..</param>
        /// <param name="dataReadBytes">Specifies the data read in bytes..</param>
        /// <param name="dataWrittenBytes">Specifies the data written in bytes..</param>
        /// <param name="logicalUsedBytes">Specifies the logical size used in bytes..</param>
        /// <param name="peakReadThroughput">Specifies the peak data read in bytes per second in the last day..</param>
        /// <param name="peakWriteThroughput">Specifies the peak data written in bytes per second in the last day..</param>
        /// <param name="physicalUsedBytes">Specifies the physical size used in bytes..</param>
        /// <param name="protocols">Specifies the protocols of this view..</param>
        /// <param name="storageReductionRatio">Specifies the storage reduction ratio..</param>
        /// <param name="viewId">Specifies the view Id..</param>
        /// <param name="viewName">Specifies the view name..</param>
        public ViewStatInfo(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? dataReadBytes = default(long?), long? dataWrittenBytes = default(long?), long? logicalUsedBytes = default(long?), long? peakReadThroughput = default(long?), long? peakWriteThroughput = default(long?), long? physicalUsedBytes = default(long?), List<ProtocolsEnum> protocols = default(List<ProtocolsEnum>), float? storageReductionRatio = default(float?), long? viewId = default(long?), string viewName = default(string))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.DataReadBytes = dataReadBytes;
            this.DataWrittenBytes = dataWrittenBytes;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.PeakReadThroughput = peakReadThroughput;
            this.PeakWriteThroughput = peakWriteThroughput;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.StorageReductionRatio = storageReductionRatio;
            this.ViewId = viewId;
            this.ViewName = viewName;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.DataReadBytes = dataReadBytes;
            this.DataWrittenBytes = dataWrittenBytes;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.PeakReadThroughput = peakReadThroughput;
            this.PeakWriteThroughput = peakWriteThroughput;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.Protocols = protocols;
            this.StorageReductionRatio = storageReductionRatio;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the cluster Id.
        /// </summary>
        /// <value>Specifies the cluster Id.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the cluster Incarnation Id.
        /// </summary>
        /// <value>Specifies the cluster Incarnation Id.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies the data read in bytes.
        /// </summary>
        /// <value>Specifies the data read in bytes.</value>
        [DataMember(Name="dataReadBytes", EmitDefaultValue=true)]
        public long? DataReadBytes { get; set; }

        /// <summary>
        /// Specifies the data written in bytes.
        /// </summary>
        /// <value>Specifies the data written in bytes.</value>
        [DataMember(Name="dataWrittenBytes", EmitDefaultValue=true)]
        public long? DataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies the logical size used in bytes.
        /// </summary>
        /// <value>Specifies the logical size used in bytes.</value>
        [DataMember(Name="logicalUsedBytes", EmitDefaultValue=true)]
        public long? LogicalUsedBytes { get; set; }

        /// <summary>
        /// Specifies the peak data read in bytes per second in the last day.
        /// </summary>
        /// <value>Specifies the peak data read in bytes per second in the last day.</value>
        [DataMember(Name="peakReadThroughput", EmitDefaultValue=true)]
        public long? PeakReadThroughput { get; set; }

        /// <summary>
        /// Specifies the peak data written in bytes per second in the last day.
        /// </summary>
        /// <value>Specifies the peak data written in bytes per second in the last day.</value>
        [DataMember(Name="peakWriteThroughput", EmitDefaultValue=true)]
        public long? PeakWriteThroughput { get; set; }

        /// <summary>
        /// Specifies the physical size used in bytes.
        /// </summary>
        /// <value>Specifies the physical size used in bytes.</value>
        [DataMember(Name="physicalUsedBytes", EmitDefaultValue=true)]
        public long? PhysicalUsedBytes { get; set; }

        /// <summary>
        /// Specifies the storage reduction ratio.
        /// </summary>
        /// <value>Specifies the storage reduction ratio.</value>
        [DataMember(Name="storageReductionRatio", EmitDefaultValue=true)]
        public float? StorageReductionRatio { get; set; }

        /// <summary>
        /// Specifies the view Id.
        /// </summary>
        /// <value>Specifies the view Id.</value>
        [DataMember(Name="viewId", EmitDefaultValue=true)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies the view name.
        /// </summary>
        /// <value>Specifies the view name.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as ViewStatInfo);
        }

        /// <summary>
        /// Returns true if ViewStatInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewStatInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewStatInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.DataReadBytes == input.DataReadBytes ||
                    (this.DataReadBytes != null &&
                    this.DataReadBytes.Equals(input.DataReadBytes))
                ) && 
                (
                    this.DataWrittenBytes == input.DataWrittenBytes ||
                    (this.DataWrittenBytes != null &&
                    this.DataWrittenBytes.Equals(input.DataWrittenBytes))
                ) && 
                (
                    this.LogicalUsedBytes == input.LogicalUsedBytes ||
                    (this.LogicalUsedBytes != null &&
                    this.LogicalUsedBytes.Equals(input.LogicalUsedBytes))
                ) && 
                (
                    this.PeakReadThroughput == input.PeakReadThroughput ||
                    (this.PeakReadThroughput != null &&
                    this.PeakReadThroughput.Equals(input.PeakReadThroughput))
                ) && 
                (
                    this.PeakWriteThroughput == input.PeakWriteThroughput ||
                    (this.PeakWriteThroughput != null &&
                    this.PeakWriteThroughput.Equals(input.PeakWriteThroughput))
                ) && 
                (
                    this.PhysicalUsedBytes == input.PhysicalUsedBytes ||
                    (this.PhysicalUsedBytes != null &&
                    this.PhysicalUsedBytes.Equals(input.PhysicalUsedBytes))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.StorageReductionRatio == input.StorageReductionRatio ||
                    (this.StorageReductionRatio != null &&
                    this.StorageReductionRatio.Equals(input.StorageReductionRatio))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.DataReadBytes != null)
                    hashCode = hashCode * 59 + this.DataReadBytes.GetHashCode();
                if (this.DataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.DataWrittenBytes.GetHashCode();
                if (this.LogicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsedBytes.GetHashCode();
                if (this.PeakReadThroughput != null)
                    hashCode = hashCode * 59 + this.PeakReadThroughput.GetHashCode();
                if (this.PeakWriteThroughput != null)
                    hashCode = hashCode * 59 + this.PeakWriteThroughput.GetHashCode();
                if (this.PhysicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalUsedBytes.GetHashCode();
                hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.StorageReductionRatio != null)
                    hashCode = hashCode * 59 + this.StorageReductionRatio.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

