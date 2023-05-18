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
    /// RestoreVMwareVMParams
    /// </summary>
    [DataContract]
    public partial class RestoreVMwareVMParams :  IEquatable<RestoreVMwareVMParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreVMwareVMParams" /> class.
        /// </summary>
        /// <param name="allowNbdsslTransportFallback">Whether to fallback to use NBDSSL transport for recovery in case using SAN transport recovery fails..</param>
        /// <param name="attemptDifferentialRestore">This field is only applicable when overwrite_existing_vm is set to true. If this field is true, as part of overwrite existing vm, differential restore will be attempted..</param>
        /// <param name="catalogUuid">Specifies the name of the catalog for vapp template recovery. This is applicable for recovery to a VCD..</param>
        /// <param name="copyRecovery">Whether to perform copy recovery instead of instant recovery..</param>
        /// <param name="datastoreEntityVec">Datastore entities if the restore is to alternate location..</param>
        /// <param name="diskProvisionType">This specifies vmware virtual disk provisioning policies.</param>
        /// <param name="isOnPremDeploy">This will be true if this is on prem deploy task. attempt_differential_restore should also be set to true in case of doing on prem deploy..</param>
        /// <param name="orgVdcNetworkName">Specifies the name of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD..</param>
        /// <param name="orgVdcNetworkVcdUuid">Specifies the VCD UUID of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD..</param>
        /// <param name="overwriteExistingVm">This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with power_off_and_rename_existing_vm..</param>
        /// <param name="powerOffAndRenameExistingVm">This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with overwrite_existing_vm..</param>
        /// <param name="preserveCustomAttributesDuringClone">Whether to preserve custom attributes for the clone op..</param>
        /// <param name="preserveTagsDuringClone">Whether to preserve tags for the clone op..</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="storageProfileName">This is only populated for VCD restore to alternate location. It contains the name of the destination storage profile..</param>
        /// <param name="storageProfileVcdUuid">This is only populated for VCD restore to alternate location. It contains the vcd uuid of the destination storage profile..</param>
        /// <param name="targetDatastoreFolder">targetDatastoreFolder.</param>
        /// <param name="targetVmFolder">targetVmFolder.</param>
        public RestoreVMwareVMParams(bool? allowNbdsslTransportFallback = default(bool?), bool? attemptDifferentialRestore = default(bool?), string catalogUuid = default(string), bool? copyRecovery = default(bool?), List<EntityProto> datastoreEntityVec = default(List<EntityProto>), int? diskProvisionType = default(int?), bool? isOnPremDeploy = default(bool?), string orgVdcNetworkName = default(string), string orgVdcNetworkVcdUuid = default(string), bool? overwriteExistingVm = default(bool?), bool? powerOffAndRenameExistingVm = default(bool?), bool? preserveCustomAttributesDuringClone = default(bool?), bool? preserveTagsDuringClone = default(bool?), EntityProto resourcePoolEntity = default(EntityProto), string storageProfileName = default(string), string storageProfileVcdUuid = default(string), EntityProto targetDatastoreFolder = default(EntityProto), EntityProto targetVmFolder = default(EntityProto))
        {
            this.AllowNbdsslTransportFallback = allowNbdsslTransportFallback;
            this.AttemptDifferentialRestore = attemptDifferentialRestore;
            this.CatalogUuid = catalogUuid;
            this.CopyRecovery = copyRecovery;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.DiskProvisionType = diskProvisionType;
            this.IsOnPremDeploy = isOnPremDeploy;
            this.OrgVdcNetworkName = orgVdcNetworkName;
            this.OrgVdcNetworkVcdUuid = orgVdcNetworkVcdUuid;
            this.OverwriteExistingVm = overwriteExistingVm;
            this.PowerOffAndRenameExistingVm = powerOffAndRenameExistingVm;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTagsDuringClone = preserveTagsDuringClone;
            this.StorageProfileName = storageProfileName;
            this.StorageProfileVcdUuid = storageProfileVcdUuid;
            this.AllowNbdsslTransportFallback = allowNbdsslTransportFallback;
            this.AttemptDifferentialRestore = attemptDifferentialRestore;
            this.CatalogUuid = catalogUuid;
            this.CopyRecovery = copyRecovery;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.DiskProvisionType = diskProvisionType;
            this.IsOnPremDeploy = isOnPremDeploy;
            this.OrgVdcNetworkName = orgVdcNetworkName;
            this.OrgVdcNetworkVcdUuid = orgVdcNetworkVcdUuid;
            this.OverwriteExistingVm = overwriteExistingVm;
            this.PowerOffAndRenameExistingVm = powerOffAndRenameExistingVm;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTagsDuringClone = preserveTagsDuringClone;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.StorageProfileName = storageProfileName;
            this.StorageProfileVcdUuid = storageProfileVcdUuid;
            this.TargetDatastoreFolder = targetDatastoreFolder;
            this.TargetVmFolder = targetVmFolder;
        }
        
        /// <summary>
        /// Whether to fallback to use NBDSSL transport for recovery in case using SAN transport recovery fails.
        /// </summary>
        /// <value>Whether to fallback to use NBDSSL transport for recovery in case using SAN transport recovery fails.</value>
        [DataMember(Name="allowNbdsslTransportFallback", EmitDefaultValue=true)]
        public bool? AllowNbdsslTransportFallback { get; set; }

        /// <summary>
        /// This field is only applicable when overwrite_existing_vm is set to true. If this field is true, as part of overwrite existing vm, differential restore will be attempted.
        /// </summary>
        /// <value>This field is only applicable when overwrite_existing_vm is set to true. If this field is true, as part of overwrite existing vm, differential restore will be attempted.</value>
        [DataMember(Name="attemptDifferentialRestore", EmitDefaultValue=true)]
        public bool? AttemptDifferentialRestore { get; set; }

        /// <summary>
        /// Specifies the name of the catalog for vapp template recovery. This is applicable for recovery to a VCD.
        /// </summary>
        /// <value>Specifies the name of the catalog for vapp template recovery. This is applicable for recovery to a VCD.</value>
        [DataMember(Name="catalogUuid", EmitDefaultValue=true)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// Whether to perform copy recovery instead of instant recovery.
        /// </summary>
        /// <value>Whether to perform copy recovery instead of instant recovery.</value>
        [DataMember(Name="copyRecovery", EmitDefaultValue=true)]
        public bool? CopyRecovery { get; set; }

        /// <summary>
        /// Datastore entities if the restore is to alternate location.
        /// </summary>
        /// <value>Datastore entities if the restore is to alternate location.</value>
        [DataMember(Name="datastoreEntityVec", EmitDefaultValue=true)]
        public List<EntityProto> DatastoreEntityVec { get; set; }

        /// <summary>
        /// This specifies vmware virtual disk provisioning policies
        /// </summary>
        /// <value>This specifies vmware virtual disk provisioning policies</value>
        [DataMember(Name="diskProvisionType", EmitDefaultValue=true)]
        public int? DiskProvisionType { get; set; }

        /// <summary>
        /// This will be true if this is on prem deploy task. attempt_differential_restore should also be set to true in case of doing on prem deploy.
        /// </summary>
        /// <value>This will be true if this is on prem deploy task. attempt_differential_restore should also be set to true in case of doing on prem deploy.</value>
        [DataMember(Name="isOnPremDeploy", EmitDefaultValue=true)]
        public bool? IsOnPremDeploy { get; set; }

        /// <summary>
        /// Specifies the name of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD.
        /// </summary>
        /// <value>Specifies the name of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD.</value>
        [DataMember(Name="orgVdcNetworkName", EmitDefaultValue=true)]
        public string OrgVdcNetworkName { get; set; }

        /// <summary>
        /// Specifies the VCD UUID of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD.
        /// </summary>
        /// <value>Specifies the VCD UUID of the org VDC network to be used for the recovery. This is applicable for recovery to a VCD.</value>
        [DataMember(Name="orgVdcNetworkVcdUuid", EmitDefaultValue=true)]
        public string OrgVdcNetworkVcdUuid { get; set; }

        /// <summary>
        /// This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with power_off_and_rename_existing_vm.
        /// </summary>
        /// <value>This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with power_off_and_rename_existing_vm.</value>
        [DataMember(Name="overwriteExistingVm", EmitDefaultValue=true)]
        public bool? OverwriteExistingVm { get; set; }

        /// <summary>
        /// This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with overwrite_existing_vm.
        /// </summary>
        /// <value>This option is only potentially populated in the case that there are no rename parameters specified for a recovery. Note that this option is mutually exclusive with overwrite_existing_vm.</value>
        [DataMember(Name="powerOffAndRenameExistingVm", EmitDefaultValue=true)]
        public bool? PowerOffAndRenameExistingVm { get; set; }

        /// <summary>
        /// Whether to preserve custom attributes for the clone op.
        /// </summary>
        /// <value>Whether to preserve custom attributes for the clone op.</value>
        [DataMember(Name="preserveCustomAttributesDuringClone", EmitDefaultValue=true)]
        public bool? PreserveCustomAttributesDuringClone { get; set; }

        /// <summary>
        /// Whether to preserve tags for the clone op.
        /// </summary>
        /// <value>Whether to preserve tags for the clone op.</value>
        [DataMember(Name="preserveTagsDuringClone", EmitDefaultValue=true)]
        public bool? PreserveTagsDuringClone { get; set; }

        /// <summary>
        /// Gets or Sets ResourcePoolEntity
        /// </summary>
        [DataMember(Name="resourcePoolEntity", EmitDefaultValue=false)]
        public EntityProto ResourcePoolEntity { get; set; }

        /// <summary>
        /// This is only populated for VCD restore to alternate location. It contains the name of the destination storage profile.
        /// </summary>
        /// <value>This is only populated for VCD restore to alternate location. It contains the name of the destination storage profile.</value>
        [DataMember(Name="storageProfileName", EmitDefaultValue=true)]
        public string StorageProfileName { get; set; }

        /// <summary>
        /// This is only populated for VCD restore to alternate location. It contains the vcd uuid of the destination storage profile.
        /// </summary>
        /// <value>This is only populated for VCD restore to alternate location. It contains the vcd uuid of the destination storage profile.</value>
        [DataMember(Name="storageProfileVcdUuid", EmitDefaultValue=true)]
        public string StorageProfileVcdUuid { get; set; }

        /// <summary>
        /// Gets or Sets TargetDatastoreFolder
        /// </summary>
        [DataMember(Name="targetDatastoreFolder", EmitDefaultValue=false)]
        public EntityProto TargetDatastoreFolder { get; set; }

        /// <summary>
        /// Gets or Sets TargetVmFolder
        /// </summary>
        [DataMember(Name="targetVmFolder", EmitDefaultValue=false)]
        public EntityProto TargetVmFolder { get; set; }

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
            return this.Equals(input as RestoreVMwareVMParams);
        }

        /// <summary>
        /// Returns true if RestoreVMwareVMParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreVMwareVMParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreVMwareVMParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowNbdsslTransportFallback == input.AllowNbdsslTransportFallback ||
                    (this.AllowNbdsslTransportFallback != null &&
                    this.AllowNbdsslTransportFallback.Equals(input.AllowNbdsslTransportFallback))
                ) && 
                (
                    this.AttemptDifferentialRestore == input.AttemptDifferentialRestore ||
                    (this.AttemptDifferentialRestore != null &&
                    this.AttemptDifferentialRestore.Equals(input.AttemptDifferentialRestore))
                ) && 
                (
                    this.CatalogUuid == input.CatalogUuid ||
                    (this.CatalogUuid != null &&
                    this.CatalogUuid.Equals(input.CatalogUuid))
                ) && 
                (
                    this.CopyRecovery == input.CopyRecovery ||
                    (this.CopyRecovery != null &&
                    this.CopyRecovery.Equals(input.CopyRecovery))
                ) && 
                (
                    this.DatastoreEntityVec == input.DatastoreEntityVec ||
                    this.DatastoreEntityVec != null &&
                    input.DatastoreEntityVec != null &&
                    this.DatastoreEntityVec.SequenceEqual(input.DatastoreEntityVec)
                ) && 
                (
                    this.DiskProvisionType == input.DiskProvisionType ||
                    (this.DiskProvisionType != null &&
                    this.DiskProvisionType.Equals(input.DiskProvisionType))
                ) && 
                (
                    this.IsOnPremDeploy == input.IsOnPremDeploy ||
                    (this.IsOnPremDeploy != null &&
                    this.IsOnPremDeploy.Equals(input.IsOnPremDeploy))
                ) && 
                (
                    this.OrgVdcNetworkName == input.OrgVdcNetworkName ||
                    (this.OrgVdcNetworkName != null &&
                    this.OrgVdcNetworkName.Equals(input.OrgVdcNetworkName))
                ) && 
                (
                    this.OrgVdcNetworkVcdUuid == input.OrgVdcNetworkVcdUuid ||
                    (this.OrgVdcNetworkVcdUuid != null &&
                    this.OrgVdcNetworkVcdUuid.Equals(input.OrgVdcNetworkVcdUuid))
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
                    this.PreserveCustomAttributesDuringClone == input.PreserveCustomAttributesDuringClone ||
                    (this.PreserveCustomAttributesDuringClone != null &&
                    this.PreserveCustomAttributesDuringClone.Equals(input.PreserveCustomAttributesDuringClone))
                ) && 
                (
                    this.PreserveTagsDuringClone == input.PreserveTagsDuringClone ||
                    (this.PreserveTagsDuringClone != null &&
                    this.PreserveTagsDuringClone.Equals(input.PreserveTagsDuringClone))
                ) && 
                (
                    this.ResourcePoolEntity == input.ResourcePoolEntity ||
                    (this.ResourcePoolEntity != null &&
                    this.ResourcePoolEntity.Equals(input.ResourcePoolEntity))
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
                    this.TargetDatastoreFolder == input.TargetDatastoreFolder ||
                    (this.TargetDatastoreFolder != null &&
                    this.TargetDatastoreFolder.Equals(input.TargetDatastoreFolder))
                ) && 
                (
                    this.TargetVmFolder == input.TargetVmFolder ||
                    (this.TargetVmFolder != null &&
                    this.TargetVmFolder.Equals(input.TargetVmFolder))
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
                if (this.AllowNbdsslTransportFallback != null)
                    hashCode = hashCode * 59 + this.AllowNbdsslTransportFallback.GetHashCode();
                if (this.AttemptDifferentialRestore != null)
                    hashCode = hashCode * 59 + this.AttemptDifferentialRestore.GetHashCode();
                if (this.CatalogUuid != null)
                    hashCode = hashCode * 59 + this.CatalogUuid.GetHashCode();
                if (this.CopyRecovery != null)
                    hashCode = hashCode * 59 + this.CopyRecovery.GetHashCode();
                if (this.DatastoreEntityVec != null)
                    hashCode = hashCode * 59 + this.DatastoreEntityVec.GetHashCode();
                if (this.DiskProvisionType != null)
                    hashCode = hashCode * 59 + this.DiskProvisionType.GetHashCode();
                if (this.IsOnPremDeploy != null)
                    hashCode = hashCode * 59 + this.IsOnPremDeploy.GetHashCode();
                if (this.OrgVdcNetworkName != null)
                    hashCode = hashCode * 59 + this.OrgVdcNetworkName.GetHashCode();
                if (this.OrgVdcNetworkVcdUuid != null)
                    hashCode = hashCode * 59 + this.OrgVdcNetworkVcdUuid.GetHashCode();
                if (this.OverwriteExistingVm != null)
                    hashCode = hashCode * 59 + this.OverwriteExistingVm.GetHashCode();
                if (this.PowerOffAndRenameExistingVm != null)
                    hashCode = hashCode * 59 + this.PowerOffAndRenameExistingVm.GetHashCode();
                if (this.PreserveCustomAttributesDuringClone != null)
                    hashCode = hashCode * 59 + this.PreserveCustomAttributesDuringClone.GetHashCode();
                if (this.PreserveTagsDuringClone != null)
                    hashCode = hashCode * 59 + this.PreserveTagsDuringClone.GetHashCode();
                if (this.ResourcePoolEntity != null)
                    hashCode = hashCode * 59 + this.ResourcePoolEntity.GetHashCode();
                if (this.StorageProfileName != null)
                    hashCode = hashCode * 59 + this.StorageProfileName.GetHashCode();
                if (this.StorageProfileVcdUuid != null)
                    hashCode = hashCode * 59 + this.StorageProfileVcdUuid.GetHashCode();
                if (this.TargetDatastoreFolder != null)
                    hashCode = hashCode * 59 + this.TargetDatastoreFolder.GetHashCode();
                if (this.TargetVmFolder != null)
                    hashCode = hashCode * 59 + this.TargetVmFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

