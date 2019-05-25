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
    /// Specifies the settings for a Restore Task that clones VMs or Views.
    /// </summary>
    [DataContract]
    public partial class CloneTaskRequest :  IEquatable<CloneTaskRequest>
    {
        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours.This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be use to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours.This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be use to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GlacierRetrievalTypeEnum
        {
            /// <summary>
            /// Enum KStandard for value: kStandard
            /// </summary>
            [EnumMember(Value = "kStandard")]
            KStandard = 1,

            /// <summary>
            /// Enum KBulk for value: kBulk
            /// </summary>
            [EnumMember(Value = "kBulk")]
            KBulk = 2,

            /// <summary>
            /// Enum KExpedited for value: kExpedited
            /// </summary>
            [EnumMember(Value = "kExpedited")]
            KExpedited = 3

        }

        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours.This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be use to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours.This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be use to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [DataMember(Name="glacierRetrievalType", EmitDefaultValue=true)]
        public GlacierRetrievalTypeEnum? GlacierRetrievalType { get; set; }
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
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloneTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTaskRequest" /> class.
        /// </summary>
        /// <param name="cloneViewParameters">Specifies settings for cloning an existing View. This field is required for a &#39;kCloneView&#39; Restore Task..</param>
        /// <param name="continueOnError">Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible..</param>
        /// <param name="glacierRetrievalType">Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours.This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be use to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes..</param>
        /// <param name="hypervParameters">hypervParameters.</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="targetViewName">Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task..</param>
        /// <param name="type">Specifies the type of Restore Task such as &#39;kCloneVMs&#39; or &#39;kCloneView&#39;. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. (required).</param>
        /// <param name="vlanParameters">vlanParameters.</param>
        /// <param name="vmwareParameters">vmwareParameters.</param>
        public CloneTaskRequest(CloneViewRequest cloneViewParameters = default(CloneViewRequest), bool? continueOnError = default(bool?), GlacierRetrievalTypeEnum? glacierRetrievalType = default(GlacierRetrievalTypeEnum?), HypervCloneParameters hypervParameters = default(HypervCloneParameters), string name = default(string), long? newParentId = default(long?), List<RestoreObjectDetails> objects = default(List<RestoreObjectDetails>), string targetViewName = default(string), TypeEnum type = default(TypeEnum), VlanParameters vlanParameters = default(VlanParameters), VmwareCloneParameters vmwareParameters = default(VmwareCloneParameters))
        {
            this.CloneViewParameters = cloneViewParameters;
            this.ContinueOnError = continueOnError;
            this.GlacierRetrievalType = glacierRetrievalType;
            this.Name = name;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.TargetViewName = targetViewName;
            this.Type = type;
            this.CloneViewParameters = cloneViewParameters;
            this.ContinueOnError = continueOnError;
            this.GlacierRetrievalType = glacierRetrievalType;
            this.HypervParameters = hypervParameters;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.TargetViewName = targetViewName;
            this.VlanParameters = vlanParameters;
            this.VmwareParameters = vmwareParameters;
        }
        
        /// <summary>
        /// Specifies settings for cloning an existing View. This field is required for a &#39;kCloneView&#39; Restore Task.
        /// </summary>
        /// <value>Specifies settings for cloning an existing View. This field is required for a &#39;kCloneView&#39; Restore Task.</value>
        [DataMember(Name="cloneViewParameters", EmitDefaultValue=true)]
        public CloneViewRequest CloneViewParameters { get; set; }

        /// <summary>
        /// Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Gets or Sets HypervParameters
        /// </summary>
        [DataMember(Name="hypervParameters", EmitDefaultValue=false)]
        public HypervCloneParameters HypervParameters { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=true)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObjectDetails> Objects { get; set; }

        /// <summary>
        /// Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task.
        /// </summary>
        /// <value>Specifies the name of the View where the cloned VMs are stored. This field is required for a &#39;kCloneVMs&#39; Restore Task.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// Gets or Sets VlanParameters
        /// </summary>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParameters
        /// </summary>
        [DataMember(Name="vmwareParameters", EmitDefaultValue=false)]
        public VmwareCloneParameters VmwareParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneTaskRequest {\n");
            sb.Append("  CloneViewParameters: ").Append(CloneViewParameters).Append("\n");
            sb.Append("  ContinueOnError: ").Append(ContinueOnError).Append("\n");
            sb.Append("  GlacierRetrievalType: ").Append(GlacierRetrievalType).Append("\n");
            sb.Append("  HypervParameters: ").Append(HypervParameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewParentId: ").Append(NewParentId).Append("\n");
            sb.Append("  Objects: ").Append(Objects).Append("\n");
            sb.Append("  TargetViewName: ").Append(TargetViewName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VlanParameters: ").Append(VlanParameters).Append("\n");
            sb.Append("  VmwareParameters: ").Append(VmwareParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                    this.GlacierRetrievalType == input.GlacierRetrievalType ||
                    this.GlacierRetrievalType.Equals(input.GlacierRetrievalType)
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
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                ) && 
                (
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.GlacierRetrievalType.GetHashCode();
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
