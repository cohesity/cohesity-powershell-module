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
    /// VlanInfo
    /// </summary>
    [DataContract]
    public partial class VlanInfo :  IEquatable<VlanInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VlanInfo" /> class.
        /// </summary>
        /// <param name="serviceAnnotations">Contains annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public VlanInfo(List<VlanInfoServiceAnnotationsEntry> serviceAnnotations = default(List<VlanInfoServiceAnnotationsEntry>), VlanParams vlanParams = default(VlanParams))
        {
            this.ServiceAnnotations = serviceAnnotations;
            this.ServiceAnnotations = serviceAnnotations;
            this.VlanParams = vlanParams;
        }
        
        /// <summary>
        /// Contains annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.
        /// </summary>
        /// <value>Contains annotations to be put on services for IP allocation. Applicable only when service is of type LoadBalancer.</value>
        [DataMember(Name="serviceAnnotations", EmitDefaultValue=true)]
        public List<VlanInfoServiceAnnotationsEntry> ServiceAnnotations { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParams VlanParams { get; set; }

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
            return this.Equals(input as VlanInfo);
        }

        /// <summary>
        /// Returns true if VlanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VlanInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceAnnotations == input.ServiceAnnotations ||
                    this.ServiceAnnotations != null &&
                    input.ServiceAnnotations != null &&
                    this.ServiceAnnotations.SequenceEqual(input.ServiceAnnotations)
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
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
                if (this.ServiceAnnotations != null)
                    hashCode = hashCode * 59 + this.ServiceAnnotations.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

