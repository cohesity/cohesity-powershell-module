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
    /// SiteBackupStatus
    /// </summary>
    [DataContract]
    public partial class SiteBackupStatus :  IEquatable<SiteBackupStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteBackupStatus" /> class.
        /// </summary>
        /// <param name="backupFileVec">List of backuped files. Its PnP package and any other files required to recover the site..</param>
        /// <param name="optionFlags">Actual options with which this site was backed up (BackupSiteArg.BackupSiteOptionFlags)..</param>
        /// <param name="siteInfo">siteInfo.</param>
        /// <param name="warningVec">Backup succeeded, but there were some warnings for user. For example we could not backup term store due to lack of permissions..</param>
        public SiteBackupStatus(List<SiteBackupFile> backupFileVec = default(List<SiteBackupFile>), int? optionFlags = default(int?), SiteInfo siteInfo = default(SiteInfo), List<string> warningVec = default(List<string>))
        {
            this.BackupFileVec = backupFileVec;
            this.OptionFlags = optionFlags;
            this.WarningVec = warningVec;
            this.BackupFileVec = backupFileVec;
            this.OptionFlags = optionFlags;
            this.SiteInfo = siteInfo;
            this.WarningVec = warningVec;
        }
        
        /// <summary>
        /// List of backuped files. Its PnP package and any other files required to recover the site.
        /// </summary>
        /// <value>List of backuped files. Its PnP package and any other files required to recover the site.</value>
        [DataMember(Name="backupFileVec", EmitDefaultValue=true)]
        public List<SiteBackupFile> BackupFileVec { get; set; }

        /// <summary>
        /// Actual options with which this site was backed up (BackupSiteArg.BackupSiteOptionFlags).
        /// </summary>
        /// <value>Actual options with which this site was backed up (BackupSiteArg.BackupSiteOptionFlags).</value>
        [DataMember(Name="optionFlags", EmitDefaultValue=true)]
        public int? OptionFlags { get; set; }

        /// <summary>
        /// Gets or Sets SiteInfo
        /// </summary>
        [DataMember(Name="siteInfo", EmitDefaultValue=false)]
        public SiteInfo SiteInfo { get; set; }

        /// <summary>
        /// Backup succeeded, but there were some warnings for user. For example we could not backup term store due to lack of permissions.
        /// </summary>
        /// <value>Backup succeeded, but there were some warnings for user. For example we could not backup term store due to lack of permissions.</value>
        [DataMember(Name="warningVec", EmitDefaultValue=true)]
        public List<string> WarningVec { get; set; }

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
            return this.Equals(input as SiteBackupStatus);
        }

        /// <summary>
        /// Returns true if SiteBackupStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteBackupStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteBackupStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupFileVec == input.BackupFileVec ||
                    this.BackupFileVec != null &&
                    input.BackupFileVec != null &&
                    this.BackupFileVec.Equals(input.BackupFileVec)
                ) && 
                (
                    this.OptionFlags == input.OptionFlags ||
                    (this.OptionFlags != null &&
                    this.OptionFlags.Equals(input.OptionFlags))
                ) && 
                (
                    this.SiteInfo == input.SiteInfo ||
                    (this.SiteInfo != null &&
                    this.SiteInfo.Equals(input.SiteInfo))
                ) && 
                (
                    this.WarningVec == input.WarningVec ||
                    this.WarningVec != null &&
                    input.WarningVec != null &&
                    this.WarningVec.Equals(input.WarningVec)
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
                if (this.BackupFileVec != null)
                    hashCode = hashCode * 59 + this.BackupFileVec.GetHashCode();
                if (this.OptionFlags != null)
                    hashCode = hashCode * 59 + this.OptionFlags.GetHashCode();
                if (this.SiteInfo != null)
                    hashCode = hashCode * 59 + this.SiteInfo.GetHashCode();
                if (this.WarningVec != null)
                    hashCode = hashCode * 59 + this.WarningVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

