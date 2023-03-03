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
    /// ListOrgVdcNetworksResponse
    /// </summary>
    [DataContract]
    public partial class ListOrgVdcNetworksResponse :  IEquatable<ListOrgVdcNetworksResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrgVdcNetworksResponse" /> class.
        /// </summary>
        /// <param name="orgVdcNetworks">Specifies a list of Org VDC Networks..</param>
        public ListOrgVdcNetworksResponse(List<OrgVdcNetwork> orgVdcNetworks = default(List<OrgVdcNetwork>))
        {
            this.OrgVdcNetworks = orgVdcNetworks;
            this.OrgVdcNetworks = orgVdcNetworks;
        }
        
        /// <summary>
        /// Specifies a list of Org VDC Networks.
        /// </summary>
        /// <value>Specifies a list of Org VDC Networks.</value>
        [DataMember(Name="orgVdcNetworks", EmitDefaultValue=true)]
        public List<OrgVdcNetwork> OrgVdcNetworks { get; set; }

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
            return this.Equals(input as ListOrgVdcNetworksResponse);
        }

        /// <summary>
        /// Returns true if ListOrgVdcNetworksResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOrgVdcNetworksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOrgVdcNetworksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrgVdcNetworks == input.OrgVdcNetworks ||
                    this.OrgVdcNetworks != null &&
                    input.OrgVdcNetworks != null &&
                    this.OrgVdcNetworks.SequenceEqual(input.OrgVdcNetworks)
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
                if (this.OrgVdcNetworks != null)
                    hashCode = hashCode * 59 + this.OrgVdcNetworks.GetHashCode();
                return hashCode;
            }
        }

    }

}

