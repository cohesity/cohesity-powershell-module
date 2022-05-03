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
    /// Specifies Outlook job parameters applicable for all Office365 Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class OutlookEnvJobParameters :  IEquatable<OutlookEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookEnvJobParameters" /> class.
        /// </summary>
        /// <param name="filePathFilter">filePathFilter.</param>
        /// <param name="shouldBackupMailbox">Specifies whether mailbox of each Office365 Users/Groups within the job, should be backed up or not..</param>
        public OutlookEnvJobParameters(FilePathFilter filePathFilter = default(FilePathFilter), bool? shouldBackupMailbox = default(bool?))
        {
            this.FilePathFilter = filePathFilter;
            this.ShouldBackupMailbox = shouldBackupMailbox;
        }
        
        /// <summary>
        /// Gets or Sets FilePathFilter
        /// </summary>
        [DataMember(Name="filePathFilter", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilter { get; set; }

        /// <summary>
        /// Specifies whether mailbox of each Office365 Users/Groups within the job, should be backed up or not.
        /// </summary>
        /// <value>Specifies whether mailbox of each Office365 Users/Groups within the job, should be backed up or not.</value>
        [DataMember(Name="shouldBackupMailbox", EmitDefaultValue=false)]
        public bool? ShouldBackupMailbox { get; set; }

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
            return this.Equals(input as OutlookEnvJobParameters);
        }

        /// <summary>
        /// Returns true if OutlookEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookEnvJobParameters input)
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
                    this.ShouldBackupMailbox == input.ShouldBackupMailbox ||
                    (this.ShouldBackupMailbox != null &&
                    this.ShouldBackupMailbox.Equals(input.ShouldBackupMailbox))
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
                if (this.ShouldBackupMailbox != null)
                    hashCode = hashCode * 59 + this.ShouldBackupMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

