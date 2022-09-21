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
    /// Specifies an Object representing one Oracle database.
    /// </summary>
    [DataContract]
    public partial class OracleProtectionSource :  IEquatable<OracleProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the database in Oracle Protection Source. &#39;kRACDatabase&#39; indicates the database is a RAC DB. &#39;kSingleInstance&#39; indicates that the database is single instance.
        /// </summary>
        /// <value>Specifies the type of the database in Oracle Protection Source. &#39;kRACDatabase&#39; indicates the database is a RAC DB. &#39;kSingleInstance&#39; indicates that the database is single instance.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DbTypeEnum
        {
            /// <summary>
            /// Enum KSingleInstance for value: kSingleInstance
            /// </summary>
            [EnumMember(Value = "kSingleInstance")]
            KSingleInstance = 1,

            /// <summary>
            /// Enum KRACDatabase for value: kRACDatabase
            /// </summary>
            [EnumMember(Value = "kRACDatabase")]
            KRACDatabase = 2

        }

        /// <summary>
        /// Specifies the type of the database in Oracle Protection Source. &#39;kRACDatabase&#39; indicates the database is a RAC DB. &#39;kSingleInstance&#39; indicates that the database is single instance.
        /// </summary>
        /// <value>Specifies the type of the database in Oracle Protection Source. &#39;kRACDatabase&#39; indicates the database is a RAC DB. &#39;kSingleInstance&#39; indicates that the database is single instance.</value>
        [DataMember(Name="dbType", EmitDefaultValue=true)]
        public DbTypeEnum? DbType { get; set; }
        /// <summary>
        /// Specifies the type of the managed Object in Oracle Protection Source. &#39;kRACRootContainer&#39; indicates the entity is a root container to an Oracle Real Application clusters(Oracle RAC). &#39;kRootContainer&#39; indicates the entity is a root container to an Oracle standalone server. &#39;kHost&#39; indicates the entity is an Oracle host. &#39;kDatabase&#39; indicates the entity is an Oracle Database. &#39;kTableSpace&#39; indicates the entity is an Oracle table space. &#39;kTable&#39; indicates the entity is an Oracle table.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Oracle Protection Source. &#39;kRACRootContainer&#39; indicates the entity is a root container to an Oracle Real Application clusters(Oracle RAC). &#39;kRootContainer&#39; indicates the entity is a root container to an Oracle standalone server. &#39;kHost&#39; indicates the entity is an Oracle host. &#39;kDatabase&#39; indicates the entity is an Oracle Database. &#39;kTableSpace&#39; indicates the entity is an Oracle table space. &#39;kTable&#39; indicates the entity is an Oracle table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRACRootContainer for value: kRACRootContainer
            /// </summary>
            [EnumMember(Value = "kRACRootContainer")]
            KRACRootContainer = 1,

            /// <summary>
            /// Enum KRootContainer for value: kRootContainer
            /// </summary>
            [EnumMember(Value = "kRootContainer")]
            KRootContainer = 2,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 3,

            /// <summary>
            /// Enum KDatabase for value: kDatabase
            /// </summary>
            [EnumMember(Value = "kDatabase")]
            KDatabase = 4,

            /// <summary>
            /// Enum KTableSpace for value: kTableSpace
            /// </summary>
            [EnumMember(Value = "kTableSpace")]
            KTableSpace = 5,

            /// <summary>
            /// Enum KTable for value: kTable
            /// </summary>
            [EnumMember(Value = "kTable")]
            KTable = 6

        }

        /// <summary>
        /// Specifies the type of the managed Object in Oracle Protection Source. &#39;kRACRootContainer&#39; indicates the entity is a root container to an Oracle Real Application clusters(Oracle RAC). &#39;kRootContainer&#39; indicates the entity is a root container to an Oracle standalone server. &#39;kHost&#39; indicates the entity is an Oracle host. &#39;kDatabase&#39; indicates the entity is an Oracle Database. &#39;kTableSpace&#39; indicates the entity is an Oracle table space. &#39;kTable&#39; indicates the entity is an Oracle table.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Oracle Protection Source. &#39;kRACRootContainer&#39; indicates the entity is a root container to an Oracle Real Application clusters(Oracle RAC). &#39;kRootContainer&#39; indicates the entity is a root container to an Oracle standalone server. &#39;kHost&#39; indicates the entity is an Oracle host. &#39;kDatabase&#39; indicates the entity is an Oracle Database. &#39;kTableSpace&#39; indicates the entity is an Oracle table space. &#39;kTable&#39; indicates the entity is an Oracle table.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleProtectionSource" /> class.
        /// </summary>
        /// <param name="archiveLogEnabled">Specifies whether the database is running in ARCHIVELOG mode. It enables the redo of log files into archived redo log files..</param>
        /// <param name="bctEnabled">Specifies whether the Block Change Tracking is enabled. BCT improves the performance of incremental backups by recording changed blocks into the block change tracking file. RMAN then uses this file to identify changed blocks to be backed up..</param>
        /// <param name="containerDatabaseInfo">containerDatabaseInfo.</param>
        /// <param name="dataGuardInfo">dataGuardInfo.</param>
        /// <param name="databaseUniqueName">Specifies the unique name of the Oracle entity..</param>
        /// <param name="dbType">Specifies the type of the database in Oracle Protection Source. &#39;kRACDatabase&#39; indicates the database is a RAC DB. &#39;kSingleInstance&#39; indicates that the database is single instance..</param>
        /// <param name="domain">Specifies the Oracle DB Domain..</param>
        /// <param name="fraSize">Specifies Flash/Fast Recovery area size for the current DB entity..</param>
        /// <param name="hosts">Specifies the list of hosts for the current DB entity..</param>
        /// <param name="name">Specifies the instance name of the Oracle entity..</param>
        /// <param name="ownerId">Specifies the entity id of the owner entity (such as a VM). This is only set if type is kDatabase..</param>
        /// <param name="sgaTargetSize">Specifies System Global Area size for the current DB entity. A system global area (SGA) is a group of shared memory structures that contain data and control information for one Oracle database..</param>
        /// <param name="sharedPoolSize">Specifies Shared Pool Size for the current DB entity..</param>
        /// <param name="size">Specifies database size..</param>
        /// <param name="tdeEncryptedTsCount">Specifies the number of TDE encrypted tablespaces found in the database..</param>
        /// <param name="tempFilesCount">Specifies number of temporary files for the current DB entity..</param>
        /// <param name="type">Specifies the type of the managed Object in Oracle Protection Source. &#39;kRACRootContainer&#39; indicates the entity is a root container to an Oracle Real Application clusters(Oracle RAC). &#39;kRootContainer&#39; indicates the entity is a root container to an Oracle standalone server. &#39;kHost&#39; indicates the entity is an Oracle host. &#39;kDatabase&#39; indicates the entity is an Oracle Database. &#39;kTableSpace&#39; indicates the entity is an Oracle table space. &#39;kTable&#39; indicates the entity is an Oracle table..</param>
        /// <param name="uuid">Specifies the UUID for the Oracle entity..</param>
        /// <param name="version">Specifies the Oracle database instance version..</param>
        public OracleProtectionSource(bool? archiveLogEnabled = default(bool?), bool? bctEnabled = default(bool?), OracleContainerDatabaseInfo containerDatabaseInfo = default(OracleContainerDatabaseInfo), OracleDataGuardInfo dataGuardInfo = default(OracleDataGuardInfo), string databaseUniqueName = default(string), DbTypeEnum? dbType = default(DbTypeEnum?), string domain = default(string), long? fraSize = default(long?), List<OracleHost> hosts = default(List<OracleHost>), string name = default(string), long? ownerId = default(long?), string sgaTargetSize = default(string), string sharedPoolSize = default(string), long? size = default(long?), long? tdeEncryptedTsCount = default(long?), long? tempFilesCount = default(long?), TypeEnum? type = default(TypeEnum?), string uuid = default(string), string version = default(string))
        {
            this.ArchiveLogEnabled = archiveLogEnabled;
            this.BctEnabled = bctEnabled;
            this.ContainerDatabaseInfo = containerDatabaseInfo;
            this.DataGuardInfo = dataGuardInfo;
            this.DatabaseUniqueName = databaseUniqueName;
            this.DbType = dbType;
            this.Domain = domain;
            this.FraSize = fraSize;
            this.Hosts = hosts;
            this.Name = name;
            this.OwnerId = ownerId;
            this.SgaTargetSize = sgaTargetSize;
            this.SharedPoolSize = sharedPoolSize;
            this.Size = size;
            this.TdeEncryptedTsCount = tdeEncryptedTsCount;
            this.TempFilesCount = tempFilesCount;
            this.Type = type;
            this.Uuid = uuid;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies whether the database is running in ARCHIVELOG mode. It enables the redo of log files into archived redo log files.
        /// </summary>
        /// <value>Specifies whether the database is running in ARCHIVELOG mode. It enables the redo of log files into archived redo log files.</value>
        [DataMember(Name="archiveLogEnabled", EmitDefaultValue=true)]
        public bool? ArchiveLogEnabled { get; set; }

        /// <summary>
        /// Specifies whether the Block Change Tracking is enabled. BCT improves the performance of incremental backups by recording changed blocks into the block change tracking file. RMAN then uses this file to identify changed blocks to be backed up.
        /// </summary>
        /// <value>Specifies whether the Block Change Tracking is enabled. BCT improves the performance of incremental backups by recording changed blocks into the block change tracking file. RMAN then uses this file to identify changed blocks to be backed up.</value>
        [DataMember(Name="bctEnabled", EmitDefaultValue=true)]
        public bool? BctEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ContainerDatabaseInfo
        /// </summary>
        [DataMember(Name="containerDatabaseInfo", EmitDefaultValue=false)]
        public OracleContainerDatabaseInfo ContainerDatabaseInfo { get; set; }

        /// <summary>
        /// Gets or Sets DataGuardInfo
        /// </summary>
        [DataMember(Name="dataGuardInfo", EmitDefaultValue=false)]
        public OracleDataGuardInfo DataGuardInfo { get; set; }

        /// <summary>
        /// Specifies the unique name of the Oracle entity.
        /// </summary>
        /// <value>Specifies the unique name of the Oracle entity.</value>
        [DataMember(Name="databaseUniqueName", EmitDefaultValue=true)]
        public string DatabaseUniqueName { get; set; }

        /// <summary>
        /// Specifies the Oracle DB Domain.
        /// </summary>
        /// <value>Specifies the Oracle DB Domain.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies Flash/Fast Recovery area size for the current DB entity.
        /// </summary>
        /// <value>Specifies Flash/Fast Recovery area size for the current DB entity.</value>
        [DataMember(Name="fraSize", EmitDefaultValue=true)]
        public long? FraSize { get; set; }

        /// <summary>
        /// Specifies the list of hosts for the current DB entity.
        /// </summary>
        /// <value>Specifies the list of hosts for the current DB entity.</value>
        [DataMember(Name="hosts", EmitDefaultValue=true)]
        public List<OracleHost> Hosts { get; set; }

        /// <summary>
        /// Specifies the instance name of the Oracle entity.
        /// </summary>
        /// <value>Specifies the instance name of the Oracle entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the entity id of the owner entity (such as a VM). This is only set if type is kDatabase.
        /// </summary>
        /// <value>Specifies the entity id of the owner entity (such as a VM). This is only set if type is kDatabase.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies System Global Area size for the current DB entity. A system global area (SGA) is a group of shared memory structures that contain data and control information for one Oracle database.
        /// </summary>
        /// <value>Specifies System Global Area size for the current DB entity. A system global area (SGA) is a group of shared memory structures that contain data and control information for one Oracle database.</value>
        [DataMember(Name="sgaTargetSize", EmitDefaultValue=true)]
        public string SgaTargetSize { get; set; }

        /// <summary>
        /// Specifies Shared Pool Size for the current DB entity.
        /// </summary>
        /// <value>Specifies Shared Pool Size for the current DB entity.</value>
        [DataMember(Name="sharedPoolSize", EmitDefaultValue=true)]
        public string SharedPoolSize { get; set; }

        /// <summary>
        /// Specifies database size.
        /// </summary>
        /// <value>Specifies database size.</value>
        [DataMember(Name="size", EmitDefaultValue=true)]
        public long? Size { get; set; }

        /// <summary>
        /// Specifies the number of TDE encrypted tablespaces found in the database.
        /// </summary>
        /// <value>Specifies the number of TDE encrypted tablespaces found in the database.</value>
        [DataMember(Name="tdeEncryptedTsCount", EmitDefaultValue=true)]
        public long? TdeEncryptedTsCount { get; set; }

        /// <summary>
        /// Specifies number of temporary files for the current DB entity.
        /// </summary>
        /// <value>Specifies number of temporary files for the current DB entity.</value>
        [DataMember(Name="tempFilesCount", EmitDefaultValue=true)]
        public long? TempFilesCount { get; set; }

        /// <summary>
        /// Specifies the UUID for the Oracle entity.
        /// </summary>
        /// <value>Specifies the UUID for the Oracle entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the Oracle database instance version.
        /// </summary>
        /// <value>Specifies the Oracle database instance version.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as OracleProtectionSource);
        }

        /// <summary>
        /// Returns true if OracleProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveLogEnabled == input.ArchiveLogEnabled ||
                    (this.ArchiveLogEnabled != null &&
                    this.ArchiveLogEnabled.Equals(input.ArchiveLogEnabled))
                ) && 
                (
                    this.BctEnabled == input.BctEnabled ||
                    (this.BctEnabled != null &&
                    this.BctEnabled.Equals(input.BctEnabled))
                ) && 
                (
                    this.ContainerDatabaseInfo == input.ContainerDatabaseInfo ||
                    (this.ContainerDatabaseInfo != null &&
                    this.ContainerDatabaseInfo.Equals(input.ContainerDatabaseInfo))
                ) && 
                (
                    this.DataGuardInfo == input.DataGuardInfo ||
                    (this.DataGuardInfo != null &&
                    this.DataGuardInfo.Equals(input.DataGuardInfo))
                ) && 
                (
                    this.DatabaseUniqueName == input.DatabaseUniqueName ||
                    (this.DatabaseUniqueName != null &&
                    this.DatabaseUniqueName.Equals(input.DatabaseUniqueName))
                ) && 
                (
                    this.DbType == input.DbType ||
                    this.DbType.Equals(input.DbType)
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.FraSize == input.FraSize ||
                    (this.FraSize != null &&
                    this.FraSize.Equals(input.FraSize))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.Equals(input.Hosts)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.SgaTargetSize == input.SgaTargetSize ||
                    (this.SgaTargetSize != null &&
                    this.SgaTargetSize.Equals(input.SgaTargetSize))
                ) && 
                (
                    this.SharedPoolSize == input.SharedPoolSize ||
                    (this.SharedPoolSize != null &&
                    this.SharedPoolSize.Equals(input.SharedPoolSize))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.TdeEncryptedTsCount == input.TdeEncryptedTsCount ||
                    (this.TdeEncryptedTsCount != null &&
                    this.TdeEncryptedTsCount.Equals(input.TdeEncryptedTsCount))
                ) && 
                (
                    this.TempFilesCount == input.TempFilesCount ||
                    (this.TempFilesCount != null &&
                    this.TempFilesCount.Equals(input.TempFilesCount))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ArchiveLogEnabled != null)
                    hashCode = hashCode * 59 + this.ArchiveLogEnabled.GetHashCode();
                if (this.BctEnabled != null)
                    hashCode = hashCode * 59 + this.BctEnabled.GetHashCode();
                if (this.ContainerDatabaseInfo != null)
                    hashCode = hashCode * 59 + this.ContainerDatabaseInfo.GetHashCode();
                if (this.DataGuardInfo != null)
                    hashCode = hashCode * 59 + this.DataGuardInfo.GetHashCode();
                if (this.DatabaseUniqueName != null)
                    hashCode = hashCode * 59 + this.DatabaseUniqueName.GetHashCode();
                if (this.DbType != null)
					hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.FraSize != null)
                    hashCode = hashCode * 59 + this.FraSize.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.SgaTargetSize != null)
                    hashCode = hashCode * 59 + this.SgaTargetSize.GetHashCode();
                if (this.SharedPoolSize != null)
                    hashCode = hashCode * 59 + this.SharedPoolSize.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TdeEncryptedTsCount != null)
                    hashCode = hashCode * 59 + this.TdeEncryptedTsCount.GetHashCode();
                if (this.TempFilesCount != null)
                    hashCode = hashCode * 59 + this.TempFilesCount.GetHashCode();
                if (this.Type != null)
					hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

