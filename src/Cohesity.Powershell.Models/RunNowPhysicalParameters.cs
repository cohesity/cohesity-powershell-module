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
    /// Specifies optional physical parameters for a specific source id.
    /// </summary>
    [DataContract]
    public partial class RunNowPhysicalParameters :  IEquatable<RunNowPhysicalParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunNowPhysicalParameters" /> class.
        /// </summary>
        /// <param name="metadataFilePath">Specifies metadata file path during run-now requests for physical file based backups for some specific host entity. If specified, it will override any default metadata/directive file path set at the job level for the host. Also note that if the job default does not specify a metadata/directive file path for the host, then specifying this field for that host during run-now request will be rejected..</param>
        public RunNowPhysicalParameters(string metadataFilePath = default(string))
        {
            this.MetadataFilePath = metadataFilePath;
            this.MetadataFilePath = metadataFilePath;
        }
        
        /// <summary>
        /// Specifies metadata file path during run-now requests for physical file based backups for some specific host entity. If specified, it will override any default metadata/directive file path set at the job level for the host. Also note that if the job default does not specify a metadata/directive file path for the host, then specifying this field for that host during run-now request will be rejected.
        /// </summary>
        /// <value>Specifies metadata file path during run-now requests for physical file based backups for some specific host entity. If specified, it will override any default metadata/directive file path set at the job level for the host. Also note that if the job default does not specify a metadata/directive file path for the host, then specifying this field for that host during run-now request will be rejected.</value>
        [DataMember(Name="metadataFilePath", EmitDefaultValue=true)]
        public string MetadataFilePath { get; set; }

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
            return this.Equals(input as RunNowPhysicalParameters);
        }

        /// <summary>
        /// Returns true if RunNowPhysicalParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RunNowPhysicalParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunNowPhysicalParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataFilePath == input.MetadataFilePath ||
                    (this.MetadataFilePath != null &&
                    this.MetadataFilePath.Equals(input.MetadataFilePath))
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
                if (this.MetadataFilePath != null)
                    hashCode = hashCode * 59 + this.MetadataFilePath.GetHashCode();
                return hashCode;
            }
        }

    }

}

