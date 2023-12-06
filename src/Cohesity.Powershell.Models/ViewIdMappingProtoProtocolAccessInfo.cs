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
    /// ViewIdMappingProtoProtocolAccessInfo
    /// </summary>
    [DataContract]
    public partial class ViewIdMappingProtoProtocolAccessInfo :  IEquatable<ViewIdMappingProtoProtocolAccessInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewIdMappingProtoProtocolAccessInfo" /> class.
        /// </summary>
        /// <param name="iscsiAccess">Access control for iSCSI protocol for this view..</param>
        /// <param name="nfs4Access">Access control for NFSv4.1 protocol for this view. NFSv4.1 will be disabled by default in all configurations..</param>
        /// <param name="nfsAccess">Access control for NFS protocol for this view..</param>
        /// <param name="s3Access">Access control for S3 protocol for this view..</param>
        /// <param name="smbAccess">Access control for SMB protocol for this view..</param>
        /// <param name="swiftAccess">Access control for Swift protocol for this view..</param>
        public ViewIdMappingProtoProtocolAccessInfo(int? iscsiAccess = default(int?), int? nfs4Access = default(int?), int? nfsAccess = default(int?), int? s3Access = default(int?), int? smbAccess = default(int?), int? swiftAccess = default(int?))
        {
            this.IscsiAccess = iscsiAccess;
            this.Nfs4Access = nfs4Access;
            this.NfsAccess = nfsAccess;
            this.S3Access = s3Access;
            this.SmbAccess = smbAccess;
            this.SwiftAccess = swiftAccess;
            this.IscsiAccess = iscsiAccess;
            this.Nfs4Access = nfs4Access;
            this.NfsAccess = nfsAccess;
            this.S3Access = s3Access;
            this.SmbAccess = smbAccess;
            this.SwiftAccess = swiftAccess;
        }
        
        /// <summary>
        /// Access control for iSCSI protocol for this view.
        /// </summary>
        /// <value>Access control for iSCSI protocol for this view.</value>
        [DataMember(Name="iscsiAccess", EmitDefaultValue=true)]
        public int? IscsiAccess { get; set; }

        /// <summary>
        /// Access control for NFSv4.1 protocol for this view. NFSv4.1 will be disabled by default in all configurations.
        /// </summary>
        /// <value>Access control for NFSv4.1 protocol for this view. NFSv4.1 will be disabled by default in all configurations.</value>
        [DataMember(Name="nfs4Access", EmitDefaultValue=true)]
        public int? Nfs4Access { get; set; }

        /// <summary>
        /// Access control for NFS protocol for this view.
        /// </summary>
        /// <value>Access control for NFS protocol for this view.</value>
        [DataMember(Name="nfsAccess", EmitDefaultValue=true)]
        public int? NfsAccess { get; set; }

        /// <summary>
        /// Access control for S3 protocol for this view.
        /// </summary>
        /// <value>Access control for S3 protocol for this view.</value>
        [DataMember(Name="s3Access", EmitDefaultValue=true)]
        public int? S3Access { get; set; }

        /// <summary>
        /// Access control for SMB protocol for this view.
        /// </summary>
        /// <value>Access control for SMB protocol for this view.</value>
        [DataMember(Name="smbAccess", EmitDefaultValue=true)]
        public int? SmbAccess { get; set; }

        /// <summary>
        /// Access control for Swift protocol for this view.
        /// </summary>
        /// <value>Access control for Swift protocol for this view.</value>
        [DataMember(Name="swiftAccess", EmitDefaultValue=true)]
        public int? SwiftAccess { get; set; }

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
            return this.Equals(input as ViewIdMappingProtoProtocolAccessInfo);
        }

        /// <summary>
        /// Returns true if ViewIdMappingProtoProtocolAccessInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewIdMappingProtoProtocolAccessInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewIdMappingProtoProtocolAccessInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IscsiAccess == input.IscsiAccess ||
                    (this.IscsiAccess != null &&
                    this.IscsiAccess.Equals(input.IscsiAccess))
                ) && 
                (
                    this.Nfs4Access == input.Nfs4Access ||
                    (this.Nfs4Access != null &&
                    this.Nfs4Access.Equals(input.Nfs4Access))
                ) && 
                (
                    this.NfsAccess == input.NfsAccess ||
                    (this.NfsAccess != null &&
                    this.NfsAccess.Equals(input.NfsAccess))
                ) && 
                (
                    this.S3Access == input.S3Access ||
                    (this.S3Access != null &&
                    this.S3Access.Equals(input.S3Access))
                ) && 
                (
                    this.SmbAccess == input.SmbAccess ||
                    (this.SmbAccess != null &&
                    this.SmbAccess.Equals(input.SmbAccess))
                ) && 
                (
                    this.SwiftAccess == input.SwiftAccess ||
                    (this.SwiftAccess != null &&
                    this.SwiftAccess.Equals(input.SwiftAccess))
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
                if (this.IscsiAccess != null)
                    hashCode = hashCode * 59 + this.IscsiAccess.GetHashCode();
                if (this.Nfs4Access != null)
                    hashCode = hashCode * 59 + this.Nfs4Access.GetHashCode();
                if (this.NfsAccess != null)
                    hashCode = hashCode * 59 + this.NfsAccess.GetHashCode();
                if (this.S3Access != null)
                    hashCode = hashCode * 59 + this.S3Access.GetHashCode();
                if (this.SmbAccess != null)
                    hashCode = hashCode * 59 + this.SmbAccess.GetHashCode();
                if (this.SwiftAccess != null)
                    hashCode = hashCode * 59 + this.SwiftAccess.GetHashCode();
                return hashCode;
            }
        }

    }

}

