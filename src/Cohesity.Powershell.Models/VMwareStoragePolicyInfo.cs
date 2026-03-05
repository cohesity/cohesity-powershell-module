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
    /// This message has fields which are created when VCD instant recovery or Test and dev uses custom storage policy.
    /// </summary>
    [DataContract]
    public partial class VMwareStoragePolicyInfo :  IEquatable<VMwareStoragePolicyInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareStoragePolicyInfo" /> class.
        /// </summary>
        /// <param name="categoryId">category id of custom category created..</param>
        /// <param name="categoryName">Name of the custom category..</param>
        /// <param name="pvdcUuid">ID of the target provider vdc. Need these to delete storage policy in GC..</param>
        /// <param name="recordErrorForGc">If set to true, all above custom created fields are added in GC..</param>
        /// <param name="storagePolicyName">Name of the custom storage policy..</param>
        /// <param name="storageProfilePvdcUuid">ID of the provider vdc storage policy..</param>
        /// <param name="storageProfileVdcUuid">ID of the org vdc storage policy..</param>
        /// <param name="tagId">Tag id of the custom tag created.</param>
        /// <param name="tagName">Name of the custom tag..</param>
        /// <param name="vdcUuid">ID of the target org vdc..</param>
        /// <param name="vmwareStoragePolicyId">ID of custom Vcenter storage policy created..</param>
        public VMwareStoragePolicyInfo(string categoryId = default(string), string categoryName = default(string), string pvdcUuid = default(string), bool? recordErrorForGc = default(bool?), string storagePolicyName = default(string), string storageProfilePvdcUuid = default(string), string storageProfileVdcUuid = default(string), string tagId = default(string), string tagName = default(string), string vdcUuid = default(string), string vmwareStoragePolicyId = default(string))
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.PvdcUuid = pvdcUuid;
            this.RecordErrorForGc = recordErrorForGc;
            this.StoragePolicyName = storagePolicyName;
            this.StorageProfilePvdcUuid = storageProfilePvdcUuid;
            this.StorageProfileVdcUuid = storageProfileVdcUuid;
            this.TagId = tagId;
            this.TagName = tagName;
            this.VdcUuid = vdcUuid;
            this.VmwareStoragePolicyId = vmwareStoragePolicyId;
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.PvdcUuid = pvdcUuid;
            this.RecordErrorForGc = recordErrorForGc;
            this.StoragePolicyName = storagePolicyName;
            this.StorageProfilePvdcUuid = storageProfilePvdcUuid;
            this.StorageProfileVdcUuid = storageProfileVdcUuid;
            this.TagId = tagId;
            this.TagName = tagName;
            this.VdcUuid = vdcUuid;
            this.VmwareStoragePolicyId = vmwareStoragePolicyId;
        }
        
        /// <summary>
        /// category id of custom category created.
        /// </summary>
        /// <value>category id of custom category created.</value>
        [DataMember(Name="categoryId", EmitDefaultValue=true)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Name of the custom category.
        /// </summary>
        /// <value>Name of the custom category.</value>
        [DataMember(Name="categoryName", EmitDefaultValue=true)]
        public string CategoryName { get; set; }

        /// <summary>
        /// ID of the target provider vdc. Need these to delete storage policy in GC.
        /// </summary>
        /// <value>ID of the target provider vdc. Need these to delete storage policy in GC.</value>
        [DataMember(Name="pvdcUuid", EmitDefaultValue=true)]
        public string PvdcUuid { get; set; }

        /// <summary>
        /// If set to true, all above custom created fields are added in GC.
        /// </summary>
        /// <value>If set to true, all above custom created fields are added in GC.</value>
        [DataMember(Name="recordErrorForGc", EmitDefaultValue=true)]
        public bool? RecordErrorForGc { get; set; }

        /// <summary>
        /// Name of the custom storage policy.
        /// </summary>
        /// <value>Name of the custom storage policy.</value>
        [DataMember(Name="storagePolicyName", EmitDefaultValue=true)]
        public string StoragePolicyName { get; set; }

        /// <summary>
        /// ID of the provider vdc storage policy.
        /// </summary>
        /// <value>ID of the provider vdc storage policy.</value>
        [DataMember(Name="storageProfilePvdcUuid", EmitDefaultValue=true)]
        public string StorageProfilePvdcUuid { get; set; }

        /// <summary>
        /// ID of the org vdc storage policy.
        /// </summary>
        /// <value>ID of the org vdc storage policy.</value>
        [DataMember(Name="storageProfileVdcUuid", EmitDefaultValue=true)]
        public string StorageProfileVdcUuid { get; set; }

        /// <summary>
        /// Tag id of the custom tag created
        /// </summary>
        /// <value>Tag id of the custom tag created</value>
        [DataMember(Name="tagId", EmitDefaultValue=true)]
        public string TagId { get; set; }

        /// <summary>
        /// Name of the custom tag.
        /// </summary>
        /// <value>Name of the custom tag.</value>
        [DataMember(Name="tagName", EmitDefaultValue=true)]
        public string TagName { get; set; }

        /// <summary>
        /// ID of the target org vdc.
        /// </summary>
        /// <value>ID of the target org vdc.</value>
        [DataMember(Name="vdcUuid", EmitDefaultValue=true)]
        public string VdcUuid { get; set; }

        /// <summary>
        /// ID of custom Vcenter storage policy created.
        /// </summary>
        /// <value>ID of custom Vcenter storage policy created.</value>
        [DataMember(Name="vmwareStoragePolicyId", EmitDefaultValue=true)]
        public string VmwareStoragePolicyId { get; set; }

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
            return this.Equals(input as VMwareStoragePolicyInfo);
        }

        /// <summary>
        /// Returns true if VMwareStoragePolicyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareStoragePolicyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareStoragePolicyInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.PvdcUuid == input.PvdcUuid ||
                    (this.PvdcUuid != null &&
                    this.PvdcUuid.Equals(input.PvdcUuid))
                ) && 
                (
                    this.RecordErrorForGc == input.RecordErrorForGc ||
                    (this.RecordErrorForGc != null &&
                    this.RecordErrorForGc.Equals(input.RecordErrorForGc))
                ) && 
                (
                    this.StoragePolicyName == input.StoragePolicyName ||
                    (this.StoragePolicyName != null &&
                    this.StoragePolicyName.Equals(input.StoragePolicyName))
                ) && 
                (
                    this.StorageProfilePvdcUuid == input.StorageProfilePvdcUuid ||
                    (this.StorageProfilePvdcUuid != null &&
                    this.StorageProfilePvdcUuid.Equals(input.StorageProfilePvdcUuid))
                ) && 
                (
                    this.StorageProfileVdcUuid == input.StorageProfileVdcUuid ||
                    (this.StorageProfileVdcUuid != null &&
                    this.StorageProfileVdcUuid.Equals(input.StorageProfileVdcUuid))
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.TagName == input.TagName ||
                    (this.TagName != null &&
                    this.TagName.Equals(input.TagName))
                ) && 
                (
                    this.VdcUuid == input.VdcUuid ||
                    (this.VdcUuid != null &&
                    this.VdcUuid.Equals(input.VdcUuid))
                ) && 
                (
                    this.VmwareStoragePolicyId == input.VmwareStoragePolicyId ||
                    (this.VmwareStoragePolicyId != null &&
                    this.VmwareStoragePolicyId.Equals(input.VmwareStoragePolicyId))
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.PvdcUuid != null)
                    hashCode = hashCode * 59 + this.PvdcUuid.GetHashCode();
                if (this.RecordErrorForGc != null)
                    hashCode = hashCode * 59 + this.RecordErrorForGc.GetHashCode();
                if (this.StoragePolicyName != null)
                    hashCode = hashCode * 59 + this.StoragePolicyName.GetHashCode();
                if (this.StorageProfilePvdcUuid != null)
                    hashCode = hashCode * 59 + this.StorageProfilePvdcUuid.GetHashCode();
                if (this.StorageProfileVdcUuid != null)
                    hashCode = hashCode * 59 + this.StorageProfileVdcUuid.GetHashCode();
                if (this.TagId != null)
                    hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.TagName != null)
                    hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.VdcUuid != null)
                    hashCode = hashCode * 59 + this.VdcUuid.GetHashCode();
                if (this.VmwareStoragePolicyId != null)
                    hashCode = hashCode * 59 + this.VmwareStoragePolicyId.GetHashCode();
                return hashCode;
            }
        }

    }

}

