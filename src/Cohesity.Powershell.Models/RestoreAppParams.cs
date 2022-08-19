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
    /// This message captures all the necessary arguments specified by the user to restore an application.
    /// </summary>
    [DataContract]
    public partial class RestoreAppParams :  IEquatable<RestoreAppParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAppParams" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="ownerRestoreInfo">ownerRestoreInfo.</param>
        /// <param name="restoreAppObjectVec">The application level objects that needs to be restored. If this vector is populated with exactly one object without its &#39;app_entity&#39;, all the application objects of the owner will be restored. If multiple objects are being restored, the &#39;app_entity&#39; field must be specified for all of them..</param>
        /// <param name="type">The application environment..</param>
        public RestoreAppParams(Credentials credentials = default(Credentials), AppOwnerRestoreInfo ownerRestoreInfo = default(AppOwnerRestoreInfo), List<RestoreAppObject> restoreAppObjectVec = default(List<RestoreAppObject>), int? type = default(int?))
        {
            this.RestoreAppObjectVec = restoreAppObjectVec;
            this.Type = type;
            this.Credentials = credentials;
            this.OwnerRestoreInfo = ownerRestoreInfo;
            this.RestoreAppObjectVec = restoreAppObjectVec;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets OwnerRestoreInfo
        /// </summary>
        [DataMember(Name="ownerRestoreInfo", EmitDefaultValue=false)]
        public AppOwnerRestoreInfo OwnerRestoreInfo { get; set; }

        /// <summary>
        /// The application level objects that needs to be restored. If this vector is populated with exactly one object without its &#39;app_entity&#39;, all the application objects of the owner will be restored. If multiple objects are being restored, the &#39;app_entity&#39; field must be specified for all of them.
        /// </summary>
        /// <value>The application level objects that needs to be restored. If this vector is populated with exactly one object without its &#39;app_entity&#39;, all the application objects of the owner will be restored. If multiple objects are being restored, the &#39;app_entity&#39; field must be specified for all of them.</value>
        [DataMember(Name="restoreAppObjectVec", EmitDefaultValue=true)]
        public List<RestoreAppObject> RestoreAppObjectVec { get; set; }

        /// <summary>
        /// The application environment.
        /// </summary>
        /// <value>The application environment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as RestoreAppParams);
        }

        /// <summary>
        /// Returns true if RestoreAppParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAppParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAppParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.OwnerRestoreInfo == input.OwnerRestoreInfo ||
                    (this.OwnerRestoreInfo != null &&
                    this.OwnerRestoreInfo.Equals(input.OwnerRestoreInfo))
                ) && 
                (
                    this.RestoreAppObjectVec == input.RestoreAppObjectVec ||
                    this.RestoreAppObjectVec != null &&
                    input.RestoreAppObjectVec != null &&
                    this.RestoreAppObjectVec.Equals(input.RestoreAppObjectVec)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.OwnerRestoreInfo != null)
                    hashCode = hashCode * 59 + this.OwnerRestoreInfo.GetHashCode();
                if (this.RestoreAppObjectVec != null)
                    hashCode = hashCode * 59 + this.RestoreAppObjectVec.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

