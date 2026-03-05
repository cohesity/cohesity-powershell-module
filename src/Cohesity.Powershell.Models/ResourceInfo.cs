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
    /// NOTE: This proto will have the resource list empty if you want to use it as just a resource type present on the cluster. The resource list will only be populated when you have to deal with specific instance of that resource like for granular selection in backup and recoveries.
    /// </summary>
    [DataContract]
    public partial class ResourceInfo :  IEquatable<ResourceInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInfo" /> class.
        /// </summary>
        /// <param name="apiGroup">API group name of the resource (excluding the version). (Eg. apps).</param>
        /// <param name="isClusterScoped">Whether the resource is namespace scoped or not..</param>
        /// <param name="kind">The kind of the resource type. (Eg. Deployment).</param>
        /// <param name="name">Name of the resource..</param>
        /// <param name="resourceList">This will not be populated in the following scenarios 1. When used in GetApiResourcesOp, only the fields above will be populated in the result of the op. 2. When this message is used to select a resource type as a whole to include/exclude from the backup or restore.  This will be populated in the following scenarios 1. When we include/exclude specific instances of a kind in backup or restores. 2. When used in SnapshotInfoProto to store list of succesfully backed up instances of the kind. Ex. VMs that are succesfully backed up..</param>
        /// <param name="version">The version under the API group for the resource. (Eg. v1, v1alpha1).</param>
        public ResourceInfo(string apiGroup = default(string), bool? isClusterScoped = default(bool?), string kind = default(string), string name = default(string), List<ResourceInfoResourceInstance> resourceList = default(List<ResourceInfoResourceInstance>), string version = default(string))
        {
            this.ApiGroup = apiGroup;
            this.IsClusterScoped = isClusterScoped;
            this.Kind = kind;
            this.Name = name;
            this.ResourceList = resourceList;
            this.Version = version;
            this.ApiGroup = apiGroup;
            this.IsClusterScoped = isClusterScoped;
            this.Kind = kind;
            this.Name = name;
            this.ResourceList = resourceList;
            this.Version = version;
        }
        
        /// <summary>
        /// API group name of the resource (excluding the version). (Eg. apps)
        /// </summary>
        /// <value>API group name of the resource (excluding the version). (Eg. apps)</value>
        [DataMember(Name="apiGroup", EmitDefaultValue=true)]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Whether the resource is namespace scoped or not.
        /// </summary>
        /// <value>Whether the resource is namespace scoped or not.</value>
        [DataMember(Name="isClusterScoped", EmitDefaultValue=true)]
        public bool? IsClusterScoped { get; set; }

        /// <summary>
        /// The kind of the resource type. (Eg. Deployment)
        /// </summary>
        /// <value>The kind of the resource type. (Eg. Deployment)</value>
        [DataMember(Name="kind", EmitDefaultValue=true)]
        public string Kind { get; set; }

        /// <summary>
        /// Name of the resource.
        /// </summary>
        /// <value>Name of the resource.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// This will not be populated in the following scenarios 1. When used in GetApiResourcesOp, only the fields above will be populated in the result of the op. 2. When this message is used to select a resource type as a whole to include/exclude from the backup or restore.  This will be populated in the following scenarios 1. When we include/exclude specific instances of a kind in backup or restores. 2. When used in SnapshotInfoProto to store list of succesfully backed up instances of the kind. Ex. VMs that are succesfully backed up.
        /// </summary>
        /// <value>This will not be populated in the following scenarios 1. When used in GetApiResourcesOp, only the fields above will be populated in the result of the op. 2. When this message is used to select a resource type as a whole to include/exclude from the backup or restore.  This will be populated in the following scenarios 1. When we include/exclude specific instances of a kind in backup or restores. 2. When used in SnapshotInfoProto to store list of succesfully backed up instances of the kind. Ex. VMs that are succesfully backed up.</value>
        [DataMember(Name="resourceList", EmitDefaultValue=true)]
        public List<ResourceInfoResourceInstance> ResourceList { get; set; }

        /// <summary>
        /// The version under the API group for the resource. (Eg. v1, v1alpha1)
        /// </summary>
        /// <value>The version under the API group for the resource. (Eg. v1, v1alpha1)</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as ResourceInfo);
        }

        /// <summary>
        /// Returns true if ResourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiGroup == input.ApiGroup ||
                    (this.ApiGroup != null &&
                    this.ApiGroup.Equals(input.ApiGroup))
                ) && 
                (
                    this.IsClusterScoped == input.IsClusterScoped ||
                    (this.IsClusterScoped != null &&
                    this.IsClusterScoped.Equals(input.IsClusterScoped))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ResourceList == input.ResourceList ||
                    this.ResourceList != null &&
                    input.ResourceList != null &&
                    this.ResourceList.SequenceEqual(input.ResourceList)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ApiGroup != null)
                    hashCode = hashCode * 59 + this.ApiGroup.GetHashCode();
                if (this.IsClusterScoped != null)
                    hashCode = hashCode * 59 + this.IsClusterScoped.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ResourceList != null)
                    hashCode = hashCode * 59 + this.ResourceList.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

