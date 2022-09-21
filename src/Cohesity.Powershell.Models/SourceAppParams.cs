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
    /// This message contains params specific to application running on the source such as a VM or a physical host.
    /// </summary>
    [DataContract]
    public partial class SourceAppParams :  IEquatable<SourceAppParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAppParams" /> class.
        /// </summary>
        /// <param name="isVssCopyOnly">If the backup is a VSS full backup with the copy-only option specified..</param>
        /// <param name="msExchangeParams">msExchangeParams.</param>
        public SourceAppParams(bool? isVssCopyOnly = default(bool?), MSExchangeParams msExchangeParams = default(MSExchangeParams))
        {
            this.IsVssCopyOnly = isVssCopyOnly;
            this.MsExchangeParams = msExchangeParams;
        }
        
        /// <summary>
        /// If the backup is a VSS full backup with the copy-only option specified.
        /// </summary>
        /// <value>If the backup is a VSS full backup with the copy-only option specified.</value>
        [DataMember(Name="isVssCopyOnly", EmitDefaultValue=true)]
        public bool? IsVssCopyOnly { get; set; }

        /// <summary>
        /// Gets or Sets MsExchangeParams
        /// </summary>
        [DataMember(Name="msExchangeParams", EmitDefaultValue=false)]
        public MSExchangeParams MsExchangeParams { get; set; }

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
            return this.Equals(input as SourceAppParams);
        }

        /// <summary>
        /// Returns true if SourceAppParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceAppParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceAppParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsVssCopyOnly == input.IsVssCopyOnly ||
                    (this.IsVssCopyOnly != null &&
                    this.IsVssCopyOnly.Equals(input.IsVssCopyOnly))
                ) && 
                (
                    this.MsExchangeParams == input.MsExchangeParams ||
                    (this.MsExchangeParams != null &&
                    this.MsExchangeParams.Equals(input.MsExchangeParams))
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
                if (this.IsVssCopyOnly != null)
                    hashCode = hashCode * 59 + this.IsVssCopyOnly.GetHashCode();
                if (this.MsExchangeParams != null)
                    hashCode = hashCode * 59 + this.MsExchangeParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

