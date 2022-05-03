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
    /// RecoverVolumesTaskStateProtoTaskResult
    /// </summary>
    [DataContract]
    public partial class RecoverVolumesTaskStateProtoTaskResult :  IEquatable<RecoverVolumesTaskStateProtoTaskResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVolumesTaskStateProtoTaskResult" /> class.
        /// </summary>
        /// <param name="dstGuid">Volume GUID for the Target Entity (phy host)..</param>
        /// <param name="error">error.</param>
        /// <param name="progressMonitorTaskPath">The path relative to the root path of the restore task progress monitor..</param>
        public RecoverVolumesTaskStateProtoTaskResult(string dstGuid = default(string), ErrorProto error = default(ErrorProto), string progressMonitorTaskPath = default(string))
        {
            this.DstGuid = dstGuid;
            this.Error = error;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
        }
        
        /// <summary>
        /// Volume GUID for the Target Entity (phy host).
        /// </summary>
        /// <value>Volume GUID for the Target Entity (phy host).</value>
        [DataMember(Name="dstGuid", EmitDefaultValue=false)]
        public string DstGuid { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The path relative to the root path of the restore task progress monitor.
        /// </summary>
        /// <value>The path relative to the root path of the restore task progress monitor.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=false)]
        public string ProgressMonitorTaskPath { get; set; }

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
            return this.Equals(input as RecoverVolumesTaskStateProtoTaskResult);
        }

        /// <summary>
        /// Returns true if RecoverVolumesTaskStateProtoTaskResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVolumesTaskStateProtoTaskResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVolumesTaskStateProtoTaskResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DstGuid == input.DstGuid ||
                    (this.DstGuid != null &&
                    this.DstGuid.Equals(input.DstGuid))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
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
                if (this.DstGuid != null)
                    hashCode = hashCode * 59 + this.DstGuid.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

