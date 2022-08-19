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
    /// Proto to hold pfile/spfile restore related information
    /// </summary>
    [DataContract]
    public partial class RestoreSpfileOrPfileInfo :  IEquatable<RestoreSpfileOrPfileInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSpfileOrPfileInfo" /> class.
        /// </summary>
        /// <param name="fileLocation">Location where spfile/pfile will be restored. If this is empty and should_restore_spfile_or_pfile is true we restore at default location : $ORACLE_HOME/dbs.</param>
        /// <param name="shouldRestoreSpfileOrPfile">If set to true we first try to restore spfile, if spfile is not available then we try to restore pfile. If set to false we dont restore spfile or pfile. Default value is false, as spfile and pfile contains a lot of system parameters also, so user might not wanna replace his spfile/pfile on overwrite restore..</param>
        public RestoreSpfileOrPfileInfo(string fileLocation = default(string), bool? shouldRestoreSpfileOrPfile = default(bool?))
        {
            this.FileLocation = fileLocation;
            this.ShouldRestoreSpfileOrPfile = shouldRestoreSpfileOrPfile;
            this.FileLocation = fileLocation;
            this.ShouldRestoreSpfileOrPfile = shouldRestoreSpfileOrPfile;
        }
        
        /// <summary>
        /// Location where spfile/pfile will be restored. If this is empty and should_restore_spfile_or_pfile is true we restore at default location : $ORACLE_HOME/dbs
        /// </summary>
        /// <value>Location where spfile/pfile will be restored. If this is empty and should_restore_spfile_or_pfile is true we restore at default location : $ORACLE_HOME/dbs</value>
        [DataMember(Name="fileLocation", EmitDefaultValue=true)]
        public string FileLocation { get; set; }

        /// <summary>
        /// If set to true we first try to restore spfile, if spfile is not available then we try to restore pfile. If set to false we dont restore spfile or pfile. Default value is false, as spfile and pfile contains a lot of system parameters also, so user might not wanna replace his spfile/pfile on overwrite restore.
        /// </summary>
        /// <value>If set to true we first try to restore spfile, if spfile is not available then we try to restore pfile. If set to false we dont restore spfile or pfile. Default value is false, as spfile and pfile contains a lot of system parameters also, so user might not wanna replace his spfile/pfile on overwrite restore.</value>
        [DataMember(Name="shouldRestoreSpfileOrPfile", EmitDefaultValue=true)]
        public bool? ShouldRestoreSpfileOrPfile { get; set; }

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
            return this.Equals(input as RestoreSpfileOrPfileInfo);
        }

        /// <summary>
        /// Returns true if RestoreSpfileOrPfileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreSpfileOrPfileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreSpfileOrPfileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileLocation == input.FileLocation ||
                    (this.FileLocation != null &&
                    this.FileLocation.Equals(input.FileLocation))
                ) && 
                (
                    this.ShouldRestoreSpfileOrPfile == input.ShouldRestoreSpfileOrPfile ||
                    (this.ShouldRestoreSpfileOrPfile != null &&
                    this.ShouldRestoreSpfileOrPfile.Equals(input.ShouldRestoreSpfileOrPfile))
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
                if (this.FileLocation != null)
                    hashCode = hashCode * 59 + this.FileLocation.GetHashCode();
                if (this.ShouldRestoreSpfileOrPfile != null)
                    hashCode = hashCode * 59 + this.ShouldRestoreSpfileOrPfile.GetHashCode();
                return hashCode;
            }
        }

    }

}

