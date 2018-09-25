// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the settings of the filer audit log configuration.
    /// </summary>
    [DataContract]
    public partial class FilerAuditLogConfiguration :  IEquatable<FilerAuditLogConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilerAuditLogConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilerAuditLogConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilerAuditLogConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">Specifies if filer audit logging is enabled on the Cohesity Cluster. If &#39;true&#39;, filer audit logging is enabled. Otherwise, it is disabled. (required).</param>
        /// <param name="retentionPeriodDays">Specifies the number of days to keep (retain) the filer audit logs. Audit logs generated before the period of time specified by retentionPeriodDays are removed from the Cohesity Cluster. (required).</param>
        public FilerAuditLogConfiguration(bool? enabled = default(bool?), int? retentionPeriodDays = default(int?))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for FilerAuditLogConfiguration and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "retentionPeriodDays" is required (not null)
            if (retentionPeriodDays == null)
            {
                throw new InvalidDataException("retentionPeriodDays is a required property for FilerAuditLogConfiguration and cannot be null");
            }
            else
            {
                this.RetentionPeriodDays = retentionPeriodDays;
            }
        }
        
        /// <summary>
        /// Specifies if filer audit logging is enabled on the Cohesity Cluster. If &#39;true&#39;, filer audit logging is enabled. Otherwise, it is disabled.
        /// </summary>
        /// <value>Specifies if filer audit logging is enabled on the Cohesity Cluster. If &#39;true&#39;, filer audit logging is enabled. Otherwise, it is disabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies the number of days to keep (retain) the filer audit logs. Audit logs generated before the period of time specified by retentionPeriodDays are removed from the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the number of days to keep (retain) the filer audit logs. Audit logs generated before the period of time specified by retentionPeriodDays are removed from the Cohesity Cluster.</value>
        [DataMember(Name="retentionPeriodDays", EmitDefaultValue=false)]
        public int? RetentionPeriodDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as FilerAuditLogConfiguration);
        }

        /// <summary>
        /// Returns true if FilerAuditLogConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of FilerAuditLogConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilerAuditLogConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.RetentionPeriodDays == input.RetentionPeriodDays ||
                    (this.RetentionPeriodDays != null &&
                    this.RetentionPeriodDays.Equals(input.RetentionPeriodDays))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetentionPeriodDays != null)
                    hashCode = hashCode * 59 + this.RetentionPeriodDays.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

