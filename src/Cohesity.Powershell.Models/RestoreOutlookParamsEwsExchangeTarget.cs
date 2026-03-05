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
    /// RestoreOutlookParamsEwsExchangeTarget
    /// </summary>
    [DataContract]
    public partial class RestoreOutlookParamsEwsExchangeTarget :  IEquatable<RestoreOutlookParamsEwsExchangeTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreOutlookParamsEwsExchangeTarget" /> class.
        /// </summary>
        /// <param name="ewsExchangeServerEntityId">Entity ID of the on prem exchange server that we will recover to. Must be set when doing a kRecoverO365ToExchangeServer recovery..</param>
        public RestoreOutlookParamsEwsExchangeTarget(long? ewsExchangeServerEntityId = default(long?))
        {
            this.EwsExchangeServerEntityId = ewsExchangeServerEntityId;
            this.EwsExchangeServerEntityId = ewsExchangeServerEntityId;
        }
        
        /// <summary>
        /// Entity ID of the on prem exchange server that we will recover to. Must be set when doing a kRecoverO365ToExchangeServer recovery.
        /// </summary>
        /// <value>Entity ID of the on prem exchange server that we will recover to. Must be set when doing a kRecoverO365ToExchangeServer recovery.</value>
        [DataMember(Name="ewsExchangeServerEntityId", EmitDefaultValue=true)]
        public long? EwsExchangeServerEntityId { get; set; }

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
            return this.Equals(input as RestoreOutlookParamsEwsExchangeTarget);
        }

        /// <summary>
        /// Returns true if RestoreOutlookParamsEwsExchangeTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreOutlookParamsEwsExchangeTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreOutlookParamsEwsExchangeTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EwsExchangeServerEntityId == input.EwsExchangeServerEntityId ||
                    (this.EwsExchangeServerEntityId != null &&
                    this.EwsExchangeServerEntityId.Equals(input.EwsExchangeServerEntityId))
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
                if (this.EwsExchangeServerEntityId != null)
                    hashCode = hashCode * 59 + this.EwsExchangeServerEntityId.GetHashCode();
                return hashCode;
            }
        }

    }

}

