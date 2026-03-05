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
    /// Contains any additional hive environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class HiveBackupJobParams :  IEquatable<HiveBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiveBackupJobParams" /> class.
        /// </summary>
        /// <param name="excludeObjectVec">List of FQN of objects to be excluded from backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats If this contains same entity as include_object_vec, we give priority to exclusion..</param>
        /// <param name="hdfsConnectParams">hdfsConnectParams.</param>
        /// <param name="includeObjectVec">List of FQN of objects to be included in backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats.</param>
        /// <param name="overwriteExcludeObjectVec">If disabled, The exclude_object_vec is merged with the exclude_sources_vec , preserving any existing elements while incorporating new ones. If disabled, The exclude_object_vec fully replaces the exclude_sources_vec discarding any previous contents..</param>
        /// <param name="overwriteIncludeObjectVec">If disabled, include_object_vec is merged with the existing sources_vec , preserving any existing elements while incorporating new ones. The include_object_vec fully replaces the sources_vec, discarding any previous contents..</param>
        public HiveBackupJobParams(List<string> excludeObjectVec = default(List<string>), HdfsConnectParams hdfsConnectParams = default(HdfsConnectParams), List<string> includeObjectVec = default(List<string>), bool? overwriteExcludeObjectVec = default(bool?), bool? overwriteIncludeObjectVec = default(bool?))
        {
            this.ExcludeObjectVec = excludeObjectVec;
            this.IncludeObjectVec = includeObjectVec;
            this.OverwriteExcludeObjectVec = overwriteExcludeObjectVec;
            this.OverwriteIncludeObjectVec = overwriteIncludeObjectVec;
            this.ExcludeObjectVec = excludeObjectVec;
            this.HdfsConnectParams = hdfsConnectParams;
            this.IncludeObjectVec = includeObjectVec;
            this.OverwriteExcludeObjectVec = overwriteExcludeObjectVec;
            this.OverwriteIncludeObjectVec = overwriteIncludeObjectVec;
        }
        
        /// <summary>
        /// List of FQN of objects to be excluded from backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats If this contains same entity as include_object_vec, we give priority to exclusion.
        /// </summary>
        /// <value>List of FQN of objects to be excluded from backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats If this contains same entity as include_object_vec, we give priority to exclusion.</value>
        [DataMember(Name="excludeObjectVec", EmitDefaultValue=true)]
        public List<string> ExcludeObjectVec { get; set; }

        /// <summary>
        /// Gets or Sets HdfsConnectParams
        /// </summary>
        [DataMember(Name="hdfsConnectParams", EmitDefaultValue=false)]
        public HdfsConnectParams HdfsConnectParams { get; set; }

        /// <summary>
        /// List of FQN of objects to be included in backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats
        /// </summary>
        /// <value>List of FQN of objects to be included in backup. For database FQN is just the name. eg. adserver_db For tables FQN in db name and table name eg. adserver_db.click_stats</value>
        [DataMember(Name="includeObjectVec", EmitDefaultValue=true)]
        public List<string> IncludeObjectVec { get; set; }

        /// <summary>
        /// If disabled, The exclude_object_vec is merged with the exclude_sources_vec , preserving any existing elements while incorporating new ones. If disabled, The exclude_object_vec fully replaces the exclude_sources_vec discarding any previous contents.
        /// </summary>
        /// <value>If disabled, The exclude_object_vec is merged with the exclude_sources_vec , preserving any existing elements while incorporating new ones. If disabled, The exclude_object_vec fully replaces the exclude_sources_vec discarding any previous contents.</value>
        [DataMember(Name="overwriteExcludeObjectVec", EmitDefaultValue=true)]
        public bool? OverwriteExcludeObjectVec { get; set; }

        /// <summary>
        /// If disabled, include_object_vec is merged with the existing sources_vec , preserving any existing elements while incorporating new ones. The include_object_vec fully replaces the sources_vec, discarding any previous contents.
        /// </summary>
        /// <value>If disabled, include_object_vec is merged with the existing sources_vec , preserving any existing elements while incorporating new ones. The include_object_vec fully replaces the sources_vec, discarding any previous contents.</value>
        [DataMember(Name="overwriteIncludeObjectVec", EmitDefaultValue=true)]
        public bool? OverwriteIncludeObjectVec { get; set; }

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
            return this.Equals(input as HiveBackupJobParams);
        }

        /// <summary>
        /// Returns true if HiveBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HiveBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiveBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeObjectVec == input.ExcludeObjectVec ||
                    this.ExcludeObjectVec != null &&
                    input.ExcludeObjectVec != null &&
                    this.ExcludeObjectVec.SequenceEqual(input.ExcludeObjectVec)
                ) && 
                (
                    this.HdfsConnectParams == input.HdfsConnectParams ||
                    (this.HdfsConnectParams != null &&
                    this.HdfsConnectParams.Equals(input.HdfsConnectParams))
                ) && 
                (
                    this.IncludeObjectVec == input.IncludeObjectVec ||
                    this.IncludeObjectVec != null &&
                    input.IncludeObjectVec != null &&
                    this.IncludeObjectVec.SequenceEqual(input.IncludeObjectVec)
                ) && 
                (
                    this.OverwriteExcludeObjectVec == input.OverwriteExcludeObjectVec ||
                    (this.OverwriteExcludeObjectVec != null &&
                    this.OverwriteExcludeObjectVec.Equals(input.OverwriteExcludeObjectVec))
                ) && 
                (
                    this.OverwriteIncludeObjectVec == input.OverwriteIncludeObjectVec ||
                    (this.OverwriteIncludeObjectVec != null &&
                    this.OverwriteIncludeObjectVec.Equals(input.OverwriteIncludeObjectVec))
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
                if (this.ExcludeObjectVec != null)
                    hashCode = hashCode * 59 + this.ExcludeObjectVec.GetHashCode();
                if (this.HdfsConnectParams != null)
                    hashCode = hashCode * 59 + this.HdfsConnectParams.GetHashCode();
                if (this.IncludeObjectVec != null)
                    hashCode = hashCode * 59 + this.IncludeObjectVec.GetHashCode();
                if (this.OverwriteExcludeObjectVec != null)
                    hashCode = hashCode * 59 + this.OverwriteExcludeObjectVec.GetHashCode();
                if (this.OverwriteIncludeObjectVec != null)
                    hashCode = hashCode * 59 + this.OverwriteIncludeObjectVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

