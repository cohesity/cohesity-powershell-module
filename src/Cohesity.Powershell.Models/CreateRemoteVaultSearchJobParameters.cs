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
        /// <param name="jobUids">Filter by specifying a list of remote job uids in form of clusterId:clusterIncarnationId:jobId..</param>
        /// <param name="clusterId">Filter by specifying a Cluster id..</param>
        /// <param name="clusterMatchString">Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results..</param>
        /// <param name="encryptionKeys">Array of Encryption Keys.  Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified..</param>
        /// <param name="endTimeUsecs">Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results..</param>
        /// <param name="jobMatchString">Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results..</param>
        /// <param name="searchJobName">Specifies the search Job name. (required).</param>
        /// <param name="startTimeUsecs">Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results..</param>
        /// <param name="vaultId">Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target. (required).</param>
        public CreateRemoteVaultSearchJobParameters(List<string> jobUids = default(List<string>), long? clusterId = default(long?), string clusterMatchString = default(string), List<VaultEncryptionKey> encryptionKeys = default(List<VaultEncryptionKey>), long? endTimeUsecs = default(long?), string jobMatchString = default(string), string searchJobName = default(string), long? startTimeUsecs = default(long?), long? vaultId = default(long?))
        {
            this.JobUids = jobUids;
            this.ClusterId = clusterId;
            this.ClusterMatchString = clusterMatchString;
            this.EncryptionKeys = encryptionKeys;
            this.EndTimeUsecs = endTimeUsecs;
            this.JobMatchString = jobMatchString;
            this.SearchJobName = searchJobName;
            this.StartTimeUsecs = startTimeUsecs;
            this.VaultId = vaultId;
            this.JobUids = jobUids;
            this.ClusterId = clusterId;
            this.ClusterMatchString = clusterMatchString;
            this.EncryptionKeys = encryptionKeys;
            this.EndTimeUsecs = endTimeUsecs;
            this.JobMatchString = jobMatchString;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Filter by specifying a list of remote job uids in form of clusterId:clusterIncarnationId:jobId.
        /// </summary>
        /// <value>Filter by specifying a list of remote job uids in form of clusterId:clusterIncarnationId:jobId.</value>
        [DataMember(Name="JobUids", EmitDefaultValue=true)]
        public List<string> JobUids { get; set; }

        /// <summary>
        /// Filter by specifying a Cluster id.
        /// </summary>
        /// <value>Filter by specifying a Cluster id.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results.
        /// </summary>
        /// <value>Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results.</value>
        [DataMember(Name="clusterMatchString", EmitDefaultValue=true)]
        public string ClusterMatchString { get; set; }

        /// <summary>
        /// Array of Encryption Keys.  Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified.
        /// </summary>
        /// <value>Array of Encryption Keys.  Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified.</value>
        [DataMember(Name="encryptionKeys", EmitDefaultValue=true)]
        public List<VaultEncryptionKey> EncryptionKeys { get; set; }

        /// <summary>
        /// Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results.
        /// </summary>
        /// <value>Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results.
        /// </summary>
        /// <value>Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results.</value>
        [DataMember(Name="jobMatchString", EmitDefaultValue=true)]
        public string JobMatchString { get; set; }

        /// <summary>
        /// Specifies the search Job name.
        /// </summary>
        /// <value>Specifies the search Job name.</value>
        [DataMember(Name="searchJobName", EmitDefaultValue=true)]
        public string SearchJobName { get; set; }

        /// <summary>
        /// Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results.
        /// </summary>
        /// <value>Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target.
        /// </summary>
        /// <value>Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=true)]
        public long? VaultId { get; set; }

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
                    this.JobUids == input.JobUids ||
                    this.JobUids != null &&
                    input.JobUids != null &&
                    this.JobUids.SequenceEqual(input.JobUids)
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterMatchString == input.ClusterMatchString ||
                    (this.ClusterMatchString != null &&
                    this.ClusterMatchString.Equals(input.ClusterMatchString))
                ) && 
                (
                    this.EncryptionKeys == input.EncryptionKeys ||
                    this.EncryptionKeys != null &&
                    input.EncryptionKeys != null &&
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
                if (this.JobUids != null)
                    hashCode = hashCode * 59 + this.JobUids.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
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

