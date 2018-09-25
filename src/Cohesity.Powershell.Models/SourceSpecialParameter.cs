// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies additional special settings for a single Source in a Protection Job. This Source must be a leaf node in the Source tree.
    /// </summary>
    [DataContract]
    public partial class SourceSpecialParameter :  IEquatable<SourceSpecialParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceSpecialParameter" /> class.
        /// </summary>
        /// <param name="physicalSpecialParameters">Specifies additional special parameters that are applicable only to Sources of &#39;kHost&#39; type in a kPhysical environment..</param>
        /// <param name="skipIndexing">Specifies not to index the objects in the Protection Source when backing up..</param>
        /// <param name="sourceId">Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server..</param>
        /// <param name="sqlSpecialParameters">Specifies additional special parameters that are applicable only to Protection Sources of &#39;kSQL&#39; type..</param>
        /// <param name="truncateExchangeLog">If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true.</param>
        /// <param name="vmCredentials">vmCredentials.</param>
        /// <param name="vmwareSpecialParameters">Specifies additional special parameters that are applicable only to Protection Sources of &#39;kVMware&#39; type..</param>
        public SourceSpecialParameter(PhysicalSpecialParameters physicalSpecialParameters = default(PhysicalSpecialParameters), bool? skipIndexing = default(bool?), long? sourceId = default(long?), SqlSpecialParameters sqlSpecialParameters = default(SqlSpecialParameters), bool? truncateExchangeLog = default(bool?), VMCredentials_ vmCredentials = default(VMCredentials_), VmwareSpecialParameters vmwareSpecialParameters = default(VmwareSpecialParameters))
        {
            this.PhysicalSpecialParameters = physicalSpecialParameters;
            this.SkipIndexing = skipIndexing;
            this.SourceId = sourceId;
            this.SqlSpecialParameters = sqlSpecialParameters;
            this.TruncateExchangeLog = truncateExchangeLog;
            this.VmCredentials = vmCredentials;
            this.VmwareSpecialParameters = vmwareSpecialParameters;
        }
        
        /// <summary>
        /// Specifies additional special parameters that are applicable only to Sources of &#39;kHost&#39; type in a kPhysical environment.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Sources of &#39;kHost&#39; type in a kPhysical environment.</value>
        [DataMember(Name="physicalSpecialParameters", EmitDefaultValue=false)]
        public PhysicalSpecialParameters PhysicalSpecialParameters { get; set; }

        /// <summary>
        /// Specifies not to index the objects in the Protection Source when backing up.
        /// </summary>
        /// <value>Specifies not to index the objects in the Protection Source when backing up.</value>
        [DataMember(Name="skipIndexing", EmitDefaultValue=false)]
        public bool? SkipIndexing { get; set; }

        /// <summary>
        /// Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server.
        /// </summary>
        /// <value>Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Protection Sources of &#39;kSQL&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Protection Sources of &#39;kSQL&#39; type.</value>
        [DataMember(Name="sqlSpecialParameters", EmitDefaultValue=false)]
        public SqlSpecialParameters SqlSpecialParameters { get; set; }

        /// <summary>
        /// If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true
        /// </summary>
        /// <value>If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true</value>
        [DataMember(Name="truncateExchangeLog", EmitDefaultValue=false)]
        public bool? TruncateExchangeLog { get; set; }

        /// <summary>
        /// Gets or Sets VmCredentials
        /// </summary>
        [DataMember(Name="vmCredentials", EmitDefaultValue=false)]
        public VMCredentials_ VmCredentials { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Protection Sources of &#39;kVMware&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Protection Sources of &#39;kVMware&#39; type.</value>
        [DataMember(Name="vmwareSpecialParameters", EmitDefaultValue=false)]
        public VmwareSpecialParameters VmwareSpecialParameters { get; set; }

        ///// <summary>
        ///// Returns the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class SourceSpecialParameter {\n");
        //    sb.Append("  PhysicalSpecialParameters: ").Append(PhysicalSpecialParameters).Append("\n");
        //    sb.Append("  SkipIndexing: ").Append(SkipIndexing).Append("\n");
        //    sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        //    sb.Append("  SqlSpecialParameters: ").Append(SqlSpecialParameters).Append("\n");
        //    sb.Append("  TruncateExchangeLog: ").Append(TruncateExchangeLog).Append("\n");
        //    sb.Append("  VmCredentials: ").Append(VmCredentials).Append("\n");
        //    sb.Append("  VmwareSpecialParameters: ").Append(VmwareSpecialParameters).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}
        public override string ToString()
        {
            return ToJson();
        }

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
            return this.Equals(input as SourceSpecialParameter);
        }

        /// <summary>
        /// Returns true if SourceSpecialParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceSpecialParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceSpecialParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhysicalSpecialParameters == input.PhysicalSpecialParameters ||
                    (this.PhysicalSpecialParameters != null &&
                    this.PhysicalSpecialParameters.Equals(input.PhysicalSpecialParameters))
                ) && 
                (
                    this.SkipIndexing == input.SkipIndexing ||
                    (this.SkipIndexing != null &&
                    this.SkipIndexing.Equals(input.SkipIndexing))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SqlSpecialParameters == input.SqlSpecialParameters ||
                    (this.SqlSpecialParameters != null &&
                    this.SqlSpecialParameters.Equals(input.SqlSpecialParameters))
                ) && 
                (
                    this.TruncateExchangeLog == input.TruncateExchangeLog ||
                    (this.TruncateExchangeLog != null &&
                    this.TruncateExchangeLog.Equals(input.TruncateExchangeLog))
                ) && 
                (
                    this.VmCredentials == input.VmCredentials ||
                    (this.VmCredentials != null &&
                    this.VmCredentials.Equals(input.VmCredentials))
                ) && 
                (
                    this.VmwareSpecialParameters == input.VmwareSpecialParameters ||
                    (this.VmwareSpecialParameters != null &&
                    this.VmwareSpecialParameters.Equals(input.VmwareSpecialParameters))
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
                if (this.PhysicalSpecialParameters != null)
                    hashCode = hashCode * 59 + this.PhysicalSpecialParameters.GetHashCode();
                if (this.SkipIndexing != null)
                    hashCode = hashCode * 59 + this.SkipIndexing.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SqlSpecialParameters != null)
                    hashCode = hashCode * 59 + this.SqlSpecialParameters.GetHashCode();
                if (this.TruncateExchangeLog != null)
                    hashCode = hashCode * 59 + this.TruncateExchangeLog.GetHashCode();
                if (this.VmCredentials != null)
                    hashCode = hashCode * 59 + this.VmCredentials.GetHashCode();
                if (this.VmwareSpecialParameters != null)
                    hashCode = hashCode * 59 + this.VmwareSpecialParameters.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

