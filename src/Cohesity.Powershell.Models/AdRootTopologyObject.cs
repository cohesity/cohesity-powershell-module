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
    /// Represents a node in AD Topology tree.
    /// </summary>
    [DataContract]
    public partial class AdRootTopologyObject :  IEquatable<AdRootTopologyObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdRootTopologyObject" /> class.
        /// </summary>
        /// <param name="childObjects">Specifies the array of children of this object..</param>
        /// <param name="description">Specifies the &#39;description&#39; of an object..</param>
        /// <param name="destGuid">Specifies the guid of matching &#39;source_guid&#39; from production AD. This is looked up  based on source_guid or distinguishedName attribute value..</param>
        /// <param name="displayName">Specifies the display name of the object in AD Topology tree..</param>
        /// <param name="distinguishedName">Specifies the distinguished name of the object in AD Topology tree. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com.</param>
        /// <param name="errorMessage">Specifies the AD error while fetching the ADRootTopologyObject..</param>
        /// <param name="objectClass">Specifies the LDAP class name such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;..</param>
        /// <param name="sourceGuid">Specifies the guid string of the object in AD snapshot database..</param>
        public AdRootTopologyObject(List<Object> childObjects = default(List<Object>), string description = default(string), string destGuid = default(string), string displayName = default(string), string distinguishedName = default(string), string errorMessage = default(string), string objectClass = default(string), string sourceGuid = default(string))
        {
            this.ChildObjects = childObjects;
            this.Description = description;
            this.DestGuid = destGuid;
            this.DisplayName = displayName;
            this.DistinguishedName = distinguishedName;
            this.ErrorMessage = errorMessage;
            this.ObjectClass = objectClass;
            this.SourceGuid = sourceGuid;
            this.ChildObjects = childObjects;
            this.Description = description;
            this.DestGuid = destGuid;
            this.DisplayName = displayName;
            this.DistinguishedName = distinguishedName;
            this.ErrorMessage = errorMessage;
            this.ObjectClass = objectClass;
            this.SourceGuid = sourceGuid;
        }
        
        /// <summary>
        /// Specifies the array of children of this object.
        /// </summary>
        /// <value>Specifies the array of children of this object.</value>
        [DataMember(Name="childObjects", EmitDefaultValue=true)]
        public List<Object> ChildObjects { get; set; }

        /// <summary>
        /// Specifies the &#39;description&#39; of an object.
        /// </summary>
        /// <value>Specifies the &#39;description&#39; of an object.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the guid of matching &#39;source_guid&#39; from production AD. This is looked up  based on source_guid or distinguishedName attribute value.
        /// </summary>
        /// <value>Specifies the guid of matching &#39;source_guid&#39; from production AD. This is looked up  based on source_guid or distinguishedName attribute value.</value>
        [DataMember(Name="destGuid", EmitDefaultValue=true)]
        public string DestGuid { get; set; }

        /// <summary>
        /// Specifies the display name of the object in AD Topology tree.
        /// </summary>
        /// <value>Specifies the display name of the object in AD Topology tree.</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Specifies the distinguished name of the object in AD Topology tree. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com
        /// </summary>
        /// <value>Specifies the distinguished name of the object in AD Topology tree. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com</value>
        [DataMember(Name="distinguishedName", EmitDefaultValue=true)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Specifies the AD error while fetching the ADRootTopologyObject.
        /// </summary>
        /// <value>Specifies the AD error while fetching the ADRootTopologyObject.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the LDAP class name such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;.
        /// </summary>
        /// <value>Specifies the LDAP class name such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=true)]
        public string ObjectClass { get; set; }

        /// <summary>
        /// Specifies the guid string of the object in AD snapshot database.
        /// </summary>
        /// <value>Specifies the guid string of the object in AD snapshot database.</value>
        [DataMember(Name="sourceGuid", EmitDefaultValue=true)]
        public string SourceGuid { get; set; }

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
            return this.Equals(input as AdRootTopologyObject);
        }

        /// <summary>
        /// Returns true if AdRootTopologyObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AdRootTopologyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdRootTopologyObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildObjects == input.ChildObjects ||
                    this.ChildObjects != null &&
                    input.ChildObjects != null &&
                    this.ChildObjects.SequenceEqual(input.ChildObjects)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DestGuid == input.DestGuid ||
                    (this.DestGuid != null &&
                    this.DestGuid.Equals(input.DestGuid))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DistinguishedName == input.DistinguishedName ||
                    (this.DistinguishedName != null &&
                    this.DistinguishedName.Equals(input.DistinguishedName))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ObjectClass == input.ObjectClass ||
                    (this.ObjectClass != null &&
                    this.ObjectClass.Equals(input.ObjectClass))
                ) && 
                (
                    this.SourceGuid == input.SourceGuid ||
                    (this.SourceGuid != null &&
                    this.SourceGuid.Equals(input.SourceGuid))
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
                if (this.ChildObjects != null)
                    hashCode = hashCode * 59 + this.ChildObjects.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DestGuid != null)
                    hashCode = hashCode * 59 + this.DestGuid.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DistinguishedName != null)
                    hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ObjectClass != null)
                    hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

