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
    /// Proto to encapsulate the filtering policy for backup objects like files or directories. If an object is not matched by any of the &#39;allow_filters&#39;, it will be excluded in the backup. If an object is matched by one of the &#39;deny_filters&#39;, it will always be excluded in the backup. Basically &#39;deny_filters&#39; overwrite &#39;allow_filters&#39; if they both match the same object. Currently we only support two kinds of filter: prefix which always starts with &#39;/&#39;, or postfix which always starts with &#39;*&#39; (cannot be \&quot;*\&quot; only). We don&#39;t support regular expression right now. A concrete example is: Allow filters: \&quot;/\&quot; Deny filters: \&quot;/tmp\&quot;, \&quot;*.mp4\&quot; Using such a policy will include everything under the root directory except the /tmp directory and all the mp4 files.
    /// </summary>
    [DataContract]
    public partial class FilteringPolicyProto :  IEquatable<FilteringPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilteringPolicyProto" /> class.
        /// </summary>
        /// <param name="allowFilters">List of filters to allow matched objects for backup..</param>
        /// <param name="denyFilters">List of filters to deny matched objects for backup..</param>
        public FilteringPolicyProto(List<string> allowFilters = default(List<string>), List<string> denyFilters = default(List<string>))
        {
            this.AllowFilters = allowFilters;
            this.DenyFilters = denyFilters;
            this.AllowFilters = allowFilters;
            this.DenyFilters = denyFilters;
        }
        
        /// <summary>
        /// List of filters to allow matched objects for backup.
        /// </summary>
        /// <value>List of filters to allow matched objects for backup.</value>
        [DataMember(Name="allowFilters", EmitDefaultValue=true)]
        public List<string> AllowFilters { get; set; }

        /// <summary>
        /// List of filters to deny matched objects for backup.
        /// </summary>
        /// <value>List of filters to deny matched objects for backup.</value>
        [DataMember(Name="denyFilters", EmitDefaultValue=true)]
        public List<string> DenyFilters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilteringPolicyProto {\n");
            sb.Append("  AllowFilters: ").Append(AllowFilters).Append("\n");
            sb.Append("  DenyFilters: ").Append(DenyFilters).Append("\n");
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
            return this.Equals(input as FilteringPolicyProto);
        }

        /// <summary>
        /// Returns true if FilteringPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of FilteringPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilteringPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowFilters == input.AllowFilters ||
                    this.AllowFilters != null &&
                    input.AllowFilters != null &&
                    this.AllowFilters.SequenceEqual(input.AllowFilters)
                ) && 
                (
                    this.DenyFilters == input.DenyFilters ||
                    this.DenyFilters != null &&
                    input.DenyFilters != null &&
                    this.DenyFilters.SequenceEqual(input.DenyFilters)
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
                if (this.AllowFilters != null)
                    hashCode = hashCode * 59 + this.AllowFilters.GetHashCode();
                if (this.DenyFilters != null)
                    hashCode = hashCode * 59 + this.DenyFilters.GetHashCode();
                return hashCode;
            }
        }

    }

}
