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
    /// SfdcRestoreObject
    /// </summary>
    [DataContract]
    public partial class SfdcRestoreObject :  IEquatable<SfdcRestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcRestoreObject" /> class.
        /// </summary>
        /// <param name="entityId">Magneto Entity id. If this is set, object_name/object_uuid should be empty..</param>
        /// <param name="objectName">The original name of the object to be restored..</param>
        /// <param name="restoreParams">restoreParams.</param>
        public SfdcRestoreObject(long? entityId = default(long?), string objectName = default(string), SfdcRestoreObjectParams restoreParams = default(SfdcRestoreObjectParams))
        {
            this.EntityId = entityId;
            this.ObjectName = objectName;
            this.EntityId = entityId;
            this.ObjectName = objectName;
            this.RestoreParams = restoreParams;
        }
        
        /// <summary>
        /// Magneto Entity id. If this is set, object_name/object_uuid should be empty.
        /// </summary>
        /// <value>Magneto Entity id. If this is set, object_name/object_uuid should be empty.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The original name of the object to be restored.
        /// </summary>
        /// <value>The original name of the object to be restored.</value>
        [DataMember(Name="objectName", EmitDefaultValue=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParams
        /// </summary>
        [DataMember(Name="restoreParams", EmitDefaultValue=false)]
        public SfdcRestoreObjectParams RestoreParams { get; set; }

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
            return this.Equals(input as SfdcRestoreObject);
        }

        /// <summary>
        /// Returns true if SfdcRestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcRestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcRestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.ObjectName == input.ObjectName ||
                    (this.ObjectName != null &&
                    this.ObjectName.Equals(input.ObjectName))
                ) && 
                (
                    this.RestoreParams == input.RestoreParams ||
                    (this.RestoreParams != null &&
                    this.RestoreParams.Equals(input.RestoreParams))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.ObjectName != null)
                    hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.RestoreParams != null)
                    hashCode = hashCode * 59 + this.RestoreParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

