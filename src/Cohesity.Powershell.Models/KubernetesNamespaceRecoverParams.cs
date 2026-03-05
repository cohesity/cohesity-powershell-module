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
    /// KubernetesNamespaceRecoverParams
    /// </summary>
    [DataContract]
    public partial class KubernetesNamespaceRecoverParams :  IEquatable<KubernetesNamespaceRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesNamespaceRecoverParams" /> class.
        /// </summary>
        /// <param name="excludeParams">excludeParams.</param>
        /// <param name="excludedPvcVec">List of PVCs that user requested to be excluded while doing restore..</param>
        /// <param name="includeParams">includeParams.</param>
        /// <param name="isClusterLevelRecoveryEnabled">Indicates whether cluster-level recovery should be performed..</param>
        /// <param name="migrationRules">migrationRules.</param>
        /// <param name="pvcOnlyRestore">Whether to restore only pvc or all the namespace resources..</param>
        /// <param name="storageClassTranslationMap">Storage class translation requested by user for the restore. Map to store custom arguments which will be provided to the source registration scripts..</param>
        /// <param name="unbindPvcs">Whether to remove the PVC -&gt; PV binding from all PVCs during the restore. This will clear the volumeName field and related annotations from the PVC essentially removing its binding from the PV. For dynamic PVC - a new PV will be provisioned by the storage class. For static PVC - a free PV matching the PVC&#39;s criteria will bind to it..</param>
        /// <param name="useInstantRecovery">Boolean to represent whether the VMs are to be recovered using instant recovery. The VMs will be restored using copy recovery by default i.e. when this field is unset or set to false..</param>
        /// <param name="usePluginForExcludedPvcs">Whether to use the Velero plugin to skip creation of user-excluded PVCs during restore. When enabled, the plugin will set SkipRestore&#x3D;true for excluded PVCs, eliminating the need to create and delete dummy PVCs. This is automatically enabled by the master op if: 1. The gflag magneto_kubernetes_use_plugin_for_excluded_pvcs is enabled AND 2. The Cohesity Velero plugin is installed on the target cluster The master op validates these conditions and sets this field before sending the restore task to the slave. The slave op reads this field to determine which approach to use (plugin-based vs legacy dummy PVCs)..</param>
        public KubernetesNamespaceRecoverParams(K8SFilterParams excludeParams = default(K8SFilterParams), List<string> excludedPvcVec = default(List<string>), K8SFilterParams includeParams = default(K8SFilterParams), bool? isClusterLevelRecoveryEnabled = default(bool?), KubernetesNamespaceRecoverParamsMigrationRuleParams migrationRules = default(KubernetesNamespaceRecoverParamsMigrationRuleParams), bool? pvcOnlyRestore = default(bool?), Dictionary<string, string> storageClassTranslationMap = default(Dictionary<string, string>), bool? unbindPvcs = default(bool?), bool? useInstantRecovery = default(bool?), bool? usePluginForExcludedPvcs = default(bool?))
        {
            this.ExcludedPvcVec = excludedPvcVec;
            this.IsClusterLevelRecoveryEnabled = isClusterLevelRecoveryEnabled;
            this.PvcOnlyRestore = pvcOnlyRestore;
            this.StorageClassTranslationMap = storageClassTranslationMap;
            this.UnbindPvcs = unbindPvcs;
            this.UseInstantRecovery = useInstantRecovery;
            this.UsePluginForExcludedPvcs = usePluginForExcludedPvcs;
            this.ExcludeParams = excludeParams;
            this.ExcludedPvcVec = excludedPvcVec;
            this.IncludeParams = includeParams;
            this.IsClusterLevelRecoveryEnabled = isClusterLevelRecoveryEnabled;
            this.MigrationRules = migrationRules;
            this.PvcOnlyRestore = pvcOnlyRestore;
            this.StorageClassTranslationMap = storageClassTranslationMap;
            this.UnbindPvcs = unbindPvcs;
            this.UseInstantRecovery = useInstantRecovery;
            this.UsePluginForExcludedPvcs = usePluginForExcludedPvcs;
        }
        
        /// <summary>
        /// Gets or Sets ExcludeParams
        /// </summary>
        [DataMember(Name="excludeParams", EmitDefaultValue=false)]
        public K8SFilterParams ExcludeParams { get; set; }

        /// <summary>
        /// List of PVCs that user requested to be excluded while doing restore.
        /// </summary>
        /// <value>List of PVCs that user requested to be excluded while doing restore.</value>
        [DataMember(Name="excludedPvcVec", EmitDefaultValue=true)]
        public List<string> ExcludedPvcVec { get; set; }

        /// <summary>
        /// Gets or Sets IncludeParams
        /// </summary>
        [DataMember(Name="includeParams", EmitDefaultValue=false)]
        public K8SFilterParams IncludeParams { get; set; }

        /// <summary>
        /// Indicates whether cluster-level recovery should be performed.
        /// </summary>
        /// <value>Indicates whether cluster-level recovery should be performed.</value>
        [DataMember(Name="isClusterLevelRecoveryEnabled", EmitDefaultValue=true)]
        public bool? IsClusterLevelRecoveryEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MigrationRules
        /// </summary>
        [DataMember(Name="migrationRules", EmitDefaultValue=false)]
        public KubernetesNamespaceRecoverParamsMigrationRuleParams MigrationRules { get; set; }

        /// <summary>
        /// Whether to restore only pvc or all the namespace resources.
        /// </summary>
        /// <value>Whether to restore only pvc or all the namespace resources.</value>
        [DataMember(Name="pvcOnlyRestore", EmitDefaultValue=true)]
        public bool? PvcOnlyRestore { get; set; }

        /// <summary>
        /// Storage class translation requested by user for the restore. Map to store custom arguments which will be provided to the source registration scripts.
        /// </summary>
        /// <value>Storage class translation requested by user for the restore. Map to store custom arguments which will be provided to the source registration scripts.</value>
        [DataMember(Name="storageClassTranslationMap", EmitDefaultValue=true)]
        public Dictionary<string, string> StorageClassTranslationMap { get; set; }

        /// <summary>
        /// Whether to remove the PVC -&gt; PV binding from all PVCs during the restore. This will clear the volumeName field and related annotations from the PVC essentially removing its binding from the PV. For dynamic PVC - a new PV will be provisioned by the storage class. For static PVC - a free PV matching the PVC&#39;s criteria will bind to it.
        /// </summary>
        /// <value>Whether to remove the PVC -&gt; PV binding from all PVCs during the restore. This will clear the volumeName field and related annotations from the PVC essentially removing its binding from the PV. For dynamic PVC - a new PV will be provisioned by the storage class. For static PVC - a free PV matching the PVC&#39;s criteria will bind to it.</value>
        [DataMember(Name="unbindPvcs", EmitDefaultValue=true)]
        public bool? UnbindPvcs { get; set; }

        /// <summary>
        /// Boolean to represent whether the VMs are to be recovered using instant recovery. The VMs will be restored using copy recovery by default i.e. when this field is unset or set to false.
        /// </summary>
        /// <value>Boolean to represent whether the VMs are to be recovered using instant recovery. The VMs will be restored using copy recovery by default i.e. when this field is unset or set to false.</value>
        [DataMember(Name="useInstantRecovery", EmitDefaultValue=true)]
        public bool? UseInstantRecovery { get; set; }

        /// <summary>
        /// Whether to use the Velero plugin to skip creation of user-excluded PVCs during restore. When enabled, the plugin will set SkipRestore&#x3D;true for excluded PVCs, eliminating the need to create and delete dummy PVCs. This is automatically enabled by the master op if: 1. The gflag magneto_kubernetes_use_plugin_for_excluded_pvcs is enabled AND 2. The Cohesity Velero plugin is installed on the target cluster The master op validates these conditions and sets this field before sending the restore task to the slave. The slave op reads this field to determine which approach to use (plugin-based vs legacy dummy PVCs).
        /// </summary>
        /// <value>Whether to use the Velero plugin to skip creation of user-excluded PVCs during restore. When enabled, the plugin will set SkipRestore&#x3D;true for excluded PVCs, eliminating the need to create and delete dummy PVCs. This is automatically enabled by the master op if: 1. The gflag magneto_kubernetes_use_plugin_for_excluded_pvcs is enabled AND 2. The Cohesity Velero plugin is installed on the target cluster The master op validates these conditions and sets this field before sending the restore task to the slave. The slave op reads this field to determine which approach to use (plugin-based vs legacy dummy PVCs).</value>
        [DataMember(Name="usePluginForExcludedPvcs", EmitDefaultValue=true)]
        public bool? UsePluginForExcludedPvcs { get; set; }

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
            return this.Equals(input as KubernetesNamespaceRecoverParams);
        }

        /// <summary>
        /// Returns true if KubernetesNamespaceRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesNamespaceRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesNamespaceRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeParams == input.ExcludeParams ||
                    (this.ExcludeParams != null &&
                    this.ExcludeParams.Equals(input.ExcludeParams))
                ) && 
                (
                    this.ExcludedPvcVec == input.ExcludedPvcVec ||
                    this.ExcludedPvcVec != null &&
                    input.ExcludedPvcVec != null &&
                    this.ExcludedPvcVec.SequenceEqual(input.ExcludedPvcVec)
                ) && 
                (
                    this.IncludeParams == input.IncludeParams ||
                    (this.IncludeParams != null &&
                    this.IncludeParams.Equals(input.IncludeParams))
                ) && 
                (
                    this.IsClusterLevelRecoveryEnabled == input.IsClusterLevelRecoveryEnabled ||
                    (this.IsClusterLevelRecoveryEnabled != null &&
                    this.IsClusterLevelRecoveryEnabled.Equals(input.IsClusterLevelRecoveryEnabled))
                ) && 
                (
                    this.MigrationRules == input.MigrationRules ||
                    (this.MigrationRules != null &&
                    this.MigrationRules.Equals(input.MigrationRules))
                ) && 
                (
                    this.PvcOnlyRestore == input.PvcOnlyRestore ||
                    (this.PvcOnlyRestore != null &&
                    this.PvcOnlyRestore.Equals(input.PvcOnlyRestore))
                ) && 
                (
                    this.StorageClassTranslationMap == input.StorageClassTranslationMap ||
                    this.StorageClassTranslationMap != null &&
                    input.StorageClassTranslationMap != null &&
                    this.StorageClassTranslationMap.SequenceEqual(input.StorageClassTranslationMap)
                ) && 
                (
                    this.UnbindPvcs == input.UnbindPvcs ||
                    (this.UnbindPvcs != null &&
                    this.UnbindPvcs.Equals(input.UnbindPvcs))
                ) && 
                (
                    this.UseInstantRecovery == input.UseInstantRecovery ||
                    (this.UseInstantRecovery != null &&
                    this.UseInstantRecovery.Equals(input.UseInstantRecovery))
                ) && 
                (
                    this.UsePluginForExcludedPvcs == input.UsePluginForExcludedPvcs ||
                    (this.UsePluginForExcludedPvcs != null &&
                    this.UsePluginForExcludedPvcs.Equals(input.UsePluginForExcludedPvcs))
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
                if (this.ExcludeParams != null)
                    hashCode = hashCode * 59 + this.ExcludeParams.GetHashCode();
                if (this.ExcludedPvcVec != null)
                    hashCode = hashCode * 59 + this.ExcludedPvcVec.GetHashCode();
                if (this.IncludeParams != null)
                    hashCode = hashCode * 59 + this.IncludeParams.GetHashCode();
                if (this.IsClusterLevelRecoveryEnabled != null)
                    hashCode = hashCode * 59 + this.IsClusterLevelRecoveryEnabled.GetHashCode();
                if (this.MigrationRules != null)
                    hashCode = hashCode * 59 + this.MigrationRules.GetHashCode();
                if (this.PvcOnlyRestore != null)
                    hashCode = hashCode * 59 + this.PvcOnlyRestore.GetHashCode();
                if (this.StorageClassTranslationMap != null)
                    hashCode = hashCode * 59 + this.StorageClassTranslationMap.GetHashCode();
                if (this.UnbindPvcs != null)
                    hashCode = hashCode * 59 + this.UnbindPvcs.GetHashCode();
                if (this.UseInstantRecovery != null)
                    hashCode = hashCode * 59 + this.UseInstantRecovery.GetHashCode();
                if (this.UsePluginForExcludedPvcs != null)
                    hashCode = hashCode * 59 + this.UsePluginForExcludedPvcs.GetHashCode();
                return hashCode;
            }
        }

    }

}

