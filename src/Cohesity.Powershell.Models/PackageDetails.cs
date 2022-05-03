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
    /// Specifies all of the details of a package that is currently installed on the cluster.
    /// </summary>
    [DataContract]
    public partial class PackageDetails :  IEquatable<PackageDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDetails" /> class.
        /// </summary>
        /// <param name="downtimeRequired">Specifies whether or not downtime is required to update to this package..</param>
        /// <param name="installedOnNodes">Specifies the list of IDs of nodes on the cluster where this package is currently installed..</param>
        /// <param name="packageName">Specifies the name of the current package..</param>
        /// <param name="releaseDate">Specifies the release date of this package..</param>
        public PackageDetails(bool? downtimeRequired = default(bool?), List<long?> installedOnNodes = default(List<long?>), string packageName = default(string), string releaseDate = default(string))
        {
            this.DowntimeRequired = downtimeRequired;
            this.InstalledOnNodes = installedOnNodes;
            this.PackageName = packageName;
            this.ReleaseDate = releaseDate;
        }
        
        /// <summary>
        /// Specifies whether or not downtime is required to update to this package.
        /// </summary>
        /// <value>Specifies whether or not downtime is required to update to this package.</value>
        [DataMember(Name="downtimeRequired", EmitDefaultValue=false)]
        public bool? DowntimeRequired { get; set; }

        /// <summary>
        /// Specifies the list of IDs of nodes on the cluster where this package is currently installed.
        /// </summary>
        /// <value>Specifies the list of IDs of nodes on the cluster where this package is currently installed.</value>
        [DataMember(Name="installedOnNodes", EmitDefaultValue=false)]
        public List<long?> InstalledOnNodes { get; set; }

        /// <summary>
        /// Specifies the name of the current package.
        /// </summary>
        /// <value>Specifies the name of the current package.</value>
        [DataMember(Name="packageName", EmitDefaultValue=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// Specifies the release date of this package.
        /// </summary>
        /// <value>Specifies the release date of this package.</value>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public string ReleaseDate { get; set; }

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
            return this.Equals(input as PackageDetails);
        }

        /// <summary>
        /// Returns true if PackageDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DowntimeRequired == input.DowntimeRequired ||
                    (this.DowntimeRequired != null &&
                    this.DowntimeRequired.Equals(input.DowntimeRequired))
                ) && 
                (
                    this.InstalledOnNodes == input.InstalledOnNodes ||
                    this.InstalledOnNodes != null &&
                    this.InstalledOnNodes.Equals(input.InstalledOnNodes)
                ) && 
                (
                    this.PackageName == input.PackageName ||
                    (this.PackageName != null &&
                    this.PackageName.Equals(input.PackageName))
                ) && 
                (
                    this.ReleaseDate == input.ReleaseDate ||
                    (this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(input.ReleaseDate))
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
                if (this.DowntimeRequired != null)
                    hashCode = hashCode * 59 + this.DowntimeRequired.GetHashCode();
                if (this.InstalledOnNodes != null)
                    hashCode = hashCode * 59 + this.InstalledOnNodes.GetHashCode();
                if (this.PackageName != null)
                    hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.ReleaseDate != null)
                    hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                return hashCode;
            }
        }

    }

}

