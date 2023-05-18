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
    /// CloudDomainList specfies the cloud domain information associated with the vault.
    /// </summary>
    [DataContract]
    public partial class CloudDomainList :  IEquatable<CloudDomainList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDomainList" /> class.
        /// </summary>
        /// <param name="domainId">Specifies the Id of the cloud domain..</param>
        /// <param name="viewBoxId">Specifies the Id of the ViewBox related to the cloud domain..</param>
        /// <param name="viewBoxName">Specifies the Name of the ViewBox related to the cloud domain..</param>
        public CloudDomainList(long? domainId = default(long?), long? viewBoxId = default(long?), string viewBoxName = default(string))
        {
            this.DomainId = domainId;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
            this.DomainId = domainId;
            this.ViewBoxId = viewBoxId;
            this.ViewBoxName = viewBoxName;
        }
        
        /// <summary>
        /// Specifies the Id of the cloud domain.
        /// </summary>
        /// <value>Specifies the Id of the cloud domain.</value>
        [DataMember(Name="domainId", EmitDefaultValue=true)]
        public long? DomainId { get; set; }

        /// <summary>
        /// Specifies the Id of the ViewBox related to the cloud domain.
        /// </summary>
        /// <value>Specifies the Id of the ViewBox related to the cloud domain.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the Name of the ViewBox related to the cloud domain.
        /// </summary>
        /// <value>Specifies the Name of the ViewBox related to the cloud domain.</value>
        [DataMember(Name="viewBoxName", EmitDefaultValue=true)]
        public string ViewBoxName { get; set; }

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
            return this.Equals(input as CloudDomainList);
        }

        /// <summary>
        /// Returns true if CloudDomainList instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDomainList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDomainList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewBoxName == input.ViewBoxName ||
                    (this.ViewBoxName != null &&
                    this.ViewBoxName.Equals(input.ViewBoxName))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewBoxName != null)
                    hashCode = hashCode * 59 + this.ViewBoxName.GetHashCode();
                return hashCode;
            }
        }

    }

}

