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
    /// Contains managed disk parameters needed to deploy to Azure using managed disk.
    /// </summary>
    [DataContract]
    public partial class AzureManagedDiskParams :  IEquatable<AzureManagedDiskParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureManagedDiskParams" /> class.
        /// </summary>
        /// <param name="dataDisksSkuType">SKU type for data disks..</param>
        /// <param name="osDiskSkuType">SKU type for OS disk..</param>
        public AzureManagedDiskParams(int? dataDisksSkuType = default(int?), int? osDiskSkuType = default(int?))
        {
            this.DataDisksSkuType = dataDisksSkuType;
            this.OsDiskSkuType = osDiskSkuType;
            this.DataDisksSkuType = dataDisksSkuType;
            this.OsDiskSkuType = osDiskSkuType;
        }
        
        /// <summary>
        /// SKU type for data disks.
        /// </summary>
        /// <value>SKU type for data disks.</value>
        [DataMember(Name="dataDisksSkuType", EmitDefaultValue=true)]
        public int? DataDisksSkuType { get; set; }

        /// <summary>
        /// SKU type for OS disk.
        /// </summary>
        /// <value>SKU type for OS disk.</value>
        [DataMember(Name="osDiskSkuType", EmitDefaultValue=true)]
        public int? OsDiskSkuType { get; set; }

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
            return this.Equals(input as AzureManagedDiskParams);
        }

        /// <summary>
        /// Returns true if AzureManagedDiskParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureManagedDiskParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureManagedDiskParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataDisksSkuType == input.DataDisksSkuType ||
                    (this.DataDisksSkuType != null &&
                    this.DataDisksSkuType.Equals(input.DataDisksSkuType))
                ) && 
                (
                    this.OsDiskSkuType == input.OsDiskSkuType ||
                    (this.OsDiskSkuType != null &&
                    this.OsDiskSkuType.Equals(input.OsDiskSkuType))
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
                if (this.DataDisksSkuType != null)
                    hashCode = hashCode * 59 + this.DataDisksSkuType.GetHashCode();
                if (this.OsDiskSkuType != null)
                    hashCode = hashCode * 59 + this.OsDiskSkuType.GetHashCode();
                return hashCode;
            }
        }

    }

}

