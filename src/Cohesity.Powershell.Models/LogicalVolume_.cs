// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace Cohesity.Models
{
    /// <summary>
    /// Specify attributes for a kLMV (Linux) or kLDM (Windows) filesystem. This field is set only for kLVM and kLDM volume types.
    /// </summary>
    [DataContract]
    public partial class LogicalVolume_ :  IEquatable<LogicalVolume_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalVolume_" /> class.
        /// </summary>
        /// <param name="deviceRootNode">Specifies the device tree defining how to combine partitions to create this logical volume..</param>
        /// <param name="groupName">Specifies the group name of the logical volume..</param>
        /// <param name="groupUuid">Specifies the group uuid of the logical volume..</param>
        /// <param name="name">Specifies the name of the logical volume..</param>
        /// <param name="uuid">Specifies the uuid of the logical volume..</param>
        public LogicalVolume_(DeviceTree deviceRootNode = default(DeviceTree), string groupName = default(string), string groupUuid = default(string), string name = default(string), string uuid = default(string))
        {
            this.DeviceRootNode = deviceRootNode;
            this.GroupName = groupName;
            this.GroupUuid = groupUuid;
            this.Name = name;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the device tree defining how to combine partitions to create this logical volume.
        /// </summary>
        /// <value>Specifies the device tree defining how to combine partitions to create this logical volume.</value>
        [DataMember(Name="deviceRootNode", EmitDefaultValue=false)]
        public DeviceTree DeviceRootNode { get; set; }

        /// <summary>
        /// Specifies the group name of the logical volume.
        /// </summary>
        /// <value>Specifies the group name of the logical volume.</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Specifies the group uuid of the logical volume.
        /// </summary>
        /// <value>Specifies the group uuid of the logical volume.</value>
        [DataMember(Name="groupUuid", EmitDefaultValue=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// Specifies the name of the logical volume.
        /// </summary>
        /// <value>Specifies the name of the logical volume.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the uuid of the logical volume.
        /// </summary>
        /// <value>Specifies the uuid of the logical volume.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

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
            return this.Equals(input as LogicalVolume_);
        }

        /// <summary>
        /// Returns true if LogicalVolume_ instances are equal
        /// </summary>
        /// <param name="input">Instance of LogicalVolume_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogicalVolume_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceRootNode == input.DeviceRootNode ||
                    (this.DeviceRootNode != null &&
                    this.DeviceRootNode.Equals(input.DeviceRootNode))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.GroupUuid == input.GroupUuid ||
                    (this.GroupUuid != null &&
                    this.GroupUuid.Equals(input.GroupUuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.DeviceRootNode != null)
                    hashCode = hashCode * 59 + this.DeviceRootNode.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupUuid != null)
                    hashCode = hashCode * 59 + this.GroupUuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

