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
    /// Message specifying new location details, should be set only when is_original_location is false.
    /// </summary>
    [DataContract]
    public partial class RestoreAzureBlobStorageParamsNewLocationParams :  IEquatable<RestoreAzureBlobStorageParamsNewLocationParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAzureBlobStorageParamsNewLocationParams" /> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="storageContainer">storageContainer.</param>
        public RestoreAzureBlobStorageParamsNewLocationParams(EntityProto region = default(EntityProto), EntityProto storageContainer = default(EntityProto))
        {
            this.Region = region;
            this.StorageContainer = storageContainer;
        }
        
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public EntityProto Region { get; set; }

        /// <summary>
        /// Gets or Sets StorageContainer
        /// </summary>
        [DataMember(Name="storageContainer", EmitDefaultValue=false)]
        public EntityProto StorageContainer { get; set; }

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
            return this.Equals(input as RestoreAzureBlobStorageParamsNewLocationParams);
        }

        /// <summary>
        /// Returns true if RestoreAzureBlobStorageParamsNewLocationParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAzureBlobStorageParamsNewLocationParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAzureBlobStorageParamsNewLocationParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.StorageContainer == input.StorageContainer ||
                    (this.StorageContainer != null &&
                    this.StorageContainer.Equals(input.StorageContainer))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.StorageContainer != null)
                    hashCode = hashCode * 59 + this.StorageContainer.GetHashCode();
                return hashCode;
            }
        }

    }

}

