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
    /// Provides Resolution details and the list of Alerts resolved by a Resolution, which are specified by Alert Ids.
    /// </summary>
    [DataContract]
    public partial class AlertResolution :  IEquatable<AlertResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertResolution" /> class.
        /// </summary>
        /// <param name="alertIdList">Specifies list of Alerts resolved by a Resolution, which are specified by Alert Ids..</param>
        /// <param name="resolutionDetails">resolutionDetails.</param>
        /// <param name="tenantIds">Specifies unique tenantIds of the alert contained in this resolution..</param>
        public AlertResolution(List<string> alertIdList = default(List<string>), AlertResolutionDetails resolutionDetails = default(AlertResolutionDetails), List<string> tenantIds = default(List<string>))
        {
            this.AlertIdList = alertIdList;
            this.TenantIds = tenantIds;
            this.AlertIdList = alertIdList;
            this.ResolutionDetails = resolutionDetails;
            this.TenantIds = tenantIds;
        }
        
        /// <summary>
        /// Specifies list of Alerts resolved by a Resolution, which are specified by Alert Ids.
        /// </summary>
        /// <value>Specifies list of Alerts resolved by a Resolution, which are specified by Alert Ids.</value>
        [DataMember(Name="alertIdList", EmitDefaultValue=true)]
        public List<string> AlertIdList { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionDetails
        /// </summary>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public AlertResolutionDetails ResolutionDetails { get; set; }

        /// <summary>
        /// Specifies unique tenantIds of the alert contained in this resolution.
        /// </summary>
        /// <value>Specifies unique tenantIds of the alert contained in this resolution.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=true)]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertResolution {\n");
            sb.Append("  AlertIdList: ").Append(AlertIdList).Append("\n");
            sb.Append("  ResolutionDetails: ").Append(ResolutionDetails).Append("\n");
            sb.Append("  TenantIds: ").Append(TenantIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as AlertResolution);
        }

        /// <summary>
        /// Returns true if AlertResolution instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertResolution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlertIdList == input.AlertIdList ||
                    this.AlertIdList != null &&
                    input.AlertIdList != null &&
                    this.AlertIdList.SequenceEqual(input.AlertIdList)
                ) && 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    input.TenantIds != null &&
                    this.TenantIds.SequenceEqual(input.TenantIds)
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
                if (this.AlertIdList != null)
                    hashCode = hashCode * 59 + this.AlertIdList.GetHashCode();
                if (this.ResolutionDetails != null)
                    hashCode = hashCode * 59 + this.ResolutionDetails.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                return hashCode;
            }
        }

    }

}
