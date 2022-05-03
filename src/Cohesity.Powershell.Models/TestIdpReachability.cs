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
    /// Specifies the parameters to test the reachability of an IdP.
    /// </summary>
    [DataContract]
    public partial class TestIdpReachability :  IEquatable<TestIdpReachability>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestIdpReachability" /> class.
        /// </summary>
        /// <param name="issuerId">Specifies the IdP provided Issuer ID for the app..</param>
        /// <param name="ssoUrl">Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site..</param>
        public TestIdpReachability(string issuerId = default(string), string ssoUrl = default(string))
        {
            this.IssuerId = issuerId;
            this.SsoUrl = ssoUrl;
        }
        
        /// <summary>
        /// Specifies the IdP provided Issuer ID for the app.
        /// </summary>
        /// <value>Specifies the IdP provided Issuer ID for the app.</value>
        [DataMember(Name="issuerId", EmitDefaultValue=false)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site.
        /// </summary>
        /// <value>Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site.</value>
        [DataMember(Name="ssoUrl", EmitDefaultValue=false)]
        public string SsoUrl { get; set; }

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
            return this.Equals(input as TestIdpReachability);
        }

        /// <summary>
        /// Returns true if TestIdpReachability instances are equal
        /// </summary>
        /// <param name="input">Instance of TestIdpReachability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestIdpReachability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))
                ) && 
                (
                    this.SsoUrl == input.SsoUrl ||
                    (this.SsoUrl != null &&
                    this.SsoUrl.Equals(input.SsoUrl))
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
                if (this.IssuerId != null)
                    hashCode = hashCode * 59 + this.IssuerId.GetHashCode();
                if (this.SsoUrl != null)
                    hashCode = hashCode * 59 + this.SsoUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

