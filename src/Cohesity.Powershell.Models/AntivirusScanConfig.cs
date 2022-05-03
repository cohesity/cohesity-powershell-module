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
        /// <param name="scanFilter">scanFilter.</param>
        /// <param name="scanOnAccess">Specifies whether to scan a file when it is opened..</param>
        /// <param name="scanOnClose">Specifies whether to scan a file when it is closed after modify..</param>
        /// <param name="scanTimeoutUsecs">Specifies the maximum amount of time that a scan can take before timing out..</param>
        public AntivirusScanConfig(bool? blockAccessOnScanFailure = default(bool?), bool? isEnabled = default(bool?), long? maximumScanFileSize = default(long?), FileExtensionFilter scanFilter = default(FileExtensionFilter), bool? scanOnAccess = default(bool?), bool? scanOnClose = default(bool?), int? scanTimeoutUsecs = default(int?))
        {
            this.BlockAccessOnScanFailure = blockAccessOnScanFailure;
            this.IsEnabled = isEnabled;
            this.MaximumScanFileSize = maximumScanFileSize;
            this.ScanFilter = scanFilter;
            this.ScanOnAccess = scanOnAccess;
            this.ScanOnClose = scanOnClose;
            this.ScanTimeoutUsecs = scanTimeoutUsecs;
        }
        
        /// <summary>
        /// Specifies whether block access to the file when antivirus scan fails.
        /// </summary>
        /// <value>Specifies whether block access to the file when antivirus scan fails.</value>
        [DataMember(Name="blockAccessOnScanFailure", EmitDefaultValue=false)]
        public bool? BlockAccessOnScanFailure { get; set; }

        /// <summary>
        /// Specifies whether the antivirus service is enabled or not.
        /// </summary>
        /// <value>Specifies whether the antivirus service is enabled or not.</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Specifies maximum file size that will be sent to antivirus server for scanning. if greater than zero, the file size that exceeds this size would be skipped from virus scan.
        /// </summary>
        /// <value>Specifies maximum file size that will be sent to antivirus server for scanning. if greater than zero, the file size that exceeds this size would be skipped from virus scan.</value>
        [DataMember(Name="maximumScanFileSize", EmitDefaultValue=false)]
        public long? MaximumScanFileSize { get; set; }

        /// <summary>
        /// Gets or Sets ScanFilter
        /// </summary>
        [DataMember(Name="scanFilter", EmitDefaultValue=false)]
        public FileExtensionFilter ScanFilter { get; set; }

        /// <summary>
        /// Specifies whether to scan a file when it is opened.
        /// </summary>
        /// <value>Specifies whether to scan a file when it is opened.</value>
        [DataMember(Name="scanOnAccess", EmitDefaultValue=false)]
        public bool? ScanOnAccess { get; set; }

        /// <summary>
        /// Specifies whether to scan a file when it is closed after modify.
        /// </summary>
        /// <value>Specifies whether to scan a file when it is closed after modify.</value>
        [DataMember(Name="scanOnClose", EmitDefaultValue=false)]
        public bool? ScanOnClose { get; set; }

        /// <summary>
        /// Specifies the maximum amount of time that a scan can take before timing out.
        /// </summary>
        /// <value>Specifies the maximum amount of time that a scan can take before timing out.</value>
        [DataMember(Name="scanTimeoutUsecs", EmitDefaultValue=false)]
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
                if (this.ScanFilter != null)
                    hashCode = hashCode * 59 + this.ScanFilter.GetHashCode();
                if (this.ScanOnAccess != null)
                    hashCode = hashCode * 59 + this.ScanOnAccess.GetHashCode();
                if (this.ScanOnClose != null)
                    hashCode = hashCode * 59 + this.ScanOnClose.GetHashCode();
                if (this.ScanTimeoutUsecs != null)
                    hashCode = hashCode * 59 + this.ScanTimeoutUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

