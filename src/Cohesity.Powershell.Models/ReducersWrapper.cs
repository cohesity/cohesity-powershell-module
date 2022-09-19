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
    /// ReducersWrapper is the struct to define the list of reducers.
    /// </summary>
    [DataContract]
    public partial class ReducersWrapper :  IEquatable<ReducersWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReducersWrapper" /> class.
        /// </summary>
        /// <param name="reducers">Reducers specifies the list of available reducers in analytics workbench..</param>
        public ReducersWrapper(List<ReducerInfo> reducers = default(List<ReducerInfo>))
        {
            this.Reducers = reducers;
            this.Reducers = reducers;
        }
        
        /// <summary>
        /// Reducers specifies the list of available reducers in analytics workbench.
        /// </summary>
        /// <value>Reducers specifies the list of available reducers in analytics workbench.</value>
        [DataMember(Name="reducers", EmitDefaultValue=true)]
        public List<ReducerInfo> Reducers { get; set; }

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
            return this.Equals(input as ReducersWrapper);
        }

        /// <summary>
        /// Returns true if ReducersWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of ReducersWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReducersWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reducers == input.Reducers ||
                    this.Reducers != null &&
                    input.Reducers != null &&
                    this.Reducers.Equals(input.Reducers)
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
                if (this.Reducers != null)
                    hashCode = hashCode * 59 + this.Reducers.GetHashCode();
                return hashCode;
            }
        }

    }

}

