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
    /// Specifies statistics about the transfer of data from a Vault (External Target) to this Cohesity Cluster for a recover or clone task.
    /// </summary>
    [DataContract]
    public partial class DataTransferFromVaultPerTask :  IEquatable<DataTransferFromVaultPerTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferFromVaultPerTask" /> class.
        /// </summary>
        /// <param name="numLogicalBytesTransferred">Specifies the total number of logical bytes that are transferred from this Vault to the Cohesity Cluster for this task. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numPhysicalBytesTransferred">Specifies the total number of physical bytes that are transferred from this Vault to the Cohesity Cluster for this task..</param>
        /// <param name="taskName">Specifies the task name..</param>
        /// <param name="taskType">Specifies the task type..</param>
        public DataTransferFromVaultPerTask(long? numLogicalBytesTransferred = default(long?), long? numPhysicalBytesTransferred = default(long?), string taskName = default(string), string taskType = default(string))
        {
            this.NumLogicalBytesTransferred = numLogicalBytesTransferred;
            this.NumPhysicalBytesTransferred = numPhysicalBytesTransferred;
            this.TaskName = taskName;
            this.TaskType = taskType;
        }
        
        /// <summary>
        /// Specifies the total number of logical bytes that are transferred from this Vault to the Cohesity Cluster for this task. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that are transferred from this Vault to the Cohesity Cluster for this task. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumLogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total number of physical bytes that are transferred from this Vault to the Cohesity Cluster for this task.
        /// </summary>
        /// <value>Specifies the total number of physical bytes that are transferred from this Vault to the Cohesity Cluster for this task.</value>
        [DataMember(Name="numPhysicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumPhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the task name.
        /// </summary>
        /// <value>Specifies the task name.</value>
        [DataMember(Name="taskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Specifies the task type.
        /// </summary>
        /// <value>Specifies the task type.</value>
        [DataMember(Name="taskType", EmitDefaultValue=false)]
        public string TaskType { get; set; }

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
            return this.Equals(input as DataTransferFromVaultPerTask);
        }

        /// <summary>
        /// Returns true if DataTransferFromVaultPerTask instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferFromVaultPerTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferFromVaultPerTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumLogicalBytesTransferred == input.NumLogicalBytesTransferred ||
                    (this.NumLogicalBytesTransferred != null &&
                    this.NumLogicalBytesTransferred.Equals(input.NumLogicalBytesTransferred))
                ) && 
                (
                    this.NumPhysicalBytesTransferred == input.NumPhysicalBytesTransferred ||
                    (this.NumPhysicalBytesTransferred != null &&
                    this.NumPhysicalBytesTransferred.Equals(input.NumPhysicalBytesTransferred))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
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
                if (this.NumLogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumLogicalBytesTransferred.GetHashCode();
                if (this.NumPhysicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumPhysicalBytesTransferred.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

