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
    /// Specifies additional special settings for a single Source in a Protection Job. This Source must be a leaf node in the Source tree.
    /// </summary>
    [DataContract]
    public partial class SourceSpecialParameter :  IEquatable<SourceSpecialParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceSpecialParameter" /> class.
        /// </summary>
        /// <param name="adSpecialParameters">adSpecialParameters.</param>
        /// <param name="oracleSpecialParameters">oracleSpecialParameters.</param>
        /// <param name="physicalSpecialParameters">physicalSpecialParameters.</param>
        /// <param name="skipIndexing">Specifies not to index the objects in the Protection Source when backing up..</param>
        /// <param name="sourceId">Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server..</param>
        /// <param name="sqlSpecialParameters">sqlSpecialParameters.</param>
        /// <param name="truncateExchangeLog">If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true.</param>
        /// <param name="vmCredentials">Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment. This field is deprecated. Use the field in VmCredentials inside source specific parameter. deprecated: true.</param>
        /// <param name="vmwareSpecialParameters">vmwareSpecialParameters.</param>
        public SourceSpecialParameter(ApplicationSpecialParameters adSpecialParameters = default(ApplicationSpecialParameters), ApplicationSpecialParameters oracleSpecialParameters = default(ApplicationSpecialParameters), PhysicalSpecialParameters physicalSpecialParameters = default(PhysicalSpecialParameters), bool? skipIndexing = default(bool?), long? sourceId = default(long?), ApplicationSpecialParameters sqlSpecialParameters = default(ApplicationSpecialParameters), bool? truncateExchangeLog = default(bool?), Credentials vmCredentials = default(Credentials), VmwareSpecialParameters vmwareSpecialParameters = default(VmwareSpecialParameters))
        {
            this.SkipIndexing = skipIndexing;
            this.SourceId = sourceId;
            this.TruncateExchangeLog = truncateExchangeLog;
            this.VmCredentials = vmCredentials;
            this.AdSpecialParameters = adSpecialParameters;
            this.OracleSpecialParameters = oracleSpecialParameters;
            this.PhysicalSpecialParameters = physicalSpecialParameters;
            this.SkipIndexing = skipIndexing;
            this.SourceId = sourceId;
            this.SqlSpecialParameters = sqlSpecialParameters;
            this.TruncateExchangeLog = truncateExchangeLog;
            this.VmCredentials = vmCredentials;
            this.VmwareSpecialParameters = vmwareSpecialParameters;
        }
        
        /// <summary>
        /// Gets or Sets AdSpecialParameters
        /// </summary>
        [DataMember(Name="adSpecialParameters", EmitDefaultValue=false)]
        public ApplicationSpecialParameters AdSpecialParameters { get; set; }

        /// <summary>
        /// Gets or Sets OracleSpecialParameters
        /// </summary>
        [DataMember(Name="oracleSpecialParameters", EmitDefaultValue=false)]
        public ApplicationSpecialParameters OracleSpecialParameters { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalSpecialParameters
        /// </summary>
        [DataMember(Name="physicalSpecialParameters", EmitDefaultValue=false)]
        public PhysicalSpecialParameters PhysicalSpecialParameters { get; set; }

        /// <summary>
        /// Specifies not to index the objects in the Protection Source when backing up.
        /// </summary>
        /// <value>Specifies not to index the objects in the Protection Source when backing up.</value>
        [DataMember(Name="skipIndexing", EmitDefaultValue=true)]
        public bool? SkipIndexing { get; set; }

        /// <summary>
        /// Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server.
        /// </summary>
        /// <value>Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Gets or Sets SqlSpecialParameters
        /// </summary>
        [DataMember(Name="sqlSpecialParameters", EmitDefaultValue=false)]
        public ApplicationSpecialParameters SqlSpecialParameters { get; set; }

        /// <summary>
        /// If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true
        /// </summary>
        /// <value>If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true</value>
        [DataMember(Name="truncateExchangeLog", EmitDefaultValue=true)]
        public bool? TruncateExchangeLog { get; set; }

        /// <summary>
        /// Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment. This field is deprecated. Use the field in VmCredentials inside source specific parameter. deprecated: true
        /// </summary>
        /// <value>Specifies the administrator credentials to log in to the guest Windows system of a VM that hosts the Microsoft Exchange Server. If truncateExchangeLog is set to true and the specified source is a VM, administrator credentials to log in to the guest Windows system of the VM must be provided to truncate the logs. This field is only applicable to Sources in the kVMware environment. This field is deprecated. Use the field in VmCredentials inside source specific parameter. deprecated: true</value>
        [DataMember(Name="vmCredentials", EmitDefaultValue=true)]
        public Credentials VmCredentials { get; set; }

        /// <summary>
        /// Gets or Sets VmwareSpecialParameters
        /// </summary>
        [DataMember(Name="vmwareSpecialParameters", EmitDefaultValue=false)]
        public VmwareSpecialParameters VmwareSpecialParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceSpecialParameter {\n");
            sb.Append("  AdSpecialParameters: ").Append(AdSpecialParameters).Append("\n");
            sb.Append("  OracleSpecialParameters: ").Append(OracleSpecialParameters).Append("\n");
            sb.Append("  PhysicalSpecialParameters: ").Append(PhysicalSpecialParameters).Append("\n");
            sb.Append("  SkipIndexing: ").Append(SkipIndexing).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SqlSpecialParameters: ").Append(SqlSpecialParameters).Append("\n");
            sb.Append("  TruncateExchangeLog: ").Append(TruncateExchangeLog).Append("\n");
            sb.Append("  VmCredentials: ").Append(VmCredentials).Append("\n");
            sb.Append("  VmwareSpecialParameters: ").Append(VmwareSpecialParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                    this.AdSpecialParameters == input.AdSpecialParameters ||
                    (this.AdSpecialParameters != null &&
                    this.AdSpecialParameters.Equals(input.AdSpecialParameters))
                ) && 
                (
                    this.OracleSpecialParameters == input.OracleSpecialParameters ||
                    (this.OracleSpecialParameters != null &&
                    this.OracleSpecialParameters.Equals(input.OracleSpecialParameters))
                ) && 
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
                if (this.AdSpecialParameters != null)
                    hashCode = hashCode * 59 + this.AdSpecialParameters.GetHashCode();
                if (this.OracleSpecialParameters != null)
                    hashCode = hashCode * 59 + this.OracleSpecialParameters.GetHashCode();
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
