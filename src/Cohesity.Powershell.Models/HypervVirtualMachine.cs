// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a VirtualMachine Object in HyperV environment.
    /// </summary>
    [DataContract]
    public partial class HypervVirtualMachine :  IEquatable<HypervVirtualMachine>
    {
        /// <summary>
        /// Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM.
        /// </summary>
        /// <value>Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmBackupStatusEnum
        {
            
            /// <summary>
            /// Enum KSupported for value: kSupported
            /// </summary>
            [EnumMember(Value = "kSupported")]
            KSupported = 1,
            
            /// <summary>
            /// Enum KUnsupportedConfig for value: kUnsupportedConfig
            /// </summary>
            [EnumMember(Value = "kUnsupportedConfig")]
            KUnsupportedConfig = 2,
            
            /// <summary>
            /// Enum KMissing for value: kMissing
            /// </summary>
            [EnumMember(Value = "kMissing")]
            KMissing = 3
        }

        /// <summary>
        /// Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM.
        /// </summary>
        /// <value>Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM.</value>
        [DataMember(Name="vmBackupStatus", EmitDefaultValue=false)]
        public VmBackupStatusEnum? VmBackupStatus { get; set; }
        /// <summary>
        /// Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.
        /// </summary>
        /// <value>Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmBackupTypeEnum
        {
            
            /// <summary>
            /// Enum KRctBackup for value: kRctBackup
            /// </summary>
            [EnumMember(Value = "kRctBackup")]
            KRctBackup = 1,
            
            /// <summary>
            /// Enum KVssBackup for value: kVssBackup
            /// </summary>
            [EnumMember(Value = "kVssBackup")]
            KVssBackup = 2
        }

        /// <summary>
        /// Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.
        /// </summary>
        /// <value>Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS.</value>
        [DataMember(Name="vmBackupType", EmitDefaultValue=false)]
        public VmBackupTypeEnum? VmBackupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HypervVirtualMachine" /> class.
        /// </summary>
        /// <param name="isHighlyAvailable">Specifies whether the VM is Highly Availabile or not..</param>
        /// <param name="version">Specifies the version of the VM. For example, 8.0, 5.0 etc..</param>
        /// <param name="vmBackupStatus">Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM..</param>
        /// <param name="vmBackupType">Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS..</param>
        public HypervVirtualMachine(bool? isHighlyAvailable = default(bool?), string version = default(string), VmBackupStatusEnum? vmBackupStatus = default(VmBackupStatusEnum?), VmBackupTypeEnum? vmBackupType = default(VmBackupTypeEnum?))
        {
            this.IsHighlyAvailable = isHighlyAvailable;
            this.Version = version;
            this.VmBackupStatus = vmBackupStatus;
            this.VmBackupType = vmBackupType;
        }
        
        /// <summary>
        /// Specifies whether the VM is Highly Availabile or not.
        /// </summary>
        /// <value>Specifies whether the VM is Highly Availabile or not.</value>
        [DataMember(Name="isHighlyAvailable", EmitDefaultValue=false)]
        public bool? IsHighlyAvailable { get; set; }

        /// <summary>
        /// Specifies the version of the VM. For example, 8.0, 5.0 etc.
        /// </summary>
        /// <value>Specifies the version of the VM. For example, 8.0, 5.0 etc.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



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
            return this.Equals(input as HypervVirtualMachine);
        }

        /// <summary>
        /// Returns true if HypervVirtualMachine instances are equal
        /// </summary>
        /// <param name="input">Instance of HypervVirtualMachine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypervVirtualMachine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsHighlyAvailable == input.IsHighlyAvailable ||
                    (this.IsHighlyAvailable != null &&
                    this.IsHighlyAvailable.Equals(input.IsHighlyAvailable))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VmBackupStatus == input.VmBackupStatus ||
                    (this.VmBackupStatus != null &&
                    this.VmBackupStatus.Equals(input.VmBackupStatus))
                ) && 
                (
                    this.VmBackupType == input.VmBackupType ||
                    (this.VmBackupType != null &&
                    this.VmBackupType.Equals(input.VmBackupType))
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
                if (this.IsHighlyAvailable != null)
                    hashCode = hashCode * 59 + this.IsHighlyAvailable.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VmBackupStatus != null)
                    hashCode = hashCode * 59 + this.VmBackupStatus.GetHashCode();
                if (this.VmBackupType != null)
                    hashCode = hashCode * 59 + this.VmBackupType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

