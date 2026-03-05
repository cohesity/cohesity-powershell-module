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
    /// GenericAdapterBackupJobParams
    /// </summary>
    [DataContract]
    public partial class GenericAdapterBackupJobParams :  IEquatable<GenericAdapterBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericAdapterBackupJobParams" /> class.
        /// </summary>
        /// <param name="taskableEntityTypeIdVec">Optionally specify what all entity types should be considered as taskable for this job. If specified, this dictates an exhaustive list of entity types for which backup tasks will be created during the &#39;pre backup run&#39; entity expansion stage. From the list of entities we get post entity expansion, entities whose entity type is not present in this list will be filtered out and backup tasks will not be created for them..</param>
        public GenericAdapterBackupJobParams(List<int> taskableEntityTypeIdVec = default(List<int>))
        {
            this.TaskableEntityTypeIdVec = taskableEntityTypeIdVec;
            this.TaskableEntityTypeIdVec = taskableEntityTypeIdVec;
        }
        
        /// <summary>
        /// Optionally specify what all entity types should be considered as taskable for this job. If specified, this dictates an exhaustive list of entity types for which backup tasks will be created during the &#39;pre backup run&#39; entity expansion stage. From the list of entities we get post entity expansion, entities whose entity type is not present in this list will be filtered out and backup tasks will not be created for them.
        /// </summary>
        /// <value>Optionally specify what all entity types should be considered as taskable for this job. If specified, this dictates an exhaustive list of entity types for which backup tasks will be created during the &#39;pre backup run&#39; entity expansion stage. From the list of entities we get post entity expansion, entities whose entity type is not present in this list will be filtered out and backup tasks will not be created for them.</value>
        [DataMember(Name="taskableEntityTypeIdVec", EmitDefaultValue=true)]
        public List<int> TaskableEntityTypeIdVec { get; set; }

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
            return this.Equals(input as GenericAdapterBackupJobParams);
        }

        /// <summary>
        /// Returns true if GenericAdapterBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericAdapterBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericAdapterBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskableEntityTypeIdVec == input.TaskableEntityTypeIdVec ||
                    this.TaskableEntityTypeIdVec != null &&
                    input.TaskableEntityTypeIdVec != null &&
                    this.TaskableEntityTypeIdVec.SequenceEqual(input.TaskableEntityTypeIdVec)
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
                if (this.TaskableEntityTypeIdVec != null)
                    hashCode = hashCode * 59 + this.TaskableEntityTypeIdVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

