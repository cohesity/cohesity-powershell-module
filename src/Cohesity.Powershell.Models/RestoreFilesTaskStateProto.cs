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
    /// RestoreFilesTaskStateProto
    /// </summary>
    [DataContract]
    public partial class RestoreFilesTaskStateProto :  IEquatable<RestoreFilesTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesTaskStateProto" /> class.
        /// </summary>
        /// <param name="restoreFilesInfo">restoreFilesInfo.</param>
        /// <param name="restoreParams">restoreParams.</param>
        public RestoreFilesTaskStateProto(RestoreFilesInfoProto restoreFilesInfo = default(RestoreFilesInfoProto), RestoreFilesParams restoreParams = default(RestoreFilesParams))
        {
            this.RestoreFilesInfo = restoreFilesInfo;
            this.RestoreParams = restoreParams;
        }
        
        /// <summary>
        /// Gets or Sets RestoreFilesInfo
        /// </summary>
        [DataMember(Name="restoreFilesInfo", EmitDefaultValue=false)]
        public RestoreFilesInfoProto RestoreFilesInfo { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParams
        /// </summary>
        [DataMember(Name="restoreParams", EmitDefaultValue=false)]
        public RestoreFilesParams RestoreParams { get; set; }

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
            return this.Equals(input as RestoreFilesTaskStateProto);
        }

        /// <summary>
        /// Returns true if RestoreFilesTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreFilesInfo == input.RestoreFilesInfo ||
                    (this.RestoreFilesInfo != null &&
                    this.RestoreFilesInfo.Equals(input.RestoreFilesInfo))
                ) && 
                (
                    this.RestoreParams == input.RestoreParams ||
                    (this.RestoreParams != null &&
                    this.RestoreParams.Equals(input.RestoreParams))
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
                if (this.RestoreFilesInfo != null)
                    hashCode = hashCode * 59 + this.RestoreFilesInfo.GetHashCode();
                if (this.RestoreParams != null)
                    hashCode = hashCode * 59 + this.RestoreParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

