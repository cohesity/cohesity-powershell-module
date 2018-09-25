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
    /// Specifies basic information about the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class BasicClusterInfo :  IEquatable<BasicClusterInfo>
    {
        /// <summary>
        /// Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterTypeEnum
        {
            
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 1,
            
            /// <summary>
            /// Enum KVirtualRobo for value: kVirtualRobo
            /// </summary>
            [EnumMember(Value = "kVirtualRobo")]
            KVirtualRobo = 2,
            
            /// <summary>
            /// Enum KMicrosoftCloud for value: kMicrosoftCloud
            /// </summary>
            [EnumMember(Value = "kMicrosoftCloud")]
            KMicrosoftCloud = 3,
            
            /// <summary>
            /// Enum KAmazonCloud for value: kAmazonCloud
            /// </summary>
            [EnumMember(Value = "kAmazonCloud")]
            KAmazonCloud = 4,
            
            /// <summary>
            /// Enum KGoogleCloud for value: kGoogleCloud
            /// </summary>
            [EnumMember(Value = "kGoogleCloud")]
            KGoogleCloud = 5
        }

        /// <summary>
        /// Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [DataMember(Name="clusterType", EmitDefaultValue=false)]
        public ClusterTypeEnum? ClusterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicClusterInfo" /> class.
        /// </summary>
        /// <param name="clusterSoftwareVersion">Specifies the current release of the Cohesity software running on this Cohesity Cluster..</param>
        /// <param name="clusterType">Specifies the type of Cohesity Cluster. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition..</param>
        /// <param name="domains">Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users..</param>
        /// <param name="languageLocale">Specifies the language and locale for the Cohesity Cluster..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        public BasicClusterInfo(string clusterSoftwareVersion = default(string), ClusterTypeEnum? clusterType = default(ClusterTypeEnum?), List<string> domains = default(List<string>), string languageLocale = default(string), string name = default(string))
        {
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.Domains = domains;
            this.LanguageLocale = languageLocale;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the current release of the Cohesity software running on this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current release of the Cohesity software running on this Cohesity Cluster.</value>
        [DataMember(Name="clusterSoftwareVersion", EmitDefaultValue=false)]
        public string ClusterSoftwareVersion { get; set; }


        /// <summary>
        /// Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users.
        /// </summary>
        /// <value>Specifies a list of domains joined to the Cohesity Cluster, including the default LOCAL Cohesity domain used to store the local Cohesity users.</value>
        [DataMember(Name="domains", EmitDefaultValue=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Specifies the language and locale for the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for the Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=false)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Specifies the name of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cohesity Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            return this.Equals(input as BasicClusterInfo);
        }

        /// <summary>
        /// Returns true if BasicClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicClusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterSoftwareVersion == input.ClusterSoftwareVersion ||
                    (this.ClusterSoftwareVersion != null &&
                    this.ClusterSoftwareVersion.Equals(input.ClusterSoftwareVersion))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.LanguageLocale == input.LanguageLocale ||
                    (this.LanguageLocale != null &&
                    this.LanguageLocale.Equals(input.LanguageLocale))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ClusterSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSoftwareVersion.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

