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
    /// RestoreVappInfo
    /// </summary>
    [DataContract]
    public partial class RestoreVappInfo :  IEquatable<RestoreVappInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreVappInfo" /> class.
        /// </summary>
        /// <param name="vappId">Id of the vApp..</param>
        /// <param name="vappName">Name of the vApp..</param>
        public RestoreVappInfo(string vappId = default(string), string vappName = default(string))
        {
            this.VappId = vappId;
            this.VappName = vappName;
            this.VappId = vappId;
            this.VappName = vappName;
        }
        
        /// <summary>
        /// Id of the vApp.
        /// </summary>
        /// <value>Id of the vApp.</value>
        [DataMember(Name="vappId", EmitDefaultValue=true)]
        public string VappId { get; set; }

        /// <summary>
        /// Name of the vApp.
        /// </summary>
        /// <value>Name of the vApp.</value>
        [DataMember(Name="vappName", EmitDefaultValue=true)]
        public string VappName { get; set; }

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
            return this.Equals(input as RestoreVappInfo);
        }

        /// <summary>
        /// Returns true if RestoreVappInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreVappInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreVappInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VappId == input.VappId ||
                    (this.VappId != null &&
                    this.VappId.Equals(input.VappId))
                ) && 
                (
                    this.VappName == input.VappName ||
                    (this.VappName != null &&
                    this.VappName.Equals(input.VappName))
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
                if (this.VappId != null)
                    hashCode = hashCode * 59 + this.VappId.GetHashCode();
                if (this.VappName != null)
                    hashCode = hashCode * 59 + this.VappName.GetHashCode();
                return hashCode;
            }
        }

    }

}

