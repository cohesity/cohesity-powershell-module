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
    /// Specifies the antivirus scan config settings for this View.
    /// </summary>
    [DataContract]
    public partial class AntivirusScanConfig :  IEquatable<AntivirusScanConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusScanConfig" /> class.
        /// </summary>
        /// <param name="blockAccessOnScanFailure">Specifies whether block access to the file when antivirus scan fails..</param>
        /// <param name="isEnabled">Specifies whether the antivirus service is enabled or not..</param>
        /// <param name="maximumScanFileSize">Specifies maximum file size that will be sent to antivirus server for scanning. if greater than zero, the file size that exceeds this size would be skipped from virus scan..</param>
        /// <param name="prefixScanFilter">prefixScanFilter.</param>
        /// <param name="s3TaggingFilter">s3TaggingFilter.</param>
        /// <param name="scanFilter">scanFilter.</param>
        /// <param name="scanOnAccess">Specifies whether to scan a SMB file or S3 object before it is opened/GET..</param>
        /// <param name="scanOnClose">Specifies whether to scan a SMB file when it is closed after modify..</param>
        /// <param name="scanOnPut">Specifies whether to scan a S3 object after it is PUT..</param>
        /// <param name="scanTimeoutUsecs">Specifies the maximum amount of time that a scan can take before timing out..</param>
        public AntivirusScanConfig(bool? blockAccessOnScanFailure = default(bool?), bool? isEnabled = default(bool?), long? maximumScanFileSize = default(long?), FileExtensionFilter prefixScanFilter = default(FileExtensionFilter), S3TaggingFilter s3TaggingFilter = default(S3TaggingFilter), FileExtensionFilter scanFilter = default(FileExtensionFilter), bool? scanOnAccess = default(bool?), bool? scanOnClose = default(bool?), bool? scanOnPut = default(bool?), int? scanTimeoutUsecs = default(int?))
        {
            this.BlockAccessOnScanFailure = blockAccessOnScanFailure;
            this.IsEnabled = isEnabled;
            this.MaximumScanFileSize = maximumScanFileSize;
            this.ScanOnAccess = scanOnAccess;
            this.ScanOnClose = scanOnClose;
            this.ScanOnPut = scanOnPut;
            this.ScanTimeoutUsecs = scanTimeoutUsecs;
            this.BlockAccessOnScanFailure = blockAccessOnScanFailure;
            this.IsEnabled = isEnabled;
            this.MaximumScanFileSize = maximumScanFileSize;
            this.PrefixScanFilter = prefixScanFilter;
            this.S3TaggingFilter = s3TaggingFilter;
            this.ScanFilter = scanFilter;
            this.ScanOnAccess = scanOnAccess;
            this.ScanOnClose = scanOnClose;
            this.ScanOnPut = scanOnPut;
            this.ScanTimeoutUsecs = scanTimeoutUsecs;
        }
        
        /// <summary>
        /// Specifies whether block access to the file when antivirus scan fails.
        /// </summary>
        /// <value>Specifies whether block access to the file when antivirus scan fails.</value>
        [DataMember(Name="blockAccessOnScanFailure", EmitDefaultValue=true)]
        public bool? BlockAccessOnScanFailure { get; set; }

        /// <summary>
        /// Specifies whether the antivirus service is enabled or not.
        /// </summary>
        /// <value>Specifies whether the antivirus service is enabled or not.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Specifies maximum file size that will be sent to antivirus server for scanning. if greater than zero, the file size that exceeds this size would be skipped from virus scan.
        /// </summary>
        /// <value>Specifies maximum file size that will be sent to antivirus server for scanning. if greater than zero, the file size that exceeds this size would be skipped from virus scan.</value>
        [DataMember(Name="maximumScanFileSize", EmitDefaultValue=true)]
        public long? MaximumScanFileSize { get; set; }

        /// <summary>
        /// Gets or Sets PrefixScanFilter
        /// </summary>
        [DataMember(Name="prefixScanFilter", EmitDefaultValue=false)]
        public FileExtensionFilter PrefixScanFilter { get; set; }

        /// <summary>
        /// Gets or Sets S3TaggingFilter
        /// </summary>
        [DataMember(Name="s3TaggingFilter", EmitDefaultValue=false)]
        public S3TaggingFilter S3TaggingFilter { get; set; }

        /// <summary>
        /// Gets or Sets ScanFilter
        /// </summary>
        [DataMember(Name="scanFilter", EmitDefaultValue=false)]
        public FileExtensionFilter ScanFilter { get; set; }

        /// <summary>
        /// Specifies whether to scan a SMB file or S3 object before it is opened/GET.
        /// </summary>
        /// <value>Specifies whether to scan a SMB file or S3 object before it is opened/GET.</value>
        [DataMember(Name="scanOnAccess", EmitDefaultValue=true)]
        public bool? ScanOnAccess { get; set; }

        /// <summary>
        /// Specifies whether to scan a SMB file when it is closed after modify.
        /// </summary>
        /// <value>Specifies whether to scan a SMB file when it is closed after modify.</value>
        [DataMember(Name="scanOnClose", EmitDefaultValue=true)]
        public bool? ScanOnClose { get; set; }

        /// <summary>
        /// Specifies whether to scan a S3 object after it is PUT.
        /// </summary>
        /// <value>Specifies whether to scan a S3 object after it is PUT.</value>
        [DataMember(Name="scanOnPut", EmitDefaultValue=true)]
        public bool? ScanOnPut { get; set; }

        /// <summary>
        /// Specifies the maximum amount of time that a scan can take before timing out.
        /// </summary>
        /// <value>Specifies the maximum amount of time that a scan can take before timing out.</value>
        [DataMember(Name="scanTimeoutUsecs", EmitDefaultValue=true)]
        public int? ScanTimeoutUsecs { get; set; }

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
            return this.Equals(input as AntivirusScanConfig);
        }

        /// <summary>
        /// Returns true if AntivirusScanConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusScanConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusScanConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockAccessOnScanFailure == input.BlockAccessOnScanFailure ||
                    (this.BlockAccessOnScanFailure != null &&
                    this.BlockAccessOnScanFailure.Equals(input.BlockAccessOnScanFailure))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.MaximumScanFileSize == input.MaximumScanFileSize ||
                    (this.MaximumScanFileSize != null &&
                    this.MaximumScanFileSize.Equals(input.MaximumScanFileSize))
                ) && 
                (
                    this.PrefixScanFilter == input.PrefixScanFilter ||
                    (this.PrefixScanFilter != null &&
                    this.PrefixScanFilter.Equals(input.PrefixScanFilter))
                ) && 
                (
                    this.S3TaggingFilter == input.S3TaggingFilter ||
                    (this.S3TaggingFilter != null &&
                    this.S3TaggingFilter.Equals(input.S3TaggingFilter))
                ) && 
                (
                    this.ScanFilter == input.ScanFilter ||
                    (this.ScanFilter != null &&
                    this.ScanFilter.Equals(input.ScanFilter))
                ) && 
                (
                    this.ScanOnAccess == input.ScanOnAccess ||
                    (this.ScanOnAccess != null &&
                    this.ScanOnAccess.Equals(input.ScanOnAccess))
                ) && 
                (
                    this.ScanOnClose == input.ScanOnClose ||
                    (this.ScanOnClose != null &&
                    this.ScanOnClose.Equals(input.ScanOnClose))
                ) && 
                (
                    this.ScanOnPut == input.ScanOnPut ||
                    (this.ScanOnPut != null &&
                    this.ScanOnPut.Equals(input.ScanOnPut))
                ) && 
                (
                    this.ScanTimeoutUsecs == input.ScanTimeoutUsecs ||
                    (this.ScanTimeoutUsecs != null &&
                    this.ScanTimeoutUsecs.Equals(input.ScanTimeoutUsecs))
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
                if (this.BlockAccessOnScanFailure != null)
                    hashCode = hashCode * 59 + this.BlockAccessOnScanFailure.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.MaximumScanFileSize != null)
                    hashCode = hashCode * 59 + this.MaximumScanFileSize.GetHashCode();
                if (this.PrefixScanFilter != null)
                    hashCode = hashCode * 59 + this.PrefixScanFilter.GetHashCode();
                if (this.S3TaggingFilter != null)
                    hashCode = hashCode * 59 + this.S3TaggingFilter.GetHashCode();
                if (this.ScanFilter != null)
                    hashCode = hashCode * 59 + this.ScanFilter.GetHashCode();
                if (this.ScanOnAccess != null)
                    hashCode = hashCode * 59 + this.ScanOnAccess.GetHashCode();
                if (this.ScanOnClose != null)
                    hashCode = hashCode * 59 + this.ScanOnClose.GetHashCode();
                if (this.ScanOnPut != null)
                    hashCode = hashCode * 59 + this.ScanOnPut.GetHashCode();
                if (this.ScanTimeoutUsecs != null)
                    hashCode = hashCode * 59 + this.ScanTimeoutUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

