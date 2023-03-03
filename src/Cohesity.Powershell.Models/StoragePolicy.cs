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
    /// Specifies the storage options applied to a Storage Domain (View Box).
    /// </summary>
    [DataContract]
    public partial class StoragePolicy :  IEquatable<StoragePolicy>
    {
        /// <summary>
        /// Specifies the compression setting to be applied to a Storage Domain (View Box). &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.
        /// </summary>
        /// <value>Specifies the compression setting to be applied to a Storage Domain (View Box). &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionPolicyEnum
        {
            /// <summary>
            /// Enum KCompressionNone for value: kCompressionNone
            /// </summary>
            [EnumMember(Value = "kCompressionNone")]
            KCompressionNone = 1,

            /// <summary>
            /// Enum KCompressionLow for value: kCompressionLow
            /// </summary>
            [EnumMember(Value = "kCompressionLow")]
            KCompressionLow = 2,

            /// <summary>
            /// Enum KCompressionHigh for value: kCompressionHigh
            /// </summary>
            [EnumMember(Value = "kCompressionHigh")]
            KCompressionHigh = 3

        }

        /// <summary>
        /// Specifies the compression setting to be applied to a Storage Domain (View Box). &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.
        /// </summary>
        /// <value>Specifies the compression setting to be applied to a Storage Domain (View Box). &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip.</value>
        [DataMember(Name="compressionPolicy", EmitDefaultValue=true)]
        public CompressionPolicyEnum? CompressionPolicy { get; set; }
        /// <summary>
        /// Specifies the encryption setting for the Storage Domain (View Box). &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.
        /// </summary>
        /// <value>Specifies the encryption setting for the Storage Domain (View Box). &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionPolicyEnum
        {
            /// <summary>
            /// Enum KEncryptionNone for value: kEncryptionNone
            /// </summary>
            [EnumMember(Value = "kEncryptionNone")]
            KEncryptionNone = 1,

            /// <summary>
            /// Enum KEncryptionStrong for value: kEncryptionStrong
            /// </summary>
            [EnumMember(Value = "kEncryptionStrong")]
            KEncryptionStrong = 2,

            /// <summary>
            /// Enum KEncryptionWeak for value: kEncryptionWeak
            /// </summary>
            [EnumMember(Value = "kEncryptionWeak")]
            KEncryptionWeak = 3

        }

        /// <summary>
        /// Specifies the encryption setting for the Storage Domain (View Box). &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.
        /// </summary>
        /// <value>Specifies the encryption setting for the Storage Domain (View Box). &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted.</value>
        [DataMember(Name="encryptionPolicy", EmitDefaultValue=true)]
        public EncryptionPolicyEnum? EncryptionPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePolicy" /> class.
        /// </summary>
        /// <param name="appMarkerDetection">Specifies Whether to support app marker detection. When this is set to true, app markers (like commvault markers) will be removed from data and put in separate chunks. This way deduplication is improved as it is done on data that has no app markers..</param>
        /// <param name="cloudSpillVaultId">Specifies the vault id assigned for an external Storage Target to facilitate cloud spill..</param>
        /// <param name="compressionPolicy">Specifies the compression setting to be applied to a Storage Domain (View Box). &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed using LZ4 or Snappy. &#39;kCompressionHigh&#39; indicates that data is compressed in Gzip..</param>
        /// <param name="deduplicateCompressDelaySecs">Specifies the time in seconds when deduplication and compression of data on the Storage Domain (View Box) starts. If set to 0, deduplication and compression is done inline (as the data is being written). Otherwise, post-process deduplication and compression is done after the specified delay..</param>
        /// <param name="deduplicationEnabled">Specifies if deduplication is enabled for the Storage Domain (View Box). If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster thus reducing the amount of storage space needed to store data..</param>
        /// <param name="encryptionPolicy">Specifies the encryption setting for the Storage Domain (View Box). &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted..</param>
        /// <param name="erasureCodingInfo">erasureCodingInfo.</param>
        /// <param name="inlineCompress">Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled. If deduplication is set to inline, Cohesity recommends setting compression to inline..</param>
        /// <param name="inlineDeduplicate">Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled..</param>
        /// <param name="numFailuresTolerated">Number of disk failures to tolerate. This is an optional field. Default value is 1 for cluster having 3 or more nodes. If erasure coding is not enabled, then this specifies the replication factor for the Storage Domain (View Box). For RF&#x3D;2, number of failures to tolerate should be specified as 1. If erasure coding is enabled, then this value will be same as number of coded stripes..</param>
        /// <param name="numNodeFailuresTolerated">Number of node failures to tolerate. If NumNodeFailuresTolerated is set to 2, then we would tolerate up to two node failures. If the following is not set, then the number of node failures tolerated would be same as replication factor - 1 for replicated chunk files or number of coded stripes for erasure coding chunk files..</param>
        public StoragePolicy(bool? appMarkerDetection = default(bool?), long? cloudSpillVaultId = default(long?), CompressionPolicyEnum? compressionPolicy = default(CompressionPolicyEnum?), int? deduplicateCompressDelaySecs = default(int?), bool? deduplicationEnabled = default(bool?), EncryptionPolicyEnum? encryptionPolicy = default(EncryptionPolicyEnum?), ErasureCodingInfo erasureCodingInfo = default(ErasureCodingInfo), bool? inlineCompress = default(bool?), bool? inlineDeduplicate = default(bool?), int? numFailuresTolerated = default(int?), int? numNodeFailuresTolerated = default(int?))
        {
            this.AppMarkerDetection = appMarkerDetection;
            this.CloudSpillVaultId = cloudSpillVaultId;
            this.CompressionPolicy = compressionPolicy;
            this.DeduplicateCompressDelaySecs = deduplicateCompressDelaySecs;
            this.DeduplicationEnabled = deduplicationEnabled;
            this.EncryptionPolicy = encryptionPolicy;
            this.InlineCompress = inlineCompress;
            this.InlineDeduplicate = inlineDeduplicate;
            this.NumFailuresTolerated = numFailuresTolerated;
            this.NumNodeFailuresTolerated = numNodeFailuresTolerated;
            this.AppMarkerDetection = appMarkerDetection;
            this.CloudSpillVaultId = cloudSpillVaultId;
            this.CompressionPolicy = compressionPolicy;
            this.DeduplicateCompressDelaySecs = deduplicateCompressDelaySecs;
            this.DeduplicationEnabled = deduplicationEnabled;
            this.EncryptionPolicy = encryptionPolicy;
            this.ErasureCodingInfo = erasureCodingInfo;
            this.InlineCompress = inlineCompress;
            this.InlineDeduplicate = inlineDeduplicate;
            this.NumFailuresTolerated = numFailuresTolerated;
            this.NumNodeFailuresTolerated = numNodeFailuresTolerated;
        }
        
        /// <summary>
        /// Specifies Whether to support app marker detection. When this is set to true, app markers (like commvault markers) will be removed from data and put in separate chunks. This way deduplication is improved as it is done on data that has no app markers.
        /// </summary>
        /// <value>Specifies Whether to support app marker detection. When this is set to true, app markers (like commvault markers) will be removed from data and put in separate chunks. This way deduplication is improved as it is done on data that has no app markers.</value>
        [DataMember(Name="appMarkerDetection", EmitDefaultValue=true)]
        public bool? AppMarkerDetection { get; set; }

        /// <summary>
        /// Specifies the vault id assigned for an external Storage Target to facilitate cloud spill.
        /// </summary>
        /// <value>Specifies the vault id assigned for an external Storage Target to facilitate cloud spill.</value>
        [DataMember(Name="cloudSpillVaultId", EmitDefaultValue=true)]
        public long? CloudSpillVaultId { get; set; }

        /// <summary>
        /// Specifies the time in seconds when deduplication and compression of data on the Storage Domain (View Box) starts. If set to 0, deduplication and compression is done inline (as the data is being written). Otherwise, post-process deduplication and compression is done after the specified delay.
        /// </summary>
        /// <value>Specifies the time in seconds when deduplication and compression of data on the Storage Domain (View Box) starts. If set to 0, deduplication and compression is done inline (as the data is being written). Otherwise, post-process deduplication and compression is done after the specified delay.</value>
        [DataMember(Name="deduplicateCompressDelaySecs", EmitDefaultValue=true)]
        public int? DeduplicateCompressDelaySecs { get; set; }

        /// <summary>
        /// Specifies if deduplication is enabled for the Storage Domain (View Box). If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster thus reducing the amount of storage space needed to store data.
        /// </summary>
        /// <value>Specifies if deduplication is enabled for the Storage Domain (View Box). If deduplication is enabled, the Cohesity Cluster eliminates duplicate blocks of repeating data stored on the Cluster thus reducing the amount of storage space needed to store data.</value>
        [DataMember(Name="deduplicationEnabled", EmitDefaultValue=true)]
        public bool? DeduplicationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ErasureCodingInfo
        /// </summary>
        [DataMember(Name="erasureCodingInfo", EmitDefaultValue=false)]
        public ErasureCodingInfo ErasureCodingInfo { get; set; }

        /// <summary>
        /// Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled. If deduplication is set to inline, Cohesity recommends setting compression to inline.
        /// </summary>
        /// <value>Specifies if compression should occur inline (as the data is being written). This field is only relevant if compression is enabled. If deduplication is set to inline, Cohesity recommends setting compression to inline.</value>
        [DataMember(Name="inlineCompress", EmitDefaultValue=true)]
        public bool? InlineCompress { get; set; }

        /// <summary>
        /// Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.
        /// </summary>
        /// <value>Specifies if deduplication should occur inline (as the data is being written). This field is only relevant if deduplication is enabled.</value>
        [DataMember(Name="inlineDeduplicate", EmitDefaultValue=true)]
        public bool? InlineDeduplicate { get; set; }

        /// <summary>
        /// Number of disk failures to tolerate. This is an optional field. Default value is 1 for cluster having 3 or more nodes. If erasure coding is not enabled, then this specifies the replication factor for the Storage Domain (View Box). For RF&#x3D;2, number of failures to tolerate should be specified as 1. If erasure coding is enabled, then this value will be same as number of coded stripes.
        /// </summary>
        /// <value>Number of disk failures to tolerate. This is an optional field. Default value is 1 for cluster having 3 or more nodes. If erasure coding is not enabled, then this specifies the replication factor for the Storage Domain (View Box). For RF&#x3D;2, number of failures to tolerate should be specified as 1. If erasure coding is enabled, then this value will be same as number of coded stripes.</value>
        [DataMember(Name="numFailuresTolerated", EmitDefaultValue=true)]
        public int? NumFailuresTolerated { get; set; }

        /// <summary>
        /// Number of node failures to tolerate. If NumNodeFailuresTolerated is set to 2, then we would tolerate up to two node failures. If the following is not set, then the number of node failures tolerated would be same as replication factor - 1 for replicated chunk files or number of coded stripes for erasure coding chunk files.
        /// </summary>
        /// <value>Number of node failures to tolerate. If NumNodeFailuresTolerated is set to 2, then we would tolerate up to two node failures. If the following is not set, then the number of node failures tolerated would be same as replication factor - 1 for replicated chunk files or number of coded stripes for erasure coding chunk files.</value>
        [DataMember(Name="numNodeFailuresTolerated", EmitDefaultValue=true)]
        public int? NumNodeFailuresTolerated { get; set; }

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
            return this.Equals(input as StoragePolicy);
        }

        /// <summary>
        /// Returns true if StoragePolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of StoragePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppMarkerDetection == input.AppMarkerDetection ||
                    (this.AppMarkerDetection != null &&
                    this.AppMarkerDetection.Equals(input.AppMarkerDetection))
                ) && 
                (
                    this.CloudSpillVaultId == input.CloudSpillVaultId ||
                    (this.CloudSpillVaultId != null &&
                    this.CloudSpillVaultId.Equals(input.CloudSpillVaultId))
                ) && 
                (
                    this.CompressionPolicy == input.CompressionPolicy ||
                    this.CompressionPolicy.Equals(input.CompressionPolicy)
                ) && 
                (
                    this.DeduplicateCompressDelaySecs == input.DeduplicateCompressDelaySecs ||
                    (this.DeduplicateCompressDelaySecs != null &&
                    this.DeduplicateCompressDelaySecs.Equals(input.DeduplicateCompressDelaySecs))
                ) && 
                (
                    this.DeduplicationEnabled == input.DeduplicationEnabled ||
                    (this.DeduplicationEnabled != null &&
                    this.DeduplicationEnabled.Equals(input.DeduplicationEnabled))
                ) && 
                (
                    this.EncryptionPolicy == input.EncryptionPolicy ||
                    this.EncryptionPolicy.Equals(input.EncryptionPolicy)
                ) && 
                (
                    this.ErasureCodingInfo == input.ErasureCodingInfo ||
                    (this.ErasureCodingInfo != null &&
                    this.ErasureCodingInfo.Equals(input.ErasureCodingInfo))
                ) && 
                (
                    this.InlineCompress == input.InlineCompress ||
                    (this.InlineCompress != null &&
                    this.InlineCompress.Equals(input.InlineCompress))
                ) && 
                (
                    this.InlineDeduplicate == input.InlineDeduplicate ||
                    (this.InlineDeduplicate != null &&
                    this.InlineDeduplicate.Equals(input.InlineDeduplicate))
                ) && 
                (
                    this.NumFailuresTolerated == input.NumFailuresTolerated ||
                    (this.NumFailuresTolerated != null &&
                    this.NumFailuresTolerated.Equals(input.NumFailuresTolerated))
                ) && 
                (
                    this.NumNodeFailuresTolerated == input.NumNodeFailuresTolerated ||
                    (this.NumNodeFailuresTolerated != null &&
                    this.NumNodeFailuresTolerated.Equals(input.NumNodeFailuresTolerated))
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
                if (this.AppMarkerDetection != null)
                    hashCode = hashCode * 59 + this.AppMarkerDetection.GetHashCode();
                if (this.CloudSpillVaultId != null)
                    hashCode = hashCode * 59 + this.CloudSpillVaultId.GetHashCode();
                hashCode = hashCode * 59 + this.CompressionPolicy.GetHashCode();
                if (this.DeduplicateCompressDelaySecs != null)
                    hashCode = hashCode * 59 + this.DeduplicateCompressDelaySecs.GetHashCode();
                if (this.DeduplicationEnabled != null)
                    hashCode = hashCode * 59 + this.DeduplicationEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptionPolicy.GetHashCode();
                if (this.ErasureCodingInfo != null)
                    hashCode = hashCode * 59 + this.ErasureCodingInfo.GetHashCode();
                if (this.InlineCompress != null)
                    hashCode = hashCode * 59 + this.InlineCompress.GetHashCode();
                if (this.InlineDeduplicate != null)
                    hashCode = hashCode * 59 + this.InlineDeduplicate.GetHashCode();
                if (this.NumFailuresTolerated != null)
                    hashCode = hashCode * 59 + this.NumFailuresTolerated.GetHashCode();
                if (this.NumNodeFailuresTolerated != null)
                    hashCode = hashCode * 59 + this.NumNodeFailuresTolerated.GetHashCode();
                return hashCode;
            }
        }

    }

}

