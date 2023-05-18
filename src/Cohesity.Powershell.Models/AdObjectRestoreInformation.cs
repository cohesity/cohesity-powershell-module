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
    /// Represents the details about the restore of the AD object.
    /// </summary>
    [DataContract]
    public partial class AdObjectRestoreInformation :  IEquatable<AdObjectRestoreInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdObjectRestoreInformation" /> class.
        /// </summary>
        /// <param name="attributeRestoreInfo">Specifies the list of attributes of the AD object whose restore failed..</param>
        /// <param name="errorMessage">Specifies the error message while restoring the AD Object..</param>
        /// <param name="name">Specifies the name of the AD object..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the restore of the AD object specified as a Unix epoch Timestamp(in microseconds)..</param>
        /// <param name="timeTakenMsecs">Specifies the time taken for restore of AD Object and its attributes in milliseconds..</param>
        public AdObjectRestoreInformation(List<AttributeRestoreInformation> attributeRestoreInfo = default(List<AttributeRestoreInformation>), string errorMessage = default(string), string name = default(string), long? startTimeUsecs = default(long?), int? timeTakenMsecs = default(int?))
        {
            this.AttributeRestoreInfo = attributeRestoreInfo;
            this.ErrorMessage = errorMessage;
            this.Name = name;
            this.StartTimeUsecs = startTimeUsecs;
            this.TimeTakenMsecs = timeTakenMsecs;
            this.AttributeRestoreInfo = attributeRestoreInfo;
            this.ErrorMessage = errorMessage;
            this.Name = name;
            this.StartTimeUsecs = startTimeUsecs;
            this.TimeTakenMsecs = timeTakenMsecs;
        }
        
        /// <summary>
        /// Specifies the list of attributes of the AD object whose restore failed.
        /// </summary>
        /// <value>Specifies the list of attributes of the AD object whose restore failed.</value>
        [DataMember(Name="attributeRestoreInfo", EmitDefaultValue=true)]
        public List<AttributeRestoreInformation> AttributeRestoreInfo { get; set; }

        /// <summary>
        /// Specifies the error message while restoring the AD Object.
        /// </summary>
        /// <value>Specifies the error message while restoring the AD Object.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the name of the AD object.
        /// </summary>
        /// <value>Specifies the name of the AD object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the start time of the restore of the AD object specified as a Unix epoch Timestamp(in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the restore of the AD object specified as a Unix epoch Timestamp(in microseconds).</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the time taken for restore of AD Object and its attributes in milliseconds.
        /// </summary>
        /// <value>Specifies the time taken for restore of AD Object and its attributes in milliseconds.</value>
        [DataMember(Name="timeTakenMsecs", EmitDefaultValue=true)]
        public int? TimeTakenMsecs { get; set; }

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
            return this.Equals(input as AdObjectRestoreInformation);
        }

        /// <summary>
        /// Returns true if AdObjectRestoreInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of AdObjectRestoreInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdObjectRestoreInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeRestoreInfo == input.AttributeRestoreInfo ||
                    this.AttributeRestoreInfo != null &&
                    input.AttributeRestoreInfo != null &&
                    this.AttributeRestoreInfo.SequenceEqual(input.AttributeRestoreInfo)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.TimeTakenMsecs == input.TimeTakenMsecs ||
                    (this.TimeTakenMsecs != null &&
                    this.TimeTakenMsecs.Equals(input.TimeTakenMsecs))
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
                if (this.AttributeRestoreInfo != null)
                    hashCode = hashCode * 59 + this.AttributeRestoreInfo.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.TimeTakenMsecs != null)
                    hashCode = hashCode * 59 + this.TimeTakenMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

