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
    /// Salesforce Account Information of a Helios user.
    /// </summary>
    [DataContract]
    public partial class SalesforceAccountInfo :  IEquatable<SalesforceAccountInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceAccountInfo" /> class.
        /// </summary>
        /// <param name="accountId">Specifies the Account Id assigned by Salesforce..</param>
        /// <param name="userId">Specifies the User Id assigned by Salesforce..</param>
        public SalesforceAccountInfo(string accountId = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.UserId = userId;
            this.AccountId = accountId;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Specifies the Account Id assigned by Salesforce.
        /// </summary>
        /// <value>Specifies the Account Id assigned by Salesforce.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Specifies the User Id assigned by Salesforce.
        /// </summary>
        /// <value>Specifies the User Id assigned by Salesforce.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesforceAccountInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as SalesforceAccountInfo);
        }

        /// <summary>
        /// Returns true if SalesforceAccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesforceAccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesforceAccountInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}
