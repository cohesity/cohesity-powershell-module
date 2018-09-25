// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// ThrottlingPolicyOverride
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyOverride :  IEquatable<ThrottlingPolicyOverride>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyOverride" /> class.
        /// </summary>
        /// <param name="datastoreId">Specifies the Protection Source id of the Datastore..</param>
        /// <param name="datastoreName">Specifies the display name of the Datastore..</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        public ThrottlingPolicyOverride(long? datastoreId = default(long?), string datastoreName = default(string), ThrottlingPolicy throttlingPolicy = default(ThrottlingPolicy))
        {
            this.DatastoreId = datastoreId;
            this.DatastoreName = datastoreName;
            this.ThrottlingPolicy = throttlingPolicy;
        }
        
        /// <summary>
        /// Specifies the Protection Source id of the Datastore.
        /// </summary>
        /// <value>Specifies the Protection Source id of the Datastore.</value>
        [DataMember(Name="datastoreId", EmitDefaultValue=false)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// Specifies the display name of the Datastore.
        /// </summary>
        /// <value>Specifies the display name of the Datastore.</value>
        [DataMember(Name="datastoreName", EmitDefaultValue=false)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Specifies the throttling policy that should be applied to this Source.
        /// </summary>
        /// <value>Specifies the throttling policy that should be applied to this Source.</value>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=false)]
        public ThrottlingPolicy ThrottlingPolicy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as ThrottlingPolicyOverride);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreId == input.DatastoreId ||
                    (this.DatastoreId != null &&
                    this.DatastoreId.Equals(input.DatastoreId))
                ) && 
                (
                    this.DatastoreName == input.DatastoreName ||
                    (this.DatastoreName != null &&
                    this.DatastoreName.Equals(input.DatastoreName))
                ) && 
                (
                    this.ThrottlingPolicy == input.ThrottlingPolicy ||
                    (this.ThrottlingPolicy != null &&
                    this.ThrottlingPolicy.Equals(input.ThrottlingPolicy))
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
                if (this.DatastoreId != null)
                    hashCode = hashCode * 59 + this.DatastoreId.GetHashCode();
                if (this.DatastoreName != null)
                    hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

