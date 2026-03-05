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
    /// KubernetesNamespaceRecoverParamsMigrationRuleParams
    /// </summary>
    [DataContract]
    public partial class KubernetesNamespaceRecoverParamsMigrationRuleParams :  IEquatable<KubernetesNamespaceRecoverParamsMigrationRuleParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubernetesNamespaceRecoverParamsMigrationRuleParams" /> class.
        /// </summary>
        /// <param name="cloudProvider">The cloud provider where the migration is being performed. Currently, only migration between the same cloud providers is supported, hence this single field represents both source and target cloud provider. This might change in future when migration across cloud providers is supported. A new field may be introduced for the target cloud provider..</param>
        /// <param name="rules">The list of migration rules to apply..</param>
        public KubernetesNamespaceRecoverParamsMigrationRuleParams(int? cloudProvider = default(int?), List<MigrationRule> rules = default(List<MigrationRule>))
        {
            this.CloudProvider = cloudProvider;
            this.Rules = rules;
            this.CloudProvider = cloudProvider;
            this.Rules = rules;
        }
        
        /// <summary>
        /// The cloud provider where the migration is being performed. Currently, only migration between the same cloud providers is supported, hence this single field represents both source and target cloud provider. This might change in future when migration across cloud providers is supported. A new field may be introduced for the target cloud provider.
        /// </summary>
        /// <value>The cloud provider where the migration is being performed. Currently, only migration between the same cloud providers is supported, hence this single field represents both source and target cloud provider. This might change in future when migration across cloud providers is supported. A new field may be introduced for the target cloud provider.</value>
        [DataMember(Name="cloudProvider", EmitDefaultValue=true)]
        public int? CloudProvider { get; set; }

        /// <summary>
        /// The list of migration rules to apply.
        /// </summary>
        /// <value>The list of migration rules to apply.</value>
        [DataMember(Name="rules", EmitDefaultValue=true)]
        public List<MigrationRule> Rules { get; set; }

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
            return this.Equals(input as KubernetesNamespaceRecoverParamsMigrationRuleParams);
        }

        /// <summary>
        /// Returns true if KubernetesNamespaceRecoverParamsMigrationRuleParams instances are equal
        /// </summary>
        /// <param name="input">Instance of KubernetesNamespaceRecoverParamsMigrationRuleParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubernetesNamespaceRecoverParamsMigrationRuleParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudProvider == input.CloudProvider ||
                    (this.CloudProvider != null &&
                    this.CloudProvider.Equals(input.CloudProvider))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
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
                if (this.CloudProvider != null)
                    hashCode = hashCode * 59 + this.CloudProvider.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }

    }

}

