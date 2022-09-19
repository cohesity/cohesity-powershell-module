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
    /// Protection Job parameters applicable to &#39;kPhysical&#39; Environment type. Specifies job parameters applicable for all &#39;kPhysical&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class PhysicalEnvJobParameters :  IEquatable<PhysicalEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalEnvJobParameters" /> class.
        /// </summary>
        /// <param name="filePathFilters">filePathFilters.</param>
        /// <param name="incrementalSnapshotUponRestart">If true, performs an incremental backup after server restarts. Otherwise a full backup is done. NOTE: This is applicable only to Windows servers. If not set, default value is false..</param>
        public PhysicalEnvJobParameters(FilePathFilter filePathFilters = default(FilePathFilter), bool? incrementalSnapshotUponRestart = default(bool?))
        {
            this.IncrementalSnapshotUponRestart = incrementalSnapshotUponRestart;
            this.FilePathFilters = filePathFilters;
            this.IncrementalSnapshotUponRestart = incrementalSnapshotUponRestart;
        }
        
        /// <summary>
        /// Gets or Sets FilePathFilters
        /// </summary>
        [DataMember(Name="filePathFilters", EmitDefaultValue=false)]
        public FilePathFilter FilePathFilters { get; set; }

        /// <summary>
        /// If true, performs an incremental backup after server restarts. Otherwise a full backup is done. NOTE: This is applicable only to Windows servers. If not set, default value is false.
        /// </summary>
        /// <value>If true, performs an incremental backup after server restarts. Otherwise a full backup is done. NOTE: This is applicable only to Windows servers. If not set, default value is false.</value>
        [DataMember(Name="incrementalSnapshotUponRestart", EmitDefaultValue=true)]
        public bool? IncrementalSnapshotUponRestart { get; set; }

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
            return this.Equals(input as PhysicalEnvJobParameters);
        }

        /// <summary>
        /// Returns true if PhysicalEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilePathFilters == input.FilePathFilters ||
                    (this.FilePathFilters != null &&
                    this.FilePathFilters.Equals(input.FilePathFilters))
                ) && 
                (
                    this.IncrementalSnapshotUponRestart == input.IncrementalSnapshotUponRestart ||
                    (this.IncrementalSnapshotUponRestart != null &&
                    this.IncrementalSnapshotUponRestart.Equals(input.IncrementalSnapshotUponRestart))
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
                if (this.FilePathFilters != null)
                    hashCode = hashCode * 59 + this.FilePathFilters.GetHashCode();
                if (this.IncrementalSnapshotUponRestart != null)
                    hashCode = hashCode * 59 + this.IncrementalSnapshotUponRestart.GetHashCode();
                return hashCode;
            }
        }

    }

}

