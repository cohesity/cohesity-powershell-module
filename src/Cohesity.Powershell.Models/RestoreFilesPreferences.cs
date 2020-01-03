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
    /// This message captures preferences from the user while restoring the files on the target.
    /// </summary>
    [DataContract]
    public partial class RestoreFilesPreferences :  IEquatable<RestoreFilesPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesPreferences" /> class.
        /// </summary>
        /// <param name="alternateRestoreBaseDirectory">This must be set to a directory path if restore_to_original_paths is false. All the files and directories restored will be restored under this location..</param>
        /// <param name="continueOnError">Whether to continue with the copy in case of encountering an error..</param>
        /// <param name="generateSshKeys">In case of GCP Linux restores, whether to generate ssh keys to connect to the customer&#39;s instance..</param>
        /// <param name="overrideOriginals">This is relevant only if restore_to_original_paths is true. If this is true, then already existing files will be overridden, otherwise new files will be skipped..</param>
        /// <param name="preserveAcls">Whether to preserve the ACLs of the original file..</param>
        /// <param name="preserveAttributes">Whether to preserve the original attributes..</param>
        /// <param name="preserveTimestamps">Whether to preserve the original time stamps..</param>
        /// <param name="restoreToOriginalPaths">If this is true, then files will be restored to original paths..</param>
        /// <param name="skipEstimation">Whether to skip the estimation step..</param>
        public RestoreFilesPreferences(string alternateRestoreBaseDirectory = default(string), bool? continueOnError = default(bool?), bool? generateSshKeys = default(bool?), bool? overrideOriginals = default(bool?), bool? preserveAcls = default(bool?), bool? preserveAttributes = default(bool?), bool? preserveTimestamps = default(bool?), bool? restoreToOriginalPaths = default(bool?), bool? skipEstimation = default(bool?))
        {
            this.AlternateRestoreBaseDirectory = alternateRestoreBaseDirectory;
            this.ContinueOnError = continueOnError;
            this.GenerateSshKeys = generateSshKeys;
            this.OverrideOriginals = overrideOriginals;
            this.PreserveAcls = preserveAcls;
            this.PreserveAttributes = preserveAttributes;
            this.PreserveTimestamps = preserveTimestamps;
            this.RestoreToOriginalPaths = restoreToOriginalPaths;
            this.SkipEstimation = skipEstimation;
            this.AlternateRestoreBaseDirectory = alternateRestoreBaseDirectory;
            this.ContinueOnError = continueOnError;
            this.GenerateSshKeys = generateSshKeys;
            this.OverrideOriginals = overrideOriginals;
            this.PreserveAcls = preserveAcls;
            this.PreserveAttributes = preserveAttributes;
            this.PreserveTimestamps = preserveTimestamps;
            this.RestoreToOriginalPaths = restoreToOriginalPaths;
            this.SkipEstimation = skipEstimation;
        }
        
        /// <summary>
        /// This must be set to a directory path if restore_to_original_paths is false. All the files and directories restored will be restored under this location.
        /// </summary>
        /// <value>This must be set to a directory path if restore_to_original_paths is false. All the files and directories restored will be restored under this location.</value>
        [DataMember(Name="alternateRestoreBaseDirectory", EmitDefaultValue=true)]
        public string AlternateRestoreBaseDirectory { get; set; }

        /// <summary>
        /// Whether to continue with the copy in case of encountering an error.
        /// </summary>
        /// <value>Whether to continue with the copy in case of encountering an error.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// In case of GCP Linux restores, whether to generate ssh keys to connect to the customer&#39;s instance.
        /// </summary>
        /// <value>In case of GCP Linux restores, whether to generate ssh keys to connect to the customer&#39;s instance.</value>
        [DataMember(Name="generateSshKeys", EmitDefaultValue=true)]
        public bool? GenerateSshKeys { get; set; }

        /// <summary>
        /// This is relevant only if restore_to_original_paths is true. If this is true, then already existing files will be overridden, otherwise new files will be skipped.
        /// </summary>
        /// <value>This is relevant only if restore_to_original_paths is true. If this is true, then already existing files will be overridden, otherwise new files will be skipped.</value>
        [DataMember(Name="overrideOriginals", EmitDefaultValue=true)]
        public bool? OverrideOriginals { get; set; }

        /// <summary>
        /// Whether to preserve the ACLs of the original file.
        /// </summary>
        /// <value>Whether to preserve the ACLs of the original file.</value>
        [DataMember(Name="preserveAcls", EmitDefaultValue=true)]
        public bool? PreserveAcls { get; set; }

        /// <summary>
        /// Whether to preserve the original attributes.
        /// </summary>
        /// <value>Whether to preserve the original attributes.</value>
        [DataMember(Name="preserveAttributes", EmitDefaultValue=true)]
        public bool? PreserveAttributes { get; set; }

        /// <summary>
        /// Whether to preserve the original time stamps.
        /// </summary>
        /// <value>Whether to preserve the original time stamps.</value>
        [DataMember(Name="preserveTimestamps", EmitDefaultValue=true)]
        public bool? PreserveTimestamps { get; set; }

        /// <summary>
        /// If this is true, then files will be restored to original paths.
        /// </summary>
        /// <value>If this is true, then files will be restored to original paths.</value>
        [DataMember(Name="restoreToOriginalPaths", EmitDefaultValue=true)]
        public bool? RestoreToOriginalPaths { get; set; }

        /// <summary>
        /// Whether to skip the estimation step.
        /// </summary>
        /// <value>Whether to skip the estimation step.</value>
        [DataMember(Name="skipEstimation", EmitDefaultValue=true)]
        public bool? SkipEstimation { get; set; }

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
            return this.Equals(input as RestoreFilesPreferences);
        }

        /// <summary>
        /// Returns true if RestoreFilesPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlternateRestoreBaseDirectory == input.AlternateRestoreBaseDirectory ||
                    (this.AlternateRestoreBaseDirectory != null &&
                    this.AlternateRestoreBaseDirectory.Equals(input.AlternateRestoreBaseDirectory))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.GenerateSshKeys == input.GenerateSshKeys ||
                    (this.GenerateSshKeys != null &&
                    this.GenerateSshKeys.Equals(input.GenerateSshKeys))
                ) && 
                (
                    this.OverrideOriginals == input.OverrideOriginals ||
                    (this.OverrideOriginals != null &&
                    this.OverrideOriginals.Equals(input.OverrideOriginals))
                ) && 
                (
                    this.PreserveAcls == input.PreserveAcls ||
                    (this.PreserveAcls != null &&
                    this.PreserveAcls.Equals(input.PreserveAcls))
                ) && 
                (
                    this.PreserveAttributes == input.PreserveAttributes ||
                    (this.PreserveAttributes != null &&
                    this.PreserveAttributes.Equals(input.PreserveAttributes))
                ) && 
                (
                    this.PreserveTimestamps == input.PreserveTimestamps ||
                    (this.PreserveTimestamps != null &&
                    this.PreserveTimestamps.Equals(input.PreserveTimestamps))
                ) && 
                (
                    this.RestoreToOriginalPaths == input.RestoreToOriginalPaths ||
                    (this.RestoreToOriginalPaths != null &&
                    this.RestoreToOriginalPaths.Equals(input.RestoreToOriginalPaths))
                ) && 
                (
                    this.SkipEstimation == input.SkipEstimation ||
                    (this.SkipEstimation != null &&
                    this.SkipEstimation.Equals(input.SkipEstimation))
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
                if (this.AlternateRestoreBaseDirectory != null)
                    hashCode = hashCode * 59 + this.AlternateRestoreBaseDirectory.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.GenerateSshKeys != null)
                    hashCode = hashCode * 59 + this.GenerateSshKeys.GetHashCode();
                if (this.OverrideOriginals != null)
                    hashCode = hashCode * 59 + this.OverrideOriginals.GetHashCode();
                if (this.PreserveAcls != null)
                    hashCode = hashCode * 59 + this.PreserveAcls.GetHashCode();
                if (this.PreserveAttributes != null)
                    hashCode = hashCode * 59 + this.PreserveAttributes.GetHashCode();
                if (this.PreserveTimestamps != null)
                    hashCode = hashCode * 59 + this.PreserveTimestamps.GetHashCode();
                if (this.RestoreToOriginalPaths != null)
                    hashCode = hashCode * 59 + this.RestoreToOriginalPaths.GetHashCode();
                if (this.SkipEstimation != null)
                    hashCode = hashCode * 59 + this.SkipEstimation.GetHashCode();
                return hashCode;
            }
        }

    }

}

