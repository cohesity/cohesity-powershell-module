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
    /// Specifies a Protection Source and the Snapshots that back it up.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourcesJobRunsReportElement :  IEquatable<ProtectionSourcesJobRunsReportElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourcesJobRunsReportElement" /> class.
        /// </summary>
        /// <param name="protectionSource">Specifies the leaf Protection Source Object such as a VM..</param>
        /// <param name="snapshotsInfo">Array of Snapshots  Specifies the Snapshots that contain backups of the Protection Source Object..</param>
        public ProtectionSourcesJobRunsReportElement(ProtectionSource protectionSource = default(ProtectionSource), List<ProtectionSourceSnapshotInformation> snapshotsInfo = default(List<ProtectionSourceSnapshotInformation>))
        {
            this.ProtectionSource = protectionSource;
            this.SnapshotsInfo = snapshotsInfo;
        }
        
        /// <summary>
        /// Specifies the leaf Protection Source Object such as a VM.
        /// </summary>
        /// <value>Specifies the leaf Protection Source Object such as a VM.</value>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Array of Snapshots  Specifies the Snapshots that contain backups of the Protection Source Object.
        /// </summary>
        /// <value>Array of Snapshots  Specifies the Snapshots that contain backups of the Protection Source Object.</value>
        [DataMember(Name="snapshotsInfo", EmitDefaultValue=false)]
        public List<ProtectionSourceSnapshotInformation> SnapshotsInfo { get; set; }

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
                    this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource)
                ) && 
                (
                    this.SnapshotsInfo == input.SnapshotsInfo ||
                    this.SnapshotsInfo != null &&
                    this.SnapshotsInfo.Equals(input.SnapshotsInfo)
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

