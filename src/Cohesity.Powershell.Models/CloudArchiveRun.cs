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
    /// Specifies the info about cloud archive run.
    /// </summary>
    [DataContract]
    public partial class CloudArchiveRun :  IEquatable<CloudArchiveRun>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudArchiveRun" /> class.
        /// </summary>
        /// <param name="archivalInfo">Specifies the archival info..</param>
        public CloudArchiveRun(List<CloudArchivalInfo> archivalInfo = default(List<CloudArchivalInfo>))
        {
            this.ArchivalInfo = archivalInfo;
            this.ArchivalInfo = archivalInfo;
        }
        
        /// <summary>
        /// Specifies the archival info.
        /// </summary>
        /// <value>Specifies the archival info.</value>
        [DataMember(Name="archivalInfo", EmitDefaultValue=true)]
        public List<CloudArchivalInfo> ArchivalInfo { get; set; }

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
            return this.Equals(input as CloudArchiveRun);
        }

        /// <summary>
        /// Returns true if CloudArchiveRun instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudArchiveRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudArchiveRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalInfo == input.ArchivalInfo ||
                    this.ArchivalInfo != null &&
                    input.ArchivalInfo != null &&
                    this.ArchivalInfo.SequenceEqual(input.ArchivalInfo)
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
                if (this.ArchivalInfo != null)
                    hashCode = hashCode * 59 + this.ArchivalInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

