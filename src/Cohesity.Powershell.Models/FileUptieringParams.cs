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
    /// FileUptieringParams
    /// </summary>
    [DataContract]
    public partial class FileUptieringParams :  IEquatable<FileUptieringParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUptieringParams" /> class.
        /// </summary>
        /// <param name="fileSelectPolicy">File uptier policy based on file access/modify time..</param>
        /// <param name="fileSize">Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered..</param>
        /// <param name="fileSizePolicy">File size policy for selecting files to uptier..</param>
        /// <param name="hotFileWindow">Identifies the hot files in the view. Files, which are accessed in the last hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed..</param>
        /// <param name="numFileAccess">Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed..</param>
        /// <param name="sourceViewName">The source view name from which the data will be uptiered..</param>
        public FileUptieringParams(int? fileSelectPolicy = default(int?), long? fileSize = default(long?), int? fileSizePolicy = default(int?), long? hotFileWindow = default(long?), int? numFileAccess = default(int?), string sourceViewName = default(string))
        {
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.NumFileAccess = numFileAccess;
            this.SourceViewName = sourceViewName;
            this.FileSelectPolicy = fileSelectPolicy;
            this.FileSize = fileSize;
            this.FileSizePolicy = fileSizePolicy;
            this.HotFileWindow = hotFileWindow;
            this.NumFileAccess = numFileAccess;
            this.SourceViewName = sourceViewName;
        }
        
        /// <summary>
        /// File uptier policy based on file access/modify time.
        /// </summary>
        /// <value>File uptier policy based on file access/modify time.</value>
        [DataMember(Name="fileSelectPolicy", EmitDefaultValue=true)]
        public int? FileSelectPolicy { get; set; }

        /// <summary>
        /// Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered.
        /// </summary>
        /// <value>Gives the size criteria to be used for selecting the files to be uptiered. The hot files, which are greater or smaller than file_size, are uptiered.</value>
        [DataMember(Name="fileSize", EmitDefaultValue=true)]
        public long? FileSize { get; set; }

        /// <summary>
        /// File size policy for selecting files to uptier.
        /// </summary>
        /// <value>File size policy for selecting files to uptier.</value>
        [DataMember(Name="fileSizePolicy", EmitDefaultValue=true)]
        public int? FileSizePolicy { get; set; }

        /// <summary>
        /// Identifies the hot files in the view. Files, which are accessed in the last hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed.
        /// </summary>
        /// <value>Identifies the hot files in the view. Files, which are accessed in the last hot_file_window msecs, are uptiered. It is only applicable when file_select_policy is kLastAccessed.</value>
        [DataMember(Name="hotFileWindow", EmitDefaultValue=true)]
        public long? HotFileWindow { get; set; }

        /// <summary>
        /// Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed.
        /// </summary>
        /// <value>Number of times file must be accessed within hot_file_window in order to qualify for uptiering. Applicable only when file_select_policy is kLastAccessed.</value>
        [DataMember(Name="numFileAccess", EmitDefaultValue=true)]
        public int? NumFileAccess { get; set; }

        /// <summary>
        /// The source view name from which the data will be uptiered.
        /// </summary>
        /// <value>The source view name from which the data will be uptiered.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=true)]
        public string SourceViewName { get; set; }

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
            return this.Equals(input as FileUptieringParams);
        }

        /// <summary>
        /// Returns true if FileUptieringParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUptieringParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUptieringParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileSelectPolicy == input.FileSelectPolicy ||
                    (this.FileSelectPolicy != null &&
                    this.FileSelectPolicy.Equals(input.FileSelectPolicy))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.FileSizePolicy == input.FileSizePolicy ||
                    (this.FileSizePolicy != null &&
                    this.FileSizePolicy.Equals(input.FileSizePolicy))
                ) && 
                (
                    this.HotFileWindow == input.HotFileWindow ||
                    (this.HotFileWindow != null &&
                    this.HotFileWindow.Equals(input.HotFileWindow))
                ) && 
                (
                    this.NumFileAccess == input.NumFileAccess ||
                    (this.NumFileAccess != null &&
                    this.NumFileAccess.Equals(input.NumFileAccess))
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
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
                if (this.FileSelectPolicy != null)
                    hashCode = hashCode * 59 + this.FileSelectPolicy.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileSizePolicy != null)
                    hashCode = hashCode * 59 + this.FileSizePolicy.GetHashCode();
                if (this.HotFileWindow != null)
                    hashCode = hashCode * 59 + this.HotFileWindow.GetHashCode();
                if (this.NumFileAccess != null)
                    hashCode = hashCode * 59 + this.NumFileAccess.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

