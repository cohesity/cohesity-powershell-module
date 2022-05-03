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
    /// Specifies information specific to NFS protocol exposed by Pure Flash Blade file system.
    /// </summary>
    [DataContract]
    public partial class FlashBladeNfsInfo :  IEquatable<FlashBladeNfsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeNfsInfo" /> class.
        /// </summary>
        /// <param name="exportRules">Specifies NFS protocol export rules. Rules are in the form host(options). host represents one of the following categories:  IP address in the form ddd.ddd.ddd.ddd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx for IPv6.  Netmask in the form ddd.ddd.ddd.ddd/dd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx/xxx for IPv6.  Wildcard in the form * to represent all clients  options in parenthesis represents a comma-separated list of NFS export options. Valid export options are rw, ro, root_squash, no_root_squash, and fileid_32bit..</param>
        public FlashBladeNfsInfo(string exportRules = default(string))
        {
            this.ExportRules = exportRules;
        }
        
        /// <summary>
        /// Specifies NFS protocol export rules. Rules are in the form host(options). host represents one of the following categories:  IP address in the form ddd.ddd.ddd.ddd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx for IPv6.  Netmask in the form ddd.ddd.ddd.ddd/dd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx/xxx for IPv6.  Wildcard in the form * to represent all clients  options in parenthesis represents a comma-separated list of NFS export options. Valid export options are rw, ro, root_squash, no_root_squash, and fileid_32bit.
        /// </summary>
        /// <value>Specifies NFS protocol export rules. Rules are in the form host(options). host represents one of the following categories:  IP address in the form ddd.ddd.ddd.ddd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx for IPv6.  Netmask in the form ddd.ddd.ddd.ddd/dd for IPv4, or xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx/xxx for IPv6.  Wildcard in the form * to represent all clients  options in parenthesis represents a comma-separated list of NFS export options. Valid export options are rw, ro, root_squash, no_root_squash, and fileid_32bit.</value>
        [DataMember(Name="exportRules", EmitDefaultValue=false)]
        public string ExportRules { get; set; }

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
            return this.Equals(input as FlashBladeNfsInfo);
        }

        /// <summary>
        /// Returns true if FlashBladeNfsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeNfsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeNfsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExportRules == input.ExportRules ||
                    (this.ExportRules != null &&
                    this.ExportRules.Equals(input.ExportRules))
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
                if (this.ExportRules != null)
                    hashCode = hashCode * 59 + this.ExportRules.GetHashCode();
                return hashCode;
            }
        }

    }

}

