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
    /// Specifies PST conversion details.
    /// </summary>
    [DataContract]
    public partial class PstParameters :  IEquatable<PstParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PstParameters" /> class.
        /// </summary>
        /// <param name="createPst">Specifies if create a PST or MSG for input items. For 6.6 we always set this to true..</param>
        /// <param name="pstPassword">Specifies Password to be set for generated PSTs..</param>
        /// <param name="pstSizeThreshold">Specifies PST size threshold in bytes..</param>
        public PstParameters(bool? createPst = default(bool?), string pstPassword = default(string), long? pstSizeThreshold = default(long?))
        {
            this.CreatePst = createPst;
            this.PstPassword = pstPassword;
            this.PstSizeThreshold = pstSizeThreshold;
        }
        
        /// <summary>
        /// Specifies if create a PST or MSG for input items. For 6.6 we always set this to true.
        /// </summary>
        /// <value>Specifies if create a PST or MSG for input items. For 6.6 we always set this to true.</value>
        [DataMember(Name="createPst", EmitDefaultValue=false)]
        public bool? CreatePst { get; set; }

        /// <summary>
        /// Specifies Password to be set for generated PSTs.
        /// </summary>
        /// <value>Specifies Password to be set for generated PSTs.</value>
        [DataMember(Name="pstPassword", EmitDefaultValue=false)]
        public string PstPassword { get; set; }

        /// <summary>
        /// Specifies PST size threshold in bytes.
        /// </summary>
        /// <value>Specifies PST size threshold in bytes.</value>
        [DataMember(Name="pstSizeThreshold", EmitDefaultValue=false)]
        public long? PstSizeThreshold { get; set; }

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
            return this.Equals(input as PstParameters);
        }

        /// <summary>
        /// Returns true if PstParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PstParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PstParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatePst == input.CreatePst ||
                    (this.CreatePst != null &&
                    this.CreatePst.Equals(input.CreatePst))
                ) && 
                (
                    this.PstPassword == input.PstPassword ||
                    (this.PstPassword != null &&
                    this.PstPassword.Equals(input.PstPassword))
                ) && 
                (
                    this.PstSizeThreshold == input.PstSizeThreshold ||
                    (this.PstSizeThreshold != null &&
                    this.PstSizeThreshold.Equals(input.PstSizeThreshold))
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
                if (this.CreatePst != null)
                    hashCode = hashCode * 59 + this.CreatePst.GetHashCode();
                if (this.PstPassword != null)
                    hashCode = hashCode * 59 + this.PstPassword.GetHashCode();
                if (this.PstSizeThreshold != null)
                    hashCode = hashCode * 59 + this.PstSizeThreshold.GetHashCode();
                return hashCode;
            }
        }

    }

}

