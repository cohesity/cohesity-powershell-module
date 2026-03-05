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
    /// SameConfigIrRecoveryOptions
    /// </summary>
    [DataContract]
    public partial class SameConfigIrRecoveryOptions :  IEquatable<SameConfigIrRecoveryOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SameConfigIrRecoveryOptions" /> class.
        /// </summary>
        /// <param name="cleanupOriginalDbFiles">Whether to cleanup existing database files. If false, the adapter will perform prechecks to ensure that the customer deleted these files..</param>
        /// <param name="isSameConfigIrRecovery">Whether this is a DR recovery to the production configuration..</param>
        /// <param name="renameDatabaseAsmDirectory">Whether to rename the database ASM directory. If false, the adapter will leave the database files and continue with clone and migration of datafiles. This might cause extra files left behind on the Oracle host from the existing database instance..</param>
        public SameConfigIrRecoveryOptions(bool? cleanupOriginalDbFiles = default(bool?), bool? isSameConfigIrRecovery = default(bool?), bool? renameDatabaseAsmDirectory = default(bool?))
        {
            this.CleanupOriginalDbFiles = cleanupOriginalDbFiles;
            this.IsSameConfigIrRecovery = isSameConfigIrRecovery;
            this.RenameDatabaseAsmDirectory = renameDatabaseAsmDirectory;
            this.CleanupOriginalDbFiles = cleanupOriginalDbFiles;
            this.IsSameConfigIrRecovery = isSameConfigIrRecovery;
            this.RenameDatabaseAsmDirectory = renameDatabaseAsmDirectory;
        }
        
        /// <summary>
        /// Whether to cleanup existing database files. If false, the adapter will perform prechecks to ensure that the customer deleted these files.
        /// </summary>
        /// <value>Whether to cleanup existing database files. If false, the adapter will perform prechecks to ensure that the customer deleted these files.</value>
        [DataMember(Name="cleanupOriginalDbFiles", EmitDefaultValue=true)]
        public bool? CleanupOriginalDbFiles { get; set; }

        /// <summary>
        /// Whether this is a DR recovery to the production configuration.
        /// </summary>
        /// <value>Whether this is a DR recovery to the production configuration.</value>
        [DataMember(Name="isSameConfigIrRecovery", EmitDefaultValue=true)]
        public bool? IsSameConfigIrRecovery { get; set; }

        /// <summary>
        /// Whether to rename the database ASM directory. If false, the adapter will leave the database files and continue with clone and migration of datafiles. This might cause extra files left behind on the Oracle host from the existing database instance.
        /// </summary>
        /// <value>Whether to rename the database ASM directory. If false, the adapter will leave the database files and continue with clone and migration of datafiles. This might cause extra files left behind on the Oracle host from the existing database instance.</value>
        [DataMember(Name="renameDatabaseAsmDirectory", EmitDefaultValue=true)]
        public bool? RenameDatabaseAsmDirectory { get; set; }

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
            return this.Equals(input as SameConfigIrRecoveryOptions);
        }

        /// <summary>
        /// Returns true if SameConfigIrRecoveryOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SameConfigIrRecoveryOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SameConfigIrRecoveryOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CleanupOriginalDbFiles == input.CleanupOriginalDbFiles ||
                    (this.CleanupOriginalDbFiles != null &&
                    this.CleanupOriginalDbFiles.Equals(input.CleanupOriginalDbFiles))
                ) && 
                (
                    this.IsSameConfigIrRecovery == input.IsSameConfigIrRecovery ||
                    (this.IsSameConfigIrRecovery != null &&
                    this.IsSameConfigIrRecovery.Equals(input.IsSameConfigIrRecovery))
                ) && 
                (
                    this.RenameDatabaseAsmDirectory == input.RenameDatabaseAsmDirectory ||
                    (this.RenameDatabaseAsmDirectory != null &&
                    this.RenameDatabaseAsmDirectory.Equals(input.RenameDatabaseAsmDirectory))
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
                if (this.CleanupOriginalDbFiles != null)
                    hashCode = hashCode * 59 + this.CleanupOriginalDbFiles.GetHashCode();
                if (this.IsSameConfigIrRecovery != null)
                    hashCode = hashCode * 59 + this.IsSameConfigIrRecovery.GetHashCode();
                if (this.RenameDatabaseAsmDirectory != null)
                    hashCode = hashCode * 59 + this.RenameDatabaseAsmDirectory.GetHashCode();
                return hashCode;
            }
        }

    }

}

