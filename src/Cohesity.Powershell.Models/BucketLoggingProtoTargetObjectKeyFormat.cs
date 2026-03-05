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
    /// This field stores the structure for bucket logging config&#39;s TargetObjectKeyFormat. This is used to store information on how the audit log object names should be created.
    /// </summary>
    [DataContract]
    public partial class BucketLoggingProtoTargetObjectKeyFormat :  IEquatable<BucketLoggingProtoTargetObjectKeyFormat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketLoggingProtoTargetObjectKeyFormat" /> class.
        /// </summary>
        /// <param name="partitionedPrefix">Specifies logs keys to be delivered in partitioned format TargetPrefix/YYYY/MM/DD/YYYY-mm-DD-HH-MM-SS-UniqueString.</param>
        /// <param name="simplePrefix">Specified to use simple format for log object keys TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString.</param>
        public BucketLoggingProtoTargetObjectKeyFormat(int? partitionedPrefix = default(int?), bool? simplePrefix = default(bool?))
        {
            this.PartitionedPrefix = partitionedPrefix;
            this.SimplePrefix = simplePrefix;
            this.PartitionedPrefix = partitionedPrefix;
            this.SimplePrefix = simplePrefix;
        }
        
        /// <summary>
        /// Specifies logs keys to be delivered in partitioned format TargetPrefix/YYYY/MM/DD/YYYY-mm-DD-HH-MM-SS-UniqueString
        /// </summary>
        /// <value>Specifies logs keys to be delivered in partitioned format TargetPrefix/YYYY/MM/DD/YYYY-mm-DD-HH-MM-SS-UniqueString</value>
        [DataMember(Name="partitionedPrefix", EmitDefaultValue=true)]
        public int? PartitionedPrefix { get; set; }

        /// <summary>
        /// Specified to use simple format for log object keys TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString
        /// </summary>
        /// <value>Specified to use simple format for log object keys TargetPrefixYYYY-mm-DD-HH-MM-SS-UniqueString</value>
        [DataMember(Name="simplePrefix", EmitDefaultValue=true)]
        public bool? SimplePrefix { get; set; }

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
            return this.Equals(input as BucketLoggingProtoTargetObjectKeyFormat);
        }

        /// <summary>
        /// Returns true if BucketLoggingProtoTargetObjectKeyFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketLoggingProtoTargetObjectKeyFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketLoggingProtoTargetObjectKeyFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartitionedPrefix == input.PartitionedPrefix ||
                    (this.PartitionedPrefix != null &&
                    this.PartitionedPrefix.Equals(input.PartitionedPrefix))
                ) && 
                (
                    this.SimplePrefix == input.SimplePrefix ||
                    (this.SimplePrefix != null &&
                    this.SimplePrefix.Equals(input.SimplePrefix))
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
                if (this.PartitionedPrefix != null)
                    hashCode = hashCode * 59 + this.PartitionedPrefix.GetHashCode();
                if (this.SimplePrefix != null)
                    hashCode = hashCode * 59 + this.SimplePrefix.GetHashCode();
                return hashCode;
            }
        }

    }

}

