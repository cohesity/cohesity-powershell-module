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
    /// MirrorParams
    /// </summary>
    [DataContract]
    public partial class MirrorParams :  IEquatable<MirrorParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MirrorParams" /> class.
        /// </summary>
        /// <param name="finalized">finalized.</param>
        /// <param name="paused">Is mirroring paused..</param>
        /// <param name="previousViewName">View to be used as previous view..</param>
        public MirrorParams(bool? finalized = default(bool?), bool? paused = default(bool?), string previousViewName = default(string))
        {
            this.Finalized = finalized;
            this.Paused = paused;
            this.PreviousViewName = previousViewName;
            this.Finalized = finalized;
            this.Paused = paused;
            this.PreviousViewName = previousViewName;
        }
        
        /// <summary>
        /// Gets or Sets Finalized
        /// </summary>
        [DataMember(Name="finalized", EmitDefaultValue=true)]
        public bool? Finalized { get; set; }

        /// <summary>
        /// Is mirroring paused.
        /// </summary>
        /// <value>Is mirroring paused.</value>
        [DataMember(Name="paused", EmitDefaultValue=true)]
        public bool? Paused { get; set; }

        /// <summary>
        /// View to be used as previous view.
        /// </summary>
        /// <value>View to be used as previous view.</value>
        [DataMember(Name="previousViewName", EmitDefaultValue=true)]
        public string PreviousViewName { get; set; }

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
            return this.Equals(input as MirrorParams);
        }

        /// <summary>
        /// Returns true if MirrorParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MirrorParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MirrorParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Finalized == input.Finalized ||
                    (this.Finalized != null &&
                    this.Finalized.Equals(input.Finalized))
                ) && 
                (
                    this.Paused == input.Paused ||
                    (this.Paused != null &&
                    this.Paused.Equals(input.Paused))
                ) && 
                (
                    this.PreviousViewName == input.PreviousViewName ||
                    (this.PreviousViewName != null &&
                    this.PreviousViewName.Equals(input.PreviousViewName))
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
                if (this.Finalized != null)
                    hashCode = hashCode * 59 + this.Finalized.GetHashCode();
                if (this.Paused != null)
                    hashCode = hashCode * 59 + this.Paused.GetHashCode();
                if (this.PreviousViewName != null)
                    hashCode = hashCode * 59 + this.PreviousViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

