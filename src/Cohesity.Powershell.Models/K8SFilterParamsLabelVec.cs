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
    /// Represents a list of all Label entity IDs that need to be present to create a positive match for the candidate volume to include.
    /// </summary>
    [DataContract]
    public partial class K8SFilterParamsLabelVec :  IEquatable<K8SFilterParamsLabelVec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="K8SFilterParamsLabelVec" /> class.
        /// </summary>
        /// <param name="labelVec">Represents a list of all Labels that need to be present to create a positive match for the candidate volume to include..</param>
        public K8SFilterParamsLabelVec(List<long> labelVec = default(List<long>))
        {
            this.LabelVec = labelVec;
            this.LabelVec = labelVec;
        }
        
        /// <summary>
        /// Represents a list of all Labels that need to be present to create a positive match for the candidate volume to include.
        /// </summary>
        /// <value>Represents a list of all Labels that need to be present to create a positive match for the candidate volume to include.</value>
        [DataMember(Name="labelVec", EmitDefaultValue=true)]
        public List<long> LabelVec { get; set; }

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
            return this.Equals(input as K8SFilterParamsLabelVec);
        }

        /// <summary>
        /// Returns true if K8SFilterParamsLabelVec instances are equal
        /// </summary>
        /// <param name="input">Instance of K8SFilterParamsLabelVec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(K8SFilterParamsLabelVec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelVec == input.LabelVec ||
                    this.LabelVec != null &&
                    input.LabelVec != null &&
                    this.LabelVec.Equals(input.LabelVec)
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
                if (this.LabelVec != null)
                    hashCode = hashCode * 59 + this.LabelVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

