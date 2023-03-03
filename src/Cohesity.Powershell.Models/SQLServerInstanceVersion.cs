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
    /// Specifies the Server Instance Version.
    /// </summary>
    [DataContract]
    public partial class SQLServerInstanceVersion :  IEquatable<SQLServerInstanceVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SQLServerInstanceVersion" /> class.
        /// </summary>
        /// <param name="build">Specifies the build..</param>
        /// <param name="majorVersion">Specifies the major version..</param>
        /// <param name="minorVersion">Specifies the minor version..</param>
        /// <param name="revision">Specifies the revision..</param>
        /// <param name="versionString">Specifies the version string..</param>
        public SQLServerInstanceVersion(int? build = default(int?), int? majorVersion = default(int?), int? minorVersion = default(int?), int? revision = default(int?), string versionString = default(string))
        {
            this.Build = build;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
            this.Revision = revision;
            this.VersionString = versionString;
            this.Build = build;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
            this.Revision = revision;
            this.VersionString = versionString;
        }
        
        /// <summary>
        /// Specifies the build.
        /// </summary>
        /// <value>Specifies the build.</value>
        [DataMember(Name="build", EmitDefaultValue=true)]
        public int? Build { get; set; }

        /// <summary>
        /// Specifies the major version.
        /// </summary>
        /// <value>Specifies the major version.</value>
        [DataMember(Name="majorVersion", EmitDefaultValue=true)]
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Specifies the minor version.
        /// </summary>
        /// <value>Specifies the minor version.</value>
        [DataMember(Name="minorVersion", EmitDefaultValue=true)]
        public int? MinorVersion { get; set; }

        /// <summary>
        /// Specifies the revision.
        /// </summary>
        /// <value>Specifies the revision.</value>
        [DataMember(Name="revision", EmitDefaultValue=true)]
        public int? Revision { get; set; }

        /// <summary>
        /// Specifies the version string.
        /// </summary>
        /// <value>Specifies the version string.</value>
        [DataMember(Name="versionString", EmitDefaultValue=true)]
        public string VersionString { get; set; }

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
            return this.Equals(input as SQLServerInstanceVersion);
        }

        /// <summary>
        /// Returns true if SQLServerInstanceVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of SQLServerInstanceVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SQLServerInstanceVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.MajorVersion == input.MajorVersion ||
                    (this.MajorVersion != null &&
                    this.MajorVersion.Equals(input.MajorVersion))
                ) && 
                (
                    this.MinorVersion == input.MinorVersion ||
                    (this.MinorVersion != null &&
                    this.MinorVersion.Equals(input.MinorVersion))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.VersionString == input.VersionString ||
                    (this.VersionString != null &&
                    this.VersionString.Equals(input.VersionString))
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
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.MajorVersion != null)
                    hashCode = hashCode * 59 + this.MajorVersion.GetHashCode();
                if (this.MinorVersion != null)
                    hashCode = hashCode * 59 + this.MinorVersion.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.VersionString != null)
                    hashCode = hashCode * 59 + this.VersionString.GetHashCode();
                return hashCode;
            }
        }

    }

}

