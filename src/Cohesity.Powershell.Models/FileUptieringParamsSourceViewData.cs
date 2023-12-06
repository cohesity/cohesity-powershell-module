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
    /// FileUptieringParamsSourceViewData
    /// </summary>
    [DataContract]
    public partial class FileUptieringParamsSourceViewData :  IEquatable<FileUptieringParamsSourceViewData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUptieringParamsSourceViewData" /> class.
        /// </summary>
        /// <param name="nfsMountPath">Mount path where the Cohesity view must be mounted on all NFS clients while migrating the data..</param>
        /// <param name="sourceViewName">The source view name from which the data will be uptiered..</param>
        public FileUptieringParamsSourceViewData(string nfsMountPath = default(string), string sourceViewName = default(string))
        {
            this.NfsMountPath = nfsMountPath;
            this.SourceViewName = sourceViewName;
            this.NfsMountPath = nfsMountPath;
            this.SourceViewName = sourceViewName;
        }
        
        /// <summary>
        /// Mount path where the Cohesity view must be mounted on all NFS clients while migrating the data.
        /// </summary>
        /// <value>Mount path where the Cohesity view must be mounted on all NFS clients while migrating the data.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

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
            return this.Equals(input as FileUptieringParamsSourceViewData);
        }

        /// <summary>
        /// Returns true if FileUptieringParamsSourceViewData instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUptieringParamsSourceViewData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUptieringParamsSourceViewData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NfsMountPath == input.NfsMountPath ||
                    (this.NfsMountPath != null &&
                    this.NfsMountPath.Equals(input.NfsMountPath))
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
                if (this.NfsMountPath != null)
                    hashCode = hashCode * 59 + this.NfsMountPath.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

