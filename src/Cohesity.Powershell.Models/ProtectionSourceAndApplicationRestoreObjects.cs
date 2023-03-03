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
    /// Specifies the details about the protection source and snapshot from where the application objects must be restored. It also provides information about the application objects which have to be restored and target host to which the application objects must be restored.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceAndApplicationRestoreObjects :  IEquatable<ProtectionSourceAndApplicationRestoreObjects>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceAndApplicationRestoreObjects" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProtectionSourceAndApplicationRestoreObjects() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceAndApplicationRestoreObjects" /> class.
        /// </summary>
        /// <param name="applicationRestoreObjects">Specifies the Application Server objects whose data should be restored and the restore parameters for each of them..</param>
        /// <param name="hostingProtectionSource">hostingProtectionSource (required).</param>
        public ProtectionSourceAndApplicationRestoreObjects(List<ApplicationRestoreObject> applicationRestoreObjects = default(List<ApplicationRestoreObject>), RestoreObjectDetails hostingProtectionSource = default(RestoreObjectDetails))
        {
            this.ApplicationRestoreObjects = applicationRestoreObjects;
            // to ensure "hostingProtectionSource" is required (not null)
            if (hostingProtectionSource == null)
            {
                throw new InvalidDataException("hostingProtectionSource is a required property for ProtectionSourceAndApplicationRestoreObjects and cannot be null");
            }
            else
            {
                this.HostingProtectionSource = hostingProtectionSource;
            }

            this.ApplicationRestoreObjects = applicationRestoreObjects;
        }
        
        /// <summary>
        /// Specifies the Application Server objects whose data should be restored and the restore parameters for each of them.
        /// </summary>
        /// <value>Specifies the Application Server objects whose data should be restored and the restore parameters for each of them.</value>
        [DataMember(Name="applicationRestoreObjects", EmitDefaultValue=true)]
        public List<ApplicationRestoreObject> ApplicationRestoreObjects { get; set; }

        /// <summary>
        /// Gets or Sets HostingProtectionSource
        /// </summary>
        [DataMember(Name="hostingProtectionSource", EmitDefaultValue=false)]
        public RestoreObjectDetails HostingProtectionSource { get; set; }

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
            return this.Equals(input as ProtectionSourceAndApplicationRestoreObjects);
        }

        /// <summary>
        /// Returns true if ProtectionSourceAndApplicationRestoreObjects instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceAndApplicationRestoreObjects to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceAndApplicationRestoreObjects input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationRestoreObjects == input.ApplicationRestoreObjects ||
                    this.ApplicationRestoreObjects != null &&
                    input.ApplicationRestoreObjects != null &&
                    this.ApplicationRestoreObjects.SequenceEqual(input.ApplicationRestoreObjects)
                ) && 
                (
                    this.HostingProtectionSource == input.HostingProtectionSource ||
                    (this.HostingProtectionSource != null &&
                    this.HostingProtectionSource.Equals(input.HostingProtectionSource))
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
                if (this.ApplicationRestoreObjects != null)
                    hashCode = hashCode * 59 + this.ApplicationRestoreObjects.GetHashCode();
                if (this.HostingProtectionSource != null)
                    hashCode = hashCode * 59 + this.HostingProtectionSource.GetHashCode();
                return hashCode;
            }
        }

    }

}

