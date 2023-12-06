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
    /// RestoreExchangeParamsDatabaseOptions
    /// </summary>
    [DataContract]
    public partial class RestoreExchangeParamsDatabaseOptions :  IEquatable<RestoreExchangeParamsDatabaseOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreExchangeParamsDatabaseOptions" /> class.
        /// </summary>
        /// <param name="destDbName">Destination Database Name.</param>
        /// <param name="destEdbFilepath">Target EDB dir path. Example: e:\\myexchange\\hrdb\\hr_db.edb..</param>
        /// <param name="destLogDirpath">Target LOG dir path. Example: e:\\myexchange\\hrdb..</param>
        /// <param name="entityId">The windows machine to which the database will be restored. This field is deprecated..</param>
        /// <param name="mountDb">Mount the Database after successful recovery. For alternate location recovery this will result in Information Store Service restart on the target Exchange Node..</param>
        /// <param name="progressMonitorPath">Progress monitor task path for this entity..</param>
        /// <param name="restoreAsRecoveryDb">Restore this DB as a Recovery Database on the target Exchange Node..</param>
        /// <param name="targetHostEntity">targetHostEntity.</param>
        /// <param name="useLatestLogs">When replaying the logs, use the latest logs on Exchange for this DB. Applicable for restoring to original location only..</param>
        public RestoreExchangeParamsDatabaseOptions(string destDbName = default(string), string destEdbFilepath = default(string), string destLogDirpath = default(string), long? entityId = default(long?), bool? mountDb = default(bool?), string progressMonitorPath = default(string), bool? restoreAsRecoveryDb = default(bool?), EntityProto targetHostEntity = default(EntityProto), bool? useLatestLogs = default(bool?))
        {
            this.DestDbName = destDbName;
            this.DestEdbFilepath = destEdbFilepath;
            this.DestLogDirpath = destLogDirpath;
            this.EntityId = entityId;
            this.MountDb = mountDb;
            this.ProgressMonitorPath = progressMonitorPath;
            this.RestoreAsRecoveryDb = restoreAsRecoveryDb;
            this.UseLatestLogs = useLatestLogs;
            this.DestDbName = destDbName;
            this.DestEdbFilepath = destEdbFilepath;
            this.DestLogDirpath = destLogDirpath;
            this.EntityId = entityId;
            this.MountDb = mountDb;
            this.ProgressMonitorPath = progressMonitorPath;
            this.RestoreAsRecoveryDb = restoreAsRecoveryDb;
            this.TargetHostEntity = targetHostEntity;
            this.UseLatestLogs = useLatestLogs;
        }
        
        /// <summary>
        /// Destination Database Name
        /// </summary>
        /// <value>Destination Database Name</value>
        [DataMember(Name="destDbName", EmitDefaultValue=true)]
        public string DestDbName { get; set; }

        /// <summary>
        /// Target EDB dir path. Example: e:\\myexchange\\hrdb\\hr_db.edb.
        /// </summary>
        /// <value>Target EDB dir path. Example: e:\\myexchange\\hrdb\\hr_db.edb.</value>
        [DataMember(Name="destEdbFilepath", EmitDefaultValue=true)]
        public string DestEdbFilepath { get; set; }

        /// <summary>
        /// Target LOG dir path. Example: e:\\myexchange\\hrdb.
        /// </summary>
        /// <value>Target LOG dir path. Example: e:\\myexchange\\hrdb.</value>
        [DataMember(Name="destLogDirpath", EmitDefaultValue=true)]
        public string DestLogDirpath { get; set; }

        /// <summary>
        /// The windows machine to which the database will be restored. This field is deprecated.
        /// </summary>
        /// <value>The windows machine to which the database will be restored. This field is deprecated.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Mount the Database after successful recovery. For alternate location recovery this will result in Information Store Service restart on the target Exchange Node.
        /// </summary>
        /// <value>Mount the Database after successful recovery. For alternate location recovery this will result in Information Store Service restart on the target Exchange Node.</value>
        [DataMember(Name="mountDb", EmitDefaultValue=true)]
        public bool? MountDb { get; set; }

        /// <summary>
        /// Progress monitor task path for this entity.
        /// </summary>
        /// <value>Progress monitor task path for this entity.</value>
        [DataMember(Name="progressMonitorPath", EmitDefaultValue=true)]
        public string ProgressMonitorPath { get; set; }

        /// <summary>
        /// Restore this DB as a Recovery Database on the target Exchange Node.
        /// </summary>
        /// <value>Restore this DB as a Recovery Database on the target Exchange Node.</value>
        [DataMember(Name="restoreAsRecoveryDb", EmitDefaultValue=true)]
        public bool? RestoreAsRecoveryDb { get; set; }

        /// <summary>
        /// Gets or Sets TargetHostEntity
        /// </summary>
        [DataMember(Name="targetHostEntity", EmitDefaultValue=false)]
        public EntityProto TargetHostEntity { get; set; }

        /// <summary>
        /// When replaying the logs, use the latest logs on Exchange for this DB. Applicable for restoring to original location only.
        /// </summary>
        /// <value>When replaying the logs, use the latest logs on Exchange for this DB. Applicable for restoring to original location only.</value>
        [DataMember(Name="useLatestLogs", EmitDefaultValue=true)]
        public bool? UseLatestLogs { get; set; }

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
            return this.Equals(input as RestoreExchangeParamsDatabaseOptions);
        }

        /// <summary>
        /// Returns true if RestoreExchangeParamsDatabaseOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreExchangeParamsDatabaseOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreExchangeParamsDatabaseOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestDbName == input.DestDbName ||
                    (this.DestDbName != null &&
                    this.DestDbName.Equals(input.DestDbName))
                ) && 
                (
                    this.DestEdbFilepath == input.DestEdbFilepath ||
                    (this.DestEdbFilepath != null &&
                    this.DestEdbFilepath.Equals(input.DestEdbFilepath))
                ) && 
                (
                    this.DestLogDirpath == input.DestLogDirpath ||
                    (this.DestLogDirpath != null &&
                    this.DestLogDirpath.Equals(input.DestLogDirpath))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.MountDb == input.MountDb ||
                    (this.MountDb != null &&
                    this.MountDb.Equals(input.MountDb))
                ) && 
                (
                    this.ProgressMonitorPath == input.ProgressMonitorPath ||
                    (this.ProgressMonitorPath != null &&
                    this.ProgressMonitorPath.Equals(input.ProgressMonitorPath))
                ) && 
                (
                    this.RestoreAsRecoveryDb == input.RestoreAsRecoveryDb ||
                    (this.RestoreAsRecoveryDb != null &&
                    this.RestoreAsRecoveryDb.Equals(input.RestoreAsRecoveryDb))
                ) && 
                (
                    this.TargetHostEntity == input.TargetHostEntity ||
                    (this.TargetHostEntity != null &&
                    this.TargetHostEntity.Equals(input.TargetHostEntity))
                ) && 
                (
                    this.UseLatestLogs == input.UseLatestLogs ||
                    (this.UseLatestLogs != null &&
                    this.UseLatestLogs.Equals(input.UseLatestLogs))
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
                if (this.DestDbName != null)
                    hashCode = hashCode * 59 + this.DestDbName.GetHashCode();
                if (this.DestEdbFilepath != null)
                    hashCode = hashCode * 59 + this.DestEdbFilepath.GetHashCode();
                if (this.DestLogDirpath != null)
                    hashCode = hashCode * 59 + this.DestLogDirpath.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.MountDb != null)
                    hashCode = hashCode * 59 + this.MountDb.GetHashCode();
                if (this.ProgressMonitorPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorPath.GetHashCode();
                if (this.RestoreAsRecoveryDb != null)
                    hashCode = hashCode * 59 + this.RestoreAsRecoveryDb.GetHashCode();
                if (this.TargetHostEntity != null)
                    hashCode = hashCode * 59 + this.TargetHostEntity.GetHashCode();
                if (this.UseLatestLogs != null)
                    hashCode = hashCode * 59 + this.UseLatestLogs.GetHashCode();
                return hashCode;
            }
        }

    }

}

