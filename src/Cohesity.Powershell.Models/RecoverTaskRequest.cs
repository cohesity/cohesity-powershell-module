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
    /// Create a Restore Task Request for recovering VMs or mounting volumes to mount points.
    /// </summary>
    [DataContract]
    public partial class RecoverTaskRequest :  IEquatable<RecoverTaskRequest>
    {
        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KRecoverVMs for value: kRecoverVMs
            /// </summary>
            [EnumMember(Value = "kRecoverVMs")]
            KRecoverVMs = 1,
            
            /// <summary>
            /// Enum KMountVolumes for value: kMountVolumes
            /// </summary>
            [EnumMember(Value = "kMountVolumes")]
            KMountVolumes = 2
        }

        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecoverTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverTaskRequest" /> class.
        /// </summary>
        /// <param name="acropolisParameters">Specifies additional parameters for &#39;kAcropolis&#39; restore objects..</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="hypervParameters">Specifies additional parameters for &#39;kHyperV&#39; restore objects..</param>
        /// <param name="mountParameters">Specifies parameters required for mounting volumes..</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="type">Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. (required).</param>
        /// <param name="vlanParameters">Specifies VLAN parameters for the restore operation..</param>
        /// <param name="vmwareParameters">Specifies additional parameters for &#39;kVmware&#39; restore objects..</param>
        public RecoverTaskRequest(AcropolisRestoreParameters acropolisParameters = default(AcropolisRestoreParameters), bool? continueOnError = default(bool?), HypervRestoreParameters hypervParameters = default(HypervRestoreParameters), MountVolumesParameters mountParameters = default(MountVolumesParameters), string name = default(string), long? newParentId = default(long?), List<RestoreObject> objects = default(List<RestoreObject>), TypeEnum type = default(TypeEnum), VlanParameters vlanParameters = default(VlanParameters), VmwareRestoreParameters vmwareParameters = default(VmwareRestoreParameters))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RecoverTaskRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RecoverTaskRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.AcropolisParameters = acropolisParameters;
            this.ContinueOnError = continueOnError;
            this.HypervParameters = hypervParameters;
            this.MountParameters = mountParameters;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.VlanParameters = vlanParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Specifies additional parameters for &#39;kAcropolis&#39; restore objects.
        /// </summary>
        /// <value>Specifies additional parameters for &#39;kAcropolis&#39; restore objects.</value>
        [DataMember(Name="acropolisParameters", EmitDefaultValue=false)]
        public AcropolisRestoreParameters AcropolisParameters { get; set; }

        /// <summary>
        /// Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=false)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Specifies additional parameters for &#39;kHyperV&#39; restore objects.
        /// </summary>
        /// <value>Specifies additional parameters for &#39;kHyperV&#39; restore objects.</value>
        [DataMember(Name="hypervParameters", EmitDefaultValue=false)]
        public HypervRestoreParameters HypervParameters { get; set; }

        /// <summary>
        /// Specifies parameters required for mounting volumes.
        /// </summary>
        /// <value>Specifies parameters required for mounting volumes.</value>
        [DataMember(Name="mountParameters", EmitDefaultValue=false)]
        public MountVolumesParameters MountParameters { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=false)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=false)]
        public List<RestoreObject> Objects { get; set; }


        /// <summary>
        /// Specifies VLAN parameters for the restore operation.
        /// </summary>
        /// <value>Specifies VLAN parameters for the restore operation.</value>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

        /// <summary>
        /// Specifies additional parameters for &#39;kVmware&#39; restore objects.
        /// </summary>
        /// <value>Specifies additional parameters for &#39;kVmware&#39; restore objects.</value>
        [DataMember(Name="vmwareParameters", EmitDefaultValue=false)]
        public VmwareRestoreParameters VmwareParameters { get; set; }

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
            return this.Equals(input as RecoverTaskRequest);
        }

        /// <summary>
        /// Returns true if RecoverTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisParameters == input.AcropolisParameters ||
                    (this.AcropolisParameters != null &&
                    this.AcropolisParameters.Equals(input.AcropolisParameters))
                ) && 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.HypervParameters == input.HypervParameters ||
                    (this.HypervParameters != null &&
                    this.HypervParameters.Equals(input.HypervParameters))
                ) && 
                (
                    this.MountParameters == input.MountParameters ||
                    (this.MountParameters != null &&
                    this.MountParameters.Equals(input.MountParameters))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewParentId == input.NewParentId ||
                    (this.NewParentId != null &&
                    this.NewParentId.Equals(input.NewParentId))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VlanParameters == input.VlanParameters ||
                    (this.VlanParameters != null &&
                    this.VlanParameters.Equals(input.VlanParameters))
                ) && 
                (
                    this.VmwareParameters == input.VmwareParameters ||
                    (this.VmwareParameters != null &&
                    this.VmwareParameters.Equals(input.VmwareParameters))
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
                if (this.AcropolisParameters != null)
                    hashCode = hashCode * 59 + this.AcropolisParameters.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.MountParameters != null)
                    hashCode = hashCode * 59 + this.MountParameters.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VlanParameters != null)
                    hashCode = hashCode * 59 + this.VlanParameters.GetHashCode();
                if (this.VmwareParameters != null)
                    hashCode = hashCode * 59 + this.VmwareParameters.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

