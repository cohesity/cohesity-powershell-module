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
    /// GenericAdapterRecoverParamsPITRParams
    /// </summary>
    [DataContract]
    public partial class GenericAdapterRecoverParamsPITRParams :  IEquatable<GenericAdapterRecoverParamsPITRParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericAdapterRecoverParamsPITRParams" /> class.
        /// </summary>
        /// <param name="logBackups">List of relevant log backups to be stitched in the slave for PITR..</param>
        /// <param name="logViewNameVec">List of relevant log views to be stitched in the slave for PITR. Use log_backups instead. This is set for now to handle case of old slave and new master..</param>
        /// <param name="pitrTimeSecs">The point-in-time to which object needs to be restored..</param>
        public GenericAdapterRecoverParamsPITRParams(List<GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo> logBackups = default(List<GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo>), List<string> logViewNameVec = default(List<string>), long? pitrTimeSecs = default(long?))
        {
            this.LogBackups = logBackups;
            this.LogViewNameVec = logViewNameVec;
            this.PitrTimeSecs = pitrTimeSecs;
            this.LogBackups = logBackups;
            this.LogViewNameVec = logViewNameVec;
            this.PitrTimeSecs = pitrTimeSecs;
        }
        
        /// <summary>
        /// List of relevant log backups to be stitched in the slave for PITR.
        /// </summary>
        /// <value>List of relevant log backups to be stitched in the slave for PITR.</value>
        [DataMember(Name="logBackups", EmitDefaultValue=true)]
        public List<GenericAdapterRecoverParamsPITRParamsLogBackupRunInfo> LogBackups { get; set; }

        /// <summary>
        /// List of relevant log views to be stitched in the slave for PITR. Use log_backups instead. This is set for now to handle case of old slave and new master.
        /// </summary>
        /// <value>List of relevant log views to be stitched in the slave for PITR. Use log_backups instead. This is set for now to handle case of old slave and new master.</value>
        [DataMember(Name="logViewNameVec", EmitDefaultValue=true)]
        public List<string> LogViewNameVec { get; set; }

        /// <summary>
        /// The point-in-time to which object needs to be restored.
        /// </summary>
        /// <value>The point-in-time to which object needs to be restored.</value>
        [DataMember(Name="pitrTimeSecs", EmitDefaultValue=true)]
        public long? PitrTimeSecs { get; set; }

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
            return this.Equals(input as GenericAdapterRecoverParamsPITRParams);
        }

        /// <summary>
        /// Returns true if GenericAdapterRecoverParamsPITRParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericAdapterRecoverParamsPITRParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericAdapterRecoverParamsPITRParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogBackups == input.LogBackups ||
                    this.LogBackups != null &&
                    input.LogBackups != null &&
                    this.LogBackups.SequenceEqual(input.LogBackups)
                ) && 
                (
                    this.LogViewNameVec == input.LogViewNameVec ||
                    this.LogViewNameVec != null &&
                    input.LogViewNameVec != null &&
                    this.LogViewNameVec.SequenceEqual(input.LogViewNameVec)
                ) && 
                (
                    this.PitrTimeSecs == input.PitrTimeSecs ||
                    (this.PitrTimeSecs != null &&
                    this.PitrTimeSecs.Equals(input.PitrTimeSecs))
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
                if (this.LogBackups != null)
                    hashCode = hashCode * 59 + this.LogBackups.GetHashCode();
                if (this.LogViewNameVec != null)
                    hashCode = hashCode * 59 + this.LogViewNameVec.GetHashCode();
                if (this.PitrTimeSecs != null)
                    hashCode = hashCode * 59 + this.PitrTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

