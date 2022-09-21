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
    /// VaultBandwidthLimits represents the network bandwidth limits while uploading/downloading data to/from the external media.
    /// </summary>
    [DataContract]
    public partial class VaultBandwidthLimits :  IEquatable<VaultBandwidthLimits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultBandwidthLimits" /> class.
        /// </summary>
        /// <param name="cloudTierDownload">cloudTierDownload.</param>
        /// <param name="cloudTierUpload">cloudTierUpload.</param>
        /// <param name="download">download.</param>
        /// <param name="upload">upload.</param>
        public VaultBandwidthLimits(BandwidthLimit cloudTierDownload = default(BandwidthLimit), BandwidthLimit cloudTierUpload = default(BandwidthLimit), BandwidthLimit download = default(BandwidthLimit), BandwidthLimit upload = default(BandwidthLimit))
        {
            this.CloudTierDownload = cloudTierDownload;
            this.CloudTierUpload = cloudTierUpload;
            this.Download = download;
            this.Upload = upload;
        }
        
        /// <summary>
        /// Gets or Sets CloudTierDownload
        /// </summary>
        [DataMember(Name="cloudTierDownload", EmitDefaultValue=false)]
        public BandwidthLimit CloudTierDownload { get; set; }

        /// <summary>
        /// Gets or Sets CloudTierUpload
        /// </summary>
        [DataMember(Name="cloudTierUpload", EmitDefaultValue=false)]
        public BandwidthLimit CloudTierUpload { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public BandwidthLimit Download { get; set; }

        /// <summary>
        /// Gets or Sets Upload
        /// </summary>
        [DataMember(Name="upload", EmitDefaultValue=false)]
        public BandwidthLimit Upload { get; set; }

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
            return this.Equals(input as VaultBandwidthLimits);
        }

        /// <summary>
        /// Returns true if VaultBandwidthLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultBandwidthLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultBandwidthLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudTierDownload == input.CloudTierDownload ||
                    (this.CloudTierDownload != null &&
                    this.CloudTierDownload.Equals(input.CloudTierDownload))
                ) && 
                (
                    this.CloudTierUpload == input.CloudTierUpload ||
                    (this.CloudTierUpload != null &&
                    this.CloudTierUpload.Equals(input.CloudTierUpload))
                ) && 
                (
                    this.Download == input.Download ||
                    (this.Download != null &&
                    this.Download.Equals(input.Download))
                ) && 
                (
                    this.Upload == input.Upload ||
                    (this.Upload != null &&
                    this.Upload.Equals(input.Upload))
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
                if (this.CloudTierDownload != null)
                    hashCode = hashCode * 59 + this.CloudTierDownload.GetHashCode();
                if (this.CloudTierUpload != null)
                    hashCode = hashCode * 59 + this.CloudTierUpload.GetHashCode();
                if (this.Download != null)
                    hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.Upload != null)
                    hashCode = hashCode * 59 + this.Upload.GetHashCode();
                return hashCode;
            }
        }

    }

}

