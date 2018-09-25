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
    /// WindowsHostSnapshotParameters
    /// </summary>
    [DataContract]
    public partial class WindowsHostSnapshotParameters :  IEquatable<WindowsHostSnapshotParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsHostSnapshotParameters" /> class.
        /// </summary>
        /// <param name="copyOnlyBackup">Specifies whether to backup regardless of the state of each file&#39;s backup history. Backup history will not be updated. Refer Microsoft documentation on VSS_BT_COPY..</param>
        /// <param name="disableMetadata">Specifies whether to disable fetching and storing of some metadata on Cohesity Cluster to save storage space. Otherwise, there will be some metadata fetched and stored on Cohesity Cluster..</param>
        /// <param name="disableNotification">Specifies whether to disable some notification steps when taking snapshots..</param>
        /// <param name="excludedVssWriters">For example, \&quot;ASR Writer\&quot;, \&quot;System Writer\&quot;. Refer Microsoft documentaion for a complete list..</param>
        public WindowsHostSnapshotParameters(bool? copyOnlyBackup = default(bool?), bool? disableMetadata = default(bool?), bool? disableNotification = default(bool?), List<string> excludedVssWriters = default(List<string>))
        {
            this.CopyOnlyBackup = copyOnlyBackup;
            this.DisableMetadata = disableMetadata;
            this.DisableNotification = disableNotification;
            this.ExcludedVssWriters = excludedVssWriters;
        }
        
        /// <summary>
        /// Specifies whether to backup regardless of the state of each file&#39;s backup history. Backup history will not be updated. Refer Microsoft documentation on VSS_BT_COPY.
        /// </summary>
        /// <value>Specifies whether to backup regardless of the state of each file&#39;s backup history. Backup history will not be updated. Refer Microsoft documentation on VSS_BT_COPY.</value>
        [DataMember(Name="copyOnlyBackup", EmitDefaultValue=false)]
        public bool? CopyOnlyBackup { get; set; }

        /// <summary>
        /// Specifies whether to disable fetching and storing of some metadata on Cohesity Cluster to save storage space. Otherwise, there will be some metadata fetched and stored on Cohesity Cluster.
        /// </summary>
        /// <value>Specifies whether to disable fetching and storing of some metadata on Cohesity Cluster to save storage space. Otherwise, there will be some metadata fetched and stored on Cohesity Cluster.</value>
        [DataMember(Name="disableMetadata", EmitDefaultValue=false)]
        public bool? DisableMetadata { get; set; }

        /// <summary>
        /// Specifies whether to disable some notification steps when taking snapshots.
        /// </summary>
        /// <value>Specifies whether to disable some notification steps when taking snapshots.</value>
        [DataMember(Name="disableNotification", EmitDefaultValue=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// For example, \&quot;ASR Writer\&quot;, \&quot;System Writer\&quot;. Refer Microsoft documentaion for a complete list.
        /// </summary>
        /// <value>For example, \&quot;ASR Writer\&quot;, \&quot;System Writer\&quot;. Refer Microsoft documentaion for a complete list.</value>
        [DataMember(Name="excludedVssWriters", EmitDefaultValue=false)]
        public List<string> ExcludedVssWriters { get; set; }

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
            return this.Equals(input as WindowsHostSnapshotParameters);
        }

        /// <summary>
        /// Returns true if WindowsHostSnapshotParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowsHostSnapshotParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowsHostSnapshotParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyOnlyBackup == input.CopyOnlyBackup ||
                    (this.CopyOnlyBackup != null &&
                    this.CopyOnlyBackup.Equals(input.CopyOnlyBackup))
                ) && 
                (
                    this.DisableMetadata == input.DisableMetadata ||
                    (this.DisableMetadata != null &&
                    this.DisableMetadata.Equals(input.DisableMetadata))
                ) && 
                (
                    this.DisableNotification == input.DisableNotification ||
                    (this.DisableNotification != null &&
                    this.DisableNotification.Equals(input.DisableNotification))
                ) && 
                (
                    this.ExcludedVssWriters == input.ExcludedVssWriters ||
                    this.ExcludedVssWriters != null &&
                    this.ExcludedVssWriters.SequenceEqual(input.ExcludedVssWriters)
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
                if (this.CopyOnlyBackup != null)
                    hashCode = hashCode * 59 + this.CopyOnlyBackup.GetHashCode();
                if (this.DisableMetadata != null)
                    hashCode = hashCode * 59 + this.DisableMetadata.GetHashCode();
                if (this.DisableNotification != null)
                    hashCode = hashCode * 59 + this.DisableNotification.GetHashCode();
                if (this.ExcludedVssWriters != null)
                    hashCode = hashCode * 59 + this.ExcludedVssWriters.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

