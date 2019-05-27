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
    /// Specifies the parameters the user wants to use when configuring encryption for the new Cluster.
    /// </summary>
    [DataContract]
    public partial class EncryptionConfiguration :  IEquatable<EncryptionConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionConfiguration" /> class.
        /// </summary>
        /// <param name="enableEncryption">Specifies whether or not to enable encryption. If encryption is enabled, all data on the Cluster will be encrypted. This can only be enabled at Cluster creation time and cannot be disabled later..</param>
        /// <param name="enableFipsMode">Specifies whether or not to enable FIPS mode. EnableEncryption must be set to true in order to enable FIPS..</param>
        /// <param name="rotationPeriod">Specifies the rotation period for encryption keys in days..</param>
        public EncryptionConfiguration(bool? enableEncryption = default(bool?), bool? enableFipsMode = default(bool?), int? rotationPeriod = default(int?))
        {
            this.EnableEncryption = enableEncryption;
            this.EnableFipsMode = enableFipsMode;
            this.RotationPeriod = rotationPeriod;
            this.EnableEncryption = enableEncryption;
            this.EnableFipsMode = enableFipsMode;
            this.RotationPeriod = rotationPeriod;
        }
        
        /// <summary>
        /// Specifies whether or not to enable encryption. If encryption is enabled, all data on the Cluster will be encrypted. This can only be enabled at Cluster creation time and cannot be disabled later.
        /// </summary>
        /// <value>Specifies whether or not to enable encryption. If encryption is enabled, all data on the Cluster will be encrypted. This can only be enabled at Cluster creation time and cannot be disabled later.</value>
        [DataMember(Name="enableEncryption", EmitDefaultValue=true)]
        public bool? EnableEncryption { get; set; }

        /// <summary>
        /// Specifies whether or not to enable FIPS mode. EnableEncryption must be set to true in order to enable FIPS.
        /// </summary>
        /// <value>Specifies whether or not to enable FIPS mode. EnableEncryption must be set to true in order to enable FIPS.</value>
        [DataMember(Name="enableFipsMode", EmitDefaultValue=true)]
        public bool? EnableFipsMode { get; set; }

        /// <summary>
        /// Specifies the rotation period for encryption keys in days.
        /// </summary>
        /// <value>Specifies the rotation period for encryption keys in days.</value>
        [DataMember(Name="rotationPeriod", EmitDefaultValue=true)]
        public int? RotationPeriod { get; set; }

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
            return this.Equals(input as EncryptionConfiguration);
        }

        /// <summary>
        /// Returns true if EncryptionConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptionConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableEncryption == input.EnableEncryption ||
                    (this.EnableEncryption != null &&
                    this.EnableEncryption.Equals(input.EnableEncryption))
                ) && 
                (
                    this.EnableFipsMode == input.EnableFipsMode ||
                    (this.EnableFipsMode != null &&
                    this.EnableFipsMode.Equals(input.EnableFipsMode))
                ) && 
                (
                    this.RotationPeriod == input.RotationPeriod ||
                    (this.RotationPeriod != null &&
                    this.RotationPeriod.Equals(input.RotationPeriod))
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
                if (this.EnableEncryption != null)
                    hashCode = hashCode * 59 + this.EnableEncryption.GetHashCode();
                if (this.EnableFipsMode != null)
                    hashCode = hashCode * 59 + this.EnableFipsMode.GetHashCode();
                if (this.RotationPeriod != null)
                    hashCode = hashCode * 59 + this.RotationPeriod.GetHashCode();
                return hashCode;
            }
        }

    }

}

