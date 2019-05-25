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
    /// ObjectInformation
    /// </summary>
    [DataContract]
    public partial class ObjectInformation :  IEquatable<ObjectInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectInformation" /> class.
        /// </summary>
        /// <param name="accessibleUsers">Species the list of user who have access to this object..</param>
        /// <param name="auditLogs">Specifies the audit log information..</param>
        /// <param name="copyTaskInfo">Specifies the copy task information..</param>
        /// <param name="isProtected">Specifies the protection status of the object..</param>
        /// <param name="location">Specifies the location of the parent source..</param>
        /// <param name="protectionInfo">Specifies the data locations for the protected objects..</param>
        /// <param name="rootNodeId">Specifies the id of the root node..</param>
        /// <param name="sourceId">Specifies the id of the Protection Source..</param>
        /// <param name="sourceName">Specifies the name of the object..</param>
        public ObjectInformation(List<string> accessibleUsers = default(List<string>), List<ClusterAuditLog> auditLogs = default(List<ClusterAuditLog>), List<GdprCopyTask> copyTaskInfo = default(List<GdprCopyTask>), bool? isProtected = default(bool?), string location = default(string), List<ProtectionInfo> protectionInfo = default(List<ProtectionInfo>), long? rootNodeId = default(long?), long? sourceId = default(long?), string sourceName = default(string))
        {
            this.AccessibleUsers = accessibleUsers;
            this.AuditLogs = auditLogs;
            this.CopyTaskInfo = copyTaskInfo;
            this.IsProtected = isProtected;
            this.Location = location;
            this.ProtectionInfo = protectionInfo;
            this.RootNodeId = rootNodeId;
            this.SourceId = sourceId;
            this.SourceName = sourceName;
            this.AccessibleUsers = accessibleUsers;
            this.AuditLogs = auditLogs;
            this.CopyTaskInfo = copyTaskInfo;
            this.IsProtected = isProtected;
            this.Location = location;
            this.ProtectionInfo = protectionInfo;
            this.RootNodeId = rootNodeId;
            this.SourceId = sourceId;
            this.SourceName = sourceName;
        }
        
        /// <summary>
        /// Species the list of user who have access to this object.
        /// </summary>
        /// <value>Species the list of user who have access to this object.</value>
        [DataMember(Name="accessibleUsers", EmitDefaultValue=true)]
        public List<string> AccessibleUsers { get; set; }

        /// <summary>
        /// Specifies the audit log information.
        /// </summary>
        /// <value>Specifies the audit log information.</value>
        [DataMember(Name="auditLogs", EmitDefaultValue=true)]
        public List<ClusterAuditLog> AuditLogs { get; set; }

        /// <summary>
        /// Specifies the copy task information.
        /// </summary>
        /// <value>Specifies the copy task information.</value>
        [DataMember(Name="copyTaskInfo", EmitDefaultValue=true)]
        public List<GdprCopyTask> CopyTaskInfo { get; set; }

        /// <summary>
        /// Specifies the protection status of the object.
        /// </summary>
        /// <value>Specifies the protection status of the object.</value>
        [DataMember(Name="isProtected", EmitDefaultValue=true)]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Specifies the location of the parent source.
        /// </summary>
        /// <value>Specifies the location of the parent source.</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies the data locations for the protected objects.
        /// </summary>
        /// <value>Specifies the data locations for the protected objects.</value>
        [DataMember(Name="protectionInfo", EmitDefaultValue=true)]
        public List<ProtectionInfo> ProtectionInfo { get; set; }

        /// <summary>
        /// Specifies the id of the root node.
        /// </summary>
        /// <value>Specifies the id of the root node.</value>
        [DataMember(Name="rootNodeId", EmitDefaultValue=true)]
        public long? RootNodeId { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Source.
        /// </summary>
        /// <value>Specifies the id of the Protection Source.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=true)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Specifies the name of the object.
        /// </summary>
        /// <value>Specifies the name of the object.</value>
        [DataMember(Name="sourceName", EmitDefaultValue=true)]
        public string SourceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectInformation {\n");
            sb.Append("  AccessibleUsers: ").Append(AccessibleUsers).Append("\n");
            sb.Append("  AuditLogs: ").Append(AuditLogs).Append("\n");
            sb.Append("  CopyTaskInfo: ").Append(CopyTaskInfo).Append("\n");
            sb.Append("  IsProtected: ").Append(IsProtected).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ProtectionInfo: ").Append(ProtectionInfo).Append("\n");
            sb.Append("  RootNodeId: ").Append(RootNodeId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
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
            return this.Equals(input as ObjectInformation);
        }

        /// <summary>
        /// Returns true if ObjectInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessibleUsers == input.AccessibleUsers ||
                    this.AccessibleUsers != null &&
                    input.AccessibleUsers != null &&
                    this.AccessibleUsers.SequenceEqual(input.AccessibleUsers)
                ) && 
                (
                    this.AuditLogs == input.AuditLogs ||
                    this.AuditLogs != null &&
                    input.AuditLogs != null &&
                    this.AuditLogs.SequenceEqual(input.AuditLogs)
                ) && 
                (
                    this.CopyTaskInfo == input.CopyTaskInfo ||
                    this.CopyTaskInfo != null &&
                    input.CopyTaskInfo != null &&
                    this.CopyTaskInfo.SequenceEqual(input.CopyTaskInfo)
                ) && 
                (
                    this.IsProtected == input.IsProtected ||
                    (this.IsProtected != null &&
                    this.IsProtected.Equals(input.IsProtected))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ProtectionInfo == input.ProtectionInfo ||
                    this.ProtectionInfo != null &&
                    input.ProtectionInfo != null &&
                    this.ProtectionInfo.SequenceEqual(input.ProtectionInfo)
                ) && 
                (
                    this.RootNodeId == input.RootNodeId ||
                    (this.RootNodeId != null &&
                    this.RootNodeId.Equals(input.RootNodeId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
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
                if (this.AccessibleUsers != null)
                    hashCode = hashCode * 59 + this.AccessibleUsers.GetHashCode();
                if (this.AuditLogs != null)
                    hashCode = hashCode * 59 + this.AuditLogs.GetHashCode();
                if (this.CopyTaskInfo != null)
                    hashCode = hashCode * 59 + this.CopyTaskInfo.GetHashCode();
                if (this.IsProtected != null)
                    hashCode = hashCode * 59 + this.IsProtected.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ProtectionInfo != null)
                    hashCode = hashCode * 59 + this.ProtectionInfo.GetHashCode();
                if (this.RootNodeId != null)
                    hashCode = hashCode * 59 + this.RootNodeId.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceName != null)
                    hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                return hashCode;
            }
        }

    }

}
