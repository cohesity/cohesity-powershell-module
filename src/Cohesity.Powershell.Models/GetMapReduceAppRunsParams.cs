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
    /// GetMapReduceAppRunsParams specifies the input params to fetch the map reduce application runs.
    /// </summary>
    [DataContract]
    public partial class GetMapReduceAppRunsParams :  IEquatable<GetMapReduceAppRunsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMapReduceAppRunsParams" /> class.
        /// </summary>
        /// <param name="appId">ApplicationId is the Id of the map reduce application..</param>
        /// <param name="appInstanceId">ApplicationInstanceId is the Id of the map reduce application instance..</param>
        /// <param name="includeDetails">If this flag is true, then send details of instance, else send only RunInfo..</param>
        /// <param name="lastNumInstances">Give last N instance of an app based on end time..</param>
        /// <param name="maxRunEndTimeInSecs">MaxRunEndTimestampInSecs specifies the maximum job run end timestamp in seconds. App run instances with end time less than equal to MaxRunEndTimestampInSecs will be selected. Default is LONG_MAX (inf)..</param>
        /// <param name="maxRunStartTimeInSecs">MaxRunStartTimestampInSecs specifies the maximum job run start timestamp in seconds. App run instances with start time less than equal to MaxRunStartTimestampInSecs will be selected. Default is LONG_MAX (inf)..</param>
        /// <param name="minRunEndTimeInSecs">MinRunEndTimestampInSecs specifies the minimum job run end timestamp in seconds. App run instances with end time greater than equal to MinRunEndTimestampInSecs will be selected. Default is 0, i.e. beginning of time..</param>
        /// <param name="minRunStartTimeInSecs">MinRunStartTimestampInSecs specifies the minimum job run start timestamp in seconds. App run instances with start time greater than equal to MinRunStartTimestampInSecs will be selected. Default is 0, i.e. beginning of time..</param>
        /// <param name="pageSize">Number of results to be displayed on a page..</param>
        /// <param name="runStatus">Filter instances based on the map reduce application run status..</param>
        /// <param name="startOffset">Start offset for pagination from where result needs to be fetched..</param>
        public GetMapReduceAppRunsParams(long? appId = default(long?), long? appInstanceId = default(long?), bool? includeDetails = default(bool?), int? lastNumInstances = default(int?), long? maxRunEndTimeInSecs = default(long?), long? maxRunStartTimeInSecs = default(long?), long? minRunEndTimeInSecs = default(long?), long? minRunStartTimeInSecs = default(long?), int? pageSize = default(int?), string runStatus = default(string), int? startOffset = default(int?))
        {
            this.AppId = appId;
            this.AppInstanceId = appInstanceId;
            this.IncludeDetails = includeDetails;
            this.LastNumInstances = lastNumInstances;
            this.MaxRunEndTimeInSecs = maxRunEndTimeInSecs;
            this.MaxRunStartTimeInSecs = maxRunStartTimeInSecs;
            this.MinRunEndTimeInSecs = minRunEndTimeInSecs;
            this.MinRunStartTimeInSecs = minRunStartTimeInSecs;
            this.PageSize = pageSize;
            this.RunStatus = runStatus;
            this.StartOffset = startOffset;
        }
        
        /// <summary>
        /// ApplicationId is the Id of the map reduce application.
        /// </summary>
        /// <value>ApplicationId is the Id of the map reduce application.</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// ApplicationInstanceId is the Id of the map reduce application instance.
        /// </summary>
        /// <value>ApplicationInstanceId is the Id of the map reduce application instance.</value>
        [DataMember(Name="appInstanceId", EmitDefaultValue=false)]
        public long? AppInstanceId { get; set; }

        /// <summary>
        /// If this flag is true, then send details of instance, else send only RunInfo.
        /// </summary>
        /// <value>If this flag is true, then send details of instance, else send only RunInfo.</value>
        [DataMember(Name="includeDetails", EmitDefaultValue=false)]
        public bool? IncludeDetails { get; set; }

        /// <summary>
        /// Give last N instance of an app based on end time.
        /// </summary>
        /// <value>Give last N instance of an app based on end time.</value>
        [DataMember(Name="lastNumInstances", EmitDefaultValue=false)]
        public int? LastNumInstances { get; set; }

        /// <summary>
        /// MaxRunEndTimestampInSecs specifies the maximum job run end timestamp in seconds. App run instances with end time less than equal to MaxRunEndTimestampInSecs will be selected. Default is LONG_MAX (inf).
        /// </summary>
        /// <value>MaxRunEndTimestampInSecs specifies the maximum job run end timestamp in seconds. App run instances with end time less than equal to MaxRunEndTimestampInSecs will be selected. Default is LONG_MAX (inf).</value>
        [DataMember(Name="maxRunEndTimeInSecs", EmitDefaultValue=false)]
        public long? MaxRunEndTimeInSecs { get; set; }

        /// <summary>
        /// MaxRunStartTimestampInSecs specifies the maximum job run start timestamp in seconds. App run instances with start time less than equal to MaxRunStartTimestampInSecs will be selected. Default is LONG_MAX (inf).
        /// </summary>
        /// <value>MaxRunStartTimestampInSecs specifies the maximum job run start timestamp in seconds. App run instances with start time less than equal to MaxRunStartTimestampInSecs will be selected. Default is LONG_MAX (inf).</value>
        [DataMember(Name="maxRunStartTimeInSecs", EmitDefaultValue=false)]
        public long? MaxRunStartTimeInSecs { get; set; }

        /// <summary>
        /// MinRunEndTimestampInSecs specifies the minimum job run end timestamp in seconds. App run instances with end time greater than equal to MinRunEndTimestampInSecs will be selected. Default is 0, i.e. beginning of time.
        /// </summary>
        /// <value>MinRunEndTimestampInSecs specifies the minimum job run end timestamp in seconds. App run instances with end time greater than equal to MinRunEndTimestampInSecs will be selected. Default is 0, i.e. beginning of time.</value>
        [DataMember(Name="minRunEndTimeInSecs", EmitDefaultValue=false)]
        public long? MinRunEndTimeInSecs { get; set; }

        /// <summary>
        /// MinRunStartTimestampInSecs specifies the minimum job run start timestamp in seconds. App run instances with start time greater than equal to MinRunStartTimestampInSecs will be selected. Default is 0, i.e. beginning of time.
        /// </summary>
        /// <value>MinRunStartTimestampInSecs specifies the minimum job run start timestamp in seconds. App run instances with start time greater than equal to MinRunStartTimestampInSecs will be selected. Default is 0, i.e. beginning of time.</value>
        [DataMember(Name="minRunStartTimeInSecs", EmitDefaultValue=false)]
        public long? MinRunStartTimeInSecs { get; set; }

        /// <summary>
        /// Number of results to be displayed on a page.
        /// </summary>
        /// <value>Number of results to be displayed on a page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Filter instances based on the map reduce application run status.
        /// </summary>
        /// <value>Filter instances based on the map reduce application run status.</value>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public string RunStatus { get; set; }

        /// <summary>
        /// Start offset for pagination from where result needs to be fetched.
        /// </summary>
        /// <value>Start offset for pagination from where result needs to be fetched.</value>
        [DataMember(Name="startOffset", EmitDefaultValue=false)]
        public int? StartOffset { get; set; }

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
            return this.Equals(input as GetMapReduceAppRunsParams);
        }

        /// <summary>
        /// Returns true if GetMapReduceAppRunsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMapReduceAppRunsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMapReduceAppRunsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppInstanceId == input.AppInstanceId ||
                    (this.AppInstanceId != null &&
                    this.AppInstanceId.Equals(input.AppInstanceId))
                ) && 
                (
                    this.IncludeDetails == input.IncludeDetails ||
                    (this.IncludeDetails != null &&
                    this.IncludeDetails.Equals(input.IncludeDetails))
                ) && 
                (
                    this.LastNumInstances == input.LastNumInstances ||
                    (this.LastNumInstances != null &&
                    this.LastNumInstances.Equals(input.LastNumInstances))
                ) && 
                (
                    this.MaxRunEndTimeInSecs == input.MaxRunEndTimeInSecs ||
                    (this.MaxRunEndTimeInSecs != null &&
                    this.MaxRunEndTimeInSecs.Equals(input.MaxRunEndTimeInSecs))
                ) && 
                (
                    this.MaxRunStartTimeInSecs == input.MaxRunStartTimeInSecs ||
                    (this.MaxRunStartTimeInSecs != null &&
                    this.MaxRunStartTimeInSecs.Equals(input.MaxRunStartTimeInSecs))
                ) && 
                (
                    this.MinRunEndTimeInSecs == input.MinRunEndTimeInSecs ||
                    (this.MinRunEndTimeInSecs != null &&
                    this.MinRunEndTimeInSecs.Equals(input.MinRunEndTimeInSecs))
                ) && 
                (
                    this.MinRunStartTimeInSecs == input.MinRunStartTimeInSecs ||
                    (this.MinRunStartTimeInSecs != null &&
                    this.MinRunStartTimeInSecs.Equals(input.MinRunStartTimeInSecs))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    (this.RunStatus != null &&
                    this.RunStatus.Equals(input.RunStatus))
                ) && 
                (
                    this.StartOffset == input.StartOffset ||
                    (this.StartOffset != null &&
                    this.StartOffset.Equals(input.StartOffset))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppInstanceId != null)
                    hashCode = hashCode * 59 + this.AppInstanceId.GetHashCode();
                if (this.IncludeDetails != null)
                    hashCode = hashCode * 59 + this.IncludeDetails.GetHashCode();
                if (this.LastNumInstances != null)
                    hashCode = hashCode * 59 + this.LastNumInstances.GetHashCode();
                if (this.MaxRunEndTimeInSecs != null)
                    hashCode = hashCode * 59 + this.MaxRunEndTimeInSecs.GetHashCode();
                if (this.MaxRunStartTimeInSecs != null)
                    hashCode = hashCode * 59 + this.MaxRunStartTimeInSecs.GetHashCode();
                if (this.MinRunEndTimeInSecs != null)
                    hashCode = hashCode * 59 + this.MinRunEndTimeInSecs.GetHashCode();
                if (this.MinRunStartTimeInSecs != null)
                    hashCode = hashCode * 59 + this.MinRunStartTimeInSecs.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.StartOffset != null)
                    hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

