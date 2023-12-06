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
        /// <param name="filterQuery">This field contains the user provided query to select only subset of records in an object for recovery. This field is set only if restore_type is &#39;kRestoreFilter;..</param>
        /// <param name="includeDeletedRecords">This field specifies whether to include the records in user selected object, that were marked as deleted in the user selected snapshot. This is applicable for restore types &#39;kRestoreObject&#39; and &#39;kRestoreOrg&#39;..</param>
        /// <param name="mutationType">The type of records to be returned. This is only applicable for restore type &#39;kRestoreFilter&#39;..</param>
        /// <param name="newObjectName">The new name of the object, if it is going to be renamed..</param>
        /// <param name="recordIdVec">Restore selected records from user selected object. This field is set only if restore_type is &#39;kRestoreRecords&#39;..</param>
        /// <param name="sfdcRestoreType">Please note that this restore_type is applicable only for the restore of Sfdc adapter. It is different from the Magneto infra field &#39;restore_type&#39; that is applicable for all the Recovery tasks..</param>
        public SfdcRestoreObjectParams(string filterQuery = default(string), bool? includeDeletedRecords = default(bool?), int? mutationType = default(int?), string newObjectName = default(string), List<string> recordIdVec = default(List<string>), int? sfdcRestoreType = default(int?))
        {
            this.FilterQuery = filterQuery;
            this.IncludeDeletedRecords = includeDeletedRecords;
            this.MutationType = mutationType;
            this.NewObjectName = newObjectName;
            this.RecordIdVec = recordIdVec;
            this.SfdcRestoreType = sfdcRestoreType;
            this.FilterQuery = filterQuery;
            this.IncludeDeletedRecords = includeDeletedRecords;
            this.MutationType = mutationType;
            this.NewObjectName = newObjectName;
            this.RecordIdVec = recordIdVec;
            this.SfdcRestoreType = sfdcRestoreType;
        }
        
        /// <summary>
        /// This field contains the user provided query to select only subset of records in an object for recovery. This field is set only if restore_type is &#39;kRestoreFilter;.
        /// </summary>
        /// <value>This field contains the user provided query to select only subset of records in an object for recovery. This field is set only if restore_type is &#39;kRestoreFilter;.</value>
        [DataMember(Name="filterQuery", EmitDefaultValue=true)]
        public string FilterQuery { get; set; }

        /// <summary>
        /// This field specifies whether to include the records in user selected object, that were marked as deleted in the user selected snapshot. This is applicable for restore types &#39;kRestoreObject&#39; and &#39;kRestoreOrg&#39;.
        /// </summary>
        /// <value>This field specifies whether to include the records in user selected object, that were marked as deleted in the user selected snapshot. This is applicable for restore types &#39;kRestoreObject&#39; and &#39;kRestoreOrg&#39;.</value>
        [DataMember(Name="includeDeletedRecords", EmitDefaultValue=true)]
        public bool? IncludeDeletedRecords { get; set; }

        /// <summary>
        /// The type of records to be returned. This is only applicable for restore type &#39;kRestoreFilter&#39;.
        /// </summary>
        /// <value>The type of records to be returned. This is only applicable for restore type &#39;kRestoreFilter&#39;.</value>
        [DataMember(Name="mutationType", EmitDefaultValue=true)]
        public int? MutationType { get; set; }

        /// <summary>
        /// The new name of the object, if it is going to be renamed.
        /// </summary>
        /// <value>The new name of the object, if it is going to be renamed.</value>
        [DataMember(Name="newObjectName", EmitDefaultValue=true)]
        public string NewObjectName { get; set; }

        /// <summary>
        /// Restore selected records from user selected object. This field is set only if restore_type is &#39;kRestoreRecords&#39;.
        /// </summary>
        /// <value>Restore selected records from user selected object. This field is set only if restore_type is &#39;kRestoreRecords&#39;.</value>
        [DataMember(Name="recordIdVec", EmitDefaultValue=true)]
        public List<string> RecordIdVec { get; set; }

        /// <summary>
        /// Please note that this restore_type is applicable only for the restore of Sfdc adapter. It is different from the Magneto infra field &#39;restore_type&#39; that is applicable for all the Recovery tasks.
        /// </summary>
        /// <value>Please note that this restore_type is applicable only for the restore of Sfdc adapter. It is different from the Magneto infra field &#39;restore_type&#39; that is applicable for all the Recovery tasks.</value>
        [DataMember(Name="sfdcRestoreType", EmitDefaultValue=true)]
        public int? SfdcRestoreType { get; set; }

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
                    this.MutationType == input.MutationType ||
                    (this.MutationType != null &&
                    this.MutationType.Equals(input.MutationType))
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
                    this.SfdcRestoreType == input.SfdcRestoreType ||
                    (this.SfdcRestoreType != null &&
                    this.SfdcRestoreType.Equals(input.SfdcRestoreType))
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
                if (this.MutationType != null)
                    hashCode = hashCode * 59 + this.MutationType.GetHashCode();
                if (this.NewObjectName != null)
                    hashCode = hashCode * 59 + this.NewObjectName.GetHashCode();
                if (this.RecordIdVec != null)
                    hashCode = hashCode * 59 + this.RecordIdVec.GetHashCode();
                if (this.SfdcRestoreType != null)
                    hashCode = hashCode * 59 + this.SfdcRestoreType.GetHashCode();
                return hashCode;
            }
        }

    }

}

