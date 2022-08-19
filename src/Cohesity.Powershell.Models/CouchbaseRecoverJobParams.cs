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
    /// Contains any additional couchbase environment specific params for the recover job.
    /// </summary>
    [DataContract]
    public partial class CouchbaseRecoverJobParams :  IEquatable<CouchbaseRecoverJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouchbaseRecoverJobParams" /> class.
        /// </summary>
        /// <param name="appendDocuments">Whether to append documents into the bucket at the destination.</param>
        /// <param name="ddlOnlyRecovery">Whether to recover only the bucket configuration.</param>
        /// <param name="documentsFilterType">Specify the document type recovery option..</param>
        /// <param name="filterExpression">A filter expression to match Documents content to be restored..</param>
        /// <param name="idRegex">A regular expression to match Documents ID&#39;s to be restored..</param>
        /// <param name="overwriteUsers">Whether to replace existing users with users from the bucket.</param>
        /// <param name="suffix">A suffix that is to be applied to all recovered entities.</param>
        public CouchbaseRecoverJobParams(bool? appendDocuments = default(bool?), bool? ddlOnlyRecovery = default(bool?), int? documentsFilterType = default(int?), string filterExpression = default(string), string idRegex = default(string), bool? overwriteUsers = default(bool?), string suffix = default(string))
        {
            this.AppendDocuments = appendDocuments;
            this.DdlOnlyRecovery = ddlOnlyRecovery;
            this.DocumentsFilterType = documentsFilterType;
            this.FilterExpression = filterExpression;
            this.IdRegex = idRegex;
            this.OverwriteUsers = overwriteUsers;
            this.Suffix = suffix;
            this.AppendDocuments = appendDocuments;
            this.DdlOnlyRecovery = ddlOnlyRecovery;
            this.DocumentsFilterType = documentsFilterType;
            this.FilterExpression = filterExpression;
            this.IdRegex = idRegex;
            this.OverwriteUsers = overwriteUsers;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// Whether to append documents into the bucket at the destination
        /// </summary>
        /// <value>Whether to append documents into the bucket at the destination</value>
        [DataMember(Name="appendDocuments", EmitDefaultValue=true)]
        public bool? AppendDocuments { get; set; }

        /// <summary>
        /// Whether to recover only the bucket configuration
        /// </summary>
        /// <value>Whether to recover only the bucket configuration</value>
        [DataMember(Name="ddlOnlyRecovery", EmitDefaultValue=true)]
        public bool? DdlOnlyRecovery { get; set; }

        /// <summary>
        /// Specify the document type recovery option.
        /// </summary>
        /// <value>Specify the document type recovery option.</value>
        [DataMember(Name="documentsFilterType", EmitDefaultValue=true)]
        public int? DocumentsFilterType { get; set; }

        /// <summary>
        /// A filter expression to match Documents content to be restored.
        /// </summary>
        /// <value>A filter expression to match Documents content to be restored.</value>
        [DataMember(Name="filterExpression", EmitDefaultValue=true)]
        public string FilterExpression { get; set; }

        /// <summary>
        /// A regular expression to match Documents ID&#39;s to be restored.
        /// </summary>
        /// <value>A regular expression to match Documents ID&#39;s to be restored.</value>
        [DataMember(Name="idRegex", EmitDefaultValue=true)]
        public string IdRegex { get; set; }

        /// <summary>
        /// Whether to replace existing users with users from the bucket
        /// </summary>
        /// <value>Whether to replace existing users with users from the bucket</value>
        [DataMember(Name="overwriteUsers", EmitDefaultValue=true)]
        public bool? OverwriteUsers { get; set; }

        /// <summary>
        /// A suffix that is to be applied to all recovered entities
        /// </summary>
        /// <value>A suffix that is to be applied to all recovered entities</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

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
            return this.Equals(input as CouchbaseRecoverJobParams);
        }

        /// <summary>
        /// Returns true if CouchbaseRecoverJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CouchbaseRecoverJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouchbaseRecoverJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppendDocuments == input.AppendDocuments ||
                    (this.AppendDocuments != null &&
                    this.AppendDocuments.Equals(input.AppendDocuments))
                ) && 
                (
                    this.DdlOnlyRecovery == input.DdlOnlyRecovery ||
                    (this.DdlOnlyRecovery != null &&
                    this.DdlOnlyRecovery.Equals(input.DdlOnlyRecovery))
                ) && 
                (
                    this.DocumentsFilterType == input.DocumentsFilterType ||
                    (this.DocumentsFilterType != null &&
                    this.DocumentsFilterType.Equals(input.DocumentsFilterType))
                ) && 
                (
                    this.FilterExpression == input.FilterExpression ||
                    (this.FilterExpression != null &&
                    this.FilterExpression.Equals(input.FilterExpression))
                ) && 
                (
                    this.IdRegex == input.IdRegex ||
                    (this.IdRegex != null &&
                    this.IdRegex.Equals(input.IdRegex))
                ) && 
                (
                    this.OverwriteUsers == input.OverwriteUsers ||
                    (this.OverwriteUsers != null &&
                    this.OverwriteUsers.Equals(input.OverwriteUsers))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.AppendDocuments != null)
                    hashCode = hashCode * 59 + this.AppendDocuments.GetHashCode();
                if (this.DdlOnlyRecovery != null)
                    hashCode = hashCode * 59 + this.DdlOnlyRecovery.GetHashCode();
                if (this.DocumentsFilterType != null)
                    hashCode = hashCode * 59 + this.DocumentsFilterType.GetHashCode();
                if (this.FilterExpression != null)
                    hashCode = hashCode * 59 + this.FilterExpression.GetHashCode();
                if (this.IdRegex != null)
                    hashCode = hashCode * 59 + this.IdRegex.GetHashCode();
                if (this.OverwriteUsers != null)
                    hashCode = hashCode * 59 + this.OverwriteUsers.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

