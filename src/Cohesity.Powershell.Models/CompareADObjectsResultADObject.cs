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
    /// CompareADObjectsResultADObject
    /// </summary>
    [DataContract]
    public partial class CompareADObjectsResultADObject :  IEquatable<CompareADObjectsResultADObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareADObjectsResultADObject" /> class.
        /// </summary>
        /// <param name="attributeVec">Array of AD attributes of AD object. This will contain distinct attributes from source and destination objects..</param>
        /// <param name="destGuid">Object guid from dest_server. If empty, compare could not find an AD object corresponding to &#39;source_guid&#39; even after looking up based on source_guid, source DN or source SAM account name. The SAM is applicable only for account type objects..</param>
        /// <param name="destPropCount">Number of attributes in destination object including system properties compared. This count is useful for debugging..</param>
        /// <param name="excludedPropCount">Number of attributes not compared due to ADCompareOptionFlags.kExcludeSysProps. This count is useful for debugging..</param>
        /// <param name="mismatchPropCount">Number of AD attributes compared based on &#39;ADCompareOptionFlagsType&#39; flags and found to be mismatched. If this is non-zero, compared objects are different. If this is 0 ann&#39;dest_guid&#39; is empty, then object is missing..</param>
        /// <param name="objectFlags">Object result flags of type ADObjectFlags..</param>
        /// <param name="sourceGuid">Object guid from $SourceServer. Guid string with or without &#39;{}&#39; braces..</param>
        /// <param name="sourcePropCount">Number of attributes in source object including system properties compared. This count is useful for debugging..</param>
        /// <param name="status">status.</param>
        public CompareADObjectsResultADObject(List<CompareADObjectsResultADAttribute> attributeVec = default(List<CompareADObjectsResultADAttribute>), string destGuid = default(string), int? destPropCount = default(int?), int? excludedPropCount = default(int?), int? mismatchPropCount = default(int?), int? objectFlags = default(int?), string sourceGuid = default(string), int? sourcePropCount = default(int?), ErrorProto status = default(ErrorProto))
        {
            this.AttributeVec = attributeVec;
            this.DestGuid = destGuid;
            this.DestPropCount = destPropCount;
            this.ExcludedPropCount = excludedPropCount;
            this.MismatchPropCount = mismatchPropCount;
            this.ObjectFlags = objectFlags;
            this.SourceGuid = sourceGuid;
            this.SourcePropCount = sourcePropCount;
            this.AttributeVec = attributeVec;
            this.DestGuid = destGuid;
            this.DestPropCount = destPropCount;
            this.ExcludedPropCount = excludedPropCount;
            this.MismatchPropCount = mismatchPropCount;
            this.ObjectFlags = objectFlags;
            this.SourceGuid = sourceGuid;
            this.SourcePropCount = sourcePropCount;
            this.Status = status;
        }
        
        /// <summary>
        /// Array of AD attributes of AD object. This will contain distinct attributes from source and destination objects.
        /// </summary>
        /// <value>Array of AD attributes of AD object. This will contain distinct attributes from source and destination objects.</value>
        [DataMember(Name="attributeVec", EmitDefaultValue=true)]
        public List<CompareADObjectsResultADAttribute> AttributeVec { get; set; }

        /// <summary>
        /// Object guid from dest_server. If empty, compare could not find an AD object corresponding to &#39;source_guid&#39; even after looking up based on source_guid, source DN or source SAM account name. The SAM is applicable only for account type objects.
        /// </summary>
        /// <value>Object guid from dest_server. If empty, compare could not find an AD object corresponding to &#39;source_guid&#39; even after looking up based on source_guid, source DN or source SAM account name. The SAM is applicable only for account type objects.</value>
        [DataMember(Name="destGuid", EmitDefaultValue=true)]
        public string DestGuid { get; set; }

        /// <summary>
        /// Number of attributes in destination object including system properties compared. This count is useful for debugging.
        /// </summary>
        /// <value>Number of attributes in destination object including system properties compared. This count is useful for debugging.</value>
        [DataMember(Name="destPropCount", EmitDefaultValue=true)]
        public int? DestPropCount { get; set; }

        /// <summary>
        /// Number of attributes not compared due to ADCompareOptionFlags.kExcludeSysProps. This count is useful for debugging.
        /// </summary>
        /// <value>Number of attributes not compared due to ADCompareOptionFlags.kExcludeSysProps. This count is useful for debugging.</value>
        [DataMember(Name="excludedPropCount", EmitDefaultValue=true)]
        public int? ExcludedPropCount { get; set; }

        /// <summary>
        /// Number of AD attributes compared based on &#39;ADCompareOptionFlagsType&#39; flags and found to be mismatched. If this is non-zero, compared objects are different. If this is 0 ann&#39;dest_guid&#39; is empty, then object is missing.
        /// </summary>
        /// <value>Number of AD attributes compared based on &#39;ADCompareOptionFlagsType&#39; flags and found to be mismatched. If this is non-zero, compared objects are different. If this is 0 ann&#39;dest_guid&#39; is empty, then object is missing.</value>
        [DataMember(Name="mismatchPropCount", EmitDefaultValue=true)]
        public int? MismatchPropCount { get; set; }

        /// <summary>
        /// Object result flags of type ADObjectFlags.
        /// </summary>
        /// <value>Object result flags of type ADObjectFlags.</value>
        [DataMember(Name="objectFlags", EmitDefaultValue=true)]
        public int? ObjectFlags { get; set; }

        /// <summary>
        /// Object guid from $SourceServer. Guid string with or without &#39;{}&#39; braces.
        /// </summary>
        /// <value>Object guid from $SourceServer. Guid string with or without &#39;{}&#39; braces.</value>
        [DataMember(Name="sourceGuid", EmitDefaultValue=true)]
        public string SourceGuid { get; set; }

        /// <summary>
        /// Number of attributes in source object including system properties compared. This count is useful for debugging.
        /// </summary>
        /// <value>Number of attributes in source object including system properties compared. This count is useful for debugging.</value>
        [DataMember(Name="sourcePropCount", EmitDefaultValue=true)]
        public int? SourcePropCount { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ErrorProto Status { get; set; }

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
            return this.Equals(input as CompareADObjectsResultADObject);
        }

        /// <summary>
        /// Returns true if CompareADObjectsResultADObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CompareADObjectsResultADObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompareADObjectsResultADObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeVec == input.AttributeVec ||
                    this.AttributeVec != null &&
                    input.AttributeVec != null &&
                    this.AttributeVec.SequenceEqual(input.AttributeVec)
                ) && 
                (
                    this.DestGuid == input.DestGuid ||
                    (this.DestGuid != null &&
                    this.DestGuid.Equals(input.DestGuid))
                ) && 
                (
                    this.DestPropCount == input.DestPropCount ||
                    (this.DestPropCount != null &&
                    this.DestPropCount.Equals(input.DestPropCount))
                ) && 
                (
                    this.ExcludedPropCount == input.ExcludedPropCount ||
                    (this.ExcludedPropCount != null &&
                    this.ExcludedPropCount.Equals(input.ExcludedPropCount))
                ) && 
                (
                    this.MismatchPropCount == input.MismatchPropCount ||
                    (this.MismatchPropCount != null &&
                    this.MismatchPropCount.Equals(input.MismatchPropCount))
                ) && 
                (
                    this.ObjectFlags == input.ObjectFlags ||
                    (this.ObjectFlags != null &&
                    this.ObjectFlags.Equals(input.ObjectFlags))
                ) && 
                (
                    this.SourceGuid == input.SourceGuid ||
                    (this.SourceGuid != null &&
                    this.SourceGuid.Equals(input.SourceGuid))
                ) && 
                (
                    this.SourcePropCount == input.SourcePropCount ||
                    (this.SourcePropCount != null &&
                    this.SourcePropCount.Equals(input.SourcePropCount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AttributeVec != null)
                    hashCode = hashCode * 59 + this.AttributeVec.GetHashCode();
                if (this.DestGuid != null)
                    hashCode = hashCode * 59 + this.DestGuid.GetHashCode();
                if (this.DestPropCount != null)
                    hashCode = hashCode * 59 + this.DestPropCount.GetHashCode();
                if (this.ExcludedPropCount != null)
                    hashCode = hashCode * 59 + this.ExcludedPropCount.GetHashCode();
                if (this.MismatchPropCount != null)
                    hashCode = hashCode * 59 + this.MismatchPropCount.GetHashCode();
                if (this.ObjectFlags != null)
                    hashCode = hashCode * 59 + this.ObjectFlags.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                if (this.SourcePropCount != null)
                    hashCode = hashCode * 59 + this.SourcePropCount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

