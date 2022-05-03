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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  DestroyClonedVMTaskInfoProto extension          Location           Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::DestroyClonedTaskInfo:: vmware_destroy_cloned_vm_task_info            vmware/vmware.proto    100 hyperv::DestroyClonedTaskInfo:: hyperv_destroy_cloned_vm_task_info            hyperv/hyperv.proto    101 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class DestroyClonedVMTaskInfoProto :  IEquatable<DestroyClonedVMTaskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyClonedVMTaskInfoProto" /> class.
        /// </summary>
        /// <param name="datastoreNotUnmountedReason">If datastore was not unmounted, this field contains the reason for the same..</param>
        /// <param name="datastoreUnmounted">Whether the datastore corresponding to the clone view was unmounted from primary environment..</param>
        /// <param name="destroyClonedEntityInfoVec">Vector of all cloned entities that this destroy task will teardown..</param>
        /// <param name="type">The type of environment this destroy clone task info pertains to..</param>
        /// <param name="viewDeleted">Whether the clone view was deleted by the destroy task..</param>
        public DestroyClonedVMTaskInfoProto(string datastoreNotUnmountedReason = default(string), bool? datastoreUnmounted = default(bool?), List<DestroyClonedEntityInfoProto> destroyClonedEntityInfoVec = default(List<DestroyClonedEntityInfoProto>), int? type = default(int?), bool? viewDeleted = default(bool?))
        {
            this.DatastoreNotUnmountedReason = datastoreNotUnmountedReason;
            this.DatastoreUnmounted = datastoreUnmounted;
            this.DestroyClonedEntityInfoVec = destroyClonedEntityInfoVec;
            this.Type = type;
            this.ViewDeleted = viewDeleted;
        }
        
        /// <summary>
        /// If datastore was not unmounted, this field contains the reason for the same.
        /// </summary>
        /// <value>If datastore was not unmounted, this field contains the reason for the same.</value>
        [DataMember(Name="datastoreNotUnmountedReason", EmitDefaultValue=false)]
        public string DatastoreNotUnmountedReason { get; set; }

        /// <summary>
        /// Whether the datastore corresponding to the clone view was unmounted from primary environment.
        /// </summary>
        /// <value>Whether the datastore corresponding to the clone view was unmounted from primary environment.</value>
        [DataMember(Name="datastoreUnmounted", EmitDefaultValue=false)]
        public bool? DatastoreUnmounted { get; set; }

        /// <summary>
        /// Vector of all cloned entities that this destroy task will teardown.
        /// </summary>
        /// <value>Vector of all cloned entities that this destroy task will teardown.</value>
        [DataMember(Name="destroyClonedEntityInfoVec", EmitDefaultValue=false)]
        public List<DestroyClonedEntityInfoProto> DestroyClonedEntityInfoVec { get; set; }

        /// <summary>
        /// The type of environment this destroy clone task info pertains to.
        /// </summary>
        /// <value>The type of environment this destroy clone task info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Whether the clone view was deleted by the destroy task.
        /// </summary>
        /// <value>Whether the clone view was deleted by the destroy task.</value>
        [DataMember(Name="viewDeleted", EmitDefaultValue=false)]
        public bool? ViewDeleted { get; set; }

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
            return this.Equals(input as DestroyClonedVMTaskInfoProto);
        }

        /// <summary>
        /// Returns true if DestroyClonedVMTaskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyClonedVMTaskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyClonedVMTaskInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreNotUnmountedReason == input.DatastoreNotUnmountedReason ||
                    (this.DatastoreNotUnmountedReason != null &&
                    this.DatastoreNotUnmountedReason.Equals(input.DatastoreNotUnmountedReason))
                ) && 
                (
                    this.DatastoreUnmounted == input.DatastoreUnmounted ||
                    (this.DatastoreUnmounted != null &&
                    this.DatastoreUnmounted.Equals(input.DatastoreUnmounted))
                ) && 
                (
                    this.DestroyClonedEntityInfoVec == input.DestroyClonedEntityInfoVec ||
                    this.DestroyClonedEntityInfoVec != null &&
                    this.DestroyClonedEntityInfoVec.Equals(input.DestroyClonedEntityInfoVec)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ViewDeleted == input.ViewDeleted ||
                    (this.ViewDeleted != null &&
                    this.ViewDeleted.Equals(input.ViewDeleted))
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
                if (this.DatastoreNotUnmountedReason != null)
                    hashCode = hashCode * 59 + this.DatastoreNotUnmountedReason.GetHashCode();
                if (this.DatastoreUnmounted != null)
                    hashCode = hashCode * 59 + this.DatastoreUnmounted.GetHashCode();
                if (this.DestroyClonedEntityInfoVec != null)
                    hashCode = hashCode * 59 + this.DestroyClonedEntityInfoVec.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewDeleted != null)
                    hashCode = hashCode * 59 + this.ViewDeleted.GetHashCode();
                return hashCode;
            }
        }

    }

}

