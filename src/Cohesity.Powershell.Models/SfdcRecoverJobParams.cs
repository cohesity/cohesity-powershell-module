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
    /// SfdcRecoverJobParams
    /// </summary>
    [DataContract]
    public partial class SfdcRecoverJobParams :  IEquatable<SfdcRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcRecoverJobParams" /> class.
        /// </summary>
        /// <param name="overwrite">Whether to overwrite or keep the object if the object being recovered already exists in the destination..</param>
        /// <param name="restoreChildsObjectVec">restoreChildsObjectVec.</param>
        /// <param name="restoreParentObjectVec">List of parent/child objects that need to be restored..</param>
        /// <param name="runStartTimeUsecs">The time when the corresponding backup run was started..</param>
        public SfdcRecoverJobParams(bool? overwrite = default(bool?), List<string> restoreChildsObjectVec = default(List<string>), List<string> restoreParentObjectVec = default(List<string>), long? runStartTimeUsecs = default(long?))
        {
            this.Overwrite = overwrite;
            this.RestoreChildsObjectVec = restoreChildsObjectVec;
            this.RestoreParentObjectVec = restoreParentObjectVec;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.Overwrite = overwrite;
            this.RestoreChildsObjectVec = restoreChildsObjectVec;
            this.RestoreParentObjectVec = restoreParentObjectVec;
            this.RunStartTimeUsecs = runStartTimeUsecs;
        }
        
        /// <summary>
        /// Whether to overwrite or keep the object if the object being recovered already exists in the destination.
        /// </summary>
        /// <value>Whether to overwrite or keep the object if the object being recovered already exists in the destination.</value>
        [DataMember(Name="overwrite", EmitDefaultValue=true)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Gets or Sets RestoreChildsObjectVec
        /// </summary>
        [DataMember(Name="restoreChildsObjectVec", EmitDefaultValue=true)]
        public List<string> RestoreChildsObjectVec { get; set; }

        /// <summary>
        /// List of parent/child objects that need to be restored.
        /// </summary>
        /// <value>List of parent/child objects that need to be restored.</value>
        [DataMember(Name="restoreParentObjectVec", EmitDefaultValue=true)]
        public List<string> RestoreParentObjectVec { get; set; }

        /// <summary>
        /// The time when the corresponding backup run was started.
        /// </summary>
        /// <value>The time when the corresponding backup run was started.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=true)]
        public long? RunStartTimeUsecs { get; set; }

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
            return this.Equals(input as SfdcRecoverJobParams);
        }

        /// <summary>
        /// Returns true if SfdcRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
                ) && 
                (
                    this.RestoreChildsObjectVec == input.RestoreChildsObjectVec ||
                    this.RestoreChildsObjectVec != null &&
                    input.RestoreChildsObjectVec != null &&
                    this.RestoreChildsObjectVec.SequenceEqual(input.RestoreChildsObjectVec)
                ) && 
                (
                    this.RestoreParentObjectVec == input.RestoreParentObjectVec ||
                    this.RestoreParentObjectVec != null &&
                    input.RestoreParentObjectVec != null &&
                    this.RestoreParentObjectVec.SequenceEqual(input.RestoreParentObjectVec)
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
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
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.RestoreChildsObjectVec != null)
                    hashCode = hashCode * 59 + this.RestoreChildsObjectVec.GetHashCode();
                if (this.RestoreParentObjectVec != null)
                    hashCode = hashCode * 59 + this.RestoreParentObjectVec.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

