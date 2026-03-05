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
    /// EntitySKU
    /// </summary>
    [DataContract]
    public partial class EntitySKU :  IEquatable<EntitySKU>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySKU" /> class.
        /// </summary>
        /// <param name="capacity">Capacity of the sku. For azure sql dbs, this is the number of cores..</param>
        /// <param name="name">Can be one of Name_Type enum above..</param>
        /// <param name="nameType">Enum representation of name for UI selection purpose..</param>
        /// <param name="tier">Can be one of Tier_Type enum above..</param>
        /// <param name="tierType">Enum representation of tier for UI selection purpose..</param>
        public EntitySKU(int? capacity = default(int?), string name = default(string), int? nameType = default(int?), string tier = default(string), int? tierType = default(int?))
        {
            this.Capacity = capacity;
            this.Name = name;
            this.NameType = nameType;
            this.Tier = tier;
            this.TierType = tierType;
            this.Capacity = capacity;
            this.Name = name;
            this.NameType = nameType;
            this.Tier = tier;
            this.TierType = tierType;
        }
        
        /// <summary>
        /// Capacity of the sku. For azure sql dbs, this is the number of cores.
        /// </summary>
        /// <value>Capacity of the sku. For azure sql dbs, this is the number of cores.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public int? Capacity { get; set; }

        /// <summary>
        /// Can be one of Name_Type enum above.
        /// </summary>
        /// <value>Can be one of Name_Type enum above.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Enum representation of name for UI selection purpose.
        /// </summary>
        /// <value>Enum representation of name for UI selection purpose.</value>
        [DataMember(Name="nameType", EmitDefaultValue=true)]
        public int? NameType { get; set; }

        /// <summary>
        /// Can be one of Tier_Type enum above.
        /// </summary>
        /// <value>Can be one of Tier_Type enum above.</value>
        [DataMember(Name="tier", EmitDefaultValue=true)]
        public string Tier { get; set; }

        /// <summary>
        /// Enum representation of tier for UI selection purpose.
        /// </summary>
        /// <value>Enum representation of tier for UI selection purpose.</value>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
        public int? TierType { get; set; }

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
            return this.Equals(input as EntitySKU);
        }

        /// <summary>
        /// Returns true if EntitySKU instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySKU to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySKU input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameType == input.NameType ||
                    (this.NameType != null &&
                    this.NameType.Equals(input.NameType))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.TierType == input.TierType ||
                    (this.TierType != null &&
                    this.TierType.Equals(input.TierType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameType != null)
                    hashCode = hashCode * 59 + this.NameType.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                return hashCode;
            }
        }

    }

}

