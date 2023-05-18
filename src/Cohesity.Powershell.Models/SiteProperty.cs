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
    /// Generic site Property structure to store site properties. Some of these site properties are not captured by Get-PnpProvisioningTemplate cmdlet. So they may need to be set outside of Appy-PnPProvisoningTemplate cmdlet.
    /// </summary>
    [DataContract]
    public partial class SiteProperty :  IEquatable<SiteProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteProperty" /> class.
        /// </summary>
        /// <param name="datatype">PnP data type of the property (&#39;string&#39;, &#39;mvstring&#39;, &#39;bool&#39;, &#39;guid&#39;,&#39;&lt;enumname&gt;&#39;,&#39;int&#39;, &#39;int64&#39;, etc.).</param>
        /// <param name="name">Name of the property returned by Get-PnPSite, Get-PnPTenantSite, Get-PnPWeb, or other cmdlets..</param>
        /// <param name="value">Property value represented as string..</param>
        public SiteProperty(string datatype = default(string), string name = default(string), string value = default(string))
        {
            this.Datatype = datatype;
            this.Name = name;
            this.Value = value;
            this.Datatype = datatype;
            this.Name = name;
            this.Value = value;
        }
        
        /// <summary>
        /// PnP data type of the property (&#39;string&#39;, &#39;mvstring&#39;, &#39;bool&#39;, &#39;guid&#39;,&#39;&lt;enumname&gt;&#39;,&#39;int&#39;, &#39;int64&#39;, etc.)
        /// </summary>
        /// <value>PnP data type of the property (&#39;string&#39;, &#39;mvstring&#39;, &#39;bool&#39;, &#39;guid&#39;,&#39;&lt;enumname&gt;&#39;,&#39;int&#39;, &#39;int64&#39;, etc.)</value>
        [DataMember(Name="datatype", EmitDefaultValue=true)]
        public string Datatype { get; set; }

        /// <summary>
        /// Name of the property returned by Get-PnPSite, Get-PnPTenantSite, Get-PnPWeb, or other cmdlets.
        /// </summary>
        /// <value>Name of the property returned by Get-PnPSite, Get-PnPTenantSite, Get-PnPWeb, or other cmdlets.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Property value represented as string.
        /// </summary>
        /// <value>Property value represented as string.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

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
            return this.Equals(input as SiteProperty);
        }

        /// <summary>
        /// Returns true if SiteProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datatype == input.Datatype ||
                    (this.Datatype != null &&
                    this.Datatype.Equals(input.Datatype))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Datatype != null)
                    hashCode = hashCode * 59 + this.Datatype.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

