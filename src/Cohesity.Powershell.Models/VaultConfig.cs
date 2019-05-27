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
    /// Specifies the settings required to connect to a specific Vault type. For some Vaults, you must also specify a storage location (bucketName).
    /// </summary>
    [DataContract]
    public partial class VaultConfig :  IEquatable<VaultConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultConfig" /> class.
        /// </summary>
        /// <param name="amazon">amazon.</param>
        /// <param name="azure">azure.</param>
        /// <param name="bucketName">Specifies the name of a storage location of the Vault, where objects are stored. For Google and AMS, this storage location is called a bucket. For Microsoft Azure, this storage location is called a container. For QStar and NAS, you do not specify a storage location..</param>
        /// <param name="google">google.</param>
        /// <param name="nas">nas.</param>
        /// <param name="oracle">oracle.</param>
        /// <param name="qstar">qstar.</param>
        public VaultConfig(AmazonCloudCredentials amazon = default(AmazonCloudCredentials), AzureCloudCredentials azure = default(AzureCloudCredentials), string bucketName = default(string), GoogleCloudCredentials google = default(GoogleCloudCredentials), NasCredentials nas = default(NasCredentials), OracleCloudCredentials oracle = default(OracleCloudCredentials), QStarServerCredentials qstar = default(QStarServerCredentials))
        {
            this.BucketName = bucketName;
            this.Amazon = amazon;
            this.Azure = azure;
            this.BucketName = bucketName;
            this.Google = google;
            this.Nas = nas;
            this.Oracle = oracle;
            this.Qstar = qstar;
        }
        
        /// <summary>
        /// Gets or Sets Amazon
        /// </summary>
        [DataMember(Name="amazon", EmitDefaultValue=false)]
        public AmazonCloudCredentials Amazon { get; set; }

        /// <summary>
        /// Gets or Sets Azure
        /// </summary>
        [DataMember(Name="azure", EmitDefaultValue=false)]
        public AzureCloudCredentials Azure { get; set; }

        /// <summary>
        /// Specifies the name of a storage location of the Vault, where objects are stored. For Google and AMS, this storage location is called a bucket. For Microsoft Azure, this storage location is called a container. For QStar and NAS, you do not specify a storage location.
        /// </summary>
        /// <value>Specifies the name of a storage location of the Vault, where objects are stored. For Google and AMS, this storage location is called a bucket. For Microsoft Azure, this storage location is called a container. For QStar and NAS, you do not specify a storage location.</value>
        [DataMember(Name="bucketName", EmitDefaultValue=true)]
        public string BucketName { get; set; }

        /// <summary>
        /// Gets or Sets Google
        /// </summary>
        [DataMember(Name="google", EmitDefaultValue=false)]
        public GoogleCloudCredentials Google { get; set; }

        /// <summary>
        /// Gets or Sets Nas
        /// </summary>
        [DataMember(Name="nas", EmitDefaultValue=false)]
        public NasCredentials Nas { get; set; }

        /// <summary>
        /// Gets or Sets Oracle
        /// </summary>
        [DataMember(Name="oracle", EmitDefaultValue=false)]
        public OracleCloudCredentials Oracle { get; set; }

        /// <summary>
        /// Gets or Sets Qstar
        /// </summary>
        [DataMember(Name="qstar", EmitDefaultValue=false)]
        public QStarServerCredentials Qstar { get; set; }

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
            return this.Equals(input as VaultConfig);
        }

        /// <summary>
        /// Returns true if VaultConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amazon == input.Amazon ||
                    (this.Amazon != null &&
                    this.Amazon.Equals(input.Amazon))
                ) && 
                (
                    this.Azure == input.Azure ||
                    (this.Azure != null &&
                    this.Azure.Equals(input.Azure))
                ) && 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.Google == input.Google ||
                    (this.Google != null &&
                    this.Google.Equals(input.Google))
                ) && 
                (
                    this.Nas == input.Nas ||
                    (this.Nas != null &&
                    this.Nas.Equals(input.Nas))
                ) && 
                (
                    this.Oracle == input.Oracle ||
                    (this.Oracle != null &&
                    this.Oracle.Equals(input.Oracle))
                ) && 
                (
                    this.Qstar == input.Qstar ||
                    (this.Qstar != null &&
                    this.Qstar.Equals(input.Qstar))
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
                if (this.Amazon != null)
                    hashCode = hashCode * 59 + this.Amazon.GetHashCode();
                if (this.Azure != null)
                    hashCode = hashCode * 59 + this.Azure.GetHashCode();
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Google != null)
                    hashCode = hashCode * 59 + this.Google.GetHashCode();
                if (this.Nas != null)
                    hashCode = hashCode * 59 + this.Nas.GetHashCode();
                if (this.Oracle != null)
                    hashCode = hashCode * 59 + this.Oracle.GetHashCode();
                if (this.Qstar != null)
                    hashCode = hashCode * 59 + this.Qstar.GetHashCode();
                return hashCode;
            }
        }

    }

}

