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
    /// A logical volume is built on a tree where leaves are the slices of partitions (PartitionSlice) defined below and intermediate nodes are assembled by combining nodes in some mode (linear layout, striped, mirrored, RAID etc). A DeviceTree is a block device formed by combining one or more Devices using a combining strategy.
    /// </summary>
    [DataContract]
    public partial class DeviceTree :  IEquatable<DeviceTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTree" /> class.
        /// </summary>
        /// <param name="childVec">childVec.</param>
        /// <param name="deviceId">Internal device identifier of the device to be activated as a thin volume..</param>
        /// <param name="deviceLength">The length of this device. This should match the length which is computable based on children and combining strategy.  e.g. if there is only one partition slice in an LVM volume, &#39;length&#39; in the partition slice is equal to &#39;device_length&#39;..</param>
        /// <param name="stripeSize">In case data is striped, this represents the length of the stripe. The number of stripes is defined by the size of child_vec above..</param>
        /// <param name="thinPoolChunkSize">Chunk size. Only populated if device type is thin pool..</param>
        /// <param name="type">How to combine the children..</param>
        public DeviceTree(List<DeviceTreeChildDevice> childVec = default(List<DeviceTreeChildDevice>), long? deviceId = default(long?), long? deviceLength = default(long?), int? stripeSize = default(int?), long? thinPoolChunkSize = default(long?), int? type = default(int?))
        {
            this.ChildVec = childVec;
            this.DeviceId = deviceId;
            this.DeviceLength = deviceLength;
            this.StripeSize = stripeSize;
            this.ThinPoolChunkSize = thinPoolChunkSize;
            this.Type = type;
            this.ChildVec = childVec;
            this.DeviceId = deviceId;
            this.DeviceLength = deviceLength;
            this.StripeSize = stripeSize;
            this.ThinPoolChunkSize = thinPoolChunkSize;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ChildVec
        /// </summary>
        [DataMember(Name="childVec", EmitDefaultValue=true)]
        public List<DeviceTreeChildDevice> ChildVec { get; set; }

        /// <summary>
        /// Internal device identifier of the device to be activated as a thin volume.
        /// </summary>
        /// <value>Internal device identifier of the device to be activated as a thin volume.</value>
        [DataMember(Name="deviceId", EmitDefaultValue=true)]
        public long? DeviceId { get; set; }

        /// <summary>
        /// The length of this device. This should match the length which is computable based on children and combining strategy.  e.g. if there is only one partition slice in an LVM volume, &#39;length&#39; in the partition slice is equal to &#39;device_length&#39;.
        /// </summary>
        /// <value>The length of this device. This should match the length which is computable based on children and combining strategy.  e.g. if there is only one partition slice in an LVM volume, &#39;length&#39; in the partition slice is equal to &#39;device_length&#39;.</value>
        [DataMember(Name="deviceLength", EmitDefaultValue=true)]
        public long? DeviceLength { get; set; }

        /// <summary>
        /// In case data is striped, this represents the length of the stripe. The number of stripes is defined by the size of child_vec above.
        /// </summary>
        /// <value>In case data is striped, this represents the length of the stripe. The number of stripes is defined by the size of child_vec above.</value>
        [DataMember(Name="stripeSize", EmitDefaultValue=true)]
        public int? StripeSize { get; set; }

        /// <summary>
        /// Chunk size. Only populated if device type is thin pool.
        /// </summary>
        /// <value>Chunk size. Only populated if device type is thin pool.</value>
        [DataMember(Name="thinPoolChunkSize", EmitDefaultValue=true)]
        public long? ThinPoolChunkSize { get; set; }

        /// <summary>
        /// How to combine the children.
        /// </summary>
        /// <value>How to combine the children.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as DeviceTree);
        }

        /// <summary>
        /// Returns true if DeviceTree instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceTree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTree input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildVec == input.ChildVec ||
                    this.ChildVec != null &&
                    input.ChildVec != null &&
                    this.ChildVec.SequenceEqual(input.ChildVec)
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceLength == input.DeviceLength ||
                    (this.DeviceLength != null &&
                    this.DeviceLength.Equals(input.DeviceLength))
                ) && 
                (
                    this.StripeSize == input.StripeSize ||
                    (this.StripeSize != null &&
                    this.StripeSize.Equals(input.StripeSize))
                ) && 
                (
                    this.ThinPoolChunkSize == input.ThinPoolChunkSize ||
                    (this.ThinPoolChunkSize != null &&
                    this.ThinPoolChunkSize.Equals(input.ThinPoolChunkSize))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ChildVec != null)
                    hashCode = hashCode * 59 + this.ChildVec.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceLength != null)
                    hashCode = hashCode * 59 + this.DeviceLength.GetHashCode();
                if (this.StripeSize != null)
                    hashCode = hashCode * 59 + this.StripeSize.GetHashCode();
                if (this.ThinPoolChunkSize != null)
                    hashCode = hashCode * 59 + this.ThinPoolChunkSize.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

