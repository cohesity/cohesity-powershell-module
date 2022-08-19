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
    /// MultiStageRestoreFinalizeActionParams holds the parameters required for finalizing a multi-stage restore task.
    /// </summary>
    [DataContract]
    public partial class MultiStageRestoreFinalizeActionParams :  IEquatable<MultiStageRestoreFinalizeActionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiStageRestoreFinalizeActionParams" /> class.
        /// </summary>
        /// <param name="powerOnTarget">Specifies the power state of the recovered object at the end of the multi-stage restore..</param>
        public MultiStageRestoreFinalizeActionParams(bool? powerOnTarget = default(bool?))
        {
            this.PowerOnTarget = powerOnTarget;
            this.PowerOnTarget = powerOnTarget;
        }
        
        /// <summary>
        /// Specifies the power state of the recovered object at the end of the multi-stage restore.
        /// </summary>
        /// <value>Specifies the power state of the recovered object at the end of the multi-stage restore.</value>
        [DataMember(Name="powerOnTarget", EmitDefaultValue=true)]
        public bool? PowerOnTarget { get; set; }

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
            return this.Equals(input as MultiStageRestoreFinalizeActionParams);
        }

        /// <summary>
        /// Returns true if MultiStageRestoreFinalizeActionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiStageRestoreFinalizeActionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiStageRestoreFinalizeActionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PowerOnTarget == input.PowerOnTarget ||
                    (this.PowerOnTarget != null &&
                    this.PowerOnTarget.Equals(input.PowerOnTarget))
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
                if (this.PowerOnTarget != null)
                    hashCode = hashCode * 59 + this.PowerOnTarget.GetHashCode();
                return hashCode;
            }
        }

    }

}

