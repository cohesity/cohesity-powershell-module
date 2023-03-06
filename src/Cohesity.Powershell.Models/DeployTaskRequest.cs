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
    /// Specifies the settings for a Deploy Task that deploys VMs on cloud.
    /// </summary>
    [DataContract]
    public partial class DeployTaskRequest :  IEquatable<DeployTaskRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeployTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployTaskRequest" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the Deploy Task. This field must be set and must be a unique name. (required).</param>
        /// <param name="newParentId">Specifies a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them..</param>
        /// <param name="objects">Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects)..</param>
        /// <param name="target">target.</param>
        public DeployTaskRequest(string name = default(string), long? newParentId = default(long?), List<RestoreObjectDetails> objects = default(List<RestoreObjectDetails>), CloudDeployTargetDetails target = default(CloudDeployTargetDetails))
        {
            this.Name = name;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.NewParentId = newParentId;
            this.Objects = objects;
            this.Target = target;
        }
        
        /// <summary>
        /// Specifies the name of the Deploy Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Deploy Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.
        /// </summary>
        /// <value>Specifies a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them.</value>
        [DataMember(Name="newParentId", EmitDefaultValue=true)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).
        /// </summary>
        /// <value>Array of Objects.  Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects).</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObjectDetails> Objects { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public CloudDeployTargetDetails Target { get; set; }

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
            return this.Equals(input as DeployTaskRequest);
        }

        /// <summary>
        /// Returns true if DeployTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployTaskRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewParentId != null)
                    hashCode = hashCode * 59 + this.NewParentId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

    }

}

