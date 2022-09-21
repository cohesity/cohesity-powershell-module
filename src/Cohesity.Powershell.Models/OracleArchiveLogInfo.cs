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
    /// OracleArchiveLogInfo
    /// </summary>
    [DataContract]
    public partial class OracleArchiveLogInfo :  IEquatable<OracleArchiveLogInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleArchiveLogInfo" /> class.
        /// </summary>
        /// <param name="oracleArchiveLogRangeVec">Specifies the range in either SCN, sequence number or time for which archive logs are to be restored or for which archive logs is to be shown on the slider. In case of restore we only support 1 range i.e vector size will be 1..</param>
        /// <param name="oracleArchiveLogRestoreDest">Destination where we need to restore archive logs. Used only when trigerring archive log restore. This field is left empty while returning ranges to the sliders..</param>
        public OracleArchiveLogInfo(List<OracleArchiveLogInfoOracleArchiveLogRange> oracleArchiveLogRangeVec = default(List<OracleArchiveLogInfoOracleArchiveLogRange>), string oracleArchiveLogRestoreDest = default(string))
        {
            this.OracleArchiveLogRangeVec = oracleArchiveLogRangeVec;
            this.OracleArchiveLogRestoreDest = oracleArchiveLogRestoreDest;
            this.OracleArchiveLogRangeVec = oracleArchiveLogRangeVec;
            this.OracleArchiveLogRestoreDest = oracleArchiveLogRestoreDest;
        }
        
        /// <summary>
        /// Specifies the range in either SCN, sequence number or time for which archive logs are to be restored or for which archive logs is to be shown on the slider. In case of restore we only support 1 range i.e vector size will be 1.
        /// </summary>
        /// <value>Specifies the range in either SCN, sequence number or time for which archive logs are to be restored or for which archive logs is to be shown on the slider. In case of restore we only support 1 range i.e vector size will be 1.</value>
        [DataMember(Name="oracleArchiveLogRangeVec", EmitDefaultValue=true)]
        public List<OracleArchiveLogInfoOracleArchiveLogRange> OracleArchiveLogRangeVec { get; set; }

        /// <summary>
        /// Destination where we need to restore archive logs. Used only when trigerring archive log restore. This field is left empty while returning ranges to the sliders.
        /// </summary>
        /// <value>Destination where we need to restore archive logs. Used only when trigerring archive log restore. This field is left empty while returning ranges to the sliders.</value>
        [DataMember(Name="oracleArchiveLogRestoreDest", EmitDefaultValue=true)]
        public string OracleArchiveLogRestoreDest { get; set; }

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
            return this.Equals(input as OracleArchiveLogInfo);
        }

        /// <summary>
        /// Returns true if OracleArchiveLogInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleArchiveLogInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleArchiveLogInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OracleArchiveLogRangeVec == input.OracleArchiveLogRangeVec ||
                    this.OracleArchiveLogRangeVec != null &&
                    input.OracleArchiveLogRangeVec != null &&
                    this.OracleArchiveLogRangeVec.Equals(input.OracleArchiveLogRangeVec)
                ) && 
                (
                    this.OracleArchiveLogRestoreDest == input.OracleArchiveLogRestoreDest ||
                    (this.OracleArchiveLogRestoreDest != null &&
                    this.OracleArchiveLogRestoreDest.Equals(input.OracleArchiveLogRestoreDest))
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
                if (this.OracleArchiveLogRangeVec != null)
                    hashCode = hashCode * 59 + this.OracleArchiveLogRangeVec.GetHashCode();
                if (this.OracleArchiveLogRestoreDest != null)
                    hashCode = hashCode * 59 + this.OracleArchiveLogRestoreDest.GetHashCode();
                return hashCode;
            }
        }

    }

}

