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
    /// Message to capture any additional O365 specific recovery params at the job level.
    /// </summary>
    [DataContract]
    public partial class O365RestoreFilesParams :  IEquatable<O365RestoreFilesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365RestoreFilesParams" /> class.
        /// </summary>
        /// <param name="subsiteItem">subsiteItem.</param>
        public O365RestoreFilesParams(SharepointSubsiteMetadata subsiteItem = default(SharepointSubsiteMetadata))
        {
            this.SubsiteItem = subsiteItem;
        }
        
        /// <summary>
        /// Gets or Sets SubsiteItem
        /// </summary>
        [DataMember(Name="subsiteItem", EmitDefaultValue=false)]
        public SharepointSubsiteMetadata SubsiteItem { get; set; }

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
            return this.Equals(input as O365RestoreFilesParams);
        }

        /// <summary>
        /// Returns true if O365RestoreFilesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365RestoreFilesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365RestoreFilesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubsiteItem == input.SubsiteItem ||
                    (this.SubsiteItem != null &&
                    this.SubsiteItem.Equals(input.SubsiteItem))
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
                if (this.SubsiteItem != null)
                    hashCode = hashCode * 59 + this.SubsiteItem.GetHashCode();
                return hashCode;
            }
        }

    }

}

