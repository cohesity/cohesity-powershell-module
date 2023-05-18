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
    /// Specifies OneDrive job parameters applicable for all Office365 Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class OneDriveEnvJobParameters :  IEquatable<OneDriveEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveEnvJobParameters" /> class.
        /// </summary>
        /// <param name="filePathFilter">filePathFilter.</param>
        /// <param name="shouldBackupOnedrive">Specifies whether OneDrive(s) of each Office365 Users/Groups within the job, should be backed up or not..</param>
        public OneDriveEnvJobParameters(FilePathFilter filePathFilter = default(FilePathFilter), bool? shouldBackupOnedrive = default(bool?))
        {
            this.ShouldBackupOnedrive = shouldBackupOnedrive;
            this.FilePathFilter = filePathFilter;
            this.ShouldBackupOnedrive = shouldBackupOnedrive;
        }
        
        /// <summary>
        /// Gets or Sets FilePathFilter
        /// </summary>
        [DataMember(Name="filePathFilter", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilter { get; set; }

        /// <summary>
        /// Specifies whether OneDrive(s) of each Office365 Users/Groups within the job, should be backed up or not.
        /// </summary>
        /// <value>Specifies whether OneDrive(s) of each Office365 Users/Groups within the job, should be backed up or not.</value>
        [DataMember(Name="shouldBackupOnedrive", EmitDefaultValue=true)]
        public bool? ShouldBackupOnedrive { get; set; }

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
            return this.Equals(input as OneDriveEnvJobParameters);
        }

        /// <summary>
        /// Returns true if OneDriveEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OneDriveEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneDriveEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePathFilter == input.FilePathFilter ||
                    (this.FilePathFilter != null &&
                    this.FilePathFilter.Equals(input.FilePathFilter))
                ) && 
                (
                    this.ShouldBackupOnedrive == input.ShouldBackupOnedrive ||
                    (this.ShouldBackupOnedrive != null &&
                    this.ShouldBackupOnedrive.Equals(input.ShouldBackupOnedrive))
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
                if (this.FilePathFilter != null)
                    hashCode = hashCode * 59 + this.FilePathFilter.GetHashCode();
                if (this.ShouldBackupOnedrive != null)
                    hashCode = hashCode * 59 + this.ShouldBackupOnedrive.GetHashCode();
                return hashCode;
            }
        }

    }

}

