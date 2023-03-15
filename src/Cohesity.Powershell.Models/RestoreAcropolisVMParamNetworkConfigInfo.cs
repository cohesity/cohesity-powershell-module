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
    /// Proto to define the network configuration to be applied to the restored VM.
    /// </summary>
    [DataContract]
    public partial class RestoreAcropolisVMParamNetworkConfigInfo :  IEquatable<RestoreAcropolisVMParamNetworkConfigInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAcropolisVMParamNetworkConfigInfo" /> class.
        /// </summary>
        /// <param name="networkStateChange">Network state to be applied to the restored VM..</param>
        /// <param name="nicVec">This field is applicable only if the network_state_change is set to &#39;kAttachNewNetwork&#39;..</param>
        public RestoreAcropolisVMParamNetworkConfigInfo(int? networkStateChange = default(int?), List<RestoreAcropolisVMParamNetworkConfigInfoNICSpec> nicVec = default(List<RestoreAcropolisVMParamNetworkConfigInfoNICSpec>))
        {
            this.NetworkStateChange = networkStateChange;
            this.NicVec = nicVec;
            this.NetworkStateChange = networkStateChange;
            this.NicVec = nicVec;
        }
        
        /// <summary>
        /// Network state to be applied to the restored VM.
        /// </summary>
        /// <value>Network state to be applied to the restored VM.</value>
        [DataMember(Name="networkStateChange", EmitDefaultValue=true)]
        public int? NetworkStateChange { get; set; }

        /// <summary>
        /// This field is applicable only if the network_state_change is set to &#39;kAttachNewNetwork&#39;.
        /// </summary>
        /// <value>This field is applicable only if the network_state_change is set to &#39;kAttachNewNetwork&#39;.</value>
        [DataMember(Name="nicVec", EmitDefaultValue=true)]
        public List<RestoreAcropolisVMParamNetworkConfigInfoNICSpec> NicVec { get; set; }

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
            return this.Equals(input as RestoreAcropolisVMParamNetworkConfigInfo);
        }

        /// <summary>
        /// Returns true if RestoreAcropolisVMParamNetworkConfigInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAcropolisVMParamNetworkConfigInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAcropolisVMParamNetworkConfigInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkStateChange == input.NetworkStateChange ||
                    (this.NetworkStateChange != null &&
                    this.NetworkStateChange.Equals(input.NetworkStateChange))
                ) && 
                (
                    this.NicVec == input.NicVec ||
                    this.NicVec != null &&
                    input.NicVec != null &&
                    this.NicVec.SequenceEqual(input.NicVec)
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
                if (this.NetworkStateChange != null)
                    hashCode = hashCode * 59 + this.NetworkStateChange.GetHashCode();
                if (this.NicVec != null)
                    hashCode = hashCode * 59 + this.NicVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

