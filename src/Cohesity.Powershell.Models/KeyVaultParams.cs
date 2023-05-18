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
    /// KeyVaultParams
    /// </summary>
    [DataContract]
    public partial class KeyVaultParams :  IEquatable<KeyVaultParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVaultParams" /> class.
        /// </summary>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="customerSecretName">Specifies the name of client secret stored in cohesity keyvault. This is used only for customer managed keys..</param>
        /// <param name="keyName">Specifies the Key name used to encrypt and decrypt DEK..</param>
        /// <param name="keyvaultUrl">Specifies the URL of the Azure key vault..</param>
        public KeyVaultParams(AzureKmsCredentials azureCredentials = default(AzureKmsCredentials), string customerSecretName = default(string), string keyName = default(string), string keyvaultUrl = default(string))
        {
            this.CustomerSecretName = customerSecretName;
            this.KeyName = keyName;
            this.KeyvaultUrl = keyvaultUrl;
            this.AzureCredentials = azureCredentials;
            this.CustomerSecretName = customerSecretName;
            this.KeyName = keyName;
            this.KeyvaultUrl = keyvaultUrl;
        }
        
        /// <summary>
        /// Gets or Sets AzureCredentials
        /// </summary>
        [DataMember(Name="azureCredentials", EmitDefaultValue=false)]
        public AzureKmsCredentials AzureCredentials { get; set; }

        /// <summary>
        /// Specifies the name of client secret stored in cohesity keyvault. This is used only for customer managed keys.
        /// </summary>
        /// <value>Specifies the name of client secret stored in cohesity keyvault. This is used only for customer managed keys.</value>
        [DataMember(Name="customerSecretName", EmitDefaultValue=true)]
        public string CustomerSecretName { get; set; }

        /// <summary>
        /// Specifies the Key name used to encrypt and decrypt DEK.
        /// </summary>
        /// <value>Specifies the Key name used to encrypt and decrypt DEK.</value>
        [DataMember(Name="keyName", EmitDefaultValue=true)]
        public string KeyName { get; set; }

        /// <summary>
        /// Specifies the URL of the Azure key vault.
        /// </summary>
        /// <value>Specifies the URL of the Azure key vault.</value>
        [DataMember(Name="keyvaultUrl", EmitDefaultValue=true)]
        public string KeyvaultUrl { get; set; }

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
            return this.Equals(input as KeyVaultParams);
        }

        /// <summary>
        /// Returns true if KeyVaultParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KeyVaultParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyVaultParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AzureCredentials == input.AzureCredentials ||
                    (this.AzureCredentials != null &&
                    this.AzureCredentials.Equals(input.AzureCredentials))
                ) && 
                (
                    this.CustomerSecretName == input.CustomerSecretName ||
                    (this.CustomerSecretName != null &&
                    this.CustomerSecretName.Equals(input.CustomerSecretName))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.KeyvaultUrl == input.KeyvaultUrl ||
                    (this.KeyvaultUrl != null &&
                    this.KeyvaultUrl.Equals(input.KeyvaultUrl))
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
                if (this.AzureCredentials != null)
                    hashCode = hashCode * 59 + this.AzureCredentials.GetHashCode();
                if (this.CustomerSecretName != null)
                    hashCode = hashCode * 59 + this.CustomerSecretName.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.KeyvaultUrl != null)
                    hashCode = hashCode * 59 + this.KeyvaultUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

