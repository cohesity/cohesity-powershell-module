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
    /// magneto/connectors/kubernetes/kubernetes.proto 102
    /// </summary>
    [DataContract]
    public partial class EntityExternalMetadataProto :  IEquatable<EntityExternalMetadataProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityExternalMetadataProto" /> class.
        /// </summary>
        /// <param name="certificateActions">certificateActions.</param>
        /// <param name="credentialVec">Connector params required to connect to different type of environment..</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="maintenanceModeConfig">maintenanceModeConfig.</param>
        /// <param name="udaParams">udaParams.</param>
        /// <param name="userTagAttributesVec">Tag attributes associated with this entity created by the user via the cohesity UI (to be consumed in future epic)..</param>
        public EntityExternalMetadataProto(CertificateActions certificateActions = default(CertificateActions), List<AppCredentials> credentialVec = default(List<AppCredentials>), Credentials credentials = default(Credentials), MaintenanceModeConfigProto maintenanceModeConfig = default(MaintenanceModeConfigProto), RegisteredEntityUdaParams udaParams = default(RegisteredEntityUdaParams), List<TagAttributeProto> userTagAttributesVec = default(List<TagAttributeProto>))
        {
            this.CredentialVec = credentialVec;
            this.UserTagAttributesVec = userTagAttributesVec;
            this.CertificateActions = certificateActions;
            this.CredentialVec = credentialVec;
            this.Credentials = credentials;
            this.MaintenanceModeConfig = maintenanceModeConfig;
            this.UdaParams = udaParams;
            this.UserTagAttributesVec = userTagAttributesVec;
        }
        
        /// <summary>
        /// Gets or Sets CertificateActions
        /// </summary>
        [DataMember(Name="certificateActions", EmitDefaultValue=false)]
        public CertificateActions CertificateActions { get; set; }

        /// <summary>
        /// Connector params required to connect to different type of environment.
        /// </summary>
        /// <value>Connector params required to connect to different type of environment.</value>
        [DataMember(Name="credentialVec", EmitDefaultValue=true)]
        public List<AppCredentials> CredentialVec { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets MaintenanceModeConfig
        /// </summary>
        [DataMember(Name="maintenanceModeConfig", EmitDefaultValue=false)]
        public MaintenanceModeConfigProto MaintenanceModeConfig { get; set; }

        /// <summary>
        /// Gets or Sets UdaParams
        /// </summary>
        [DataMember(Name="udaParams", EmitDefaultValue=false)]
        public RegisteredEntityUdaParams UdaParams { get; set; }

        /// <summary>
        /// Tag attributes associated with this entity created by the user via the cohesity UI (to be consumed in future epic).
        /// </summary>
        /// <value>Tag attributes associated with this entity created by the user via the cohesity UI (to be consumed in future epic).</value>
        [DataMember(Name="userTagAttributesVec", EmitDefaultValue=true)]
        public List<TagAttributeProto> UserTagAttributesVec { get; set; }

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
            return this.Equals(input as EntityExternalMetadataProto);
        }

        /// <summary>
        /// Returns true if EntityExternalMetadataProto instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityExternalMetadataProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityExternalMetadataProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateActions == input.CertificateActions ||
                    (this.CertificateActions != null &&
                    this.CertificateActions.Equals(input.CertificateActions))
                ) && 
                (
                    this.CredentialVec == input.CredentialVec ||
                    this.CredentialVec != null &&
                    input.CredentialVec != null &&
                    this.CredentialVec.SequenceEqual(input.CredentialVec)
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.MaintenanceModeConfig == input.MaintenanceModeConfig ||
                    (this.MaintenanceModeConfig != null &&
                    this.MaintenanceModeConfig.Equals(input.MaintenanceModeConfig))
                ) && 
                (
                    this.UdaParams == input.UdaParams ||
                    (this.UdaParams != null &&
                    this.UdaParams.Equals(input.UdaParams))
                ) && 
                (
                    this.UserTagAttributesVec == input.UserTagAttributesVec ||
                    this.UserTagAttributesVec != null &&
                    input.UserTagAttributesVec != null &&
                    this.UserTagAttributesVec.SequenceEqual(input.UserTagAttributesVec)
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
                if (this.CertificateActions != null)
                    hashCode = hashCode * 59 + this.CertificateActions.GetHashCode();
                if (this.CredentialVec != null)
                    hashCode = hashCode * 59 + this.CredentialVec.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.MaintenanceModeConfig != null)
                    hashCode = hashCode * 59 + this.MaintenanceModeConfig.GetHashCode();
                if (this.UdaParams != null)
                    hashCode = hashCode * 59 + this.UdaParams.GetHashCode();
                if (this.UserTagAttributesVec != null)
                    hashCode = hashCode * 59 + this.UserTagAttributesVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

