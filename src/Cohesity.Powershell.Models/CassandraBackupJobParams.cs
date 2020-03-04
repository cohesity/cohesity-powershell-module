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
    /// Contains any additional cassandra environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class CassandraBackupJobParams :  IEquatable<CassandraBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraBackupJobParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalInfo">cassandraAdditionalInfo.</param>
        /// <param name="selectedDataCenterVec">The data centers selected for backup..</param>
        public CassandraBackupJobParams(CassandraAdditionalParams cassandraAdditionalInfo = default(CassandraAdditionalParams), List<string> selectedDataCenterVec = default(List<string>))
        {
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.CassandraAdditionalInfo = cassandraAdditionalInfo;
            this.SelectedDataCenterVec = selectedDataCenterVec;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalInfo
        /// </summary>
        [DataMember(Name="cassandraAdditionalInfo", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalInfo { get; set; }

        /// <summary>
        /// The data centers selected for backup.
        /// </summary>
        /// <value>The data centers selected for backup.</value>
        [DataMember(Name="selectedDataCenterVec", EmitDefaultValue=true)]
        public List<string> SelectedDataCenterVec { get; set; }

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
            return this.Equals(input as CassandraBackupJobParams);
        }

        /// <summary>
        /// Returns true if CassandraBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraAdditionalInfo == input.CassandraAdditionalInfo ||
                    (this.CassandraAdditionalInfo != null &&
                    this.CassandraAdditionalInfo.Equals(input.CassandraAdditionalInfo))
                ) && 
                (
                    this.SelectedDataCenterVec == input.SelectedDataCenterVec ||
                    this.SelectedDataCenterVec != null &&
                    input.SelectedDataCenterVec != null &&
                    this.SelectedDataCenterVec.SequenceEqual(input.SelectedDataCenterVec)
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
                if (this.CassandraAdditionalInfo != null)
                    hashCode = hashCode * 59 + this.CassandraAdditionalInfo.GetHashCode();
                if (this.SelectedDataCenterVec != null)
                    hashCode = hashCode * 59 + this.SelectedDataCenterVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

