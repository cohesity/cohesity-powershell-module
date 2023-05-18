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
    /// This message contains basic info of the disk to be filtered from backup.
    /// </summary>
    [DataContract]
    public partial class AcropolisDiskFilterProto :  IEquatable<AcropolisDiskFilterProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcropolisDiskFilterProto" /> class.
        /// </summary>
        /// <param name="busType">Bus type (SCSI, IDE, PCI, SATA, SPAPR, NVME)..</param>
        /// <param name="index">Index/Unit number of the disk..</param>
        public AcropolisDiskFilterProto(string busType = default(string), int? index = default(int?))
        {
            this.BusType = busType;
            this.Index = index;
            this.BusType = busType;
            this.Index = index;
        }
        
        /// <summary>
        /// Bus type (SCSI, IDE, PCI, SATA, SPAPR, NVME).
        /// </summary>
        /// <value>Bus type (SCSI, IDE, PCI, SATA, SPAPR, NVME).</value>
        [DataMember(Name="busType", EmitDefaultValue=true)]
        public string BusType { get; set; }

        /// <summary>
        /// Index/Unit number of the disk.
        /// </summary>
        /// <value>Index/Unit number of the disk.</value>
        [DataMember(Name="index", EmitDefaultValue=true)]
        public int? Index { get; set; }

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
            return this.Equals(input as AcropolisDiskFilterProto);
        }

        /// <summary>
        /// Returns true if AcropolisDiskFilterProto instances are equal
        /// </summary>
        /// <param name="input">Instance of AcropolisDiskFilterProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcropolisDiskFilterProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusType == input.BusType ||
                    (this.BusType != null &&
                    this.BusType.Equals(input.BusType))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
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
                if (this.BusType != null)
                    hashCode = hashCode * 59 + this.BusType.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                return hashCode;
            }
        }

    }

}

