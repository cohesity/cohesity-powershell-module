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
    /// Specifies an Object containing information about a mongodb Project.
    /// </summary>
    [DataContract]
    public partial class MongoDBProject :  IEquatable<MongoDBProject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBProject" /> class.
        /// </summary>
        /// <param name="projectId">Specifies the Id of Mongodb project..</param>
        /// <param name="projectName">Specifies the NAme of Mongodb project..</param>
        public MongoDBProject(string projectId = default(string), string projectName = default(string))
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }
        
        /// <summary>
        /// Specifies the Id of Mongodb project.
        /// </summary>
        /// <value>Specifies the Id of Mongodb project.</value>
        [DataMember(Name="projectId", EmitDefaultValue=true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Specifies the NAme of Mongodb project.
        /// </summary>
        /// <value>Specifies the NAme of Mongodb project.</value>
        [DataMember(Name="projectName", EmitDefaultValue=true)]
        public string ProjectName { get; set; }

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
            return this.Equals(input as MongoDBProject);
        }

        /// <summary>
        /// Returns true if MongoDBProject instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBProject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                return hashCode;
            }
        }

    }

}

