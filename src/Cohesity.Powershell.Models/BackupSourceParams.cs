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
    /// Message to capture any additional backup params at the source level.
    /// </summary>
    [DataContract]
    public partial class BackupSourceParams :  IEquatable<BackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupSourceParams" /> class.
        /// </summary>
        /// <param name="appEntityIdVec">If we are backing up an application (such as SQL), this contains the entity ids of the app entities (such as SQL instances and databases) that will be protected on the backup source.  If this vector is empty, it implies that we are protecting all app entities on the source..</param>
        /// <param name="awsNativeParams">awsNativeParams.</param>
        /// <param name="awsSnapshotManagerParams">awsSnapshotManagerParams.</param>
        /// <param name="oracleParams">oracleParams.</param>
        /// <param name="physicalParams">physicalParams.</param>
        /// <param name="skipIndexing">Set to true, if indexing is not required for given source..</param>
        /// <param name="sourceId">Source entity id. NOTE: This is expected to point to a leaf-level entity..</param>
        /// <param name="vmwareParams">vmwareParams.</param>
        public BackupSourceParams(List<long?> appEntityIdVec = default(List<long?>), AWSNativeBackupSourceParams awsNativeParams = default(AWSNativeBackupSourceParams), AWSSnapshotManagerBackupSourceParams awsSnapshotManagerParams = default(AWSSnapshotManagerBackupSourceParams), OracleSourceParams oracleParams = default(OracleSourceParams), PhysicalBackupSourceParams physicalParams = default(PhysicalBackupSourceParams), bool? skipIndexing = default(bool?), long? sourceId = default(long?), VMwareBackupSourceParams vmwareParams = default(VMwareBackupSourceParams))
        {
            this.AppEntityIdVec = appEntityIdVec;
            this.AwsNativeParams = awsNativeParams;
            this.AwsSnapshotManagerParams = awsSnapshotManagerParams;
            this.OracleParams = oracleParams;
            this.PhysicalParams = physicalParams;
            this.SkipIndexing = skipIndexing;
            this.SourceId = sourceId;
            this.VmwareParams = vmwareParams;
        }
        
        /// <summary>
        /// If we are backing up an application (such as SQL), this contains the entity ids of the app entities (such as SQL instances and databases) that will be protected on the backup source.  If this vector is empty, it implies that we are protecting all app entities on the source.
        /// </summary>
        /// <value>If we are backing up an application (such as SQL), this contains the entity ids of the app entities (such as SQL instances and databases) that will be protected on the backup source.  If this vector is empty, it implies that we are protecting all app entities on the source.</value>
        [DataMember(Name="appEntityIdVec", EmitDefaultValue=false)]
        public List<long?> AppEntityIdVec { get; set; }

        /// <summary>
        /// Gets or Sets AwsNativeParams
        /// </summary>
        [DataMember(Name="awsNativeParams", EmitDefaultValue=false)]
        public AWSNativeBackupSourceParams AwsNativeParams { get; set; }

        /// <summary>
        /// Gets or Sets AwsSnapshotManagerParams
        /// </summary>
        [DataMember(Name="awsSnapshotManagerParams", EmitDefaultValue=false)]
        public AWSSnapshotManagerBackupSourceParams AwsSnapshotManagerParams { get; set; }

        /// <summary>
        /// Gets or Sets OracleParams
        /// </summary>
        [DataMember(Name="oracleParams", EmitDefaultValue=false)]
        public OracleSourceParams OracleParams { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalParams
        /// </summary>
        [DataMember(Name="physicalParams", EmitDefaultValue=false)]
        public PhysicalBackupSourceParams PhysicalParams { get; set; }

        /// <summary>
        /// Set to true, if indexing is not required for given source.
        /// </summary>
        /// <value>Set to true, if indexing is not required for given source.</value>
        [DataMember(Name="skipIndexing", EmitDefaultValue=false)]
        public bool? SkipIndexing { get; set; }

        /// <summary>
        /// Source entity id. NOTE: This is expected to point to a leaf-level entity.
        /// </summary>
        /// <value>Source entity id. NOTE: This is expected to point to a leaf-level entity.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParams
        /// </summary>
        [DataMember(Name="vmwareParams", EmitDefaultValue=false)]
        public VMwareBackupSourceParams VmwareParams { get; set; }

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
            return this.Equals(input as BackupSourceParams);
        }

        /// <summary>
        /// Returns true if BackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppEntityIdVec == input.AppEntityIdVec ||
                    this.AppEntityIdVec != null &&
                    this.AppEntityIdVec.Equals(input.AppEntityIdVec)
                ) && 
                (
                    this.AwsNativeParams == input.AwsNativeParams ||
                    (this.AwsNativeParams != null &&
                    this.AwsNativeParams.Equals(input.AwsNativeParams))
                ) && 
                (
                    this.AwsSnapshotManagerParams == input.AwsSnapshotManagerParams ||
                    (this.AwsSnapshotManagerParams != null &&
                    this.AwsSnapshotManagerParams.Equals(input.AwsSnapshotManagerParams))
                ) && 
                (
                    this.OracleParams == input.OracleParams ||
                    (this.OracleParams != null &&
                    this.OracleParams.Equals(input.OracleParams))
                ) && 
                (
                    this.PhysicalParams == input.PhysicalParams ||
                    (this.PhysicalParams != null &&
                    this.PhysicalParams.Equals(input.PhysicalParams))
                ) && 
                (
                    this.SkipIndexing == input.SkipIndexing ||
                    (this.SkipIndexing != null &&
                    this.SkipIndexing.Equals(input.SkipIndexing))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.VmwareParams == input.VmwareParams ||
                    (this.VmwareParams != null &&
                    this.VmwareParams.Equals(input.VmwareParams))
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
                if (this.AppEntityIdVec != null)
                    hashCode = hashCode * 59 + this.AppEntityIdVec.GetHashCode();
                if (this.AwsNativeParams != null)
                    hashCode = hashCode * 59 + this.AwsNativeParams.GetHashCode();
                if (this.AwsSnapshotManagerParams != null)
                    hashCode = hashCode * 59 + this.AwsSnapshotManagerParams.GetHashCode();
                if (this.OracleParams != null)
                    hashCode = hashCode * 59 + this.OracleParams.GetHashCode();
                if (this.PhysicalParams != null)
                    hashCode = hashCode * 59 + this.PhysicalParams.GetHashCode();
                if (this.SkipIndexing != null)
                    hashCode = hashCode * 59 + this.SkipIndexing.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.VmwareParams != null)
                    hashCode = hashCode * 59 + this.VmwareParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

