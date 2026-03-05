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
    /// Specifies the parameters for performing various action on NoSQL app instance.
    /// </summary>
    [DataContract]
    public partial class NoSqlAppActionsParameters :  IEquatable<NoSqlAppActionsParameters>
    {
        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kRefreshConfig&#39; Refreshes xml configs for site files for NoSql App from Gandalf. &#39;kListConfig&#39; List xml Configs set in site files using GFlag approach. &#39;kRestartServices&#39; restart App services. e.g yarn, zookeeper etc. &#39;kSSLImport&#39; Import ssl certificates to App&#39;s TrustStore/Keystore. &#39;kSSLListCertificates&#39; List ssl certificates from Keystore/TrustStore. &#39;kSSLDeleteCertificate&#39; Delete specific certificates from TrustStore. &#39;kSSLDeleteStore&#39; Delete trustore/keystore from App. &#39;kKerberosAddrealm&#39; Add kerberos realm. &#39;kKerberosDeleteRealm&#39; Delete kerberos realm. &#39;kKerberosImportKeyTab&#39; Import keytab.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kRefreshConfig&#39; Refreshes xml configs for site files for NoSql App from Gandalf. &#39;kListConfig&#39; List xml Configs set in site files using GFlag approach. &#39;kRestartServices&#39; restart App services. e.g yarn, zookeeper etc. &#39;kSSLImport&#39; Import ssl certificates to App&#39;s TrustStore/Keystore. &#39;kSSLListCertificates&#39; List ssl certificates from Keystore/TrustStore. &#39;kSSLDeleteCertificate&#39; Delete specific certificates from TrustStore. &#39;kSSLDeleteStore&#39; Delete trustore/keystore from App. &#39;kKerberosAddrealm&#39; Add kerberos realm. &#39;kKerberosDeleteRealm&#39; Delete kerberos realm. &#39;kKerberosImportKeyTab&#39; Import keytab.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum KRefreshConfig for value: kRefreshConfig
            /// </summary>
            [EnumMember(Value = "kRefreshConfig")]
            KRefreshConfig = 1,

            /// <summary>
            /// Enum KListConfig for value: kListConfig
            /// </summary>
            [EnumMember(Value = "kListConfig")]
            KListConfig = 2,

            /// <summary>
            /// Enum KRestartServices for value: kRestartServices
            /// </summary>
            [EnumMember(Value = "kRestartServices")]
            KRestartServices = 3,

            /// <summary>
            /// Enum KSSLImport for value: kSSLImport
            /// </summary>
            [EnumMember(Value = "kSSLImport")]
            KSSLImport = 4,

            /// <summary>
            /// Enum KSSLListCertificates for value: kSSLListCertificates
            /// </summary>
            [EnumMember(Value = "kSSLListCertificates")]
            KSSLListCertificates = 5,

            /// <summary>
            /// Enum KSSLDeleteCertificate for value: kSSLDeleteCertificate
            /// </summary>
            [EnumMember(Value = "kSSLDeleteCertificate")]
            KSSLDeleteCertificate = 6,

            /// <summary>
            /// Enum KSSLDeleteStore for value: kSSLDeleteStore
            /// </summary>
            [EnumMember(Value = "kSSLDeleteStore")]
            KSSLDeleteStore = 7,

            /// <summary>
            /// Enum KKerberosAddrealm for value: kKerberosAddrealm
            /// </summary>
            [EnumMember(Value = "kKerberosAddrealm")]
            KKerberosAddrealm = 8,

            /// <summary>
            /// Enum KKerberosDeleteRealm for value: kKerberosDeleteRealm
            /// </summary>
            [EnumMember(Value = "kKerberosDeleteRealm")]
            KKerberosDeleteRealm = 9,

            /// <summary>
            /// Enum KKerberosImportKeyTab for value: kKerberosImportKeyTab
            /// </summary>
            [EnumMember(Value = "kKerberosImportKeyTab")]
            KKerberosImportKeyTab = 10

        }

        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kRefreshConfig&#39; Refreshes xml configs for site files for NoSql App from Gandalf. &#39;kListConfig&#39; List xml Configs set in site files using GFlag approach. &#39;kRestartServices&#39; restart App services. e.g yarn, zookeeper etc. &#39;kSSLImport&#39; Import ssl certificates to App&#39;s TrustStore/Keystore. &#39;kSSLListCertificates&#39; List ssl certificates from Keystore/TrustStore. &#39;kSSLDeleteCertificate&#39; Delete specific certificates from TrustStore. &#39;kSSLDeleteStore&#39; Delete trustore/keystore from App. &#39;kKerberosAddrealm&#39; Add kerberos realm. &#39;kKerberosDeleteRealm&#39; Delete kerberos realm. &#39;kKerberosImportKeyTab&#39; Import keytab.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kRefreshConfig&#39; Refreshes xml configs for site files for NoSql App from Gandalf. &#39;kListConfig&#39; List xml Configs set in site files using GFlag approach. &#39;kRestartServices&#39; restart App services. e.g yarn, zookeeper etc. &#39;kSSLImport&#39; Import ssl certificates to App&#39;s TrustStore/Keystore. &#39;kSSLListCertificates&#39; List ssl certificates from Keystore/TrustStore. &#39;kSSLDeleteCertificate&#39; Delete specific certificates from TrustStore. &#39;kSSLDeleteStore&#39; Delete trustore/keystore from App. &#39;kKerberosAddrealm&#39; Add kerberos realm. &#39;kKerberosDeleteRealm&#39; Delete kerberos realm. &#39;kKerberosImportKeyTab&#39; Import keytab.</value>
        [DataMember(Name="action", EmitDefaultValue=true)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSqlAppActionsParameters" /> class.
        /// </summary>
        /// <param name="action">Specifies the current Cluster-level operation in progress. &#39;kRefreshConfig&#39; Refreshes xml configs for site files for NoSql App from Gandalf. &#39;kListConfig&#39; List xml Configs set in site files using GFlag approach. &#39;kRestartServices&#39; restart App services. e.g yarn, zookeeper etc. &#39;kSSLImport&#39; Import ssl certificates to App&#39;s TrustStore/Keystore. &#39;kSSLListCertificates&#39; List ssl certificates from Keystore/TrustStore. &#39;kSSLDeleteCertificate&#39; Delete specific certificates from TrustStore. &#39;kSSLDeleteStore&#39; Delete trustore/keystore from App. &#39;kKerberosAddrealm&#39; Add kerberos realm. &#39;kKerberosDeleteRealm&#39; Delete kerberos realm. &#39;kKerberosImportKeyTab&#39; Import keytab..</param>
        /// <param name="listConfigParams">listConfigParams.</param>
        /// <param name="restartServicesParams">restartServicesParams.</param>
        public NoSqlAppActionsParameters(ActionEnum? action = default(ActionEnum?), ListConfigParams listConfigParams = default(ListConfigParams), RestartServicesParams restartServicesParams = default(RestartServicesParams))
        {
            this.Action = action;
            this.Action = action;
            this.ListConfigParams = listConfigParams;
            this.RestartServicesParams = restartServicesParams;
        }
        
        /// <summary>
        /// Gets or Sets ListConfigParams
        /// </summary>
        [DataMember(Name="listConfigParams", EmitDefaultValue=false)]
        public ListConfigParams ListConfigParams { get; set; }

        /// <summary>
        /// Gets or Sets RestartServicesParams
        /// </summary>
        [DataMember(Name="restartServicesParams", EmitDefaultValue=false)]
        public RestartServicesParams RestartServicesParams { get; set; }

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
            return this.Equals(input as NoSqlAppActionsParameters);
        }

        /// <summary>
        /// Returns true if NoSqlAppActionsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSqlAppActionsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSqlAppActionsParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ListConfigParams == input.ListConfigParams ||
                    (this.ListConfigParams != null &&
                    this.ListConfigParams.Equals(input.ListConfigParams))
                ) && 
                (
                    this.RestartServicesParams == input.RestartServicesParams ||
                    (this.RestartServicesParams != null &&
                    this.RestartServicesParams.Equals(input.RestartServicesParams))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ListConfigParams != null)
                    hashCode = hashCode * 59 + this.ListConfigParams.GetHashCode();
                if (this.RestartServicesParams != null)
                    hashCode = hashCode * 59 + this.RestartServicesParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

