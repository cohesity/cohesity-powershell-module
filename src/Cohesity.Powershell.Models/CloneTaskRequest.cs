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
    /// Specifies the settings for a Restore Task that clones VMs or Views.
    /// </summary>
    [DataContract]
    public partial class CloneTaskRequest :  IEquatable<CloneTaskRequest>
    {
        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KCloneVMs for value: kCloneVMs
            /// </summary>
            [EnumMember(Value = "kCloneVMs")]
            KCloneVMs = 1,
            
            /// <summary>
            /// Enum KCloneView for value: kCloneView
            /// </summary>
            [EnumMember(Value = "kCloneView")]
            KCloneView = 2
        }

        /// <summary>
        /// Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View.
        /// </summary>
        /// <value>Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloneTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTaskRequest" /> class.
        /// </summary>
        /// <param name="cloneViewParameters">cloneViewParameters.</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="hypervParameters">Specifies additional parameters for &#39;kHyperV&#39; restore objects..</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="targetViewName">Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task..</param>
        /// <param name="type">Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. (required).</param>
        /// <param name="vlanParameters">Specifies VLAN parameters for the restore operation..</param>
        /// <param name="vmwareParameters">Specifies additional parameters for &#39;kVmware&#39; restore objects..</param>
        public CloneTaskRequest(CloneView_ cloneViewParameters = default(CloneView_), bool? continueOnError = default(bool?), HypervCloneParameters hypervParameters = default(HypervCloneParameters), string name = default(string), long? newParentId = default(long?), List<RestoreObject> objects = default(List<RestoreObject>), string targetViewName = default(string), TypeEnum type = default(TypeEnum), VlanParameters vlanParameters = default(VlanParameters), VmwareCloneParameters vmwareParameters = default(VmwareCloneParameters))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CloneTaskRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CloneTaskRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.CloneViewParameters = cloneViewParameters;
            this.ContinueOnError = continueOnError;
            this.HypervParameters = hypervParameters;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.TargetViewName = targetViewName;
            this.VlanParameters = vlanParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Gets or Sets CloneViewParameters
        /// </summary>
        [DataMember(Name="cloneViewParameters", EmitDefaultValue=false)]
        public CloneView_ CloneViewParameters { get; set; }

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
        public HypervCloneParameters HypervParameters { get; set; }

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
        /// Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task.
        /// </summary>
        /// <value>Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=false)]
        public string TargetViewName { get; set; }


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
        public VmwareCloneParameters VmwareParameters { get; set; }

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
            return this.Equals(input as CloneTaskRequest);
        }

        /// <summary>
        /// Returns true if CloneTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloneViewParameters == input.CloneViewParameters ||
                    (this.CloneViewParameters != null &&
                    this.CloneViewParameters.Equals(input.CloneViewParameters))
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
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                if (this.CloneViewParameters != null)
                    hashCode = hashCode * 59 + this.CloneViewParameters.GetHashCode();
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
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

