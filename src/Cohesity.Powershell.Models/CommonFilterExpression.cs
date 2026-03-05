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
    /// Message containing common params for filtering. This message is in the form of expression and complex expressions can be supported by adding more operations. Each expression contains exactly one of the fields - either a filter_policy which is a leaf node in the expression tree or one of the expression fields which will be intermediate nodes in the expression tree. The actual filter policies will only be specified at the leaf level of the expression. The common evaluation logic for the expression is defined in DoesFilterExpressionMatch in magneto/base/util.h which can be extended as required when more expression fields are added.
    /// </summary>
    [DataContract]
    public partial class CommonFilterExpression :  IEquatable<CommonFilterExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonFilterExpression" /> class.
        /// </summary>
        /// <param name="filterPolicy">Message that encapsulates information about any filter policy. Environment specific policies are defined as extensions to this proto..</param>
        public CommonFilterExpression(Object filterPolicy = default(Object))
        {
            this.FilterPolicy = filterPolicy;
        }
        
        /// <summary>
        /// Message that encapsulates information about any filter policy. Environment specific policies are defined as extensions to this proto.
        /// </summary>
        /// <value>Message that encapsulates information about any filter policy. Environment specific policies are defined as extensions to this proto.</value>
        [DataMember(Name="filterPolicy", EmitDefaultValue=false)]
        public Object FilterPolicy { get; set; }

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
            return this.Equals(input as CommonFilterExpression);
        }

        /// <summary>
        /// Returns true if CommonFilterExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonFilterExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonFilterExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterPolicy == input.FilterPolicy ||
                    (this.FilterPolicy != null &&
                    this.FilterPolicy.Equals(input.FilterPolicy))
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
                if (this.FilterPolicy != null)
                    hashCode = hashCode * 59 + this.FilterPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}

