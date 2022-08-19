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
    /// VM Linking Info
    /// </summary>
    [DataContract]
    public partial class VmLinkingInfo :  IEquatable<VmLinkingInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmLinkingInfo" /> class.
        /// </summary>
        /// <param name="isMigrated">This is set to true if a VM is linked in entity provenance by edge type kVMMigration..</param>
        /// <param name="migratedTimeUsecs">This is the time when ther VM was identified to have been migrated by Cohesity. Note that this time can differ from the actual migration time in vCenter..</param>
        /// <param name="previousVmEntityId">This is the id of the VM on the vCenter where it was originally present.</param>
        /// <param name="previousVmParentSourceId">This is the id of vCenter where the VM was originally present.</param>
        public VmLinkingInfo(bool? isMigrated = default(bool?), long? migratedTimeUsecs = default(long?), long? previousVmEntityId = default(long?), long? previousVmParentSourceId = default(long?))
        {
            this.IsMigrated = isMigrated;
            this.MigratedTimeUsecs = migratedTimeUsecs;
            this.PreviousVmEntityId = previousVmEntityId;
            this.PreviousVmParentSourceId = previousVmParentSourceId;
            this.IsMigrated = isMigrated;
            this.MigratedTimeUsecs = migratedTimeUsecs;
            this.PreviousVmEntityId = previousVmEntityId;
            this.PreviousVmParentSourceId = previousVmParentSourceId;
        }
        
        /// <summary>
        /// This is set to true if a VM is linked in entity provenance by edge type kVMMigration.
        /// </summary>
        /// <value>This is set to true if a VM is linked in entity provenance by edge type kVMMigration.</value>
        [DataMember(Name="isMigrated", EmitDefaultValue=true)]
        public bool? IsMigrated { get; set; }

        /// <summary>
        /// This is the time when ther VM was identified to have been migrated by Cohesity. Note that this time can differ from the actual migration time in vCenter.
        /// </summary>
        /// <value>This is the time when ther VM was identified to have been migrated by Cohesity. Note that this time can differ from the actual migration time in vCenter.</value>
        [DataMember(Name="migratedTimeUsecs", EmitDefaultValue=true)]
        public long? MigratedTimeUsecs { get; set; }

        /// <summary>
        /// This is the id of the VM on the vCenter where it was originally present
        /// </summary>
        /// <value>This is the id of the VM on the vCenter where it was originally present</value>
        [DataMember(Name="previousVmEntityId", EmitDefaultValue=true)]
        public long? PreviousVmEntityId { get; set; }

        /// <summary>
        /// This is the id of vCenter where the VM was originally present
        /// </summary>
        /// <value>This is the id of vCenter where the VM was originally present</value>
        [DataMember(Name="previousVmParentSourceId", EmitDefaultValue=true)]
        public long? PreviousVmParentSourceId { get; set; }

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
            return this.Equals(input as VmLinkingInfo);
        }

        /// <summary>
        /// Returns true if VmLinkingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VmLinkingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmLinkingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMigrated == input.IsMigrated ||
                    (this.IsMigrated != null &&
                    this.IsMigrated.Equals(input.IsMigrated))
                ) && 
                (
                    this.MigratedTimeUsecs == input.MigratedTimeUsecs ||
                    (this.MigratedTimeUsecs != null &&
                    this.MigratedTimeUsecs.Equals(input.MigratedTimeUsecs))
                ) && 
                (
                    this.PreviousVmEntityId == input.PreviousVmEntityId ||
                    (this.PreviousVmEntityId != null &&
                    this.PreviousVmEntityId.Equals(input.PreviousVmEntityId))
                ) && 
                (
                    this.PreviousVmParentSourceId == input.PreviousVmParentSourceId ||
                    (this.PreviousVmParentSourceId != null &&
                    this.PreviousVmParentSourceId.Equals(input.PreviousVmParentSourceId))
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
                if (this.IsMigrated != null)
                    hashCode = hashCode * 59 + this.IsMigrated.GetHashCode();
                if (this.MigratedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.MigratedTimeUsecs.GetHashCode();
                if (this.PreviousVmEntityId != null)
                    hashCode = hashCode * 59 + this.PreviousVmEntityId.GetHashCode();
                if (this.PreviousVmParentSourceId != null)
                    hashCode = hashCode * 59 + this.PreviousVmParentSourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}

