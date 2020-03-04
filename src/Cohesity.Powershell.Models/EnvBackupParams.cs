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
    /// Message to capture any additional environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class EnvBackupParams :  IEquatable<EnvBackupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvBackupParams" /> class.
        /// </summary>
        /// <param name="exchangeBackupJobParams">exchangeBackupJobParams.</param>
        /// <param name="fileStubbingParams">fileStubbingParams.</param>
        /// <param name="fileUptieringParams">fileUptieringParams.</param>
        /// <param name="hypervBackupParams">hypervBackupParams.</param>
        /// <param name="nasBackupParams">nasBackupParams.</param>
        /// <param name="nosqlBackupJobParams">nosqlBackupJobParams.</param>
        /// <param name="o365BackupParams">o365BackupParams.</param>
        /// <param name="oracleBackupJobParams">oracleBackupJobParams.</param>
        /// <param name="outlookBackupParams">outlookBackupParams.</param>
        /// <param name="physicalBackupParams">physicalBackupParams.</param>
        /// <param name="snapshotManagerParams">snapshotManagerParams.</param>
        /// <param name="sqlBackupJobParams">sqlBackupJobParams.</param>
        /// <param name="vmwareBackupParams">vmwareBackupParams.</param>
        public EnvBackupParams(ExchangeBackupJobParams exchangeBackupJobParams = default(ExchangeBackupJobParams), FileStubbingParams fileStubbingParams = default(FileStubbingParams), FileUptieringParams fileUptieringParams = default(FileUptieringParams), HyperVBackupEnvParams hypervBackupParams = default(HyperVBackupEnvParams), NasBackupParams nasBackupParams = default(NasBackupParams), NoSqlBackupJobParams nosqlBackupJobParams = default(NoSqlBackupJobParams), O365BackupEnvParams o365BackupParams = default(O365BackupEnvParams), OracleBackupJobParams oracleBackupJobParams = default(OracleBackupJobParams), OutlookBackupEnvParams outlookBackupParams = default(OutlookBackupEnvParams), PhysicalBackupEnvParams physicalBackupParams = default(PhysicalBackupEnvParams), SnapshotManagerParams snapshotManagerParams = default(SnapshotManagerParams), SqlBackupJobParams sqlBackupJobParams = default(SqlBackupJobParams), VMwareBackupEnvParams vmwareBackupParams = default(VMwareBackupEnvParams))
        {
            this.ExchangeBackupJobParams = exchangeBackupJobParams;
            this.FileStubbingParams = fileStubbingParams;
            this.FileUptieringParams = fileUptieringParams;
            this.HypervBackupParams = hypervBackupParams;
            this.NasBackupParams = nasBackupParams;
            this.NosqlBackupJobParams = nosqlBackupJobParams;
            this.O365BackupParams = o365BackupParams;
            this.OracleBackupJobParams = oracleBackupJobParams;
            this.OutlookBackupParams = outlookBackupParams;
            this.PhysicalBackupParams = physicalBackupParams;
            this.SnapshotManagerParams = snapshotManagerParams;
            this.SqlBackupJobParams = sqlBackupJobParams;
            this.VmwareBackupParams = vmwareBackupParams;
        }
        
        /// <summary>
        /// Gets or Sets ExchangeBackupJobParams
        /// </summary>
        [DataMember(Name="exchangeBackupJobParams", EmitDefaultValue=false)]
        public ExchangeBackupJobParams ExchangeBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets FileStubbingParams
        /// </summary>
        [DataMember(Name="fileStubbingParams", EmitDefaultValue=false)]
        public FileStubbingParams FileStubbingParams { get; set; }

        /// <summary>
        /// Gets or Sets FileUptieringParams
        /// </summary>
        [DataMember(Name="fileUptieringParams", EmitDefaultValue=false)]
        public FileUptieringParams FileUptieringParams { get; set; }

        /// <summary>
        /// Gets or Sets HypervBackupParams
        /// </summary>
        [DataMember(Name="hypervBackupParams", EmitDefaultValue=false)]
        public HyperVBackupEnvParams HypervBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets NasBackupParams
        /// </summary>
        [DataMember(Name="nasBackupParams", EmitDefaultValue=false)]
        public NasBackupParams NasBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets NosqlBackupJobParams
        /// </summary>
        [DataMember(Name="nosqlBackupJobParams", EmitDefaultValue=false)]
        public NoSqlBackupJobParams NosqlBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets O365BackupParams
        /// </summary>
        [DataMember(Name="o365BackupParams", EmitDefaultValue=false)]
        public O365BackupEnvParams O365BackupParams { get; set; }

        /// <summary>
        /// Gets or Sets OracleBackupJobParams
        /// </summary>
        [DataMember(Name="oracleBackupJobParams", EmitDefaultValue=false)]
        public OracleBackupJobParams OracleBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets OutlookBackupParams
        /// </summary>
        [DataMember(Name="outlookBackupParams", EmitDefaultValue=false)]
        public OutlookBackupEnvParams OutlookBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalBackupParams
        /// </summary>
        [DataMember(Name="physicalBackupParams", EmitDefaultValue=false)]
        public PhysicalBackupEnvParams PhysicalBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotManagerParams
        /// </summary>
        [DataMember(Name="snapshotManagerParams", EmitDefaultValue=false)]
        public SnapshotManagerParams SnapshotManagerParams { get; set; }

        /// <summary>
        /// Gets or Sets SqlBackupJobParams
        /// </summary>
        [DataMember(Name="sqlBackupJobParams", EmitDefaultValue=false)]
        public SqlBackupJobParams SqlBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets VmwareBackupParams
        /// </summary>
        [DataMember(Name="vmwareBackupParams", EmitDefaultValue=false)]
        public VMwareBackupEnvParams VmwareBackupParams { get; set; }

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
            return this.Equals(input as EnvBackupParams);
        }

        /// <summary>
        /// Returns true if EnvBackupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvBackupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvBackupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExchangeBackupJobParams == input.ExchangeBackupJobParams ||
                    (this.ExchangeBackupJobParams != null &&
                    this.ExchangeBackupJobParams.Equals(input.ExchangeBackupJobParams))
                ) && 
                (
                    this.FileStubbingParams == input.FileStubbingParams ||
                    (this.FileStubbingParams != null &&
                    this.FileStubbingParams.Equals(input.FileStubbingParams))
                ) && 
                (
                    this.FileUptieringParams == input.FileUptieringParams ||
                    (this.FileUptieringParams != null &&
                    this.FileUptieringParams.Equals(input.FileUptieringParams))
                ) && 
                (
                    this.HypervBackupParams == input.HypervBackupParams ||
                    (this.HypervBackupParams != null &&
                    this.HypervBackupParams.Equals(input.HypervBackupParams))
                ) && 
                (
                    this.NasBackupParams == input.NasBackupParams ||
                    (this.NasBackupParams != null &&
                    this.NasBackupParams.Equals(input.NasBackupParams))
                ) && 
                (
                    this.NosqlBackupJobParams == input.NosqlBackupJobParams ||
                    (this.NosqlBackupJobParams != null &&
                    this.NosqlBackupJobParams.Equals(input.NosqlBackupJobParams))
                ) && 
                (
                    this.O365BackupParams == input.O365BackupParams ||
                    (this.O365BackupParams != null &&
                    this.O365BackupParams.Equals(input.O365BackupParams))
                ) && 
                (
                    this.OracleBackupJobParams == input.OracleBackupJobParams ||
                    (this.OracleBackupJobParams != null &&
                    this.OracleBackupJobParams.Equals(input.OracleBackupJobParams))
                ) && 
                (
                    this.OutlookBackupParams == input.OutlookBackupParams ||
                    (this.OutlookBackupParams != null &&
                    this.OutlookBackupParams.Equals(input.OutlookBackupParams))
                ) && 
                (
                    this.PhysicalBackupParams == input.PhysicalBackupParams ||
                    (this.PhysicalBackupParams != null &&
                    this.PhysicalBackupParams.Equals(input.PhysicalBackupParams))
                ) && 
                (
                    this.SnapshotManagerParams == input.SnapshotManagerParams ||
                    (this.SnapshotManagerParams != null &&
                    this.SnapshotManagerParams.Equals(input.SnapshotManagerParams))
                ) && 
                (
                    this.SqlBackupJobParams == input.SqlBackupJobParams ||
                    (this.SqlBackupJobParams != null &&
                    this.SqlBackupJobParams.Equals(input.SqlBackupJobParams))
                ) && 
                (
                    this.VmwareBackupParams == input.VmwareBackupParams ||
                    (this.VmwareBackupParams != null &&
                    this.VmwareBackupParams.Equals(input.VmwareBackupParams))
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
                if (this.ExchangeBackupJobParams != null)
                    hashCode = hashCode * 59 + this.ExchangeBackupJobParams.GetHashCode();
                if (this.FileStubbingParams != null)
                    hashCode = hashCode * 59 + this.FileStubbingParams.GetHashCode();
                if (this.FileUptieringParams != null)
                    hashCode = hashCode * 59 + this.FileUptieringParams.GetHashCode();
                if (this.HypervBackupParams != null)
                    hashCode = hashCode * 59 + this.HypervBackupParams.GetHashCode();
                if (this.NasBackupParams != null)
                    hashCode = hashCode * 59 + this.NasBackupParams.GetHashCode();
                if (this.NosqlBackupJobParams != null)
                    hashCode = hashCode * 59 + this.NosqlBackupJobParams.GetHashCode();
                if (this.O365BackupParams != null)
                    hashCode = hashCode * 59 + this.O365BackupParams.GetHashCode();
                if (this.OracleBackupJobParams != null)
                    hashCode = hashCode * 59 + this.OracleBackupJobParams.GetHashCode();
                if (this.OutlookBackupParams != null)
                    hashCode = hashCode * 59 + this.OutlookBackupParams.GetHashCode();
                if (this.PhysicalBackupParams != null)
                    hashCode = hashCode * 59 + this.PhysicalBackupParams.GetHashCode();
                if (this.SnapshotManagerParams != null)
                    hashCode = hashCode * 59 + this.SnapshotManagerParams.GetHashCode();
                if (this.SqlBackupJobParams != null)
                    hashCode = hashCode * 59 + this.SqlBackupJobParams.GetHashCode();
                if (this.VmwareBackupParams != null)
                    hashCode = hashCode * 59 + this.VmwareBackupParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

