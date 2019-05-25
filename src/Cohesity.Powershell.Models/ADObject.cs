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
    /// Represents the details about an AD object.
    /// </summary>
    [DataContract]
    public partial class ADObject :  IEquatable<ADObject>
    {
        /// <summary>
        /// Defines SearchResultFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchResultFlagsEnum
        {
            /// <summary>
            /// Enum KEqual for value: kEqual
            /// </summary>
            [EnumMember(Value = "kEqual")]
            KEqual = 1,

            /// <summary>
            /// Enum KNotEqual for value: kNotEqual
            /// </summary>
            [EnumMember(Value = "kNotEqual")]
            KNotEqual = 2,

            /// <summary>
            /// Enum KRestorePasswordRequired for value: kRestorePasswordRequired
            /// </summary>
            [EnumMember(Value = "kRestorePasswordRequired")]
            KRestorePasswordRequired = 3,

            /// <summary>
            /// Enum KMovedOnDestination for value: kMovedOnDestination
            /// </summary>
            [EnumMember(Value = "kMovedOnDestination")]
            KMovedOnDestination = 4,

            /// <summary>
            /// Enum KDisableSupported for value: kDisableSupported
            /// </summary>
            [EnumMember(Value = "kDisableSupported")]
            KDisableSupported = 5

        }


        /// <summary>
        /// Specifies the SearchResultFlags of the AD object. &#39;kEqual&#39; indicates the AD Object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the AD Object from snapshot and production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates when restoring this AD Object from Snapshot AD to Production AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in Production AD compared to  Snapshot AD. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation.
        /// </summary>
        /// <value>Specifies the SearchResultFlags of the AD object. &#39;kEqual&#39; indicates the AD Object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the AD Object from snapshot and production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates when restoring this AD Object from Snapshot AD to Production AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in Production AD compared to  Snapshot AD. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation.</value>
        [DataMember(Name="searchResultFlags", EmitDefaultValue=true)]
        public List<SearchResultFlagsEnum> SearchResultFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ADObject" /> class.
        /// </summary>
        /// <param name="description">Specifies the &#39;description&#39; of an AD object..</param>
        /// <param name="destinationGuid">Specifies the guid of object in the Production AD which is equivalent to the object in the Snapshot AD..</param>
        /// <param name="destinationPropCount">Specifies the number of properties in AD Object in the Production AD..</param>
        /// <param name="displayName">Specifies the display name of the AD object..</param>
        /// <param name="distinguishedName">Specifies the distinguished name of the AD object. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com.</param>
        /// <param name="errorMessage">Specifies the error message while fetching the AD object..</param>
        /// <param name="mismatchPropName">Specifies the name of the first property which differs in the AD Object fetched from both Snapshot and Production AD..</param>
        /// <param name="objectClass">Specifies the class name of an AD Object such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;..</param>
        /// <param name="searchResultFlags">Specifies the SearchResultFlags of the AD object. &#39;kEqual&#39; indicates the AD Object from Snapshot and Production AD are equal. &#39;kNotEqual&#39; indicates the AD Object from snapshot and production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates when restoring this AD Object from Snapshot AD to Production AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in Production AD compared to  Snapshot AD. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation..</param>
        /// <param name="sourceGuid">Specifies the guid of the AD object in Snapshot AD..</param>
        /// <param name="sourcePropCount">Specifies the number of properties in AD Object in the Snapshot AD..</param>
        public ADObject(string description = default(string), string destinationGuid = default(string), int? destinationPropCount = default(int?), string displayName = default(string), string distinguishedName = default(string), string errorMessage = default(string), string mismatchPropName = default(string), string objectClass = default(string), List<SearchResultFlagsEnum> searchResultFlags = default(List<SearchResultFlagsEnum>), string sourceGuid = default(string), int? sourcePropCount = default(int?))
        {
            this.Description = description;
            this.DestinationGuid = destinationGuid;
            this.DestinationPropCount = destinationPropCount;
            this.DisplayName = displayName;
            this.DistinguishedName = distinguishedName;
            this.ErrorMessage = errorMessage;
            this.MismatchPropName = mismatchPropName;
            this.ObjectClass = objectClass;
            this.SearchResultFlags = searchResultFlags;
            this.SourceGuid = sourceGuid;
            this.SourcePropCount = sourcePropCount;
            this.Description = description;
            this.DestinationGuid = destinationGuid;
            this.DestinationPropCount = destinationPropCount;
            this.DisplayName = displayName;
            this.DistinguishedName = distinguishedName;
            this.ErrorMessage = errorMessage;
            this.MismatchPropName = mismatchPropName;
            this.ObjectClass = objectClass;
            this.SearchResultFlags = searchResultFlags;
            this.SourceGuid = sourceGuid;
            this.SourcePropCount = sourcePropCount;
        }
        
        /// <summary>
        /// Specifies the &#39;description&#39; of an AD object.
        /// </summary>
        /// <value>Specifies the &#39;description&#39; of an AD object.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the guid of object in the Production AD which is equivalent to the object in the Snapshot AD.
        /// </summary>
        /// <value>Specifies the guid of object in the Production AD which is equivalent to the object in the Snapshot AD.</value>
        [DataMember(Name="destinationGuid", EmitDefaultValue=true)]
        public string DestinationGuid { get; set; }

        /// <summary>
        /// Specifies the number of properties in AD Object in the Production AD.
        /// </summary>
        /// <value>Specifies the number of properties in AD Object in the Production AD.</value>
        [DataMember(Name="destinationPropCount", EmitDefaultValue=true)]
        public int? DestinationPropCount { get; set; }

        /// <summary>
        /// Specifies the display name of the AD object.
        /// </summary>
        /// <value>Specifies the display name of the AD object.</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Specifies the distinguished name of the AD object. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com
        /// </summary>
        /// <value>Specifies the distinguished name of the AD object. Eg: CN&#x3D;Jone Doe,OU&#x3D;Users,DC&#x3D;corp,DC&#x3D;cohesity,DC&#x3D;com</value>
        [DataMember(Name="distinguishedName", EmitDefaultValue=true)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Specifies the error message while fetching the AD object.
        /// </summary>
        /// <value>Specifies the error message while fetching the AD object.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the name of the first property which differs in the AD Object fetched from both Snapshot and Production AD.
        /// </summary>
        /// <value>Specifies the name of the first property which differs in the AD Object fetched from both Snapshot and Production AD.</value>
        [DataMember(Name="mismatchPropName", EmitDefaultValue=true)]
        public string MismatchPropName { get; set; }

        /// <summary>
        /// Specifies the class name of an AD Object such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;.
        /// </summary>
        /// <value>Specifies the class name of an AD Object such as &#39;user&#39;,&#39;computer&#39;, &#39;organizationalUnit&#39;.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=true)]
        public string ObjectClass { get; set; }

        /// <summary>
        /// Specifies the guid of the AD object in Snapshot AD.
        /// </summary>
        /// <value>Specifies the guid of the AD object in Snapshot AD.</value>
        [DataMember(Name="sourceGuid", EmitDefaultValue=true)]
        public string SourceGuid { get; set; }

        /// <summary>
        /// Specifies the number of properties in AD Object in the Snapshot AD.
        /// </summary>
        /// <value>Specifies the number of properties in AD Object in the Snapshot AD.</value>
        [DataMember(Name="sourcePropCount", EmitDefaultValue=true)]
        public int? SourcePropCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ADObject {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DestinationGuid: ").Append(DestinationGuid).Append("\n");
            sb.Append("  DestinationPropCount: ").Append(DestinationPropCount).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MismatchPropName: ").Append(MismatchPropName).Append("\n");
            sb.Append("  ObjectClass: ").Append(ObjectClass).Append("\n");
            sb.Append("  SearchResultFlags: ").Append(SearchResultFlags).Append("\n");
            sb.Append("  SourceGuid: ").Append(SourceGuid).Append("\n");
            sb.Append("  SourcePropCount: ").Append(SourcePropCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as ADObject);
        }

        /// <summary>
        /// Returns true if ADObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ADObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DestinationGuid == input.DestinationGuid ||
                    (this.DestinationGuid != null &&
                    this.DestinationGuid.Equals(input.DestinationGuid))
                ) && 
                (
                    this.DestinationPropCount == input.DestinationPropCount ||
                    (this.DestinationPropCount != null &&
                    this.DestinationPropCount.Equals(input.DestinationPropCount))
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
                    this.MismatchPropName == input.MismatchPropName ||
                    (this.MismatchPropName != null &&
                    this.MismatchPropName.Equals(input.MismatchPropName))
                ) && 
                (
                    this.ObjectClass == input.ObjectClass ||
                    (this.ObjectClass != null &&
                    this.ObjectClass.Equals(input.ObjectClass))
                ) && 
                (
                    this.SearchResultFlags == input.SearchResultFlags ||
                    this.SearchResultFlags != null &&
                    input.SearchResultFlags != null &&
                    this.SearchResultFlags.SequenceEqual(input.SearchResultFlags)
                ) && 
                (
                    this.SourceGuid == input.SourceGuid ||
                    (this.SourceGuid != null &&
                    this.SourceGuid.Equals(input.SourceGuid))
                ) && 
                (
                    this.SourcePropCount == input.SourcePropCount ||
                    (this.SourcePropCount != null &&
                    this.SourcePropCount.Equals(input.SourcePropCount))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DestinationGuid != null)
                    hashCode = hashCode * 59 + this.DestinationGuid.GetHashCode();
                if (this.DestinationPropCount != null)
                    hashCode = hashCode * 59 + this.DestinationPropCount.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DistinguishedName != null)
                    hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.MismatchPropName != null)
                    hashCode = hashCode * 59 + this.MismatchPropName.GetHashCode();
                if (this.ObjectClass != null)
                    hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                hashCode = hashCode * 59 + this.SearchResultFlags.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                if (this.SourcePropCount != null)
                    hashCode = hashCode * 59 + this.SourcePropCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
