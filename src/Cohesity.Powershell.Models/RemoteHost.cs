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
    /// Specifies the settings required to connect to a remote host.
    /// </summary>
    [DataContract]
    public partial class RemoteHost :  IEquatable<RemoteHost>
    {
        /// <summary>
        /// Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 6,

            /// <summary>
            /// Enum KCockroachDB for value: kCockroachDB
            /// </summary>
            [EnumMember(Value = "kCockroachDB")]
            KCockroachDB = 7,

            /// <summary>
            /// Enum KMySQL for value: kMySQL
            /// </summary>
            [EnumMember(Value = "kMySQL")]
            KMySQL = 8,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 9,

            /// <summary>
            /// Enum KSapSybase for value: kSapSybase
            /// </summary>
            [EnumMember(Value = "kSapSybase")]
            KSapSybase = 10,

            /// <summary>
            /// Enum KSapMaxDB for value: kSapMaxDB
            /// </summary>
            [EnumMember(Value = "kSapMaxDB")]
            KSapMaxDB = 11,

            /// <summary>
            /// Enum KSapSybaseIQ for value: kSapSybaseIQ
            /// </summary>
            [EnumMember(Value = "kSapSybaseIQ")]
            KSapSybaseIQ = 12,

            /// <summary>
            /// Enum KDB2 for value: kDB2
            /// </summary>
            [EnumMember(Value = "kDB2")]
            KDB2 = 13,

            /// <summary>
            /// Enum KSapASE for value: kSapASE
            /// </summary>
            [EnumMember(Value = "kSapASE")]
            KSapASE = 14,

            /// <summary>
            /// Enum KMariaDB for value: kMariaDB
            /// </summary>
            [EnumMember(Value = "kMariaDB")]
            KMariaDB = 15,

            /// <summary>
            /// Enum KPostgreSQL for value: kPostgreSQL
            /// </summary>
            [EnumMember(Value = "kPostgreSQL")]
            KPostgreSQL = 16,

            /// <summary>
            /// Enum KVOS for value: kVOS
            /// </summary>
            [EnumMember(Value = "kVOS")]
            KVOS = 17,

            /// <summary>
            /// Enum KHPUX for value: kHPUX
            /// </summary>
            [EnumMember(Value = "kHPUX")]
            KHPUX = 18

        }

        /// <summary>
        /// Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteHost" /> class.
        /// </summary>
        /// <param name="address">Specifies the address (IP, hostname or FQDN) of the remote host that will run the script..</param>
        /// <param name="type">Specifies the OS type of the remote host that will run the script. Currently only &#39;kLinux&#39; is supported. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        public RemoteHost(string address = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Address = address;
            this.Type = type;
            this.Address = address;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the address (IP, hostname or FQDN) of the remote host that will run the script.
        /// </summary>
        /// <value>Specifies the address (IP, hostname or FQDN) of the remote host that will run the script.</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

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
            return this.Equals(input as RemoteHost);
        }

        /// <summary>
        /// Returns true if RemoteHost instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteHost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteHost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

