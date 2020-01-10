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
    /// RestoreKubernetesNamespacesParams
    /// </summary>
    [DataContract]
    public partial class RestoreKubernetesNamespacesParams :  IEquatable<RestoreKubernetesNamespacesParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreKubernetesNamespacesParams" /> class.
        /// </summary>
        /// <param name="backupJobName">Backup job that needs to be used for recovering the namespace..</param>
        /// <param name="clusterEntity">clusterEntity.</param>
        /// <param name="managementNamespace">Namespace in which restore job will be created in K8s cluster..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        public RestoreKubernetesNamespacesParams(string backupJobName = default(string), EntityProto clusterEntity = default(EntityProto), string managementNamespace = default(string), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto))
        {
            this.BackupJobName = backupJobName;
            this.ManagementNamespace = managementNamespace;
            this.BackupJobName = backupJobName;
            this.ClusterEntity = clusterEntity;
            this.ManagementNamespace = managementNamespace;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
        }
        
        /// <summary>
        /// Backup job that needs to be used for recovering the namespace.
        /// </summary>
        /// <value>Backup job that needs to be used for recovering the namespace.</value>
        [DataMember(Name="backupJobName", EmitDefaultValue=true)]
        public string BackupJobName { get; set; }

        /// <summary>
        /// Gets or Sets ClusterEntity
        /// </summary>
        [DataMember(Name="clusterEntity", EmitDefaultValue=false)]
        public EntityProto ClusterEntity { get; set; }

        /// <summary>
        /// Namespace in which restore job will be created in K8s cluster.
        /// </summary>
        /// <value>Namespace in which restore job will be created in K8s cluster.</value>
        [DataMember(Name="managementNamespace", EmitDefaultValue=true)]
        public string ManagementNamespace { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredObjectParam
        /// </summary>
        [DataMember(Name="renameRestoredObjectParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredObjectParam { get; set; }

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
            return this.Equals(input as RestoreKubernetesNamespacesParams);
        }

        /// <summary>
        /// Returns true if RestoreKubernetesNamespacesParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreKubernetesNamespacesParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreKubernetesNamespacesParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupJobName == input.BackupJobName ||
                    (this.BackupJobName != null &&
                    this.BackupJobName.Equals(input.BackupJobName))
                ) && 
                (
                    this.ClusterEntity == input.ClusterEntity ||
                    (this.ClusterEntity != null &&
                    this.ClusterEntity.Equals(input.ClusterEntity))
                ) && 
                (
                    this.ManagementNamespace == input.ManagementNamespace ||
                    (this.ManagementNamespace != null &&
                    this.ManagementNamespace.Equals(input.ManagementNamespace))
                ) && 
                (
                    this.RenameRestoredObjectParam == input.RenameRestoredObjectParam ||
                    (this.RenameRestoredObjectParam != null &&
                    this.RenameRestoredObjectParam.Equals(input.RenameRestoredObjectParam))
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
                if (this.BackupJobName != null)
                    hashCode = hashCode * 59 + this.BackupJobName.GetHashCode();
                if (this.ClusterEntity != null)
                    hashCode = hashCode * 59 + this.ClusterEntity.GetHashCode();
                if (this.ManagementNamespace != null)
                    hashCode = hashCode * 59 + this.ManagementNamespace.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                return hashCode;
            }
        }

    }

}

