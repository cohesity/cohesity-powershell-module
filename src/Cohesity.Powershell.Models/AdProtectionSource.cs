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
    /// Specifies an object representing an AD entity.
    /// </summary>
    [DataContract]
    public partial class AdProtectionSource :  IEquatable<AdProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed object in AD Protection Source. Specifies the kind of AD protection source. &#39;kRootContainer&#39; indicates the entity is a root container to an AD domain controller. &#39;kDomainController&#39; indicates the domain controller hosted in this physical server.
        /// </summary>
        /// <value>Specifies the type of the managed object in AD Protection Source. Specifies the kind of AD protection source. &#39;kRootContainer&#39; indicates the entity is a root container to an AD domain controller. &#39;kDomainController&#39; indicates the domain controller hosted in this physical server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KRootContainer for value: kRootContainer
            /// </summary>
            [EnumMember(Value = "kRootContainer")]
            KRootContainer = 1,

            /// <summary>
            /// Enum KDomainController for value: kDomainController
            /// </summary>
            [EnumMember(Value = "kDomainController")]
            KDomainController = 2

        }

        /// <summary>
        /// Specifies the type of the managed object in AD Protection Source. Specifies the kind of AD protection source. &#39;kRootContainer&#39; indicates the entity is a root container to an AD domain controller. &#39;kDomainController&#39; indicates the domain controller hosted in this physical server.
        /// </summary>
        /// <value>Specifies the type of the managed object in AD Protection Source. Specifies the kind of AD protection source. &#39;kRootContainer&#39; indicates the entity is a root container to an AD domain controller. &#39;kDomainController&#39; indicates the domain controller hosted in this physical server.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdProtectionSource" /> class.
        /// </summary>
        /// <param name="domainController">domainController.</param>
        /// <param name="domainName">Specifies the domain name corresponding to the domain controller..</param>
        /// <param name="name">Specifies the domain name of the AD entity..</param>
        /// <param name="ownerId">Specifies the entity id of the owner entity..</param>
        /// <param name="type">Specifies the type of the managed object in AD Protection Source. Specifies the kind of AD protection source. &#39;kRootContainer&#39; indicates the entity is a root container to an AD domain controller. &#39;kDomainController&#39; indicates the domain controller hosted in this physical server..</param>
        /// <param name="uuid">Specifies the UUID for the AD entity..</param>
        public AdProtectionSource(AdDomainController domainController = default(AdDomainController), string domainName = default(string), string name = default(string), long? ownerId = default(long?), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.DomainName = domainName;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Type = type;
            this.Uuid = uuid;
            this.DomainController = domainController;
            this.DomainName = domainName;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets DomainController
        /// </summary>
        [DataMember(Name="domainController", EmitDefaultValue=false)]
        public AdDomainController DomainController { get; set; }

        /// <summary>
        /// Specifies the domain name corresponding to the domain controller.
        /// </summary>
        /// <value>Specifies the domain name corresponding to the domain controller.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the domain name of the AD entity.
        /// </summary>
        /// <value>Specifies the domain name of the AD entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the entity id of the owner entity.
        /// </summary>
        /// <value>Specifies the entity id of the owner entity.</value>
        [DataMember(Name="ownerId", EmitDefaultValue=true)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies the UUID for the AD entity.
        /// </summary>
        /// <value>Specifies the UUID for the AD entity.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as AdProtectionSource);
        }

        /// <summary>
        /// Returns true if AdProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of AdProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainController == input.DomainController ||
                    (this.DomainController != null &&
                    this.DomainController.Equals(input.DomainController))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.DomainController != null)
                    hashCode = hashCode * 59 + this.DomainController.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

