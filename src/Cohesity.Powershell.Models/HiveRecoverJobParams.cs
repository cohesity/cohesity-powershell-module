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
    /// Contains any additional hive environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class HiveRecoverJobParams :  IEquatable<HiveRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiveRecoverJobParams" /> class.
        /// </summary>
        /// <param name="hdfsConnectParams">hdfsConnectParams.</param>
        /// <param name="suffix">A suffix that is to be applied to all recovered entities.</param>
        public HiveRecoverJobParams(HdfsConnectParams hdfsConnectParams = default(HdfsConnectParams), string suffix = default(string))
        {
            this.HdfsConnectParams = hdfsConnectParams;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Gets or Sets HdfsConnectParams
        /// </summary>
        [DataMember(Name="hdfsConnectParams", EmitDefaultValue=false)]
        public HdfsConnectParams HdfsConnectParams { get; set; }

        /// <summary>
        /// A suffix that is to be applied to all recovered entities
        /// </summary>
        /// <value>A suffix that is to be applied to all recovered entities</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

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
            return this.Equals(input as HiveRecoverJobParams);
        }

        /// <summary>
        /// Returns true if HiveRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HiveRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiveRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HdfsConnectParams == input.HdfsConnectParams ||
                    (this.HdfsConnectParams != null &&
                    this.HdfsConnectParams.Equals(input.HdfsConnectParams))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.HdfsConnectParams != null)
                    hashCode = hashCode * 59 + this.HdfsConnectParams.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

