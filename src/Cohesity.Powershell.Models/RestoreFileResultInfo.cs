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
    /// This message captures result of restore of individual file or directory as initiated from magneto. Note, it is expected that the agents go through the \&quot;estimation\&quot; phase first for the entire batch of restore requests and then start copying. These state transitions are reflected in the \&quot;status\&quot; field here.
    /// </summary>
    [DataContract]
    public partial class RestoreFileResultInfo :  IEquatable<RestoreFileResultInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFileResultInfo" /> class.
        /// </summary>
        /// <param name="copyStats">copyStats.</param>
        /// <param name="destinationDir">This is set to the destination directory where the file/directory was copied..</param>
        /// <param name="error">error.</param>
        /// <param name="restoredFileInfo">restoredFileInfo.</param>
        /// <param name="status">Status of the restore..</param>
        public RestoreFileResultInfo(RestoreFileCopyStats copyStats = default(RestoreFileCopyStats), string destinationDir = default(string), ErrorProto error = default(ErrorProto), RestoredFileInfo restoredFileInfo = default(RestoredFileInfo), int? status = default(int?))
        {
            this.CopyStats = copyStats;
            this.DestinationDir = destinationDir;
            this.Error = error;
            this.RestoredFileInfo = restoredFileInfo;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets CopyStats
        /// </summary>
        [DataMember(Name="copyStats", EmitDefaultValue=false)]
        public RestoreFileCopyStats CopyStats { get; set; }

        /// <summary>
        /// This is set to the destination directory where the file/directory was copied.
        /// </summary>
        /// <value>This is set to the destination directory where the file/directory was copied.</value>
        [DataMember(Name="destinationDir", EmitDefaultValue=false)]
        public string DestinationDir { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Gets or Sets RestoredFileInfo
        /// </summary>
        [DataMember(Name="restoredFileInfo", EmitDefaultValue=false)]
        public RestoredFileInfo RestoredFileInfo { get; set; }

        /// <summary>
        /// Status of the restore.
        /// </summary>
        /// <value>Status of the restore.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

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
            return this.Equals(input as RestoreFileResultInfo);
        }

        /// <summary>
        /// Returns true if RestoreFileResultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFileResultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFileResultInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyStats == input.CopyStats ||
                    (this.CopyStats != null &&
                    this.CopyStats.Equals(input.CopyStats))
                ) && 
                (
                    this.DestinationDir == input.DestinationDir ||
                    (this.DestinationDir != null &&
                    this.DestinationDir.Equals(input.DestinationDir))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.RestoredFileInfo == input.RestoredFileInfo ||
                    (this.RestoredFileInfo != null &&
                    this.RestoredFileInfo.Equals(input.RestoredFileInfo))
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
                if (this.CopyStats != null)
                    hashCode = hashCode * 59 + this.CopyStats.GetHashCode();
                if (this.DestinationDir != null)
                    hashCode = hashCode * 59 + this.DestinationDir.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.RestoredFileInfo != null)
                    hashCode = hashCode * 59 + this.RestoredFileInfo.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

