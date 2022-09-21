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
    /// VMwareStandbyResource
    /// </summary>
    [DataContract]
    public partial class VMwareStandbyResource :  IEquatable<VMwareStandbyResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMwareStandbyResource" /> class.
        /// </summary>
        /// <param name="datastoreEntityVec">Datastore entities where the standby VM should be created..</param>
        /// <param name="networkConfig">networkConfig.</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="renameObjectParams">renameObjectParams.</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="targetDatastoreFolder">targetDatastoreFolder.</param>
        /// <param name="targetVmFolder">targetVmFolder.</param>
        public VMwareStandbyResource(List<EntityProto> datastoreEntityVec = default(List<EntityProto>), RestoredObjectNetworkConfigProto networkConfig = default(RestoredObjectNetworkConfigProto), EntityProto parentSource = default(EntityProto), RenameObjectParamProto renameObjectParams = default(RenameObjectParamProto), EntityProto resourcePoolEntity = default(EntityProto), EntityProto targetDatastoreFolder = default(EntityProto), EntityProto targetVmFolder = default(EntityProto))
        {
            this.DatastoreEntityVec = datastoreEntityVec;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.NetworkConfig = networkConfig;
            this.ParentSource = parentSource;
            this.RenameObjectParams = renameObjectParams;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.TargetDatastoreFolder = targetDatastoreFolder;
            this.TargetVmFolder = targetVmFolder;
        }
        
        /// <summary>
        /// Datastore entities where the standby VM should be created.
        /// </summary>
        /// <value>Datastore entities where the standby VM should be created.</value>
        [DataMember(Name="datastoreEntityVec", EmitDefaultValue=true)]
        public List<EntityProto> DatastoreEntityVec { get; set; }

        /// <summary>
        /// Gets or Sets NetworkConfig
        /// </summary>
        [DataMember(Name="networkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto NetworkConfig { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public EntityProto ParentSource { get; set; }

        /// <summary>
        /// Gets or Sets RenameObjectParams
        /// </summary>
        [DataMember(Name="renameObjectParams", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameObjectParams { get; set; }

        /// <summary>
        /// Gets or Sets ResourcePoolEntity
        /// </summary>
        [DataMember(Name="resourcePoolEntity", EmitDefaultValue=false)]
        public EntityProto ResourcePoolEntity { get; set; }

        /// <summary>
        /// Gets or Sets TargetDatastoreFolder
        /// </summary>
        [DataMember(Name="targetDatastoreFolder", EmitDefaultValue=false)]
        public EntityProto TargetDatastoreFolder { get; set; }

        /// <summary>
        /// Gets or Sets TargetVmFolder
        /// </summary>
        [DataMember(Name="targetVmFolder", EmitDefaultValue=false)]
        public EntityProto TargetVmFolder { get; set; }

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
            return this.Equals(input as VMwareStandbyResource);
        }

        /// <summary>
        /// Returns true if VMwareStandbyResource instances are equal
        /// </summary>
        /// <param name="input">Instance of VMwareStandbyResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VMwareStandbyResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreEntityVec == input.DatastoreEntityVec ||
                    this.DatastoreEntityVec != null &&
                    input.DatastoreEntityVec != null &&
                    this.DatastoreEntityVec.Equals(input.DatastoreEntityVec)
                ) && 
                (
                    this.NetworkConfig == input.NetworkConfig ||
                    (this.NetworkConfig != null &&
                    this.NetworkConfig.Equals(input.NetworkConfig))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.RenameObjectParams == input.RenameObjectParams ||
                    (this.RenameObjectParams != null &&
                    this.RenameObjectParams.Equals(input.RenameObjectParams))
                ) && 
                (
                    this.ResourcePoolEntity == input.ResourcePoolEntity ||
                    (this.ResourcePoolEntity != null &&
                    this.ResourcePoolEntity.Equals(input.ResourcePoolEntity))
                ) && 
                (
                    this.TargetDatastoreFolder == input.TargetDatastoreFolder ||
                    (this.TargetDatastoreFolder != null &&
                    this.TargetDatastoreFolder.Equals(input.TargetDatastoreFolder))
                ) && 
                (
                    this.TargetVmFolder == input.TargetVmFolder ||
                    (this.TargetVmFolder != null &&
                    this.TargetVmFolder.Equals(input.TargetVmFolder))
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
                if (this.DatastoreEntityVec != null)
                    hashCode = hashCode * 59 + this.DatastoreEntityVec.GetHashCode();
                if (this.NetworkConfig != null)
                    hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.RenameObjectParams != null)
                    hashCode = hashCode * 59 + this.RenameObjectParams.GetHashCode();
                if (this.ResourcePoolEntity != null)
                    hashCode = hashCode * 59 + this.ResourcePoolEntity.GetHashCode();
                if (this.TargetDatastoreFolder != null)
                    hashCode = hashCode * 59 + this.TargetDatastoreFolder.GetHashCode();
                if (this.TargetVmFolder != null)
                    hashCode = hashCode * 59 + this.TargetVmFolder.GetHashCode();
                return hashCode;
            }
        }

    }

}

