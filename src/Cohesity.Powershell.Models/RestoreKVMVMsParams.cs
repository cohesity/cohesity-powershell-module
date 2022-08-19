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
    /// RestoreKVMVMsParams
    /// </summary>
    [DataContract]
    public partial class RestoreKVMVMsParams :  IEquatable<RestoreKVMVMsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreKVMVMsParams" /> class.
        /// </summary>
        /// <param name="clusterEntity">clusterEntity.</param>
        /// <param name="datacenterEntity">datacenterEntity.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="storagedomainEntity">storagedomainEntity.</param>
        public RestoreKVMVMsParams(EntityProto clusterEntity = default(EntityProto), EntityProto datacenterEntity = default(EntityProto), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), EntityProto storagedomainEntity = default(EntityProto))
        {
            this.ClusterEntity = clusterEntity;
            this.DatacenterEntity = datacenterEntity;
            this.PowerStateConfig = powerStateConfig;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.StoragedomainEntity = storagedomainEntity;
        }
        
        /// <summary>
        /// Gets or Sets ClusterEntity
        /// </summary>
        [DataMember(Name="clusterEntity", EmitDefaultValue=false)]
        public EntityProto ClusterEntity { get; set; }

        /// <summary>
        /// Gets or Sets DatacenterEntity
        /// </summary>
        [DataMember(Name="datacenterEntity", EmitDefaultValue=false)]
        public EntityProto DatacenterEntity { get; set; }

        /// <summary>
        /// Gets or Sets PowerStateConfig
        /// </summary>
        [DataMember(Name="powerStateConfig", EmitDefaultValue=false)]
        public PowerStateConfigProto PowerStateConfig { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredObjectParam
        /// </summary>
        [DataMember(Name="renameRestoredObjectParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredObjectParam { get; set; }

        /// <summary>
        /// Gets or Sets RestoredObjectsNetworkConfig
        /// </summary>
        [DataMember(Name="restoredObjectsNetworkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto RestoredObjectsNetworkConfig { get; set; }

        /// <summary>
        /// Gets or Sets StoragedomainEntity
        /// </summary>
        [DataMember(Name="storagedomainEntity", EmitDefaultValue=false)]
        public EntityProto StoragedomainEntity { get; set; }

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
            return this.Equals(input as RestoreKVMVMsParams);
        }

        /// <summary>
        /// Returns true if RestoreKVMVMsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreKVMVMsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreKVMVMsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterEntity == input.ClusterEntity ||
                    (this.ClusterEntity != null &&
                    this.ClusterEntity.Equals(input.ClusterEntity))
                ) && 
                (
                    this.DatacenterEntity == input.DatacenterEntity ||
                    (this.DatacenterEntity != null &&
                    this.DatacenterEntity.Equals(input.DatacenterEntity))
                ) && 
                (
                    this.PowerStateConfig == input.PowerStateConfig ||
                    (this.PowerStateConfig != null &&
                    this.PowerStateConfig.Equals(input.PowerStateConfig))
                ) && 
                (
                    this.RenameRestoredObjectParam == input.RenameRestoredObjectParam ||
                    (this.RenameRestoredObjectParam != null &&
                    this.RenameRestoredObjectParam.Equals(input.RenameRestoredObjectParam))
                ) && 
                (
                    this.RestoredObjectsNetworkConfig == input.RestoredObjectsNetworkConfig ||
                    (this.RestoredObjectsNetworkConfig != null &&
                    this.RestoredObjectsNetworkConfig.Equals(input.RestoredObjectsNetworkConfig))
                ) && 
                (
                    this.StoragedomainEntity == input.StoragedomainEntity ||
                    (this.StoragedomainEntity != null &&
                    this.StoragedomainEntity.Equals(input.StoragedomainEntity))
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
                if (this.ClusterEntity != null)
                    hashCode = hashCode * 59 + this.ClusterEntity.GetHashCode();
                if (this.DatacenterEntity != null)
                    hashCode = hashCode * 59 + this.DatacenterEntity.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.StoragedomainEntity != null)
                    hashCode = hashCode * 59 + this.StoragedomainEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

