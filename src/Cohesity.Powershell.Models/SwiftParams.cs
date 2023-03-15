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
    /// Specifies the parameters of Swift configuration.
    /// </summary>
    [DataContract]
    public partial class SwiftParams :  IEquatable<SwiftParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwiftParams" /> class.
        /// </summary>
        /// <param name="keystoneId">Specifies the associated Keystone configuration id..</param>
        /// <param name="operatorRoles">Specifies a list of operator roles..</param>
        public SwiftParams(long? keystoneId = default(long?), List<string> operatorRoles = default(List<string>))
        {
            this.KeystoneId = keystoneId;
            this.OperatorRoles = operatorRoles;
            this.KeystoneId = keystoneId;
            this.OperatorRoles = operatorRoles;
        }
        
        /// <summary>
        /// Specifies the associated Keystone configuration id.
        /// </summary>
        /// <value>Specifies the associated Keystone configuration id.</value>
        [DataMember(Name="keystoneId", EmitDefaultValue=true)]
        public long? KeystoneId { get; set; }

        /// <summary>
        /// Specifies a list of operator roles.
        /// </summary>
        /// <value>Specifies a list of operator roles.</value>
        [DataMember(Name="operatorRoles", EmitDefaultValue=true)]
        public List<string> OperatorRoles { get; set; }

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
            return this.Equals(input as SwiftParams);
        }

        /// <summary>
        /// Returns true if SwiftParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SwiftParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwiftParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeystoneId == input.KeystoneId ||
                    (this.KeystoneId != null &&
                    this.KeystoneId.Equals(input.KeystoneId))
                ) && 
                (
                    this.OperatorRoles == input.OperatorRoles ||
                    this.OperatorRoles != null &&
                    input.OperatorRoles != null &&
                    this.OperatorRoles.SequenceEqual(input.OperatorRoles)
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
                if (this.KeystoneId != null)
                    hashCode = hashCode * 59 + this.KeystoneId.GetHashCode();
                if (this.OperatorRoles != null)
                    hashCode = hashCode * 59 + this.OperatorRoles.GetHashCode();
                return hashCode;
            }
        }

    }

}

