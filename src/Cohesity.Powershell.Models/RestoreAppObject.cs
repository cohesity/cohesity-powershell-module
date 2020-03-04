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
    /// Message that captures information about an application object being restored.
    /// </summary>
    [DataContract]
    public partial class RestoreAppObject :  IEquatable<RestoreAppObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAppObject" /> class.
        /// </summary>
        /// <param name="additionalParams">additionalParams.</param>
        /// <param name="appEntity">appEntity.</param>
        /// <param name="displayName">The proper display name of this object in the UI, if app_entity is not empty. For example, for SQL databases the name should also include the instance name..</param>
        /// <param name="restoreParams">restoreParams.</param>
        public RestoreAppObject(RestoreTaskAdditionalParams additionalParams = default(RestoreTaskAdditionalParams), EntityProto appEntity = default(EntityProto), string displayName = default(string), RestoreAppObjectParams restoreParams = default(RestoreAppObjectParams))
        {
            this.DisplayName = displayName;
            this.AdditionalParams = additionalParams;
            this.AppEntity = appEntity;
            this.DisplayName = displayName;
            this.RestoreParams = restoreParams;
        }
        
        /// <summary>
        /// Gets or Sets AdditionalParams
        /// </summary>
        [DataMember(Name="additionalParams", EmitDefaultValue=false)]
        public RestoreTaskAdditionalParams AdditionalParams { get; set; }

        /// <summary>
        /// Gets or Sets AppEntity
        /// </summary>
        [DataMember(Name="appEntity", EmitDefaultValue=false)]
        public EntityProto AppEntity { get; set; }

        /// <summary>
        /// The proper display name of this object in the UI, if app_entity is not empty. For example, for SQL databases the name should also include the instance name.
        /// </summary>
        /// <value>The proper display name of this object in the UI, if app_entity is not empty. For example, for SQL databases the name should also include the instance name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParams
        /// </summary>
        [DataMember(Name="restoreParams", EmitDefaultValue=false)]
        public RestoreAppObjectParams RestoreParams { get; set; }

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
            return this.Equals(input as RestoreAppObject);
        }

        /// <summary>
        /// Returns true if RestoreAppObject instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAppObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAppObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalParams == input.AdditionalParams ||
                    (this.AdditionalParams != null &&
                    this.AdditionalParams.Equals(input.AdditionalParams))
                ) && 
                (
                    this.AppEntity == input.AppEntity ||
                    (this.AppEntity != null &&
                    this.AppEntity.Equals(input.AppEntity))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.AdditionalParams != null)
                    hashCode = hashCode * 59 + this.AdditionalParams.GetHashCode();
                if (this.AppEntity != null)
                    hashCode = hashCode * 59 + this.AppEntity.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.RestoreParams != null)
                    hashCode = hashCode * 59 + this.RestoreParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

