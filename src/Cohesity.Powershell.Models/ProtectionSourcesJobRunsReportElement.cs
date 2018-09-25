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
    /// Specifies a Protection Source and the Snapshots that back it up.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourcesJobRunsReportElement :  IEquatable<ProtectionSourcesJobRunsReportElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourcesJobRunsReportElement" /> class.
        /// </summary>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="snapshotsInfo">Specifies the Snapshots that contain backups of the Protection Source Object..</param>
        public ProtectionSourcesJobRunsReportElement(ProtectionSource2 protectionSource = default(ProtectionSource2), List<ProtectionSourceSnapshotInformation> snapshotsInfo = default(List<ProtectionSourceSnapshotInformation>))
        {
            this.ProtectionSource = protectionSource;
            this.SnapshotsInfo = snapshotsInfo;
        }
        
        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource2 ProtectionSource { get; set; }

        /// <summary>
        /// Specifies the Snapshots that contain backups of the Protection Source Object.
        /// </summary>
        /// <value>Specifies the Snapshots that contain backups of the Protection Source Object.</value>
        [DataMember(Name="snapshotsInfo", EmitDefaultValue=false)]
        public List<ProtectionSourceSnapshotInformation> SnapshotsInfo { get; set; }

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
            return this.Equals(input as ProtectionSourcesJobRunsReportElement);
        }

        /// <summary>
        /// Returns true if ProtectionSourcesJobRunsReportElement instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourcesJobRunsReportElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourcesJobRunsReportElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.SnapshotsInfo == input.SnapshotsInfo ||
                    this.SnapshotsInfo != null &&
                    this.SnapshotsInfo.SequenceEqual(input.SnapshotsInfo)
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
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.SnapshotsInfo != null)
                    hashCode = hashCode * 59 + this.SnapshotsInfo.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

