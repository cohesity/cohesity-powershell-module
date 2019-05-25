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
    /// Specifies the request to compare AD objects from Snapshot and Production AD.
    /// </summary>
    [DataContract]
    public partial class CompareAdObjectsRequest :  IEquatable<CompareAdObjectsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareAdObjectsRequest" /> class.
        /// </summary>
        /// <param name="restoreTaskId">Specifies the Restore Task Id corresponding to which we need to compare the AD objects..</param>
        /// <param name="allowEmptyDestGuids">Specifies the option to get object attributes from Snapshot AD when destination guid is missing in GuidPair. This helps to show attributes of AD object from Snapshot AD when the object is missing in Production AD..</param>
        /// <param name="caseSensitive">Specifies the option to make comparison of attribute values case sensitive. Default is case insensitive..</param>
        /// <param name="excludeSysAttributes">Specifies the option to exclude AD system attributes when comparing two AD object attributes. If the objects have same guid, most of the system attributes would match.If the AD object was recovered through a restore, then many system attributes will be different. Default compares all attributes..</param>
        /// <param name="filterNullValueAttributes">Specifies the option to not return attributes where source and destination values are null values. This reduces noise of the properties in the objects returned..</param>
        /// <param name="filterSameValueAttributes">Specifies the option to not return attributes where source and destination values are same. Use this flag to return only values that are different..</param>
        /// <param name="guidPairs">Specifies the GuidPair of the AD Objects which we want to compare from both Snapshot and Production AD..</param>
        /// <param name="quickCompare">Specifies the option to do quick compare of specified guid between Snapshot AD and Production AD. If at least one attribute mismatch is found, comparison stops and returns with AdObjectFlag kNotEqual..</param>
        public CompareAdObjectsRequest(long? restoreTaskId = default(long?), bool? allowEmptyDestGuids = default(bool?), bool? caseSensitive = default(bool?), bool? excludeSysAttributes = default(bool?), bool? filterNullValueAttributes = default(bool?), bool? filterSameValueAttributes = default(bool?), List<GuidPair> guidPairs = default(List<GuidPair>), bool? quickCompare = default(bool?))
        {
            this.RestoreTaskId = restoreTaskId;
            this.AllowEmptyDestGuids = allowEmptyDestGuids;
            this.CaseSensitive = caseSensitive;
            this.ExcludeSysAttributes = excludeSysAttributes;
            this.FilterNullValueAttributes = filterNullValueAttributes;
            this.FilterSameValueAttributes = filterSameValueAttributes;
            this.GuidPairs = guidPairs;
            this.QuickCompare = quickCompare;
            this.RestoreTaskId = restoreTaskId;
            this.AllowEmptyDestGuids = allowEmptyDestGuids;
            this.CaseSensitive = caseSensitive;
            this.ExcludeSysAttributes = excludeSysAttributes;
            this.FilterNullValueAttributes = filterNullValueAttributes;
            this.FilterSameValueAttributes = filterSameValueAttributes;
            this.GuidPairs = guidPairs;
            this.QuickCompare = quickCompare;
        }
        
        /// <summary>
        /// Specifies the Restore Task Id corresponding to which we need to compare the AD objects.
        /// </summary>
        /// <value>Specifies the Restore Task Id corresponding to which we need to compare the AD objects.</value>
        [DataMember(Name="RestoreTaskId", EmitDefaultValue=true)]
        public long? RestoreTaskId { get; set; }

        /// <summary>
        /// Specifies the option to get object attributes from Snapshot AD when destination guid is missing in GuidPair. This helps to show attributes of AD object from Snapshot AD when the object is missing in Production AD.
        /// </summary>
        /// <value>Specifies the option to get object attributes from Snapshot AD when destination guid is missing in GuidPair. This helps to show attributes of AD object from Snapshot AD when the object is missing in Production AD.</value>
        [DataMember(Name="allowEmptyDestGuids", EmitDefaultValue=true)]
        public bool? AllowEmptyDestGuids { get; set; }

        /// <summary>
        /// Specifies the option to make comparison of attribute values case sensitive. Default is case insensitive.
        /// </summary>
        /// <value>Specifies the option to make comparison of attribute values case sensitive. Default is case insensitive.</value>
        [DataMember(Name="caseSensitive", EmitDefaultValue=true)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Specifies the option to exclude AD system attributes when comparing two AD object attributes. If the objects have same guid, most of the system attributes would match.If the AD object was recovered through a restore, then many system attributes will be different. Default compares all attributes.
        /// </summary>
        /// <value>Specifies the option to exclude AD system attributes when comparing two AD object attributes. If the objects have same guid, most of the system attributes would match.If the AD object was recovered through a restore, then many system attributes will be different. Default compares all attributes.</value>
        [DataMember(Name="excludeSysAttributes", EmitDefaultValue=true)]
        public bool? ExcludeSysAttributes { get; set; }

        /// <summary>
        /// Specifies the option to not return attributes where source and destination values are null values. This reduces noise of the properties in the objects returned.
        /// </summary>
        /// <value>Specifies the option to not return attributes where source and destination values are null values. This reduces noise of the properties in the objects returned.</value>
        [DataMember(Name="filterNullValueAttributes", EmitDefaultValue=true)]
        public bool? FilterNullValueAttributes { get; set; }

        /// <summary>
        /// Specifies the option to not return attributes where source and destination values are same. Use this flag to return only values that are different.
        /// </summary>
        /// <value>Specifies the option to not return attributes where source and destination values are same. Use this flag to return only values that are different.</value>
        [DataMember(Name="filterSameValueAttributes", EmitDefaultValue=true)]
        public bool? FilterSameValueAttributes { get; set; }

        /// <summary>
        /// Specifies the GuidPair of the AD Objects which we want to compare from both Snapshot and Production AD.
        /// </summary>
        /// <value>Specifies the GuidPair of the AD Objects which we want to compare from both Snapshot and Production AD.</value>
        [DataMember(Name="guidPairs", EmitDefaultValue=true)]
        public List<GuidPair> GuidPairs { get; set; }

        /// <summary>
        /// Specifies the option to do quick compare of specified guid between Snapshot AD and Production AD. If at least one attribute mismatch is found, comparison stops and returns with AdObjectFlag kNotEqual.
        /// </summary>
        /// <value>Specifies the option to do quick compare of specified guid between Snapshot AD and Production AD. If at least one attribute mismatch is found, comparison stops and returns with AdObjectFlag kNotEqual.</value>
        [DataMember(Name="quickCompare", EmitDefaultValue=true)]
        public bool? QuickCompare { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareAdObjectsRequest {\n");
            sb.Append("  RestoreTaskId: ").Append(RestoreTaskId).Append("\n");
            sb.Append("  AllowEmptyDestGuids: ").Append(AllowEmptyDestGuids).Append("\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  ExcludeSysAttributes: ").Append(ExcludeSysAttributes).Append("\n");
            sb.Append("  FilterNullValueAttributes: ").Append(FilterNullValueAttributes).Append("\n");
            sb.Append("  FilterSameValueAttributes: ").Append(FilterSameValueAttributes).Append("\n");
            sb.Append("  GuidPairs: ").Append(GuidPairs).Append("\n");
            sb.Append("  QuickCompare: ").Append(QuickCompare).Append("\n");
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
            return this.Equals(input as CompareAdObjectsRequest);
        }

        /// <summary>
        /// Returns true if CompareAdObjectsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CompareAdObjectsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompareAdObjectsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreTaskId == input.RestoreTaskId ||
                    (this.RestoreTaskId != null &&
                    this.RestoreTaskId.Equals(input.RestoreTaskId))
                ) && 
                (
                    this.AllowEmptyDestGuids == input.AllowEmptyDestGuids ||
                    (this.AllowEmptyDestGuids != null &&
                    this.AllowEmptyDestGuids.Equals(input.AllowEmptyDestGuids))
                ) && 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.ExcludeSysAttributes == input.ExcludeSysAttributes ||
                    (this.ExcludeSysAttributes != null &&
                    this.ExcludeSysAttributes.Equals(input.ExcludeSysAttributes))
                ) && 
                (
                    this.FilterNullValueAttributes == input.FilterNullValueAttributes ||
                    (this.FilterNullValueAttributes != null &&
                    this.FilterNullValueAttributes.Equals(input.FilterNullValueAttributes))
                ) && 
                (
                    this.FilterSameValueAttributes == input.FilterSameValueAttributes ||
                    (this.FilterSameValueAttributes != null &&
                    this.FilterSameValueAttributes.Equals(input.FilterSameValueAttributes))
                ) && 
                (
                    this.GuidPairs == input.GuidPairs ||
                    this.GuidPairs != null &&
                    input.GuidPairs != null &&
                    this.GuidPairs.SequenceEqual(input.GuidPairs)
                ) && 
                (
                    this.QuickCompare == input.QuickCompare ||
                    (this.QuickCompare != null &&
                    this.QuickCompare.Equals(input.QuickCompare))
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
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                if (this.AllowEmptyDestGuids != null)
                    hashCode = hashCode * 59 + this.AllowEmptyDestGuids.GetHashCode();
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.ExcludeSysAttributes != null)
                    hashCode = hashCode * 59 + this.ExcludeSysAttributes.GetHashCode();
                if (this.FilterNullValueAttributes != null)
                    hashCode = hashCode * 59 + this.FilterNullValueAttributes.GetHashCode();
                if (this.FilterSameValueAttributes != null)
                    hashCode = hashCode * 59 + this.FilterSameValueAttributes.GetHashCode();
                if (this.GuidPairs != null)
                    hashCode = hashCode * 59 + this.GuidPairs.GetHashCode();
                if (this.QuickCompare != null)
                    hashCode = hashCode * 59 + this.QuickCompare.GetHashCode();
                return hashCode;
            }
        }

    }

}
