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
    /// Specifies the information about the Exchange Database.
    /// </summary>
    [DataContract]
    public partial class ExchangeDatabaseInfo :  IEquatable<ExchangeDatabaseInfo>
    {
        /// <summary>
        /// Specifies the state of the Exchange database copy. Specifies the state of Exchange Database Copy.   &#39;kUnknown&#39; indicates the status is not known. &#39;kMounted&#39; indicates the exchange database copy is mounted and healthy. &#39;kError&#39; indicates  the  exchange  database  copy  is unmounted or partially mounted or is in error state.
        /// </summary>
        /// <value>Specifies the state of the Exchange database copy. Specifies the state of Exchange Database Copy.   &#39;kUnknown&#39; indicates the status is not known. &#39;kMounted&#39; indicates the exchange database copy is mounted and healthy. &#39;kError&#39; indicates  the  exchange  database  copy  is unmounted or partially mounted or is in error state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DatabaseStateEnum
        {
            /// <summary>
            /// Enum KUnknown for value: kUnknown
            /// </summary>
            [EnumMember(Value = "kUnknown")]
            KUnknown = 1,

            /// <summary>
            /// Enum KMounted for value: kMounted
            /// </summary>
            [EnumMember(Value = "kMounted")]
            KMounted = 2,

            /// <summary>
            /// Enum KError for value: kError
            /// </summary>
            [EnumMember(Value = "kError")]
            KError = 3

        }

        /// <summary>
        /// Specifies the state of the Exchange database copy. Specifies the state of Exchange Database Copy.   &#39;kUnknown&#39; indicates the status is not known. &#39;kMounted&#39; indicates the exchange database copy is mounted and healthy. &#39;kError&#39; indicates  the  exchange  database  copy  is unmounted or partially mounted or is in error state.
        /// </summary>
        /// <value>Specifies the state of the Exchange database copy. Specifies the state of Exchange Database Copy.   &#39;kUnknown&#39; indicates the status is not known. &#39;kMounted&#39; indicates the exchange database copy is mounted and healthy. &#39;kError&#39; indicates  the  exchange  database  copy  is unmounted or partially mounted or is in error state.</value>
        [DataMember(Name="databaseState", EmitDefaultValue=true)]
        public DatabaseStateEnum? DatabaseState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeDatabaseInfo" /> class.
        /// </summary>
        /// <param name="appServerId">Specifies the entity id of the Exchange Application Server which has this database copy..</param>
        /// <param name="backupSupported">Specifies if backup is supported for the Exchange database copy..</param>
        /// <param name="backupUnsupportedReasons">Specifies any reason(s) for Exchange database backup not supported..</param>
        /// <param name="createdTimeMsecs">Specifies the time when the database is created in Unix epoch time in milliseconds..</param>
        /// <param name="databaseState">Specifies the state of the Exchange database copy. Specifies the state of Exchange Database Copy.   &#39;kUnknown&#39; indicates the status is not known. &#39;kMounted&#39; indicates the exchange database copy is mounted and healthy. &#39;kError&#39; indicates  the  exchange  database  copy  is unmounted or partially mounted or is in error state..</param>
        /// <param name="dbSizeBytes">Specifies the size of the Exchange database copy in bytes..</param>
        /// <param name="dbguid">Specifies the guid of the Exchange Database..</param>
        /// <param name="name">Specifes the name of the Exchange Database..</param>
        /// <param name="ownerId">Specifies the owner entity id of the Exchange Application Server which has this database copy..</param>
        /// <param name="utcOffsetMin">Specifies UTC time offset of database creation time..</param>
        public ExchangeDatabaseInfo(long? appServerId = default(long?), bool? backupSupported = default(bool?), List<string> backupUnsupportedReasons = default(List<string>), long? createdTimeMsecs = default(long?), DatabaseStateEnum? databaseState = default(DatabaseStateEnum?), long? dbSizeBytes = default(long?), string dbguid = default(string), string name = default(string), long? ownerId = default(long?), long? utcOffsetMin = default(long?))
        {
            this.AppServerId = appServerId;
            this.BackupSupported = backupSupported;
            this.BackupUnsupportedReasons = backupUnsupportedReasons;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.DatabaseState = databaseState;
            this.DbSizeBytes = dbSizeBytes;
            this.Dbguid = dbguid;
            this.Name = name;
            this.OwnerId = ownerId;
            this.UtcOffsetMin = utcOffsetMin;
            this.AppServerId = appServerId;
            this.BackupSupported = backupSupported;
            this.BackupUnsupportedReasons = backupUnsupportedReasons;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.DatabaseState = databaseState;
            this.DbSizeBytes = dbSizeBytes;
            this.Dbguid = dbguid;
            this.Name = name;
            this.OwnerId = ownerId;
            this.UtcOffsetMin = utcOffsetMin;
        }
        
        /// <summary>
        /// Specifies the entity id of the Exchange Application Server which has this database copy.
        /// </summary>
        /// <value>Specifies the entity id of the Exchange Application Server which has this database copy.</value>
        [DataMember(Name="appServerId", EmitDefaultValue=true)]
        public long? AppServerId { get; set; }

        /// <summary>
        /// Specifies if backup is supported for the Exchange database copy.
        /// </summary>
        /// <value>Specifies if backup is supported for the Exchange database copy.</value>
        [DataMember(Name="backupSupported", EmitDefaultValue=true)]
        public bool? BackupSupported { get; set; }

        /// <summary>
        /// Specifies any reason(s) for Exchange database backup not supported.
        /// </summary>
        /// <value>Specifies any reason(s) for Exchange database backup not supported.</value>
        [DataMember(Name="backupUnsupportedReasons", EmitDefaultValue=true)]
        public List<string> BackupUnsupportedReasons { get; set; }

        /// <summary>
        /// Specifies the time when the database is created in Unix epoch time in milliseconds.
        /// </summary>
        /// <value>Specifies the time when the database is created in Unix epoch time in milliseconds.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the size of the Exchange database copy in bytes.
        /// </summary>
        /// <value>Specifies the size of the Exchange database copy in bytes.</value>
        [DataMember(Name="dbSizeBytes", EmitDefaultValue=true)]
        public long? DbSizeBytes { get; set; }

        /// <summary>
        /// Specifies the guid of the Exchange Database.
        /// </summary>
        /// <value>Specifies the guid of the Exchange Database.</value>
        [DataMember(Name="dbguid", EmitDefaultValue=true)]
        public string Dbguid { get; set; }

        /// <summary>
        /// Specifes the name of the Exchange Database.
        /// </summary>
        /// <value>Specifes the name of the Exchange Database.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the owner entity id of the Exchange Application Server which has this database copy.
        /// </summary>
        /// <value>Specifies the owner entity id of the Exchange Application Server which has this database copy.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies UTC time offset of database creation time.
        /// </summary>
        /// <value>Specifies UTC time offset of database creation time.</value>
        [DataMember(Name="utcOffsetMin", EmitDefaultValue=true)]
        public long? UtcOffsetMin { get; set; }

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
            return this.Equals(input as ExchangeDatabaseInfo);
        }

        /// <summary>
        /// Returns true if ExchangeDatabaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeDatabaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeDatabaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppServerId == input.AppServerId ||
                    (this.AppServerId != null &&
                    this.AppServerId.Equals(input.AppServerId))
                ) && 
                (
                    this.BackupSupported == input.BackupSupported ||
                    (this.BackupSupported != null &&
                    this.BackupSupported.Equals(input.BackupSupported))
                ) && 
                (
                    this.BackupUnsupportedReasons == input.BackupUnsupportedReasons ||
                    this.BackupUnsupportedReasons != null &&
                    input.BackupUnsupportedReasons != null &&
                    this.BackupUnsupportedReasons.Equals(input.BackupUnsupportedReasons)
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.DatabaseState == input.DatabaseState ||
                    this.DatabaseState.Equals(input.DatabaseState)
                ) && 
                (
                    this.DbSizeBytes == input.DbSizeBytes ||
                    (this.DbSizeBytes != null &&
                    this.DbSizeBytes.Equals(input.DbSizeBytes))
                ) && 
                (
                    this.Dbguid == input.Dbguid ||
                    (this.Dbguid != null &&
                    this.Dbguid.Equals(input.Dbguid))
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
                    this.UtcOffsetMin == input.UtcOffsetMin ||
                    (this.UtcOffsetMin != null &&
                    this.UtcOffsetMin.Equals(input.UtcOffsetMin))
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
                if (this.AppServerId != null)
                    hashCode = hashCode * 59 + this.AppServerId.GetHashCode();
                if (this.BackupSupported != null)
                    hashCode = hashCode * 59 + this.BackupSupported.GetHashCode();
                if (this.BackupUnsupportedReasons != null)
                    hashCode = hashCode * 59 + this.BackupUnsupportedReasons.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.DatabaseState.GetHashCode();
                if (this.DbSizeBytes != null)
                    hashCode = hashCode * 59 + this.DbSizeBytes.GetHashCode();
                if (this.Dbguid != null)
                    hashCode = hashCode * 59 + this.Dbguid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.UtcOffsetMin != null)
                    hashCode = hashCode * 59 + this.UtcOffsetMin.GetHashCode();
                return hashCode;
            }
        }

    }

}

