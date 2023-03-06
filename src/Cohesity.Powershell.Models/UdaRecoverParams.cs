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
    /// UdaRecoverParams
    /// </summary>
    [DataContract]
    public partial class UdaRecoverParams :  IEquatable<UdaRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaRecoverParams" /> class.
        /// </summary>
        /// <param name="logViewName">If the restore has logs to be replayed, &#39;log_view_name&#39; contains the name of log backup view to be mounted on the host..</param>
        /// <param name="restoreObjects">restoreObjects.</param>
        /// <param name="viewBoxId">The view box where log backed up data has been saved..</param>
        public UdaRecoverParams(string logViewName = default(string), List<UdaRestoreObject> restoreObjects = default(List<UdaRestoreObject>), long? viewBoxId = default(long?))
        {
            this.LogViewName = logViewName;
            this.RestoreObjects = restoreObjects;
            this.ViewBoxId = viewBoxId;
            this.LogViewName = logViewName;
            this.RestoreObjects = restoreObjects;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// If the restore has logs to be replayed, &#39;log_view_name&#39; contains the name of log backup view to be mounted on the host.
        /// </summary>
        /// <value>If the restore has logs to be replayed, &#39;log_view_name&#39; contains the name of log backup view to be mounted on the host.</value>
        [DataMember(Name="logViewName", EmitDefaultValue=true)]
        public string LogViewName { get; set; }

        /// <summary>
        /// Gets or Sets RestoreObjects
        /// </summary>
        [DataMember(Name="restoreObjects", EmitDefaultValue=true)]
        public List<UdaRestoreObject> RestoreObjects { get; set; }

        /// <summary>
        /// The view box where log backed up data has been saved.
        /// </summary>
        /// <value>The view box where log backed up data has been saved.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as UdaRecoverParams);
        }

        /// <summary>
        /// Returns true if UdaRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogViewName == input.LogViewName ||
                    (this.LogViewName != null &&
                    this.LogViewName.Equals(input.LogViewName))
                ) && 
                (
                    this.RestoreObjects == input.RestoreObjects ||
                    this.RestoreObjects != null &&
                    input.RestoreObjects != null &&
                    this.RestoreObjects.SequenceEqual(input.RestoreObjects)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.LogViewName != null)
                    hashCode = hashCode * 59 + this.LogViewName.GetHashCode();
                if (this.RestoreObjects != null)
                    hashCode = hashCode * 59 + this.RestoreObjects.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}

