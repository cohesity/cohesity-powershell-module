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
    /// Specifies the result returned after a successful request to show system LED details.
    /// </summary>
    [DataContract]
    public partial class ShowSystemLedInfoResult :  IEquatable<ShowSystemLedInfoResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowSystemLedInfoResult" /> class.
        /// </summary>
        /// <param name="ledInfo">ledInfo.</param>
        public ShowSystemLedInfoResult(string ledInfo = default(string))
        {
            this.LedInfo = ledInfo;
        }
        
        /// <summary>
        /// Gets or Sets LedInfo
        /// </summary>
        [DataMember(Name="ledInfo", EmitDefaultValue=true)]
        public string LedInfo { get; set; }

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
            return this.Equals(input as ShowSystemLedInfoResult);
        }

        /// <summary>
        /// Returns true if ShowSystemLedInfoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowSystemLedInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowSystemLedInfoResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LedInfo == input.LedInfo ||
                    (this.LedInfo != null &&
                    this.LedInfo.Equals(input.LedInfo))
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
                if (this.LedInfo != null)
                    hashCode = hashCode * 59 + this.LedInfo.GetHashCode();
                return hashCode;
            }
        }

    }

}

