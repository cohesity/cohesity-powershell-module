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
    /// KubernetesEnvParams
    /// </summary>
    [DataContract]
    public partial class KubernetesEnvParams :  IEquatable<KubernetesEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesEnvParams" /> class.
        /// </summary>
        /// <param name="excludeParams">excludeParams.</param>
        /// <param name="includeParams">includeParams.</param>
        /// <param name="leverageCsiSnapshot">If specified, the backup job will use CSI snapshot for backups..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public KubernetesEnvParams(K8SFilterParams excludeParams = default(K8SFilterParams), K8SFilterParams includeParams = default(K8SFilterParams), bool? leverageCsiSnapshot = default(bool?), VlanParams vlanParams = default(VlanParams))
        {
            this.LeverageCsiSnapshot = leverageCsiSnapshot;
            this.ExcludeParams = excludeParams;
            this.IncludeParams = includeParams;
            this.LeverageCsiSnapshot = leverageCsiSnapshot;
            this.VlanParams = vlanParams;
        }
        
        /// <summary>
        /// Gets or Sets ExcludeParams
        /// </summary>
        [DataMember(Name="excludeParams", EmitDefaultValue=false)]
        public K8SFilterParams ExcludeParams { get; set; }

        /// <summary>
        /// Gets or Sets IncludeParams
        /// </summary>
        [DataMember(Name="includeParams", EmitDefaultValue=false)]
        public K8SFilterParams IncludeParams { get; set; }

        /// <summary>
        /// If specified, the backup job will use CSI snapshot for backups.
        /// </summary>
        /// <value>If specified, the backup job will use CSI snapshot for backups.</value>
        [DataMember(Name="leverageCsiSnapshot", EmitDefaultValue=true)]
        public bool? LeverageCsiSnapshot { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParams VlanParams { get; set; }

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
            return this.Equals(input as KubernetesEnvParams);
        }

        /// <summary>
        /// Returns true if KubernetesEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesEnvParams input)
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
                    this.IncludeParams == input.IncludeParams ||
                    (this.IncludeParams != null &&
                    this.IncludeParams.Equals(input.IncludeParams))
                ) && 
                (
                    this.LeverageCsiSnapshot == input.LeverageCsiSnapshot ||
                    (this.LeverageCsiSnapshot != null &&
                    this.LeverageCsiSnapshot.Equals(input.LeverageCsiSnapshot))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
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
                if (this.IncludeParams != null)
                    hashCode = hashCode * 59 + this.IncludeParams.GetHashCode();
                if (this.LeverageCsiSnapshot != null)
                    hashCode = hashCode * 59 + this.LeverageCsiSnapshot.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

