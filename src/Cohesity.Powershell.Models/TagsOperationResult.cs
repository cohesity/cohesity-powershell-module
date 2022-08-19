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
    /// TagsOperationResult
    /// </summary>
    [DataContract]
    public partial class TagsOperationResult :  IEquatable<TagsOperationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsOperationResult" /> class.
        /// </summary>
        /// <param name="docErrors">DocErrors are document errors incurred in yoda service while tagging..</param>
        public TagsOperationResult(List<DocError> docErrors = default(List<DocError>))
        {
            this.DocErrors = docErrors;
            this.DocErrors = docErrors;
        }
        
        /// <summary>
        /// DocErrors are document errors incurred in yoda service while tagging.
        /// </summary>
        /// <value>DocErrors are document errors incurred in yoda service while tagging.</value>
        [DataMember(Name="docErrors", EmitDefaultValue=true)]
        public List<DocError> DocErrors { get; set; }

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
            return this.Equals(input as TagsOperationResult);
        }

        /// <summary>
        /// Returns true if TagsOperationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TagsOperationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagsOperationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocErrors == input.DocErrors ||
                    this.DocErrors != null &&
                    input.DocErrors != null &&
                    this.DocErrors.Equals(input.DocErrors)
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
                if (this.DocErrors != null)
                    hashCode = hashCode * 59 + this.DocErrors.GetHashCode();
                return hashCode;
            }
        }

    }

}

