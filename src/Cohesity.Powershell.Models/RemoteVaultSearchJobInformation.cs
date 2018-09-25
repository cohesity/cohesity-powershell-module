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
    /// Specifies information about a search of a remote Vault.
    /// </summary>
    [DataContract]
    public partial class RemoteVaultSearchJobInformation :  IEquatable<RemoteVaultSearchJobInformation>
    {
        /// <summary>
        /// Specifies the status of the search. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the search. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchJobStatusEnum
        {
            
            /// <summary>
            /// Enum KJobRunning for value: kJobRunning
            /// </summary>
            [EnumMember(Value = "kJobRunning")]
            KJobRunning = 1,
            
            /// <summary>
            /// Enum KJobFinished for value: kJobFinished
            /// </summary>
            [EnumMember(Value = "kJobFinished")]
            KJobFinished = 2,
            
            /// <summary>
            /// Enum KJobFailed for value: kJobFailed
            /// </summary>
            [EnumMember(Value = "kJobFailed")]
            KJobFailed = 3,
            
            /// <summary>
            /// Enum KJobCanceled for value: kJobCanceled
            /// </summary>
            [EnumMember(Value = "kJobCanceled")]
            KJobCanceled = 4,
            
            /// <summary>
            /// Enum KJobPaused for value: kJobPaused
            /// </summary>
            [EnumMember(Value = "kJobPaused")]
            KJobPaused = 5
        }

        /// <summary>
        /// Specifies the status of the search. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the search. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [DataMember(Name="searchJobStatus", EmitDefaultValue=false)]
        public SearchJobStatusEnum? SearchJobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteVaultSearchJobInformation" /> class.
        /// </summary>
        /// <param name="clusterCount">Specifies number of Clusters that have archived to the remote Vault and match the search criteria for this job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported..</param>
        /// <param name="endTimeUsecs">Specifies the end time of the search as a Unix epoch Timestamp (in microseconds) if the search Job has completed..</param>
        /// <param name="error">Specifies the error message reported when a search fails..</param>
        /// <param name="jobCount">Specifies number of Protection Jobs that have archived to the remote Vault and match the search criteria for this search Job, up to this point in the search. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported..</param>
        /// <param name="name">Specifies the name of the search Job..</param>
        /// <param name="searchJobStatus">Specifies the status of the search. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused..</param>
        /// <param name="searchJobUid">searchJobUid.</param>
        /// <param name="startTimeUsecs">Specifies the start time of the search as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="vaultId">Specifies the id of the remote Vault (External Target) that was searched..</param>
        /// <param name="vaultName">Specifies the name of the remote Vault (External Target) that was searched..</param>
        public RemoteVaultSearchJobInformation(int? clusterCount = default(int?), long? endTimeUsecs = default(long?), string error = default(string), int? jobCount = default(int?), string name = default(string), SearchJobStatusEnum? searchJobStatus = default(SearchJobStatusEnum?), SearchJobUid2 searchJobUid = default(SearchJobUid2), long? startTimeUsecs = default(long?), long? vaultId = default(long?), string vaultName = default(string))
        {
            this.ClusterCount = clusterCount;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.JobCount = jobCount;
            this.Name = name;
            this.SearchJobStatus = searchJobStatus;
            this.SearchJobUid = searchJobUid;
            this.StartTimeUsecs = startTimeUsecs;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies number of Clusters that have archived to the remote Vault and match the search criteria for this job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported.
        /// </summary>
        /// <value>Specifies number of Clusters that have archived to the remote Vault and match the search criteria for this job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported.</value>
        [DataMember(Name="clusterCount", EmitDefaultValue=false)]
        public int? ClusterCount { get; set; }

        /// <summary>
        /// Specifies the end time of the search as a Unix epoch Timestamp (in microseconds) if the search Job has completed.
        /// </summary>
        /// <value>Specifies the end time of the search as a Unix epoch Timestamp (in microseconds) if the search Job has completed.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the error message reported when a search fails.
        /// </summary>
        /// <value>Specifies the error message reported when a search fails.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies number of Protection Jobs that have archived to the remote Vault and match the search criteria for this search Job, up to this point in the search. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported.
        /// </summary>
        /// <value>Specifies number of Protection Jobs that have archived to the remote Vault and match the search criteria for this search Job, up to this point in the search. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and that match the search criteria for this search Job, are reported. If the search is not complete, a partial number is reported.</value>
        [DataMember(Name="jobCount", EmitDefaultValue=false)]
        public int? JobCount { get; set; }

        /// <summary>
        /// Specifies the name of the search Job.
        /// </summary>
        /// <value>Specifies the name of the search Job.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets SearchJobUid
        /// </summary>
        [DataMember(Name="searchJobUid", EmitDefaultValue=false)]
        public SearchJobUid2 SearchJobUid { get; set; }

        /// <summary>
        /// Specifies the start time of the search as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the search as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the remote Vault (External Target) that was searched.
        /// </summary>
        /// <value>Specifies the id of the remote Vault (External Target) that was searched.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the name of the remote Vault (External Target) that was searched.
        /// </summary>
        /// <value>Specifies the name of the remote Vault (External Target) that was searched.</value>
        [DataMember(Name="vaultName", EmitDefaultValue=false)]
        public string VaultName { get; set; }

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
            return this.Equals(input as RemoteVaultSearchJobInformation);
        }

        /// <summary>
        /// Returns true if RemoteVaultSearchJobInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteVaultSearchJobInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteVaultSearchJobInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterCount == input.ClusterCount ||
                    (this.ClusterCount != null &&
                    this.ClusterCount.Equals(input.ClusterCount))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.JobCount == input.JobCount ||
                    (this.JobCount != null &&
                    this.JobCount.Equals(input.JobCount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SearchJobStatus == input.SearchJobStatus ||
                    (this.SearchJobStatus != null &&
                    this.SearchJobStatus.Equals(input.SearchJobStatus))
                ) && 
                (
                    this.SearchJobUid == input.SearchJobUid ||
                    (this.SearchJobUid != null &&
                    this.SearchJobUid.Equals(input.SearchJobUid))
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
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
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
                if (this.ClusterCount != null)
                    hashCode = hashCode * 59 + this.ClusterCount.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.JobCount != null)
                    hashCode = hashCode * 59 + this.JobCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SearchJobStatus != null)
                    hashCode = hashCode * 59 + this.SearchJobStatus.GetHashCode();
                if (this.SearchJobUid != null)
                    hashCode = hashCode * 59 + this.SearchJobUid.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

