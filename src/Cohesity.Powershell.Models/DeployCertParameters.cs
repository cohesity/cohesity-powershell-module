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
    /// Specifies the parameters used to generate and deploy a certificate.
    /// </summary>
    [DataContract]
    public partial class DeployCertParameters :  IEquatable<DeployCertParameters>
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
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployCertParameters" /> class.
        /// </summary>
        /// <param name="certFileName">Specifies the filename of the certificate..</param>
        /// <param name="hostsInfoList">Specifies the list of all hosts on which the certificate is to be deployed..</param>
        /// <param name="type">Specifies the type of the host such as &#39;kSapHana&#39;, &#39;kSapOracle&#39;, etc. Specifies the host type of host for generating and deploying a Certificate. &#39;kOther&#39; indicates it is any of the other hosts. &#39;kSapOracle&#39; indicates it is a SAP Oracle host. &#39;kSapHana&#39; indicates it is a SAP HANA host..</param>
        /// <param name="validDays">Specifies the number of days after which the certificate will expire. The user has to input the number of days (from the current date) till when the certificate is valid..</param>
        public DeployCertParameters(string certFileName = default(string), List<HostInfo> hostsInfoList = default(List<HostInfo>), TypeEnum? type = default(TypeEnum?), long? validDays = default(long?))
        {
            this.CertFileName = certFileName;
            this.HostsInfoList = hostsInfoList;
            this.Type = type;
            this.ValidDays = validDays;
        }
        
        /// <summary>
        /// Specifies the filename of the certificate.
        /// </summary>
        /// <value>Specifies the filename of the certificate.</value>
        [DataMember(Name="certFileName", EmitDefaultValue=false)]
        public string CertFileName { get; set; }

        /// <summary>
        /// Specifies the list of all hosts on which the certificate is to be deployed.
        /// </summary>
        /// <value>Specifies the list of all hosts on which the certificate is to be deployed.</value>
        [DataMember(Name="hostsInfoList", EmitDefaultValue=false)]
        public List<HostInfo> HostsInfoList { get; set; }


        /// <summary>
        /// Specifies the number of days after which the certificate will expire. The user has to input the number of days (from the current date) till when the certificate is valid.
        /// </summary>
        /// <value>Specifies the number of days after which the certificate will expire. The user has to input the number of days (from the current date) till when the certificate is valid.</value>
        [DataMember(Name="validDays", EmitDefaultValue=false)]
        public long? ValidDays { get; set; }

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
            return this.Equals(input as DeployCertParameters);
        }

        /// <summary>
        /// Returns true if DeployCertParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployCertParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployCertParameters input)
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
                    this.HostsInfoList == input.HostsInfoList ||
                    this.HostsInfoList != null &&
                    this.HostsInfoList.Equals(input.HostsInfoList)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValidDays == input.ValidDays ||
                    (this.ValidDays != null &&
                    this.ValidDays.Equals(input.ValidDays))
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
                if (this.HostsInfoList != null)
                    hashCode = hashCode * 59 + this.HostsInfoList.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidDays != null)
                    hashCode = hashCode * 59 + this.ValidDays.GetHashCode();
                return hashCode;
            }
        }

    }

}

