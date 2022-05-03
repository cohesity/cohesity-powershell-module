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
    /// Contains any additional hive environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class HiveBackupJobParams :  IEquatable<HiveBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiveBackupJobParams" /> class.
        /// </summary>
        /// <param name="hdfsConnectParams">hdfsConnectParams.</param>
        public HiveBackupJobParams(HdfsConnectParams hdfsConnectParams = default(HdfsConnectParams))
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
            return this.Equals(input as HiveBackupJobParams);
        }

        /// <summary>
        /// Returns true if HiveBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of HiveBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiveBackupJobParams input)
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

