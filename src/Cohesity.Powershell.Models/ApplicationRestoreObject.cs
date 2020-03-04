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
    /// Specifies the Application Server to restore and parameters specific to that application.
    /// </summary>
    [DataContract]
    public partial class ApplicationRestoreObject :  IEquatable<ApplicationRestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationRestoreObject" /> class.
        /// </summary>
        /// <param name="adRestoreParameters">adRestoreParameters.</param>
        /// <param name="applicationServerId">Specifies the Application Server to restore (for example, kSQL)..</param>
        /// <param name="exchangeRestoreParameters">exchangeRestoreParameters.</param>
        /// <param name="sqlRestoreParameters">sqlRestoreParameters.</param>
        /// <param name="targetHostId">Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source..</param>
        /// <param name="targetRootNodeId">Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application..</param>
        public ApplicationRestoreObject(AdRestoreParameters adRestoreParameters = default(AdRestoreParameters), long? applicationServerId = default(long?), ExchangeRestoreParameters exchangeRestoreParameters = default(ExchangeRestoreParameters), SqlRestoreParameters sqlRestoreParameters = default(SqlRestoreParameters), long? targetHostId = default(long?), long? targetRootNodeId = default(long?))
        {
            this.ApplicationServerId = applicationServerId;
            this.TargetHostId = targetHostId;
            this.TargetRootNodeId = targetRootNodeId;
            this.AdRestoreParameters = adRestoreParameters;
            this.ApplicationServerId = applicationServerId;
            this.ExchangeRestoreParameters = exchangeRestoreParameters;
            this.SqlRestoreParameters = sqlRestoreParameters;
            this.TargetHostId = targetHostId;
            this.TargetRootNodeId = targetRootNodeId;
        }
        
        /// <summary>
        /// Gets or Sets AdRestoreParameters
        /// </summary>
        [DataMember(Name="adRestoreParameters", EmitDefaultValue=false)]
        public AdRestoreParameters AdRestoreParameters { get; set; }

        /// <summary>
        /// Specifies the Application Server to restore (for example, kSQL).
        /// </summary>
        /// <value>Specifies the Application Server to restore (for example, kSQL).</value>
        [DataMember(Name="applicationServerId", EmitDefaultValue=true)]
        public long? ApplicationServerId { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRestoreParameters
        /// </summary>
        [DataMember(Name="exchangeRestoreParameters", EmitDefaultValue=false)]
        public ExchangeRestoreParameters ExchangeRestoreParameters { get; set; }

        /// <summary>
        /// Gets or Sets SqlRestoreParameters
        /// </summary>
        [DataMember(Name="sqlRestoreParameters", EmitDefaultValue=false)]
        public SqlRestoreParameters SqlRestoreParameters { get; set; }

        /// <summary>
        /// Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source.
        /// </summary>
        /// <value>Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source.</value>
        [DataMember(Name="targetHostId", EmitDefaultValue=true)]
        public long? TargetHostId { get; set; }

        /// <summary>
        /// Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application.
        /// </summary>
        /// <value>Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application.</value>
        [DataMember(Name="targetRootNodeId", EmitDefaultValue=true)]
        public long? TargetRootNodeId { get; set; }

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
            return this.Equals(input as ApplicationRestoreObject);
        }

        /// <summary>
        /// Returns true if ApplicationRestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationRestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationRestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdRestoreParameters == input.AdRestoreParameters ||
                    (this.AdRestoreParameters != null &&
                    this.AdRestoreParameters.Equals(input.AdRestoreParameters))
                ) && 
                (
                    this.ApplicationServerId == input.ApplicationServerId ||
                    (this.ApplicationServerId != null &&
                    this.ApplicationServerId.Equals(input.ApplicationServerId))
                ) && 
                (
                    this.ExchangeRestoreParameters == input.ExchangeRestoreParameters ||
                    (this.ExchangeRestoreParameters != null &&
                    this.ExchangeRestoreParameters.Equals(input.ExchangeRestoreParameters))
                ) && 
                (
                    this.SqlRestoreParameters == input.SqlRestoreParameters ||
                    (this.SqlRestoreParameters != null &&
                    this.SqlRestoreParameters.Equals(input.SqlRestoreParameters))
                ) && 
                (
                    this.TargetHostId == input.TargetHostId ||
                    (this.TargetHostId != null &&
                    this.TargetHostId.Equals(input.TargetHostId))
                ) && 
                (
                    this.TargetRootNodeId == input.TargetRootNodeId ||
                    (this.TargetRootNodeId != null &&
                    this.TargetRootNodeId.Equals(input.TargetRootNodeId))
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
                if (this.AdRestoreParameters != null)
                    hashCode = hashCode * 59 + this.AdRestoreParameters.GetHashCode();
                if (this.ApplicationServerId != null)
                    hashCode = hashCode * 59 + this.ApplicationServerId.GetHashCode();
                if (this.ExchangeRestoreParameters != null)
                    hashCode = hashCode * 59 + this.ExchangeRestoreParameters.GetHashCode();
                if (this.SqlRestoreParameters != null)
                    hashCode = hashCode * 59 + this.SqlRestoreParameters.GetHashCode();
                if (this.TargetHostId != null)
                    hashCode = hashCode * 59 + this.TargetHostId.GetHashCode();
                if (this.TargetRootNodeId != null)
                    hashCode = hashCode * 59 + this.TargetRootNodeId.GetHashCode();
                return hashCode;
            }
        }

    }

}

