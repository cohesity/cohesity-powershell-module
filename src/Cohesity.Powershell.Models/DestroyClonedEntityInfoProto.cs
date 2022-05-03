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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  DestroyClonedEntityInfoProto.ClonedEntity extension    Location    Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; azure::ClonedEntityInfo::azure_cloned_entity_info   azure/azure.proto   100 aws::ClonedEntityInfo::aws_cloned_entity_info       aws/aws.proto       101 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class DestroyClonedEntityInfoProto :  IEquatable<DestroyClonedEntityInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyClonedEntityInfoProto" /> class.
        /// </summary>
        /// <param name="clonedEntity">clonedEntity.</param>
        /// <param name="clonedEntityStatus">clonedEntityStatus.</param>
        /// <param name="destroyClonedEntityState">The state of the destroy/teardown of a cloned entity (i.e, VM).  The following two fields are set by the slave in order for the master to find status of the destroy operation..</param>
        /// <param name="error">error.</param>
        /// <param name="fullViewName">The full external view name where cloned objects are placed..</param>
        /// <param name="type">The type of environment this destroy cloned entity info pertains to..</param>
        public DestroyClonedEntityInfoProto(DestroyClonedEntityInfoProtoClonedEntity clonedEntity = default(DestroyClonedEntityInfoProtoClonedEntity), int? clonedEntityStatus = default(int?), int? destroyClonedEntityState = default(int?), ErrorProto error = default(ErrorProto), string fullViewName = default(string), int? type = default(int?))
        {
            this.ClonedEntity = clonedEntity;
            this.ClonedEntityStatus = clonedEntityStatus;
            this.DestroyClonedEntityState = destroyClonedEntityState;
            this.Error = error;
            this.FullViewName = fullViewName;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ClonedEntity
        /// </summary>
        [DataMember(Name="clonedEntity", EmitDefaultValue=false)]
        public DestroyClonedEntityInfoProtoClonedEntity ClonedEntity { get; set; }

        /// <summary>
        /// Gets or Sets ClonedEntityStatus
        /// </summary>
        [DataMember(Name="clonedEntityStatus", EmitDefaultValue=false)]
        public int? ClonedEntityStatus { get; set; }

        /// <summary>
        /// The state of the destroy/teardown of a cloned entity (i.e, VM).  The following two fields are set by the slave in order for the master to find status of the destroy operation.
        /// </summary>
        /// <value>The state of the destroy/teardown of a cloned entity (i.e, VM).  The following two fields are set by the slave in order for the master to find status of the destroy operation.</value>
        [DataMember(Name="destroyClonedEntityState", EmitDefaultValue=false)]
        public int? DestroyClonedEntityState { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The full external view name where cloned objects are placed.
        /// </summary>
        /// <value>The full external view name where cloned objects are placed.</value>
        [DataMember(Name="fullViewName", EmitDefaultValue=false)]
        public string FullViewName { get; set; }

        /// <summary>
        /// The type of environment this destroy cloned entity info pertains to.
        /// </summary>
        /// <value>The type of environment this destroy cloned entity info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as DestroyClonedEntityInfoProto);
        }

        /// <summary>
        /// Returns true if DestroyClonedEntityInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyClonedEntityInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyClonedEntityInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClonedEntity == input.ClonedEntity ||
                    (this.ClonedEntity != null &&
                    this.ClonedEntity.Equals(input.ClonedEntity))
                ) && 
                (
                    this.ClonedEntityStatus == input.ClonedEntityStatus ||
                    (this.ClonedEntityStatus != null &&
                    this.ClonedEntityStatus.Equals(input.ClonedEntityStatus))
                ) && 
                (
                    this.DestroyClonedEntityState == input.DestroyClonedEntityState ||
                    (this.DestroyClonedEntityState != null &&
                    this.DestroyClonedEntityState.Equals(input.DestroyClonedEntityState))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FullViewName == input.FullViewName ||
                    (this.FullViewName != null &&
                    this.FullViewName.Equals(input.FullViewName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ClonedEntity != null)
                    hashCode = hashCode * 59 + this.ClonedEntity.GetHashCode();
                if (this.ClonedEntityStatus != null)
                    hashCode = hashCode * 59 + this.ClonedEntityStatus.GetHashCode();
                if (this.DestroyClonedEntityState != null)
                    hashCode = hashCode * 59 + this.DestroyClonedEntityState.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FullViewName != null)
                    hashCode = hashCode * 59 + this.FullViewName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

