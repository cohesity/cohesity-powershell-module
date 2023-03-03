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
        /// <param name="acropolisBackupJobParams">acropolisBackupJobParams.</param>
        /// <param name="awsNativeEnvParams">awsNativeEnvParams.</param>
        /// <param name="exchangeBackupJobParams">exchangeBackupJobParams.</param>
        /// <param name="externallyTriggeredJobParams">externallyTriggeredJobParams.</param>
        /// <param name="fileStubbingParams">fileStubbingParams.</param>
        /// <param name="fileUptieringParams">fileUptieringParams.</param>
        /// <param name="hypervBackupParams">hypervBackupParams.</param>
        /// <param name="isilonEnvParams">isilonEnvParams.</param>
        /// <param name="kubernetesEnvParams">kubernetesEnvParams.</param>
        /// <param name="nasAnalysisJobParams">nasAnalysisJobParams.</param>
        /// <param name="nasBackupParams">nasBackupParams.</param>
        /// <param name="nosqlBackupJobParams">nosqlBackupJobParams.</param>
        /// <param name="o365BackupParams">o365BackupParams.</param>
        /// <param name="oracleBackupJobParams">oracleBackupJobParams.</param>
        /// <param name="outlookBackupParams">outlookBackupParams.</param>
        /// <param name="physicalBackupParams">physicalBackupParams.</param>
        /// <param name="sfdcBackupJobParams">sfdcBackupJobParams.</param>
        /// <param name="snapshotManagerParams">snapshotManagerParams.</param>
        /// <param name="sqlBackupJobParams">sqlBackupJobParams.</param>
        /// <param name="udaBackupJobParams">udaBackupJobParams.</param>
        /// <param name="vmwareBackupParams">vmwareBackupParams.</param>
        public EnvBackupParams(AcropolisBackupJobParams acropolisBackupJobParams = default(AcropolisBackupJobParams), AWSNativeEnvParams awsNativeEnvParams = default(AWSNativeEnvParams), ExchangeBackupJobParams exchangeBackupJobParams = default(ExchangeBackupJobParams), ExternallyTriggeredJobParams externallyTriggeredJobParams = default(ExternallyTriggeredJobParams), FileStubbingParams fileStubbingParams = default(FileStubbingParams), FileUptieringParams fileUptieringParams = default(FileUptieringParams), HyperVBackupEnvParams hypervBackupParams = default(HyperVBackupEnvParams), IsilonEnvParams isilonEnvParams = default(IsilonEnvParams), KubernetesEnvParams kubernetesEnvParams = default(KubernetesEnvParams), NasAnalysisJobParams nasAnalysisJobParams = default(NasAnalysisJobParams), NasBackupParams nasBackupParams = default(NasBackupParams), NoSqlBackupJobParams nosqlBackupJobParams = default(NoSqlBackupJobParams), O365BackupEnvParams o365BackupParams = default(O365BackupEnvParams), OracleBackupJobParams oracleBackupJobParams = default(OracleBackupJobParams), OutlookBackupEnvParams outlookBackupParams = default(OutlookBackupEnvParams), PhysicalBackupEnvParams physicalBackupParams = default(PhysicalBackupEnvParams), SfdcBackupJobParams sfdcBackupJobParams = default(SfdcBackupJobParams), SnapshotManagerParams snapshotManagerParams = default(SnapshotManagerParams), SqlBackupJobParams sqlBackupJobParams = default(SqlBackupJobParams), UdaBackupJobParams udaBackupJobParams = default(UdaBackupJobParams), VMwareBackupEnvParams vmwareBackupParams = default(VMwareBackupEnvParams))
        {
            this.AcropolisBackupJobParams = acropolisBackupJobParams;
            this.AwsNativeEnvParams = awsNativeEnvParams;
            this.ExchangeBackupJobParams = exchangeBackupJobParams;
            this.ExternallyTriggeredJobParams = externallyTriggeredJobParams;
            this.FileStubbingParams = fileStubbingParams;
            this.FileUptieringParams = fileUptieringParams;
            this.HypervBackupParams = hypervBackupParams;
            this.IsilonEnvParams = isilonEnvParams;
            this.KubernetesEnvParams = kubernetesEnvParams;
            this.NasAnalysisJobParams = nasAnalysisJobParams;
            this.NasBackupParams = nasBackupParams;
            this.NosqlBackupJobParams = nosqlBackupJobParams;
            this.O365BackupParams = o365BackupParams;
            this.OracleBackupJobParams = oracleBackupJobParams;
            this.OutlookBackupParams = outlookBackupParams;
            this.PhysicalBackupParams = physicalBackupParams;
            this.SfdcBackupJobParams = sfdcBackupJobParams;
            this.SnapshotManagerParams = snapshotManagerParams;
            this.SqlBackupJobParams = sqlBackupJobParams;
            this.UdaBackupJobParams = udaBackupJobParams;
            this.VmwareBackupParams = vmwareBackupParams;
        }
        
        /// <summary>
        /// Gets or Sets AcropolisBackupJobParams
        /// </summary>
        [DataMember(Name="acropolisBackupJobParams", EmitDefaultValue=false)]
        public AcropolisBackupJobParams AcropolisBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets AwsNativeEnvParams
        /// </summary>
        [DataMember(Name="awsNativeEnvParams", EmitDefaultValue=false)]
        public AWSNativeEnvParams AwsNativeEnvParams { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeBackupJobParams
        /// </summary>
        [DataMember(Name="exchangeBackupJobParams", EmitDefaultValue=false)]
        public ExchangeBackupJobParams ExchangeBackupJobParams { get; set; }

        /// <summary>
        /// Gets or Sets ExternallyTriggeredJobParams
        /// </summary>
        [DataMember(Name="externallyTriggeredJobParams", EmitDefaultValue=false)]
        public ExternallyTriggeredJobParams ExternallyTriggeredJobParams { get; set; }

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
        /// Gets or Sets IsilonEnvParams
        /// </summary>
        [DataMember(Name="isilonEnvParams", EmitDefaultValue=false)]
        public IsilonEnvParams IsilonEnvParams { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesEnvParams
        /// </summary>
        [DataMember(Name="kubernetesEnvParams", EmitDefaultValue=false)]
        public KubernetesEnvParams KubernetesEnvParams { get; set; }

        /// <summary>
        /// Gets or Sets NasAnalysisJobParams
        /// </summary>
        [DataMember(Name="nasAnalysisJobParams", EmitDefaultValue=false)]
        public NasAnalysisJobParams NasAnalysisJobParams { get; set; }

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
        /// Gets or Sets SfdcBackupJobParams
        /// </summary>
        [DataMember(Name="sfdcBackupJobParams", EmitDefaultValue=false)]
        public SfdcBackupJobParams SfdcBackupJobParams { get; set; }

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
        /// Gets or Sets UdaBackupJobParams
        /// </summary>
        [DataMember(Name="udaBackupJobParams", EmitDefaultValue=false)]
        public UdaBackupJobParams UdaBackupJobParams { get; set; }

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
                    this.AcropolisBackupJobParams == input.AcropolisBackupJobParams ||
                    (this.AcropolisBackupJobParams != null &&
                    this.AcropolisBackupJobParams.Equals(input.AcropolisBackupJobParams))
                ) && 
                (
                    this.AwsNativeEnvParams == input.AwsNativeEnvParams ||
                    (this.AwsNativeEnvParams != null &&
                    this.AwsNativeEnvParams.Equals(input.AwsNativeEnvParams))
                ) && 
                (
                    this.ExchangeBackupJobParams == input.ExchangeBackupJobParams ||
                    (this.ExchangeBackupJobParams != null &&
                    this.ExchangeBackupJobParams.Equals(input.ExchangeBackupJobParams))
                ) && 
                (
                    this.ExternallyTriggeredJobParams == input.ExternallyTriggeredJobParams ||
                    (this.ExternallyTriggeredJobParams != null &&
                    this.ExternallyTriggeredJobParams.Equals(input.ExternallyTriggeredJobParams))
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
                    this.IsilonEnvParams == input.IsilonEnvParams ||
                    (this.IsilonEnvParams != null &&
                    this.IsilonEnvParams.Equals(input.IsilonEnvParams))
                ) && 
                (
                    this.KubernetesEnvParams == input.KubernetesEnvParams ||
                    (this.KubernetesEnvParams != null &&
                    this.KubernetesEnvParams.Equals(input.KubernetesEnvParams))
                ) && 
                (
                    this.NasAnalysisJobParams == input.NasAnalysisJobParams ||
                    (this.NasAnalysisJobParams != null &&
                    this.NasAnalysisJobParams.Equals(input.NasAnalysisJobParams))
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
                    this.SfdcBackupJobParams == input.SfdcBackupJobParams ||
                    (this.SfdcBackupJobParams != null &&
                    this.SfdcBackupJobParams.Equals(input.SfdcBackupJobParams))
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
                    this.UdaBackupJobParams == input.UdaBackupJobParams ||
                    (this.UdaBackupJobParams != null &&
                    this.UdaBackupJobParams.Equals(input.UdaBackupJobParams))
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
                if (this.AcropolisBackupJobParams != null)
                    hashCode = hashCode * 59 + this.AcropolisBackupJobParams.GetHashCode();
                if (this.AwsNativeEnvParams != null)
                    hashCode = hashCode * 59 + this.AwsNativeEnvParams.GetHashCode();
                if (this.ExchangeBackupJobParams != null)
                    hashCode = hashCode * 59 + this.ExchangeBackupJobParams.GetHashCode();
                if (this.ExternallyTriggeredJobParams != null)
                    hashCode = hashCode * 59 + this.ExternallyTriggeredJobParams.GetHashCode();
                if (this.FileStubbingParams != null)
                    hashCode = hashCode * 59 + this.FileStubbingParams.GetHashCode();
                if (this.FileUptieringParams != null)
                    hashCode = hashCode * 59 + this.FileUptieringParams.GetHashCode();
                if (this.HypervBackupParams != null)
                    hashCode = hashCode * 59 + this.HypervBackupParams.GetHashCode();
                if (this.IsilonEnvParams != null)
                    hashCode = hashCode * 59 + this.IsilonEnvParams.GetHashCode();
                if (this.KubernetesEnvParams != null)
                    hashCode = hashCode * 59 + this.KubernetesEnvParams.GetHashCode();
                if (this.NasAnalysisJobParams != null)
                    hashCode = hashCode * 59 + this.NasAnalysisJobParams.GetHashCode();
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
                if (this.SfdcBackupJobParams != null)
                    hashCode = hashCode * 59 + this.SfdcBackupJobParams.GetHashCode();
                if (this.SnapshotManagerParams != null)
                    hashCode = hashCode * 59 + this.SnapshotManagerParams.GetHashCode();
                if (this.SqlBackupJobParams != null)
                    hashCode = hashCode * 59 + this.SqlBackupJobParams.GetHashCode();
                if (this.UdaBackupJobParams != null)
                    hashCode = hashCode * 59 + this.UdaBackupJobParams.GetHashCode();
                if (this.VmwareBackupParams != null)
                    hashCode = hashCode * 59 + this.VmwareBackupParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

