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
    /// Message to capture params when backing up files on a Physical source.
    /// </summary>
    [DataContract]
    public partial class PhysicalFileBackupParams :  IEquatable<PhysicalFileBackupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalFileBackupParams" /> class.
        /// </summary>
        /// <param name="backupPathInfoVec">Specifies the paths to backup on the Physical source..</param>
        public PhysicalFileBackupParams(List<PhysicalFileBackupParamsBackupPathInfo> backupPathInfoVec = default(List<PhysicalFileBackupParamsBackupPathInfo>))
        {
            this.BackupPathInfoVec = backupPathInfoVec;
            this.BackupPathInfoVec = backupPathInfoVec;
        }
        
        /// <summary>
        /// Specifies the paths to backup on the Physical source.
        /// </summary>
        /// <value>Specifies the paths to backup on the Physical source.</value>
        [DataMember(Name="backupPathInfoVec", EmitDefaultValue=true)]
        public List<PhysicalFileBackupParamsBackupPathInfo> BackupPathInfoVec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhysicalFileBackupParams {\n");
            sb.Append("  BackupPathInfoVec: ").Append(BackupPathInfoVec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as PhysicalFileBackupParams);
        }

        /// <summary>
        /// Returns true if PhysicalFileBackupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalFileBackupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalFileBackupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupPathInfoVec == input.BackupPathInfoVec ||
                    this.BackupPathInfoVec != null &&
                    input.BackupPathInfoVec != null &&
                    this.BackupPathInfoVec.SequenceEqual(input.BackupPathInfoVec)
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
                if (this.BackupPathInfoVec != null)
                    hashCode = hashCode * 59 + this.BackupPathInfoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}
