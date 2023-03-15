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
    /// Specifies details about a certificate.
    /// </summary>
    [DataContract]
    public partial class CertificateDetails :  IEquatable<CertificateDetails>
    {
        /// <summary>
        /// Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host.
        /// </summary>
        /// <value>Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 1,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 2,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 3

        }

        /// <summary>
        /// Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host.
        /// </summary>
        /// <value>Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateDetails" /> class.
        /// </summary>
        /// <param name="certFileName">Specifies the filename of the certificate. This is unique to each certificate generated..</param>
        /// <param name="expiryDate">Specifies the date in epoch till when the certificate is valid..</param>
        /// <param name="hostIps">Each certificate can be deployed to multiple hosts. List of all hosts is returned after deployment..</param>
        /// <param name="type">Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host..</param>
        public CertificateDetails(string certFileName = default(string), string expiryDate = default(string), List<string> hostIps = default(List<string>), TypeEnum? type = default(TypeEnum?))
        {
            this.CertFileName = certFileName;
            this.ExpiryDate = expiryDate;
            this.HostIps = hostIps;
            this.Type = type;
            this.CertFileName = certFileName;
            this.ExpiryDate = expiryDate;
            this.HostIps = hostIps;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the filename of the certificate. This is unique to each certificate generated.
        /// </summary>
        /// <value>Specifies the filename of the certificate. This is unique to each certificate generated.</value>
        [DataMember(Name="certFileName", EmitDefaultValue=true)]
        public string CertFileName { get; set; }

        /// <summary>
        /// Specifies the date in epoch till when the certificate is valid.
        /// </summary>
        /// <value>Specifies the date in epoch till when the certificate is valid.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=true)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Each certificate can be deployed to multiple hosts. List of all hosts is returned after deployment.
        /// </summary>
        /// <value>Each certificate can be deployed to multiple hosts. List of all hosts is returned after deployment.</value>
        [DataMember(Name="hostIps", EmitDefaultValue=true)]
        public List<string> HostIps { get; set; }

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
            return this.Equals(input as CertificateDetails);
        }

        /// <summary>
        /// Returns true if CertificateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertFileName == input.CertFileName ||
                    (this.CertFileName != null &&
                    this.CertFileName.Equals(input.CertFileName))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.HostIps == input.HostIps ||
                    this.HostIps != null &&
                    input.HostIps != null &&
                    this.HostIps.SequenceEqual(input.HostIps)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.CertFileName != null)
                    hashCode = hashCode * 59 + this.CertFileName.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.HostIps != null)
                    hashCode = hashCode * 59 + this.HostIps.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

