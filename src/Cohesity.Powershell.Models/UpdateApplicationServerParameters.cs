// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the parameters required to modify the parameters of previously registered Application Servers in a Protection Source.
    /// </summary>
    [DataContract]
    public partial class UpdateApplicationServerParameters :  IEquatable<UpdateApplicationServerParameters>
    {
        /// <summary>
        /// Defines Applications
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationsEnum
        {
            
            /// <summary>
            /// Enum KVMware for value: kVMware
            /// </summary>
            [EnumMember(Value = "kVMware")]
            KVMware = 1,
            
            /// <summary>
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 2,
            
            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 3,
            
            /// <summary>
            /// Enum KPuppeteer for value: kPuppeteer
            /// </summary>
            [EnumMember(Value = "kPuppeteer")]
            KPuppeteer = 4,
            
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 5,
            
            /// <summary>
            /// Enum KPure for value: kPure
            /// </summary>
            [EnumMember(Value = "kPure")]
            KPure = 6,
            
            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 7,
            
            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 8,
            
            /// <summary>
            /// Enum KHyperV for value: kHyperV
            /// </summary>
            [EnumMember(Value = "kHyperV")]
            KHyperV = 9,
            
            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 10,
            
            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 11
        }


        /// <summary>
        /// Specifies the types of applications such as &#39;kSQL&#39;, &#39;kExchange&#39; running on the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the types of applications such as &#39;kSQL&#39;, &#39;kExchange&#39; running on the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<ApplicationsEnum> Applications { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationServerParameters" /> class.
        /// </summary>
        /// <param name="applications">Specifies the types of applications such as &#39;kSQL&#39;, &#39;kExchange&#39; running on the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="hasPersistentAgent">Set this to true if a persistent agent is running on the host. If this is specified, then credentials would not be used to log into the host environment. This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials. If this field is not specified, credentials must be specified..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="protectionSourceId">Specifies the Id of the Protection Source that contains one or more Application Servers running on it..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        public UpdateApplicationServerParameters(List<ApplicationsEnum> applications = default(List<ApplicationsEnum>), bool? hasPersistentAgent = default(bool?), string password = default(string), long? protectionSourceId = default(long?), string username = default(string))
        {
            this.Applications = applications;
            this.HasPersistentAgent = hasPersistentAgent;
            this.Password = password;
            this.ProtectionSourceId = protectionSourceId;
            this.Username = username;
        }
        

        /// <summary>
        /// Set this to true if a persistent agent is running on the host. If this is specified, then credentials would not be used to log into the host environment. This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials. If this field is not specified, credentials must be specified.
        /// </summary>
        /// <value>Set this to true if a persistent agent is running on the host. If this is specified, then credentials would not be used to log into the host environment. This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials. If this field is not specified, credentials must be specified.</value>
        [DataMember(Name="hasPersistentAgent", EmitDefaultValue=false)]
        public bool? HasPersistentAgent { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the Id of the Protection Source that contains one or more Application Servers running on it.
        /// </summary>
        /// <value>Specifies the Id of the Protection Source that contains one or more Application Servers running on it.</value>
        [DataMember(Name="protectionSourceId", EmitDefaultValue=false)]
        public long? ProtectionSourceId { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as UpdateApplicationServerParameters);
        }

        /// <summary>
        /// Returns true if UpdateApplicationServerParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationServerParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationServerParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
                ) && 
                (
                    this.HasPersistentAgent == input.HasPersistentAgent ||
                    (this.HasPersistentAgent != null &&
                    this.HasPersistentAgent.Equals(input.HasPersistentAgent))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ProtectionSourceId == input.ProtectionSourceId ||
                    (this.ProtectionSourceId != null &&
                    this.ProtectionSourceId.Equals(input.ProtectionSourceId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.HasPersistentAgent != null)
                    hashCode = hashCode * 59 + this.HasPersistentAgent.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProtectionSourceId != null)
                    hashCode = hashCode * 59 + this.ProtectionSourceId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

