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
    /// Specifies an Application Server and the Protection Source that registered the Application Server.
    /// </summary>
    [DataContract]
    public partial class RegisteredApplicationServer :  IEquatable<RegisteredApplicationServer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredApplicationServer" /> class.
        /// </summary>
        /// <param name="applicationServer">Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM..</param>
        /// <param name="registeredProtectionSource">Specifies the Protection Source like a VM or Physical Server that registered the Application Server..</param>
        public RegisteredApplicationServer(ProtectionSourceNode applicationServer = default(ProtectionSourceNode), ProtectionSource registeredProtectionSource = default(ProtectionSource))
        {
            this.ApplicationServer = applicationServer;
            this.RegisteredProtectionSource = registeredProtectionSource;
        }
        
        /// <summary>
        /// Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.
        /// </summary>
        /// <value>Specifies the child subtree used to store additional application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM.</value>
        [DataMember(Name="applicationServer", EmitDefaultValue=true)]
        public ProtectionSourceNode ApplicationServer { get; set; }

        /// <summary>
        /// Specifies the Protection Source like a VM or Physical Server that registered the Application Server.
        /// </summary>
        /// <value>Specifies the Protection Source like a VM or Physical Server that registered the Application Server.</value>
        [DataMember(Name="registeredProtectionSource", EmitDefaultValue=true)]
        public ProtectionSource RegisteredProtectionSource { get; set; }

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
            return this.Equals(input as RegisteredApplicationServer);
        }

        /// <summary>
        /// Returns true if RegisteredApplicationServer instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredApplicationServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredApplicationServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationServer == input.ApplicationServer ||
                    (this.ApplicationServer != null &&
                    this.ApplicationServer.Equals(input.ApplicationServer))
                ) && 
                (
                    this.RegisteredProtectionSource == input.RegisteredProtectionSource ||
                    (this.RegisteredProtectionSource != null &&
                    this.RegisteredProtectionSource.Equals(input.RegisteredProtectionSource))
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
                if (this.ApplicationServer != null)
                    hashCode = hashCode * 59 + this.ApplicationServer.GetHashCode();
                if (this.RegisteredProtectionSource != null)
                    hashCode = hashCode * 59 + this.RegisteredProtectionSource.GetHashCode();
                return hashCode;
            }
        }

    }

}

