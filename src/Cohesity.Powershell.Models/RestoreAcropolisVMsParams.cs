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
    /// RestoreAcropolisVMsParams
    /// </summary>
    [DataContract]
    public partial class RestoreAcropolisVMsParams :  IEquatable<RestoreAcropolisVMsParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAcropolisVMsParams" /> class.
        /// </summary>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="storageContainer">storageContainer.</param>
        /// <param name="uuidConfig">uuidConfig.</param>
        public RestoreAcropolisVMsParams(PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), EntityProto storageContainer = default(EntityProto), UuidConfigProto uuidConfig = default(UuidConfigProto))
        {
            this.PowerStateConfig = powerStateConfig;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.StorageContainer = storageContainer;
            this.UuidConfig = uuidConfig;
        }
        
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
        /// Gets or Sets StorageContainer
        /// </summary>
        [DataMember(Name="storageContainer", EmitDefaultValue=false)]
        public EntityProto StorageContainer { get; set; }

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
            return this.Equals(input as RestoreAcropolisVMsParams);
        }

        /// <summary>
        /// Returns true if RestoreAcropolisVMsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAcropolisVMsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAcropolisVMsParams input)
        {
            if (input == null)
                return false;

            return 
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
                    this.StorageContainer == input.StorageContainer ||
                    (this.StorageContainer != null &&
                    this.StorageContainer.Equals(input.StorageContainer))
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
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.StorageContainer != null)
                    hashCode = hashCode * 59 + this.StorageContainer.GetHashCode();
                if (this.UuidConfig != null)
                    hashCode = hashCode * 59 + this.UuidConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}

