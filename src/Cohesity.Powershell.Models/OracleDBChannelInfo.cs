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
    /// Note: The name of this proto message is out-dated. This proto can represent more than just the database channel information. It should be renamed in the future.
    /// </summary>
    [DataContract]
    public partial class OracleDBChannelInfo :  IEquatable<OracleDBChannelInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDBChannelInfo" /> class.
        /// </summary>
        /// <param name="archivelogKeepDays">Archived log deletion policy for this unique Oracle database. 1: keep archived log forever 0: delete archived log immediately n&gt;0: delete archived log after n days.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="dbUniqueName">The unique name of the database..</param>
        /// <param name="dbUuid">Database id, internal field, is filled by magneto master based on corresponding app entity id..</param>
        /// <param name="enableDgPrimaryBackup">If set to false, and if the DG database role is primary, we will not allow the backup of that database..</param>
        /// <param name="hostInfoVec">Vector of Oracle hosts from which we are allowed to take the backup/restore. In case of RAC database it may be more than one..</param>
        /// <param name="maxNumHost">Maximum number of hosts from which we are allowed to take backup/restore parallely. This will be less than or equal to host_info_vec_size. If this is less than host_info_vec_size we will choose max_num_host from host_info_vec and take backup/restore from this number of host..</param>
        /// <param name="numChannels">The default number of channels to use per host per db. This value is used on all hosts unless host_info_vec.num_channels is specified for that host. Default value for num_channels will be calculated as minimum number of nodes in cohesity cluster, and 2 * number of cpu on Oracle host. Preference order for number of channels per host for given db is: 1. If user has specified host_info_vec.num_channels for host we will use that. 2. If user has not specified host_info_vec.num_channels but specified num_channels we will use this. 3. If user has neither specified host_info_vec.num_channels nor num_channels we will calculate default channels with above formula..</param>
        /// <param name="rmanBackupType">Type of Oracle RMAN backup rquested (i.e ImageCopy, BackupSets)..</param>
        public OracleDBChannelInfo(int? archivelogKeepDays = default(int?), Credentials credentials = default(Credentials), string dbUniqueName = default(string), string dbUuid = default(string), bool? enableDgPrimaryBackup = default(bool?), List<OracleDBChannelInfoHostInfo> hostInfoVec = default(List<OracleDBChannelInfoHostInfo>), int? maxNumHost = default(int?), int? numChannels = default(int?), int? rmanBackupType = default(int?))
        {
            this.ArchivelogKeepDays = archivelogKeepDays;
            this.Credentials = credentials;
            this.DbUniqueName = dbUniqueName;
            this.DbUuid = dbUuid;
            this.EnableDgPrimaryBackup = enableDgPrimaryBackup;
            this.HostInfoVec = hostInfoVec;
            this.MaxNumHost = maxNumHost;
            this.NumChannels = numChannels;
            this.RmanBackupType = rmanBackupType;
        }
        
        /// <summary>
        /// Archived log deletion policy for this unique Oracle database. 1: keep archived log forever 0: delete archived log immediately n&gt;0: delete archived log after n days
        /// </summary>
        /// <value>Archived log deletion policy for this unique Oracle database. 1: keep archived log forever 0: delete archived log immediately n&gt;0: delete archived log after n days</value>
        [DataMember(Name="archivelogKeepDays", EmitDefaultValue=true)]
        public int? ArchivelogKeepDays { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// The unique name of the database.
        /// </summary>
        /// <value>The unique name of the database.</value>
        [DataMember(Name="dbUniqueName", EmitDefaultValue=true)]
        public string DbUniqueName { get; set; }

        /// <summary>
        /// Database id, internal field, is filled by magneto master based on corresponding app entity id.
        /// </summary>
        /// <value>Database id, internal field, is filled by magneto master based on corresponding app entity id.</value>
        [DataMember(Name="dbUuid", EmitDefaultValue=true)]
        public string DbUuid { get; set; }

        /// <summary>
        /// If set to false, and if the DG database role is primary, we will not allow the backup of that database.
        /// </summary>
        /// <value>If set to false, and if the DG database role is primary, we will not allow the backup of that database.</value>
        [DataMember(Name="enableDgPrimaryBackup", EmitDefaultValue=true)]
        public bool? EnableDgPrimaryBackup { get; set; }

        /// <summary>
        /// Vector of Oracle hosts from which we are allowed to take the backup/restore. In case of RAC database it may be more than one.
        /// </summary>
        /// <value>Vector of Oracle hosts from which we are allowed to take the backup/restore. In case of RAC database it may be more than one.</value>
        [DataMember(Name="hostInfoVec", EmitDefaultValue=true)]
        public List<OracleDBChannelInfoHostInfo> HostInfoVec { get; set; }

        /// <summary>
        /// Maximum number of hosts from which we are allowed to take backup/restore parallely. This will be less than or equal to host_info_vec_size. If this is less than host_info_vec_size we will choose max_num_host from host_info_vec and take backup/restore from this number of host.
        /// </summary>
        /// <value>Maximum number of hosts from which we are allowed to take backup/restore parallely. This will be less than or equal to host_info_vec_size. If this is less than host_info_vec_size we will choose max_num_host from host_info_vec and take backup/restore from this number of host.</value>
        [DataMember(Name="maxNumHost", EmitDefaultValue=true)]
        public int? MaxNumHost { get; set; }

        /// <summary>
        /// The default number of channels to use per host per db. This value is used on all hosts unless host_info_vec.num_channels is specified for that host. Default value for num_channels will be calculated as minimum number of nodes in cohesity cluster, and 2 * number of cpu on Oracle host. Preference order for number of channels per host for given db is: 1. If user has specified host_info_vec.num_channels for host we will use that. 2. If user has not specified host_info_vec.num_channels but specified num_channels we will use this. 3. If user has neither specified host_info_vec.num_channels nor num_channels we will calculate default channels with above formula.
        /// </summary>
        /// <value>The default number of channels to use per host per db. This value is used on all hosts unless host_info_vec.num_channels is specified for that host. Default value for num_channels will be calculated as minimum number of nodes in cohesity cluster, and 2 * number of cpu on Oracle host. Preference order for number of channels per host for given db is: 1. If user has specified host_info_vec.num_channels for host we will use that. 2. If user has not specified host_info_vec.num_channels but specified num_channels we will use this. 3. If user has neither specified host_info_vec.num_channels nor num_channels we will calculate default channels with above formula.</value>
        [DataMember(Name="numChannels", EmitDefaultValue=true)]
        public int? NumChannels { get; set; }

        /// <summary>
        /// Type of Oracle RMAN backup rquested (i.e ImageCopy, BackupSets).
        /// </summary>
        /// <value>Type of Oracle RMAN backup rquested (i.e ImageCopy, BackupSets).</value>
        [DataMember(Name="rmanBackupType", EmitDefaultValue=true)]
        public int? RmanBackupType { get; set; }

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
            return this.Equals(input as OracleDBChannelInfo);
        }

        /// <summary>
        /// Returns true if OracleDBChannelInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDBChannelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDBChannelInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivelogKeepDays == input.ArchivelogKeepDays ||
                    (this.ArchivelogKeepDays != null &&
                    this.ArchivelogKeepDays.Equals(input.ArchivelogKeepDays))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.DbUniqueName == input.DbUniqueName ||
                    (this.DbUniqueName != null &&
                    this.DbUniqueName.Equals(input.DbUniqueName))
                ) && 
                (
                    this.DbUuid == input.DbUuid ||
                    (this.DbUuid != null &&
                    this.DbUuid.Equals(input.DbUuid))
                ) && 
                (
                    this.EnableDgPrimaryBackup == input.EnableDgPrimaryBackup ||
                    (this.EnableDgPrimaryBackup != null &&
                    this.EnableDgPrimaryBackup.Equals(input.EnableDgPrimaryBackup))
                ) && 
                (
                    this.HostInfoVec == input.HostInfoVec ||
                    this.HostInfoVec != null &&
                    input.HostInfoVec != null &&
                    this.HostInfoVec.Equals(input.HostInfoVec)
                ) && 
                (
                    this.MaxNumHost == input.MaxNumHost ||
                    (this.MaxNumHost != null &&
                    this.MaxNumHost.Equals(input.MaxNumHost))
                ) && 
                (
                    this.NumChannels == input.NumChannels ||
                    (this.NumChannels != null &&
                    this.NumChannels.Equals(input.NumChannels))
                ) && 
                (
                    this.RmanBackupType == input.RmanBackupType ||
                    (this.RmanBackupType != null &&
                    this.RmanBackupType.Equals(input.RmanBackupType))
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
                if (this.ArchivelogKeepDays != null)
                    hashCode = hashCode * 59 + this.ArchivelogKeepDays.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.DbUniqueName != null)
                    hashCode = hashCode * 59 + this.DbUniqueName.GetHashCode();
                if (this.DbUuid != null)
                    hashCode = hashCode * 59 + this.DbUuid.GetHashCode();
                if (this.EnableDgPrimaryBackup != null)
                    hashCode = hashCode * 59 + this.EnableDgPrimaryBackup.GetHashCode();
                if (this.HostInfoVec != null)
                    hashCode = hashCode * 59 + this.HostInfoVec.GetHashCode();
                if (this.MaxNumHost != null)
                    hashCode = hashCode * 59 + this.MaxNumHost.GetHashCode();
                if (this.NumChannels != null)
                    hashCode = hashCode * 59 + this.NumChannels.GetHashCode();
                if (this.RmanBackupType != null)
                    hashCode = hashCode * 59 + this.RmanBackupType.GetHashCode();
                return hashCode;
            }
        }

    }

}

