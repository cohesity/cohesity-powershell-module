// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies Cloud parameters that are applicable to all Protection Sources in a Protection Job in certain scenarios.
    /// </summary>
    [DataContract]
    public partial class CloudParameters :  IEquatable<CloudParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudParameters" /> class.
        /// </summary>
        /// <param name="failoverToCloud">Specifies whether the Protection Sources in this Protection Job will be failed over to Cloud. This flag is applicable to backup on-prem Sources..</param>
        public CloudParameters(bool? failoverToCloud = default(bool?))
        {
            this.FailoverToCloud = failoverToCloud;
        }
        
        /// <summary>
        /// Specifies whether the Protection Sources in this Protection Job will be failed over to Cloud. This flag is applicable to backup on-prem Sources.
        /// </summary>
        /// <value>Specifies whether the Protection Sources in this Protection Job will be failed over to Cloud. This flag is applicable to backup on-prem Sources.</value>
        [DataMember(Name="failoverToCloud", EmitDefaultValue=false)]
        public bool? FailoverToCloud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class CloudParameters {\n");
        //    sb.Append("  FailoverToCloud: ").Append(FailoverToCloud).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}
  
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
            return this.Equals(input as CloudParameters);
        }

        /// <summary>
        /// Returns true if CloudParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailoverToCloud == input.FailoverToCloud ||
                    (this.FailoverToCloud != null &&
                    this.FailoverToCloud.Equals(input.FailoverToCloud))
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
                if (this.FailoverToCloud != null)
                    hashCode = hashCode * 59 + this.FailoverToCloud.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

