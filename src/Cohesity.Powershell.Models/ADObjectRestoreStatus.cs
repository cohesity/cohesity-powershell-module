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
    /// ADObjectRestoreStatus
    /// </summary>
    [DataContract]
    public partial class ADObjectRestoreStatus :  IEquatable<ADObjectRestoreStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADObjectRestoreStatus" /> class.
        /// </summary>
        /// <param name="destGuid">Destination guid string of the AD object that is newly created on production AD corresponding to &#39;source_guid&#39;. If the object was restored from production AD recycle Bin, this value can be empty or set to same value as &#39;source_guid&#39;. If this value is non-empty and is different from source_guid, implying production AD object is a new object created in production AD as part of restore..</param>
        /// <param name="objectFlags">Object result flags of type ADObjectFlags..</param>
        /// <param name="propertyStatusVec">AD object attribute(property) restore status vector..</param>
        /// <param name="sourceGuid">Source guid of AD object that was restored. This will not be empty. This is populated from the source of request argument..</param>
        /// <param name="status">status.</param>
        /// <param name="timetakenMs">Time taken in milliseconds to restore the individual object or attribute update. If this object restore was part of a batch, it shows the time taken once the operation was dispatched to AD for the object. This time can be useful in answering why some objects took long time to restore. Note that this time is not the elapsed time when the request was made from Magneto..</param>
        public ADObjectRestoreStatus(string destGuid = default(string), int? objectFlags = default(int?), List<ADObjectRestoreStatusADAttributeRestoreStatus> propertyStatusVec = default(List<ADObjectRestoreStatusADAttributeRestoreStatus>), string sourceGuid = default(string), ErrorProto status = default(ErrorProto), int? timetakenMs = default(int?))
        {
            this.DestGuid = destGuid;
            this.ObjectFlags = objectFlags;
            this.PropertyStatusVec = propertyStatusVec;
            this.SourceGuid = sourceGuid;
            this.Status = status;
            this.TimetakenMs = timetakenMs;
        }
        
        /// <summary>
        /// Destination guid string of the AD object that is newly created on production AD corresponding to &#39;source_guid&#39;. If the object was restored from production AD recycle Bin, this value can be empty or set to same value as &#39;source_guid&#39;. If this value is non-empty and is different from source_guid, implying production AD object is a new object created in production AD as part of restore.
        /// </summary>
        /// <value>Destination guid string of the AD object that is newly created on production AD corresponding to &#39;source_guid&#39;. If the object was restored from production AD recycle Bin, this value can be empty or set to same value as &#39;source_guid&#39;. If this value is non-empty and is different from source_guid, implying production AD object is a new object created in production AD as part of restore.</value>
        [DataMember(Name="destGuid", EmitDefaultValue=false)]
        public string DestGuid { get; set; }

        /// <summary>
        /// Object result flags of type ADObjectFlags.
        /// </summary>
        /// <value>Object result flags of type ADObjectFlags.</value>
        [DataMember(Name="objectFlags", EmitDefaultValue=false)]
        public int? ObjectFlags { get; set; }

        /// <summary>
        /// AD object attribute(property) restore status vector.
        /// </summary>
        /// <value>AD object attribute(property) restore status vector.</value>
        [DataMember(Name="propertyStatusVec", EmitDefaultValue=false)]
        public List<ADObjectRestoreStatusADAttributeRestoreStatus> PropertyStatusVec { get; set; }

        /// <summary>
        /// Source guid of AD object that was restored. This will not be empty. This is populated from the source of request argument.
        /// </summary>
        /// <value>Source guid of AD object that was restored. This will not be empty. This is populated from the source of request argument.</value>
        [DataMember(Name="sourceGuid", EmitDefaultValue=false)]
        public string SourceGuid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ErrorProto Status { get; set; }

        /// <summary>
        /// Time taken in milliseconds to restore the individual object or attribute update. If this object restore was part of a batch, it shows the time taken once the operation was dispatched to AD for the object. This time can be useful in answering why some objects took long time to restore. Note that this time is not the elapsed time when the request was made from Magneto.
        /// </summary>
        /// <value>Time taken in milliseconds to restore the individual object or attribute update. If this object restore was part of a batch, it shows the time taken once the operation was dispatched to AD for the object. This time can be useful in answering why some objects took long time to restore. Note that this time is not the elapsed time when the request was made from Magneto.</value>
        [DataMember(Name="timetakenMs", EmitDefaultValue=false)]
        public int? TimetakenMs { get; set; }

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
            return this.Equals(input as ADObjectRestoreStatus);
        }

        /// <summary>
        /// Returns true if ADObjectRestoreStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ADObjectRestoreStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADObjectRestoreStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestGuid == input.DestGuid ||
                    (this.DestGuid != null &&
                    this.DestGuid.Equals(input.DestGuid))
                ) && 
                (
                    this.ObjectFlags == input.ObjectFlags ||
                    (this.ObjectFlags != null &&
                    this.ObjectFlags.Equals(input.ObjectFlags))
                ) && 
                (
                    this.PropertyStatusVec == input.PropertyStatusVec ||
                    this.PropertyStatusVec != null &&
                    this.PropertyStatusVec.Equals(input.PropertyStatusVec)
                ) && 
                (
                    this.SourceGuid == input.SourceGuid ||
                    (this.SourceGuid != null &&
                    this.SourceGuid.Equals(input.SourceGuid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TimetakenMs == input.TimetakenMs ||
                    (this.TimetakenMs != null &&
                    this.TimetakenMs.Equals(input.TimetakenMs))
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
                if (this.DestGuid != null)
                    hashCode = hashCode * 59 + this.DestGuid.GetHashCode();
                if (this.ObjectFlags != null)
                    hashCode = hashCode * 59 + this.ObjectFlags.GetHashCode();
                if (this.PropertyStatusVec != null)
                    hashCode = hashCode * 59 + this.PropertyStatusVec.GetHashCode();
                if (this.SourceGuid != null)
                    hashCode = hashCode * 59 + this.SourceGuid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TimetakenMs != null)
                    hashCode = hashCode * 59 + this.TimetakenMs.GetHashCode();
                return hashCode;
            }
        }

    }

}

