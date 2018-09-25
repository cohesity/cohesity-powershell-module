// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the information required for recovering or cloning VmWare VMs.
    /// </summary>
    [DataContract]
    public partial class VmwareRestoreParameters :  IEquatable<VmwareRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareRestoreParameters" /> class.
        /// </summary>
        /// <param name="datastoreFolderId">Specifies the folder where the restore datastore should be created. This is applicable only when the VMs are being cloned..</param>
        /// <param name="datastoreId">Specifies the datastore where the object&#39;s files should be recovered to. This field is mandatory to recover objects to a different resource pool or to a different parent source. If not specified, objects are recovered to their original datastore locations in the parent source..</param>
        /// <param name="disableNetwork">Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it..</param>
        /// <param name="networkId">Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source..</param>
        /// <param name="poweredOn">Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off..</param>
        /// <param name="prefix">Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="resourcePoolId">Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent..</param>
        /// <param name="suffix">Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="vmFolderId">Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed..</param>
        public VmwareRestoreParameters(long? datastoreFolderId = default(long?), long? datastoreId = default(long?), bool? disableNetwork = default(bool?), long? networkId = default(long?), bool? poweredOn = default(bool?), string prefix = default(string), long? resourcePoolId = default(long?), string suffix = default(string), long? vmFolderId = default(long?))
        {
            this.DatastoreFolderId = datastoreFolderId;
            this.DatastoreId = datastoreId;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
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
        [DataMember(Name="datastoreFolderId", EmitDefaultValue=false)]
        public long? DatastoreFolderId { get; set; }

        /// <summary>
        /// Specifies the datastore where the object&#39;s files should be recovered to. This field is mandatory to recover objects to a different resource pool or to a different parent source. If not specified, objects are recovered to their original datastore locations in the parent source.
        /// </summary>
        /// <value>Specifies the datastore where the object&#39;s files should be recovered to. This field is mandatory to recover objects to a different resource pool or to a different parent source. If not specified, objects are recovered to their original datastore locations in the parent source.</value>
        [DataMember(Name="datastoreId", EmitDefaultValue=false)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.
        /// </summary>
        /// <value>Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=false)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.
        /// </summary>
        /// <value>Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.</value>
        [DataMember(Name="networkId", EmitDefaultValue=false)]
        public long? NetworkId { get; set; }

        /// <summary>
        /// Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.
        /// </summary>
        /// <value>Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.</value>
        [DataMember(Name="poweredOn", EmitDefaultValue=false)]
        public bool? PoweredOn { get; set; }

        /// <summary>
        /// Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.
        /// </summary>
        /// <value>Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.</value>
        [DataMember(Name="resourcePoolId", EmitDefaultValue=false)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed.
        /// </summary>
        /// <value>Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed.</value>
        [DataMember(Name="vmFolderId", EmitDefaultValue=false)]
        public long? VmFolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as VmwareRestoreParameters);
        }

        /// <summary>
        /// Returns true if VmwareRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareRestoreParameters input)
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
                    this.DatastoreId == input.DatastoreId ||
                    (this.DatastoreId != null &&
                    this.DatastoreId.Equals(input.DatastoreId))
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
                if (this.DatastoreId != null)
                    hashCode = hashCode * 59 + this.DatastoreId.GetHashCode();
                if (this.DisableNetwork != null)
                    hashCode = hashCode * 59 + this.DisableNetwork.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
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

