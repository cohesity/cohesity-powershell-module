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
    /// Specifies an Object containing information about a mongodb collection.
    /// </summary>
    [DataContract]
    public partial class MongoDBCollection :  IEquatable<MongoDBCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBCollection" /> class.
        /// </summary>
        /// <param name="isCappedCollection">Set to true if this is a capped Collection..</param>
        /// <param name="isMongoView">Set to true if this Collection is a view..</param>
        /// <param name="sizeBytes">Size of this Collection..</param>
        public MongoDBCollection(bool? isCappedCollection = default(bool?), bool? isMongoView = default(bool?), long? sizeBytes = default(long?))
        {
            this.IsCappedCollection = isCappedCollection;
            this.IsMongoView = isMongoView;
            this.SizeBytes = sizeBytes;
            this.IsCappedCollection = isCappedCollection;
            this.IsMongoView = isMongoView;
            this.SizeBytes = sizeBytes;
        }
        
        /// <summary>
        /// Set to true if this is a capped Collection.
        /// </summary>
        /// <value>Set to true if this is a capped Collection.</value>
        [DataMember(Name="isCappedCollection", EmitDefaultValue=true)]
        public bool? IsCappedCollection { get; set; }

        /// <summary>
        /// Set to true if this Collection is a view.
        /// </summary>
        /// <value>Set to true if this Collection is a view.</value>
        [DataMember(Name="isMongoView", EmitDefaultValue=true)]
        public bool? IsMongoView { get; set; }

        /// <summary>
        /// Size of this Collection.
        /// </summary>
        /// <value>Size of this Collection.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
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
            return this.Equals(input as MongoDBCollection);
        }

        /// <summary>
        /// Returns true if MongoDBCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCappedCollection == input.IsCappedCollection ||
                    (this.IsCappedCollection != null &&
                    this.IsCappedCollection.Equals(input.IsCappedCollection))
                ) && 
                (
                    this.IsMongoView == input.IsMongoView ||
                    (this.IsMongoView != null &&
                    this.IsMongoView.Equals(input.IsMongoView))
                ) && 
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
                if (this.IsCappedCollection != null)
                    hashCode = hashCode * 59 + this.IsCappedCollection.GetHashCode();
                if (this.IsMongoView != null)
                    hashCode = hashCode * 59 + this.IsMongoView.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

