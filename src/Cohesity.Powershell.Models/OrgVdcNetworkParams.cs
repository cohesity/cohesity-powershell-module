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
    /// Specifies the parameters of an Org VDC network.
    /// </summary>
    [DataContract]
    public partial class OrgVdcNetworkParams :  IEquatable<OrgVdcNetworkParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgVdcNetworkParams" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the Org VDC Network..</param>
        /// <param name="vcdUuid">Specifies the UUID as identified by the VCD..</param>
        /// <param name="vcenterUuid">Specifies the UUID of the corresponding network on the vCenter..</param>
        public OrgVdcNetworkParams(string name = default(string), string vcdUuid = default(string), string vcenterUuid = default(string))
        {
            this.Name = name;
            this.VcdUuid = vcdUuid;
            this.VcenterUuid = vcenterUuid;
            this.Name = name;
            this.VcdUuid = vcdUuid;
            this.VcenterUuid = vcenterUuid;
        }
        
        /// <summary>
        /// Specifies the name of the Org VDC Network.
        /// </summary>
        /// <value>Specifies the name of the Org VDC Network.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID as identified by the VCD.
        /// </summary>
        /// <value>Specifies the UUID as identified by the VCD.</value>
        [DataMember(Name="vcdUuid", EmitDefaultValue=true)]
        public string VcdUuid { get; set; }

        /// <summary>
        /// Specifies the UUID of the corresponding network on the vCenter.
        /// </summary>
        /// <value>Specifies the UUID of the corresponding network on the vCenter.</value>
        [DataMember(Name="vcenterUuid", EmitDefaultValue=true)]
        public string VcenterUuid { get; set; }

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
            return this.Equals(input as OrgVdcNetworkParams);
        }

        /// <summary>
        /// Returns true if OrgVdcNetworkParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgVdcNetworkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgVdcNetworkParams input)
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
                    this.VcdUuid == input.VcdUuid ||
                    (this.VcdUuid != null &&
                    this.VcdUuid.Equals(input.VcdUuid))
                ) && 
                (
                    this.VcenterUuid == input.VcenterUuid ||
                    (this.VcenterUuid != null &&
                    this.VcenterUuid.Equals(input.VcenterUuid))
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
                if (this.VcdUuid != null)
                    hashCode = hashCode * 59 + this.VcdUuid.GetHashCode();
                if (this.VcenterUuid != null)
                    hashCode = hashCode * 59 + this.VcenterUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

