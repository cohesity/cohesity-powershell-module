// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about the snapshot task created to backup or copy one source object like a VM.
    /// </summary>
    [DataContract]
    public partial class SnapshotInfo :  IEquatable<SnapshotInfo>
    {

        /// <summary>
        /// Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotInfo" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="relativeSnapshotDirectory">Specifies the relative directory path from root path where the snapshot is stored..</param>
        /// <param name="rootPath">Specifies the root path where the snapshot is stored, using the following format: \&quot;/ViewBox/ViewName/fs\&quot;..</param>
        /// <param name="viewName">Specifies the name of the View that is cloned. NOTE: This field is only populated for View cloning..</param>
        public SnapshotInfo(EnvironmentEnum? environment = default(EnvironmentEnum?), string relativeSnapshotDirectory = default(string), string rootPath = default(string), string viewName = default(string))
        {
            this.Environment = environment;
            this.RelativeSnapshotDirectory = relativeSnapshotDirectory;
            this.RootPath = rootPath;
            this.ViewName = viewName;
        }
        

        /// <summary>
        /// Specifies the relative directory path from root path where the snapshot is stored.
        /// </summary>
        /// <value>Specifies the relative directory path from root path where the snapshot is stored.</value>
        [DataMember(Name="relativeSnapshotDirectory", EmitDefaultValue=false)]
        public string RelativeSnapshotDirectory { get; set; }

        /// <summary>
        /// Specifies the root path where the snapshot is stored, using the following format: \&quot;/ViewBox/ViewName/fs\&quot;.
        /// </summary>
        /// <value>Specifies the root path where the snapshot is stored, using the following format: \&quot;/ViewBox/ViewName/fs\&quot;.</value>
        [DataMember(Name="rootPath", EmitDefaultValue=false)]
        public string RootPath { get; set; }

        /// <summary>
        /// Specifies the name of the View that is cloned. NOTE: This field is only populated for View cloning.
        /// </summary>
        /// <value>Specifies the name of the View that is cloned. NOTE: This field is only populated for View cloning.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

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
            return this.Equals(input as SnapshotInfo);
        }

        /// <summary>
        /// Returns true if SnapshotInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.RelativeSnapshotDirectory == input.RelativeSnapshotDirectory ||
                    (this.RelativeSnapshotDirectory != null &&
                    this.RelativeSnapshotDirectory.Equals(input.RelativeSnapshotDirectory))
                ) && 
                (
                    this.RootPath == input.RootPath ||
                    (this.RootPath != null &&
                    this.RootPath.Equals(input.RootPath))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.RelativeSnapshotDirectory != null)
                    hashCode = hashCode * 59 + this.RelativeSnapshotDirectory.GetHashCode();
                if (this.RootPath != null)
                    hashCode = hashCode * 59 + this.RootPath.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

