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
    /// TenantDeletionInfo captures the individual deletion state of a category of objects marked tagged with a tenant_id (which has been marked for deletion).
    /// </summary>
    [DataContract]
    public partial class TenantDeletionInfo :  IEquatable<TenantDeletionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDeletionInfo" /> class.
        /// </summary>
        /// <param name="category">Specifies the category of objects whose deletion state is being captured..</param>
        /// <param name="finishedAtTimeMsecs">Specifies the time when the process finished..</param>
        /// <param name="processedAtNode">Specifies the node ip where the process ran. Typically this would be Iris Master..</param>
        /// <param name="retryCount">Specifies the number of times this task has been retried..</param>
        /// <param name="startedAtTimeMsecs">Specifies the time when the process started..</param>
        /// <param name="state">Specifies the deletion completion state of the object category..</param>
        public TenantDeletionInfo(int? category = default(int?), long? finishedAtTimeMsecs = default(long?), string processedAtNode = default(string), long? retryCount = default(long?), long? startedAtTimeMsecs = default(long?), int? state = default(int?))
        {
            this.Category = category;
            this.FinishedAtTimeMsecs = finishedAtTimeMsecs;
            this.ProcessedAtNode = processedAtNode;
            this.RetryCount = retryCount;
            this.StartedAtTimeMsecs = startedAtTimeMsecs;
            this.State = state;
        }
        
        /// <summary>
        /// Specifies the category of objects whose deletion state is being captured.
        /// </summary>
        /// <value>Specifies the category of objects whose deletion state is being captured.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int? Category { get; set; }

        /// <summary>
        /// Specifies the time when the process finished.
        /// </summary>
        /// <value>Specifies the time when the process finished.</value>
        [DataMember(Name="finishedAtTimeMsecs", EmitDefaultValue=false)]
        public long? FinishedAtTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the node ip where the process ran. Typically this would be Iris Master.
        /// </summary>
        /// <value>Specifies the node ip where the process ran. Typically this would be Iris Master.</value>
        [DataMember(Name="processedAtNode", EmitDefaultValue=false)]
        public string ProcessedAtNode { get; set; }

        /// <summary>
        /// Specifies the number of times this task has been retried.
        /// </summary>
        /// <value>Specifies the number of times this task has been retried.</value>
        [DataMember(Name="retryCount", EmitDefaultValue=false)]
        public long? RetryCount { get; set; }

        /// <summary>
        /// Specifies the time when the process started.
        /// </summary>
        /// <value>Specifies the time when the process started.</value>
        [DataMember(Name="startedAtTimeMsecs", EmitDefaultValue=false)]
        public long? StartedAtTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the deletion completion state of the object category.
        /// </summary>
        /// <value>Specifies the deletion completion state of the object category.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

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
            return this.Equals(input as TenantDeletionInfo);
        }

        /// <summary>
        /// Returns true if TenantDeletionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantDeletionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantDeletionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.FinishedAtTimeMsecs == input.FinishedAtTimeMsecs ||
                    (this.FinishedAtTimeMsecs != null &&
                    this.FinishedAtTimeMsecs.Equals(input.FinishedAtTimeMsecs))
                ) && 
                (
                    this.ProcessedAtNode == input.ProcessedAtNode ||
                    (this.ProcessedAtNode != null &&
                    this.ProcessedAtNode.Equals(input.ProcessedAtNode))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.StartedAtTimeMsecs == input.StartedAtTimeMsecs ||
                    (this.StartedAtTimeMsecs != null &&
                    this.StartedAtTimeMsecs.Equals(input.StartedAtTimeMsecs))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.FinishedAtTimeMsecs != null)
                    hashCode = hashCode * 59 + this.FinishedAtTimeMsecs.GetHashCode();
                if (this.ProcessedAtNode != null)
                    hashCode = hashCode * 59 + this.ProcessedAtNode.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.StartedAtTimeMsecs != null)
                    hashCode = hashCode * 59 + this.StartedAtTimeMsecs.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}

