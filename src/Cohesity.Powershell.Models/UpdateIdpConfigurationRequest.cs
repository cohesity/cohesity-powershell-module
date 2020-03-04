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
    /// Specifies the parameters of an IdP configuration to be updated.
    /// </summary>
    [DataContract]
    public partial class UpdateIdpConfigurationRequest :  IEquatable<UpdateIdpConfigurationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIdpConfigurationRequest" /> class.
        /// </summary>
        /// <param name="allowLocalAuthentication">Specifies whether to allow local authentication. When IdP is configured, only IdP users are allowed to login to the Cluster. Local login is disabled except for users with admin role. If this flag is set to true, local (non-IdP) logins are allowed for all local and AD users. Local or AD users with admin role can login always independent of this flag&#39;s setting..</param>
        /// <param name="certificate">Specifies the certificate generated for the app by the IdP service when the Cluster is registered as an app. This is required to verify the SAML response..</param>
        /// <param name="certificateFilename">Specifies the filename used to upload the certificate..</param>
        /// <param name="enable">Specifies a flag to enable or disable this IdP service. When it is set to true, IdP service is enabled. When it is set to false, IdP service is disabled. When an IdP service is created, it is set to true..</param>
        /// <param name="issuerId">Specifies the IdP provided Issuer ID for the app. For example, exkh1aov1nhHrgFhN0h7..</param>
        /// <param name="roles">Specifies a list of roles assigned to an IdP user if samlAttributeName is not given..</param>
        /// <param name="samlAttributeName">Specifies the SAML attribute name that contains a comma separated list of Cluster roles. Either this field or roles must be set. This field takes higher precedence than the roles field..</param>
        /// <param name="signRequest">Specifies whether to sign the SAML request or not. When it is set to true, SAML request will be signed. When it is set to false, SAML request is not signed. Default is false. Set this flag to true if the IdP site is configured to expect the SAML request from the Cluster signed. If this is set to true, users must get the Cluster&#39;s certificate and upload it on the IdP site..</param>
        /// <param name="ssoUrl">Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site. For example, dev-332534.oktapreview.com.</param>
        public UpdateIdpConfigurationRequest(bool? allowLocalAuthentication = default(bool?), string certificate = default(string), string certificateFilename = default(string), bool? enable = default(bool?), string issuerId = default(string), List<string> roles = default(List<string>), string samlAttributeName = default(string), bool? signRequest = default(bool?), string ssoUrl = default(string))
        {
            this.AllowLocalAuthentication = allowLocalAuthentication;
            this.Certificate = certificate;
            this.CertificateFilename = certificateFilename;
            this.Enable = enable;
            this.IssuerId = issuerId;
            this.Roles = roles;
            this.SamlAttributeName = samlAttributeName;
            this.SignRequest = signRequest;
            this.SsoUrl = ssoUrl;
            this.AllowLocalAuthentication = allowLocalAuthentication;
            this.Certificate = certificate;
            this.CertificateFilename = certificateFilename;
            this.Enable = enable;
            this.IssuerId = issuerId;
            this.Roles = roles;
            this.SamlAttributeName = samlAttributeName;
            this.SignRequest = signRequest;
            this.SsoUrl = ssoUrl;
        }
        
        /// <summary>
        /// Specifies whether to allow local authentication. When IdP is configured, only IdP users are allowed to login to the Cluster. Local login is disabled except for users with admin role. If this flag is set to true, local (non-IdP) logins are allowed for all local and AD users. Local or AD users with admin role can login always independent of this flag&#39;s setting.
        /// </summary>
        /// <value>Specifies whether to allow local authentication. When IdP is configured, only IdP users are allowed to login to the Cluster. Local login is disabled except for users with admin role. If this flag is set to true, local (non-IdP) logins are allowed for all local and AD users. Local or AD users with admin role can login always independent of this flag&#39;s setting.</value>
        [DataMember(Name="allowLocalAuthentication", EmitDefaultValue=true)]
        public bool? AllowLocalAuthentication { get; set; }

        /// <summary>
        /// Specifies the certificate generated for the app by the IdP service when the Cluster is registered as an app. This is required to verify the SAML response.
        /// </summary>
        /// <value>Specifies the certificate generated for the app by the IdP service when the Cluster is registered as an app. This is required to verify the SAML response.</value>
        [DataMember(Name="certificate", EmitDefaultValue=true)]
        public string Certificate { get; set; }

        /// <summary>
        /// Specifies the filename used to upload the certificate.
        /// </summary>
        /// <value>Specifies the filename used to upload the certificate.</value>
        [DataMember(Name="certificateFilename", EmitDefaultValue=true)]
        public string CertificateFilename { get; set; }

        /// <summary>
        /// Specifies a flag to enable or disable this IdP service. When it is set to true, IdP service is enabled. When it is set to false, IdP service is disabled. When an IdP service is created, it is set to true.
        /// </summary>
        /// <value>Specifies a flag to enable or disable this IdP service. When it is set to true, IdP service is enabled. When it is set to false, IdP service is disabled. When an IdP service is created, it is set to true.</value>
        [DataMember(Name="enable", EmitDefaultValue=true)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Specifies the IdP provided Issuer ID for the app. For example, exkh1aov1nhHrgFhN0h7.
        /// </summary>
        /// <value>Specifies the IdP provided Issuer ID for the app. For example, exkh1aov1nhHrgFhN0h7.</value>
        [DataMember(Name="issuerId", EmitDefaultValue=true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Specifies a list of roles assigned to an IdP user if samlAttributeName is not given.
        /// </summary>
        /// <value>Specifies a list of roles assigned to an IdP user if samlAttributeName is not given.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the SAML attribute name that contains a comma separated list of Cluster roles. Either this field or roles must be set. This field takes higher precedence than the roles field.
        /// </summary>
        /// <value>Specifies the SAML attribute name that contains a comma separated list of Cluster roles. Either this field or roles must be set. This field takes higher precedence than the roles field.</value>
        [DataMember(Name="samlAttributeName", EmitDefaultValue=true)]
        public string SamlAttributeName { get; set; }

        /// <summary>
        /// Specifies whether to sign the SAML request or not. When it is set to true, SAML request will be signed. When it is set to false, SAML request is not signed. Default is false. Set this flag to true if the IdP site is configured to expect the SAML request from the Cluster signed. If this is set to true, users must get the Cluster&#39;s certificate and upload it on the IdP site.
        /// </summary>
        /// <value>Specifies whether to sign the SAML request or not. When it is set to true, SAML request will be signed. When it is set to false, SAML request is not signed. Default is false. Set this flag to true if the IdP site is configured to expect the SAML request from the Cluster signed. If this is set to true, users must get the Cluster&#39;s certificate and upload it on the IdP site.</value>
        [DataMember(Name="signRequest", EmitDefaultValue=true)]
        public bool? SignRequest { get; set; }

        /// <summary>
        /// Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site. For example, dev-332534.oktapreview.com
        /// </summary>
        /// <value>Specifies the SSO URL of the IdP service for the customer. This is the URL given by IdP when the customer created an account. Customers may use this for several clusters that are registered with on IdP site. For example, dev-332534.oktapreview.com</value>
        [DataMember(Name="ssoUrl", EmitDefaultValue=true)]
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
            return this.Equals(input as UpdateIdpConfigurationRequest);
        }

        /// <summary>
        /// Returns true if UpdateIdpConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateIdpConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateIdpConfigurationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowLocalAuthentication == input.AllowLocalAuthentication ||
                    (this.AllowLocalAuthentication != null &&
                    this.AllowLocalAuthentication.Equals(input.AllowLocalAuthentication))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.CertificateFilename == input.CertificateFilename ||
                    (this.CertificateFilename != null &&
                    this.CertificateFilename.Equals(input.CertificateFilename))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.SamlAttributeName == input.SamlAttributeName ||
                    (this.SamlAttributeName != null &&
                    this.SamlAttributeName.Equals(input.SamlAttributeName))
                ) && 
                (
                    this.SignRequest == input.SignRequest ||
                    (this.SignRequest != null &&
                    this.SignRequest.Equals(input.SignRequest))
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
                if (this.AllowLocalAuthentication != null)
                    hashCode = hashCode * 59 + this.AllowLocalAuthentication.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.CertificateFilename != null)
                    hashCode = hashCode * 59 + this.CertificateFilename.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.IssuerId != null)
                    hashCode = hashCode * 59 + this.IssuerId.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.SamlAttributeName != null)
                    hashCode = hashCode * 59 + this.SamlAttributeName.GetHashCode();
                if (this.SignRequest != null)
                    hashCode = hashCode * 59 + this.SignRequest.GetHashCode();
                if (this.SsoUrl != null)
                    hashCode = hashCode * 59 + this.SsoUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}

