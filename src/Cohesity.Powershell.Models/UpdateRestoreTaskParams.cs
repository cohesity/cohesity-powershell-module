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
    /// UpdateRestoreTaskParams holds the information to update a Restore Task in Magneto.
    /// </summary>
    [DataContract]
    public partial class UpdateRestoreTaskParams :  IEquatable<UpdateRestoreTaskParams>
    {
        /// <summary>
        /// Specifies the sql options to update the Restore Task with. Specifies the action type of multi stage SQL restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.
        /// </summary>
        /// <value>Specifies the sql options to update the Restore Task with. Specifies the action type of multi stage SQL restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SqlOptionsEnum
        {
            /// <summary>
            /// Enum KCreate for value: kCreate
            /// </summary>
            [EnumMember(Value = "kCreate")]
            KCreate = 1,

            /// <summary>
            /// Enum KUpdate for value: kUpdate
            /// </summary>
            [EnumMember(Value = "kUpdate")]
            KUpdate = 2,

            /// <summary>
            /// Enum KFinalize for value: kFinalize
            /// </summary>
            [EnumMember(Value = "kFinalize")]
            KFinalize = 3

        }

        /// <summary>
        /// Specifies the sql options to update the Restore Task with. Specifies the action type of multi stage SQL restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.
        /// </summary>
        /// <value>Specifies the sql options to update the Restore Task with. Specifies the action type of multi stage SQL restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.</value>
        [DataMember(Name="sqlOptions", EmitDefaultValue=true)]
        public SqlOptionsEnum? SqlOptions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRestoreTaskParams" /> class.
        /// </summary>
        /// <param name="adOptions">adOptions.</param>
        /// <param name="enableAutoSync">Enables Auto Sync feature for SQL Multi-stage Restore task..</param>
        /// <param name="restoreTaskId">Specifies the ID of the existing Restore Task to update..</param>
        /// <param name="sqlOptions">Specifies the sql options to update the Restore Task with. Specifies the action type of multi stage SQL restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore..</param>
        public UpdateRestoreTaskParams(AdRestoreOptions adOptions = default(AdRestoreOptions), bool? enableAutoSync = default(bool?), long? restoreTaskId = default(long?), SqlOptionsEnum? sqlOptions = default(SqlOptionsEnum?))
        {
            this.EnableAutoSync = enableAutoSync;
            this.RestoreTaskId = restoreTaskId;
            this.SqlOptions = sqlOptions;
            this.AdOptions = adOptions;
            this.EnableAutoSync = enableAutoSync;
            this.RestoreTaskId = restoreTaskId;
            this.SqlOptions = sqlOptions;
        }
        
        /// <summary>
        /// Gets or Sets AdOptions
        /// </summary>
        [DataMember(Name="adOptions", EmitDefaultValue=false)]
        public AdRestoreOptions AdOptions { get; set; }

        /// <summary>
        /// Enables Auto Sync feature for SQL Multi-stage Restore task.
        /// </summary>
        /// <value>Enables Auto Sync feature for SQL Multi-stage Restore task.</value>
        [DataMember(Name="enableAutoSync", EmitDefaultValue=true)]
        public bool? EnableAutoSync { get; set; }

        /// <summary>
        /// Specifies the ID of the existing Restore Task to update.
        /// </summary>
        /// <value>Specifies the ID of the existing Restore Task to update.</value>
        [DataMember(Name="restoreTaskId", EmitDefaultValue=true)]
        public long? RestoreTaskId { get; set; }

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
            return this.Equals(input as UpdateRestoreTaskParams);
        }

        /// <summary>
        /// Returns true if UpdateRestoreTaskParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRestoreTaskParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRestoreTaskParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdOptions == input.AdOptions ||
                    (this.AdOptions != null &&
                    this.AdOptions.Equals(input.AdOptions))
                ) && 
                (
                    this.EnableAutoSync == input.EnableAutoSync ||
                    (this.EnableAutoSync != null &&
                    this.EnableAutoSync.Equals(input.EnableAutoSync))
                ) && 
                (
                    this.RestoreTaskId == input.RestoreTaskId ||
                    (this.RestoreTaskId != null &&
                    this.RestoreTaskId.Equals(input.RestoreTaskId))
                ) && 
                (
                    this.SqlOptions == input.SqlOptions ||
                    this.SqlOptions.Equals(input.SqlOptions)
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
                if (this.AdOptions != null)
                    hashCode = hashCode * 59 + this.AdOptions.GetHashCode();
                if (this.EnableAutoSync != null)
                    hashCode = hashCode * 59 + this.EnableAutoSync.GetHashCode();
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                hashCode = hashCode * 59 + this.SqlOptions.GetHashCode();
                return hashCode;
            }
        }

    }

}

