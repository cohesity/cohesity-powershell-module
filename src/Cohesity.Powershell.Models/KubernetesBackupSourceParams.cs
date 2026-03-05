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
    /// Message to capture additional backup params for a Kubernetes type source.
    /// </summary>
    [DataContract]
    public partial class KubernetesBackupSourceParams :  IEquatable<KubernetesBackupSourceParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesBackupSourceParams" /> class.
        /// </summary>
        /// <param name="excludeParams">excludeParams.</param>
        /// <param name="failBackupsOnHookExecErrors">Boolean to represent if backup should fail if any one of the hook execution has failed..</param>
        /// <param name="includeParams">includeParams.</param>
        /// <param name="pvcOnlyBackup">If enabled we will only backup pvc and related resources..</param>
        /// <param name="quiesceGroups">List of groups to execute during PVC snapshots..</param>
        public KubernetesBackupSourceParams(K8SFilterParams excludeParams = default(K8SFilterParams), bool? failBackupsOnHookExecErrors = default(bool?), K8SFilterParams includeParams = default(K8SFilterParams), bool? pvcOnlyBackup = default(bool?), List<QuiesceGroup> quiesceGroups = default(List<QuiesceGroup>))
        {
            this.FailBackupsOnHookExecErrors = failBackupsOnHookExecErrors;
            this.PvcOnlyBackup = pvcOnlyBackup;
            this.QuiesceGroups = quiesceGroups;
            this.ExcludeParams = excludeParams;
            this.FailBackupsOnHookExecErrors = failBackupsOnHookExecErrors;
            this.IncludeParams = includeParams;
            this.PvcOnlyBackup = pvcOnlyBackup;
            this.QuiesceGroups = quiesceGroups;
        }
        
        /// <summary>
        /// Gets or Sets ExcludeParams
        /// </summary>
        [DataMember(Name="excludeParams", EmitDefaultValue=false)]
        public K8SFilterParams ExcludeParams { get; set; }

        /// <summary>
        /// Boolean to represent if backup should fail if any one of the hook execution has failed.
        /// </summary>
        /// <value>Boolean to represent if backup should fail if any one of the hook execution has failed.</value>
        [DataMember(Name="failBackupsOnHookExecErrors", EmitDefaultValue=true)]
        public bool? FailBackupsOnHookExecErrors { get; set; }

        /// <summary>
        /// Gets or Sets IncludeParams
        /// </summary>
        [DataMember(Name="includeParams", EmitDefaultValue=false)]
        public K8SFilterParams IncludeParams { get; set; }

        /// <summary>
        /// If enabled we will only backup pvc and related resources.
        /// </summary>
        /// <value>If enabled we will only backup pvc and related resources.</value>
        [DataMember(Name="pvcOnlyBackup", EmitDefaultValue=true)]
        public bool? PvcOnlyBackup { get; set; }

        /// <summary>
        /// List of groups to execute during PVC snapshots.
        /// </summary>
        /// <value>List of groups to execute during PVC snapshots.</value>
        [DataMember(Name="quiesceGroups", EmitDefaultValue=true)]
        public List<QuiesceGroup> QuiesceGroups { get; set; }

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
            return this.Equals(input as KubernetesBackupSourceParams);
        }

        /// <summary>
        /// Returns true if KubernetesBackupSourceParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesBackupSourceParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesBackupSourceParams input)
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
                    this.FailBackupsOnHookExecErrors == input.FailBackupsOnHookExecErrors ||
                    (this.FailBackupsOnHookExecErrors != null &&
                    this.FailBackupsOnHookExecErrors.Equals(input.FailBackupsOnHookExecErrors))
                ) && 
                (
                    this.IncludeParams == input.IncludeParams ||
                    (this.IncludeParams != null &&
                    this.IncludeParams.Equals(input.IncludeParams))
                ) && 
                (
                    this.PvcOnlyBackup == input.PvcOnlyBackup ||
                    (this.PvcOnlyBackup != null &&
                    this.PvcOnlyBackup.Equals(input.PvcOnlyBackup))
                ) && 
                (
                    this.QuiesceGroups == input.QuiesceGroups ||
                    this.QuiesceGroups != null &&
                    input.QuiesceGroups != null &&
                    this.QuiesceGroups.SequenceEqual(input.QuiesceGroups)
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
                if (this.FailBackupsOnHookExecErrors != null)
                    hashCode = hashCode * 59 + this.FailBackupsOnHookExecErrors.GetHashCode();
                if (this.IncludeParams != null)
                    hashCode = hashCode * 59 + this.IncludeParams.GetHashCode();
                if (this.PvcOnlyBackup != null)
                    hashCode = hashCode * 59 + this.PvcOnlyBackup.GetHashCode();
                if (this.QuiesceGroups != null)
                    hashCode = hashCode * 59 + this.QuiesceGroups.GetHashCode();
                return hashCode;
            }
        }

    }

}

