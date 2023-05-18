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
    /// Specifies additional parameters that are common to all Protection Sources in a Protection Job created for a particular environment type.
    /// </summary>
    [DataContract]
    public partial class EnvironmentTypeJobParameters :  IEquatable<EnvironmentTypeJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTypeJobParameters" /> class.
        /// </summary>
        /// <param name="awsSnapshotParameters">awsSnapshotParameters.</param>
        /// <param name="exchangeParameters">exchangeParameters.</param>
        /// <param name="externallyTriggeredJobParameters">externallyTriggeredJobParameters.</param>
        /// <param name="hypervParameters">hypervParameters.</param>
        /// <param name="nasParameters">nasParameters.</param>
        /// <param name="office365Parameters">office365Parameters.</param>
        /// <param name="oracleParameters">oracleParameters.</param>
        /// <param name="physicalParameters">physicalParameters.</param>
        /// <param name="pureParameters">pureParameters.</param>
        /// <param name="sqlParameters">sqlParameters.</param>
        /// <param name="vmwareParameters">vmwareParameters.</param>
        public EnvironmentTypeJobParameters(AwsSnapshotManagerParameters awsSnapshotParameters = default(AwsSnapshotManagerParameters), ExchangeEnvJobParameters exchangeParameters = default(ExchangeEnvJobParameters), ExternallyTriggeredEnvJobParameters externallyTriggeredJobParameters = default(ExternallyTriggeredEnvJobParameters), HypervEnvJobParameters hypervParameters = default(HypervEnvJobParameters), NasEnvJobParameters nasParameters = default(NasEnvJobParameters), Office365EnvJobParameters office365Parameters = default(Office365EnvJobParameters), OracleEnvJobParameters oracleParameters = default(OracleEnvJobParameters), PhysicalEnvJobParameters physicalParameters = default(PhysicalEnvJobParameters), SanEnvJobParameters pureParameters = default(SanEnvJobParameters), SqlEnvJobParameters sqlParameters = default(SqlEnvJobParameters), VmwareEnvJobParameters vmwareParameters = default(VmwareEnvJobParameters))
        {
            this.AwsSnapshotParameters = awsSnapshotParameters;
            this.ExchangeParameters = exchangeParameters;
            this.ExternallyTriggeredJobParameters = externallyTriggeredJobParameters;
            this.HypervParameters = hypervParameters;
            this.NasParameters = nasParameters;
            this.Office365Parameters = office365Parameters;
            this.OracleParameters = oracleParameters;
            this.PhysicalParameters = physicalParameters;
            this.PureParameters = pureParameters;
            this.SqlParameters = sqlParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Gets or Sets AwsSnapshotParameters
        /// </summary>
        [DataMember(Name="awsSnapshotParameters", EmitDefaultValue=false)]
        public AwsSnapshotManagerParameters AwsSnapshotParameters { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeParameters
        /// </summary>
        [DataMember(Name="exchangeParameters", EmitDefaultValue=false)]
        public ExchangeEnvJobParameters ExchangeParameters { get; set; }

        /// <summary>
        /// Gets or Sets ExternallyTriggeredJobParameters
        /// </summary>
        [DataMember(Name="externallyTriggeredJobParameters", EmitDefaultValue=false)]
        public ExternallyTriggeredEnvJobParameters ExternallyTriggeredJobParameters { get; set; }

        /// <summary>
        /// Gets or Sets HypervParameters
        /// </summary>
        [DataMember(Name="hypervParameters", EmitDefaultValue=false)]
        public HypervEnvJobParameters HypervParameters { get; set; }

        /// <summary>
        /// Gets or Sets NasParameters
        /// </summary>
        [DataMember(Name="nasParameters", EmitDefaultValue=false)]
        public NasEnvJobParameters NasParameters { get; set; }

        /// <summary>
        /// Gets or Sets Office365Parameters
        /// </summary>
        [DataMember(Name="office365Parameters", EmitDefaultValue=false)]
        public Office365EnvJobParameters Office365Parameters { get; set; }

        /// <summary>
        /// Gets or Sets OracleParameters
        /// </summary>
        [DataMember(Name="oracleParameters", EmitDefaultValue=false)]
        public OracleEnvJobParameters OracleParameters { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalParameters
        /// </summary>
        [DataMember(Name="physicalParameters", EmitDefaultValue=false)]
        public PhysicalEnvJobParameters PhysicalParameters { get; set; }

        /// <summary>
        /// Gets or Sets PureParameters
        /// </summary>
        [DataMember(Name="pureParameters", EmitDefaultValue=false)]
        public SanEnvJobParameters PureParameters { get; set; }

        /// <summary>
        /// Gets or Sets SqlParameters
        /// </summary>
        [DataMember(Name="sqlParameters", EmitDefaultValue=false)]
        public SqlEnvJobParameters SqlParameters { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParameters
        /// </summary>
        [DataMember(Name="vmwareParameters", EmitDefaultValue=false)]
        public VmwareEnvJobParameters VmwareParameters { get; set; }

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
            return this.Equals(input as EnvironmentTypeJobParameters);
        }

        /// <summary>
        /// Returns true if EnvironmentTypeJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentTypeJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentTypeJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsSnapshotParameters == input.AwsSnapshotParameters ||
                    (this.AwsSnapshotParameters != null &&
                    this.AwsSnapshotParameters.Equals(input.AwsSnapshotParameters))
                ) && 
                (
                    this.ExchangeParameters == input.ExchangeParameters ||
                    (this.ExchangeParameters != null &&
                    this.ExchangeParameters.Equals(input.ExchangeParameters))
                ) && 
                (
                    this.ExternallyTriggeredJobParameters == input.ExternallyTriggeredJobParameters ||
                    (this.ExternallyTriggeredJobParameters != null &&
                    this.ExternallyTriggeredJobParameters.Equals(input.ExternallyTriggeredJobParameters))
                ) && 
                (
                    this.HypervParameters == input.HypervParameters ||
                    (this.HypervParameters != null &&
                    this.HypervParameters.Equals(input.HypervParameters))
                ) && 
                (
                    this.NasParameters == input.NasParameters ||
                    (this.NasParameters != null &&
                    this.NasParameters.Equals(input.NasParameters))
                ) && 
                (
                    this.Office365Parameters == input.Office365Parameters ||
                    (this.Office365Parameters != null &&
                    this.Office365Parameters.Equals(input.Office365Parameters))
                ) && 
                (
                    this.OracleParameters == input.OracleParameters ||
                    (this.OracleParameters != null &&
                    this.OracleParameters.Equals(input.OracleParameters))
                ) && 
                (
                    this.PhysicalParameters == input.PhysicalParameters ||
                    (this.PhysicalParameters != null &&
                    this.PhysicalParameters.Equals(input.PhysicalParameters))
                ) && 
                (
                    this.PureParameters == input.PureParameters ||
                    (this.PureParameters != null &&
                    this.PureParameters.Equals(input.PureParameters))
                ) && 
                (
                    this.SqlParameters == input.SqlParameters ||
                    (this.SqlParameters != null &&
                    this.SqlParameters.Equals(input.SqlParameters))
                ) && 
                (
                    this.VmwareParameters == input.VmwareParameters ||
                    (this.VmwareParameters != null &&
                    this.VmwareParameters.Equals(input.VmwareParameters))
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
                if (this.AwsSnapshotParameters != null)
                    hashCode = hashCode * 59 + this.AwsSnapshotParameters.GetHashCode();
                if (this.ExchangeParameters != null)
                    hashCode = hashCode * 59 + this.ExchangeParameters.GetHashCode();
                if (this.ExternallyTriggeredJobParameters != null)
                    hashCode = hashCode * 59 + this.ExternallyTriggeredJobParameters.GetHashCode();
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.NasParameters != null)
                    hashCode = hashCode * 59 + this.NasParameters.GetHashCode();
                if (this.Office365Parameters != null)
                    hashCode = hashCode * 59 + this.Office365Parameters.GetHashCode();
                if (this.OracleParameters != null)
                    hashCode = hashCode * 59 + this.OracleParameters.GetHashCode();
                if (this.PhysicalParameters != null)
                    hashCode = hashCode * 59 + this.PhysicalParameters.GetHashCode();
                if (this.PureParameters != null)
                    hashCode = hashCode * 59 + this.PureParameters.GetHashCode();
                if (this.SqlParameters != null)
                    hashCode = hashCode * 59 + this.SqlParameters.GetHashCode();
                if (this.VmwareParameters != null)
                    hashCode = hashCode * 59 + this.VmwareParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

