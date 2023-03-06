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
    /// For SQL, this filters will be applicable only for auto protect sources and can be used at the host, instance level.
    /// </summary>
    [DataContract]
    public partial class SourceFilters :  IEquatable<SourceFilters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFilters" /> class.
        /// </summary>
        /// <param name="excludeSourceFilterVec">This contains the list of exclude filters to be applied on the entities in the backup source..</param>
        public SourceFilters(List<SourceFiltersSourceFilter> excludeSourceFilterVec = default(List<SourceFiltersSourceFilter>))
        {
            this.ExcludeSourceFilterVec = excludeSourceFilterVec;
            this.ExcludeSourceFilterVec = excludeSourceFilterVec;
        }
        
        /// <summary>
        /// This contains the list of exclude filters to be applied on the entities in the backup source.
        /// </summary>
        /// <value>This contains the list of exclude filters to be applied on the entities in the backup source.</value>
        [DataMember(Name="excludeSourceFilterVec", EmitDefaultValue=true)]
        public List<SourceFiltersSourceFilter> ExcludeSourceFilterVec { get; set; }

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
            return this.Equals(input as SourceFilters);
        }

        /// <summary>
        /// Returns true if SourceFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceFilters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeSourceFilterVec == input.ExcludeSourceFilterVec ||
                    this.ExcludeSourceFilterVec != null &&
                    input.ExcludeSourceFilterVec != null &&
                    this.ExcludeSourceFilterVec.SequenceEqual(input.ExcludeSourceFilterVec)
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
                if (this.ExcludeSourceFilterVec != null)
                    hashCode = hashCode * 59 + this.ExcludeSourceFilterVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

