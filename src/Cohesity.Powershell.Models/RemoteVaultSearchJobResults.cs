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
    /// Specifies detailed information about Job Runs of Protection Jobs found by a search Job when searching a remote Vault for archived data.
    /// </summary>
    [DataContract]
    public partial class RemoteVaultSearchJobResults :  IEquatable<RemoteVaultSearchJobResults>
    {
        /// <summary>
        /// Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
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
        /// Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [DataMember(Name="searchJobStatus", EmitDefaultValue=false)]
        public SearchJobStatusEnum? SearchJobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteVaultSearchJobResults" /> class.
        /// </summary>
        /// <param name="clusterCount">Specifies number of Clusters that have archived to the remote Vault that match the criteria specified in the search Job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for the search Job, are reported. If the search was not complete, a partial number is reported..</param>
        /// <param name="clusterMatchString">Specifies the value of the clusterMatchSting if it was set in the original search Job..</param>
        /// <param name="cookie">Specifies an opaque string to pass to the next request to get the next set of search results. This is provided to support pagination. If null, this is the last set of search results..</param>
        /// <param name="endTimeUsecs">Specifies the value of endTimeUsecs if it was set in the original search Job. End time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="error">Specifies the error message if the search fails..</param>
        /// <param name="jobCount">Specifies number of Protection Jobs that have archived to the remote Vault that match the criteria specified in the search Job. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and match the search criteria for the search Job, are reported. If the search is not complete, a partial number is reported..</param>
        /// <param name="jobMatchString">Specifies the value of the jobMatchSting if it was set in the original search Job..</param>
        /// <param name="protectionJobs">Specifies a list of Protection Jobs that have archived data to a remote Vault and that also match the filter criteria..</param>
        /// <param name="searchJobStatus">Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused..</param>
        /// <param name="searchJobUid">searchJobUid.</param>
        /// <param name="startTimeUsecs">Specifies the value of startTimeUsecs if it was set in the original search Job. Start time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="vaultId">Specifies the id of the remote Vault that was searched..</param>
        /// <param name="vaultName">Specifies the name of the remote Vault that was searched..</param>
        public RemoteVaultSearchJobResults(int? clusterCount = default(int?), string clusterMatchString = default(string), string cookie = default(string), long? endTimeUsecs = default(long?), string error = default(string), int? jobCount = default(int?), string jobMatchString = default(string), List<RemoteProtectionJobRunInformation> protectionJobs = default(List<RemoteProtectionJobRunInformation>), SearchJobStatusEnum? searchJobStatus = default(SearchJobStatusEnum?), SearchJobId_ searchJobUid = default(SearchJobId_), long? startTimeUsecs = default(long?), long? vaultId = default(long?), string vaultName = default(string))
        {
            this.ClusterCount = clusterCount;
            this.ClusterMatchString = clusterMatchString;
            this.Cookie = cookie;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.JobCount = jobCount;
            this.JobMatchString = jobMatchString;
            this.ProtectionJobs = protectionJobs;
            this.SearchJobStatus = searchJobStatus;
            this.SearchJobUid = searchJobUid;
            this.StartTimeUsecs = startTimeUsecs;
            this.VaultId = vaultId;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies number of Clusters that have archived to the remote Vault that match the criteria specified in the search Job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for the search Job, are reported. If the search was not complete, a partial number is reported.
        /// </summary>
        /// <value>Specifies number of Clusters that have archived to the remote Vault that match the criteria specified in the search Job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for the search Job, are reported. If the search was not complete, a partial number is reported.</value>
        [DataMember(Name="clusterCount", EmitDefaultValue=false)]
        public int? ClusterCount { get; set; }

        /// <summary>
        /// Specifies the value of the clusterMatchSting if it was set in the original search Job.
        /// </summary>
        /// <value>Specifies the value of the clusterMatchSting if it was set in the original search Job.</value>
        [DataMember(Name="clusterMatchString", EmitDefaultValue=false)]
        public string ClusterMatchString { get; set; }

        /// <summary>
        /// Specifies an opaque string to pass to the next request to get the next set of search results. This is provided to support pagination. If null, this is the last set of search results.
        /// </summary>
        /// <value>Specifies an opaque string to pass to the next request to get the next set of search results. This is provided to support pagination. If null, this is the last set of search results.</value>
        [DataMember(Name="cookie", EmitDefaultValue=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// Specifies the value of endTimeUsecs if it was set in the original search Job. End time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the value of endTimeUsecs if it was set in the original search Job. End time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the error message if the search fails.
        /// </summary>
        /// <value>Specifies the error message if the search fails.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies number of Protection Jobs that have archived to the remote Vault that match the criteria specified in the search Job. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and match the search criteria for the search Job, are reported. If the search is not complete, a partial number is reported.
        /// </summary>
        /// <value>Specifies number of Protection Jobs that have archived to the remote Vault that match the criteria specified in the search Job. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and match the search criteria for the search Job, are reported. If the search is not complete, a partial number is reported.</value>
        [DataMember(Name="jobCount", EmitDefaultValue=false)]
        public int? JobCount { get; set; }

        /// <summary>
        /// Specifies the value of the jobMatchSting if it was set in the original search Job.
        /// </summary>
        /// <value>Specifies the value of the jobMatchSting if it was set in the original search Job.</value>
        [DataMember(Name="jobMatchString", EmitDefaultValue=false)]
        public string JobMatchString { get; set; }

        /// <summary>
        /// Specifies a list of Protection Jobs that have archived data to a remote Vault and that also match the filter criteria.
        /// </summary>
        /// <value>Specifies a list of Protection Jobs that have archived data to a remote Vault and that also match the filter criteria.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=false)]
        public List<RemoteProtectionJobRunInformation> ProtectionJobs { get; set; }


        /// <summary>
        /// Gets or Sets SearchJobUid
        /// </summary>
        [DataMember(Name="searchJobUid", EmitDefaultValue=false)]
        public SearchJobId_ SearchJobUid { get; set; }

        /// <summary>
        /// Specifies the value of startTimeUsecs if it was set in the original search Job. Start time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the value of startTimeUsecs if it was set in the original search Job. Start time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the remote Vault that was searched.
        /// </summary>
        /// <value>Specifies the id of the remote Vault that was searched.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

        /// <summary>
        /// Specifies the name of the remote Vault that was searched.
        /// </summary>
        /// <value>Specifies the name of the remote Vault that was searched.</value>
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
            return this.Equals(input as RemoteVaultSearchJobResults);
        }

        /// <summary>
        /// Returns true if RemoteVaultSearchJobResults instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteVaultSearchJobResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteVaultSearchJobResults input)
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
                    this.ClusterMatchString == input.ClusterMatchString ||
                    (this.ClusterMatchString != null &&
                    this.ClusterMatchString.Equals(input.ClusterMatchString))
                ) && 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
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
                    this.JobMatchString == input.JobMatchString ||
                    (this.JobMatchString != null &&
                    this.JobMatchString.Equals(input.JobMatchString))
                ) && 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
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
                if (this.ClusterMatchString != null)
                    hashCode = hashCode * 59 + this.ClusterMatchString.GetHashCode();
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.JobCount != null)
                    hashCode = hashCode * 59 + this.JobCount.GetHashCode();
                if (this.JobMatchString != null)
                    hashCode = hashCode * 59 + this.JobMatchString.GetHashCode();
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
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

