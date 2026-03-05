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
    /// GenericAdapterRecoverParams
    /// </summary>
    [DataContract]
    public partial class GenericAdapterRecoverParams :  IEquatable<GenericAdapterRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericAdapterRecoverParams" /> class.
        /// </summary>
        /// <param name="adapterEnvType">This field specifies which adapter to use for restore..</param>
        /// <param name="agentIdVec">List of agent IDs used in the restore workflow. Currently populated only for kAwsRDSOracle restores to persist agent IDs across crashes..</param>
        /// <param name="ancestorEntityDetails">ancestorEntityDetails.</param>
        /// <param name="entitiesExternalMetadata">The external metadata associated with restore entity if it exists, and all entities in ancestor_entity_details..</param>
        /// <param name="pitrParams">pitrParams.</param>
        /// <param name="restoreTargetEntityVec">The list of possible entities available in magneto&#39;s entity hierarchy, where the object can be restored. Repeated field is required for \&quot;restore to original\&quot; case, where the entity being restored has multiple parents. In that case, all parents will be provided as possible targets..</param>
        public GenericAdapterRecoverParams(int? adapterEnvType = default(int?), List<long> agentIdVec = default(List<long>), EntityDAGProto ancestorEntityDetails = default(EntityDAGProto), List<EntitiesExternalMetadata> entitiesExternalMetadata = default(List<EntitiesExternalMetadata>), GenericAdapterRecoverParamsPITRParams pitrParams = default(GenericAdapterRecoverParamsPITRParams), List<EntityProto> restoreTargetEntityVec = default(List<EntityProto>))
        {
            this.AdapterEnvType = adapterEnvType;
            this.AgentIdVec = agentIdVec;
            this.EntitiesExternalMetadata = entitiesExternalMetadata;
            this.RestoreTargetEntityVec = restoreTargetEntityVec;
            this.AdapterEnvType = adapterEnvType;
            this.AgentIdVec = agentIdVec;
            this.AncestorEntityDetails = ancestorEntityDetails;
            this.EntitiesExternalMetadata = entitiesExternalMetadata;
            this.PitrParams = pitrParams;
            this.RestoreTargetEntityVec = restoreTargetEntityVec;
        }
        
        /// <summary>
        /// This field specifies which adapter to use for restore.
        /// </summary>
        /// <value>This field specifies which adapter to use for restore.</value>
        [DataMember(Name="adapterEnvType", EmitDefaultValue=true)]
        public int? AdapterEnvType { get; set; }

        /// <summary>
        /// List of agent IDs used in the restore workflow. Currently populated only for kAwsRDSOracle restores to persist agent IDs across crashes.
        /// </summary>
        /// <value>List of agent IDs used in the restore workflow. Currently populated only for kAwsRDSOracle restores to persist agent IDs across crashes.</value>
        [DataMember(Name="agentIdVec", EmitDefaultValue=true)]
        public List<long> AgentIdVec { get; set; }

        /// <summary>
        /// Gets or Sets AncestorEntityDetails
        /// </summary>
        [DataMember(Name="ancestorEntityDetails", EmitDefaultValue=false)]
        public EntityDAGProto AncestorEntityDetails { get; set; }

        /// <summary>
        /// The external metadata associated with restore entity if it exists, and all entities in ancestor_entity_details.
        /// </summary>
        /// <value>The external metadata associated with restore entity if it exists, and all entities in ancestor_entity_details.</value>
        [DataMember(Name="entitiesExternalMetadata", EmitDefaultValue=true)]
        public List<EntitiesExternalMetadata> EntitiesExternalMetadata { get; set; }

        /// <summary>
        /// Gets or Sets PitrParams
        /// </summary>
        [DataMember(Name="pitrParams", EmitDefaultValue=false)]
        public GenericAdapterRecoverParamsPITRParams PitrParams { get; set; }

        /// <summary>
        /// The list of possible entities available in magneto&#39;s entity hierarchy, where the object can be restored. Repeated field is required for \&quot;restore to original\&quot; case, where the entity being restored has multiple parents. In that case, all parents will be provided as possible targets.
        /// </summary>
        /// <value>The list of possible entities available in magneto&#39;s entity hierarchy, where the object can be restored. Repeated field is required for \&quot;restore to original\&quot; case, where the entity being restored has multiple parents. In that case, all parents will be provided as possible targets.</value>
        [DataMember(Name="restoreTargetEntityVec", EmitDefaultValue=true)]
        public List<EntityProto> RestoreTargetEntityVec { get; set; }

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
            return this.Equals(input as GenericAdapterRecoverParams);
        }

        /// <summary>
        /// Returns true if GenericAdapterRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericAdapterRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericAdapterRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdapterEnvType == input.AdapterEnvType ||
                    (this.AdapterEnvType != null &&
                    this.AdapterEnvType.Equals(input.AdapterEnvType))
                ) && 
                (
                    this.AgentIdVec == input.AgentIdVec ||
                    this.AgentIdVec != null &&
                    input.AgentIdVec != null &&
                    this.AgentIdVec.SequenceEqual(input.AgentIdVec)
                ) && 
                (
                    this.AncestorEntityDetails == input.AncestorEntityDetails ||
                    (this.AncestorEntityDetails != null &&
                    this.AncestorEntityDetails.Equals(input.AncestorEntityDetails))
                ) && 
                (
                    this.EntitiesExternalMetadata == input.EntitiesExternalMetadata ||
                    this.EntitiesExternalMetadata != null &&
                    input.EntitiesExternalMetadata != null &&
                    this.EntitiesExternalMetadata.SequenceEqual(input.EntitiesExternalMetadata)
                ) && 
                (
                    this.PitrParams == input.PitrParams ||
                    (this.PitrParams != null &&
                    this.PitrParams.Equals(input.PitrParams))
                ) && 
                (
                    this.RestoreTargetEntityVec == input.RestoreTargetEntityVec ||
                    this.RestoreTargetEntityVec != null &&
                    input.RestoreTargetEntityVec != null &&
                    this.RestoreTargetEntityVec.SequenceEqual(input.RestoreTargetEntityVec)
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
                if (this.AdapterEnvType != null)
                    hashCode = hashCode * 59 + this.AdapterEnvType.GetHashCode();
                if (this.AgentIdVec != null)
                    hashCode = hashCode * 59 + this.AgentIdVec.GetHashCode();
                if (this.AncestorEntityDetails != null)
                    hashCode = hashCode * 59 + this.AncestorEntityDetails.GetHashCode();
                if (this.EntitiesExternalMetadata != null)
                    hashCode = hashCode * 59 + this.EntitiesExternalMetadata.GetHashCode();
                if (this.PitrParams != null)
                    hashCode = hashCode * 59 + this.PitrParams.GetHashCode();
                if (this.RestoreTargetEntityVec != null)
                    hashCode = hashCode * 59 + this.RestoreTargetEntityVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

