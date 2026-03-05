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
    /// GaiaIndexStoragesInfo holds information about the list of Gaia index storage subscription infos.
    /// </summary>
    [DataContract]
    public partial class GaiaIndexStoragesInfo :  IEquatable<GaiaIndexStoragesInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GaiaIndexStoragesInfo" /> class.
        /// </summary>
        /// <param name="indexStorages">Specifies the list of Gaia index storage subscription info..</param>
        public GaiaIndexStoragesInfo(List<GaiaIndexStorageInfo> indexStorages = default(List<GaiaIndexStorageInfo>))
        {
            this.IndexStorages = indexStorages;
            this.IndexStorages = indexStorages;
        }
        
        /// <summary>
        /// Specifies the list of Gaia index storage subscription info.
        /// </summary>
        /// <value>Specifies the list of Gaia index storage subscription info.</value>
        [DataMember(Name="indexStorages", EmitDefaultValue=true)]
        public List<GaiaIndexStorageInfo> IndexStorages { get; set; }

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
            return this.Equals(input as GaiaIndexStoragesInfo);
        }

        /// <summary>
        /// Returns true if GaiaIndexStoragesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GaiaIndexStoragesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GaiaIndexStoragesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndexStorages == input.IndexStorages ||
                    this.IndexStorages != null &&
                    input.IndexStorages != null &&
                    this.IndexStorages.SequenceEqual(input.IndexStorages)
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
                if (this.IndexStorages != null)
                    hashCode = hashCode * 59 + this.IndexStorages.GetHashCode();
                return hashCode;
            }
        }

    }

}

