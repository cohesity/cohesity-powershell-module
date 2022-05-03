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
    /// UpdateInfectedFileResponse
    /// </summary>
    [DataContract]
    public partial class UpdateInfectedFileResponse :  IEquatable<UpdateInfectedFileResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInfectedFileResponse" /> class.
        /// </summary>
        /// <param name="updateFailedInfectedFiles">Specifies the failed update infected files..</param>
        /// <param name="updateSucceededInfectedFiles">Specifies the successfully updated infected files..</param>
        public UpdateInfectedFileResponse(List<InfectedFileId> updateFailedInfectedFiles = default(List<InfectedFileId>), List<InfectedFileId> updateSucceededInfectedFiles = default(List<InfectedFileId>))
        {
            this.UpdateFailedInfectedFiles = updateFailedInfectedFiles;
            this.UpdateSucceededInfectedFiles = updateSucceededInfectedFiles;
        }
        
        /// <summary>
        /// Specifies the failed update infected files.
        /// </summary>
        /// <value>Specifies the failed update infected files.</value>
        [DataMember(Name="updateFailedInfectedFiles", EmitDefaultValue=false)]
        public List<InfectedFileId> UpdateFailedInfectedFiles { get; set; }

        /// <summary>
        /// Specifies the successfully updated infected files.
        /// </summary>
        /// <value>Specifies the successfully updated infected files.</value>
        [DataMember(Name="updateSucceededInfectedFiles", EmitDefaultValue=false)]
        public List<InfectedFileId> UpdateSucceededInfectedFiles { get; set; }

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
            return this.Equals(input as UpdateInfectedFileResponse);
        }

        /// <summary>
        /// Returns true if UpdateInfectedFileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInfectedFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInfectedFileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdateFailedInfectedFiles == input.UpdateFailedInfectedFiles ||
                    this.UpdateFailedInfectedFiles != null &&
                    this.UpdateFailedInfectedFiles.Equals(input.UpdateFailedInfectedFiles)
                ) && 
                (
                    this.UpdateSucceededInfectedFiles == input.UpdateSucceededInfectedFiles ||
                    this.UpdateSucceededInfectedFiles != null &&
                    this.UpdateSucceededInfectedFiles.Equals(input.UpdateSucceededInfectedFiles)
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
                if (this.UpdateFailedInfectedFiles != null)
                    hashCode = hashCode * 59 + this.UpdateFailedInfectedFiles.GetHashCode();
                if (this.UpdateSucceededInfectedFiles != null)
                    hashCode = hashCode * 59 + this.UpdateSucceededInfectedFiles.GetHashCode();
                return hashCode;
            }
        }

    }

}

