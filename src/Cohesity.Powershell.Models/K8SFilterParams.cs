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
    /// Message defining the different criteria to filter objects, such as persistent volumes from backup for include or exclude. This is used to specify both object-level (BackupSourceParams) and job-level (EnvBackupParams) in/exclusion criteria.  If a criterion is specified at both object-level and job-level, then job-level setting will be ignored.
    /// </summary>
    [DataContract]
    public partial class K8SFilterParams :  IEquatable<K8SFilterParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="K8SFilterParams" /> class.
        /// </summary>
        /// <param name="entityVec">List of entities included in filter. This contains the list of entities corresponding to entity IDs in &#39;object_id_vec&#39; and the list of entities under the union of intersection of labels specified by &#39;label_vec_vec&#39;. This will be populated during backup run..</param>
        /// <param name="labelEntityType">Denotes the entity type to which the above label filters apply to..</param>
        /// <param name="labelVecVec">Array of Arrays of Label Ids that Specify Persistent Volumes (PV) and Persistent Volume Claims (PVC) to include in filter. The outer array represents a union operation (i.e.: match any label rule), while the inner array represents an intersection operation (i.e.: match all label rules). See iris/apiSpecs/v2/common/adapters/kubernetes/jobs.yaml:filterLabelIds for full description..</param>
        /// <param name="objectIdVec">IDs of objects to be included in filter..</param>
        /// <param name="resources">Array of kubernetes resource types to be included in the filter..</param>
        /// <param name="selectedResources">Information of the list of resource types that were filtered and the specific resources that were selected for filtering of that type. If this field is populated it assumes that the resources and object_id field are not populated..</param>
        public K8SFilterParams(List<Entity> entityVec = default(List<Entity>), int? labelEntityType = default(int?), List<K8SFilterParamsLabelVec> labelVecVec = default(List<K8SFilterParamsLabelVec>), List<long> objectIdVec = default(List<long>), List<string> resources = default(List<string>), List<ResourceInfo> selectedResources = default(List<ResourceInfo>))
        {
            this.EntityVec = entityVec;
            this.LabelEntityType = labelEntityType;
            this.LabelVecVec = labelVecVec;
            this.ObjectIdVec = objectIdVec;
            this.Resources = resources;
            this.SelectedResources = selectedResources;
            this.EntityVec = entityVec;
            this.LabelEntityType = labelEntityType;
            this.LabelVecVec = labelVecVec;
            this.ObjectIdVec = objectIdVec;
            this.Resources = resources;
            this.SelectedResources = selectedResources;
        }
        
        /// <summary>
        /// List of entities included in filter. This contains the list of entities corresponding to entity IDs in &#39;object_id_vec&#39; and the list of entities under the union of intersection of labels specified by &#39;label_vec_vec&#39;. This will be populated during backup run.
        /// </summary>
        /// <value>List of entities included in filter. This contains the list of entities corresponding to entity IDs in &#39;object_id_vec&#39; and the list of entities under the union of intersection of labels specified by &#39;label_vec_vec&#39;. This will be populated during backup run.</value>
        [DataMember(Name="entityVec", EmitDefaultValue=true)]
        public List<Entity> EntityVec { get; set; }

        /// <summary>
        /// Denotes the entity type to which the above label filters apply to.
        /// </summary>
        /// <value>Denotes the entity type to which the above label filters apply to.</value>
        [DataMember(Name="labelEntityType", EmitDefaultValue=true)]
        public int? LabelEntityType { get; set; }

        /// <summary>
        /// Array of Arrays of Label Ids that Specify Persistent Volumes (PV) and Persistent Volume Claims (PVC) to include in filter. The outer array represents a union operation (i.e.: match any label rule), while the inner array represents an intersection operation (i.e.: match all label rules). See iris/apiSpecs/v2/common/adapters/kubernetes/jobs.yaml:filterLabelIds for full description.
        /// </summary>
        /// <value>Array of Arrays of Label Ids that Specify Persistent Volumes (PV) and Persistent Volume Claims (PVC) to include in filter. The outer array represents a union operation (i.e.: match any label rule), while the inner array represents an intersection operation (i.e.: match all label rules). See iris/apiSpecs/v2/common/adapters/kubernetes/jobs.yaml:filterLabelIds for full description.</value>
        [DataMember(Name="labelVecVec", EmitDefaultValue=true)]
        public List<K8SFilterParamsLabelVec> LabelVecVec { get; set; }

        /// <summary>
        /// IDs of objects to be included in filter.
        /// </summary>
        /// <value>IDs of objects to be included in filter.</value>
        [DataMember(Name="objectIdVec", EmitDefaultValue=true)]
        public List<long> ObjectIdVec { get; set; }

        /// <summary>
        /// Array of kubernetes resource types to be included in the filter.
        /// </summary>
        /// <value>Array of kubernetes resource types to be included in the filter.</value>
        [DataMember(Name="resources", EmitDefaultValue=true)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// Information of the list of resource types that were filtered and the specific resources that were selected for filtering of that type. If this field is populated it assumes that the resources and object_id field are not populated.
        /// </summary>
        /// <value>Information of the list of resource types that were filtered and the specific resources that were selected for filtering of that type. If this field is populated it assumes that the resources and object_id field are not populated.</value>
        [DataMember(Name="selectedResources", EmitDefaultValue=true)]
        public List<ResourceInfo> SelectedResources { get; set; }

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
            return this.Equals(input as K8SFilterParams);
        }

        /// <summary>
        /// Returns true if K8SFilterParams instances are equal
        /// </summary>
        /// <param name="input">Instance of K8SFilterParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(K8SFilterParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityVec == input.EntityVec ||
                    this.EntityVec != null &&
                    input.EntityVec != null &&
                    this.EntityVec.SequenceEqual(input.EntityVec)
                ) && 
                (
                    this.LabelEntityType == input.LabelEntityType ||
                    (this.LabelEntityType != null &&
                    this.LabelEntityType.Equals(input.LabelEntityType))
                ) && 
                (
                    this.LabelVecVec == input.LabelVecVec ||
                    this.LabelVecVec != null &&
                    input.LabelVecVec != null &&
                    this.LabelVecVec.SequenceEqual(input.LabelVecVec)
                ) && 
                (
                    this.ObjectIdVec == input.ObjectIdVec ||
                    this.ObjectIdVec != null &&
                    input.ObjectIdVec != null &&
                    this.ObjectIdVec.SequenceEqual(input.ObjectIdVec)
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.SelectedResources == input.SelectedResources ||
                    this.SelectedResources != null &&
                    input.SelectedResources != null &&
                    this.SelectedResources.SequenceEqual(input.SelectedResources)
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
                if (this.EntityVec != null)
                    hashCode = hashCode * 59 + this.EntityVec.GetHashCode();
                if (this.LabelEntityType != null)
                    hashCode = hashCode * 59 + this.LabelEntityType.GetHashCode();
                if (this.LabelVecVec != null)
                    hashCode = hashCode * 59 + this.LabelVecVec.GetHashCode();
                if (this.ObjectIdVec != null)
                    hashCode = hashCode * 59 + this.ObjectIdVec.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.SelectedResources != null)
                    hashCode = hashCode * 59 + this.SelectedResources.GetHashCode();
                return hashCode;
            }
        }

    }

}

