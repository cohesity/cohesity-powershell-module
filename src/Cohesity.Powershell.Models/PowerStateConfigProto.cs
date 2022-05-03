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
    /// PowerStateConfigProto
    /// </summary>
    [DataContract]
    public partial class PowerStateConfigProto :  IEquatable<PowerStateConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerStateConfigProto" /> class.
        /// </summary>
        /// <param name="powerOn">powerOn.</param>
        public PowerStateConfigProto(bool? powerOn = default(bool?))
        {
            this.PowerOn = powerOn;
        }
        
        /// <summary>
        /// Gets or Sets PowerOn
        /// </summary>
        [DataMember(Name="powerOn", EmitDefaultValue=false)]
        public bool? PowerOn { get; set; }

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
            return this.Equals(input as PowerStateConfigProto);
        }

        /// <summary>
        /// Returns true if PowerStateConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of PowerStateConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerStateConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PowerOn == input.PowerOn ||
                    (this.PowerOn != null &&
                    this.PowerOn.Equals(input.PowerOn))
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
                if (this.PowerOn != null)
                    hashCode = hashCode * 59 + this.PowerOn.GetHashCode();
                return hashCode;
            }
        }

    }

}

