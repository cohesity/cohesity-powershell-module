// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the state of an individual object in a Restore Task.
    /// </summary>
    [DataContract]
    public partial class RestoreObjectState :  IEquatable<RestoreObjectState>
    {
        /// <summary>
        /// Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source.
        /// </summary>
        /// <value>Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectStatusEnum
        {
            
            /// <summary>
            /// Enum KFilesCloned for value: kFilesCloned
            /// </summary>
            [EnumMember(Value = "kFilesCloned")]
            KFilesCloned = 1,
            
            /// <summary>
            /// Enum KFetchedEntityInfo for value: kFetchedEntityInfo
            /// </summary>
            [EnumMember(Value = "kFetchedEntityInfo")]
            KFetchedEntityInfo = 2,
            
            /// <summary>
            /// Enum KVMCreated for value: kVMCreated
            /// </summary>
            [EnumMember(Value = "kVMCreated")]
            KVMCreated = 3,
            
            /// <summary>
            /// Enum KRelocationStarted for value: kRelocationStarted
            /// </summary>
            [EnumMember(Value = "kRelocationStarted")]
            KRelocationStarted = 4,
            
            /// <summary>
            /// Enum KFinished for value: kFinished
            /// </summary>
            [EnumMember(Value = "kFinished")]
            KFinished = 5,
            
            /// <summary>
            /// Enum KAborted for value: kAborted
            /// </summary>
            [EnumMember(Value = "kAborted")]
            KAborted = 6,

            /// <summary>
            /// Enum KDataCopyStarted for value: kDataCopyStarted
            /// </summary>
            [EnumMember(Value = "kDataCopyStarted")]
            KDataCopyStarted = 7,

            /// <summary>
            /// Enum KInProgress for value: kInProgress
            /// </summary>
            [EnumMember(Value = "kInProgress")]
            KInProgress = 8
        }

        /// <summary>
        /// Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source.
        /// </summary>
        /// <value>Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source.</value>
        [DataMember(Name="objectStatus", EmitDefaultValue=false)]
        public ObjectStatusEnum? ObjectStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreObjectState" /> class.
        /// </summary>
        /// <param name="error">Specifies if an error occurred during the restore operation..</param>
        /// <param name="objectStatus">Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source..</param>
        /// <param name="resourcePoolId">Specifies the id of the Resource Pool that the restored object is attached to. For a &#39;kRecoverVMs&#39; Restore Task, an object can be recovered back to its original resource pool. This means while recovering a set of objects, this field can reference different resource pools. For a &#39;kCloneVMs&#39; Restore Task, all objects are attached to the same resource pool. However, this field will still be populated. NOTE: This field may not be populated if the restore of the object fails..</param>
        /// <param name="restoredObjectId">Specifies the Id of the recovered or cloned object. NOTE: For a Restore Task that is recovering or cloning an object in the VMware environment, after the VM is created it is storage vMotioned to its primary datastore. If storage vMotion fails, the Cohesity Cluster marks the recovery task as failed. However, this field is still populated with the id of the recovered VM. This id can be used later to clean up the VM from primary environment (i.e, the vCenter Server)..</param>
        /// <param name="sourceObjectId">Specifies the Protection Source id of the object to be recovered or cloned..</param>
        public RestoreObjectState(RequestError error = default(RequestError), ObjectStatusEnum? objectStatus = default(ObjectStatusEnum?), long? resourcePoolId = default(long?), long? restoredObjectId = default(long?), long? sourceObjectId = default(long?))
        {
            this.Error = error;
            this.ObjectStatus = objectStatus;
            this.ResourcePoolId = resourcePoolId;
            this.RestoredObjectId = restoredObjectId;
            this.SourceObjectId = sourceObjectId;
        }
        
        /// <summary>
        /// Specifies if an error occurred during the restore operation.
        /// </summary>
        /// <value>Specifies if an error occurred during the restore operation.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public RequestError Error { get; set; }


        /// <summary>
        /// Specifies the id of the Resource Pool that the restored object is attached to. For a &#39;kRecoverVMs&#39; Restore Task, an object can be recovered back to its original resource pool. This means while recovering a set of objects, this field can reference different resource pools. For a &#39;kCloneVMs&#39; Restore Task, all objects are attached to the same resource pool. However, this field will still be populated. NOTE: This field may not be populated if the restore of the object fails.
        /// </summary>
        /// <value>Specifies the id of the Resource Pool that the restored object is attached to. For a &#39;kRecoverVMs&#39; Restore Task, an object can be recovered back to its original resource pool. This means while recovering a set of objects, this field can reference different resource pools. For a &#39;kCloneVMs&#39; Restore Task, all objects are attached to the same resource pool. However, this field will still be populated. NOTE: This field may not be populated if the restore of the object fails.</value>
        [DataMember(Name="resourcePoolId", EmitDefaultValue=false)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// Specifies the Id of the recovered or cloned object. NOTE: For a Restore Task that is recovering or cloning an object in the VMware environment, after the VM is created it is storage vMotioned to its primary datastore. If storage vMotion fails, the Cohesity Cluster marks the recovery task as failed. However, this field is still populated with the id of the recovered VM. This id can be used later to clean up the VM from primary environment (i.e, the vCenter Server).
        /// </summary>
        /// <value>Specifies the Id of the recovered or cloned object. NOTE: For a Restore Task that is recovering or cloning an object in the VMware environment, after the VM is created it is storage vMotioned to its primary datastore. If storage vMotion fails, the Cohesity Cluster marks the recovery task as failed. However, this field is still populated with the id of the recovered VM. This id can be used later to clean up the VM from primary environment (i.e, the vCenter Server).</value>
        [DataMember(Name="restoredObjectId", EmitDefaultValue=false)]
        public long? RestoredObjectId { get; set; }

        /// <summary>
        /// Specifies the Protection Source id of the object to be recovered or cloned.
        /// </summary>
        /// <value>Specifies the Protection Source id of the object to be recovered or cloned.</value>
        [DataMember(Name="sourceObjectId", EmitDefaultValue=false)]
        public long? SourceObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as RestoreObjectState);
        }

        /// <summary>
        /// Returns true if RestoreObjectState instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreObjectState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreObjectState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ObjectStatus == input.ObjectStatus ||
                    (this.ObjectStatus != null &&
                    this.ObjectStatus.Equals(input.ObjectStatus))
                ) && 
                (
                    this.ResourcePoolId == input.ResourcePoolId ||
                    (this.ResourcePoolId != null &&
                    this.ResourcePoolId.Equals(input.ResourcePoolId))
                ) && 
                (
                    this.RestoredObjectId == input.RestoredObjectId ||
                    (this.RestoredObjectId != null &&
                    this.RestoredObjectId.Equals(input.RestoredObjectId))
                ) && 
                (
                    this.SourceObjectId == input.SourceObjectId ||
                    (this.SourceObjectId != null &&
                    this.SourceObjectId.Equals(input.SourceObjectId))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ObjectStatus != null)
                    hashCode = hashCode * 59 + this.ObjectStatus.GetHashCode();
                if (this.ResourcePoolId != null)
                    hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.RestoredObjectId != null)
                    hashCode = hashCode * 59 + this.RestoredObjectId.GetHashCode();
                if (this.SourceObjectId != null)
                    hashCode = hashCode * 59 + this.SourceObjectId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

