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
    /// Specifies statistics about the transfer of data from this Cohesity Cluster to this Vault for a Protection Job.
    /// </summary>
    [DataContract]
    public partial class DataTransferToVaultPerProtectionJob :  IEquatable<DataTransferToVaultPerProtectionJob>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferToVaultPerProtectionJob" /> class.
        /// </summary>
        /// <param name="numLogicalBytesTransferred">Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numPhysicalBytesTransferred">Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job..</param>
        /// <param name="protectionJobName">Specifies the name of the Protection Job..</param>
        public DataTransferToVaultPerProtectionJob(long? numLogicalBytesTransferred = default(long?), long? numPhysicalBytesTransferred = default(long?), string protectionJobName = default(string))
        {
            this.NumLogicalBytesTransferred = numLogicalBytesTransferred;
            this.NumPhysicalBytesTransferred = numPhysicalBytesTransferred;
            this.ProtectionJobName = protectionJobName;
        }
        
        /// <summary>
        /// Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumLogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job.
        /// </summary>
        /// <value>Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault for this Protection Job.</value>
        [DataMember(Name="numPhysicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumPhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job.
        /// </summary>
        /// <value>Specifies the name of the Protection Job.</value>
        [DataMember(Name="protectionJobName", EmitDefaultValue=false)]
        public string ProtectionJobName { get; set; }

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
            return this.Equals(input as DataTransferToVaultPerProtectionJob);
        }

        /// <summary>
        /// Returns true if DataTransferToVaultPerProtectionJob instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferToVaultPerProtectionJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferToVaultPerProtectionJob input)
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
                    this.ProtectionJobName == input.ProtectionJobName ||
                    (this.ProtectionJobName != null &&
                    this.ProtectionJobName.Equals(input.ProtectionJobName))
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
                if (this.ProtectionJobName != null)
                    hashCode = hashCode * 59 + this.ProtectionJobName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

