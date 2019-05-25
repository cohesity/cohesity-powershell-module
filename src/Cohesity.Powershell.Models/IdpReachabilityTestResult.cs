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
    /// Specifies the result of the reachability test done for an IdP.
    /// </summary>
    [DataContract]
    public partial class IdpReachabilityTestResult :  IEquatable<IdpReachabilityTestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdpReachabilityTestResult" /> class.
        /// </summary>
        /// <param name="reachable">Specifies the flag for Idp reachability..</param>
        public IdpReachabilityTestResult(bool? reachable = default(bool?))
        {
            this.Reachable = reachable;
            this.Reachable = reachable;
        }
        
        /// <summary>
        /// Specifies the flag for Idp reachability.
        /// </summary>
        /// <value>Specifies the flag for Idp reachability.</value>
        [DataMember(Name="reachable", EmitDefaultValue=true)]
        public bool? Reachable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdpReachabilityTestResult {\n");
            sb.Append("  Reachable: ").Append(Reachable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as IdpReachabilityTestResult);
        }

        /// <summary>
        /// Returns true if IdpReachabilityTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of IdpReachabilityTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdpReachabilityTestResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reachable == input.Reachable ||
                    (this.Reachable != null &&
                    this.Reachable.Equals(input.Reachable))
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
                if (this.Reachable != null)
                    hashCode = hashCode * 59 + this.Reachable.GetHashCode();
                return hashCode;
            }
        }

    }

}
