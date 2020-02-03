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
    /// RestoreVMwareVMParams
    /// </summary>
    [DataContract]
    public partial class RestoreVMwareVMParams :  IEquatable<RestoreVMwareVMParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreVMwareVMParams" /> class.
        /// </summary>
        /// <param name="copyRecovery">Whether to perform copy recovery instead of instant recovery..</param>
        /// <param name="datastoreEntityVec">Datastore entities if the restore is to alternate location..</param>
        /// <param name="preserveCustomAttributesDuringClone">Whether to preserve custom attributes for the clone op..</param>
        /// <param name="preserveTagsDuringClone">Whether to preserve tags for the clone op..</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="targetDatastoreFolder">targetDatastoreFolder.</param>
        /// <param name="targetVmFolder">targetVmFolder.</param>
        public RestoreVMwareVMParams(bool? copyRecovery = default(bool?), List<EntityProto> datastoreEntityVec = default(List<EntityProto>), bool? preserveCustomAttributesDuringClone = default(bool?), bool? preserveTagsDuringClone = default(bool?), EntityProto resourcePoolEntity = default(EntityProto), EntityProto targetDatastoreFolder = default(EntityProto), EntityProto targetVmFolder = default(EntityProto))
        {
            this.CopyRecovery = copyRecovery;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTagsDuringClone = preserveTagsDuringClone;
            this.CopyRecovery = copyRecovery;
            this.DatastoreEntityVec = datastoreEntityVec;
            this.PreserveCustomAttributesDuringClone = preserveCustomAttributesDuringClone;
            this.PreserveTagsDuringClone = preserveTagsDuringClone;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.TargetDatastoreFolder = targetDatastoreFolder;
            this.TargetVmFolder = targetVmFolder;
        }
        
        /// <summary>
        /// Whether to perform copy recovery instead of instant recovery.
        /// </summary>
        /// <value>Whether to perform copy recovery instead of instant recovery.</value>
        [DataMember(Name="copyRecovery", EmitDefaultValue=true)]
        public bool? CopyRecovery { get; set; }

        /// <summary>
        /// Datastore entities if the restore is to alternate location.
        /// </summary>
        /// <value>Datastore entities if the restore is to alternate location.</value>
        [DataMember(Name="datastoreEntityVec", EmitDefaultValue=true)]
        public List<EntityProto> DatastoreEntityVec { get; set; }

        /// <summary>
        /// Whether to preserve custom attributes for the clone op.
        /// </summary>
        /// <value>Whether to preserve custom attributes for the clone op.</value>
        [DataMember(Name="preserveCustomAttributesDuringClone", EmitDefaultValue=true)]
        public bool? PreserveCustomAttributesDuringClone { get; set; }

        /// <summary>
        /// Whether to preserve tags for the clone op.
        /// </summary>
        /// <value>Whether to preserve tags for the clone op.</value>
        [DataMember(Name="preserveTagsDuringClone", EmitDefaultValue=true)]
        public bool? PreserveTagsDuringClone { get; set; }

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
            return this.Equals(input as RestoreVMwareVMParams);
        }

        /// <summary>
        /// Returns true if RestoreVMwareVMParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreVMwareVMParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreVMwareVMParams input)
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
                    this.DatastoreEntityVec == input.DatastoreEntityVec ||
                    this.DatastoreEntityVec != null &&
                    input.DatastoreEntityVec != null &&
                    this.DatastoreEntityVec.SequenceEqual(input.DatastoreEntityVec)
                ) && 
                (
                    this.PreserveCustomAttributesDuringClone == input.PreserveCustomAttributesDuringClone ||
                    (this.PreserveCustomAttributesDuringClone != null &&
                    this.PreserveCustomAttributesDuringClone.Equals(input.PreserveCustomAttributesDuringClone))
                ) && 
                (
                    this.PreserveTagsDuringClone == input.PreserveTagsDuringClone ||
                    (this.PreserveTagsDuringClone != null &&
                    this.PreserveTagsDuringClone.Equals(input.PreserveTagsDuringClone))
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
                if (this.CopyRecovery != null)
                    hashCode = hashCode * 59 + this.CopyRecovery.GetHashCode();
                if (this.DatastoreEntityVec != null)
                    hashCode = hashCode * 59 + this.DatastoreEntityVec.GetHashCode();
                if (this.PreserveCustomAttributesDuringClone != null)
                    hashCode = hashCode * 59 + this.PreserveCustomAttributesDuringClone.GetHashCode();
                if (this.PreserveTagsDuringClone != null)
                    hashCode = hashCode * 59 + this.PreserveTagsDuringClone.GetHashCode();
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

