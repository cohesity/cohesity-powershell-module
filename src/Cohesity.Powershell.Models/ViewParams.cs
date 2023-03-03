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
    /// ViewParams
    /// </summary>
    [DataContract]
    public partial class ViewParams :  IEquatable<ViewParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewParams" /> class.
        /// </summary>
        /// <param name="clientSubnetWhitelistVec">List of external client subnets from where requests will be received for the new view..</param>
        /// <param name="disableNfsAccess">Whether to disable NFS access in the new view..</param>
        /// <param name="protocolAccessInfo">protocolAccessInfo.</param>
        /// <param name="qosMappingVec">The qos mappings (if any) for the new view..</param>
        /// <param name="storagePolicyOverride">storagePolicyOverride.</param>
        /// <param name="viewDescription">The description to be applied to the new view..</param>
        /// <param name="wormLockExpiryUsecs">This value &#39;worm_lock_expiry_usecs&#39; if specified will be set on the cloned view. This guarantees that the cloned view cannot be removed till the specified timestamp has reached. NOTE: If this is specified the clone view will be marked as immutable..</param>
        public ViewParams(List<ClusterConfigProtoSubnet> clientSubnetWhitelistVec = default(List<ClusterConfigProtoSubnet>), bool? disableNfsAccess = default(bool?), ViewIdMappingProtoProtocolAccessInfo protocolAccessInfo = default(ViewIdMappingProtoProtocolAccessInfo), List<ClusterConfigProtoQoSMapping> qosMappingVec = default(List<ClusterConfigProtoQoSMapping>), ClusterConfigProtoStoragePolicyOverride storagePolicyOverride = default(ClusterConfigProtoStoragePolicyOverride), string viewDescription = default(string), long? wormLockExpiryUsecs = default(long?))
        {
            this.ClientSubnetWhitelistVec = clientSubnetWhitelistVec;
            this.DisableNfsAccess = disableNfsAccess;
            this.QosMappingVec = qosMappingVec;
            this.ViewDescription = viewDescription;
            this.WormLockExpiryUsecs = wormLockExpiryUsecs;
            this.ClientSubnetWhitelistVec = clientSubnetWhitelistVec;
            this.DisableNfsAccess = disableNfsAccess;
            this.ProtocolAccessInfo = protocolAccessInfo;
            this.QosMappingVec = qosMappingVec;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.ViewDescription = viewDescription;
            this.WormLockExpiryUsecs = wormLockExpiryUsecs;
        }
        
        /// <summary>
        /// List of external client subnets from where requests will be received for the new view.
        /// </summary>
        /// <value>List of external client subnets from where requests will be received for the new view.</value>
        [DataMember(Name="clientSubnetWhitelistVec", EmitDefaultValue=true)]
        public List<ClusterConfigProtoSubnet> ClientSubnetWhitelistVec { get; set; }

        /// <summary>
        /// Whether to disable NFS access in the new view.
        /// </summary>
        /// <value>Whether to disable NFS access in the new view.</value>
        [DataMember(Name="disableNfsAccess", EmitDefaultValue=true)]
        public bool? DisableNfsAccess { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolAccessInfo
        /// </summary>
        [DataMember(Name="protocolAccessInfo", EmitDefaultValue=false)]
        public ViewIdMappingProtoProtocolAccessInfo ProtocolAccessInfo { get; set; }

        /// <summary>
        /// The qos mappings (if any) for the new view.
        /// </summary>
        /// <value>The qos mappings (if any) for the new view.</value>
        [DataMember(Name="qosMappingVec", EmitDefaultValue=true)]
        public List<ClusterConfigProtoQoSMapping> QosMappingVec { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicyOverride
        /// </summary>
        [DataMember(Name="storagePolicyOverride", EmitDefaultValue=false)]
        public ClusterConfigProtoStoragePolicyOverride StoragePolicyOverride { get; set; }

        /// <summary>
        /// The description to be applied to the new view.
        /// </summary>
        /// <value>The description to be applied to the new view.</value>
        [DataMember(Name="viewDescription", EmitDefaultValue=true)]
        public string ViewDescription { get; set; }

        /// <summary>
        /// This value &#39;worm_lock_expiry_usecs&#39; if specified will be set on the cloned view. This guarantees that the cloned view cannot be removed till the specified timestamp has reached. NOTE: If this is specified the clone view will be marked as immutable.
        /// </summary>
        /// <value>This value &#39;worm_lock_expiry_usecs&#39; if specified will be set on the cloned view. This guarantees that the cloned view cannot be removed till the specified timestamp has reached. NOTE: If this is specified the clone view will be marked as immutable.</value>
        [DataMember(Name="wormLockExpiryUsecs", EmitDefaultValue=true)]
        public long? WormLockExpiryUsecs { get; set; }

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
            return this.Equals(input as ViewParams);
        }

        /// <summary>
        /// Returns true if ViewParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientSubnetWhitelistVec == input.ClientSubnetWhitelistVec ||
                    this.ClientSubnetWhitelistVec != null &&
                    input.ClientSubnetWhitelistVec != null &&
                    this.ClientSubnetWhitelistVec.SequenceEqual(input.ClientSubnetWhitelistVec)
                ) && 
                (
                    this.DisableNfsAccess == input.DisableNfsAccess ||
                    (this.DisableNfsAccess != null &&
                    this.DisableNfsAccess.Equals(input.DisableNfsAccess))
                ) && 
                (
                    this.ProtocolAccessInfo == input.ProtocolAccessInfo ||
                    (this.ProtocolAccessInfo != null &&
                    this.ProtocolAccessInfo.Equals(input.ProtocolAccessInfo))
                ) && 
                (
                    this.QosMappingVec == input.QosMappingVec ||
                    this.QosMappingVec != null &&
                    input.QosMappingVec != null &&
                    this.QosMappingVec.SequenceEqual(input.QosMappingVec)
                ) && 
                (
                    this.StoragePolicyOverride == input.StoragePolicyOverride ||
                    (this.StoragePolicyOverride != null &&
                    this.StoragePolicyOverride.Equals(input.StoragePolicyOverride))
                ) && 
                (
                    this.ViewDescription == input.ViewDescription ||
                    (this.ViewDescription != null &&
                    this.ViewDescription.Equals(input.ViewDescription))
                ) && 
                (
                    this.WormLockExpiryUsecs == input.WormLockExpiryUsecs ||
                    (this.WormLockExpiryUsecs != null &&
                    this.WormLockExpiryUsecs.Equals(input.WormLockExpiryUsecs))
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
                if (this.ClientSubnetWhitelistVec != null)
                    hashCode = hashCode * 59 + this.ClientSubnetWhitelistVec.GetHashCode();
                if (this.DisableNfsAccess != null)
                    hashCode = hashCode * 59 + this.DisableNfsAccess.GetHashCode();
                if (this.ProtocolAccessInfo != null)
                    hashCode = hashCode * 59 + this.ProtocolAccessInfo.GetHashCode();
                if (this.QosMappingVec != null)
                    hashCode = hashCode * 59 + this.QosMappingVec.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.ViewDescription != null)
                    hashCode = hashCode * 59 + this.ViewDescription.GetHashCode();
                if (this.WormLockExpiryUsecs != null)
                    hashCode = hashCode * 59 + this.WormLockExpiryUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

