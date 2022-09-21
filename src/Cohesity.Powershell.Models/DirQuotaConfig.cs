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
    /// Specifies the configuration object of a directory quota.
    /// </summary>
    [DataContract]
    public partial class DirQuotaConfig :  IEquatable<DirQuotaConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirQuotaConfig" /> class.
        /// </summary>
        /// <param name="enabled">Specifies whether the directory quota is enabled on the view..</param>
        /// <param name="viewName">Specifies the name of the view..</param>
        public DirQuotaConfig(bool? enabled = default(bool?), string viewName = default(string))
        {
            this.Enabled = enabled;
            this.ViewName = viewName;
            this.Enabled = enabled;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies whether the directory quota is enabled on the view.
        /// </summary>
        /// <value>Specifies whether the directory quota is enabled on the view.</value>
        [DataMember(Name="enabled", EmitDefaultValue=true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies the name of the view.
        /// </summary>
        /// <value>Specifies the name of the view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as DirQuotaConfig);
        }

        /// <summary>
        /// Returns true if DirQuotaConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DirQuotaConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirQuotaConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

