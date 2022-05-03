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
    /// Represents AD restore status for object/attribute recovery. Each ADRestoreStatus entry will contain object_info: information about the object getting restored and status: status of the restore operation. object_info is used to generate the audit information of the AD restore operations.
    /// </summary>
    [DataContract]
    public partial class ADRestoreStatus :  IEquatable<ADRestoreStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADRestoreStatus" /> class.
        /// </summary>
        /// <param name="objectInfo">objectInfo.</param>
        /// <param name="status">status.</param>
        public ADRestoreStatus(CompareADObjectsResultADObject objectInfo = default(CompareADObjectsResultADObject), ADObjectRestoreStatus status = default(ADObjectRestoreStatus))
        {
            this.ObjectInfo = objectInfo;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets ObjectInfo
        /// </summary>
        [DataMember(Name="objectInfo", EmitDefaultValue=false)]
        public CompareADObjectsResultADObject ObjectInfo { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ADObjectRestoreStatus Status { get; set; }

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
            return this.Equals(input as ADRestoreStatus);
        }

        /// <summary>
        /// Returns true if ADRestoreStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ADRestoreStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADRestoreStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    (this.ObjectInfo != null &&
                    this.ObjectInfo.Equals(input.ObjectInfo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

