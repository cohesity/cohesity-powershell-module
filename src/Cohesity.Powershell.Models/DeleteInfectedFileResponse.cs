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
    /// DeleteInfectedFileResponse
    /// </summary>
    [DataContract]
    public partial class DeleteInfectedFileResponse :  IEquatable<DeleteInfectedFileResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInfectedFileResponse" /> class.
        /// </summary>
        /// <param name="deleteFailedInfectedFiles">Specifies the failed delete infected files..</param>
        /// <param name="deleteSucceededInfectedFiles">Specifies the successfully deleted infected files..</param>
        public DeleteInfectedFileResponse(List<InfectedFileId> deleteFailedInfectedFiles = default(List<InfectedFileId>), List<InfectedFileId> deleteSucceededInfectedFiles = default(List<InfectedFileId>))
        {
            this.DeleteFailedInfectedFiles = deleteFailedInfectedFiles;
            this.DeleteSucceededInfectedFiles = deleteSucceededInfectedFiles;
        }
        
        /// <summary>
        /// Specifies the failed delete infected files.
        /// </summary>
        /// <value>Specifies the failed delete infected files.</value>
        [DataMember(Name="deleteFailedInfectedFiles", EmitDefaultValue=false)]
        public List<InfectedFileId> DeleteFailedInfectedFiles { get; set; }

        /// <summary>
        /// Specifies the successfully deleted infected files.
        /// </summary>
        /// <value>Specifies the successfully deleted infected files.</value>
        [DataMember(Name="deleteSucceededInfectedFiles", EmitDefaultValue=false)]
        public List<InfectedFileId> DeleteSucceededInfectedFiles { get; set; }

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
            return this.Equals(input as DeleteInfectedFileResponse);
        }

        /// <summary>
        /// Returns true if DeleteInfectedFileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInfectedFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInfectedFileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteFailedInfectedFiles == input.DeleteFailedInfectedFiles ||
                    this.DeleteFailedInfectedFiles != null &&
                    this.DeleteFailedInfectedFiles.Equals(input.DeleteFailedInfectedFiles)
                ) && 
                (
                    this.DeleteSucceededInfectedFiles == input.DeleteSucceededInfectedFiles ||
                    this.DeleteSucceededInfectedFiles != null &&
                    this.DeleteSucceededInfectedFiles.Equals(input.DeleteSucceededInfectedFiles)
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
                if (this.DeleteFailedInfectedFiles != null)
                    hashCode = hashCode * 59 + this.DeleteFailedInfectedFiles.GetHashCode();
                if (this.DeleteSucceededInfectedFiles != null)
                    hashCode = hashCode * 59 + this.DeleteSucceededInfectedFiles.GetHashCode();
                return hashCode;
            }
        }

    }

}

