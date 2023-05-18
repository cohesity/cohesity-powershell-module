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
    /// ExternallyTriggeredSbtParameters
    /// </summary>
    [DataContract]
    public partial class ExternallyTriggeredSbtParameters :  IEquatable<ExternallyTriggeredSbtParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternallyTriggeredSbtParameters" /> class.
        /// </summary>
        /// <param name="catalogView">Specifies the catalog view associated with this job..</param>
        public ExternallyTriggeredSbtParameters(string catalogView = default(string))
        {
            this.CatalogView = catalogView;
            this.CatalogView = catalogView;
        }
        
        /// <summary>
        /// Specifies the catalog view associated with this job.
        /// </summary>
        /// <value>Specifies the catalog view associated with this job.</value>
        [DataMember(Name="catalogView", EmitDefaultValue=true)]
        public string CatalogView { get; set; }

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
            return this.Equals(input as ExternallyTriggeredSbtParameters);
        }

        /// <summary>
        /// Returns true if ExternallyTriggeredSbtParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternallyTriggeredSbtParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternallyTriggeredSbtParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatalogView == input.CatalogView ||
                    (this.CatalogView != null &&
                    this.CatalogView.Equals(input.CatalogView))
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
                if (this.CatalogView != null)
                    hashCode = hashCode * 59 + this.CatalogView.GetHashCode();
                return hashCode;
            }
        }

    }

}

