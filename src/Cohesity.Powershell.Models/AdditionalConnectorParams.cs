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
    /// Message that encapsulates the additional connector params to establish a connection with a particular environment.
    /// </summary>
    [DataContract]
    public partial class AdditionalConnectorParams :  IEquatable<AdditionalConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalConnectorParams" /> class.
        /// </summary>
        /// <param name="o365Region">o365Region.</param>
        /// <param name="useOutlookEwsOauth">Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online..</param>
        public AdditionalConnectorParams(O365RegionProto o365Region = default(O365RegionProto), bool? useOutlookEwsOauth = default(bool?))
        {
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
            this.O365Region = o365Region;
            this.UseOutlookEwsOauth = useOutlookEwsOauth;
        }
        
        /// <summary>
        /// Gets or Sets O365Region
        /// </summary>
        [DataMember(Name="o365Region", EmitDefaultValue=false)]
        public O365RegionProto O365Region { get; set; }

        /// <summary>
        /// Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online.
        /// </summary>
        /// <value>Whether OAuth should be used for authentication with EWS API (outlook backup), applicable only for Exchange Online.</value>
        [DataMember(Name="useOutlookEwsOauth", EmitDefaultValue=true)]
        public bool? UseOutlookEwsOauth { get; set; }

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
            return this.Equals(input as AdditionalConnectorParams);
        }

        /// <summary>
        /// Returns true if AdditionalConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.O365Region == input.O365Region ||
                    (this.O365Region != null &&
                    this.O365Region.Equals(input.O365Region))
                ) && 
                (
                    this.UseOutlookEwsOauth == input.UseOutlookEwsOauth ||
                    (this.UseOutlookEwsOauth != null &&
                    this.UseOutlookEwsOauth.Equals(input.UseOutlookEwsOauth))
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
                if (this.O365Region != null)
                    hashCode = hashCode * 59 + this.O365Region.GetHashCode();
                if (this.UseOutlookEwsOauth != null)
                    hashCode = hashCode * 59 + this.UseOutlookEwsOauth.GetHashCode();
                return hashCode;
            }
        }

    }

}

