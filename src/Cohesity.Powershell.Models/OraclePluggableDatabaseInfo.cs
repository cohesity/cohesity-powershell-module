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
    /// Specifies the informatiomn about the pluggable database. A Pluggabele Database(PDB) is a portable collection of schemas, schema objects, and nonschema objects that appears to an Oracle Net client as a non-CDB.
    /// </summary>
    [DataContract]
    public partial class OraclePluggableDatabaseInfo :  IEquatable<OraclePluggableDatabaseInfo>
    {
        /// <summary>
        /// Specifies the OPEN_MODE information. Specifies the OPEN_MODE type for the Oracle database. &#39;kMounted&#39; indicates that the database is open in Mounted mode. &#39;kReadWrite&#39; indicates that the database is open in R/W mode. &#39;kReadOnly&#39; indicates that the database is open in ReadOnly mode. &#39;kMigrate&#39; inidcates that the database is open in Migrate mode.
        /// </summary>
        /// <value>Specifies the OPEN_MODE information. Specifies the OPEN_MODE type for the Oracle database. &#39;kMounted&#39; indicates that the database is open in Mounted mode. &#39;kReadWrite&#39; indicates that the database is open in R/W mode. &#39;kReadOnly&#39; indicates that the database is open in ReadOnly mode. &#39;kMigrate&#39; inidcates that the database is open in Migrate mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpenModeEnum
        {
            /// <summary>
            /// Enum KMounted for value: kMounted
            /// </summary>
            [EnumMember(Value = "kMounted")]
            KMounted = 1,

            /// <summary>
            /// Enum KReadWrite for value: kReadWrite
            /// </summary>
            [EnumMember(Value = "kReadWrite")]
            KReadWrite = 2,

            /// <summary>
            /// Enum KReadOnly for value: kReadOnly
            /// </summary>
            [EnumMember(Value = "kReadOnly")]
            KReadOnly = 3,

            /// <summary>
            /// Enum KMigrate for value: kMigrate
            /// </summary>
            [EnumMember(Value = "kMigrate")]
            KMigrate = 4

        }

        /// <summary>
        /// Specifies the OPEN_MODE information. Specifies the OPEN_MODE type for the Oracle database. &#39;kMounted&#39; indicates that the database is open in Mounted mode. &#39;kReadWrite&#39; indicates that the database is open in R/W mode. &#39;kReadOnly&#39; indicates that the database is open in ReadOnly mode. &#39;kMigrate&#39; inidcates that the database is open in Migrate mode.
        /// </summary>
        /// <value>Specifies the OPEN_MODE information. Specifies the OPEN_MODE type for the Oracle database. &#39;kMounted&#39; indicates that the database is open in Mounted mode. &#39;kReadWrite&#39; indicates that the database is open in R/W mode. &#39;kReadOnly&#39; indicates that the database is open in ReadOnly mode. &#39;kMigrate&#39; inidcates that the database is open in Migrate mode.</value>
        [DataMember(Name="openMode", EmitDefaultValue=true)]
        public OpenModeEnum? OpenMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OraclePluggableDatabaseInfo" /> class.
        /// </summary>
        /// <param name="databaseId">Specifies the ID of the Pluggable Database..</param>
        /// <param name="name">Speicifes the name of the Pluggable Database..</param>
        /// <param name="openMode">Specifies the OPEN_MODE information. Specifies the OPEN_MODE type for the Oracle database. &#39;kMounted&#39; indicates that the database is open in Mounted mode. &#39;kReadWrite&#39; indicates that the database is open in R/W mode. &#39;kReadOnly&#39; indicates that the database is open in ReadOnly mode. &#39;kMigrate&#39; inidcates that the database is open in Migrate mode..</param>
        /// <param name="sizeBytes">Specifies the Size in Bytes of the Pluggable Database..</param>
        public OraclePluggableDatabaseInfo(string databaseId = default(string), string name = default(string), OpenModeEnum? openMode = default(OpenModeEnum?), long? sizeBytes = default(long?))
        {
            this.DatabaseId = databaseId;
            this.Name = name;
            this.OpenMode = openMode;
            this.SizeBytes = sizeBytes;
            this.DatabaseId = databaseId;
            this.Name = name;
            this.OpenMode = openMode;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Specifies the ID of the Pluggable Database.
        /// </summary>
        /// <value>Specifies the ID of the Pluggable Database.</value>
        [DataMember(Name="databaseId", EmitDefaultValue=true)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// Speicifes the name of the Pluggable Database.
        /// </summary>
        /// <value>Speicifes the name of the Pluggable Database.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the Size in Bytes of the Pluggable Database.
        /// </summary>
        /// <value>Specifies the Size in Bytes of the Pluggable Database.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as OraclePluggableDatabaseInfo);
        }

        /// <summary>
        /// Returns true if OraclePluggableDatabaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OraclePluggableDatabaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OraclePluggableDatabaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseId == input.DatabaseId ||
                    (this.DatabaseId != null &&
                    this.DatabaseId.Equals(input.DatabaseId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenMode == input.OpenMode ||
                    this.OpenMode.Equals(input.OpenMode)
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                if (this.DatabaseId != null)
                    hashCode = hashCode * 59 + this.DatabaseId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.OpenMode.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

