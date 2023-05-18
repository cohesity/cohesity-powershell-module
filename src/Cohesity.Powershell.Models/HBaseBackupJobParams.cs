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
    /// Contains any additional hbase environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class HBaseBackupJobParams :  IEquatable<HBaseBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HBaseBackupJobParams" /> class.
        /// </summary>
        /// <param name="hdfsConnectParams">hdfsConnectParams.</param>
        public HBaseBackupJobParams(HdfsConnectParams hdfsConnectParams = default(HdfsConnectParams))
        {
            this.HdfsConnectParams = hdfsConnectParams;
        }
        
        /// <summary>
        /// Gets or Sets HdfsConnectParams
        /// </summary>
        [DataMember(Name="hdfsConnectParams", EmitDefaultValue=false)]
        public HdfsConnectParams HdfsConnectParams { get; set; }

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
            return this.Equals(input as HBaseBackupJobParams);
        }

        /// <summary>
        /// Returns true if HBaseBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HBaseBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HBaseBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HdfsConnectParams == input.HdfsConnectParams ||
                    (this.HdfsConnectParams != null &&
                    this.HdfsConnectParams.Equals(input.HdfsConnectParams))
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
                return hashCode;
            }
        }

    }

}

