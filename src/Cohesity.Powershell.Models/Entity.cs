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
    /// Message encapsulating a Kubernetes entity
    /// </summary>
    [DataContract]
    public partial class Entity :  IEquatable<Entity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="datamoverImageLocation">Location of the datamover image specified by the user..</param>
        /// <param name="description">This is a general description that could be set for some entities..</param>
        /// <param name="distribution">K8s distribution. This will only be applicable to kCluster entities..</param>
        /// <param name="initContainerImageLocation">Location of the init container image specified by the user..</param>
        /// <param name="labelAttributesVec">Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also..</param>
        /// <param name="name">A human readable name for the object..</param>
        /// <param name="_namespace">Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV..</param>
        /// <param name="pvcName">Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity..</param>
        /// <param name="servicesToConnectorIdsMap">A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities..</param>
        /// <param name="type">The type of entity this proto refers to..</param>
        /// <param name="uuid">The UUID of the object..</param>
        /// <param name="veleroAwsPluginImageLocation">Location of the Velero AWS plugin image specified by the user..</param>
        /// <param name="veleroImageLocation">Location of the Velero image specified by the user..</param>
        /// <param name="veleroOpenshiftPluginImageLocation">Location of the Velero Openshift plugin image specified by the user..</param>
        /// <param name="version">Kubernetes cluster version..</param>
        public Entity(string datamoverImageLocation = default(string), string description = default(string), int? distribution = default(int?), string initContainerImageLocation = default(string), List<LabelAttributesInfo> labelAttributesVec = default(List<LabelAttributesInfo>), string name = default(string), string _namespace = default(string), string pvcName = default(string), List<EntityServicesToConnectorIdsMapEntry> servicesToConnectorIdsMap = default(List<EntityServicesToConnectorIdsMapEntry>), int? type = default(int?), string uuid = default(string), string veleroAwsPluginImageLocation = default(string), string veleroImageLocation = default(string), string veleroOpenshiftPluginImageLocation = default(string), string version = default(string))
        {
            this.DatamoverImageLocation = datamoverImageLocation;
            this.Description = description;
            this.Distribution = distribution;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.LabelAttributesVec = labelAttributesVec;
            this.Name = name;
            this.Namespace = _namespace;
            this.PvcName = pvcName;
            this.ServicesToConnectorIdsMap = servicesToConnectorIdsMap;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.Version = version;
            this.DatamoverImageLocation = datamoverImageLocation;
            this.Description = description;
            this.Distribution = distribution;
            this.InitContainerImageLocation = initContainerImageLocation;
            this.LabelAttributesVec = labelAttributesVec;
            this.Name = name;
            this.Namespace = _namespace;
            this.PvcName = pvcName;
            this.ServicesToConnectorIdsMap = servicesToConnectorIdsMap;
            this.Type = type;
            this.Uuid = uuid;
            this.VeleroAwsPluginImageLocation = veleroAwsPluginImageLocation;
            this.VeleroImageLocation = veleroImageLocation;
            this.VeleroOpenshiftPluginImageLocation = veleroOpenshiftPluginImageLocation;
            this.Version = version;
        }
        
        /// <summary>
        /// Location of the datamover image specified by the user.
        /// </summary>
        /// <value>Location of the datamover image specified by the user.</value>
        [DataMember(Name="datamoverImageLocation", EmitDefaultValue=true)]
        public string DatamoverImageLocation { get; set; }

        /// <summary>
        /// This is a general description that could be set for some entities.
        /// </summary>
        /// <value>This is a general description that could be set for some entities.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// K8s distribution. This will only be applicable to kCluster entities.
        /// </summary>
        /// <value>K8s distribution. This will only be applicable to kCluster entities.</value>
        [DataMember(Name="distribution", EmitDefaultValue=true)]
        public int? Distribution { get; set; }

        /// <summary>
        /// Location of the init container image specified by the user.
        /// </summary>
        /// <value>Location of the init container image specified by the user.</value>
        [DataMember(Name="initContainerImageLocation", EmitDefaultValue=true)]
        public string InitContainerImageLocation { get; set; }

        /// <summary>
        /// Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also.
        /// </summary>
        /// <value>Label attributes vector contains info about the label nodes corresponding to the current entity&#39;s labels. TODO(jhwang): Make it applicable to non-kNamespace type entities also.</value>
        [DataMember(Name="labelAttributesVec", EmitDefaultValue=true)]
        public List<LabelAttributesInfo> LabelAttributesVec { get; set; }

        /// <summary>
        /// A human readable name for the object.
        /// </summary>
        /// <value>A human readable name for the object.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV.
        /// </summary>
        /// <value>Namespace of object, if applicable. For a PV, this field stores the namespace of the PVC which is bound to the PV.</value>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity.
        /// </summary>
        /// <value>Name of the PVC which is bound to the PV. Applicable only to &#39;kPersistentVolume&#39; type entity.</value>
        [DataMember(Name="pvcName", EmitDefaultValue=true)]
        public string PvcName { get; set; }

        /// <summary>
        /// A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities.
        /// </summary>
        /// <value>A mapping from datamover services to corresponding unique connector_params IDs. This will be generated during registration and updated during refresh. Applicable only for &#39;kCluster&#39; type entities.</value>
        [DataMember(Name="servicesToConnectorIdsMap", EmitDefaultValue=true)]
        public List<EntityServicesToConnectorIdsMapEntry> ServicesToConnectorIdsMap { get; set; }

        /// <summary>
        /// The type of entity this proto refers to.
        /// </summary>
        /// <value>The type of entity this proto refers to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// The UUID of the object.
        /// </summary>
        /// <value>The UUID of the object.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Location of the Velero AWS plugin image specified by the user.
        /// </summary>
        /// <value>Location of the Velero AWS plugin image specified by the user.</value>
        [DataMember(Name="veleroAwsPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroAwsPluginImageLocation { get; set; }

        /// <summary>
        /// Location of the Velero image specified by the user.
        /// </summary>
        /// <value>Location of the Velero image specified by the user.</value>
        [DataMember(Name="veleroImageLocation", EmitDefaultValue=true)]
        public string VeleroImageLocation { get; set; }

        /// <summary>
        /// Location of the Velero Openshift plugin image specified by the user.
        /// </summary>
        /// <value>Location of the Velero Openshift plugin image specified by the user.</value>
        [DataMember(Name="veleroOpenshiftPluginImageLocation", EmitDefaultValue=true)]
        public string VeleroOpenshiftPluginImageLocation { get; set; }

        /// <summary>
        /// Kubernetes cluster version.
        /// </summary>
        /// <value>Kubernetes cluster version.</value>
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
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatamoverImageLocation == input.DatamoverImageLocation ||
                    (this.DatamoverImageLocation != null &&
                    this.DatamoverImageLocation.Equals(input.DatamoverImageLocation))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Distribution == input.Distribution ||
                    (this.Distribution != null &&
                    this.Distribution.Equals(input.Distribution))
                ) && 
                (
                    this.InitContainerImageLocation == input.InitContainerImageLocation ||
                    (this.InitContainerImageLocation != null &&
                    this.InitContainerImageLocation.Equals(input.InitContainerImageLocation))
                ) && 
                (
                    this.LabelAttributesVec == input.LabelAttributesVec ||
                    this.LabelAttributesVec != null &&
                    input.LabelAttributesVec != null &&
                    this.LabelAttributesVec.SequenceEqual(input.LabelAttributesVec)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PvcName == input.PvcName ||
                    (this.PvcName != null &&
                    this.PvcName.Equals(input.PvcName))
                ) && 
                (
                    this.ServicesToConnectorIdsMap == input.ServicesToConnectorIdsMap ||
                    this.ServicesToConnectorIdsMap != null &&
                    input.ServicesToConnectorIdsMap != null &&
                    this.ServicesToConnectorIdsMap.SequenceEqual(input.ServicesToConnectorIdsMap)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VeleroAwsPluginImageLocation == input.VeleroAwsPluginImageLocation ||
                    (this.VeleroAwsPluginImageLocation != null &&
                    this.VeleroAwsPluginImageLocation.Equals(input.VeleroAwsPluginImageLocation))
                ) && 
                (
                    this.VeleroImageLocation == input.VeleroImageLocation ||
                    (this.VeleroImageLocation != null &&
                    this.VeleroImageLocation.Equals(input.VeleroImageLocation))
                ) && 
                (
                    this.VeleroOpenshiftPluginImageLocation == input.VeleroOpenshiftPluginImageLocation ||
                    (this.VeleroOpenshiftPluginImageLocation != null &&
                    this.VeleroOpenshiftPluginImageLocation.Equals(input.VeleroOpenshiftPluginImageLocation))
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
                if (this.DatamoverImageLocation != null)
                    hashCode = hashCode * 59 + this.DatamoverImageLocation.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Distribution != null)
                    hashCode = hashCode * 59 + this.Distribution.GetHashCode();
                if (this.InitContainerImageLocation != null)
                    hashCode = hashCode * 59 + this.InitContainerImageLocation.GetHashCode();
                if (this.LabelAttributesVec != null)
                    hashCode = hashCode * 59 + this.LabelAttributesVec.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PvcName != null)
                    hashCode = hashCode * 59 + this.PvcName.GetHashCode();
                if (this.ServicesToConnectorIdsMap != null)
                    hashCode = hashCode * 59 + this.ServicesToConnectorIdsMap.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VeleroAwsPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroAwsPluginImageLocation.GetHashCode();
                if (this.VeleroImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroImageLocation.GetHashCode();
                if (this.VeleroOpenshiftPluginImageLocation != null)
                    hashCode = hashCode * 59 + this.VeleroOpenshiftPluginImageLocation.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}

