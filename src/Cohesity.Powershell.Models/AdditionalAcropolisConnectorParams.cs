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
    /// AdditionalAcropolisConnectorParams
    /// </summary>
    [DataContract]
    public partial class AdditionalAcropolisConnectorParams :  IEquatable<AdditionalAcropolisConnectorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalAcropolisConnectorParams" /> class.
        /// </summary>
        /// <param name="isPrismCentral">Indicates whether the connection is to a Prism Central cluster. If false, connection is to a Prism Element cluster..</param>
        /// <param name="pcConnectorParams">pcConnectorParams.</param>
        public AdditionalAcropolisConnectorParams(bool? isPrismCentral = default(bool?), ConnectorParams pcConnectorParams = default(ConnectorParams))
        {
            this.IsPrismCentral = isPrismCentral;
            this.IsPrismCentral = isPrismCentral;
            this.PcConnectorParams = pcConnectorParams;
        }
        
        /// <summary>
        /// Indicates whether the connection is to a Prism Central cluster. If false, connection is to a Prism Element cluster.
        /// </summary>
        /// <value>Indicates whether the connection is to a Prism Central cluster. If false, connection is to a Prism Element cluster.</value>
        [DataMember(Name="isPrismCentral", EmitDefaultValue=true)]
        public bool? IsPrismCentral { get; set; }

        /// <summary>
        /// Gets or Sets PcConnectorParams
        /// </summary>
        [DataMember(Name="pcConnectorParams", EmitDefaultValue=false)]
        public ConnectorParams PcConnectorParams { get; set; }

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
            return this.Equals(input as AdditionalAcropolisConnectorParams);
        }

        /// <summary>
        /// Returns true if AdditionalAcropolisConnectorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalAcropolisConnectorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalAcropolisConnectorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPrismCentral == input.IsPrismCentral ||
                    (this.IsPrismCentral != null &&
                    this.IsPrismCentral.Equals(input.IsPrismCentral))
                ) && 
                (
                    this.PcConnectorParams == input.PcConnectorParams ||
                    (this.PcConnectorParams != null &&
                    this.PcConnectorParams.Equals(input.PcConnectorParams))
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
                if (this.IsPrismCentral != null)
                    hashCode = hashCode * 59 + this.IsPrismCentral.GetHashCode();
                if (this.PcConnectorParams != null)
                    hashCode = hashCode * 59 + this.PcConnectorParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

