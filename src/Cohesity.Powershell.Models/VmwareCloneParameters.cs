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
        /// Specifies the type of recovery process to be performed. If unspecified, then an instant recovery will be performed. Specifies the recovery process type to be used.. &#39;kInstantRecovery&#39; indicates that an instant recovery should be performed. &#39;kCopyRecovery&#39; indicates that a copy recovery should be performed.
        /// </summary>
        /// <value>Specifies the type of recovery process to be performed. If unspecified, then an instant recovery will be performed. Specifies the recovery process type to be used.. &#39;kInstantRecovery&#39; indicates that an instant recovery should be performed. &#39;kCopyRecovery&#39; indicates that a copy recovery should be performed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecoveryProcessTypeEnum
        {
            /// <summary>
            /// Enum KInstantRecovery for value: kInstantRecovery
            /// </summary>
            [EnumMember(Value = "kInstantRecovery")]
            KInstantRecovery = 1,

            /// <summary>
            /// Enum KCopyRecovery for value: kCopyRecovery
            /// </summary>
            [EnumMember(Value = "kCopyRecovery")]
            KCopyRecovery = 2

        }

        /// <summary>
        /// Specifies the type of recovery process to be performed. If unspecified, then an instant recovery will be performed. Specifies the recovery process type to be used.. &#39;kInstantRecovery&#39; indicates that an instant recovery should be performed. &#39;kCopyRecovery&#39; indicates that a copy recovery should be performed.
        /// </summary>
        /// <value>Specifies the type of recovery process to be performed. If unspecified, then an instant recovery will be performed. Specifies the recovery process type to be used.. &#39;kInstantRecovery&#39; indicates that an instant recovery should be performed. &#39;kCopyRecovery&#39; indicates that a copy recovery should be performed.</value>
        [DataMember(Name="recoveryProcessType", EmitDefaultValue=true)]
        public RecoveryProcessTypeEnum? RecoveryProcessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareCloneParameters" /> class.
        /// </summary>
        /// <param name="attemptDifferentialRestore">Specifies whether to attempt differential restore..</param>
        /// <param name="datastoreFolderId">Specifies the folder where the restore datastore should be created. This is applicable only when the VMs are being cloned..</param>
        /// <param name="detachNetwork">Specifies whether the network should be detached from the recovered or cloned VMs..</param>
        /// <param name="disableNetwork">Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it..</param>
        /// <param name="networkId">Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source..</param>
        /// <param name="networkMappings">Specifies the parameters for mapping the source and target networks. This field can be used if restoring to a different parent source. This will replace the NetworkId and DisableNetwork that are used to provide configuration for a single network. Unless the support for mapping is available for all the entities old keys can be used to attach a new network. Supports &#39;kVMware&#39; for now..</param>
        /// <param name="orgVdcNetwork">orgVdcNetwork.</param>
        /// <param name="overwriteExistingVm">Specifies whether to overwrite the existing VM for a recovery when rename parameters are not given..</param>
        /// <param name="powerOffAndRenameExistingVm">Specifies whether to power off and rename the existing VM as deprecated for recovery when rename parameters are not given..</param>
        /// <param name="poweredOn">Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off..</param>
        /// <param name="prefix">Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="preserveCustomAttributesDuringClone">Specifies whether or not to preserve the custom attributes during the clone operation. The default behavior is &#39;true&#39;..</param>
        /// <param name="preserveTags">Specifies whether or not to preserve tags during the clone operation. The default behavior is &#39;true&#39;..</param>
        /// <param name="recoveryProcessType">Specifies the type of recovery process to be performed. If unspecified, then an instant recovery will be performed. Specifies the recovery process type to be used.. &#39;kInstantRecovery&#39; indicates that an instant recovery should be performed. &#39;kCopyRecovery&#39; indicates that a copy recovery should be performed..</param>
        /// <param name="resourcePoolId">Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent..</param>
        /// <param name="storageProfileName">Specifies the name of the destination storage profile while restoring to an alternate VCD location..</param>
        /// <param name="storageProfileVcdUuid">Specifies the UUID of the storage profile while restoring to an alternate VCD location..</param>
        /// <param name="suffix">Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="vAppId">Specifies the ID of the vApp to which a VM should be restored..</param>
        /// <param name="vdcId">Specifies the ID of the VDC to which a VM should be restored..</param>
        /// <param name="vmFolderId">Specifies a folder where the VMs should be restored. This is applicable only when the VMs are being restored to an alternate location or if clone is being performed..</param>
        public VmwareCloneParameters(bool? attemptDifferentialRestore = default(bool?), long? datastoreFolderId = default(long?), bool? detachNetwork = default(bool?), bool? disableNetwork = default(bool?), long? networkId = default(long?), List<NetworkMapping> networkMappings = default(List<NetworkMapping>), OrgVdcNetwork orgVdcNetwork = default(OrgVdcNetwork), bool? overwriteExistingVm = default(bool?), bool? powerOffAndRenameExistingVm = default(bool?), bool? poweredOn = default(bool?), string prefix = default(string), bool? preserveCustomAttributesDuringClone = default(bool?), bool? preserveTags = default(bool?), RecoveryProcessTypeEnum? recoveryProcessType = default(RecoveryProcessTypeEnum?), long? resourcePoolId = default(long?), string storageProfileName = default(string), string storageProfileVcdUuid = default(string), string suffix = default(string), long? vAppId = default(long?), long? vdcId = default(long?), long? vmFolderId = default(long?))
        {
            this.AttemptDifferentialRestore = attemptDifferentialRestore;
            this.DatastoreFolderId = datastoreFolderId;
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.NetworkMappings = networkMappings;
            this.OverwriteExistingVm = overwriteExistingVm;
            this.PowerOffAndRenameExistingVm = powerOffAndRenameExistingVm;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTags = preserveTags;
            this.RecoveryProcessType = recoveryProcessType;
            this.ResourcePoolId = resourcePoolId;
            this.StorageProfileName = storageProfileName;
            this.StorageProfileVcdUuid = storageProfileVcdUuid;
            this.Suffix = suffix;
            this.VAppId = vAppId;
            this.VdcId = vdcId;
            this.VmFolderId = vmFolderId;
            this.AttemptDifferentialRestore = attemptDifferentialRestore;
            this.DatastoreFolderId = datastoreFolderId;
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.NetworkMappings = networkMappings;
            this.OrgVdcNetwork = orgVdcNetwork;
            this.OverwriteExistingVm = overwriteExistingVm;
            this.PowerOffAndRenameExistingVm = powerOffAndRenameExistingVm;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTags = preserveTags;
            this.RecoveryProcessType = recoveryProcessType;
            this.ResourcePoolId = resourcePoolId;
            this.StorageProfileName = storageProfileName;
            this.StorageProfileVcdUuid = storageProfileVcdUuid;
            this.Suffix = suffix;
            this.VAppId = vAppId;
            this.VdcId = vdcId;
            this.VmFolderId = vmFolderId;
        }
        
        /// <summary>
        /// Specifies whether to attempt differential restore.
        /// </summary>
        /// <value>Specifies whether to attempt differential restore.</value>
        [DataMember(Name="attemptDifferentialRestore", EmitDefaultValue=true)]
        public bool? AttemptDifferentialRestore { get; set; }

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
        /// Gets or Sets OrgVdcNetwork
        /// </summary>
        [DataMember(Name="orgVdcNetwork", EmitDefaultValue=false)]
        public OrgVdcNetwork OrgVdcNetwork { get; set; }

        /// <summary>
        /// Specifies whether to overwrite the existing VM for a recovery when rename parameters are not given.
        /// </summary>
        /// <value>Specifies whether to overwrite the existing VM for a recovery when rename parameters are not given.</value>
        [DataMember(Name="overwriteExistingVm", EmitDefaultValue=true)]
        public bool? OverwriteExistingVm { get; set; }

        /// <summary>
        /// Specifies whether to power off and rename the existing VM as deprecated for recovery when rename parameters are not given.
        /// </summary>
        /// <value>Specifies whether to power off and rename the existing VM as deprecated for recovery when rename parameters are not given.</value>
        [DataMember(Name="powerOffAndRenameExistingVm", EmitDefaultValue=true)]
        public bool? PowerOffAndRenameExistingVm { get; set; }

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
        /// Specifies whether or not to preserve the custom attributes during the clone operation. The default behavior is &#39;true&#39;.
        /// </summary>
        /// <value>Specifies whether or not to preserve the custom attributes during the clone operation. The default behavior is &#39;true&#39;.</value>
        [DataMember(Name="preserveCustomAttributesDuringClone", EmitDefaultValue=true)]
        public bool? PreserveCustomAttributesDuringClone { get; set; }

        /// <summary>
        /// Specifies whether or not to preserve tags during the clone operation. The default behavior is &#39;true&#39;.
        /// </summary>
        /// <value>Specifies whether or not to preserve tags during the clone operation. The default behavior is &#39;true&#39;.</value>
        [DataMember(Name="preserveTags", EmitDefaultValue=true)]
        public bool? PreserveTags { get; set; }

        /// <summary>
        /// Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.
        /// </summary>
        /// <value>Specifies the resource pool where the cloned or recovered objects are attached. This field is mandatory for kCloneVMs Restore Tasks always. For kRecoverVMs Restore Tasks, this field is mandatory only if newParentId field is specified. If this field is not specified, recovered objects are attached to the original resource pool under the original parent.</value>
        [DataMember(Name="resourcePoolId", EmitDefaultValue=true)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// Specifies the name of the destination storage profile while restoring to an alternate VCD location.
        /// </summary>
        /// <value>Specifies the name of the destination storage profile while restoring to an alternate VCD location.</value>
        [DataMember(Name="storageProfileName", EmitDefaultValue=true)]
        public string StorageProfileName { get; set; }

        /// <summary>
        /// Specifies the UUID of the storage profile while restoring to an alternate VCD location.
        /// </summary>
        /// <value>Specifies the UUID of the storage profile while restoring to an alternate VCD location.</value>
        [DataMember(Name="storageProfileVcdUuid", EmitDefaultValue=true)]
        public string StorageProfileVcdUuid { get; set; }

        /// <summary>
        /// Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Specifies the ID of the vApp to which a VM should be restored.
        /// </summary>
        /// <value>Specifies the ID of the vApp to which a VM should be restored.</value>
        [DataMember(Name="vAppId", EmitDefaultValue=true)]
        public long? VAppId { get; set; }

        /// <summary>
        /// Specifies the ID of the VDC to which a VM should be restored.
        /// </summary>
        /// <value>Specifies the ID of the VDC to which a VM should be restored.</value>
        [DataMember(Name="vdcId", EmitDefaultValue=true)]
        public long? VdcId { get; set; }

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
                    this.AttemptDifferentialRestore == input.AttemptDifferentialRestore ||
                    (this.AttemptDifferentialRestore != null &&
                    this.AttemptDifferentialRestore.Equals(input.AttemptDifferentialRestore))
                ) && 
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
                    this.OrgVdcNetwork == input.OrgVdcNetwork ||
                    (this.OrgVdcNetwork != null &&
                    this.OrgVdcNetwork.Equals(input.OrgVdcNetwork))
                ) && 
                (
                    this.OverwriteExistingVm == input.OverwriteExistingVm ||
                    (this.OverwriteExistingVm != null &&
                    this.OverwriteExistingVm.Equals(input.OverwriteExistingVm))
                ) && 
                (
                    this.PowerOffAndRenameExistingVm == input.PowerOffAndRenameExistingVm ||
                    (this.PowerOffAndRenameExistingVm != null &&
                    this.PowerOffAndRenameExistingVm.Equals(input.PowerOffAndRenameExistingVm))
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
                    this.PreserveCustomAttributesDuringClone == input.PreserveCustomAttributesDuringClone ||
                    (this.PreserveCustomAttributesDuringClone != null &&
                    this.PreserveCustomAttributesDuringClone.Equals(input.PreserveCustomAttributesDuringClone))
                ) && 
                (
                    this.PreserveTags == input.PreserveTags ||
                    (this.PreserveTags != null &&
                    this.PreserveTags.Equals(input.PreserveTags))
                ) && 
                (
                    this.RecoveryProcessType == input.RecoveryProcessType ||
                    this.RecoveryProcessType.Equals(input.RecoveryProcessType)
                ) && 
                (
                    this.ResourcePoolId == input.ResourcePoolId ||
                    (this.ResourcePoolId != null &&
                    this.ResourcePoolId.Equals(input.ResourcePoolId))
                ) && 
                (
                    this.StorageProfileName == input.StorageProfileName ||
                    (this.StorageProfileName != null &&
                    this.StorageProfileName.Equals(input.StorageProfileName))
                ) && 
                (
                    this.StorageProfileVcdUuid == input.StorageProfileVcdUuid ||
                    (this.StorageProfileVcdUuid != null &&
                    this.StorageProfileVcdUuid.Equals(input.StorageProfileVcdUuid))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.VAppId == input.VAppId ||
                    (this.VAppId != null &&
                    this.VAppId.Equals(input.VAppId))
                ) && 
                (
                    this.VdcId == input.VdcId ||
                    (this.VdcId != null &&
                    this.VdcId.Equals(input.VdcId))
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
                if (this.AttemptDifferentialRestore != null)
                    hashCode = hashCode * 59 + this.AttemptDifferentialRestore.GetHashCode();
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
                if (this.OrgVdcNetwork != null)
                    hashCode = hashCode * 59 + this.OrgVdcNetwork.GetHashCode();
                if (this.OverwriteExistingVm != null)
                    hashCode = hashCode * 59 + this.OverwriteExistingVm.GetHashCode();
                if (this.PowerOffAndRenameExistingVm != null)
                    hashCode = hashCode * 59 + this.PowerOffAndRenameExistingVm.GetHashCode();
                if (this.PoweredOn != null)
                    hashCode = hashCode * 59 + this.PoweredOn.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.PreserveCustomAttributesDuringClone != null)
                    hashCode = hashCode * 59 + this.PreserveCustomAttributesDuringClone.GetHashCode();
                if (this.PreserveTags != null)
                    hashCode = hashCode * 59 + this.PreserveTags.GetHashCode();
                hashCode = hashCode * 59 + this.RecoveryProcessType.GetHashCode();
                if (this.ResourcePoolId != null)
                    hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.StorageProfileName != null)
                    hashCode = hashCode * 59 + this.StorageProfileName.GetHashCode();
                if (this.StorageProfileVcdUuid != null)
                    hashCode = hashCode * 59 + this.StorageProfileVcdUuid.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.VAppId != null)
                    hashCode = hashCode * 59 + this.VAppId.GetHashCode();
                if (this.VdcId != null)
                    hashCode = hashCode * 59 + this.VdcId.GetHashCode();
                if (this.VmFolderId != null)
                    hashCode = hashCode * 59 + this.VmFolderId.GetHashCode();
                return hashCode;
            }
        }

    }

}

