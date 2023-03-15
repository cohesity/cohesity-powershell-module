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
    /// Message to capture any additional backup params for Acropolis environment.
    /// </summary>
    [DataContract]
    public partial class AcropolisBackupJobParams :  IEquatable<AcropolisBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcropolisBackupJobParams" /> class.
        /// </summary>
        /// <param name="acropolisDiskExclusionInfo">List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams..</param>
        /// <param name="acropolisDiskInclusionInfo">List of Virtual Disk(s) to be included from the backup job. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams..</param>
        public AcropolisBackupJobParams(List<AcropolisDiskFilterProto> acropolisDiskExclusionInfo = default(List<AcropolisDiskFilterProto>), List<AcropolisDiskFilterProto> acropolisDiskInclusionInfo = default(List<AcropolisDiskFilterProto>))
        {
            this.AcropolisDiskExclusionInfo = acropolisDiskExclusionInfo;
            this.AcropolisDiskInclusionInfo = acropolisDiskInclusionInfo;
            this.AcropolisDiskExclusionInfo = acropolisDiskExclusionInfo;
            this.AcropolisDiskInclusionInfo = acropolisDiskInclusionInfo;
        }
        
        /// <summary>
        /// List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be excluded from the backup job. These disks will be excluded for all VMs in this environment unless overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams.</value>
        [DataMember(Name="acropolisDiskExclusionInfo", EmitDefaultValue=true)]
        public List<AcropolisDiskFilterProto> AcropolisDiskExclusionInfo { get; set; }

        /// <summary>
        /// List of Virtual Disk(s) to be included from the backup job. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams.
        /// </summary>
        /// <value>List of Virtual Disk(s) to be included from the backup job. These disks will be included for all VMs in this environment and all other disks will be excluded. It can be overriden by the disk exclusion/inclusion list from BackupSourceParams.AcropolisBackupSourceParams.</value>
        [DataMember(Name="acropolisDiskInclusionInfo", EmitDefaultValue=true)]
        public List<AcropolisDiskFilterProto> AcropolisDiskInclusionInfo { get; set; }

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
            return this.Equals(input as AcropolisBackupJobParams);
        }

        /// <summary>
        /// Returns true if AcropolisBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AcropolisBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcropolisBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisDiskExclusionInfo == input.AcropolisDiskExclusionInfo ||
                    this.AcropolisDiskExclusionInfo != null &&
                    input.AcropolisDiskExclusionInfo != null &&
                    this.AcropolisDiskExclusionInfo.SequenceEqual(input.AcropolisDiskExclusionInfo)
                ) && 
                (
                    this.AcropolisDiskInclusionInfo == input.AcropolisDiskInclusionInfo ||
                    this.AcropolisDiskInclusionInfo != null &&
                    input.AcropolisDiskInclusionInfo != null &&
                    this.AcropolisDiskInclusionInfo.SequenceEqual(input.AcropolisDiskInclusionInfo)
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
                if (this.AcropolisDiskExclusionInfo != null)
                    hashCode = hashCode * 59 + this.AcropolisDiskExclusionInfo.GetHashCode();
                if (this.AcropolisDiskInclusionInfo != null)
                    hashCode = hashCode * 59 + this.AcropolisDiskInclusionInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

