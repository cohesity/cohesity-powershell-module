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
    /// Specifies the response to request to list the storage profiles associated with a VDC.
    /// </summary>
    [DataContract]
    public partial class ListStorageProfilesResponseBody :  IEquatable<ListStorageProfilesResponseBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStorageProfilesResponseBody" /> class.
        /// </summary>
        /// <param name="storageProfiles">Specifies a list of storage profiles..</param>
        public ListStorageProfilesResponseBody(List<VcdStorageProfile> storageProfiles = default(List<VcdStorageProfile>))
        {
            this.StorageProfiles = storageProfiles;
        }
        
        /// <summary>
        /// Specifies a list of storage profiles.
        /// </summary>
        /// <value>Specifies a list of storage profiles.</value>
        [DataMember(Name="storageProfiles", EmitDefaultValue=false)]
        public List<VcdStorageProfile> StorageProfiles { get; set; }

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
            return this.Equals(input as ListStorageProfilesResponseBody);
        }

        /// <summary>
        /// Returns true if ListStorageProfilesResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ListStorageProfilesResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListStorageProfilesResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageProfiles == input.StorageProfiles ||
                    this.StorageProfiles != null &&
                    this.StorageProfiles.Equals(input.StorageProfiles)
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
                if (this.StorageProfiles != null)
                    hashCode = hashCode * 59 + this.StorageProfiles.GetHashCode();
                return hashCode;
            }
        }

    }

}

