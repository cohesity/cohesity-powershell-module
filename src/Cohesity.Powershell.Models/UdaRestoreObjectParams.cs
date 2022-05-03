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
    /// UdaRestoreObjectParams
    /// </summary>
    [DataContract]
    public partial class UdaRestoreObjectParams :  IEquatable<UdaRestoreObjectParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UdaRestoreObjectParams" /> class.
        /// </summary>
        /// <param name="newObjectName">The new name of the object, if it is going to be renamed..</param>
        /// <param name="overwrite">Whether to overwrite or keep the object if the object being recovered already exists in the destination..</param>
        /// <param name="restoreTimeSecs">The point-in-time to which object needs to be restored. This allows for the granular recovery of Uda objects. If this is not set, the Uda object will be restored to full/incremental snapshot..</param>
        public UdaRestoreObjectParams(string newObjectName = default(string), bool? overwrite = default(bool?), long? restoreTimeSecs = default(long?))
        {
            this.NewObjectName = newObjectName;
            this.Overwrite = overwrite;
            this.RestoreTimeSecs = restoreTimeSecs;
        }
        
        /// <summary>
        /// The new name of the object, if it is going to be renamed.
        /// </summary>
        /// <value>The new name of the object, if it is going to be renamed.</value>
        [DataMember(Name="newObjectName", EmitDefaultValue=false)]
        public string NewObjectName { get; set; }

        /// <summary>
        /// Whether to overwrite or keep the object if the object being recovered already exists in the destination.
        /// </summary>
        /// <value>Whether to overwrite or keep the object if the object being recovered already exists in the destination.</value>
        [DataMember(Name="overwrite", EmitDefaultValue=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// The point-in-time to which object needs to be restored. This allows for the granular recovery of Uda objects. If this is not set, the Uda object will be restored to full/incremental snapshot.
        /// </summary>
        /// <value>The point-in-time to which object needs to be restored. This allows for the granular recovery of Uda objects. If this is not set, the Uda object will be restored to full/incremental snapshot.</value>
        [DataMember(Name="restoreTimeSecs", EmitDefaultValue=false)]
        public long? RestoreTimeSecs { get; set; }

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
            return this.Equals(input as UdaRestoreObjectParams);
        }

        /// <summary>
        /// Returns true if UdaRestoreObjectParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UdaRestoreObjectParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UdaRestoreObjectParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewObjectName == input.NewObjectName ||
                    (this.NewObjectName != null &&
                    this.NewObjectName.Equals(input.NewObjectName))
                ) && 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
                ) && 
                (
                    this.RestoreTimeSecs == input.RestoreTimeSecs ||
                    (this.RestoreTimeSecs != null &&
                    this.RestoreTimeSecs.Equals(input.RestoreTimeSecs))
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
                if (this.NewObjectName != null)
                    hashCode = hashCode * 59 + this.NewObjectName.GetHashCode();
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.RestoreTimeSecs != null)
                    hashCode = hashCode * 59 + this.RestoreTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

