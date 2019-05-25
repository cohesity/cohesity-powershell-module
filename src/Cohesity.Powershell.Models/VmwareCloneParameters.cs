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
    /// Specifies the information required for recovering or cloning VmWare VMs.
    /// </summary>
    [DataContract]
    public partial class VmwareCloneParameters :  IEquatable<VmwareCloneParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareCloneParameters" /> class.
        /// </summary>
        /// <param name="datastoreFolderId">Specifies the folder where the restore datastore should be created. This is applicable only when the VMs are being cloned..</param>
        /// <param name="detachNetwork">Specifies whether the network should be detached from the recovered or cloned VMs..</param>
        /// <param name="disableNetwork">Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it..</param>
        /// <param name="networkId">Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source..</param>
        /// <param name="networkMappings">Specifies the parameters for mapping the source and target networks. This field can be used if restoring to a different parent source. This will replace the NetworkId and DisableNetwork that are used to provide configuration for a single network. Unless the support for mapping is available for all the entities old keys can be used to attach a new network. Supports &#39;kVMware&#39; for now..</param>
        /// <param name="poweredOn">Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off..</param>
        /// <param name="prefix">Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="resourcePoolId">Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent..</param>
        /// <param name="suffix">Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="vmFolderId">Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed..</param>
        public VmwareCloneParameters(long? datastoreFolderId = default(long?), bool? detachNetwork = default(bool?), bool? disableNetwork = default(bool?), long? networkId = default(long?), List<NetworkMapping> networkMappings = default(List<NetworkMapping>), bool? poweredOn = default(bool?), string prefix = default(string), long? resourcePoolId = default(long?), string suffix = default(string), long? vmFolderId = default(long?))
        {
            this.DatastoreFolderId = datastoreFolderId;
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.NetworkMappings = networkMappings;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.ResourcePoolId = resourcePoolId;
            this.Suffix = suffix;
            this.VmFolderId = vmFolderId;
            this.DatastoreFolderId = datastoreFolderId;
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.NetworkMappings = networkMappings;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.ResourcePoolId = resourcePoolId;
            this.Suffix = suffix;
            this.VmFolderId = vmFolderId;
        }
        
        /// <summary>
        /// Specifies the folder where the restore datastore should be created. This is applicable only when the VMs are being cloned.
        /// </summary>
        /// <value>Specifies the folder where the restore datastore should be created. This is applicable only when the VMs are being cloned.</value>
        [DataMember(Name="datastoreFolderId", EmitDefaultValue=true)]
        public long? DatastoreFolderId { get; set; }

        /// <summary>
        /// Specifies whether the network should be detached from the recovered or cloned VMs.
        /// </summary>
        /// <value>Specifies whether the network should be detached from the recovered or cloned VMs.</value>
        [DataMember(Name="detachNetwork", EmitDefaultValue=true)]
        public bool? DetachNetwork { get; set; }

        /// <summary>
        /// Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.
        /// </summary>
        /// <value>Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=true)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.
        /// </summary>
        /// <value>Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.</value>
        [DataMember(Name="networkId", EmitDefaultValue=true)]
        public long? NetworkId { get; set; }

        /// <summary>
        /// Specifies the parameters for mapping the source and target networks. This field can be used if restoring to a different parent source. This will replace the NetworkId and DisableNetwork that are used to provide configuration for a single network. Unless the support for mapping is available for all the entities old keys can be used to attach a new network. Supports &#39;kVMware&#39; for now.
        /// </summary>
        /// <value>Specifies the parameters for mapping the source and target networks. This field can be used if restoring to a different parent source. This will replace the NetworkId and DisableNetwork that are used to provide configuration for a single network. Unless the support for mapping is available for all the entities old keys can be used to attach a new network. Supports &#39;kVMware&#39; for now.</value>
        [DataMember(Name="networkMappings", EmitDefaultValue=true)]
        public List<NetworkMapping> NetworkMappings { get; set; }

        /// <summary>
        /// Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.
        /// </summary>
        /// <value>Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.</value>
        [DataMember(Name="poweredOn", EmitDefaultValue=true)]
        public bool? PoweredOn { get; set; }

        /// <summary>
        /// Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="prefix", EmitDefaultValue=true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.
        /// </summary>
        /// <value>Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.</value>
        [DataMember(Name="resourcePoolId", EmitDefaultValue=true)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed.
        /// </summary>
        /// <value>Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed.</value>
        [DataMember(Name="vmFolderId", EmitDefaultValue=true)]
        public long? VmFolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmwareCloneParameters {\n");
            sb.Append("  DatastoreFolderId: ").Append(DatastoreFolderId).Append("\n");
            sb.Append("  DetachNetwork: ").Append(DetachNetwork).Append("\n");
            sb.Append("  DisableNetwork: ").Append(DisableNetwork).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  NetworkMappings: ").Append(NetworkMappings).Append("\n");
            sb.Append("  PoweredOn: ").Append(PoweredOn).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  ResourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  VmFolderId: ").Append(VmFolderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as VmwareCloneParameters);
        }

        /// <summary>
        /// Returns true if VmwareCloneParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareCloneParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareCloneParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreFolderId == input.DatastoreFolderId ||
                    (this.DatastoreFolderId != null &&
                    this.DatastoreFolderId.Equals(input.DatastoreFolderId))
                ) && 
                (
                    this.DetachNetwork == input.DetachNetwork ||
                    (this.DetachNetwork != null &&
                    this.DetachNetwork.Equals(input.DetachNetwork))
                ) && 
                (
                    this.DisableNetwork == input.DisableNetwork ||
                    (this.DisableNetwork != null &&
                    this.DisableNetwork.Equals(input.DisableNetwork))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.NetworkMappings == input.NetworkMappings ||
                    this.NetworkMappings != null &&
                    input.NetworkMappings != null &&
                    this.NetworkMappings.SequenceEqual(input.NetworkMappings)
                ) && 
                (
                    this.PoweredOn == input.PoweredOn ||
                    (this.PoweredOn != null &&
                    this.PoweredOn.Equals(input.PoweredOn))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.ResourcePoolId == input.ResourcePoolId ||
                    (this.ResourcePoolId != null &&
                    this.ResourcePoolId.Equals(input.ResourcePoolId))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.VmFolderId == input.VmFolderId ||
                    (this.VmFolderId != null &&
                    this.VmFolderId.Equals(input.VmFolderId))
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
                if (this.DatastoreFolderId != null)
                    hashCode = hashCode * 59 + this.DatastoreFolderId.GetHashCode();
                if (this.DetachNetwork != null)
                    hashCode = hashCode * 59 + this.DetachNetwork.GetHashCode();
                if (this.DisableNetwork != null)
                    hashCode = hashCode * 59 + this.DisableNetwork.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.NetworkMappings != null)
                    hashCode = hashCode * 59 + this.NetworkMappings.GetHashCode();
                if (this.PoweredOn != null)
                    hashCode = hashCode * 59 + this.PoweredOn.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.ResourcePoolId != null)
                    hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.VmFolderId != null)
                    hashCode = hashCode * 59 + this.VmFolderId.GetHashCode();
                return hashCode;
            }
        }

    }

}
