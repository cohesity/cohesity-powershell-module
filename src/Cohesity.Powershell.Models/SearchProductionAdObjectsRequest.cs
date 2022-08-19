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
    /// Specifies the request to search AD objects from Production AD.
    /// </summary>
    [DataContract]
    public partial class SearchProductionAdObjectsRequest :  IEquatable<SearchProductionAdObjectsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchProductionAdObjectsRequest" /> class.
        /// </summary>
        /// <param name="distinguishedNames">Specifies the list of the distinguished names of the AD objects..</param>
        /// <param name="objectGuids">Specifies the list of the guids of the AD objects..</param>
        /// <param name="protectionSourceId">ProtectionSourceId is the Id of the Domain Controller host on which we want to search for AD objects..</param>
        /// <param name="samAccountNames">Specifies the list of the sam account names of the AD objects..</param>
        public SearchProductionAdObjectsRequest(List<string> distinguishedNames = default(List<string>), List<string> objectGuids = default(List<string>), long? protectionSourceId = default(long?), List<string> samAccountNames = default(List<string>))
        {
            this.DistinguishedNames = distinguishedNames;
            this.ObjectGuids = objectGuids;
            this.ProtectionSourceId = protectionSourceId;
            this.SamAccountNames = samAccountNames;
        }
        
        /// <summary>
        /// Specifies the list of the distinguished names of the AD objects.
        /// </summary>
        /// <value>Specifies the list of the distinguished names of the AD objects.</value>
        [DataMember(Name="distinguishedNames", EmitDefaultValue=true)]
        public List<string> DistinguishedNames { get; set; }

        /// <summary>
        /// Specifies the list of the guids of the AD objects.
        /// </summary>
        /// <value>Specifies the list of the guids of the AD objects.</value>
        [DataMember(Name="objectGuids", EmitDefaultValue=true)]
        public List<string> ObjectGuids { get; set; }

        /// <summary>
        /// ProtectionSourceId is the Id of the Domain Controller host on which we want to search for AD objects.
        /// </summary>
        /// <value>ProtectionSourceId is the Id of the Domain Controller host on which we want to search for AD objects.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=true)]
        public long? ProtectionSourceId { get; set; }

        /// <summary>
        /// Specifies the list of the sam account names of the AD objects.
        /// </summary>
        /// <value>Specifies the list of the sam account names of the AD objects.</value>
        [DataMember(Name="samAccountNames", EmitDefaultValue=true)]
        public List<string> SamAccountNames { get; set; }

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
            return this.Equals(input as SearchProductionAdObjectsRequest);
        }

        /// <summary>
        /// Returns true if SearchProductionAdObjectsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchProductionAdObjectsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchProductionAdObjectsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistinguishedNames == input.DistinguishedNames ||
                    this.DistinguishedNames != null &&
                    input.DistinguishedNames != null &&
                    this.DistinguishedNames.Equals(input.DistinguishedNames)
                ) && 
                (
                    this.ObjectGuids == input.ObjectGuids ||
                    this.ObjectGuids != null &&
                    input.ObjectGuids != null &&
                    this.ObjectGuids.Equals(input.ObjectGuids)
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
                ) && 
                (
                    this.SamAccountNames == input.SamAccountNames ||
                    this.SamAccountNames != null &&
                    input.SamAccountNames != null &&
                    this.SamAccountNames.Equals(input.SamAccountNames)
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
                if (this.DistinguishedNames != null)
                    hashCode = hashCode * 59 + this.DistinguishedNames.GetHashCode();
                if (this.ObjectGuids != null)
                    hashCode = hashCode * 59 + this.ObjectGuids.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                if (this.SamAccountNames != null)
                    hashCode = hashCode * 59 + this.SamAccountNames.GetHashCode();
                return hashCode;
            }
        }

    }

}

