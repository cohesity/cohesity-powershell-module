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
    /// Specifies the request to create a restore task for restoring Application Servers like SQL or Exchange servers hosted by a Protection Source.
    /// </summary>
    [DataContract]
    public partial class ApplicationsRestoreTaskRequest :  IEquatable<ApplicationsRestoreTaskRequest>
    {
        /// <summary>
        /// Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true
        /// </summary>
        /// <value>Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationEnvironmentEnum
        {
            
            /// <summary>
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 1,
            
            /// <summary>
            /// Enum KExchange for value: kExchange
            /// </summary>
            [EnumMember(Value = "kExchange")]
            KExchange = 2
        }

        /// <summary>
        /// Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true
        /// </summary>
        /// <value>Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true</value>
        [DataMember(Name="applicationEnvironment", EmitDefaultValue=false)]
        public ApplicationEnvironmentEnum ApplicationEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsRestoreTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationsRestoreTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsRestoreTaskRequest" /> class.
        /// </summary>
        /// <param name="applicationEnvironment">Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true (required).</param>
        /// <param name="applicationRestoreObjects">Specifies the Application Server objects whose data should be restored and the restore parameters for each of them..</param>
        /// <param name="hostingProtectionSource">Specifies the restore information for the Protection Source object that registered and hosts the Application Servers. This provides the snapshot details from which the applications should be restored. (required).</param>
        /// <param name="name">Specifies a name for the new task to be created. This field has to be set, and it needs to be unique across all restore tasks. (required).</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vlanParameters">Specifies VLAN parameters for the restore operation..</param>
        public ApplicationsRestoreTaskRequest(ApplicationEnvironmentEnum applicationEnvironment = default(ApplicationEnvironmentEnum), List<ApplicationRestoreObject> applicationRestoreObjects = default(List<ApplicationRestoreObject>), RestoreObject hostingProtectionSource = default(RestoreObject), string name = default(string), string password = default(string), string username = default(string), VlanParameters vlanParameters = default(VlanParameters))
        {
            // to ensure "applicationEnvironment" is required (not null)
            if (applicationEnvironment == null)
            {
                throw new InvalidDataException("applicationEnvironment is a required property for ApplicationsRestoreTaskRequest and cannot be null");
            }
            else
            {
                this.ApplicationEnvironment = applicationEnvironment;
            }
            // to ensure "hostingProtectionSource" is required (not null)
            if (hostingProtectionSource == null)
            {
                throw new InvalidDataException("hostingProtectionSource is a required property for ApplicationsRestoreTaskRequest and cannot be null");
            }
            else
            {
                this.HostingProtectionSource = hostingProtectionSource;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ApplicationsRestoreTaskRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.ApplicationRestoreObjects = applicationRestoreObjects;
            this.Password = password;
            this.Username = username;
            this.VlanParameters = vlanParameters;
        }
        

        /// <summary>
        /// Specifies the Application Server objects whose data should be restored and the restore parameters for each of them.
        /// </summary>
        /// <value>Specifies the Application Server objects whose data should be restored and the restore parameters for each of them.</value>
        [DataMember(Name="applicationRestoreObjects", EmitDefaultValue=false)]
        public List<ApplicationRestoreObject> ApplicationRestoreObjects { get; set; }

        /// <summary>
        /// Specifies the restore information for the Protection Source object that registered and hosts the Application Servers. This provides the snapshot details from which the applications should be restored.
        /// </summary>
        /// <value>Specifies the restore information for the Protection Source object that registered and hosts the Application Servers. This provides the snapshot details from which the applications should be restored.</value>
        [DataMember(Name="hostingProtectionSource", EmitDefaultValue=false)]
        public RestoreObject HostingProtectionSource { get; set; }

        /// <summary>
        /// Specifies a name for the new task to be created. This field has to be set, and it needs to be unique across all restore tasks.
        /// </summary>
        /// <value>Specifies a name for the new task to be created. This field has to be set, and it needs to be unique across all restore tasks.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Specifies VLAN parameters for the restore operation.
        /// </summary>
        /// <value>Specifies VLAN parameters for the restore operation.</value>
        [DataMember(Name="vlanParameters", EmitDefaultValue=false)]
        public VlanParameters VlanParameters { get; set; }

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
            return this.Equals(input as ApplicationsRestoreTaskRequest);
        }

        /// <summary>
        /// Returns true if ApplicationsRestoreTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsRestoreTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsRestoreTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationEnvironment == input.ApplicationEnvironment ||
                    (this.ApplicationEnvironment != null &&
                    this.ApplicationEnvironment.Equals(input.ApplicationEnvironment))
                ) && 
                (
                    this.ApplicationRestoreObjects == input.ApplicationRestoreObjects ||
                    this.ApplicationRestoreObjects != null &&
                    this.ApplicationRestoreObjects.SequenceEqual(input.ApplicationRestoreObjects)
                ) && 
                (
                    this.HostingProtectionSource == input.HostingProtectionSource ||
                    (this.HostingProtectionSource != null &&
                    this.HostingProtectionSource.Equals(input.HostingProtectionSource))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VlanParameters == input.VlanParameters ||
                    (this.VlanParameters != null &&
                    this.VlanParameters.Equals(input.VlanParameters))
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
                if (this.ApplicationEnvironment != null)
                    hashCode = hashCode * 59 + this.ApplicationEnvironment.GetHashCode();
                if (this.ApplicationRestoreObjects != null)
                    hashCode = hashCode * 59 + this.ApplicationRestoreObjects.GetHashCode();
                if (this.HostingProtectionSource != null)
                    hashCode = hashCode * 59 + this.HostingProtectionSource.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VlanParameters != null)
                    hashCode = hashCode * 59 + this.VlanParameters.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

