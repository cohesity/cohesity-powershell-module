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
    /// RestoreAppObjectParams
    /// </summary>
    [DataContract]
    public partial class RestoreAppObjectParams :  IEquatable<RestoreAppObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAppObjectParams" /> class.
        /// </summary>
        /// <param name="adRestoreParams">adRestoreParams.</param>
        /// <param name="cloneTaskId">Id of finished clone task which has to be refreshed with different data..</param>
        /// <param name="exchangeRestoreParams">exchangeRestoreParams.</param>
        /// <param name="oracleRestoreParams">oracleRestoreParams.</param>
        /// <param name="sqlRestoreParams">sqlRestoreParams.</param>
        /// <param name="targetHost">targetHost.</param>
        /// <param name="targetHostParentSource">targetHostParentSource.</param>
        public RestoreAppObjectParams(RestoreADAppObjectParams adRestoreParams = default(RestoreADAppObjectParams), long? cloneTaskId = default(long?), RestoreExchangeParams exchangeRestoreParams = default(RestoreExchangeParams), RestoreOracleAppObjectParams oracleRestoreParams = default(RestoreOracleAppObjectParams), RestoreSqlAppObjectParams sqlRestoreParams = default(RestoreSqlAppObjectParams), EntityProto targetHost = default(EntityProto), EntityProto targetHostParentSource = default(EntityProto))
        {
            this.AdRestoreParams = adRestoreParams;
            this.CloneTaskId = cloneTaskId;
            this.ExchangeRestoreParams = exchangeRestoreParams;
            this.OracleRestoreParams = oracleRestoreParams;
            this.SqlRestoreParams = sqlRestoreParams;
            this.TargetHost = targetHost;
            this.TargetHostParentSource = targetHostParentSource;
        }
        
        /// <summary>
        /// Gets or Sets AdRestoreParams
        /// </summary>
        [DataMember(Name="adRestoreParams", EmitDefaultValue=false)]
        public RestoreADAppObjectParams AdRestoreParams { get; set; }

        /// <summary>
        /// Id of finished clone task which has to be refreshed with different data.
        /// </summary>
        /// <value>Id of finished clone task which has to be refreshed with different data.</value>
        [DataMember(Name="cloneTaskId", EmitDefaultValue=false)]
        public long? CloneTaskId { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRestoreParams
        /// </summary>
        [DataMember(Name="exchangeRestoreParams", EmitDefaultValue=false)]
        public RestoreExchangeParams ExchangeRestoreParams { get; set; }

        /// <summary>
        /// Gets or Sets OracleRestoreParams
        /// </summary>
        [DataMember(Name="oracleRestoreParams", EmitDefaultValue=false)]
        public RestoreOracleAppObjectParams OracleRestoreParams { get; set; }

        /// <summary>
        /// Gets or Sets SqlRestoreParams
        /// </summary>
        [DataMember(Name="sqlRestoreParams", EmitDefaultValue=false)]
        public RestoreSqlAppObjectParams SqlRestoreParams { get; set; }

        /// <summary>
        /// Gets or Sets TargetHost
        /// </summary>
        [DataMember(Name="targetHost", EmitDefaultValue=false)]
        public EntityProto TargetHost { get; set; }

        /// <summary>
        /// Gets or Sets TargetHostParentSource
        /// </summary>
        [DataMember(Name="targetHostParentSource", EmitDefaultValue=false)]
        public EntityProto TargetHostParentSource { get; set; }

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
            return this.Equals(input as RestoreAppObjectParams);
        }

        /// <summary>
        /// Returns true if RestoreAppObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAppObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAppObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdRestoreParams == input.AdRestoreParams ||
                    (this.AdRestoreParams != null &&
                    this.AdRestoreParams.Equals(input.AdRestoreParams))
                ) && 
                (
                    this.CloneTaskId == input.CloneTaskId ||
                    (this.CloneTaskId != null &&
                    this.CloneTaskId.Equals(input.CloneTaskId))
                ) && 
                (
                    this.ExchangeRestoreParams == input.ExchangeRestoreParams ||
                    (this.ExchangeRestoreParams != null &&
                    this.ExchangeRestoreParams.Equals(input.ExchangeRestoreParams))
                ) && 
                (
                    this.OracleRestoreParams == input.OracleRestoreParams ||
                    (this.OracleRestoreParams != null &&
                    this.OracleRestoreParams.Equals(input.OracleRestoreParams))
                ) && 
                (
                    this.SqlRestoreParams == input.SqlRestoreParams ||
                    (this.SqlRestoreParams != null &&
                    this.SqlRestoreParams.Equals(input.SqlRestoreParams))
                ) && 
                (
                    this.TargetHost == input.TargetHost ||
                    (this.TargetHost != null &&
                    this.TargetHost.Equals(input.TargetHost))
                ) && 
                (
                    this.TargetHostParentSource == input.TargetHostParentSource ||
                    (this.TargetHostParentSource != null &&
                    this.TargetHostParentSource.Equals(input.TargetHostParentSource))
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
                if (this.AdRestoreParams != null)
                    hashCode = hashCode * 59 + this.AdRestoreParams.GetHashCode();
                if (this.CloneTaskId != null)
                    hashCode = hashCode * 59 + this.CloneTaskId.GetHashCode();
                if (this.ExchangeRestoreParams != null)
                    hashCode = hashCode * 59 + this.ExchangeRestoreParams.GetHashCode();
                if (this.OracleRestoreParams != null)
                    hashCode = hashCode * 59 + this.OracleRestoreParams.GetHashCode();
                if (this.SqlRestoreParams != null)
                    hashCode = hashCode * 59 + this.SqlRestoreParams.GetHashCode();
                if (this.TargetHost != null)
                    hashCode = hashCode * 59 + this.TargetHost.GetHashCode();
                if (this.TargetHostParentSource != null)
                    hashCode = hashCode * 59 + this.TargetHostParentSource.GetHashCode();
                return hashCode;
            }
        }

    }

}

