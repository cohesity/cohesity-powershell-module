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
    /// Request that provides the details of a resolution and the list of Alert Ids to be marked resolved.
    /// </summary>
    [DataContract]
    public partial class AlertResolutionRequest :  IEquatable<AlertResolutionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertResolutionRequest" /> class.
        /// </summary>
        /// <param name="alertIdList">Specifies list of alerts resolved by a Resolution, which are specified by Alert Ids..</param>
        /// <param name="resolutionDetails">resolutionDetails.</param>
        public AlertResolutionRequest(List<string> alertIdList = default(List<string>), AlertResolutionInfo resolutionDetails = default(AlertResolutionInfo))
        {
            this.AlertIdList = alertIdList;
            this.AlertIdList = alertIdList;
            this.ResolutionDetails = resolutionDetails;
        }
        
        /// <summary>
        /// Specifies list of alerts resolved by a Resolution, which are specified by Alert Ids.
        /// </summary>
        /// <value>Specifies list of alerts resolved by a Resolution, which are specified by Alert Ids.</value>
        [DataMember(Name="alertIdList", EmitDefaultValue=true)]
        public List<string> AlertIdList { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionDetails
        /// </summary>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public AlertResolutionInfo ResolutionDetails { get; set; }

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
            return this.Equals(input as AlertResolutionRequest);
        }

        /// <summary>
        /// Returns true if AlertResolutionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertResolutionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertResolutionRequest input)
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
                return hashCode;
            }
        }

    }

}

