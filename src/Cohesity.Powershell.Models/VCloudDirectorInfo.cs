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
    /// VCloudDirectorInfo
    /// </summary>
    [DataContract]
    public partial class VCloudDirectorInfo :  IEquatable<VCloudDirectorInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCloudDirectorInfo" /> class.
        /// </summary>
        /// <param name="endpoint">vCenter endpoint..</param>
        /// <param name="name">vCenter name..</param>
        public VCloudDirectorInfo(string endpoint = default(string), string name = default(string))
        {
            this.Endpoint = endpoint;
            this.Name = name;
        }
        
        /// <summary>
        /// vCenter endpoint.
        /// </summary>
        /// <value>vCenter endpoint.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// vCenter name.
        /// </summary>
        /// <value>vCenter name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as VCloudDirectorInfo);
        }

        /// <summary>
        /// Returns true if VCloudDirectorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VCloudDirectorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCloudDirectorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

