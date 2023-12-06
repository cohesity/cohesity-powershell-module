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
    /// RestoreS3Params
    /// </summary>
    [DataContract]
    public partial class RestoreS3Params :  IEquatable<RestoreS3Params>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreS3Params" /> class.
        /// </summary>
        /// <param name="isOriginalLocation">Flag specifying if it is an original location recovery or a new location..</param>
        /// <param name="newLocationParams">newLocationParams.</param>
        /// <param name="objectPrefix">Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;..</param>
        /// <param name="overwriteObjectsInBucket">Flag specifying if we should overwrite if files are already present in the target location..</param>
        /// <param name="preserveObjectAttributes">Flag specifying if we should preserve object attributes at the time of restore..</param>
        public RestoreS3Params(bool? isOriginalLocation = default(bool?), RestoreS3ParamsNewLocationParams newLocationParams = default(RestoreS3ParamsNewLocationParams), string objectPrefix = default(string), bool? overwriteObjectsInBucket = default(bool?), bool? preserveObjectAttributes = default(bool?))
        {
            this.IsOriginalLocation = isOriginalLocation;
            this.ObjectPrefix = objectPrefix;
            this.OverwriteObjectsInBucket = overwriteObjectsInBucket;
            this.PreserveObjectAttributes = preserveObjectAttributes;
            this.IsOriginalLocation = isOriginalLocation;
            this.NewLocationParams = newLocationParams;
            this.ObjectPrefix = objectPrefix;
            this.OverwriteObjectsInBucket = overwriteObjectsInBucket;
            this.PreserveObjectAttributes = preserveObjectAttributes;
        }
        
        /// <summary>
        /// Flag specifying if it is an original location recovery or a new location.
        /// </summary>
        /// <value>Flag specifying if it is an original location recovery or a new location.</value>
        [DataMember(Name="isOriginalLocation", EmitDefaultValue=true)]
        public bool? IsOriginalLocation { get; set; }

        /// <summary>
        /// Gets or Sets NewLocationParams
        /// </summary>
        [DataMember(Name="newLocationParams", EmitDefaultValue=false)]
        public RestoreS3ParamsNewLocationParams NewLocationParams { get; set; }

        /// <summary>
        /// Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;.
        /// </summary>
        /// <value>Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;.</value>
        [DataMember(Name="objectPrefix", EmitDefaultValue=true)]
        public string ObjectPrefix { get; set; }

        /// <summary>
        /// Flag specifying if we should overwrite if files are already present in the target location.
        /// </summary>
        /// <value>Flag specifying if we should overwrite if files are already present in the target location.</value>
        [DataMember(Name="overwriteObjectsInBucket", EmitDefaultValue=true)]
        public bool? OverwriteObjectsInBucket { get; set; }

        /// <summary>
        /// Flag specifying if we should preserve object attributes at the time of restore.
        /// </summary>
        /// <value>Flag specifying if we should preserve object attributes at the time of restore.</value>
        [DataMember(Name="preserveObjectAttributes", EmitDefaultValue=true)]
        public bool? PreserveObjectAttributes { get; set; }

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
            return this.Equals(input as RestoreS3Params);
        }

        /// <summary>
        /// Returns true if RestoreS3Params instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreS3Params to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreS3Params input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsOriginalLocation == input.IsOriginalLocation ||
                    (this.IsOriginalLocation != null &&
                    this.IsOriginalLocation.Equals(input.IsOriginalLocation))
                ) && 
                (
                    this.NewLocationParams == input.NewLocationParams ||
                    (this.NewLocationParams != null &&
                    this.NewLocationParams.Equals(input.NewLocationParams))
                ) && 
                (
                    this.ObjectPrefix == input.ObjectPrefix ||
                    (this.ObjectPrefix != null &&
                    this.ObjectPrefix.Equals(input.ObjectPrefix))
                ) && 
                (
                    this.OverwriteObjectsInBucket == input.OverwriteObjectsInBucket ||
                    (this.OverwriteObjectsInBucket != null &&
                    this.OverwriteObjectsInBucket.Equals(input.OverwriteObjectsInBucket))
                ) && 
                (
                    this.PreserveObjectAttributes == input.PreserveObjectAttributes ||
                    (this.PreserveObjectAttributes != null &&
                    this.PreserveObjectAttributes.Equals(input.PreserveObjectAttributes))
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
                if (this.IsOriginalLocation != null)
                    hashCode = hashCode * 59 + this.IsOriginalLocation.GetHashCode();
                if (this.NewLocationParams != null)
                    hashCode = hashCode * 59 + this.NewLocationParams.GetHashCode();
                if (this.ObjectPrefix != null)
                    hashCode = hashCode * 59 + this.ObjectPrefix.GetHashCode();
                if (this.OverwriteObjectsInBucket != null)
                    hashCode = hashCode * 59 + this.OverwriteObjectsInBucket.GetHashCode();
                if (this.PreserveObjectAttributes != null)
                    hashCode = hashCode * 59 + this.PreserveObjectAttributes.GetHashCode();
                return hashCode;
            }
        }

    }

}

