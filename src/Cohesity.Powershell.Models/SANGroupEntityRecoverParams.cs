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
    /// This message contains additional params for restoring from a SAN Group Backup.
    /// </summary>
    [DataContract]
    public partial class SANGroupEntityRecoverParams :  IEquatable<SANGroupEntityRecoverParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SANGroupEntityRecoverParams" /> class.
        /// </summary>
        /// <param name="volumeRecoverParamsVec">Information about all the volumes in a group recover task..</param>
        public SANGroupEntityRecoverParams(List<SANGroupEntityRecoverParamsSANVolumeRecoverParams> volumeRecoverParamsVec = default(List<SANGroupEntityRecoverParamsSANVolumeRecoverParams>))
        {
            this.VolumeRecoverParamsVec = volumeRecoverParamsVec;
            this.VolumeRecoverParamsVec = volumeRecoverParamsVec;
        }
        
        /// <summary>
        /// Information about all the volumes in a group recover task.
        /// </summary>
        /// <value>Information about all the volumes in a group recover task.</value>
        [DataMember(Name="volumeRecoverParamsVec", EmitDefaultValue=true)]
        public List<SANGroupEntityRecoverParamsSANVolumeRecoverParams> VolumeRecoverParamsVec { get; set; }

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
            return this.Equals(input as SANGroupEntityRecoverParams);
        }

        /// <summary>
        /// Returns true if SANGroupEntityRecoverParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SANGroupEntityRecoverParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SANGroupEntityRecoverParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeRecoverParamsVec == input.VolumeRecoverParamsVec ||
                    this.VolumeRecoverParamsVec != null &&
                    input.VolumeRecoverParamsVec != null &&
                    this.VolumeRecoverParamsVec.SequenceEqual(input.VolumeRecoverParamsVec)
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
                if (this.VolumeRecoverParamsVec != null)
                    hashCode = hashCode * 59 + this.VolumeRecoverParamsVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

