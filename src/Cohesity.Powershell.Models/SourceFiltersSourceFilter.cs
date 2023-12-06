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
    /// Plain text filter: { source_filter: \&quot;TestDatabase\&quot;, is_regex: false}. Wildcard filter: { source_filter: \&quot;Test?Database*\&quot;, is_regex: false}. Regex filter: { source_filter: \&quot;^Test.*Database$\&quot;, is_regex: true}.
    /// </summary>
    [DataContract]
    public partial class SourceFiltersSourceFilter :  IEquatable<SourceFiltersSourceFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFiltersSourceFilter" /> class.
        /// </summary>
        /// <param name="caseSensitive">Determines if the filter is case sensitive or not. For some environments (e.g. SQL), there may be a flag controlled default if the field is not populated while for some environments (e.g. VMware), the default will be based on the default value for this field..</param>
        /// <param name="isRegex">If true, this implies &#39;source_filter&#39; is a regex filter. If false, it will be treated as wildcard/plain text filter..</param>
        /// <param name="sourceFilter">This contains the filter string..</param>
        public SourceFiltersSourceFilter(bool? caseSensitive = default(bool?), bool? isRegex = default(bool?), string sourceFilter = default(string))
        {
            this.CaseSensitive = caseSensitive;
            this.IsRegex = isRegex;
            this.SourceFilter = sourceFilter;
            this.CaseSensitive = caseSensitive;
            this.IsRegex = isRegex;
            this.SourceFilter = sourceFilter;
        }
        
        /// <summary>
        /// Determines if the filter is case sensitive or not. For some environments (e.g. SQL), there may be a flag controlled default if the field is not populated while for some environments (e.g. VMware), the default will be based on the default value for this field.
        /// </summary>
        /// <value>Determines if the filter is case sensitive or not. For some environments (e.g. SQL), there may be a flag controlled default if the field is not populated while for some environments (e.g. VMware), the default will be based on the default value for this field.</value>
        [DataMember(Name="caseSensitive", EmitDefaultValue=true)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// If true, this implies &#39;source_filter&#39; is a regex filter. If false, it will be treated as wildcard/plain text filter.
        /// </summary>
        /// <value>If true, this implies &#39;source_filter&#39; is a regex filter. If false, it will be treated as wildcard/plain text filter.</value>
        [DataMember(Name="isRegex", EmitDefaultValue=true)]
        public bool? IsRegex { get; set; }

        /// <summary>
        /// This contains the filter string.
        /// </summary>
        /// <value>This contains the filter string.</value>
        [DataMember(Name="sourceFilter", EmitDefaultValue=true)]
        public string SourceFilter { get; set; }

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
            return this.Equals(input as SourceFiltersSourceFilter);
        }

        /// <summary>
        /// Returns true if SourceFiltersSourceFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceFiltersSourceFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceFiltersSourceFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.IsRegex == input.IsRegex ||
                    (this.IsRegex != null &&
                    this.IsRegex.Equals(input.IsRegex))
                ) && 
                (
                    this.SourceFilter == input.SourceFilter ||
                    (this.SourceFilter != null &&
                    this.SourceFilter.Equals(input.SourceFilter))
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
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.IsRegex != null)
                    hashCode = hashCode * 59 + this.IsRegex.GetHashCode();
                if (this.SourceFilter != null)
                    hashCode = hashCode * 59 + this.SourceFilter.GetHashCode();
                return hashCode;
            }
        }

    }

}

