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
    /// Provides summary statistics about the transfer of data from this Cohesity Cluster to Vaults (External Targets).
    /// </summary>
    [DataContract]
    public partial class DataTransferToVaultsSummaryResponse :  IEquatable<DataTransferToVaultsSummaryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferToVaultsSummaryResponse" /> class.
        /// </summary>
        /// <param name="dataTransferSummary">Specifies summary statistics about the transfer of data from the Cohesity Cluster to Vaults..</param>
        public DataTransferToVaultsSummaryResponse(List<DataTransferToVaultSummary> dataTransferSummary = default(List<DataTransferToVaultSummary>))
        {
            this.DataTransferSummary = dataTransferSummary;
        }
        
        /// <summary>
        /// Specifies summary statistics about the transfer of data from the Cohesity Cluster to Vaults.
        /// </summary>
        /// <value>Specifies summary statistics about the transfer of data from the Cohesity Cluster to Vaults.</value>
        [DataMember(Name="dataTransferSummary", EmitDefaultValue=false)]
        public List<DataTransferToVaultSummary> DataTransferSummary { get; set; }

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
            return this.Equals(input as DataTransferToVaultsSummaryResponse);
        }

        /// <summary>
        /// Returns true if DataTransferToVaultsSummaryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferToVaultsSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferToVaultsSummaryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataTransferSummary == input.DataTransferSummary ||
                    this.DataTransferSummary != null &&
                    this.DataTransferSummary.SequenceEqual(input.DataTransferSummary)
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
                if (this.DataTransferSummary != null)
                    hashCode = hashCode * 59 + this.DataTransferSummary.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

