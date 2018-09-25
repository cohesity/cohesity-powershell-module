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
    /// Specifies the list of Views returned that matched the specified filter criteria.
    /// </summary>
    [DataContract]
    public partial class GetViewsResult :  IEquatable<GetViewsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewsResult" /> class.
        /// </summary>
        /// <param name="lastResult">If false, more Views are available to return. If the number of Views to return exceeds the number of Views specified in maxCount (default of 1000) of the original GET /public/views request, the first set of Views are returned and this field returns false. To get the next set of Views, in the next GET /public/views request send the last id from the previous viewList..</param>
        /// <param name="views">Specifies the list of Views returned in this response. The list is sorted by decreasing View ids..</param>
        public GetViewsResult(bool? lastResult = default(bool?), List<View> views = default(List<View>))
        {
            this.LastResult = lastResult;
            this.Views = views;
        }
        
        /// <summary>
        /// If false, more Views are available to return. If the number of Views to return exceeds the number of Views specified in maxCount (default of 1000) of the original GET /public/views request, the first set of Views are returned and this field returns false. To get the next set of Views, in the next GET /public/views request send the last id from the previous viewList.
        /// </summary>
        /// <value>If false, more Views are available to return. If the number of Views to return exceeds the number of Views specified in maxCount (default of 1000) of the original GET /public/views request, the first set of Views are returned and this field returns false. To get the next set of Views, in the next GET /public/views request send the last id from the previous viewList.</value>
        [DataMember(Name="lastResult", EmitDefaultValue=false)]
        public bool? LastResult { get; set; }

        /// <summary>
        /// Specifies the list of Views returned in this response. The list is sorted by decreasing View ids.
        /// </summary>
        /// <value>Specifies the list of Views returned in this response. The list is sorted by decreasing View ids.</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<View> Views { get; set; }

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
            return this.Equals(input as GetViewsResult);
        }

        /// <summary>
        /// Returns true if GetViewsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetViewsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetViewsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastResult == input.LastResult ||
                    (this.LastResult != null &&
                    this.LastResult.Equals(input.LastResult))
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.LastResult != null)
                    hashCode = hashCode * 59 + this.LastResult.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

