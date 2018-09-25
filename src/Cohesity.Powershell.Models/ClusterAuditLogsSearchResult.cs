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
    /// Returns the Cluster audit logs that match the specified filter criteria up to the limit specified in pageCount.
    /// </summary>
    [DataContract]
    public partial class ClusterAuditLogsSearchResult :  IEquatable<ClusterAuditLogsSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterAuditLogsSearchResult" /> class.
        /// </summary>
        /// <param name="clusterAuditLogs">Specifies a list of Cluster audit logs that match the specified filter criteria up to the limit specified in pageCount..</param>
        /// <param name="totalCount">Specifies the total number of logs that match the specified filter criteria. (This number might be larger than the size of the Cluster Audit Logs array.) This count is provided to indicate if additional requests must be made to get the full result..</param>
        public ClusterAuditLogsSearchResult(List<ClusterAuditLog> clusterAuditLogs = default(List<ClusterAuditLog>), long? totalCount = default(long?))
        {
            this.ClusterAuditLogs = clusterAuditLogs;
            this.TotalCount = totalCount;
        }
        
        /// <summary>
        /// Specifies a list of Cluster audit logs that match the specified filter criteria up to the limit specified in pageCount.
        /// </summary>
        /// <value>Specifies a list of Cluster audit logs that match the specified filter criteria up to the limit specified in pageCount.</value>
        [DataMember(Name="clusterAuditLogs", EmitDefaultValue=false)]
        public List<ClusterAuditLog> ClusterAuditLogs { get; set; }

        /// <summary>
        /// Specifies the total number of logs that match the specified filter criteria. (This number might be larger than the size of the Cluster Audit Logs array.) This count is provided to indicate if additional requests must be made to get the full result.
        /// </summary>
        /// <value>Specifies the total number of logs that match the specified filter criteria. (This number might be larger than the size of the Cluster Audit Logs array.) This count is provided to indicate if additional requests must be made to get the full result.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

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
            return this.Equals(input as ClusterAuditLogsSearchResult);
        }

        /// <summary>
        /// Returns true if ClusterAuditLogsSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterAuditLogsSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterAuditLogsSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterAuditLogs == input.ClusterAuditLogs ||
                    this.ClusterAuditLogs != null &&
                    this.ClusterAuditLogs.SequenceEqual(input.ClusterAuditLogs)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.ClusterAuditLogs != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogs.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

