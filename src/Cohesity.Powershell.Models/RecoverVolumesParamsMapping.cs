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
    /// RecoverVolumesParamsMapping
    /// </summary>
    [DataContract]
    public partial class RecoverVolumesParamsMapping :  IEquatable<RecoverVolumesParamsMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVolumesParamsMapping" /> class.
        /// </summary>
        /// <param name="dstGuid">The destination, pertains to the newly rebuilt system..</param>
        /// <param name="srcGuid">The source, pertains to the original backup..</param>
        public RecoverVolumesParamsMapping(string dstGuid = default(string), string srcGuid = default(string))
        {
            this.DstGuid = dstGuid;
            this.SrcGuid = srcGuid;
        }
        
        /// <summary>
        /// The destination, pertains to the newly rebuilt system.
        /// </summary>
        /// <value>The destination, pertains to the newly rebuilt system.</value>
        [DataMember(Name="dstGuid", EmitDefaultValue=false)]
        public string DstGuid { get; set; }

        /// <summary>
        /// The source, pertains to the original backup.
        /// </summary>
        /// <value>The source, pertains to the original backup.</value>
        [DataMember(Name="srcGuid", EmitDefaultValue=false)]
        public string SrcGuid { get; set; }

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
            return this.Equals(input as RecoverVolumesParamsMapping);
        }

        /// <summary>
        /// Returns true if RecoverVolumesParamsMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVolumesParamsMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVolumesParamsMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DstGuid == input.DstGuid ||
                    (this.DstGuid != null &&
                    this.DstGuid.Equals(input.DstGuid))
                ) && 
                (
                    this.SrcGuid == input.SrcGuid ||
                    (this.SrcGuid != null &&
                    this.SrcGuid.Equals(input.SrcGuid))
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
                if (this.DstGuid != null)
                    hashCode = hashCode * 59 + this.DstGuid.GetHashCode();
                if (this.SrcGuid != null)
                    hashCode = hashCode * 59 + this.SrcGuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

