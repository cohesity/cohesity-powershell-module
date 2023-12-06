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
    /// OrgVDCNetwork
    /// </summary>
    [DataContract]
    public partial class OrgVDCNetwork :  IEquatable<OrgVDCNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgVDCNetwork" /> class.
        /// </summary>
        /// <param name="name">This is the name of the  Org VDC network..</param>
        /// <param name="networkType">This is the type of the corresponding network on VCenter..</param>
        /// <param name="vcdUuid">This is the uuid of Org VDC network as identified by VCD..</param>
        /// <param name="vcenterMorefUuid">This is the moref of the corresponding network on VCenter..</param>
        public OrgVDCNetwork(string name = default(string), string networkType = default(string), string vcdUuid = default(string), string vcenterMorefUuid = default(string))
        {
            this.Name = name;
            this.NetworkType = networkType;
            this.VcdUuid = vcdUuid;
            this.VcenterMorefUuid = vcenterMorefUuid;
            this.Name = name;
            this.NetworkType = networkType;
            this.VcdUuid = vcdUuid;
            this.VcenterMorefUuid = vcenterMorefUuid;
        }
        
        /// <summary>
        /// This is the name of the  Org VDC network.
        /// </summary>
        /// <value>This is the name of the  Org VDC network.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// This is the type of the corresponding network on VCenter.
        /// </summary>
        /// <value>This is the type of the corresponding network on VCenter.</value>
        [DataMember(Name="networkType", EmitDefaultValue=true)]
        public string NetworkType { get; set; }

        /// <summary>
        /// This is the uuid of Org VDC network as identified by VCD.
        /// </summary>
        /// <value>This is the uuid of Org VDC network as identified by VCD.</value>
        [DataMember(Name="vcdUuid", EmitDefaultValue=true)]
        public string VcdUuid { get; set; }

        /// <summary>
        /// This is the moref of the corresponding network on VCenter.
        /// </summary>
        /// <value>This is the moref of the corresponding network on VCenter.</value>
        [DataMember(Name="vcenterMorefUuid", EmitDefaultValue=true)]
        public string VcenterMorefUuid { get; set; }

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
            return this.Equals(input as OrgVDCNetwork);
        }

        /// <summary>
        /// Returns true if OrgVDCNetwork instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgVDCNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgVDCNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    (this.NetworkType != null &&
                    this.NetworkType.Equals(input.NetworkType))
                ) && 
                (
                    this.VcdUuid == input.VcdUuid ||
                    (this.VcdUuid != null &&
                    this.VcdUuid.Equals(input.VcdUuid))
                ) && 
                (
                    this.VcenterMorefUuid == input.VcenterMorefUuid ||
                    (this.VcenterMorefUuid != null &&
                    this.VcenterMorefUuid.Equals(input.VcenterMorefUuid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkType != null)
                    hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.VcdUuid != null)
                    hashCode = hashCode * 59 + this.VcdUuid.GetHashCode();
                if (this.VcenterMorefUuid != null)
                    hashCode = hashCode * 59 + this.VcenterMorefUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

