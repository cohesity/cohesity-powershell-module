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
    /// Contains any additional cassandra environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class CassandraRecoverJobParams :  IEquatable<CassandraRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraRecoverJobParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalInfo">cassandraAdditionalInfo.</param>
        /// <param name="selectedDataCenterVec">The data centers selected for recovery..</param>
        /// <param name="stagingDirectoryVec">Cassandra staging directory.</param>
        /// <param name="suffix">A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this..</param>
        public CassandraRecoverJobParams(CassandraAdditionalParams cassandraAdditionalInfo = default(CassandraAdditionalParams), List<string> selectedDataCenterVec = default(List<string>), List<string> stagingDirectoryVec = default(List<string>), string suffix = default(string))
        {
            this.CassandraAdditionalInfo = cassandraAdditionalInfo;
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.StagingDirectoryVec = stagingDirectoryVec;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalInfo
        /// </summary>
        [DataMember(Name="cassandraAdditionalInfo", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalInfo { get; set; }

        /// <summary>
        /// The data centers selected for recovery.
        /// </summary>
        /// <value>The data centers selected for recovery.</value>
        [DataMember(Name="selectedDataCenterVec", EmitDefaultValue=false)]
        public List<string> SelectedDataCenterVec { get; set; }

        /// <summary>
        /// Cassandra staging directory
        /// </summary>
        /// <value>Cassandra staging directory</value>
        [DataMember(Name="stagingDirectoryVec", EmitDefaultValue=false)]
        public List<string> StagingDirectoryVec { get; set; }

        /// <summary>
        /// A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this.
        /// </summary>
        /// <value>A suffix that is to be applied to all recovered entities TODO (faizan.khan) : Remove this.</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

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
            return this.Equals(input as CassandraRecoverJobParams);
        }

        /// <summary>
        /// Returns true if CassandraRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraRecoverJobParams input)
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
                    this.SelectedDataCenterVec.Equals(input.SelectedDataCenterVec)
                ) && 
                (
                    this.StagingDirectoryVec == input.StagingDirectoryVec ||
                    this.StagingDirectoryVec != null &&
                    this.StagingDirectoryVec.Equals(input.StagingDirectoryVec)
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.StagingDirectoryVec != null)
                    hashCode = hashCode * 59 + this.StagingDirectoryVec.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

