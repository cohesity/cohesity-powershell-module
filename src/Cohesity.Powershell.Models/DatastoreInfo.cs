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
    /// DatastoreInfo
    /// </summary>
    [DataContract]
    public partial class DatastoreInfo :  IEquatable<DatastoreInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatastoreInfo" /> class.
        /// </summary>
        /// <param name="capacity">Specifies the capacity of the datastore in bytes..</param>
        /// <param name="freeSpace">Specifies the available space on the datastore in bytes..</param>
        public DatastoreInfo(long? capacity = default(long?), long? freeSpace = default(long?))
        {
            this.Capacity = capacity;
            this.FreeSpace = freeSpace;
            this.Capacity = capacity;
            this.FreeSpace = freeSpace;
        }
        
        /// <summary>
        /// Specifies the capacity of the datastore in bytes.
        /// </summary>
        /// <value>Specifies the capacity of the datastore in bytes.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public long? Capacity { get; set; }

        /// <summary>
        /// Specifies the available space on the datastore in bytes.
        /// </summary>
        /// <value>Specifies the available space on the datastore in bytes.</value>
        [DataMember(Name="freeSpace", EmitDefaultValue=true)]
        public long? FreeSpace { get; set; }

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
            return this.Equals(input as DatastoreInfo);
        }

        /// <summary>
        /// Returns true if DatastoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DatastoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatastoreInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.FreeSpace == input.FreeSpace ||
                    (this.FreeSpace != null &&
                    this.FreeSpace.Equals(input.FreeSpace))
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.FreeSpace != null)
                    hashCode = hashCode * 59 + this.FreeSpace.GetHashCode();
                return hashCode;
            }
        }

    }

}

