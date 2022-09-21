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
    /// Specifies an Object containing information about a registered Office 365 source.
    /// </summary>
    [DataContract]
    public partial class O365ConnectParams :  IEquatable<O365ConnectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="O365ConnectParams" /> class.
        /// </summary>
        /// <param name="objectsDiscoveryParams">objectsDiscoveryParams.</param>
        public O365ConnectParams(ObjectsDiscoveryParams objectsDiscoveryParams = default(ObjectsDiscoveryParams))
        {
            this.ObjectsDiscoveryParams = objectsDiscoveryParams;
        }
        
        /// <summary>
        /// Gets or Sets ObjectsDiscoveryParams
        /// </summary>
        [DataMember(Name="ObjectsDiscoveryParams", EmitDefaultValue=false)]
        public ObjectsDiscoveryParams ObjectsDiscoveryParams { get; set; }

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
            return this.Equals(input as O365ConnectParams);
        }

        /// <summary>
        /// Returns true if O365ConnectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of O365ConnectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(O365ConnectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectsDiscoveryParams == input.ObjectsDiscoveryParams ||
                    (this.ObjectsDiscoveryParams != null &&
                    this.ObjectsDiscoveryParams.Equals(input.ObjectsDiscoveryParams))
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
                if (this.ObjectsDiscoveryParams != null)
                    hashCode = hashCode * 59 + this.ObjectsDiscoveryParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

