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
    /// Specifies a storage profile for use while recovering to a VMware VCD.
    /// </summary>
    [DataContract]
    public partial class VcdStorageProfile :  IEquatable<VcdStorageProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VcdStorageProfile" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the storage profile..</param>
        /// <param name="uuid">Specifies the UUID of the storage profile as identified by the VCD..</param>
        public VcdStorageProfile(string name = default(string), string uuid = default(string))
        {
            this.Name = name;
            this.Uuid = uuid;
            this.Name = name;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the name of the storage profile.
        /// </summary>
        /// <value>Specifies the name of the storage profile.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the UUID of the storage profile as identified by the VCD.
        /// </summary>
        /// <value>Specifies the UUID of the storage profile as identified by the VCD.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as VcdStorageProfile);
        }

        /// <summary>
        /// Returns true if VcdStorageProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of VcdStorageProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VcdStorageProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

