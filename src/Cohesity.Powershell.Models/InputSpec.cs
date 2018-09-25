// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// InputSpec
    /// </summary>
    [DataContract]
    public partial class InputSpec :  IEquatable<InputSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSpec" /> class.
        /// </summary>
        /// <param name="filesSelector">filesSelector.</param>
        /// <param name="onNfsFiles">Selects whether input is files inside vmdks or files on NFS. One of vm_selector or files_selector will be chosen based on this flag..</param>
        /// <param name="vmSelector">vmSelector.</param>
        public InputSpec(InputSpecInputFilesSelector filesSelector = default(InputSpecInputFilesSelector), bool? onNfsFiles = default(bool?), InputSpecInputVMsSelector vmSelector = default(InputSpecInputVMsSelector))
        {
            this.FilesSelector = filesSelector;
            this.OnNfsFiles = onNfsFiles;
            this.VmSelector = vmSelector;
        }
        
        /// <summary>
        /// Gets or Sets FilesSelector
        /// </summary>
        [DataMember(Name="filesSelector", EmitDefaultValue=false)]
        public InputSpecInputFilesSelector FilesSelector { get; set; }

        /// <summary>
        /// Selects whether input is files inside vmdks or files on NFS. One of vm_selector or files_selector will be chosen based on this flag.
        /// </summary>
        /// <value>Selects whether input is files inside vmdks or files on NFS. One of vm_selector or files_selector will be chosen based on this flag.</value>
        [DataMember(Name="onNfsFiles", EmitDefaultValue=false)]
        public bool? OnNfsFiles { get; set; }

        /// <summary>
        /// Gets or Sets VmSelector
        /// </summary>
        [DataMember(Name="vmSelector", EmitDefaultValue=false)]
        public InputSpecInputVMsSelector VmSelector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as InputSpec);
        }

        /// <summary>
        /// Returns true if InputSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of InputSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilesSelector == input.FilesSelector ||
                    (this.FilesSelector != null &&
                    this.FilesSelector.Equals(input.FilesSelector))
                ) && 
                (
                    this.OnNfsFiles == input.OnNfsFiles ||
                    (this.OnNfsFiles != null &&
                    this.OnNfsFiles.Equals(input.OnNfsFiles))
                ) && 
                (
                    this.VmSelector == input.VmSelector ||
                    (this.VmSelector != null &&
                    this.VmSelector.Equals(input.VmSelector))
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
                if (this.FilesSelector != null)
                    hashCode = hashCode * 59 + this.FilesSelector.GetHashCode();
                if (this.OnNfsFiles != null)
                    hashCode = hashCode * 59 + this.OnNfsFiles.GetHashCode();
                if (this.VmSelector != null)
                    hashCode = hashCode * 59 + this.VmSelector.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

