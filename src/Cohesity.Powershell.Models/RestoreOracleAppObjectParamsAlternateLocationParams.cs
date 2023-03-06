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
    /// For restoring to alternate location this message can not be empty and all the fields inside the message also can not be empty.
    /// </summary>
    [DataContract]
    public partial class RestoreOracleAppObjectParamsAlternateLocationParams :  IEquatable<RestoreOracleAppObjectParamsAlternateLocationParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOracleAppObjectParamsAlternateLocationParams" /> class.
        /// </summary>
        /// <param name="baseDir">Base directory of Oracle at destination. Example : /u01/app/oracle.</param>
        /// <param name="databaseFileDestination">Location to put the database files(datafiles, logfiles etc.)..</param>
        /// <param name="homeDir">Home directory of Oracle at destination. Example : /u01/app/oracle/product/11.2.0.3/db_1.</param>
        /// <param name="newDatabaseName">The name of the Oracle database that we restore to..</param>
        /// <param name="newSidDeprecated">Deprecated field SID of new Oracle database..</param>
        /// <param name="newnameClause">SET NEWNAME clause user can specified. This allows user to have full control on how their database files can be renamed during the alternate restore workflow..</param>
        /// <param name="nofilenamecheck">NOFILENAMECHECK option for RMAN Duplicate Database command.</param>
        /// <param name="oracleDbConfig">oracleDbConfig.</param>
        public RestoreOracleAppObjectParamsAlternateLocationParams(string baseDir = default(string), string databaseFileDestination = default(string), string homeDir = default(string), string newDatabaseName = default(string), string newSidDeprecated = default(string), string newnameClause = default(string), bool? nofilenamecheck = default(bool?), OracleDBConfig oracleDbConfig = default(OracleDBConfig))
        {
            this.BaseDir = baseDir;
            this.DatabaseFileDestination = databaseFileDestination;
            this.HomeDir = homeDir;
            this.NewDatabaseName = newDatabaseName;
            this.NewSidDeprecated = newSidDeprecated;
            this.NewnameClause = newnameClause;
            this.Nofilenamecheck = nofilenamecheck;
            this.BaseDir = baseDir;
            this.DatabaseFileDestination = databaseFileDestination;
            this.HomeDir = homeDir;
            this.NewDatabaseName = newDatabaseName;
            this.NewSidDeprecated = newSidDeprecated;
            this.NewnameClause = newnameClause;
            this.Nofilenamecheck = nofilenamecheck;
            this.OracleDbConfig = oracleDbConfig;
        }
        
        /// <summary>
        /// Base directory of Oracle at destination. Example : /u01/app/oracle
        /// </summary>
        /// <value>Base directory of Oracle at destination. Example : /u01/app/oracle</value>
        [DataMember(Name="baseDir", EmitDefaultValue=true)]
        public string BaseDir { get; set; }

        /// <summary>
        /// Location to put the database files(datafiles, logfiles etc.).
        /// </summary>
        /// <value>Location to put the database files(datafiles, logfiles etc.).</value>
        [DataMember(Name="databaseFileDestination", EmitDefaultValue=true)]
        public string DatabaseFileDestination { get; set; }

        /// <summary>
        /// Home directory of Oracle at destination. Example : /u01/app/oracle/product/11.2.0.3/db_1
        /// </summary>
        /// <value>Home directory of Oracle at destination. Example : /u01/app/oracle/product/11.2.0.3/db_1</value>
        [DataMember(Name="homeDir", EmitDefaultValue=true)]
        public string HomeDir { get; set; }

        /// <summary>
        /// The name of the Oracle database that we restore to.
        /// </summary>
        /// <value>The name of the Oracle database that we restore to.</value>
        [DataMember(Name="newDatabaseName", EmitDefaultValue=true)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// Deprecated field SID of new Oracle database.
        /// </summary>
        /// <value>Deprecated field SID of new Oracle database.</value>
        [DataMember(Name="newSidDeprecated", EmitDefaultValue=true)]
        public string NewSidDeprecated { get; set; }

        /// <summary>
        /// SET NEWNAME clause user can specified. This allows user to have full control on how their database files can be renamed during the alternate restore workflow.
        /// </summary>
        /// <value>SET NEWNAME clause user can specified. This allows user to have full control on how their database files can be renamed during the alternate restore workflow.</value>
        [DataMember(Name="newnameClause", EmitDefaultValue=true)]
        public string NewnameClause { get; set; }

        /// <summary>
        /// NOFILENAMECHECK option for RMAN Duplicate Database command
        /// </summary>
        /// <value>NOFILENAMECHECK option for RMAN Duplicate Database command</value>
        [DataMember(Name="nofilenamecheck", EmitDefaultValue=true)]
        public bool? Nofilenamecheck { get; set; }

        /// <summary>
        /// Gets or Sets OracleDbConfig
        /// </summary>
        [DataMember(Name="oracleDbConfig", EmitDefaultValue=false)]
        public OracleDBConfig OracleDbConfig { get; set; }

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
            return this.Equals(input as RestoreOracleAppObjectParamsAlternateLocationParams);
        }

        /// <summary>
        /// Returns true if RestoreOracleAppObjectParamsAlternateLocationParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOracleAppObjectParamsAlternateLocationParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOracleAppObjectParamsAlternateLocationParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseDir == input.BaseDir ||
                    (this.BaseDir != null &&
                    this.BaseDir.Equals(input.BaseDir))
                ) && 
                (
                    this.DatabaseFileDestination == input.DatabaseFileDestination ||
                    (this.DatabaseFileDestination != null &&
                    this.DatabaseFileDestination.Equals(input.DatabaseFileDestination))
                ) && 
                (
                    this.HomeDir == input.HomeDir ||
                    (this.HomeDir != null &&
                    this.HomeDir.Equals(input.HomeDir))
                ) && 
                (
                    this.NewDatabaseName == input.NewDatabaseName ||
                    (this.NewDatabaseName != null &&
                    this.NewDatabaseName.Equals(input.NewDatabaseName))
                ) && 
                (
                    this.NewSidDeprecated == input.NewSidDeprecated ||
                    (this.NewSidDeprecated != null &&
                    this.NewSidDeprecated.Equals(input.NewSidDeprecated))
                ) && 
                (
                    this.NewnameClause == input.NewnameClause ||
                    (this.NewnameClause != null &&
                    this.NewnameClause.Equals(input.NewnameClause))
                ) && 
                (
                    this.Nofilenamecheck == input.Nofilenamecheck ||
                    (this.Nofilenamecheck != null &&
                    this.Nofilenamecheck.Equals(input.Nofilenamecheck))
                ) && 
                (
                    this.OracleDbConfig == input.OracleDbConfig ||
                    (this.OracleDbConfig != null &&
                    this.OracleDbConfig.Equals(input.OracleDbConfig))
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
                if (this.BaseDir != null)
                    hashCode = hashCode * 59 + this.BaseDir.GetHashCode();
                if (this.DatabaseFileDestination != null)
                    hashCode = hashCode * 59 + this.DatabaseFileDestination.GetHashCode();
                if (this.HomeDir != null)
                    hashCode = hashCode * 59 + this.HomeDir.GetHashCode();
                if (this.NewDatabaseName != null)
                    hashCode = hashCode * 59 + this.NewDatabaseName.GetHashCode();
                if (this.NewSidDeprecated != null)
                    hashCode = hashCode * 59 + this.NewSidDeprecated.GetHashCode();
                if (this.NewnameClause != null)
                    hashCode = hashCode * 59 + this.NewnameClause.GetHashCode();
                if (this.Nofilenamecheck != null)
                    hashCode = hashCode * 59 + this.Nofilenamecheck.GetHashCode();
                if (this.OracleDbConfig != null)
                    hashCode = hashCode * 59 + this.OracleDbConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

