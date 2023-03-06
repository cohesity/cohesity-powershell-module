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
    /// Message to capture details of a point in time that the DB needs to be restored to.
    /// </summary>
    [DataContract]
    public partial class DeployDBInstancesToRDSParamsPointInTimeRestoreParams :  IEquatable<DeployDBInstancesToRDSParamsPointInTimeRestoreParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployDBInstancesToRDSParamsPointInTimeRestoreParams" /> class.
        /// </summary>
        /// <param name="timestampMsecs">Time in milliseconds since epoch that the DB needs to be restored to..</param>
        public DeployDBInstancesToRDSParamsPointInTimeRestoreParams(long? timestampMsecs = default(long?))
        {
            this.TimestampMsecs = timestampMsecs;
            this.TimestampMsecs = timestampMsecs;
        }
        
        /// <summary>
        /// Time in milliseconds since epoch that the DB needs to be restored to.
        /// </summary>
        /// <value>Time in milliseconds since epoch that the DB needs to be restored to.</value>
        [DataMember(Name="timestampMsecs", EmitDefaultValue=true)]
        public long? TimestampMsecs { get; set; }

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
            return this.Equals(input as DeployDBInstancesToRDSParamsPointInTimeRestoreParams);
        }

        /// <summary>
        /// Returns true if DeployDBInstancesToRDSParamsPointInTimeRestoreParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployDBInstancesToRDSParamsPointInTimeRestoreParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployDBInstancesToRDSParamsPointInTimeRestoreParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestampMsecs == input.TimestampMsecs ||
                    (this.TimestampMsecs != null &&
                    this.TimestampMsecs.Equals(input.TimestampMsecs))
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
                if (this.TimestampMsecs != null)
                    hashCode = hashCode * 59 + this.TimestampMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

