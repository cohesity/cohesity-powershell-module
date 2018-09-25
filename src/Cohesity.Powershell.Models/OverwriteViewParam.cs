// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// OverwriteViewParam
    /// </summary>
    [DataContract]
    public partial class OverwriteViewParam :  IEquatable<OverwriteViewParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverwriteViewParam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OverwriteViewParam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OverwriteViewParam" /> class.
        /// </summary>
        /// <param name="sourceViewName">Specifies the source view name. (required).</param>
        /// <param name="targetViewName">Specifies the target view name. (required).</param>
        public OverwriteViewParam(string sourceViewName = default(string), string targetViewName = default(string))
        {
            // to ensure "sourceViewName" is required (not null)
            if (sourceViewName == null)
            {
                throw new InvalidDataException("sourceViewName is a required property for OverwriteViewParam and cannot be null");
            }
            else
            {
                this.SourceViewName = sourceViewName;
            }
            // to ensure "targetViewName" is required (not null)
            if (targetViewName == null)
            {
                throw new InvalidDataException("targetViewName is a required property for OverwriteViewParam and cannot be null");
            }
            else
            {
                this.TargetViewName = targetViewName;
            }
        }
        
        /// <summary>
        /// Specifies the source view name.
        /// </summary>
        /// <value>Specifies the source view name.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=false)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// Specifies the target view name.
        /// </summary>
        /// <value>Specifies the target view name.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=false)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as OverwriteViewParam);
        }

        /// <summary>
        /// Returns true if OverwriteViewParam instances are equal
        /// </summary>
        /// <param name="input">Instance of OverwriteViewParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverwriteViewParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

