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
    /// IP Range for range of vip address addition
    /// </summary>
    [DataContract]
    public partial class IpRange :  IEquatable<IpRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRange" /> class.
        /// </summary>
        /// <param name="endIp">Optional End IP of the range If not specified, EndIp is same as StartIp.</param>
        /// <param name="startIp">Start IP of the range.</param>
        public IpRange(string endIp = default(string), string startIp = default(string))
        {
            this.EndIp = endIp;
            this.StartIp = startIp;
            this.EndIp = endIp;
            this.StartIp = startIp;
        }
        
        /// <summary>
        /// Optional End IP of the range If not specified, EndIp is same as StartIp
        /// </summary>
        /// <value>Optional End IP of the range If not specified, EndIp is same as StartIp</value>
        [DataMember(Name="endIp", EmitDefaultValue=true)]
        public string EndIp { get; set; }

        /// <summary>
        /// Start IP of the range
        /// </summary>
        /// <value>Start IP of the range</value>
        [DataMember(Name="startIp", EmitDefaultValue=true)]
        public string StartIp { get; set; }

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
            return this.Equals(input as IpRange);
        }

        /// <summary>
        /// Returns true if IpRange instances are equal
        /// </summary>
        /// <param name="input">Instance of IpRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndIp == input.EndIp ||
                    (this.EndIp != null &&
                    this.EndIp.Equals(input.EndIp))
                ) && 
                (
                    this.StartIp == input.StartIp ||
                    (this.StartIp != null &&
                    this.StartIp.Equals(input.StartIp))
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
                if (this.EndIp != null)
                    hashCode = hashCode * 59 + this.EndIp.GetHashCode();
                if (this.StartIp != null)
                    hashCode = hashCode * 59 + this.StartIp.GetHashCode();
                return hashCode;
            }
        }

    }

}

