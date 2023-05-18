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
    /// NodeDeleteResult specifies response for mark node for removal
    /// </summary>
    [DataContract]
    public partial class NodeDeleteResult :  IEquatable<NodeDeleteResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeDeleteResult" /> class.
        /// </summary>
        /// <param name="id">Id of the node to be marked for deletion..</param>
        /// <param name="markNodeForRemoval">MarkNodeForRemoval indicates if the node is marked for removal.</param>
        /// <param name="timestampSecs">TimestampSecs specifies the last run time of the pre-checks execution in Unix epoch timestamp in seconds.</param>
        /// <param name="validationChecks">ValidationChecks specifies list of pre-check validations.</param>
        public NodeDeleteResult(long? id = default(long?), bool? markNodeForRemoval = default(bool?), long? timestampSecs = default(long?), List<PreCheckValidation> validationChecks = default(List<PreCheckValidation>))
        {
            this.Id = id;
            this.MarkNodeForRemoval = markNodeForRemoval;
            this.TimestampSecs = timestampSecs;
            this.ValidationChecks = validationChecks;
            this.Id = id;
            this.MarkNodeForRemoval = markNodeForRemoval;
            this.TimestampSecs = timestampSecs;
            this.ValidationChecks = validationChecks;
        }
        
        /// <summary>
        /// Id of the node to be marked for deletion.
        /// </summary>
        /// <value>Id of the node to be marked for deletion.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// MarkNodeForRemoval indicates if the node is marked for removal
        /// </summary>
        /// <value>MarkNodeForRemoval indicates if the node is marked for removal</value>
        [DataMember(Name="markNodeForRemoval", EmitDefaultValue=true)]
        public bool? MarkNodeForRemoval { get; set; }

        /// <summary>
        /// TimestampSecs specifies the last run time of the pre-checks execution in Unix epoch timestamp in seconds
        /// </summary>
        /// <value>TimestampSecs specifies the last run time of the pre-checks execution in Unix epoch timestamp in seconds</value>
        [DataMember(Name="timestampSecs", EmitDefaultValue=true)]
        public long? TimestampSecs { get; set; }

        /// <summary>
        /// ValidationChecks specifies list of pre-check validations
        /// </summary>
        /// <value>ValidationChecks specifies list of pre-check validations</value>
        [DataMember(Name="validationChecks", EmitDefaultValue=true)]
        public List<PreCheckValidation> ValidationChecks { get; set; }

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
            return this.Equals(input as NodeDeleteResult);
        }

        /// <summary>
        /// Returns true if NodeDeleteResult instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeDeleteResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeDeleteResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MarkNodeForRemoval == input.MarkNodeForRemoval ||
                    (this.MarkNodeForRemoval != null &&
                    this.MarkNodeForRemoval.Equals(input.MarkNodeForRemoval))
                ) && 
                (
                    this.TimestampSecs == input.TimestampSecs ||
                    (this.TimestampSecs != null &&
                    this.TimestampSecs.Equals(input.TimestampSecs))
                ) && 
                (
                    this.ValidationChecks == input.ValidationChecks ||
                    this.ValidationChecks != null &&
                    input.ValidationChecks != null &&
                    this.ValidationChecks.SequenceEqual(input.ValidationChecks)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MarkNodeForRemoval != null)
                    hashCode = hashCode * 59 + this.MarkNodeForRemoval.GetHashCode();
                if (this.TimestampSecs != null)
                    hashCode = hashCode * 59 + this.TimestampSecs.GetHashCode();
                if (this.ValidationChecks != null)
                    hashCode = hashCode * 59 + this.ValidationChecks.GetHashCode();
                return hashCode;
            }
        }

    }

}

