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
    /// CloudDomainMigrationQueryResult represents the info returned while querying cloud domain migration.
    /// </summary>
    [DataContract]
    public partial class CloudDomainMigrationQueryResult :  IEquatable<CloudDomainMigrationQueryResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDomainMigrationQueryResult" /> class.
        /// </summary>
        /// <param name="appJobUidList">Specifies the list of the application jobs discovered..</param>
        /// <param name="cloudDomainId">Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated..</param>
        /// <param name="commonJobInfo">commonJobInfo.</param>
        /// <param name="isCadMode">Specifies if the migration mode is CAD or not..</param>
        /// <param name="isMigrationReady">Specifies whether the protection jobs/objects in the cloud domain are ready to be migrated. This is set after required snap trees have been downloaded and CM tables have been populated..</param>
        /// <param name="numOfBytesDownloaded">Specifies the Number of bytes downloaded by this job. The downloaded bytes are for reading metadata object, data objects and index files..</param>
        public CloudDomainMigrationQueryResult(List<UniversalId> appJobUidList = default(List<UniversalId>), long? cloudDomainId = default(long?), CommonJobInfo commonJobInfo = default(CommonJobInfo), bool? isCadMode = default(bool?), bool? isMigrationReady = default(bool?), long? numOfBytesDownloaded = default(long?))
        {
            this.AppJobUidList = appJobUidList;
            this.CloudDomainId = cloudDomainId;
            this.IsCadMode = isCadMode;
            this.IsMigrationReady = isMigrationReady;
            this.NumOfBytesDownloaded = numOfBytesDownloaded;
            this.AppJobUidList = appJobUidList;
            this.CloudDomainId = cloudDomainId;
            this.CommonJobInfo = commonJobInfo;
            this.IsCadMode = isCadMode;
            this.IsMigrationReady = isMigrationReady;
            this.NumOfBytesDownloaded = numOfBytesDownloaded;
        }
        
        /// <summary>
        /// Specifies the list of the application jobs discovered.
        /// </summary>
        /// <value>Specifies the list of the application jobs discovered.</value>
        [DataMember(Name="appJobUidList", EmitDefaultValue=true)]
        public List<UniversalId> AppJobUidList { get; set; }

        /// <summary>
        /// Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated.
        /// </summary>
        /// <value>Specifies the Id of a specific cloud domain present inside the vault, that needs to be migrated. If not set, all cloud domains found in the vault or under the &#39;domain_namespace&#39; specified in CADConfig will be migrated.</value>
        [DataMember(Name="cloudDomainId", EmitDefaultValue=true)]
        public long? CloudDomainId { get; set; }

        /// <summary>
        /// Gets or Sets CommonJobInfo
        /// </summary>
        [DataMember(Name="commonJobInfo", EmitDefaultValue=false)]
        public CommonJobInfo CommonJobInfo { get; set; }

        /// <summary>
        /// Specifies if the migration mode is CAD or not.
        /// </summary>
        /// <value>Specifies if the migration mode is CAD or not.</value>
        [DataMember(Name="isCadMode", EmitDefaultValue=true)]
        public bool? IsCadMode { get; set; }

        /// <summary>
        /// Specifies whether the protection jobs/objects in the cloud domain are ready to be migrated. This is set after required snap trees have been downloaded and CM tables have been populated.
        /// </summary>
        /// <value>Specifies whether the protection jobs/objects in the cloud domain are ready to be migrated. This is set after required snap trees have been downloaded and CM tables have been populated.</value>
        [DataMember(Name="isMigrationReady", EmitDefaultValue=true)]
        public bool? IsMigrationReady { get; set; }

        /// <summary>
        /// Specifies the Number of bytes downloaded by this job. The downloaded bytes are for reading metadata object, data objects and index files.
        /// </summary>
        /// <value>Specifies the Number of bytes downloaded by this job. The downloaded bytes are for reading metadata object, data objects and index files.</value>
        [DataMember(Name="numOfBytesDownloaded", EmitDefaultValue=true)]
        public long? NumOfBytesDownloaded { get; set; }

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
            return this.Equals(input as CloudDomainMigrationQueryResult);
        }

        /// <summary>
        /// Returns true if CloudDomainMigrationQueryResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDomainMigrationQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDomainMigrationQueryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppJobUidList == input.AppJobUidList ||
                    this.AppJobUidList != null &&
                    input.AppJobUidList != null &&
                    this.AppJobUidList.SequenceEqual(input.AppJobUidList)
                ) && 
                (
                    this.CloudDomainId == input.CloudDomainId ||
                    (this.CloudDomainId != null &&
                    this.CloudDomainId.Equals(input.CloudDomainId))
                ) && 
                (
                    this.CommonJobInfo == input.CommonJobInfo ||
                    (this.CommonJobInfo != null &&
                    this.CommonJobInfo.Equals(input.CommonJobInfo))
                ) && 
                (
                    this.IsCadMode == input.IsCadMode ||
                    (this.IsCadMode != null &&
                    this.IsCadMode.Equals(input.IsCadMode))
                ) && 
                (
                    this.IsMigrationReady == input.IsMigrationReady ||
                    (this.IsMigrationReady != null &&
                    this.IsMigrationReady.Equals(input.IsMigrationReady))
                ) && 
                (
                    this.NumOfBytesDownloaded == input.NumOfBytesDownloaded ||
                    (this.NumOfBytesDownloaded != null &&
                    this.NumOfBytesDownloaded.Equals(input.NumOfBytesDownloaded))
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
                if (this.AppJobUidList != null)
                    hashCode = hashCode * 59 + this.AppJobUidList.GetHashCode();
                if (this.CloudDomainId != null)
                    hashCode = hashCode * 59 + this.CloudDomainId.GetHashCode();
                if (this.CommonJobInfo != null)
                    hashCode = hashCode * 59 + this.CommonJobInfo.GetHashCode();
                if (this.IsCadMode != null)
                    hashCode = hashCode * 59 + this.IsCadMode.GetHashCode();
                if (this.IsMigrationReady != null)
                    hashCode = hashCode * 59 + this.IsMigrationReady.GetHashCode();
                if (this.NumOfBytesDownloaded != null)
                    hashCode = hashCode * 59 + this.NumOfBytesDownloaded.GetHashCode();
                return hashCode;
            }
        }

    }

}

