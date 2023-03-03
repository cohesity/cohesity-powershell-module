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
    /// FileStubbingParamsTargetViewData
    /// </summary>
    [DataContract]
    public partial class FileStubbingParamsTargetViewData :  IEquatable<FileStubbingParamsTargetViewData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileStubbingParamsTargetViewData" /> class.
        /// </summary>
        /// <param name="nfsMountPath">Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data..</param>
        /// <param name="targetViewName">The target view name to which the data will be migrated..</param>
        public FileStubbingParamsTargetViewData(string nfsMountPath = default(string), string targetViewName = default(string))
        {
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
            this.NfsMountPath = nfsMountPath;
            this.TargetViewName = targetViewName;
        }
        
        /// <summary>
        /// Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.
        /// </summary>
        /// <value>Mount path where the Cohesity target view must be mounted on all NFS clients for accessing the migrated data.</value>
        [DataMember(Name="nfsMountPath", EmitDefaultValue=true)]
        public string NfsMountPath { get; set; }

        /// <summary>
        /// The target view name to which the data will be migrated.
        /// </summary>
        /// <value>The target view name to which the data will be migrated.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

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
            return this.Equals(input as FileStubbingParamsTargetViewData);
        }

        /// <summary>
        /// Returns true if FileStubbingParamsTargetViewData instances are equal
        /// </summary>
        /// <param name="input">Instance of FileStubbingParamsTargetViewData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileStubbingParamsTargetViewData input)
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
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

