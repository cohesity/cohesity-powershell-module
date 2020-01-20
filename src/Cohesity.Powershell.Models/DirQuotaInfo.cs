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
    /// Specifies the configuration and policy details for directory quota in a view.
    /// </summary>
    [DataContract]
    public partial class DirQuotaInfo :  IEquatable<DirQuotaInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirQuotaInfo" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="quotas">Specifies the list of directory quota policies applied on the view..</param>
        public DirQuotaInfo(DirQuotaConfig config = default(DirQuotaConfig), List<DirQuotaPolicy> quotas = default(List<DirQuotaPolicy>))
        {
            this.Quotas = quotas;
            this.Config = config;
            this.Quotas = quotas;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public DirQuotaConfig Config { get; set; }

        /// <summary>
        /// Specifies the list of directory quota policies applied on the view.
        /// </summary>
        /// <value>Specifies the list of directory quota policies applied on the view.</value>
        [DataMember(Name="quotas", EmitDefaultValue=true)]
        public List<DirQuotaPolicy> Quotas { get; set; }

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
            return this.Equals(input as DirQuotaInfo);
        }

        /// <summary>
        /// Returns true if DirQuotaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DirQuotaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirQuotaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Quotas == input.Quotas ||
                    this.Quotas != null &&
                    input.Quotas != null &&
                    this.Quotas.SequenceEqual(input.Quotas)
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Quotas != null)
                    hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                return hashCode;
            }
        }

    }

}

