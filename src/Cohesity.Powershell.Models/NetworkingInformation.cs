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
    /// Specifies the struct containing information about network addresses configured on the given box. This is needed for dealing with Windows/Oracle Cluster resources that we discover and protect automatically.
    /// </summary>
    [DataContract]
    public partial class NetworkingInformation :  IEquatable<NetworkingInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkingInformation" /> class.
        /// </summary>
        /// <param name="resourceVec">The list of resources on the system that are accessible by an IP address..</param>
        public NetworkingInformation(List<ClusterNetworkingResourceInformation> resourceVec = default(List<ClusterNetworkingResourceInformation>))
        {
            this.ResourceVec = resourceVec;
            this.ResourceVec = resourceVec;
        }
        
        /// <summary>
        /// The list of resources on the system that are accessible by an IP address.
        /// </summary>
        /// <value>The list of resources on the system that are accessible by an IP address.</value>
        [DataMember(Name="resourceVec", EmitDefaultValue=true)]
        public List<ClusterNetworkingResourceInformation> ResourceVec { get; set; }

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
            return this.Equals(input as NetworkingInformation);
        }

        /// <summary>
        /// Returns true if NetworkingInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkingInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceVec == input.ResourceVec ||
                    this.ResourceVec != null &&
                    input.ResourceVec != null &&
                    this.ResourceVec.SequenceEqual(input.ResourceVec)
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
                if (this.ResourceVec != null)
                    hashCode = hashCode * 59 + this.ResourceVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

