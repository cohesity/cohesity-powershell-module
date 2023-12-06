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
    /// Project
    /// </summary>
    [DataContract]
    public partial class Project :  IEquatable<Project>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        /// <param name="domainId">The ID of the domain to which the project is scoped. This field is used in the reponse of Keystone API..</param>
        /// <param name="id">The ID of the project..</param>
        /// <param name="name">The name of the project..</param>
        public Project(Domain domain = default(Domain), string domainId = default(string), string id = default(string), string name = default(string))
        {
            this.DomainId = domainId;
            this.Id = id;
            this.Name = name;
            this.Domain = domain;
            this.DomainId = domainId;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public Domain Domain { get; set; }

        /// <summary>
        /// The ID of the domain to which the project is scoped. This field is used in the reponse of Keystone API.
        /// </summary>
        /// <value>The ID of the domain to which the project is scoped. This field is used in the reponse of Keystone API.</value>
        [DataMember(Name="domainId", EmitDefaultValue=true)]
        public string DomainId { get; set; }

        /// <summary>
        /// The ID of the project.
        /// </summary>
        /// <value>The ID of the project.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

