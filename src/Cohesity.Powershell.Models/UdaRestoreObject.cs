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
    /// UdaRestoreObject
    /// </summary>
    [DataContract]
    public partial class UdaRestoreObject :  IEquatable<UdaRestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaRestoreObject" /> class.
        /// </summary>
        /// <param name="entityId">Magneto Entity id. If this is set, object_name/object_uuid should be empty..</param>
        /// <param name="objectName">The original name of the object to be restored..</param>
        /// <param name="objectUuid">The UUID of the object to be restored..</param>
        /// <param name="restoreParams">restoreParams.</param>
        public UdaRestoreObject(long? entityId = default(long?), string objectName = default(string), string objectUuid = default(string), UdaRestoreObjectParams restoreParams = default(UdaRestoreObjectParams))
        {
            this.EntityId = entityId;
            this.ObjectName = objectName;
            this.ObjectUuid = objectUuid;
            this.EntityId = entityId;
            this.ObjectName = objectName;
            this.ObjectUuid = objectUuid;
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
        /// The UUID of the object to be restored.
        /// </summary>
        /// <value>The UUID of the object to be restored.</value>
        [DataMember(Name="objectUuid", EmitDefaultValue=true)]
        public string ObjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParams
        /// </summary>
        [DataMember(Name="restoreParams", EmitDefaultValue=false)]
        public UdaRestoreObjectParams RestoreParams { get; set; }

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
            return this.Equals(input as UdaRestoreObject);
        }

        /// <summary>
        /// Returns true if UdaRestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaRestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaRestoreObject input)
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
                    this.ObjectUuid == input.ObjectUuid ||
                    (this.ObjectUuid != null &&
                    this.ObjectUuid.Equals(input.ObjectUuid))
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
                if (this.ObjectUuid != null)
                    hashCode = hashCode * 59 + this.ObjectUuid.GetHashCode();
                if (this.RestoreParams != null)
                    hashCode = hashCode * 59 + this.RestoreParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

