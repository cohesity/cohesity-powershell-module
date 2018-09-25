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
    /// Provides summary statistics about the transfer of data from Vaults (External Targets) to this Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class DataTransferFromVaultsSummaryResponse :  IEquatable<DataTransferFromVaultsSummaryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferFromVaultsSummaryResponse" /> class.
        /// </summary>
        /// <param name="dataTransferSummary">Specifies summary statistics about the transfer of data from Vaults to the Cohesity Cluster..</param>
        public DataTransferFromVaultsSummaryResponse(List<DataTransferFromVaultSummary> dataTransferSummary = default(List<DataTransferFromVaultSummary>))
        {
            this.DataTransferSummary = dataTransferSummary;
        }
        
        /// <summary>
        /// Specifies summary statistics about the transfer of data from Vaults to the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies summary statistics about the transfer of data from Vaults to the Cohesity Cluster.</value>
        [DataMember(Name="dataTransferSummary", EmitDefaultValue=false)]
        public List<DataTransferFromVaultSummary> DataTransferSummary { get; set; }

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
            return this.Equals(input as DataTransferFromVaultsSummaryResponse);
        }

        /// <summary>
        /// Returns true if DataTransferFromVaultsSummaryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferFromVaultsSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferFromVaultsSummaryResponse input)
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

