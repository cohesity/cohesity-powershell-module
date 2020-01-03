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
    /// Message to capture any additional backup params for Office365 environment. This encapsulates both Outlook &amp; OneDrive backup parameters.
    /// </summary>
    [DataContract]
    public partial class O365BackupEnvParams :  IEquatable<O365BackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365BackupEnvParams" /> class.
        /// </summary>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="onedriveBackupParams">onedriveBackupParams.</param>
        /// <param name="outlookBackupParams">outlookBackupParams.</param>
        public O365BackupEnvParams(FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), OneDriveBackupEnvParams onedriveBackupParams = default(OneDriveBackupEnvParams), OutlookBackupEnvParams outlookBackupParams = default(OutlookBackupEnvParams))
        {
            this.FilteringPolicy = filteringPolicy;
            this.OnedriveBackupParams = onedriveBackupParams;
            this.OutlookBackupParams = outlookBackupParams;
        }
        
        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// Gets or Sets OnedriveBackupParams
        /// </summary>
        [DataMember(Name="onedriveBackupParams", EmitDefaultValue=false)]
        public OneDriveBackupEnvParams OnedriveBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets OutlookBackupParams
        /// </summary>
        [DataMember(Name="outlookBackupParams", EmitDefaultValue=false)]
        public OutlookBackupEnvParams OutlookBackupParams { get; set; }

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
            return this.Equals(input as O365BackupEnvParams);
        }

        /// <summary>
        /// Returns true if O365BackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365BackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365BackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.OnedriveBackupParams == input.OnedriveBackupParams ||
                    (this.OnedriveBackupParams != null &&
                    this.OnedriveBackupParams.Equals(input.OnedriveBackupParams))
                ) && 
                (
                    this.OutlookBackupParams == input.OutlookBackupParams ||
                    (this.OutlookBackupParams != null &&
                    this.OutlookBackupParams.Equals(input.OutlookBackupParams))
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
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.OnedriveBackupParams != null)
                    hashCode = hashCode * 59 + this.OnedriveBackupParams.GetHashCode();
                if (this.OutlookBackupParams != null)
                    hashCode = hashCode * 59 + this.OutlookBackupParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

