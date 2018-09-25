// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies an Object representing one SQL Server instance or database.
    /// </summary>
    [DataContract]
    public partial class SqlProtectionSource :  IEquatable<SqlProtectionSource>
    {
        /// <summary>
        /// Specifies the Recovery Model for the database in SQL environment. Only meaningful for the &#39;kDatabase&#39; SQL Protection Source. Specifies the Recovery Model set for the Microsoft SQL Server. &#39;kSimpleRecoveryModel&#39; indicates the Simple SQL Recovery Model which does not utilize log backups. &#39;kFullRecoveryModel&#39; indicates the Full SQL Recovery Model which requires log backups and allows recovery to a single point in time. &#39;kBulkLoggedRecoveryModel&#39; indicates the Bulk Logged SQL Recovery Model which requires log backups and allows high-performance bulk copy operations.
        /// </summary>
        /// <value>Specifies the Recovery Model for the database in SQL environment. Only meaningful for the &#39;kDatabase&#39; SQL Protection Source. Specifies the Recovery Model set for the Microsoft SQL Server. &#39;kSimpleRecoveryModel&#39; indicates the Simple SQL Recovery Model which does not utilize log backups. &#39;kFullRecoveryModel&#39; indicates the Full SQL Recovery Model which requires log backups and allows recovery to a single point in time. &#39;kBulkLoggedRecoveryModel&#39; indicates the Bulk Logged SQL Recovery Model which requires log backups and allows high-performance bulk copy operations.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecoveryModelEnum
        {
            
            /// <summary>
            /// Enum KSimpleRecoveryModel for value: kSimpleRecoveryModel
            /// </summary>
            [EnumMember(Value = "kSimpleRecoveryModel")]
            KSimpleRecoveryModel = 1,
            
            /// <summary>
            /// Enum KFullRecoveryModel for value: kFullRecoveryModel
            /// </summary>
            [EnumMember(Value = "kFullRecoveryModel")]
            KFullRecoveryModel = 2,
            
            /// <summary>
            /// Enum KBulkLoggedRecoveryModel for value: kBulkLoggedRecoveryModel
            /// </summary>
            [EnumMember(Value = "kBulkLoggedRecoveryModel")]
            KBulkLoggedRecoveryModel = 3
        }

        /// <summary>
        /// Specifies the Recovery Model for the database in SQL environment. Only meaningful for the &#39;kDatabase&#39; SQL Protection Source. Specifies the Recovery Model set for the Microsoft SQL Server. &#39;kSimpleRecoveryModel&#39; indicates the Simple SQL Recovery Model which does not utilize log backups. &#39;kFullRecoveryModel&#39; indicates the Full SQL Recovery Model which requires log backups and allows recovery to a single point in time. &#39;kBulkLoggedRecoveryModel&#39; indicates the Bulk Logged SQL Recovery Model which requires log backups and allows high-performance bulk copy operations.
        /// </summary>
        /// <value>Specifies the Recovery Model for the database in SQL environment. Only meaningful for the &#39;kDatabase&#39; SQL Protection Source. Specifies the Recovery Model set for the Microsoft SQL Server. &#39;kSimpleRecoveryModel&#39; indicates the Simple SQL Recovery Model which does not utilize log backups. &#39;kFullRecoveryModel&#39; indicates the Full SQL Recovery Model which requires log backups and allows recovery to a single point in time. &#39;kBulkLoggedRecoveryModel&#39; indicates the Bulk Logged SQL Recovery Model which requires log backups and allows high-performance bulk copy operations.</value>
        [DataMember(Name="recoveryModel", EmitDefaultValue=false)]
        public RecoveryModelEnum? RecoveryModel { get; set; }
        /// <summary>
        /// Specifies the type of the managed Object in a SQL Protection Source. Examples of SQL Objects include &#39;kInstance&#39; and &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies the type of the managed Object in a SQL Protection Source. Examples of SQL Objects include &#39;kInstance&#39; and &#39;kDatabase&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KInstance for value: kInstance
            /// </summary>
            [EnumMember(Value = "kInstance")]
            KInstance = 1,
            
            /// <summary>
            /// Enum KDatabase for value: kDatabase
            /// </summary>
            [EnumMember(Value = "kDatabase")]
            KDatabase = 2
        }

        /// <summary>
        /// Specifies the type of the managed Object in a SQL Protection Source. Examples of SQL Objects include &#39;kInstance&#39; and &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies the type of the managed Object in a SQL Protection Source. Examples of SQL Objects include &#39;kInstance&#39; and &#39;kDatabase&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlProtectionSource" /> class.
        /// </summary>
        /// <param name="isAvailableForVssBackup">Specifies whether the database is marked as available for backup according to the SQL Server VSS writer. This may be false if either the state of the databases is not online, or if the VSS writer is not online. This field is set only for type &#39;kDatabase&#39;..</param>
        /// <param name="createdTimestamp">Specifies the time when the database was created. It is displayed in the timezone of the SQL server on which this database is running..</param>
        /// <param name="databaseName">Specifies the database name of the SQL Protection Source, if the type is database..</param>
        /// <param name="dbAagEntityId">Specifies the AAG entity id if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;..</param>
        /// <param name="dbAagName">Specifies the name of the AAG if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;..</param>
        /// <param name="dbFiles">Specifies the last known information about the set of database files on the host. This field is set only for type &#39;kDatabase&#39;..</param>
        /// <param name="id">Specifies an id that identifies an SQL Object..</param>
        /// <param name="name">Specifies the instance name of the SQL Protection Source.</param>
        /// <param name="ownerId">Specifies the id of the container VM for the SQL Protection Source..</param>
        /// <param name="recoveryModel">Specifies the Recovery Model for the database in SQL environment. Only meaningful for the &#39;kDatabase&#39; SQL Protection Source. Specifies the Recovery Model set for the Microsoft SQL Server. &#39;kSimpleRecoveryModel&#39; indicates the Simple SQL Recovery Model which does not utilize log backups. &#39;kFullRecoveryModel&#39; indicates the Full SQL Recovery Model which requires log backups and allows recovery to a single point in time. &#39;kBulkLoggedRecoveryModel&#39; indicates the Bulk Logged SQL Recovery Model which requires log backups and allows high-performance bulk copy operations..</param>
        /// <param name="sqlServerDbState">The state of the database as returned by SQL Server..</param>
        /// <param name="type">Specifies the type of the managed Object in a SQL Protection Source. Examples of SQL Objects include &#39;kInstance&#39; and &#39;kDatabase&#39;..</param>
        public SqlProtectionSource(bool? isAvailableForVssBackup = default(bool?), string createdTimestamp = default(string), string databaseName = default(string), long? dbAagEntityId = default(long?), string dbAagName = default(string), List<DbFileInfo> dbFiles = default(List<DbFileInfo>), SqlSourceId id = default(SqlSourceId), string name = default(string), long? ownerId = default(long?), RecoveryModelEnum? recoveryModel = default(RecoveryModelEnum?), int? sqlServerDbState = default(int?), TypeEnum? type = default(TypeEnum?))
        {
            this.IsAvailableForVssBackup = isAvailableForVssBackup;
            this.CreatedTimestamp = createdTimestamp;
            this.DatabaseName = databaseName;
            this.DbAagEntityId = dbAagEntityId;
            this.DbAagName = dbAagName;
            this.DbFiles = dbFiles;
            this.Id = id;
            this.Name = name;
            this.OwnerId = ownerId;
            this.RecoveryModel = recoveryModel;
            this.SqlServerDbState = sqlServerDbState;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies whether the database is marked as available for backup according to the SQL Server VSS writer. This may be false if either the state of the databases is not online, or if the VSS writer is not online. This field is set only for type &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies whether the database is marked as available for backup according to the SQL Server VSS writer. This may be false if either the state of the databases is not online, or if the VSS writer is not online. This field is set only for type &#39;kDatabase&#39;.</value>
        [DataMember(Name="IsAvailableForVssBackup", EmitDefaultValue=false)]
        public bool? IsAvailableForVssBackup { get; set; }

        /// <summary>
        /// Specifies the time when the database was created. It is displayed in the timezone of the SQL server on which this database is running.
        /// </summary>
        /// <value>Specifies the time when the database was created. It is displayed in the timezone of the SQL server on which this database is running.</value>
        [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
        public string CreatedTimestamp { get; set; }

        /// <summary>
        /// Specifies the database name of the SQL Protection Source, if the type is database.
        /// </summary>
        /// <value>Specifies the database name of the SQL Protection Source, if the type is database.</value>
        [DataMember(Name="databaseName", EmitDefaultValue=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Specifies the AAG entity id if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies the AAG entity id if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;.</value>
        [DataMember(Name="dbAagEntityId", EmitDefaultValue=false)]
        public long? DbAagEntityId { get; set; }

        /// <summary>
        /// Specifies the name of the AAG if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies the name of the AAG if the database is part of an AAG. This field is set only for type &#39;kDatabase&#39;.</value>
        [DataMember(Name="dbAagName", EmitDefaultValue=false)]
        public string DbAagName { get; set; }

        /// <summary>
        /// Specifies the last known information about the set of database files on the host. This field is set only for type &#39;kDatabase&#39;.
        /// </summary>
        /// <value>Specifies the last known information about the set of database files on the host. This field is set only for type &#39;kDatabase&#39;.</value>
        [DataMember(Name="dbFiles", EmitDefaultValue=false)]
        public List<DbFileInfo> DbFiles { get; set; }

        /// <summary>
        /// Specifies an id that identifies an SQL Object.
        /// </summary>
        /// <value>Specifies an id that identifies an SQL Object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public SqlSourceId Id { get; set; }

        /// <summary>
        /// Specifies the instance name of the SQL Protection Source
        /// </summary>
        /// <value>Specifies the instance name of the SQL Protection Source</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the id of the container VM for the SQL Protection Source.
        /// </summary>
        /// <value>Specifies the id of the container VM for the SQL Protection Source.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public long? OwnerId { get; set; }


        /// <summary>
        /// The state of the database as returned by SQL Server.
        /// </summary>
        /// <value>The state of the database as returned by SQL Server.</value>
        [DataMember(Name="sqlServerDbState", EmitDefaultValue=false)]
        public int? SqlServerDbState { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as SqlProtectionSource);
        }

        /// <summary>
        /// Returns true if SqlProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAvailableForVssBackup == input.IsAvailableForVssBackup ||
                    (this.IsAvailableForVssBackup != null &&
                    this.IsAvailableForVssBackup.Equals(input.IsAvailableForVssBackup))
                ) && 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    (this.CreatedTimestamp != null &&
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp))
                ) && 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.DbAagEntityId == input.DbAagEntityId ||
                    (this.DbAagEntityId != null &&
                    this.DbAagEntityId.Equals(input.DbAagEntityId))
                ) && 
                (
                    this.DbAagName == input.DbAagName ||
                    (this.DbAagName != null &&
                    this.DbAagName.Equals(input.DbAagName))
                ) && 
                (
                    this.DbFiles == input.DbFiles ||
                    this.DbFiles != null &&
                    this.DbFiles.SequenceEqual(input.DbFiles)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.RecoveryModel == input.RecoveryModel ||
                    (this.RecoveryModel != null &&
                    this.RecoveryModel.Equals(input.RecoveryModel))
                ) && 
                (
                    this.SqlServerDbState == input.SqlServerDbState ||
                    (this.SqlServerDbState != null &&
                    this.SqlServerDbState.Equals(input.SqlServerDbState))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IsAvailableForVssBackup != null)
                    hashCode = hashCode * 59 + this.IsAvailableForVssBackup.GetHashCode();
                if (this.CreatedTimestamp != null)
                    hashCode = hashCode * 59 + this.CreatedTimestamp.GetHashCode();
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.DbAagEntityId != null)
                    hashCode = hashCode * 59 + this.DbAagEntityId.GetHashCode();
                if (this.DbAagName != null)
                    hashCode = hashCode * 59 + this.DbAagName.GetHashCode();
                if (this.DbFiles != null)
                    hashCode = hashCode * 59 + this.DbFiles.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.RecoveryModel != null)
                    hashCode = hashCode * 59 + this.RecoveryModel.GetHashCode();
                if (this.SqlServerDbState != null)
                    hashCode = hashCode * 59 + this.SqlServerDbState.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

