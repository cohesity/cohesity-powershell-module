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
    /// Specifies information about the Database in Oracle DataGuard configuration. Data GUard provides a comprehensive set of services that create, maintain, and monitor one or more standby databases to enable production Oracle databases to survive disasters and data corruptions. Data Guard maintains these standby databases as transactionally consistent copies of the production databases.
    /// </summary>
    [DataContract]
    public partial class OracleDataGuardInfo :  IEquatable<OracleDataGuardInfo>
    {
        /// <summary>
        /// Specifies the role of the DataGuard database. Specifies the role of the DataGuard database.  A Data Guard configuration contains one production database, also referred to as the primary database, that functions in the primary role. The primary database can be either a single-instance Oracle database or an Oracle Real Application Clusters database.  A standby database is a transactionally consistent copy of the primary database. Similar to a primary database, a standby database can be either a single-instance Oracle database or an Oracle Real Application Clusters database. &#39;kPrimary&#39; indicates that the current database is primary database. &#39;kStandby&#39; indicates that the current database is standby database.
        /// </summary>
        /// <value>Specifies the role of the DataGuard database. Specifies the role of the DataGuard database.  A Data Guard configuration contains one production database, also referred to as the primary database, that functions in the primary role. The primary database can be either a single-instance Oracle database or an Oracle Real Application Clusters database.  A standby database is a transactionally consistent copy of the primary database. Similar to a primary database, a standby database can be either a single-instance Oracle database or an Oracle Real Application Clusters database. &#39;kPrimary&#39; indicates that the current database is primary database. &#39;kStandby&#39; indicates that the current database is standby database.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum KPrimary for value: kPrimary
            /// </summary>
            [EnumMember(Value = "kPrimary")]
            KPrimary = 1,

            /// <summary>
            /// Enum KStandby for value: kStandby
            /// </summary>
            [EnumMember(Value = "kStandby")]
            KStandby = 2

        }

        /// <summary>
        /// Specifies the role of the DataGuard database. Specifies the role of the DataGuard database.  A Data Guard configuration contains one production database, also referred to as the primary database, that functions in the primary role. The primary database can be either a single-instance Oracle database or an Oracle Real Application Clusters database.  A standby database is a transactionally consistent copy of the primary database. Similar to a primary database, a standby database can be either a single-instance Oracle database or an Oracle Real Application Clusters database. &#39;kPrimary&#39; indicates that the current database is primary database. &#39;kStandby&#39; indicates that the current database is standby database.
        /// </summary>
        /// <value>Specifies the role of the DataGuard database. Specifies the role of the DataGuard database.  A Data Guard configuration contains one production database, also referred to as the primary database, that functions in the primary role. The primary database can be either a single-instance Oracle database or an Oracle Real Application Clusters database.  A standby database is a transactionally consistent copy of the primary database. Similar to a primary database, a standby database can be either a single-instance Oracle database or an Oracle Real Application Clusters database. &#39;kPrimary&#39; indicates that the current database is primary database. &#39;kStandby&#39; indicates that the current database is standby database.</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Specifies the type of standby database. Specifies the type of standby database. &#39;kPhysical&#39; indicates that the current database provides a physically identical copy of the primary database, with on disk structures identical to the primary database on a block-for-block basis. It is kept synchronized with the primary database, though Redo Apply, which recovers the redo data received from the primary database and applies the redo to the physical standby database. &#39;kLogical&#39; indicates that the current database provides the same logical information as the production database, although the physical structure can be different. It is kept synchronized with the primary database thorugh SQL Apply, which transforms the data in the redo received from the primary database into SQL statements and then executing the SQL statements on the standby database. &#39;kSnapshot&#39; indicates that the current database is a fully updateable standby created by converting a physical standby database into a snasphot standby database. It receives and archives but does not apply redo data from a primary database.
        /// </summary>
        /// <value>Specifies the type of standby database. Specifies the type of standby database. &#39;kPhysical&#39; indicates that the current database provides a physically identical copy of the primary database, with on disk structures identical to the primary database on a block-for-block basis. It is kept synchronized with the primary database, though Redo Apply, which recovers the redo data received from the primary database and applies the redo to the physical standby database. &#39;kLogical&#39; indicates that the current database provides the same logical information as the production database, although the physical structure can be different. It is kept synchronized with the primary database thorugh SQL Apply, which transforms the data in the redo received from the primary database into SQL statements and then executing the SQL statements on the standby database. &#39;kSnapshot&#39; indicates that the current database is a fully updateable standby created by converting a physical standby database into a snasphot standby database. It receives and archives but does not apply redo data from a primary database.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 1,

            /// <summary>
            /// Enum KLogical for value: kLogical
            /// </summary>
            [EnumMember(Value = "kLogical")]
            KLogical = 2,

            /// <summary>
            /// Enum KSnapshot for value: kSnapshot
            /// </summary>
            [EnumMember(Value = "kSnapshot")]
            KSnapshot = 3

        }

        /// <summary>
        /// Specifies the type of standby database. Specifies the type of standby database. &#39;kPhysical&#39; indicates that the current database provides a physically identical copy of the primary database, with on disk structures identical to the primary database on a block-for-block basis. It is kept synchronized with the primary database, though Redo Apply, which recovers the redo data received from the primary database and applies the redo to the physical standby database. &#39;kLogical&#39; indicates that the current database provides the same logical information as the production database, although the physical structure can be different. It is kept synchronized with the primary database thorugh SQL Apply, which transforms the data in the redo received from the primary database into SQL statements and then executing the SQL statements on the standby database. &#39;kSnapshot&#39; indicates that the current database is a fully updateable standby created by converting a physical standby database into a snasphot standby database. It receives and archives but does not apply redo data from a primary database.
        /// </summary>
        /// <value>Specifies the type of standby database. Specifies the type of standby database. &#39;kPhysical&#39; indicates that the current database provides a physically identical copy of the primary database, with on disk structures identical to the primary database on a block-for-block basis. It is kept synchronized with the primary database, though Redo Apply, which recovers the redo data received from the primary database and applies the redo to the physical standby database. &#39;kLogical&#39; indicates that the current database provides the same logical information as the production database, although the physical structure can be different. It is kept synchronized with the primary database thorugh SQL Apply, which transforms the data in the redo received from the primary database into SQL statements and then executing the SQL statements on the standby database. &#39;kSnapshot&#39; indicates that the current database is a fully updateable standby created by converting a physical standby database into a snasphot standby database. It receives and archives but does not apply redo data from a primary database.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDataGuardInfo" /> class.
        /// </summary>
        /// <param name="role">Specifies the role of the DataGuard database. Specifies the role of the DataGuard database.  A Data Guard configuration contains one production database, also referred to as the primary database, that functions in the primary role. The primary database can be either a single-instance Oracle database or an Oracle Real Application Clusters database.  A standby database is a transactionally consistent copy of the primary database. Similar to a primary database, a standby database can be either a single-instance Oracle database or an Oracle Real Application Clusters database. &#39;kPrimary&#39; indicates that the current database is primary database. &#39;kStandby&#39; indicates that the current database is standby database..</param>
        /// <param name="type">Specifies the type of standby database. Specifies the type of standby database. &#39;kPhysical&#39; indicates that the current database provides a physically identical copy of the primary database, with on disk structures identical to the primary database on a block-for-block basis. It is kept synchronized with the primary database, though Redo Apply, which recovers the redo data received from the primary database and applies the redo to the physical standby database. &#39;kLogical&#39; indicates that the current database provides the same logical information as the production database, although the physical structure can be different. It is kept synchronized with the primary database thorugh SQL Apply, which transforms the data in the redo received from the primary database into SQL statements and then executing the SQL statements on the standby database. &#39;kSnapshot&#39; indicates that the current database is a fully updateable standby created by converting a physical standby database into a snasphot standby database. It receives and archives but does not apply redo data from a primary database..</param>
        public OracleDataGuardInfo(RoleEnum? role = default(RoleEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.Role = role;
            this.Type = type;
            this.Role = role;
            this.Type = type;
        }
        
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
            return this.Equals(input as OracleDataGuardInfo);
        }

        /// <summary>
        /// Returns true if OracleDataGuardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDataGuardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDataGuardInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

