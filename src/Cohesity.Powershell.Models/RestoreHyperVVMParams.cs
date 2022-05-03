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
    /// RestoreHyperVVMParams
    /// </summary>
    [DataContract]
    public partial class RestoreHyperVVMParams :  IEquatable<RestoreHyperVVMParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreHyperVVMParams" /> class.
        /// </summary>
        /// <param name="copyRecovery">Whether to perform copy recovery..</param>
        /// <param name="datastoreEntity">datastoreEntity.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="resourceEntity">resourceEntity.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="uuidConfig">uuidConfig.</param>
        public RestoreHyperVVMParams(bool? copyRecovery = default(bool?), EntityProto datastoreEntity = default(EntityProto), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), EntityProto resourceEntity = default(EntityProto), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), UuidConfigProto uuidConfig = default(UuidConfigProto))
        {
            this.CopyRecovery = copyRecovery;
            this.DatastoreEntity = datastoreEntity;
            this.PowerStateConfig = powerStateConfig;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.ResourceEntity = resourceEntity;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.UuidConfig = uuidConfig;
        }
        
        /// <summary>
        /// Whether to perform copy recovery.
        /// </summary>
        /// <value>Whether to perform copy recovery.</value>
        [DataMember(Name="copyRecovery", EmitDefaultValue=false)]
        public bool? CopyRecovery { get; set; }

        /// <summary>
        /// Gets or Sets DatastoreEntity
        /// </summary>
        [DataMember(Name="datastoreEntity", EmitDefaultValue=false)]
        public EntityProto DatastoreEntity { get; set; }

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
        /// Gets or Sets ResourceEntity
        /// </summary>
        [DataMember(Name="resourceEntity", EmitDefaultValue=false)]
        public EntityProto ResourceEntity { get; set; }

        /// <summary>
        /// Gets or Sets RestoredObjectsNetworkConfig
        /// </summary>
        [DataMember(Name="restoredObjectsNetworkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto RestoredObjectsNetworkConfig { get; set; }

        /// <summary>
        /// Gets or Sets UuidConfig
        /// </summary>
        [DataMember(Name="uuidConfig", EmitDefaultValue=false)]
        public UuidConfigProto UuidConfig { get; set; }

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
            return this.Equals(input as RestoreHyperVVMParams);
        }

        /// <summary>
        /// Returns true if RestoreHyperVVMParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreHyperVVMParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreHyperVVMParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyRecovery == input.CopyRecovery ||
                    (this.CopyRecovery != null &&
                    this.CopyRecovery.Equals(input.CopyRecovery))
                ) && 
                (
                    this.DatastoreEntity == input.DatastoreEntity ||
                    (this.DatastoreEntity != null &&
                    this.DatastoreEntity.Equals(input.DatastoreEntity))
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
                    this.ResourceEntity == input.ResourceEntity ||
                    (this.ResourceEntity != null &&
                    this.ResourceEntity.Equals(input.ResourceEntity))
                ) && 
                (
                    this.RestoredObjectsNetworkConfig == input.RestoredObjectsNetworkConfig ||
                    (this.RestoredObjectsNetworkConfig != null &&
                    this.RestoredObjectsNetworkConfig.Equals(input.RestoredObjectsNetworkConfig))
                ) && 
                (
                    this.UuidConfig == input.UuidConfig ||
                    (this.UuidConfig != null &&
                    this.UuidConfig.Equals(input.UuidConfig))
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
                if (this.CopyRecovery != null)
                    hashCode = hashCode * 59 + this.CopyRecovery.GetHashCode();
                if (this.DatastoreEntity != null)
                    hashCode = hashCode * 59 + this.DatastoreEntity.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.ResourceEntity != null)
                    hashCode = hashCode * 59 + this.ResourceEntity.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.UuidConfig != null)
                    hashCode = hashCode * 59 + this.UuidConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

