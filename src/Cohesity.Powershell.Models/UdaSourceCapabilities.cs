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
    /// UdaSourceCapabilities
    /// </summary>
    [DataContract]
    public partial class UdaSourceCapabilities :  IEquatable<UdaSourceCapabilities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaSourceCapabilities" /> class.
        /// </summary>
        /// <param name="autoLogBackup">autoLogBackup.</param>
        /// <param name="dynamicConfig">Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability..</param>
        /// <param name="entitySupport">Indicates if source has entity capability..</param>
        /// <param name="fullBackup">fullBackup.</param>
        /// <param name="incrBackup">incrBackup.</param>
        /// <param name="logBackup">logBackup.</param>
        /// <param name="multiObjectRestore">Whether the source supports restore of multiple objects..</param>
        public UdaSourceCapabilities(bool? autoLogBackup = default(bool?), bool? dynamicConfig = default(bool?), bool? entitySupport = default(bool?), bool? fullBackup = default(bool?), bool? incrBackup = default(bool?), bool? logBackup = default(bool?), bool? multiObjectRestore = default(bool?))
        {
            this.AutoLogBackup = autoLogBackup;
            this.DynamicConfig = dynamicConfig;
            this.EntitySupport = entitySupport;
            this.FullBackup = fullBackup;
            this.IncrBackup = incrBackup;
            this.LogBackup = logBackup;
            this.MultiObjectRestore = multiObjectRestore;
            this.AutoLogBackup = autoLogBackup;
            this.DynamicConfig = dynamicConfig;
            this.EntitySupport = entitySupport;
            this.FullBackup = fullBackup;
            this.IncrBackup = incrBackup;
            this.LogBackup = logBackup;
            this.MultiObjectRestore = multiObjectRestore;
        }
        
        /// <summary>
        /// Gets or Sets AutoLogBackup
        /// </summary>
        [DataMember(Name="autoLogBackup", EmitDefaultValue=true)]
        public bool? AutoLogBackup { get; set; }

        /// <summary>
        /// Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability.
        /// </summary>
        /// <value>Specifies whether the source supports the &#39;Dynamic Configuration&#39; capability.</value>
        [DataMember(Name="dynamicConfig", EmitDefaultValue=true)]
        public bool? DynamicConfig { get; set; }

        /// <summary>
        /// Indicates if source has entity capability.
        /// </summary>
        /// <value>Indicates if source has entity capability.</value>
        [DataMember(Name="entitySupport", EmitDefaultValue=true)]
        public bool? EntitySupport { get; set; }

        /// <summary>
        /// Gets or Sets FullBackup
        /// </summary>
        [DataMember(Name="fullBackup", EmitDefaultValue=true)]
        public bool? FullBackup { get; set; }

        /// <summary>
        /// Gets or Sets IncrBackup
        /// </summary>
        [DataMember(Name="incrBackup", EmitDefaultValue=true)]
        public bool? IncrBackup { get; set; }

        /// <summary>
        /// Gets or Sets LogBackup
        /// </summary>
        [DataMember(Name="logBackup", EmitDefaultValue=true)]
        public bool? LogBackup { get; set; }

        /// <summary>
        /// Whether the source supports restore of multiple objects.
        /// </summary>
        /// <value>Whether the source supports restore of multiple objects.</value>
        [DataMember(Name="multiObjectRestore", EmitDefaultValue=true)]
        public bool? MultiObjectRestore { get; set; }

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
            return this.Equals(input as UdaSourceCapabilities);
        }

        /// <summary>
        /// Returns true if UdaSourceCapabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaSourceCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaSourceCapabilities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoLogBackup == input.AutoLogBackup ||
                    (this.AutoLogBackup != null &&
                    this.AutoLogBackup.Equals(input.AutoLogBackup))
                ) && 
                (
                    this.DynamicConfig == input.DynamicConfig ||
                    (this.DynamicConfig != null &&
                    this.DynamicConfig.Equals(input.DynamicConfig))
                ) && 
                (
                    this.EntitySupport == input.EntitySupport ||
                    (this.EntitySupport != null &&
                    this.EntitySupport.Equals(input.EntitySupport))
                ) && 
                (
                    this.FullBackup == input.FullBackup ||
                    (this.FullBackup != null &&
                    this.FullBackup.Equals(input.FullBackup))
                ) && 
                (
                    this.IncrBackup == input.IncrBackup ||
                    (this.IncrBackup != null &&
                    this.IncrBackup.Equals(input.IncrBackup))
                ) && 
                (
                    this.LogBackup == input.LogBackup ||
                    (this.LogBackup != null &&
                    this.LogBackup.Equals(input.LogBackup))
                ) && 
                (
                    this.MultiObjectRestore == input.MultiObjectRestore ||
                    (this.MultiObjectRestore != null &&
                    this.MultiObjectRestore.Equals(input.MultiObjectRestore))
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
                if (this.AutoLogBackup != null)
                    hashCode = hashCode * 59 + this.AutoLogBackup.GetHashCode();
                if (this.DynamicConfig != null)
                    hashCode = hashCode * 59 + this.DynamicConfig.GetHashCode();
                if (this.EntitySupport != null)
                    hashCode = hashCode * 59 + this.EntitySupport.GetHashCode();
                if (this.FullBackup != null)
                    hashCode = hashCode * 59 + this.FullBackup.GetHashCode();
                if (this.IncrBackup != null)
                    hashCode = hashCode * 59 + this.IncrBackup.GetHashCode();
                if (this.LogBackup != null)
                    hashCode = hashCode * 59 + this.LogBackup.GetHashCode();
                if (this.MultiObjectRestore != null)
                    hashCode = hashCode * 59 + this.MultiObjectRestore.GetHashCode();
                return hashCode;
            }
        }

    }

}

