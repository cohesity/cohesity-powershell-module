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
    /// SqlUpdateRestoreTaskOptions
    /// </summary>
    [DataContract]
    public partial class SqlUpdateRestoreTaskOptions :  IEquatable<SqlUpdateRestoreTaskOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlUpdateRestoreTaskOptions" /> class.
        /// </summary>
        /// <param name="enableAutoSync">Enable/Disable auto_sync for db migration.</param>
        /// <param name="multiStageRestoreAction">This field is set if we are performing an action on a multi-stage SQL restore..</param>
        public SqlUpdateRestoreTaskOptions(bool? enableAutoSync = default(bool?), int? multiStageRestoreAction = default(int?))
        {
            this.EnableAutoSync = enableAutoSync;
            this.MultiStageRestoreAction = multiStageRestoreAction;
            this.EnableAutoSync = enableAutoSync;
            this.MultiStageRestoreAction = multiStageRestoreAction;
        }
        
        /// <summary>
        /// Enable/Disable auto_sync for db migration
        /// </summary>
        /// <value>Enable/Disable auto_sync for db migration</value>
        [DataMember(Name="enableAutoSync", EmitDefaultValue=true)]
        public bool? EnableAutoSync { get; set; }

        /// <summary>
        /// This field is set if we are performing an action on a multi-stage SQL restore.
        /// </summary>
        /// <value>This field is set if we are performing an action on a multi-stage SQL restore.</value>
        [DataMember(Name="multiStageRestoreAction", EmitDefaultValue=true)]
        public int? MultiStageRestoreAction { get; set; }

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
            return this.Equals(input as SqlUpdateRestoreTaskOptions);
        }

        /// <summary>
        /// Returns true if SqlUpdateRestoreTaskOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlUpdateRestoreTaskOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlUpdateRestoreTaskOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableAutoSync == input.EnableAutoSync ||
                    (this.EnableAutoSync != null &&
                    this.EnableAutoSync.Equals(input.EnableAutoSync))
                ) && 
                (
                    this.MultiStageRestoreAction == input.MultiStageRestoreAction ||
                    (this.MultiStageRestoreAction != null &&
                    this.MultiStageRestoreAction.Equals(input.MultiStageRestoreAction))
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
                if (this.EnableAutoSync != null)
                    hashCode = hashCode * 59 + this.EnableAutoSync.GetHashCode();
                if (this.MultiStageRestoreAction != null)
                    hashCode = hashCode * 59 + this.MultiStageRestoreAction.GetHashCode();
                return hashCode;
            }
        }

    }

}

