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
    /// Protobuf that describes the bucket ownership control configuarion that is used to manage the ownership of objects in a bucket.
    /// </summary>
    [DataContract]
    public partial class BucketOwnershipControls :  IEquatable<BucketOwnershipControls>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketOwnershipControls" /> class.
        /// </summary>
        /// <param name="rule">rule.</param>
        public BucketOwnershipControls(OwnershipControlsRule rule = default(OwnershipControlsRule))
        {
            this.Rule = rule;
        }
        
        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public OwnershipControlsRule Rule { get; set; }

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
            return this.Equals(input as BucketOwnershipControls);
        }

        /// <summary>
        /// Returns true if BucketOwnershipControls instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketOwnershipControls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketOwnershipControls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
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
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                return hashCode;
            }
        }

    }

}

