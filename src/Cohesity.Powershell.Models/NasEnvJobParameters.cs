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
        /// Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NasProtocolEnum
        {
            /// <summary>
            /// Enum KNfs3 for value: kNfs3
            /// </summary>
            [EnumMember(Value = "kNfs3")]
            KNfs3 = 1,

            /// <summary>
            /// Enum KCifs1 for value: kCifs1
            /// </summary>
            [EnumMember(Value = "kCifs1")]
            KCifs1 = 2

        }

        /// <summary>
        /// Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.
        /// </summary>
        /// <value>Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol.</value>
        [DataMember(Name="nasProtocol", EmitDefaultValue=true)]
        public NasProtocolEnum? NasProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NasEnvJobParameters" /> class.
        /// </summary>
        /// <param name="continueOnError">Specifies if the backup should continue on with other Protection Sources even if the backup operation of some Protection Source fails. If true, the Cohesity Cluster ignores the errors and continues with remaining Protection Sources in the job. If false, the backup operation stops when an error occurs. This does not apply to non-snapshot based generic NAS backup jobs. If not set, default value is true..</param>
        /// <param name="dataMigrationJobParameters">dataMigrationJobParameters.</param>
        /// <param name="enableFasterIncrementalBackups">Specifies whether this job will enable faster incremental backups using change list or similar APIs.</param>
        /// <param name="filePathFilters">filePathFilters.</param>
        /// <param name="nasProtocol">Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol..</param>
        public NasEnvJobParameters(bool? continueOnError = default(bool?), DataMigrationJobParameters dataMigrationJobParameters = default(DataMigrationJobParameters), bool? enableFasterIncrementalBackups = default(bool?), FilePathFilter filePathFilters = default(FilePathFilter), NasProtocolEnum? nasProtocol = default(NasProtocolEnum?))
        {
            this.ContinueOnError = continueOnError;
            this.EnableFasterIncrementalBackups = enableFasterIncrementalBackups;
            this.NasProtocol = nasProtocol;
            this.ContinueOnError = continueOnError;
            this.DataMigrationJobParameters = dataMigrationJobParameters;
            this.EnableFasterIncrementalBackups = enableFasterIncrementalBackups;
            this.FilePathFilters = filePathFilters;
            this.NasProtocol = nasProtocol;
        }
        
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
        /// Specifies whether this job will enable faster incremental backups using change list or similar APIs
        /// </summary>
        /// <value>Specifies whether this job will enable faster incremental backups using change list or similar APIs</value>
        [DataMember(Name="enableFasterIncrementalBackups", EmitDefaultValue=true)]
        public bool? EnableFasterIncrementalBackups { get; set; }

        /// <summary>
        /// Gets or Sets FilePathFilters
        /// </summary>
        [DataMember(Name="filePathFilters", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilters { get; set; }

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
                    this.EnableFasterIncrementalBackups == input.EnableFasterIncrementalBackups ||
                    (this.EnableFasterIncrementalBackups != null &&
                    this.EnableFasterIncrementalBackups.Equals(input.EnableFasterIncrementalBackups))
                ) && 
                (
                    this.FilePathFilters == input.FilePathFilters ||
                    (this.FilePathFilters != null &&
                    this.FilePathFilters.Equals(input.FilePathFilters))
                ) && 
                (
                    this.NasProtocol == input.NasProtocol ||
                    this.NasProtocol.Equals(input.NasProtocol)
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
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.DataMigrationJobParameters != null)
                    hashCode = hashCode * 59 + this.DataMigrationJobParameters.GetHashCode();
                if (this.EnableFasterIncrementalBackups != null)
                    hashCode = hashCode * 59 + this.EnableFasterIncrementalBackups.GetHashCode();
                if (this.FilePathFilters != null)
                    hashCode = hashCode * 59 + this.FilePathFilters.GetHashCode();
                hashCode = hashCode * 59 + this.NasProtocol.GetHashCode();
                return hashCode;
            }
        }

    }

}

