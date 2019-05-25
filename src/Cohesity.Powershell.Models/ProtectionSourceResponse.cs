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
    /// Specifies the information about the individual object from search api response.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceResponse :  IEquatable<ProtectionSourceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceResponse" /> class.
        /// </summary>
        /// <param name="jobs">Specifies the list of Protection Jobs that protect the object..</param>
        /// <param name="logicalSizeInBytes">Specifies the logical size of Protection Source in bytes..</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="protectionSourceUidList">Specifies the list of universal ids of the Protection Source..</param>
        /// <param name="source">source.</param>
        /// <param name="uuid">Specifies the unique id of the Protection Source..</param>
        public ProtectionSourceResponse(List<ProtectionJobSummary> jobs = default(List<ProtectionJobSummary>), long? logicalSizeInBytes = default(long?), ProtectionSource parentSource = default(ProtectionSource), List<ProtectionSourceUid> protectionSourceUidList = default(List<ProtectionSourceUid>), ProtectionSource source = default(ProtectionSource), string uuid = default(string))
        {
            this.Jobs = jobs;
            this.LogicalSizeInBytes = logicalSizeInBytes;
            this.ProtectionSourceUidList = protectionSourceUidList;
            this.Uuid = uuid;
            this.Jobs = jobs;
            this.LogicalSizeInBytes = logicalSizeInBytes;
            this.ParentSource = parentSource;
            this.ProtectionSourceUidList = protectionSourceUidList;
            this.Source = source;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the list of Protection Jobs that protect the object.
        /// </summary>
        /// <value>Specifies the list of Protection Jobs that protect the object.</value>
        [DataMember(Name="jobs", EmitDefaultValue=true)]
        public List<ProtectionJobSummary> Jobs { get; set; }

        /// <summary>
        /// Specifies the logical size of Protection Source in bytes.
        /// </summary>
        /// <value>Specifies the logical size of Protection Source in bytes.</value>
        [DataMember(Name="logicalSizeInBytes", EmitDefaultValue=true)]
        public long? LogicalSizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public ProtectionSource ParentSource { get; set; }

        /// <summary>
        /// Specifies the list of universal ids of the Protection Source.
        /// </summary>
        /// <value>Specifies the list of universal ids of the Protection Source.</value>
        [DataMember(Name="protectionSourceUidList", EmitDefaultValue=true)]
        public List<ProtectionSourceUid> ProtectionSourceUidList { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public ProtectionSource Source { get; set; }

        /// <summary>
        /// Specifies the unique id of the Protection Source.
        /// </summary>
        /// <value>Specifies the unique id of the Protection Source.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectionSourceResponse {\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  LogicalSizeInBytes: ").Append(LogicalSizeInBytes).Append("\n");
            sb.Append("  ParentSource: ").Append(ParentSource).Append("\n");
            sb.Append("  ProtectionSourceUidList: ").Append(ProtectionSourceUidList).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as ProtectionSourceResponse);
        }

        /// <summary>
        /// Returns true if ProtectionSourceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs != null &&
                    input.Jobs != null &&
                    this.Jobs.SequenceEqual(input.Jobs)
                ) && 
                (
                    this.LogicalSizeInBytes == input.LogicalSizeInBytes ||
                    (this.LogicalSizeInBytes != null &&
                    this.LogicalSizeInBytes.Equals(input.LogicalSizeInBytes))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.ProtectionSourceUidList == input.ProtectionSourceUidList ||
                    this.ProtectionSourceUidList != null &&
                    input.ProtectionSourceUidList != null &&
                    this.ProtectionSourceUidList.SequenceEqual(input.ProtectionSourceUidList)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Jobs != null)
                    hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                if (this.LogicalSizeInBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeInBytes.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.ProtectionSourceUidList != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceUidList.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}
