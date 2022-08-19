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
    /// LicensedUsage
    /// </summary>
    [DataContract]
    public partial class LicensedUsage :  IEquatable<LicensedUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensedUsage" /> class.
        /// </summary>
        /// <param name="capacityGiB">Feature usage by the cluster..</param>
        /// <param name="expiryTime">Expiry time(epoch) of each feature. There could be multiple expiry time for the given SKU..</param>
        /// <param name="featureName">Name of feature..</param>
        /// <param name="licenseType">Type of License.</param>
        /// <param name="numVm">Number of VM spinned..</param>
        /// <param name="productDescription">Detail description of entitlement.</param>
        /// <param name="productInfo">Short description of entitlement.</param>
        public LicensedUsage(long? capacityGiB = default(long?), long? expiryTime = default(long?), string featureName = default(string), string licenseType = default(string), long? numVm = default(long?), string productDescription = default(string), string productInfo = default(string))
        {
            this.CapacityGiB = capacityGiB;
            this.ExpiryTime = expiryTime;
            this.FeatureName = featureName;
            this.LicenseType = licenseType;
            this.NumVm = numVm;
            this.ProductDescription = productDescription;
            this.ProductInfo = productInfo;
        }
        
        /// <summary>
        /// Feature usage by the cluster.
        /// </summary>
        /// <value>Feature usage by the cluster.</value>
        [DataMember(Name="capacityGiB", EmitDefaultValue=true)]
        public long? CapacityGiB { get; set; }

        /// <summary>
        /// Expiry time(epoch) of each feature. There could be multiple expiry time for the given SKU.
        /// </summary>
        /// <value>Expiry time(epoch) of each feature. There could be multiple expiry time for the given SKU.</value>
        [DataMember(Name="expiryTime", EmitDefaultValue=true)]
        public long? ExpiryTime { get; set; }

        /// <summary>
        /// Name of feature.
        /// </summary>
        /// <value>Name of feature.</value>
        [DataMember(Name="featureName", EmitDefaultValue=true)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Type of License
        /// </summary>
        /// <value>Type of License</value>
        [DataMember(Name="licenseType", EmitDefaultValue=true)]
        public string LicenseType { get; set; }

        /// <summary>
        /// Number of VM spinned.
        /// </summary>
        /// <value>Number of VM spinned.</value>
        [DataMember(Name="numVm", EmitDefaultValue=true)]
        public long? NumVm { get; set; }

        /// <summary>
        /// Detail description of entitlement
        /// </summary>
        /// <value>Detail description of entitlement</value>
        [DataMember(Name="productDescription", EmitDefaultValue=true)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Short description of entitlement
        /// </summary>
        /// <value>Short description of entitlement</value>
        [DataMember(Name="productInfo", EmitDefaultValue=true)]
        public string ProductInfo { get; set; }

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
            return this.Equals(input as LicensedUsage);
        }

        /// <summary>
        /// Returns true if LicensedUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensedUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensedUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityGiB == input.CapacityGiB ||
                    (this.CapacityGiB != null &&
                    this.CapacityGiB.Equals(input.CapacityGiB))
                ) && 
                (
                    this.ExpiryTime == input.ExpiryTime ||
                    (this.ExpiryTime != null &&
                    this.ExpiryTime.Equals(input.ExpiryTime))
                ) && 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) && 
                (
                    this.LicenseType == input.LicenseType ||
                    (this.LicenseType != null &&
                    this.LicenseType.Equals(input.LicenseType))
                ) && 
                (
                    this.NumVm == input.NumVm ||
                    (this.NumVm != null &&
                    this.NumVm.Equals(input.NumVm))
                ) && 
                (
                    this.ProductDescription == input.ProductDescription ||
                    (this.ProductDescription != null &&
                    this.ProductDescription.Equals(input.ProductDescription))
                ) && 
                (
                    this.ProductInfo == input.ProductInfo ||
                    (this.ProductInfo != null &&
                    this.ProductInfo.Equals(input.ProductInfo))
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
                if (this.CapacityGiB != null)
                    hashCode = hashCode * 59 + this.CapacityGiB.GetHashCode();
                if (this.ExpiryTime != null)
                    hashCode = hashCode * 59 + this.ExpiryTime.GetHashCode();
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.LicenseType != null)
                    hashCode = hashCode * 59 + this.LicenseType.GetHashCode();
                if (this.NumVm != null)
                    hashCode = hashCode * 59 + this.NumVm.GetHashCode();
                if (this.ProductDescription != null)
                    hashCode = hashCode * 59 + this.ProductDescription.GetHashCode();
                if (this.ProductInfo != null)
                    hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

