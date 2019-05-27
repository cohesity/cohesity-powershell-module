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
    /// ExternalClientSubnets
    /// </summary>
    [DataContract]
    public partial class ExternalClientSubnets :  IEquatable<ExternalClientSubnets>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalClientSubnets" /> class.
        /// </summary>
        /// <param name="clientSubnets">Specifies the Client Subnets for the cluster..</param>
        public ExternalClientSubnets(List<Subnet> clientSubnets = default(List<Subnet>))
        {
            this.ClientSubnets = clientSubnets;
            this.ClientSubnets = clientSubnets;
        }
        
        /// <summary>
        /// Specifies the Client Subnets for the cluster.
        /// </summary>
        /// <value>Specifies the Client Subnets for the cluster.</value>
        [DataMember(Name="clientSubnets", EmitDefaultValue=true)]
        public List<Subnet> ClientSubnets { get; set; }

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
            return this.Equals(input as ExternalClientSubnets);
        }

        /// <summary>
        /// Returns true if ExternalClientSubnets instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalClientSubnets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalClientSubnets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientSubnets == input.ClientSubnets ||
                    this.ClientSubnets != null &&
                    input.ClientSubnets != null &&
                    this.ClientSubnets.SequenceEqual(input.ClientSubnets)
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
                if (this.ClientSubnets != null)
                    hashCode = hashCode * 59 + this.ClientSubnets.GetHashCode();
                return hashCode;
            }
        }

    }

}

