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
    /// S3BackupJobParams
    /// </summary>
    [DataContract]
    public partial class S3BackupJobParams :  IEquatable<S3BackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BackupJobParams" /> class.
        /// </summary>
        /// <param name="backupObjectAcls">If true, we will also backup object level acls if they are enabled..</param>
        /// <param name="skipFilesOnError">If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed..</param>
        /// <param name="storageClasses">Objects whose storage class is not in the selected storage classes will be skipped..</param>
        public S3BackupJobParams(bool? backupObjectAcls = default(bool?), bool? skipFilesOnError = default(bool?), List<int> storageClasses = default(List<int>))
        {
            this.BackupObjectAcls = backupObjectAcls;
            this.SkipFilesOnError = skipFilesOnError;
            this.StorageClasses = storageClasses;
            this.BackupObjectAcls = backupObjectAcls;
            this.SkipFilesOnError = skipFilesOnError;
            this.StorageClasses = storageClasses;
        }
        
        /// <summary>
        /// If true, we will also backup object level acls if they are enabled.
        /// </summary>
        /// <value>If true, we will also backup object level acls if they are enabled.</value>
        [DataMember(Name="backupObjectAcls", EmitDefaultValue=true)]
        public bool? BackupObjectAcls { get; set; }

        /// <summary>
        /// If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed.
        /// </summary>
        /// <value>If true then backup job will skip the S3 objects whose backup get failed. Basically, won&#39;t fail the backup job if some of the objects gets failed.</value>
        [DataMember(Name="skipFilesOnError", EmitDefaultValue=true)]
        public bool? SkipFilesOnError { get; set; }

        /// <summary>
        /// Objects whose storage class is not in the selected storage classes will be skipped.
        /// </summary>
        /// <value>Objects whose storage class is not in the selected storage classes will be skipped.</value>
        [DataMember(Name="storageClasses", EmitDefaultValue=true)]
        public List<int> StorageClasses { get; set; }

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
            return this.Equals(input as S3BackupJobParams);
        }

        /// <summary>
        /// Returns true if S3BackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupObjectAcls == input.BackupObjectAcls ||
                    (this.BackupObjectAcls != null &&
                    this.BackupObjectAcls.Equals(input.BackupObjectAcls))
                ) && 
                (
                    this.SkipFilesOnError == input.SkipFilesOnError ||
                    (this.SkipFilesOnError != null &&
                    this.SkipFilesOnError.Equals(input.SkipFilesOnError))
                ) && 
                (
                    this.StorageClasses == input.StorageClasses ||
                    this.StorageClasses != null &&
                    input.StorageClasses != null &&
                    this.StorageClasses.SequenceEqual(input.StorageClasses)
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
                if (this.BackupObjectAcls != null)
                    hashCode = hashCode * 59 + this.BackupObjectAcls.GetHashCode();
                if (this.SkipFilesOnError != null)
                    hashCode = hashCode * 59 + this.SkipFilesOnError.GetHashCode();
                if (this.StorageClasses != null)
                    hashCode = hashCode * 59 + this.StorageClasses.GetHashCode();
                return hashCode;
            }
        }

    }

}

