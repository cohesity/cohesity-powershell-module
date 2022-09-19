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
    /// Specifies information about the Alert Resolution such as a summary, id assigned by the Cohesity Cluster, user who resolved the Alerts, etc.
    /// </summary>
    [DataContract]
    public partial class AlertResolutionDetails :  IEquatable<AlertResolutionDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertResolutionDetails" /> class.
        /// </summary>
        /// <param name="resolutionDetails">Specifies detailed notes about the Resolution..</param>
        /// <param name="resolutionId">Specifies Unique id assigned by the Cohesity Cluster for this Resolution..</param>
        /// <param name="resolutionSummary">Specifies short description about the Resolution..</param>
        /// <param name="timestampUsecs">Specifies unix epoch timestamp (in microseconds) when the Alerts were resolved..</param>
        /// <param name="userName">Specifies name of the Cohesity Cluster user who resolved the Alerts..</param>
        public AlertResolutionDetails(string resolutionDetails = default(string), long? resolutionId = default(long?), string resolutionSummary = default(string), long? timestampUsecs = default(long?), string userName = default(string))
        {
            this.ResolutionDetails = resolutionDetails;
            this.ResolutionId = resolutionId;
            this.ResolutionSummary = resolutionSummary;
            this.TimestampUsecs = timestampUsecs;
            this.UserName = userName;
            this.ResolutionDetails = resolutionDetails;
            this.ResolutionId = resolutionId;
            this.ResolutionSummary = resolutionSummary;
            this.TimestampUsecs = timestampUsecs;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Specifies detailed notes about the Resolution.
        /// </summary>
        /// <value>Specifies detailed notes about the Resolution.</value>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=true)]
        public string ResolutionDetails { get; set; }

        /// <summary>
        /// Specifies Unique id assigned by the Cohesity Cluster for this Resolution.
        /// </summary>
        /// <value>Specifies Unique id assigned by the Cohesity Cluster for this Resolution.</value>
        [DataMember(Name="resolutionId", EmitDefaultValue=true)]
        public long? ResolutionId { get; set; }

        /// <summary>
        /// Specifies short description about the Resolution.
        /// </summary>
        /// <value>Specifies short description about the Resolution.</value>
        [DataMember(Name="resolutionSummary", EmitDefaultValue=true)]
        public string ResolutionSummary { get; set; }

        /// <summary>
        /// Specifies unix epoch timestamp (in microseconds) when the Alerts were resolved.
        /// </summary>
        /// <value>Specifies unix epoch timestamp (in microseconds) when the Alerts were resolved.</value>
        [DataMember(Name="timestampUsecs", EmitDefaultValue=true)]
        public long? TimestampUsecs { get; set; }

        /// <summary>
        /// Specifies name of the Cohesity Cluster user who resolved the Alerts.
        /// </summary>
        /// <value>Specifies name of the Cohesity Cluster user who resolved the Alerts.</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

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
            return this.Equals(input as AlertResolutionDetails);
        }

        /// <summary>
        /// Returns true if AlertResolutionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertResolutionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertResolutionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
                ) && 
                (
                    this.ResolutionId == input.ResolutionId ||
                    (this.ResolutionId != null &&
                    this.ResolutionId.Equals(input.ResolutionId))
                ) && 
                (
                    this.ResolutionSummary == input.ResolutionSummary ||
                    (this.ResolutionSummary != null &&
                    this.ResolutionSummary.Equals(input.ResolutionSummary))
                ) && 
                (
                    this.TimestampUsecs == input.TimestampUsecs ||
                    (this.TimestampUsecs != null &&
                    this.TimestampUsecs.Equals(input.TimestampUsecs))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.ResolutionDetails != null)
                    hashCode = hashCode * 59 + this.ResolutionDetails.GetHashCode();
                if (this.ResolutionId != null)
                    hashCode = hashCode * 59 + this.ResolutionId.GetHashCode();
                if (this.ResolutionSummary != null)
                    hashCode = hashCode * 59 + this.ResolutionSummary.GetHashCode();
                if (this.TimestampUsecs != null)
                    hashCode = hashCode * 59 + this.TimestampUsecs.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }

    }

}

