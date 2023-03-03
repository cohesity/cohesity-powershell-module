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
    /// SfdcRestoreObjectParams
    /// </summary>
    [DataContract]
    public partial class SfdcRestoreObjectParams :  IEquatable<SfdcRestoreObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcRestoreObjectParams" /> class.
        /// </summary>
        /// <param name="filterQuery">Restore subset of records. Query to filter the records. populated if restore_type is kRestoreFilter..</param>
        /// <param name="includeDeletedRecords">Include deleted records..</param>
        /// <param name="newObjectName">The new name of the object, if it is going to be renamed..</param>
        /// <param name="recordIdVec">Restore selected records populated if restore_type is kRestoreRecords.</param>
        /// <param name="restoreType">restoreType.</param>
        public SfdcRestoreObjectParams(string filterQuery = default(string), bool? includeDeletedRecords = default(bool?), string newObjectName = default(string), List<string> recordIdVec = default(List<string>), int? restoreType = default(int?))
        {
            this.FilterQuery = filterQuery;
            this.IncludeDeletedRecords = includeDeletedRecords;
            this.NewObjectName = newObjectName;
            this.RecordIdVec = recordIdVec;
            this.RestoreType = restoreType;
            this.FilterQuery = filterQuery;
            this.IncludeDeletedRecords = includeDeletedRecords;
            this.NewObjectName = newObjectName;
            this.RecordIdVec = recordIdVec;
            this.RestoreType = restoreType;
        }
        
        /// <summary>
        /// Restore subset of records. Query to filter the records. populated if restore_type is kRestoreFilter.
        /// </summary>
        /// <value>Restore subset of records. Query to filter the records. populated if restore_type is kRestoreFilter.</value>
        [DataMember(Name="filterQuery", EmitDefaultValue=true)]
        public string FilterQuery { get; set; }

        /// <summary>
        /// Include deleted records.
        /// </summary>
        /// <value>Include deleted records.</value>
        [DataMember(Name="includeDeletedRecords", EmitDefaultValue=true)]
        public bool? IncludeDeletedRecords { get; set; }

        /// <summary>
        /// The new name of the object, if it is going to be renamed.
        /// </summary>
        /// <value>The new name of the object, if it is going to be renamed.</value>
        [DataMember(Name="newObjectName", EmitDefaultValue=true)]
        public string NewObjectName { get; set; }

        /// <summary>
        /// Restore selected records populated if restore_type is kRestoreRecords
        /// </summary>
        /// <value>Restore selected records populated if restore_type is kRestoreRecords</value>
        [DataMember(Name="recordIdVec", EmitDefaultValue=true)]
        public List<string> RecordIdVec { get; set; }

        /// <summary>
        /// Gets or Sets RestoreType
        /// </summary>
        [DataMember(Name="restoreType", EmitDefaultValue=true)]
        public int? RestoreType { get; set; }

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
            return this.Equals(input as SfdcRestoreObjectParams);
        }

        /// <summary>
        /// Returns true if SfdcRestoreObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcRestoreObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcRestoreObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterQuery == input.FilterQuery ||
                    (this.FilterQuery != null &&
                    this.FilterQuery.Equals(input.FilterQuery))
                ) && 
                (
                    this.IncludeDeletedRecords == input.IncludeDeletedRecords ||
                    (this.IncludeDeletedRecords != null &&
                    this.IncludeDeletedRecords.Equals(input.IncludeDeletedRecords))
                ) && 
                (
                    this.NewObjectName == input.NewObjectName ||
                    (this.NewObjectName != null &&
                    this.NewObjectName.Equals(input.NewObjectName))
                ) && 
                (
                    this.RecordIdVec == input.RecordIdVec ||
                    this.RecordIdVec != null &&
                    input.RecordIdVec != null &&
                    this.RecordIdVec.SequenceEqual(input.RecordIdVec)
                ) && 
                (
                    this.RestoreType == input.RestoreType ||
                    (this.RestoreType != null &&
                    this.RestoreType.Equals(input.RestoreType))
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
                if (this.FilterQuery != null)
                    hashCode = hashCode * 59 + this.FilterQuery.GetHashCode();
                if (this.IncludeDeletedRecords != null)
                    hashCode = hashCode * 59 + this.IncludeDeletedRecords.GetHashCode();
                if (this.NewObjectName != null)
                    hashCode = hashCode * 59 + this.NewObjectName.GetHashCode();
                if (this.RecordIdVec != null)
                    hashCode = hashCode * 59 + this.RecordIdVec.GetHashCode();
                if (this.RestoreType != null)
                    hashCode = hashCode * 59 + this.RestoreType.GetHashCode();
                return hashCode;
            }
        }

    }

}

