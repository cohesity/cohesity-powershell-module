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
    /// AzureKmsConfiguration
    /// </summary>
    [DataContract]
    public partial class AzureKmsConfiguration :  IEquatable<AzureKmsConfiguration>
    {
        /// <summary>
        /// Specifies if its a cohesity managed or customer managed key vault. &#39;kCohesityManaged&#39; indicates an internal KMS object. &#39;kCustomerManaged&#39; indicates an Aws KMS object.
        /// </summary>
        /// <value>Specifies if its a cohesity managed or customer managed key vault. &#39;kCohesityManaged&#39; indicates an internal KMS object. &#39;kCustomerManaged&#39; indicates an Aws KMS object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VaultOwnerEnum
        {
            /// <summary>
            /// Enum KCohesityManaged for value: kCohesityManaged
            /// </summary>
            [EnumMember(Value = "kCohesityManaged")]
            KCohesityManaged = 1,

            /// <summary>
            /// Enum KCustomerManaged for value: kCustomerManaged
            /// </summary>
            [EnumMember(Value = "kCustomerManaged")]
            KCustomerManaged = 2

        }

        /// <summary>
        /// Specifies if its a cohesity managed or customer managed key vault. &#39;kCohesityManaged&#39; indicates an internal KMS object. &#39;kCustomerManaged&#39; indicates an Aws KMS object.
        /// </summary>
        /// <value>Specifies if its a cohesity managed or customer managed key vault. &#39;kCohesityManaged&#39; indicates an internal KMS object. &#39;kCustomerManaged&#39; indicates an Aws KMS object.</value>
        [DataMember(Name="vaultOwner", EmitDefaultValue=true)]
        public VaultOwnerEnum? VaultOwner { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureKmsConfiguration" /> class.
        /// </summary>
        /// <param name="cohesityKeyVault">cohesityKeyVault.</param>
        /// <param name="customerKeyVault">customerKeyVault.</param>
        /// <param name="vaultOwner">Specifies if its a cohesity managed or customer managed key vault. &#39;kCohesityManaged&#39; indicates an internal KMS object. &#39;kCustomerManaged&#39; indicates an Aws KMS object..</param>
        public AzureKmsConfiguration(KeyVaultParams cohesityKeyVault = default(KeyVaultParams), KeyVaultParams customerKeyVault = default(KeyVaultParams), VaultOwnerEnum? vaultOwner = default(VaultOwnerEnum?))
        {
            this.VaultOwner = vaultOwner;
            this.CohesityKeyVault = cohesityKeyVault;
            this.CustomerKeyVault = customerKeyVault;
            this.VaultOwner = vaultOwner;
        }
        
        /// <summary>
        /// Gets or Sets CohesityKeyVault
        /// </summary>
        [DataMember(Name="cohesityKeyVault", EmitDefaultValue=false)]
        public KeyVaultParams CohesityKeyVault { get; set; }

        /// <summary>
        /// Gets or Sets CustomerKeyVault
        /// </summary>
        [DataMember(Name="customerKeyVault", EmitDefaultValue=false)]
        public KeyVaultParams CustomerKeyVault { get; set; }

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
            return this.Equals(input as AzureKmsConfiguration);
        }

        /// <summary>
        /// Returns true if AzureKmsConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureKmsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureKmsConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CohesityKeyVault == input.CohesityKeyVault ||
                    (this.CohesityKeyVault != null &&
                    this.CohesityKeyVault.Equals(input.CohesityKeyVault))
                ) && 
                (
                    this.CustomerKeyVault == input.CustomerKeyVault ||
                    (this.CustomerKeyVault != null &&
                    this.CustomerKeyVault.Equals(input.CustomerKeyVault))
                ) && 
                (
                    this.VaultOwner == input.VaultOwner ||
                    this.VaultOwner.Equals(input.VaultOwner)
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
                if (this.CohesityKeyVault != null)
                    hashCode = hashCode * 59 + this.CohesityKeyVault.GetHashCode();
                if (this.CustomerKeyVault != null)
                    hashCode = hashCode * 59 + this.CustomerKeyVault.GetHashCode();
                hashCode = hashCode * 59 + this.VaultOwner.GetHashCode();
                return hashCode;
            }
        }

    }

}

