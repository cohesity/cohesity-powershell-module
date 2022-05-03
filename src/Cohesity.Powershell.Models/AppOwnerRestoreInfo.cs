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
    /// AppOwnerRestoreInfo
    /// </summary>
    [DataContract]
    public partial class AppOwnerRestoreInfo :  IEquatable<AppOwnerRestoreInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOwnerRestoreInfo" /> class.
        /// </summary>
        /// <param name="ownerObject">ownerObject.</param>
        /// <param name="ownerRestoreParams">ownerRestoreParams.</param>
        /// <param name="performRestore">If this is set to true, then the owner object needs to be restored. The restore options that follow only apply if this field is set to true. If this field is not set, then the application objects will be restored to the original owner from where they were backed up..</param>
        public AppOwnerRestoreInfo(RestoreObject ownerObject = default(RestoreObject), RestoreObjectParams ownerRestoreParams = default(RestoreObjectParams), bool? performRestore = default(bool?))
        {
            this.OwnerObject = ownerObject;
            this.OwnerRestoreParams = ownerRestoreParams;
            this.PerformRestore = performRestore;
        }
        
        /// <summary>
        /// Gets or Sets OwnerObject
        /// </summary>
        [DataMember(Name="ownerObject", EmitDefaultValue=false)]
        public RestoreObject OwnerObject { get; set; }

        /// <summary>
        /// Gets or Sets OwnerRestoreParams
        /// </summary>
        [DataMember(Name="ownerRestoreParams", EmitDefaultValue=false)]
        public RestoreObjectParams OwnerRestoreParams { get; set; }

        /// <summary>
        /// If this is set to true, then the owner object needs to be restored. The restore options that follow only apply if this field is set to true. If this field is not set, then the application objects will be restored to the original owner from where they were backed up.
        /// </summary>
        /// <value>If this is set to true, then the owner object needs to be restored. The restore options that follow only apply if this field is set to true. If this field is not set, then the application objects will be restored to the original owner from where they were backed up.</value>
        [DataMember(Name="performRestore", EmitDefaultValue=false)]
        public bool? PerformRestore { get; set; }

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
            return this.Equals(input as AppOwnerRestoreInfo);
        }

        /// <summary>
        /// Returns true if AppOwnerRestoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AppOwnerRestoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppOwnerRestoreInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerObject == input.OwnerObject ||
                    (this.OwnerObject != null &&
                    this.OwnerObject.Equals(input.OwnerObject))
                ) && 
                (
                    this.OwnerRestoreParams == input.OwnerRestoreParams ||
                    (this.OwnerRestoreParams != null &&
                    this.OwnerRestoreParams.Equals(input.OwnerRestoreParams))
                ) && 
                (
                    this.PerformRestore == input.PerformRestore ||
                    (this.PerformRestore != null &&
                    this.PerformRestore.Equals(input.PerformRestore))
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
                if (this.OwnerObject != null)
                    hashCode = hashCode * 59 + this.OwnerObject.GetHashCode();
                if (this.OwnerRestoreParams != null)
                    hashCode = hashCode * 59 + this.OwnerRestoreParams.GetHashCode();
                if (this.PerformRestore != null)
                    hashCode = hashCode * 59 + this.PerformRestore.GetHashCode();
                return hashCode;
            }
        }

    }

}

