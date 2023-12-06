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
    /// PVCInfoPVCSpecResources
    /// </summary>
    [DataContract]
    public partial class PVCInfoPVCSpecResources :  IEquatable<PVCInfoPVCSpecResources>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PVCInfoPVCSpecResources" /> class.
        /// </summary>
        /// <param name="requests">Map of requested resources and their values..</param>
        public PVCInfoPVCSpecResources(List<PVCInfoPVCSpecResourcesRequestsEntry> requests = default(List<PVCInfoPVCSpecResourcesRequestsEntry>))
        {
            this.Requests = requests;
            this.Requests = requests;
        }
        
        /// <summary>
        /// Map of requested resources and their values.
        /// </summary>
        /// <value>Map of requested resources and their values.</value>
        [DataMember(Name="requests", EmitDefaultValue=true)]
        public List<PVCInfoPVCSpecResourcesRequestsEntry> Requests { get; set; }

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
            return this.Equals(input as PVCInfoPVCSpecResources);
        }

        /// <summary>
        /// Returns true if PVCInfoPVCSpecResources instances are equal
        /// </summary>
        /// <param name="input">Instance of PVCInfoPVCSpecResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PVCInfoPVCSpecResources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Requests == input.Requests ||
                    this.Requests != null &&
                    input.Requests != null &&
                    this.Requests.SequenceEqual(input.Requests)
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
                if (this.Requests != null)
                    hashCode = hashCode * 59 + this.Requests.GetHashCode();
                return hashCode;
            }
        }

    }

}

