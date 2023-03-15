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
    /// This proto captures the oracle database configuration for alternate DB restore.
    /// </summary>
    [DataContract]
    public partial class OracleDBConfig :  IEquatable<OracleDBConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDBConfig" /> class.
        /// </summary>
        /// <param name="auditLogDest">Audit log destination..</param>
        /// <param name="bctFilePath">BCT file path..</param>
        /// <param name="controlFilePathVec">List of paths where the control file needs to be multiplexed..</param>
        /// <param name="dbConfigFilePath">Path to the file on oracle host which decides the configuration of restored DB..</param>
        /// <param name="diagDest">Diag destination..</param>
        /// <param name="enableArchiveLogMode">If set to false, archive log mode is disabled..</param>
        /// <param name="fraDest">FRA path..</param>
        /// <param name="fraSizeMb">FRA Size in MBs..</param>
        /// <param name="numTempfiles">How many tempfiles to use for the recovered database..</param>
        /// <param name="pfileParameterMap">Map of pfile parameters to its values..</param>
        /// <param name="redoLogConf">redoLogConf.</param>
        /// <param name="sgaTargetSize">SGA_TARGET_SIZE size [ Default value same as Source DB ]..</param>
        /// <param name="sharedPoolSize">Shared pool size [ Default value same as Source DB ]..</param>
        public OracleDBConfig(string auditLogDest = default(string), string bctFilePath = default(string), List<string> controlFilePathVec = default(List<string>), string dbConfigFilePath = default(string), string diagDest = default(string), bool? enableArchiveLogMode = default(bool?), string fraDest = default(string), int? fraSizeMb = default(int?), int? numTempfiles = default(int?), List<OracleDBConfigPfileParameterMapEntry> pfileParameterMap = default(List<OracleDBConfigPfileParameterMapEntry>), OracleDBConfigRedoLogGroupConf redoLogConf = default(OracleDBConfigRedoLogGroupConf), string sgaTargetSize = default(string), string sharedPoolSize = default(string))
        {
            this.AuditLogDest = auditLogDest;
            this.BctFilePath = bctFilePath;
            this.ControlFilePathVec = controlFilePathVec;
            this.DbConfigFilePath = dbConfigFilePath;
            this.DiagDest = diagDest;
            this.EnableArchiveLogMode = enableArchiveLogMode;
            this.FraDest = fraDest;
            this.FraSizeMb = fraSizeMb;
            this.NumTempfiles = numTempfiles;
            this.PfileParameterMap = pfileParameterMap;
            this.SgaTargetSize = sgaTargetSize;
            this.SharedPoolSize = sharedPoolSize;
            this.AuditLogDest = auditLogDest;
            this.BctFilePath = bctFilePath;
            this.ControlFilePathVec = controlFilePathVec;
            this.DbConfigFilePath = dbConfigFilePath;
            this.DiagDest = diagDest;
            this.EnableArchiveLogMode = enableArchiveLogMode;
            this.FraDest = fraDest;
            this.FraSizeMb = fraSizeMb;
            this.NumTempfiles = numTempfiles;
            this.PfileParameterMap = pfileParameterMap;
            this.RedoLogConf = redoLogConf;
            this.SgaTargetSize = sgaTargetSize;
            this.SharedPoolSize = sharedPoolSize;
        }
        
        /// <summary>
        /// Audit log destination.
        /// </summary>
        /// <value>Audit log destination.</value>
        [DataMember(Name="auditLogDest", EmitDefaultValue=true)]
        public string AuditLogDest { get; set; }

        /// <summary>
        /// BCT file path.
        /// </summary>
        /// <value>BCT file path.</value>
        [DataMember(Name="bctFilePath", EmitDefaultValue=true)]
        public string BctFilePath { get; set; }

        /// <summary>
        /// List of paths where the control file needs to be multiplexed.
        /// </summary>
        /// <value>List of paths where the control file needs to be multiplexed.</value>
        [DataMember(Name="controlFilePathVec", EmitDefaultValue=true)]
        public List<string> ControlFilePathVec { get; set; }

        /// <summary>
        /// Path to the file on oracle host which decides the configuration of restored DB.
        /// </summary>
        /// <value>Path to the file on oracle host which decides the configuration of restored DB.</value>
        [DataMember(Name="dbConfigFilePath", EmitDefaultValue=true)]
        public string DbConfigFilePath { get; set; }

        /// <summary>
        /// Diag destination.
        /// </summary>
        /// <value>Diag destination.</value>
        [DataMember(Name="diagDest", EmitDefaultValue=true)]
        public string DiagDest { get; set; }

        /// <summary>
        /// If set to false, archive log mode is disabled.
        /// </summary>
        /// <value>If set to false, archive log mode is disabled.</value>
        [DataMember(Name="enableArchiveLogMode", EmitDefaultValue=true)]
        public bool? EnableArchiveLogMode { get; set; }

        /// <summary>
        /// FRA path.
        /// </summary>
        /// <value>FRA path.</value>
        [DataMember(Name="fraDest", EmitDefaultValue=true)]
        public string FraDest { get; set; }

        /// <summary>
        /// FRA Size in MBs.
        /// </summary>
        /// <value>FRA Size in MBs.</value>
        [DataMember(Name="fraSizeMb", EmitDefaultValue=true)]
        public int? FraSizeMb { get; set; }

        /// <summary>
        /// How many tempfiles to use for the recovered database.
        /// </summary>
        /// <value>How many tempfiles to use for the recovered database.</value>
        [DataMember(Name="numTempfiles", EmitDefaultValue=true)]
        public int? NumTempfiles { get; set; }

        /// <summary>
        /// Map of pfile parameters to its values.
        /// </summary>
        /// <value>Map of pfile parameters to its values.</value>
        [DataMember(Name="pfileParameterMap", EmitDefaultValue=true)]
        public List<OracleDBConfigPfileParameterMapEntry> PfileParameterMap { get; set; }

        /// <summary>
        /// Gets or Sets RedoLogConf
        /// </summary>
        [DataMember(Name="redoLogConf", EmitDefaultValue=false)]
        public OracleDBConfigRedoLogGroupConf RedoLogConf { get; set; }

        /// <summary>
        /// SGA_TARGET_SIZE size [ Default value same as Source DB ].
        /// </summary>
        /// <value>SGA_TARGET_SIZE size [ Default value same as Source DB ].</value>
        [DataMember(Name="sgaTargetSize", EmitDefaultValue=true)]
        public string SgaTargetSize { get; set; }

        /// <summary>
        /// Shared pool size [ Default value same as Source DB ].
        /// </summary>
        /// <value>Shared pool size [ Default value same as Source DB ].</value>
        [DataMember(Name="sharedPoolSize", EmitDefaultValue=true)]
        public string SharedPoolSize { get; set; }

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
            return this.Equals(input as OracleDBConfig);
        }

        /// <summary>
        /// Returns true if OracleDBConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDBConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDBConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuditLogDest == input.AuditLogDest ||
                    (this.AuditLogDest != null &&
                    this.AuditLogDest.Equals(input.AuditLogDest))
                ) && 
                (
                    this.BctFilePath == input.BctFilePath ||
                    (this.BctFilePath != null &&
                    this.BctFilePath.Equals(input.BctFilePath))
                ) && 
                (
                    this.ControlFilePathVec == input.ControlFilePathVec ||
                    this.ControlFilePathVec != null &&
                    input.ControlFilePathVec != null &&
                    this.ControlFilePathVec.SequenceEqual(input.ControlFilePathVec)
                ) && 
                (
                    this.DbConfigFilePath == input.DbConfigFilePath ||
                    (this.DbConfigFilePath != null &&
                    this.DbConfigFilePath.Equals(input.DbConfigFilePath))
                ) && 
                (
                    this.DiagDest == input.DiagDest ||
                    (this.DiagDest != null &&
                    this.DiagDest.Equals(input.DiagDest))
                ) && 
                (
                    this.EnableArchiveLogMode == input.EnableArchiveLogMode ||
                    (this.EnableArchiveLogMode != null &&
                    this.EnableArchiveLogMode.Equals(input.EnableArchiveLogMode))
                ) && 
                (
                    this.FraDest == input.FraDest ||
                    (this.FraDest != null &&
                    this.FraDest.Equals(input.FraDest))
                ) && 
                (
                    this.FraSizeMb == input.FraSizeMb ||
                    (this.FraSizeMb != null &&
                    this.FraSizeMb.Equals(input.FraSizeMb))
                ) && 
                (
                    this.NumTempfiles == input.NumTempfiles ||
                    (this.NumTempfiles != null &&
                    this.NumTempfiles.Equals(input.NumTempfiles))
                ) && 
                (
                    this.PfileParameterMap == input.PfileParameterMap ||
                    this.PfileParameterMap != null &&
                    input.PfileParameterMap != null &&
                    this.PfileParameterMap.SequenceEqual(input.PfileParameterMap)
                ) && 
                (
                    this.RedoLogConf == input.RedoLogConf ||
                    (this.RedoLogConf != null &&
                    this.RedoLogConf.Equals(input.RedoLogConf))
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
                if (this.AuditLogDest != null)
                    hashCode = hashCode * 59 + this.AuditLogDest.GetHashCode();
                if (this.BctFilePath != null)
                    hashCode = hashCode * 59 + this.BctFilePath.GetHashCode();
                if (this.ControlFilePathVec != null)
                    hashCode = hashCode * 59 + this.ControlFilePathVec.GetHashCode();
                if (this.DbConfigFilePath != null)
                    hashCode = hashCode * 59 + this.DbConfigFilePath.GetHashCode();
                if (this.DiagDest != null)
                    hashCode = hashCode * 59 + this.DiagDest.GetHashCode();
                if (this.EnableArchiveLogMode != null)
                    hashCode = hashCode * 59 + this.EnableArchiveLogMode.GetHashCode();
                if (this.FraDest != null)
                    hashCode = hashCode * 59 + this.FraDest.GetHashCode();
                if (this.FraSizeMb != null)
                    hashCode = hashCode * 59 + this.FraSizeMb.GetHashCode();
                if (this.NumTempfiles != null)
                    hashCode = hashCode * 59 + this.NumTempfiles.GetHashCode();
                if (this.PfileParameterMap != null)
                    hashCode = hashCode * 59 + this.PfileParameterMap.GetHashCode();
                if (this.RedoLogConf != null)
                    hashCode = hashCode * 59 + this.RedoLogConf.GetHashCode();
                if (this.SgaTargetSize != null)
                    hashCode = hashCode * 59 + this.SgaTargetSize.GetHashCode();
                if (this.SharedPoolSize != null)
                    hashCode = hashCode * 59 + this.SharedPoolSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

