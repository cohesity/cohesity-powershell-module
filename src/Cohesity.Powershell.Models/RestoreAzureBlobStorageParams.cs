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
    /// RestoreAzureBlobStorageParams
    /// </summary>
    [DataContract]
    public partial class RestoreAzureBlobStorageParams :  IEquatable<RestoreAzureBlobStorageParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAzureBlobStorageParams" /> class.
        /// </summary>
        /// <param name="isOriginalLocation">Flag specifying if it is an original location recovery or a new location..</param>
        /// <param name="newLocationParams">newLocationParams.</param>
        /// <param name="objectPrefix">Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;. All operations at Blob container (lookup, upload, etc.) will prepend this prefix to the Object name..</param>
        /// <param name="overwriteObjectsInContainer">Flag specifying if we should overwrite if files are already present in the target location..</param>
        /// <param name="prefixesToRecover">Specifies all the prefixes which we have to recover. If it is empty, then magneto will recover the whole bucket..</param>
        /// <param name="preserveObjectAttributes">Flag specifying if we should preserve object attributes at the time of restore..</param>
        /// <param name="storageAccountEntity">storageAccountEntity.</param>
        public RestoreAzureBlobStorageParams(bool? isOriginalLocation = default(bool?), RestoreAzureBlobStorageParamsNewLocationParams newLocationParams = default(RestoreAzureBlobStorageParamsNewLocationParams), string objectPrefix = default(string), bool? overwriteObjectsInContainer = default(bool?), List<string> prefixesToRecover = default(List<string>), bool? preserveObjectAttributes = default(bool?), EntityProto storageAccountEntity = default(EntityProto))
        {
            this.IsOriginalLocation = isOriginalLocation;
            this.ObjectPrefix = objectPrefix;
            this.OverwriteObjectsInContainer = overwriteObjectsInContainer;
            this.PrefixesToRecover = prefixesToRecover;
            this.PreserveObjectAttributes = preserveObjectAttributes;
            this.IsOriginalLocation = isOriginalLocation;
            this.NewLocationParams = newLocationParams;
            this.ObjectPrefix = objectPrefix;
            this.OverwriteObjectsInContainer = overwriteObjectsInContainer;
            this.PrefixesToRecover = prefixesToRecover;
            this.PreserveObjectAttributes = preserveObjectAttributes;
            this.StorageAccountEntity = storageAccountEntity;
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
        public RestoreAzureBlobStorageParamsNewLocationParams NewLocationParams { get; set; }

        /// <summary>
        /// Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;. All operations at Blob container (lookup, upload, etc.) will prepend this prefix to the Object name.
        /// </summary>
        /// <value>Object prefix for the recovered objects. E.g. \&quot;/\&quot;, \&quot;/a/b\&quot;. All operations at Blob container (lookup, upload, etc.) will prepend this prefix to the Object name.</value>
        [DataMember(Name="objectPrefix", EmitDefaultValue=true)]
        public string ObjectPrefix { get; set; }

        /// <summary>
        /// Flag specifying if we should overwrite if files are already present in the target location.
        /// </summary>
        /// <value>Flag specifying if we should overwrite if files are already present in the target location.</value>
        [DataMember(Name="overwriteObjectsInContainer", EmitDefaultValue=true)]
        public bool? OverwriteObjectsInContainer { get; set; }

        /// <summary>
        /// Specifies all the prefixes which we have to recover. If it is empty, then magneto will recover the whole bucket.
        /// </summary>
        /// <value>Specifies all the prefixes which we have to recover. If it is empty, then magneto will recover the whole bucket.</value>
        [DataMember(Name="prefixesToRecover", EmitDefaultValue=true)]
        public List<string> PrefixesToRecover { get; set; }

        /// <summary>
        /// Flag specifying if we should preserve object attributes at the time of restore.
        /// </summary>
        /// <value>Flag specifying if we should preserve object attributes at the time of restore.</value>
        [DataMember(Name="preserveObjectAttributes", EmitDefaultValue=true)]
        public bool? PreserveObjectAttributes { get; set; }

        /// <summary>
        /// Gets or Sets StorageAccountEntity
        /// </summary>
        [DataMember(Name="storageAccountEntity", EmitDefaultValue=false)]
        public EntityProto StorageAccountEntity { get; set; }

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
            return this.Equals(input as RestoreAzureBlobStorageParams);
        }

        /// <summary>
        /// Returns true if RestoreAzureBlobStorageParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAzureBlobStorageParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAzureBlobStorageParams input)
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
                    this.OverwriteObjectsInContainer == input.OverwriteObjectsInContainer ||
                    (this.OverwriteObjectsInContainer != null &&
                    this.OverwriteObjectsInContainer.Equals(input.OverwriteObjectsInContainer))
                ) && 
                (
                    this.PrefixesToRecover == input.PrefixesToRecover ||
                    this.PrefixesToRecover != null &&
                    input.PrefixesToRecover != null &&
                    this.PrefixesToRecover.SequenceEqual(input.PrefixesToRecover)
                ) && 
                (
                    this.PreserveObjectAttributes == input.PreserveObjectAttributes ||
                    (this.PreserveObjectAttributes != null &&
                    this.PreserveObjectAttributes.Equals(input.PreserveObjectAttributes))
                ) && 
                (
                    this.StorageAccountEntity == input.StorageAccountEntity ||
                    (this.StorageAccountEntity != null &&
                    this.StorageAccountEntity.Equals(input.StorageAccountEntity))
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
                if (this.OverwriteObjectsInContainer != null)
                    hashCode = hashCode * 59 + this.OverwriteObjectsInContainer.GetHashCode();
                if (this.PrefixesToRecover != null)
                    hashCode = hashCode * 59 + this.PrefixesToRecover.GetHashCode();
                if (this.PreserveObjectAttributes != null)
                    hashCode = hashCode * 59 + this.PreserveObjectAttributes.GetHashCode();
                if (this.StorageAccountEntity != null)
                    hashCode = hashCode * 59 + this.StorageAccountEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

