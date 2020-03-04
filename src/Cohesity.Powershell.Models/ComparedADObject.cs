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
    /// Represents the details about an AD object and its properties. The attributes of the AD Object contain the information about whether they are equal on both Snapshot AD and Production AD as well as value of attribute on both Production and Snapshot AD.
    /// </summary>
    [DataContract]
    public partial class ComparedADObject :  IEquatable<ComparedADObject>
    {
        /// <summary>
        /// Defines AdObjectFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdObjectFlagsEnum
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
            /// Enum KDestinationNotFound for value: kDestinationNotFound
            /// </summary>
            [EnumMember(Value = "kDestinationNotFound")]
            KDestinationNotFound = 5,

            /// <summary>
            /// Enum KDisableSupported for value: kDisableSupported
            /// </summary>
            [EnumMember(Value = "kDisableSupported")]
            KDisableSupported = 6

        }


        /// <summary>
        /// Specifies the flags related to this AD Object. &#39;kEqual&#39; indicates all the attributes of the AD Object on the Snapshot and Production are equal. &#39;kNotEqual&#39; indicates atleast one of the attribute of the AD Object on the Snapshot and Production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates the AD Object is of &#39;User&#39; object class type. when restoring this object from Snapshot AD to Priduction AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in production AD compared to AD snapshot. In this case, the distinguishedName will be different for these objects &#39;kDestinationNotFound&#39; indicates the object corresponding to dest_guid specified is missing from Production AD. Caller should check this flag and empty &#39;dest_guid&#39; first to find out destination is missing. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation.
        /// </summary>
        /// <value>Specifies the flags related to this AD Object. &#39;kEqual&#39; indicates all the attributes of the AD Object on the Snapshot and Production are equal. &#39;kNotEqual&#39; indicates atleast one of the attribute of the AD Object on the Snapshot and Production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates the AD Object is of &#39;User&#39; object class type. when restoring this object from Snapshot AD to Priduction AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in production AD compared to AD snapshot. In this case, the distinguishedName will be different for these objects &#39;kDestinationNotFound&#39; indicates the object corresponding to dest_guid specified is missing from Production AD. Caller should check this flag and empty &#39;dest_guid&#39; first to find out destination is missing. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation.</value>
        [DataMember(Name="adObjectFlags", EmitDefaultValue=true)]
        public List<AdObjectFlagsEnum> AdObjectFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComparedADObject" /> class.
        /// </summary>
        /// <param name="adAttributes">Specifies the list of AD attributes for the AD object..</param>
        /// <param name="adObjectFlags">Specifies the flags related to this AD Object. &#39;kEqual&#39; indicates all the attributes of the AD Object on the Snapshot and Production are equal. &#39;kNotEqual&#39; indicates atleast one of the attribute of the AD Object on the Snapshot and Production AD are not equal. &#39;kRestorePasswordRequired&#39; indicates the AD Object is of &#39;User&#39; object class type. when restoring this object from Snapshot AD to Priduction AD, a password is required. &#39;kMovedOnDestination&#39; indicates the object has moved to another container or OU in production AD compared to AD snapshot. In this case, the distinguishedName will be different for these objects &#39;kDestinationNotFound&#39; indicates the object corresponding to dest_guid specified is missing from Production AD. Caller should check this flag and empty &#39;dest_guid&#39; first to find out destination is missing. &#39;kDisableSupported&#39; indicates the enable and disable is supported on the AD Object. AD Objects of type &#39;User&#39; and &#39;Computers&#39; support this operation..</param>
        /// <param name="destinationGuid">Specifies the guid of the object in the Production AD which is equivalent to the one in the Snapshot AD..</param>
        /// <param name="errorMessage">Specifies the error message while fetching the AD object..</param>
        /// <param name="mismatchAttrCount">Specifies the number of attributes of AD Object mismatched on the Snapshot and Production AD..</param>
        /// <param name="sourceGuid">Specifies the guid of the AD object in the Snapshot AD..</param>
        public ComparedADObject(List<AdAttribute> adAttributes = default(List<AdAttribute>), List<AdObjectFlagsEnum> adObjectFlags = default(List<AdObjectFlagsEnum>), string destinationGuid = default(string), string errorMessage = default(string), int? mismatchAttrCount = default(int?), string sourceGuid = default(string))
        {
            this.AdAttributes = adAttributes;
            this.AdObjectFlags = adObjectFlags;
            this.DestinationGuid = destinationGuid;
            this.ErrorMessage = errorMessage;
            this.MismatchAttrCount = mismatchAttrCount;
            this.SourceGuid = sourceGuid;
            this.AdAttributes = adAttributes;
            this.AdObjectFlags = adObjectFlags;
            this.DestinationGuid = destinationGuid;
            this.ErrorMessage = errorMessage;
            this.MismatchAttrCount = mismatchAttrCount;
            this.SourceGuid = sourceGuid;
        }
        
        /// <summary>
        /// Specifies the list of AD attributes for the AD object.
        /// </summary>
        /// <value>Specifies the list of AD attributes for the AD object.</value>
        [DataMember(Name="adAttributes", EmitDefaultValue=true)]
        public List<AdAttribute> AdAttributes { get; set; }

        /// <summary>
        /// Specifies the guid of the object in the Production AD which is equivalent to the one in the Snapshot AD.
        /// </summary>
        /// <value>Specifies the guid of the object in the Production AD which is equivalent to the one in the Snapshot AD.</value>
        [DataMember(Name="destinationGuid", EmitDefaultValue=true)]
        public string DestinationGuid { get; set; }

        /// <summary>
        /// Specifies the error message while fetching the AD object.
        /// </summary>
        /// <value>Specifies the error message while fetching the AD object.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the number of attributes of AD Object mismatched on the Snapshot and Production AD.
        /// </summary>
        /// <value>Specifies the number of attributes of AD Object mismatched on the Snapshot and Production AD.</value>
        [DataMember(Name="mismatchAttrCount", EmitDefaultValue=true)]
        public int? MismatchAttrCount { get; set; }

        /// <summary>
        /// Specifies the guid of the AD object in the Snapshot AD.
        /// </summary>
        /// <value>Specifies the guid of the AD object in the Snapshot AD.</value>
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
            return this.Equals(input as ComparedADObject);
        }

        /// <summary>
        /// Returns true if ComparedADObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ComparedADObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComparedADObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdAttributes == input.AdAttributes ||
                    this.AdAttributes != null &&
                    input.AdAttributes != null &&
                    this.AdAttributes.SequenceEqual(input.AdAttributes)
                ) && 
                (
                    this.AdObjectFlags == input.AdObjectFlags ||
                    this.AdObjectFlags.SequenceEqual(input.AdObjectFlags)
                ) && 
                (
                    this.DestinationGuid == input.DestinationGuid ||
                    (this.DestinationGuid != null &&
                    this.DestinationGuid.Equals(input.DestinationGuid))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MismatchAttrCount == input.MismatchAttrCount ||
                    (this.MismatchAttrCount != null &&
                    this.MismatchAttrCount.Equals(input.MismatchAttrCount))
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
                if (this.AdAttributes != null)
                    hashCode = hashCode * 59 + this.AdAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.AdObjectFlags.GetHashCode();
                if (this.DestinationGuid != null)
                    hashCode = hashCode * 59 + this.DestinationGuid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.MismatchAttrCount != null)
                    hashCode = hashCode * 59 + this.MismatchAttrCount.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

