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
    /// Message to capture additional backup params for a Physical type source.
    /// </summary>
    [DataContract]
    public partial class PhysicalBackupSourceParams :  IEquatable<PhysicalBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalBackupSourceParams" /> class.
        /// </summary>
        /// <param name="enableSystemBackup">Allows Magneto to drive a \&quot;system\&quot; backup using a 3rd-party tool installed on the Agent host..</param>
        /// <param name="fileBackupParams">fileBackupParams.</param>
        /// <param name="snapshotParams">snapshotParams.</param>
        /// <param name="sourceAppParams">sourceAppParams.</param>
        /// <param name="volumeGuidVec">If this list is non-empty, then only volumes in this will be protected, otherwise all volumes belonging to the host will be protected..</param>
        public PhysicalBackupSourceParams(bool? enableSystemBackup = default(bool?), PhysicalFileBackupParams fileBackupParams = default(PhysicalFileBackupParams), PhysicalSnapshotParams snapshotParams = default(PhysicalSnapshotParams), SourceAppParams sourceAppParams = default(SourceAppParams), List<string> volumeGuidVec = default(List<string>))
        {
            this.EnableSystemBackup = enableSystemBackup;
            this.VolumeGuidVec = volumeGuidVec;
            this.EnableSystemBackup = enableSystemBackup;
            this.FileBackupParams = fileBackupParams;
            this.SnapshotParams = snapshotParams;
            this.SourceAppParams = sourceAppParams;
            this.VolumeGuidVec = volumeGuidVec;
        }
        
        /// <summary>
        /// Allows Magneto to drive a \&quot;system\&quot; backup using a 3rd-party tool installed on the Agent host.
        /// </summary>
        /// <value>Allows Magneto to drive a \&quot;system\&quot; backup using a 3rd-party tool installed on the Agent host.</value>
        [DataMember(Name="enableSystemBackup", EmitDefaultValue=true)]
        public bool? EnableSystemBackup { get; set; }

        /// <summary>
        /// Gets or Sets FileBackupParams
        /// </summary>
        [DataMember(Name="fileBackupParams", EmitDefaultValue=false)]
        public PhysicalFileBackupParams FileBackupParams { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotParams
        /// </summary>
        [DataMember(Name="snapshotParams", EmitDefaultValue=false)]
        public PhysicalSnapshotParams SnapshotParams { get; set; }

        /// <summary>
        /// Gets or Sets SourceAppParams
        /// </summary>
        [DataMember(Name="sourceAppParams", EmitDefaultValue=false)]
        public SourceAppParams SourceAppParams { get; set; }

        /// <summary>
        /// If this list is non-empty, then only volumes in this will be protected, otherwise all volumes belonging to the host will be protected.
        /// </summary>
        /// <value>If this list is non-empty, then only volumes in this will be protected, otherwise all volumes belonging to the host will be protected.</value>
        [DataMember(Name="volumeGuidVec", EmitDefaultValue=true)]
        public List<string> VolumeGuidVec { get; set; }

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
            return this.Equals(input as PhysicalBackupSourceParams);
        }

        /// <summary>
        /// Returns true if PhysicalBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalBackupSourceParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableSystemBackup == input.EnableSystemBackup ||
                    (this.EnableSystemBackup != null &&
                    this.EnableSystemBackup.Equals(input.EnableSystemBackup))
                ) && 
                (
                    this.FileBackupParams == input.FileBackupParams ||
                    (this.FileBackupParams != null &&
                    this.FileBackupParams.Equals(input.FileBackupParams))
                ) && 
                (
                    this.SnapshotParams == input.SnapshotParams ||
                    (this.SnapshotParams != null &&
                    this.SnapshotParams.Equals(input.SnapshotParams))
                ) && 
                (
                    this.SourceAppParams == input.SourceAppParams ||
                    (this.SourceAppParams != null &&
                    this.SourceAppParams.Equals(input.SourceAppParams))
                ) && 
                (
                    this.VolumeGuidVec == input.VolumeGuidVec ||
                    this.VolumeGuidVec != null &&
                    input.VolumeGuidVec != null &&
                    this.VolumeGuidVec.SequenceEqual(input.VolumeGuidVec)
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
                if (this.EnableSystemBackup != null)
                    hashCode = hashCode * 59 + this.EnableSystemBackup.GetHashCode();
                if (this.FileBackupParams != null)
                    hashCode = hashCode * 59 + this.FileBackupParams.GetHashCode();
                if (this.SnapshotParams != null)
                    hashCode = hashCode * 59 + this.SnapshotParams.GetHashCode();
                if (this.SourceAppParams != null)
                    hashCode = hashCode * 59 + this.SourceAppParams.GetHashCode();
                if (this.VolumeGuidVec != null)
                    hashCode = hashCode * 59 + this.VolumeGuidVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

