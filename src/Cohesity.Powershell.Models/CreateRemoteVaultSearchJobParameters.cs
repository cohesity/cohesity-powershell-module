// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies settings required to create a search of a remote Vault for data that has been archived from other Clusters.
    /// </summary>
    [DataContract]
    public partial class CreateRemoteVaultSearchJobParameters :  IEquatable<CreateRemoteVaultSearchJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultSearchJobParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRemoteVaultSearchJobParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultSearchJobParameters" /> class.
        /// </summary>
        /// <param name="clusterMatchString">Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results..</param>
        /// <param name="encryptionKeys">Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified..</param>
        /// <param name="endTimeUsecs">Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results..</param>
        /// <param name="jobMatchString">Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results..</param>
        /// <param name="searchJobName">Specifies the search Job name. (required).</param>
        /// <param name="startTimeUsecs">Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results..</param>
        /// <param name="vaultId">Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target. (required).</param>
        public CreateRemoteVaultSearchJobParameters(string clusterMatchString = default(string), List<VaultEncryptionKey> encryptionKeys = default(List<VaultEncryptionKey>), long? endTimeUsecs = default(long?), string jobMatchString = default(string), string searchJobName = default(string), long? startTimeUsecs = default(long?), long? vaultId = default(long?))
        {
            // to ensure "searchJobName" is required (not null)
            if (searchJobName == null)
            {
                throw new InvalidDataException("searchJobName is a required property for CreateRemoteVaultSearchJobParameters and cannot be null");
            }
            else
            {
                this.SearchJobName = searchJobName;
            }
            // to ensure "vaultId" is required (not null)
            if (vaultId == null)
            {
                throw new InvalidDataException("vaultId is a required property for CreateRemoteVaultSearchJobParameters and cannot be null");
            }
            else
            {
                this.VaultId = vaultId;
            }
            this.ClusterMatchString = clusterMatchString;
            this.EncryptionKeys = encryptionKeys;
            this.EndTimeUsecs = endTimeUsecs;
            this.JobMatchString = jobMatchString;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results.
        /// </summary>
        /// <value>Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results.</value>
        [DataMember(Name="clusterMatchString", EmitDefaultValue=false)]
        public string ClusterMatchString { get; set; }

        /// <summary>
        /// Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified.
        /// </summary>
        /// <value>Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified.</value>
        [DataMember(Name="encryptionKeys", EmitDefaultValue=false)]
        public List<VaultEncryptionKey> EncryptionKeys { get; set; }

        /// <summary>
        /// Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results.
        /// </summary>
        /// <value>Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results.
        /// </summary>
        /// <value>Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results.</value>
        [DataMember(Name="jobMatchString", EmitDefaultValue=false)]
        public string JobMatchString { get; set; }

        /// <summary>
        /// Specifies the search Job name.
        /// </summary>
        /// <value>Specifies the search Job name.</value>
        [DataMember(Name="searchJobName", EmitDefaultValue=false)]
        public string SearchJobName { get; set; }

        /// <summary>
        /// Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results.
        /// </summary>
        /// <value>Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target.
        /// </summary>
        /// <value>Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as CreateRemoteVaultSearchJobParameters);
        }

        /// <summary>
        /// Returns true if CreateRemoteVaultSearchJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRemoteVaultSearchJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRemoteVaultSearchJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterMatchString == input.ClusterMatchString ||
                    (this.ClusterMatchString != null &&
                    this.ClusterMatchString.Equals(input.ClusterMatchString))
                ) && 
                (
                    this.EncryptionKeys == input.EncryptionKeys ||
                    this.EncryptionKeys != null &&
                    this.EncryptionKeys.SequenceEqual(input.EncryptionKeys)
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.JobMatchString == input.JobMatchString ||
                    (this.JobMatchString != null &&
                    this.JobMatchString.Equals(input.JobMatchString))
                ) && 
                (
                    this.SearchJobName == input.SearchJobName ||
                    (this.SearchJobName != null &&
                    this.SearchJobName.Equals(input.SearchJobName))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.ClusterMatchString != null)
                    hashCode = hashCode * 59 + this.ClusterMatchString.GetHashCode();
                if (this.EncryptionKeys != null)
                    hashCode = hashCode * 59 + this.EncryptionKeys.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.JobMatchString != null)
                    hashCode = hashCode * 59 + this.JobMatchString.GetHashCode();
                if (this.SearchJobName != null)
                    hashCode = hashCode * 59 + this.SearchJobName.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

