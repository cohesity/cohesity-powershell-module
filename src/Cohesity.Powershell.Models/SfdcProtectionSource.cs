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
    /// Specifies an Object representing Salesforce.
    /// </summary>
    [DataContract]
    public partial class SfdcProtectionSource :  IEquatable<SfdcProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in Salesforce Protection Source. Sfdc related params.  Specifies the type of an Salesforce source entity. &#39;kOrg&#39; indicates a Salseforce Org. &#39;kObject&#39; indicates a object within the Salesforce Org.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Salesforce Protection Source. Sfdc related params.  Specifies the type of an Salesforce source entity. &#39;kOrg&#39; indicates a Salseforce Org. &#39;kObject&#39; indicates a object within the Salesforce Org.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KOrg for value: kOrg
            /// </summary>
            [EnumMember(Value = "kOrg")]
            KOrg = 1,

            /// <summary>
            /// Enum KObject for value: kObject
            /// </summary>
            [EnumMember(Value = "kObject")]
            KObject = 2

        }

        /// <summary>
        /// Specifies the type of the managed Object in Salesforce Protection Source. Sfdc related params.  Specifies the type of an Salesforce source entity. &#39;kOrg&#39; indicates a Salseforce Org. &#39;kObject&#39; indicates a object within the Salesforce Org.
        /// </summary>
        /// <value>Specifies the type of the managed Object in Salesforce Protection Source. Sfdc related params.  Specifies the type of an Salesforce source entity. &#39;kOrg&#39; indicates a Salseforce Org. &#39;kObject&#39; indicates a object within the Salesforce Org.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SfdcProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies the instance name of the Salesforce entity..</param>
        /// <param name="objectInfo">objectInfo.</param>
        /// <param name="orgInfo">orgInfo.</param>
        /// <param name="type">Specifies the type of the managed Object in Salesforce Protection Source. Sfdc related params.  Specifies the type of an Salesforce source entity. &#39;kOrg&#39; indicates a Salseforce Org. &#39;kObject&#39; indicates a object within the Salesforce Org..</param>
        public SfdcProtectionSource(string name = default(string), SfdcObject objectInfo = default(SfdcObject), SfdcOrg orgInfo = default(SfdcOrg), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
            this.Name = name;
            this.ObjectInfo = objectInfo;
            this.OrgInfo = orgInfo;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the instance name of the Salesforce entity.
        /// </summary>
        /// <value>Specifies the instance name of the Salesforce entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ObjectInfo
        /// </summary>
        [DataMember(Name="objectInfo", EmitDefaultValue=false)]
        public SfdcObject ObjectInfo { get; set; }

        /// <summary>
        /// Gets or Sets OrgInfo
        /// </summary>
        [DataMember(Name="orgInfo", EmitDefaultValue=false)]
        public SfdcOrg OrgInfo { get; set; }

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
            return this.Equals(input as SfdcProtectionSource);
        }

        /// <summary>
        /// Returns true if SfdcProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of SfdcProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SfdcProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    (this.ObjectInfo != null &&
                    this.ObjectInfo.Equals(input.ObjectInfo))
                ) && 
                (
                    this.OrgInfo == input.OrgInfo ||
                    (this.OrgInfo != null &&
                    this.OrgInfo.Equals(input.OrgInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.OrgInfo != null)
                    hashCode = hashCode * 59 + this.OrgInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

