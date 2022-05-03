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
    /// Specifies configuration settings for antivirus service provider.
    /// </summary>
    [DataContract]
    public partial class AntivirusServiceConfig :  IEquatable<AntivirusServiceConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntivirusServiceConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntivirusServiceConfig" /> class.
        /// </summary>
        /// <param name="description">Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service..</param>
        /// <param name="icapUri">Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt; (required).</param>
        /// <param name="tag">Specifies the tag of antivirus service. This is service-specific \&quot;cookie\&quot; sent from Antivirus server to clients that represents a service&#39;s current state. This tag validates that previous Antivirus server responses can still be considered fresh by an Antivirus client that may be caching them. If a change on the AV server invalidates previous responses, the AV server can invalidate portions of the Antivirus client&#39;s cache by changing its service tag..</param>
        /// <param name="tagId">Specifies the tag Id of antivirus service..</param>
        public AntivirusServiceConfig(string description = default(string), string icapUri = default(string), string tag = default(string), long? tagId = default(long?))
        {
            // to ensure "icapUri" is required (not null)
            if (icapUri == null)
            {
                throw new InvalidDataException("icapUri is a required property for AntivirusServiceConfig and cannot be null");
            }
            else
            {
                this.IcapUri = icapUri;
            }
            this.Description = description;
            this.Tag = tag;
            this.TagId = tagId;
        }
        
        /// <summary>
        /// Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service.
        /// </summary>
        /// <value>Specifies the description of the Antivirus service. This could be any additional information admin might associate with the Antivirus service.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt;
        /// </summary>
        /// <value>Specifies the ICAP uri for this Antivirus service. It is of the form icap://&lt;ip-address&gt;[:&lt;port&gt;]/&lt;service&gt;</value>
        [DataMember(Name="icapUri", EmitDefaultValue=false)]
        public string IcapUri { get; set; }

        /// <summary>
        /// Specifies the tag of antivirus service. This is service-specific \&quot;cookie\&quot; sent from Antivirus server to clients that represents a service&#39;s current state. This tag validates that previous Antivirus server responses can still be considered fresh by an Antivirus client that may be caching them. If a change on the AV server invalidates previous responses, the AV server can invalidate portions of the Antivirus client&#39;s cache by changing its service tag.
        /// </summary>
        /// <value>Specifies the tag of antivirus service. This is service-specific \&quot;cookie\&quot; sent from Antivirus server to clients that represents a service&#39;s current state. This tag validates that previous Antivirus server responses can still be considered fresh by an Antivirus client that may be caching them. If a change on the AV server invalidates previous responses, the AV server can invalidate portions of the Antivirus client&#39;s cache by changing its service tag.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Specifies the tag Id of antivirus service.
        /// </summary>
        /// <value>Specifies the tag Id of antivirus service.</value>
        [DataMember(Name="tagId", EmitDefaultValue=false)]
        public long? TagId { get; set; }

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
            return this.Equals(input as AntivirusServiceConfig);
        }

        /// <summary>
        /// Returns true if AntivirusServiceConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AntivirusServiceConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntivirusServiceConfig input)
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
                    this.IcapUri == input.IcapUri ||
                    (this.IcapUri != null &&
                    this.IcapUri.Equals(input.IcapUri))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
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
                if (this.IcapUri != null)
                    hashCode = hashCode * 59 + this.IcapUri.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.TagId != null)
                    hashCode = hashCode * 59 + this.TagId.GetHashCode();
                return hashCode;
            }
        }

    }

}

