// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a file path in an SMB view that has active sessions and opens.
    /// </summary>
    [DataContract]
    public partial class SmbActiveFilePath :  IEquatable<SmbActiveFilePath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbActiveFilePath" /> class.
        /// </summary>
        /// <param name="activeSessions">activeSessions.</param>
        /// <param name="filePath">Specifies the filepath in the view..</param>
        /// <param name="viewId">Specifies the id of the View assigned by the Cohesity Cluster. Either viewName or viewId must be specified..</param>
        /// <param name="viewName">Specifies the name of the View..</param>
        public SmbActiveFilePath(List<SmbActiveSession> activeSessions = default(List<SmbActiveSession>), string filePath = default(string), long? viewId = default(long?), string viewName = default(string))
        {
            this.ActiveSessions = activeSessions;
            this.FilePath = filePath;
            this.ViewId = viewId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Gets or Sets ActiveSessions
        /// </summary>
        [DataMember(Name="activeSessions", EmitDefaultValue=false)]
        public List<SmbActiveSession> ActiveSessions { get; set; }

        /// <summary>
        /// Specifies the filepath in the view.
        /// </summary>
        /// <value>Specifies the filepath in the view.</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Specifies the id of the View assigned by the Cohesity Cluster. Either viewName or viewId must be specified.
        /// </summary>
        /// <value>Specifies the id of the View assigned by the Cohesity Cluster. Either viewName or viewId must be specified.</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public long? ViewId { get; set; }

        /// <summary>
        /// Specifies the name of the View.
        /// </summary>
        /// <value>Specifies the name of the View.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as SmbActiveFilePath);
        }

        /// <summary>
        /// Returns true if SmbActiveFilePath instances are equal
        /// </summary>
        /// <param name="input">Instance of SmbActiveFilePath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmbActiveFilePath input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveSessions == input.ActiveSessions ||
                    this.ActiveSessions != null &&
                    this.ActiveSessions.SequenceEqual(input.ActiveSessions)
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.ActiveSessions != null)
                    hashCode = hashCode * 59 + this.ActiveSessions.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

