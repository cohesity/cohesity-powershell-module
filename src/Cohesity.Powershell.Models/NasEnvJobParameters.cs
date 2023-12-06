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
    /// Specifies job parameters applicable for all &#39;kGenericNas&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class NasEnvJobParameters :  IEquatable<NasEnvJobParameters>
    {
        /// <summary>
        /// Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NasProtocolEnum
        {
            /// <summary>
            /// Enum KNoProtocol for value: kNoProtocol
            /// </summary>
            [EnumMember(Value = "kNoProtocol")]
            KNoProtocol = 1,

            /// <summary>
            /// Enum KNfs3 for value: kNfs3
            /// </summary>
            [EnumMember(Value = "kNfs3")]
            KNfs3 = 2,

            /// <summary>
            /// Enum KNfs41 for value: kNfs4_1
            /// </summary>
            [EnumMember(Value = "kNfs4_1")]
            KNfs41 = 3,

            /// <summary>
            /// Enum KCifs1 for value: kCifs1
            /// </summary>
            [EnumMember(Value = "kCifs1")]
            KCifs1 = 4,

            /// <summary>
            /// Enum KCifs2 for value: kCifs2
            /// </summary>
            [EnumMember(Value = "kCifs2")]
            KCifs2 = 5,

            /// <summary>
            /// Enum KCifs3 for value: kCifs3
            /// </summary>
            [EnumMember(Value = "kCifs3")]
            KCifs3 = 6

        }

        /// <summary>
        /// Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.</value>
        [DataMember(Name="nasProtocol", EmitDefaultValue=true)]
        public NasProtocolEnum? NasProtocol { get; set; }
        /// <summary>
        /// Specifies the preferred NFS protocol to use for the backup when multiple NFS protocols are present on a single volume. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred NFS protocol to use for the backup when multiple NFS protocols are present on a single volume. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NfsVersionPreferenceEnum
        {
            /// <summary>
            /// Enum KNoProtocol for value: kNoProtocol
            /// </summary>
            [EnumMember(Value = "kNoProtocol")]
            KNoProtocol = 1,

            /// <summary>
            /// Enum KNfs3 for value: kNfs3
            /// </summary>
            [EnumMember(Value = "kNfs3")]
            KNfs3 = 2,

            /// <summary>
            /// Enum KNfs41 for value: kNfs4_1
            /// </summary>
            [EnumMember(Value = "kNfs4_1")]
            KNfs41 = 3,

            /// <summary>
            /// Enum KCifs1 for value: kCifs1
            /// </summary>
            [EnumMember(Value = "kCifs1")]
            KCifs1 = 4,

            /// <summary>
            /// Enum KCifs2 for value: kCifs2
            /// </summary>
            [EnumMember(Value = "kCifs2")]
            KCifs2 = 5,

            /// <summary>
            /// Enum KCifs3 for value: kCifs3
            /// </summary>
            [EnumMember(Value = "kCifs3")]
            KCifs3 = 6

        }

        /// <summary>
        /// Specifies the preferred NFS protocol to use for the backup when multiple NFS protocols are present on a single volume. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred NFS protocol to use for the backup when multiple NFS protocols are present on a single volume. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol.</value>
        [DataMember(Name="nfsVersionPreference", EmitDefaultValue=true)]
        public NfsVersionPreferenceEnum? NfsVersionPreference { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NasEnvJobParameters" /> class.
        /// </summary>
        /// <param name="backupExistingSnapshot">Specifies if the protection job should use existing snapshot while backing up..</param>
        /// <param name="continueOnError">Specifies if the backup should continue on with other Protection Sources even if the backup operation of some Protection Source fails. If true, the Cohesity Cluster ignores the errors and continues with remaining Protection Sources in the job. If false, the backup operation stops when an error occurs. This does not apply to non-snapshot based generic NAS backup jobs. If not set, default value is true..</param>
        /// <param name="dataMigrationJobParameters">dataMigrationJobParameters.</param>
        /// <param name="dataUptierJobParameters">dataUptierJobParameters.</param>
        /// <param name="enableFasterIncrementalBackups">Specifies whether this job will enable faster incremental backups using change list or similar APIs.</param>
        /// <param name="encryptionEnabled">Specifies if the protection job should use encryption while backing up..</param>
        /// <param name="fileLockConfig">fileLockConfig.</param>
        /// <param name="filePathFilters">filePathFilters.</param>
        /// <param name="filterIpConfig">filterIpConfig.</param>
        /// <param name="nasProtocol">Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol..</param>
        /// <param name="nfsVersionPreference">Specifies the preferred NFS protocol to use for the backup when multiple NFS protocols are present on a single volume. Specifies the protocol used by a NAS server. &#39;kNoProtocol&#39; indicates no protocol set. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kNfs4_1&#39; indicates NFS v4.1 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. &#39;kCifs2&#39; indicates CIFS v2.0 protocol. &#39;kCifs3&#39; indicates CIFS v3.0 protocol..</param>
        /// <param name="snapshotLabel">snapshotLabel.</param>
        /// <param name="throttlingConfig">throttlingConfig.</param>
        public NasEnvJobParameters(bool? backupExistingSnapshot = default(bool?), bool? continueOnError = default(bool?), DataMigrationJobParameters dataMigrationJobParameters = default(DataMigrationJobParameters), DataUptierJobParameters dataUptierJobParameters = default(DataUptierJobParameters), bool? enableFasterIncrementalBackups = default(bool?), bool? encryptionEnabled = default(bool?), FileLevelDataLockConfig fileLockConfig = default(FileLevelDataLockConfig), FilePathFilter filePathFilters = default(FilePathFilter), FilterIpConfig filterIpConfig = default(FilterIpConfig), NasProtocolEnum? nasProtocol = default(NasProtocolEnum?), NfsVersionPreferenceEnum? nfsVersionPreference = default(NfsVersionPreferenceEnum?), SnapshotLabel snapshotLabel = default(SnapshotLabel), NasSourceThrottlingParams throttlingConfig = default(NasSourceThrottlingParams))
        {
            this.BackupExistingSnapshot = backupExistingSnapshot;
            this.ContinueOnError = continueOnError;
            this.EnableFasterIncrementalBackups = enableFasterIncrementalBackups;
            this.EncryptionEnabled = encryptionEnabled;
            this.NasProtocol = nasProtocol;
            this.NfsVersionPreference = nfsVersionPreference;
            this.BackupExistingSnapshot = backupExistingSnapshot;
            this.ContinueOnError = continueOnError;
            this.DataMigrationJobParameters = dataMigrationJobParameters;
            this.DataUptierJobParameters = dataUptierJobParameters;
            this.EnableFasterIncrementalBackups = enableFasterIncrementalBackups;
            this.EncryptionEnabled = encryptionEnabled;
            this.FileLockConfig = fileLockConfig;
            this.FilePathFilters = filePathFilters;
            this.FilterIpConfig = filterIpConfig;
            this.NasProtocol = nasProtocol;
            this.NfsVersionPreference = nfsVersionPreference;
            this.SnapshotLabel = snapshotLabel;
            this.ThrottlingConfig = throttlingConfig;
        }
        
        /// <summary>
        /// Specifies if the protection job should use existing snapshot while backing up.
        /// </summary>
        /// <value>Specifies if the protection job should use existing snapshot while backing up.</value>
        [DataMember(Name="backupExistingSnapshot", EmitDefaultValue=true)]
        public bool? BackupExistingSnapshot { get; set; }

        /// <summary>
        /// Specifies if the backup should continue on with other Protection Sources even if the backup operation of some Protection Source fails. If true, the Cohesity Cluster ignores the errors and continues with remaining Protection Sources in the job. If false, the backup operation stops when an error occurs. This does not apply to non-snapshot based generic NAS backup jobs. If not set, default value is true.
        /// </summary>
        /// <value>Specifies if the backup should continue on with other Protection Sources even if the backup operation of some Protection Source fails. If true, the Cohesity Cluster ignores the errors and continues with remaining Protection Sources in the job. If false, the backup operation stops when an error occurs. This does not apply to non-snapshot based generic NAS backup jobs. If not set, default value is true.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Gets or Sets DataMigrationJobParameters
        /// </summary>
        [DataMember(Name="dataMigrationJobParameters", EmitDefaultValue=false)]
        public DataMigrationJobParameters DataMigrationJobParameters { get; set; }

        /// <summary>
        /// Gets or Sets DataUptierJobParameters
        /// </summary>
        [DataMember(Name="dataUptierJobParameters", EmitDefaultValue=false)]
        public DataUptierJobParameters DataUptierJobParameters { get; set; }

        /// <summary>
        /// Specifies whether this job will enable faster incremental backups using change list or similar APIs
        /// </summary>
        /// <value>Specifies whether this job will enable faster incremental backups using change list or similar APIs</value>
        [DataMember(Name="enableFasterIncrementalBackups", EmitDefaultValue=true)]
        public bool? EnableFasterIncrementalBackups { get; set; }

        /// <summary>
        /// Specifies if the protection job should use encryption while backing up.
        /// </summary>
        /// <value>Specifies if the protection job should use encryption while backing up.</value>
        [DataMember(Name="encryptionEnabled", EmitDefaultValue=true)]
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets FileLockConfig
        /// </summary>
        [DataMember(Name="fileLockConfig", EmitDefaultValue=false)]
        public FileLevelDataLockConfig FileLockConfig { get; set; }

        /// <summary>
        /// Gets or Sets FilePathFilters
        /// </summary>
        [DataMember(Name="filePathFilters", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilters { get; set; }

        /// <summary>
        /// Gets or Sets FilterIpConfig
        /// </summary>
        [DataMember(Name="filterIpConfig", EmitDefaultValue=false)]
        public FilterIpConfig FilterIpConfig { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotLabel
        /// </summary>
        [DataMember(Name="snapshotLabel", EmitDefaultValue=false)]
        public SnapshotLabel SnapshotLabel { get; set; }

        /// <summary>
        /// Gets or Sets ThrottlingConfig
        /// </summary>
        [DataMember(Name="throttlingConfig", EmitDefaultValue=false)]
        public NasSourceThrottlingParams ThrottlingConfig { get; set; }

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
            return this.Equals(input as NasEnvJobParameters);
        }

        /// <summary>
        /// Returns true if NasEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of NasEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NasEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupExistingSnapshot == input.BackupExistingSnapshot ||
                    (this.BackupExistingSnapshot != null &&
                    this.BackupExistingSnapshot.Equals(input.BackupExistingSnapshot))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.DataMigrationJobParameters == input.DataMigrationJobParameters ||
                    (this.DataMigrationJobParameters != null &&
                    this.DataMigrationJobParameters.Equals(input.DataMigrationJobParameters))
                ) && 
                (
                    this.DataUptierJobParameters == input.DataUptierJobParameters ||
                    (this.DataUptierJobParameters != null &&
                    this.DataUptierJobParameters.Equals(input.DataUptierJobParameters))
                ) && 
                (
                    this.EnableFasterIncrementalBackups == input.EnableFasterIncrementalBackups ||
                    (this.EnableFasterIncrementalBackups != null &&
                    this.EnableFasterIncrementalBackups.Equals(input.EnableFasterIncrementalBackups))
                ) && 
                (
                    this.EncryptionEnabled == input.EncryptionEnabled ||
                    (this.EncryptionEnabled != null &&
                    this.EncryptionEnabled.Equals(input.EncryptionEnabled))
                ) && 
                (
                    this.FileLockConfig == input.FileLockConfig ||
                    (this.FileLockConfig != null &&
                    this.FileLockConfig.Equals(input.FileLockConfig))
                ) && 
                (
                    this.FilePathFilters == input.FilePathFilters ||
                    (this.FilePathFilters != null &&
                    this.FilePathFilters.Equals(input.FilePathFilters))
                ) && 
                (
                    this.FilterIpConfig == input.FilterIpConfig ||
                    (this.FilterIpConfig != null &&
                    this.FilterIpConfig.Equals(input.FilterIpConfig))
                ) && 
                (
                    this.NasProtocol == input.NasProtocol ||
                    this.NasProtocol.Equals(input.NasProtocol)
                ) && 
                (
                    this.NfsVersionPreference == input.NfsVersionPreference ||
                    this.NfsVersionPreference.Equals(input.NfsVersionPreference)
                ) && 
                (
                    this.SnapshotLabel == input.SnapshotLabel ||
                    (this.SnapshotLabel != null &&
                    this.SnapshotLabel.Equals(input.SnapshotLabel))
                ) && 
                (
                    this.ThrottlingConfig == input.ThrottlingConfig ||
                    (this.ThrottlingConfig != null &&
                    this.ThrottlingConfig.Equals(input.ThrottlingConfig))
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
                if (this.BackupExistingSnapshot != null)
                    hashCode = hashCode * 59 + this.BackupExistingSnapshot.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.DataMigrationJobParameters != null)
                    hashCode = hashCode * 59 + this.DataMigrationJobParameters.GetHashCode();
                if (this.DataUptierJobParameters != null)
                    hashCode = hashCode * 59 + this.DataUptierJobParameters.GetHashCode();
                if (this.EnableFasterIncrementalBackups != null)
                    hashCode = hashCode * 59 + this.EnableFasterIncrementalBackups.GetHashCode();
                if (this.EncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.EncryptionEnabled.GetHashCode();
                if (this.FileLockConfig != null)
                    hashCode = hashCode * 59 + this.FileLockConfig.GetHashCode();
                if (this.FilePathFilters != null)
                    hashCode = hashCode * 59 + this.FilePathFilters.GetHashCode();
                if (this.FilterIpConfig != null)
                    hashCode = hashCode * 59 + this.FilterIpConfig.GetHashCode();
                hashCode = hashCode * 59 + this.NasProtocol.GetHashCode();
                hashCode = hashCode * 59 + this.NfsVersionPreference.GetHashCode();
                if (this.SnapshotLabel != null)
                    hashCode = hashCode * 59 + this.SnapshotLabel.GetHashCode();
                if (this.ThrottlingConfig != null)
                    hashCode = hashCode * 59 + this.ThrottlingConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

