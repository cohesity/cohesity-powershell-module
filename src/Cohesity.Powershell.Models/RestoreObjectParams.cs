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
    /// RestoreObjectParams
    /// </summary>
    [DataContract]
    public partial class RestoreObjectParams :  IEquatable<RestoreObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreObjectParams" /> class.
        /// </summary>
        /// <param name="action">The action to perform..</param>
        /// <param name="datastoreEntity">datastoreEntity.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="restoreParentSource">restoreParentSource.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="viewName">Target view into which the objects are to be cloned..</param>
        public RestoreObjectParams(int? action = default(int?), EntityProto datastoreEntity = default(EntityProto), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), EntityProto resourcePoolEntity = default(EntityProto), EntityProto restoreParentSource = default(EntityProto), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), string viewName = default(string))
        {
            this.Action = action;
            this.ViewName = viewName;
            this.Action = action;
            this.DatastoreEntity = datastoreEntity;
            this.PowerStateConfig = powerStateConfig;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.RestoreParentSource = restoreParentSource;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// The action to perform.
        /// </summary>
        /// <value>The action to perform.</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public int? Action { get; set; }

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
        /// Gets or Sets ResourcePoolEntity
        /// </summary>
        [DataMember(Name="resourcePoolEntity", EmitDefaultValue=false)]
        public EntityProto ResourcePoolEntity { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParentSource
        /// </summary>
        [DataMember(Name="restoreParentSource", EmitDefaultValue=false)]
        public EntityProto RestoreParentSource { get; set; }

        /// <summary>
        /// Gets or Sets RestoredObjectsNetworkConfig
        /// </summary>
        [DataMember(Name="restoredObjectsNetworkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto RestoredObjectsNetworkConfig { get; set; }

        /// <summary>
        /// Target view into which the objects are to be cloned.
        /// </summary>
        /// <value>Target view into which the objects are to be cloned.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as RestoreObjectParams);
        }

        /// <summary>
        /// Returns true if RestoreObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                    this.ResourcePoolEntity == input.ResourcePoolEntity ||
                    (this.ResourcePoolEntity != null &&
                    this.ResourcePoolEntity.Equals(input.ResourcePoolEntity))
                ) && 
                (
                    this.RestoreParentSource == input.RestoreParentSource ||
                    (this.RestoreParentSource != null &&
                    this.RestoreParentSource.Equals(input.RestoreParentSource))
                ) && 
                (
                    this.RestoredObjectsNetworkConfig == input.RestoredObjectsNetworkConfig ||
                    (this.RestoredObjectsNetworkConfig != null &&
                    this.RestoredObjectsNetworkConfig.Equals(input.RestoredObjectsNetworkConfig))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.DatastoreEntity != null)
                    hashCode = hashCode * 59 + this.DatastoreEntity.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.ResourcePoolEntity != null)
                    hashCode = hashCode * 59 + this.ResourcePoolEntity.GetHashCode();
                if (this.RestoreParentSource != null)
                    hashCode = hashCode * 59 + this.RestoreParentSource.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

