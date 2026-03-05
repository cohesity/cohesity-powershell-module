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
    /// EntitlementBannerInfo
    /// </summary>
    [DataContract]
    public partial class EntitlementBannerInfo :  IEquatable<EntitlementBannerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementBannerInfo" /> class.
        /// </summary>
        /// <param name="bannerSeverity">Severity of banner to display Enum: [Info Warning Error].</param>
        /// <param name="bannerType">Type of banner to display Enum: [PreExpiration Expired].</param>
        /// <param name="showBanner">Flag to Show or hide the Warning Banner in Helios.</param>
        public EntitlementBannerInfo(string bannerSeverity = default(string), string bannerType = default(string), bool? showBanner = default(bool?))
        {
            this.BannerSeverity = bannerSeverity;
            this.BannerType = bannerType;
            this.ShowBanner = showBanner;
            this.BannerSeverity = bannerSeverity;
            this.BannerType = bannerType;
            this.ShowBanner = showBanner;
        }
        
        /// <summary>
        /// Severity of banner to display Enum: [Info Warning Error]
        /// </summary>
        /// <value>Severity of banner to display Enum: [Info Warning Error]</value>
        [DataMember(Name="bannerSeverity", EmitDefaultValue=true)]
        public string BannerSeverity { get; set; }

        /// <summary>
        /// Type of banner to display Enum: [PreExpiration Expired]
        /// </summary>
        /// <value>Type of banner to display Enum: [PreExpiration Expired]</value>
        [DataMember(Name="bannerType", EmitDefaultValue=true)]
        public string BannerType { get; set; }

        /// <summary>
        /// Flag to Show or hide the Warning Banner in Helios
        /// </summary>
        /// <value>Flag to Show or hide the Warning Banner in Helios</value>
        [DataMember(Name="showBanner", EmitDefaultValue=true)]
        public bool? ShowBanner { get; set; }

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
            return this.Equals(input as EntitlementBannerInfo);
        }

        /// <summary>
        /// Returns true if EntitlementBannerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitlementBannerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitlementBannerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BannerSeverity == input.BannerSeverity ||
                    (this.BannerSeverity != null &&
                    this.BannerSeverity.Equals(input.BannerSeverity))
                ) && 
                (
                    this.BannerType == input.BannerType ||
                    (this.BannerType != null &&
                    this.BannerType.Equals(input.BannerType))
                ) && 
                (
                    this.ShowBanner == input.ShowBanner ||
                    (this.ShowBanner != null &&
                    this.ShowBanner.Equals(input.ShowBanner))
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
                if (this.BannerSeverity != null)
                    hashCode = hashCode * 59 + this.BannerSeverity.GetHashCode();
                if (this.BannerType != null)
                    hashCode = hashCode * 59 + this.BannerType.GetHashCode();
                if (this.ShowBanner != null)
                    hashCode = hashCode * 59 + this.ShowBanner.GetHashCode();
                return hashCode;
            }
        }

    }

}

