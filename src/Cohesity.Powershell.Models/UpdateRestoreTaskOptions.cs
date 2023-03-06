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
    /// UpdateRestoreTaskOptions holds the common information needed for updating a restore task.
    /// </summary>
    [DataContract]
    public partial class UpdateRestoreTaskOptions :  IEquatable<UpdateRestoreTaskOptions>
    {
        /// <summary>
        /// Specifies the multi-stage options to update the Restore Task with. Specifies the action type of multi stage restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.
        /// </summary>
        /// <value>Specifies the multi-stage options to update the Restore Task with. Specifies the action type of multi stage restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MultiStageRestoreActionEnum
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
        /// Specifies the multi-stage options to update the Restore Task with. Specifies the action type of multi stage restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.
        /// </summary>
        /// <value>Specifies the multi-stage options to update the Restore Task with. Specifies the action type of multi stage restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore.</value>
        [DataMember(Name="multiStageRestoreAction", EmitDefaultValue=true)]
        public MultiStageRestoreActionEnum? MultiStageRestoreAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRestoreTaskOptions" /> class.
        /// </summary>
        /// <param name="multiStageFinalizeParams">multiStageFinalizeParams.</param>
        /// <param name="multiStageRestoreAction">Specifies the multi-stage options to update the Restore Task with. Specifies the action type of multi stage restore.  &#39;kCreate&#39; specifies the create action for a restore. &#39;kUpdate&#39; specifies the user action to update an ongoing restore. &#39;kFinalize&#39; specifies the user action to finalize a restore..</param>
        public UpdateRestoreTaskOptions(MultiStageRestoreFinalizeActionParams multiStageFinalizeParams = default(MultiStageRestoreFinalizeActionParams), MultiStageRestoreActionEnum? multiStageRestoreAction = default(MultiStageRestoreActionEnum?))
        {
            this.MultiStageRestoreAction = multiStageRestoreAction;
            this.MultiStageFinalizeParams = multiStageFinalizeParams;
            this.MultiStageRestoreAction = multiStageRestoreAction;
        }
        
        /// <summary>
        /// Gets or Sets MultiStageFinalizeParams
        /// </summary>
        [DataMember(Name="multiStageFinalizeParams", EmitDefaultValue=false)]
        public MultiStageRestoreFinalizeActionParams MultiStageFinalizeParams { get; set; }

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
            return this.Equals(input as UpdateRestoreTaskOptions);
        }

        /// <summary>
        /// Returns true if UpdateRestoreTaskOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRestoreTaskOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRestoreTaskOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MultiStageFinalizeParams == input.MultiStageFinalizeParams ||
                    (this.MultiStageFinalizeParams != null &&
                    this.MultiStageFinalizeParams.Equals(input.MultiStageFinalizeParams))
                ) && 
                (
                    this.MultiStageRestoreAction == input.MultiStageRestoreAction ||
                    this.MultiStageRestoreAction.Equals(input.MultiStageRestoreAction)
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
                if (this.MultiStageFinalizeParams != null)
                    hashCode = hashCode * 59 + this.MultiStageFinalizeParams.GetHashCode();
                hashCode = hashCode * 59 + this.MultiStageRestoreAction.GetHashCode();
                return hashCode;
            }
        }

    }

}

