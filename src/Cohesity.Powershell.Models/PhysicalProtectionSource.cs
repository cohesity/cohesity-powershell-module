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
    /// Specifies a Protection Source in a Physical environment.
    /// </summary>
    [DataContract]
    public partial class PhysicalProtectionSource :  IEquatable<PhysicalProtectionSource>
    {
        /// <summary>
        /// Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the type of managed Object in a Physical Protection Source. &#39;kGroup&#39; indicates the EH container. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. &#39;kOracleRACCluster&#39; indicates an Oracle Real Application Cluster(RAC). &#39;kOracleAPCluster&#39; indicates an Oracle Active-Passive Cluster.
        /// </summary>
        /// <value>Specifies the type of managed Object in a Physical Protection Source. &#39;kGroup&#39; indicates the EH container. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. &#39;kOracleRACCluster&#39; indicates an Oracle Real Application Cluster(RAC). &#39;kOracleAPCluster&#39; indicates an Oracle Active-Passive Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 1,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 2,

            /// <summary>
            /// Enum KWindowsCluster for value: kWindowsCluster
            /// </summary>
            [EnumMember(Value = "kWindowsCluster")]
            KWindowsCluster = 3,

            /// <summary>
            /// Enum KOracleRACCluster for value: kOracleRACCluster
            /// </summary>
            [EnumMember(Value = "kOracleRACCluster")]
            KOracleRACCluster = 4,

            /// <summary>
            /// Enum KOracleAPCluster for value: kOracleAPCluster
            /// </summary>
            [EnumMember(Value = "kOracleAPCluster")]
            KOracleAPCluster = 5,

            /// <summary>
            /// Enum KOracleCluster for value: kOracleCluster
            /// </summary>
            [EnumMember(Value = "kOracleCluster")]
            KOracleCluster = 6

        }

        /// <summary>
        /// Specifies the type of managed Object in a Physical Protection Source. &#39;kGroup&#39; indicates the EH container. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. &#39;kOracleRACCluster&#39; indicates an Oracle Real Application Cluster(RAC). &#39;kOracleAPCluster&#39; indicates an Oracle Active-Passive Cluster.
        /// </summary>
        /// <value>Specifies the type of managed Object in a Physical Protection Source. &#39;kGroup&#39; indicates the EH container. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. &#39;kOracleRACCluster&#39; indicates an Oracle Real Application Cluster(RAC). &#39;kOracleAPCluster&#39; indicates an Oracle Active-Passive Cluster.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalProtectionSource" /> class.
        /// </summary>
        /// <param name="agents">Array of Agents on the Physical Protection Source.  Specifiles the agents running on the Physical Protection Source and the status information..</param>
        /// <param name="hostName">Specifies the hostname..</param>
        /// <param name="hostType">Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="id">Specifies a unique id of a Physical Protection Source. The id is unique across Cohesity Clusters..</param>
        /// <param name="memorySizeBytes">Specifies the total memory ont the host in bytes..</param>
        /// <param name="name">Specifies a human readable name of the Protection Source..</param>
        /// <param name="networkingInfo">networkingInfo.</param>
        /// <param name="numProcessors">Specifies the number of processors on the host..</param>
        /// <param name="osName">Specifies a human readable name of the OS of the Protection Source..</param>
        /// <param name="type">Specifies the type of managed Object in a Physical Protection Source. &#39;kGroup&#39; indicates the EH container. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. &#39;kOracleRACCluster&#39; indicates an Oracle Real Application Cluster(RAC). &#39;kOracleAPCluster&#39; indicates an Oracle Active-Passive Cluster..</param>
        /// <param name="vcsVersion">Specifies cluster version for VCS host..</param>
        /// <param name="volumes">Array of Physical Volumes.  Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type..</param>
        public PhysicalProtectionSource(List<AgentInformation> agents = default(List<AgentInformation>), string hostName = default(string), HostTypeEnum? hostType = default(HostTypeEnum?), UniversalId id = default(UniversalId), long? memorySizeBytes = default(long?), string name = default(string), NetworkingInformation networkingInfo = default(NetworkingInformation), long? numProcessors = default(long?), string osName = default(string), TypeEnum? type = default(TypeEnum?), string vcsVersion = default(string), List<PhysicalVolume> volumes = default(List<PhysicalVolume>))
        {
            this.Agents = agents;
            this.HostName = hostName;
            this.HostType = hostType;
            this.Id = id;
            this.MemorySizeBytes = memorySizeBytes;
            this.Name = name;
            this.NumProcessors = numProcessors;
            this.OsName = osName;
            this.Type = type;
            this.VcsVersion = vcsVersion;
            this.Volumes = volumes;
            this.Agents = agents;
            this.HostName = hostName;
            this.HostType = hostType;
            this.Id = id;
            this.MemorySizeBytes = memorySizeBytes;
            this.Name = name;
            this.NetworkingInfo = networkingInfo;
            this.NumProcessors = numProcessors;
            this.OsName = osName;
            this.Type = type;
            this.VcsVersion = vcsVersion;
            this.Volumes = volumes;
        }
        
        /// <summary>
        /// Array of Agents on the Physical Protection Source.  Specifiles the agents running on the Physical Protection Source and the status information.
        /// </summary>
        /// <value>Array of Agents on the Physical Protection Source.  Specifiles the agents running on the Physical Protection Source and the status information.</value>
        [DataMember(Name="agents", EmitDefaultValue=true)]
        public List<AgentInformation> Agents { get; set; }

        /// <summary>
        /// Specifies the hostname.
        /// </summary>
        /// <value>Specifies the hostname.</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Specifies a unique id of a Physical Protection Source. The id is unique across Cohesity Clusters.
        /// </summary>
        /// <value>Specifies a unique id of a Physical Protection Source. The id is unique across Cohesity Clusters.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public UniversalId Id { get; set; }

        /// <summary>
        /// Specifies the total memory ont the host in bytes.
        /// </summary>
        /// <value>Specifies the total memory ont the host in bytes.</value>
        [DataMember(Name="memorySizeBytes", EmitDefaultValue=true)]
        public long? MemorySizeBytes { get; set; }

        /// <summary>
        /// Specifies a human readable name of the Protection Source.
        /// </summary>
        /// <value>Specifies a human readable name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NetworkingInfo
        /// </summary>
        [DataMember(Name="networkingInfo", EmitDefaultValue=false)]
        public NetworkingInformation NetworkingInfo { get; set; }

        /// <summary>
        /// Specifies the number of processors on the host.
        /// </summary>
        /// <value>Specifies the number of processors on the host.</value>
        [DataMember(Name="numProcessors", EmitDefaultValue=true)]
        public long? NumProcessors { get; set; }

        /// <summary>
        /// Specifies a human readable name of the OS of the Protection Source.
        /// </summary>
        /// <value>Specifies a human readable name of the OS of the Protection Source.</value>
        [DataMember(Name="osName", EmitDefaultValue=true)]
        public string OsName { get; set; }

        /// <summary>
        /// Specifies cluster version for VCS host.
        /// </summary>
        /// <value>Specifies cluster version for VCS host.</value>
        [DataMember(Name="vcsVersion", EmitDefaultValue=true)]
        public string VcsVersion { get; set; }

        /// <summary>
        /// Array of Physical Volumes.  Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type.
        /// </summary>
        /// <value>Array of Physical Volumes.  Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type.</value>
        [DataMember(Name="volumes", EmitDefaultValue=true)]
        public List<PhysicalVolume> Volumes { get; set; }

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
            return this.Equals(input as PhysicalProtectionSource);
        }

        /// <summary>
        /// Returns true if PhysicalProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Agents == input.Agents ||
                    this.Agents != null &&
                    input.Agents != null &&
                    this.Agents.SequenceEqual(input.Agents)
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemorySizeBytes == input.MemorySizeBytes ||
                    (this.MemorySizeBytes != null &&
                    this.MemorySizeBytes.Equals(input.MemorySizeBytes))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkingInfo == input.NetworkingInfo ||
                    (this.NetworkingInfo != null &&
                    this.NetworkingInfo.Equals(input.NetworkingInfo))
                ) && 
                (
                    this.NumProcessors == input.NumProcessors ||
                    (this.NumProcessors != null &&
                    this.NumProcessors.Equals(input.NumProcessors))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.VcsVersion == input.VcsVersion ||
                    (this.VcsVersion != null &&
                    this.VcsVersion.Equals(input.VcsVersion))
                ) && 
                (
                    this.Volumes == input.Volumes ||
                    this.Volumes != null &&
                    input.Volumes != null &&
                    this.Volumes.SequenceEqual(input.Volumes)
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
                if (this.Agents != null)
                    hashCode = hashCode * 59 + this.Agents.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemorySizeBytes != null)
                    hashCode = hashCode * 59 + this.MemorySizeBytes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkingInfo != null)
                    hashCode = hashCode * 59 + this.NetworkingInfo.GetHashCode();
                if (this.NumProcessors != null)
                    hashCode = hashCode * 59 + this.NumProcessors.GetHashCode();
                if (this.OsName != null)
                    hashCode = hashCode * 59 + this.OsName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VcsVersion != null)
                    hashCode = hashCode * 59 + this.VcsVersion.GetHashCode();
                if (this.Volumes != null)
                    hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }

    }

}

