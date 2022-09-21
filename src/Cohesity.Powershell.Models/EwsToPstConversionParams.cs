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
    /// EwsToPstConversionParams
    /// </summary>
    [DataContract]
    public partial class EwsToPstConversionParams :  IEquatable<EwsToPstConversionParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EwsToPstConversionParams" /> class.
        /// </summary>
        /// <param name="createPst">Create Msg files or Pst. false value indicates only create msg files. Default value is true..</param>
        /// <param name="optionFlags">ConvertEwsToPst flags of type ConvertEwsToPSTOptionFlags..</param>
        /// <param name="pstNamePrefix">Name prefix for generated PST files..</param>
        /// <param name="pstPassword">Optional password to be set for the output PSTs..</param>
        /// <param name="pstSizeThreshold">PST rotation size in bytes..</param>
        public EwsToPstConversionParams(bool? createPst = default(bool?), int? optionFlags = default(int?), string pstNamePrefix = default(string), string pstPassword = default(string), long? pstSizeThreshold = default(long?))
        {
            this.CreatePst = createPst;
            this.OptionFlags = optionFlags;
            this.PstNamePrefix = pstNamePrefix;
            this.PstPassword = pstPassword;
            this.PstSizeThreshold = pstSizeThreshold;
            this.CreatePst = createPst;
            this.OptionFlags = optionFlags;
            this.PstNamePrefix = pstNamePrefix;
            this.PstPassword = pstPassword;
            this.PstSizeThreshold = pstSizeThreshold;
        }
        
        /// <summary>
        /// Create Msg files or Pst. false value indicates only create msg files. Default value is true.
        /// </summary>
        /// <value>Create Msg files or Pst. false value indicates only create msg files. Default value is true.</value>
        [DataMember(Name="createPst", EmitDefaultValue=true)]
        public bool? CreatePst { get; set; }

        /// <summary>
        /// ConvertEwsToPst flags of type ConvertEwsToPSTOptionFlags.
        /// </summary>
        /// <value>ConvertEwsToPst flags of type ConvertEwsToPSTOptionFlags.</value>
        [DataMember(Name="optionFlags", EmitDefaultValue=true)]
        public int? OptionFlags { get; set; }

        /// <summary>
        /// Name prefix for generated PST files.
        /// </summary>
        /// <value>Name prefix for generated PST files.</value>
        [DataMember(Name="pstNamePrefix", EmitDefaultValue=true)]
        public string PstNamePrefix { get; set; }

        /// <summary>
        /// Optional password to be set for the output PSTs.
        /// </summary>
        /// <value>Optional password to be set for the output PSTs.</value>
        [DataMember(Name="pstPassword", EmitDefaultValue=true)]
        public string PstPassword { get; set; }

        /// <summary>
        /// PST rotation size in bytes.
        /// </summary>
        /// <value>PST rotation size in bytes.</value>
        [DataMember(Name="pstSizeThreshold", EmitDefaultValue=true)]
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
            return this.Equals(input as EwsToPstConversionParams);
        }

        /// <summary>
        /// Returns true if EwsToPstConversionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of EwsToPstConversionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EwsToPstConversionParams input)
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
                    this.OptionFlags == input.OptionFlags ||
                    (this.OptionFlags != null &&
                    this.OptionFlags.Equals(input.OptionFlags))
                ) && 
                (
                    this.PstNamePrefix == input.PstNamePrefix ||
                    (this.PstNamePrefix != null &&
                    this.PstNamePrefix.Equals(input.PstNamePrefix))
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
                if (this.OptionFlags != null)
                    hashCode = hashCode * 59 + this.OptionFlags.GetHashCode();
                if (this.PstNamePrefix != null)
                    hashCode = hashCode * 59 + this.PstNamePrefix.GetHashCode();
                if (this.PstPassword != null)
                    hashCode = hashCode * 59 + this.PstPassword.GetHashCode();
                if (this.PstSizeThreshold != null)
                    hashCode = hashCode * 59 + this.PstSizeThreshold.GetHashCode();
                return hashCode;
            }
        }

    }

}

