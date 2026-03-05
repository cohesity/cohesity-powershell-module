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
    /// TieringReportsInfo
    /// </summary>
    [DataContract]
    public partial class TieringReportsInfo :  IEquatable<TieringReportsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TieringReportsInfo" /> class.
        /// </summary>
        /// <param name="reportName">Relative path to tiering report..</param>
        /// <param name="reportsDirPath">Path to the directory where tiering reports are stored..</param>
        public TieringReportsInfo(string reportName = default(string), string reportsDirPath = default(string))
        {
            this.ReportName = reportName;
            this.ReportsDirPath = reportsDirPath;
            this.ReportName = reportName;
            this.ReportsDirPath = reportsDirPath;
        }
        
        /// <summary>
        /// Relative path to tiering report.
        /// </summary>
        /// <value>Relative path to tiering report.</value>
        [DataMember(Name="reportName", EmitDefaultValue=true)]
        public string ReportName { get; set; }

        /// <summary>
        /// Path to the directory where tiering reports are stored.
        /// </summary>
        /// <value>Path to the directory where tiering reports are stored.</value>
        [DataMember(Name="reportsDirPath", EmitDefaultValue=true)]
        public string ReportsDirPath { get; set; }

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
            return this.Equals(input as TieringReportsInfo);
        }

        /// <summary>
        /// Returns true if TieringReportsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TieringReportsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TieringReportsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ReportsDirPath == input.ReportsDirPath ||
                    (this.ReportsDirPath != null &&
                    this.ReportsDirPath.Equals(input.ReportsDirPath))
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
                if (this.ReportName != null)
                    hashCode = hashCode * 59 + this.ReportName.GetHashCode();
                if (this.ReportsDirPath != null)
                    hashCode = hashCode * 59 + this.ReportsDirPath.GetHashCode();
                return hashCode;
            }
        }

    }

}

