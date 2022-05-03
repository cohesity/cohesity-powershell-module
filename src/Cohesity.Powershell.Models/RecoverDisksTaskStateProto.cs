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
    /// RecoverDisksTaskStateProto
    /// </summary>
    [DataContract]
    public partial class RecoverDisksTaskStateProto :  IEquatable<RecoverDisksTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverDisksTaskStateProto" /> class.
        /// </summary>
        /// <param name="recoverVirtualDiskInfo">recoverVirtualDiskInfo.</param>
        /// <param name="recoverVirtualDiskParams">recoverVirtualDiskParams.</param>
        public RecoverDisksTaskStateProto(RecoverVirtualDiskInfoProto recoverVirtualDiskInfo = default(RecoverVirtualDiskInfoProto), RecoverVirtualDiskParams recoverVirtualDiskParams = default(RecoverVirtualDiskParams))
        {
            this.RecoverVirtualDiskInfo = recoverVirtualDiskInfo;
            this.RecoverVirtualDiskParams = recoverVirtualDiskParams;
        }
        
        /// <summary>
        /// Gets or Sets RecoverVirtualDiskInfo
        /// </summary>
        [DataMember(Name="recoverVirtualDiskInfo", EmitDefaultValue=false)]
        public RecoverVirtualDiskInfoProto RecoverVirtualDiskInfo { get; set; }

        /// <summary>
        /// Gets or Sets RecoverVirtualDiskParams
        /// </summary>
        [DataMember(Name="recoverVirtualDiskParams", EmitDefaultValue=false)]
        public RecoverVirtualDiskParams RecoverVirtualDiskParams { get; set; }

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
            return this.Equals(input as RecoverDisksTaskStateProto);
        }

        /// <summary>
        /// Returns true if RecoverDisksTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverDisksTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverDisksTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecoverVirtualDiskInfo == input.RecoverVirtualDiskInfo ||
                    (this.RecoverVirtualDiskInfo != null &&
                    this.RecoverVirtualDiskInfo.Equals(input.RecoverVirtualDiskInfo))
                ) && 
                (
                    this.RecoverVirtualDiskParams == input.RecoverVirtualDiskParams ||
                    (this.RecoverVirtualDiskParams != null &&
                    this.RecoverVirtualDiskParams.Equals(input.RecoverVirtualDiskParams))
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
                if (this.RecoverVirtualDiskInfo != null)
                    hashCode = hashCode * 59 + this.RecoverVirtualDiskInfo.GetHashCode();
                if (this.RecoverVirtualDiskParams != null)
                    hashCode = hashCode * 59 + this.RecoverVirtualDiskParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

