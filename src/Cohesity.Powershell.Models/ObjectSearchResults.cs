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
    /// Specifies an array of backup objects and a count to indicate if additional requests must be made to get the full result.
    /// </summary>
    [DataContract]
    public partial class ObjectSearchResults :  IEquatable<ObjectSearchResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSearchResults" /> class.
        /// </summary>
        /// <param name="objectSnapshotInfo">Specifies the list of backup objects returned by this request that match the specified search and filter criteria. The number of objects returned is limited by the pageCount field..</param>
        /// <param name="totalCount">Specifies the total number of backup objects that match the filter and search criteria. Use this value to determine how many additional requests are required to get the full result..</param>
        public ObjectSearchResults(List<ObjectSnapshotInfo> objectSnapshotInfo = default(List<ObjectSnapshotInfo>), long? totalCount = default(long?))
        {
            this.ObjectSnapshotInfo = objectSnapshotInfo;
            this.TotalCount = totalCount;
        }
        
        /// <summary>
        /// Specifies the list of backup objects returned by this request that match the specified search and filter criteria. The number of objects returned is limited by the pageCount field.
        /// </summary>
        /// <value>Specifies the list of backup objects returned by this request that match the specified search and filter criteria. The number of objects returned is limited by the pageCount field.</value>
        [DataMember(Name="objectSnapshotInfo", EmitDefaultValue=false)]
        public List<ObjectSnapshotInfo> ObjectSnapshotInfo { get; set; }

        /// <summary>
        /// Specifies the total number of backup objects that match the filter and search criteria. Use this value to determine how many additional requests are required to get the full result.
        /// </summary>
        /// <value>Specifies the total number of backup objects that match the filter and search criteria. Use this value to determine how many additional requests are required to get the full result.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

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
            return this.Equals(input as ObjectSearchResults);
        }

        /// <summary>
        /// Returns true if ObjectSearchResults instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectSearchResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectSnapshotInfo == input.ObjectSnapshotInfo ||
                    this.ObjectSnapshotInfo != null &&
                    this.ObjectSnapshotInfo.SequenceEqual(input.ObjectSnapshotInfo)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.ObjectSnapshotInfo != null)
                    hashCode = hashCode * 59 + this.ObjectSnapshotInfo.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

