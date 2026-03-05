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
    /// Specifies an Object containing information about a mongodb Organization.
    /// </summary>
    [DataContract]
    public partial class MongoDBOrganization :  IEquatable<MongoDBOrganization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBOrganization" /> class.
        /// </summary>
        /// <param name="organizationId">Specifies the Id of Mongodb organization..</param>
        /// <param name="organizationName">Specifies the Name for the MongoDB organization..</param>
        public MongoDBOrganization(string organizationId = default(string), string organizationName = default(string))
        {
            this.OrganizationId = organizationId;
            this.OrganizationName = organizationName;
            this.OrganizationId = organizationId;
            this.OrganizationName = organizationName;
        }
        
        /// <summary>
        /// Specifies the Id of Mongodb organization.
        /// </summary>
        /// <value>Specifies the Id of Mongodb organization.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=true)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Specifies the Name for the MongoDB organization.
        /// </summary>
        /// <value>Specifies the Name for the MongoDB organization.</value>
        [DataMember(Name="organizationName", EmitDefaultValue=true)]
        public string OrganizationName { get; set; }

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
            return this.Equals(input as MongoDBOrganization);
        }

        /// <summary>
        /// Returns true if MongoDBOrganization instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBOrganization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                return hashCode;
            }
        }

    }

}

