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
    /// Specifies NFS Mount Point exposed by Isilon Protection Source.
    /// </summary>
    [DataContract]
    public partial class IsilonNfsMountPoint :  IEquatable<IsilonNfsMountPoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonNfsMountPoint" /> class.
        /// </summary>
        /// <param name="accessZoneName">Specifies the Access Zone name..</param>
        /// <param name="description">Specifies the description of the NFS mount point..</param>
        /// <param name="id">Specifies the Id of the NFS export..</param>
        public IsilonNfsMountPoint(string accessZoneName = default(string), string description = default(string), long? id = default(long?))
        {
            this.AccessZoneName = accessZoneName;
            this.Description = description;
            this.Id = id;
        }
        
        /// <summary>
        /// Specifies the Access Zone name.
        /// </summary>
        /// <value>Specifies the Access Zone name.</value>
        [DataMember(Name="accessZoneName", EmitDefaultValue=false)]
        public string AccessZoneName { get; set; }

        /// <summary>
        /// Specifies the description of the NFS mount point.
        /// </summary>
        /// <value>Specifies the description of the NFS mount point.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Id of the NFS export.
        /// </summary>
        /// <value>Specifies the Id of the NFS export.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

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
            return this.Equals(input as IsilonNfsMountPoint);
        }

        /// <summary>
        /// Returns true if IsilonNfsMountPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonNfsMountPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonNfsMountPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessZoneName == input.AccessZoneName ||
                    (this.AccessZoneName != null &&
                    this.AccessZoneName.Equals(input.AccessZoneName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AccessZoneName != null)
                    hashCode = hashCode * 59 + this.AccessZoneName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}

