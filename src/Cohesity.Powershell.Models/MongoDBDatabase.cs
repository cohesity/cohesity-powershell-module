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
    /// Specifies an Object containing information about a mongodb database.
    /// </summary>
    [DataContract]
    public partial class MongoDBDatabase :  IEquatable<MongoDBDatabase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBDatabase" /> class.
        /// </summary>
        /// <param name="sizeBytes">Size of this Database..</param>
        public MongoDBDatabase(long? sizeBytes = default(long?))
        {
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Size of this Database.
        /// </summary>
        /// <value>Size of this Database.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }

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
            return this.Equals(input as MongoDBDatabase);
        }

        /// <summary>
        /// Returns true if MongoDBDatabase instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBDatabase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBDatabase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
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
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

