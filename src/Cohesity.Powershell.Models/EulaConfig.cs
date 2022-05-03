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
    /// Specifies the End User License Agreement acceptance information.
    /// </summary>
    [DataContract]
    public partial class EulaConfig :  IEquatable<EulaConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EulaConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EulaConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EulaConfig" /> class.
        /// </summary>
        /// <param name="licenseKey">Specifies the license key. (required).</param>
        /// <param name="signedVersion">Specifies the version of the End User License Agreement that was accepted. (required).</param>
        public EulaConfig(string licenseKey = default(string), long? signedVersion = default(long?))
        {
            // to ensure "licenseKey" is required (not null)
            if (licenseKey == null)
            {
                throw new InvalidDataException("licenseKey is a required property for EulaConfig and cannot be null");
            }
            else
            {
                this.LicenseKey = licenseKey;
            }
            // to ensure "signedVersion" is required (not null)
            if (signedVersion == null)
            {
                throw new InvalidDataException("signedVersion is a required property for EulaConfig and cannot be null");
            }
            else
            {
                this.SignedVersion = signedVersion;
            }
        }
        
        /// <summary>
        /// Specifies the license key.
        /// </summary>
        /// <value>Specifies the license key.</value>
        [DataMember(Name="licenseKey", EmitDefaultValue=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Specifies the login account name for the Cohesity user who accepted the End User License Agreement.
        /// </summary>
        /// <value>Specifies the login account name for the Cohesity user who accepted the End User License Agreement.</value>
        [DataMember(Name="signedByUser", EmitDefaultValue=false)]
        public string SignedByUser { get; private set; }

        /// <summary>
        /// Specifies the time that the End User License Agreement was accepted.
        /// </summary>
        /// <value>Specifies the time that the End User License Agreement was accepted.</value>
        [DataMember(Name="signedTime", EmitDefaultValue=false)]
        public long? SignedTime { get; private set; }

        /// <summary>
        /// Specifies the version of the End User License Agreement that was accepted.
        /// </summary>
        /// <value>Specifies the version of the End User License Agreement that was accepted.</value>
        [DataMember(Name="signedVersion", EmitDefaultValue=false)]
        public long? SignedVersion { get; set; }

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
            return this.Equals(input as EulaConfig);
        }

        /// <summary>
        /// Returns true if EulaConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of EulaConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EulaConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LicenseKey == input.LicenseKey ||
                    (this.LicenseKey != null &&
                    this.LicenseKey.Equals(input.LicenseKey))
                ) && 
                (
                    this.SignedByUser == input.SignedByUser ||
                    (this.SignedByUser != null &&
                    this.SignedByUser.Equals(input.SignedByUser))
                ) && 
                (
                    this.SignedTime == input.SignedTime ||
                    (this.SignedTime != null &&
                    this.SignedTime.Equals(input.SignedTime))
                ) && 
                (
                    this.SignedVersion == input.SignedVersion ||
                    (this.SignedVersion != null &&
                    this.SignedVersion.Equals(input.SignedVersion))
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
                if (this.LicenseKey != null)
                    hashCode = hashCode * 59 + this.LicenseKey.GetHashCode();
                if (this.SignedByUser != null)
                    hashCode = hashCode * 59 + this.SignedByUser.GetHashCode();
                if (this.SignedTime != null)
                    hashCode = hashCode * 59 + this.SignedTime.GetHashCode();
                if (this.SignedVersion != null)
                    hashCode = hashCode * 59 + this.SignedVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}

