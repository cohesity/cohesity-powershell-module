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
    /// Specifies a logical volume stored as a tree where the leaves are the blocks of partitions and intermediate nodes are assembled by combining nodes using one of the following modes: linear layout, striped, mirrored, RAID etc. A deviceTree is a block device formed by combining one or more Devices using a combining strategy.
    /// </summary>
    [DataContract]
    public partial class DeviceTree :  IEquatable<DeviceTree>
    {
        /// <summary>
        /// Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39;
        /// </summary>
        /// <value>Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CombineMethodEnum
        {
            
            /// <summary>
            /// Enum LINEAR for value: LINEAR
            /// </summary>
            [EnumMember(Value = "LINEAR")]
            LINEAR = 1,
            
            /// <summary>
            /// Enum STRIPE for value: STRIPE
            /// </summary>
            [EnumMember(Value = "STRIPE")]
            STRIPE = 2,
            
            /// <summary>
            /// Enum MIRROR for value: MIRROR
            /// </summary>
            [EnumMember(Value = "MIRROR")]
            MIRROR = 3,
            
            /// <summary>
            /// Enum RAID5 for value: RAID5
            /// </summary>
            [EnumMember(Value = "RAID5")]
            RAID5 = 4,
            
            /// <summary>
            /// Enum RAID6 for value: RAID6
            /// </summary>
            [EnumMember(Value = "RAID6")]
            RAID6 = 5,
            
            /// <summary>
            /// Enum ZERO for value: ZERO
            /// </summary>
            [EnumMember(Value = "ZERO")]
            ZERO = 6,
            
            /// <summary>
            /// Enum THIN for value: THIN
            /// </summary>
            [EnumMember(Value = "THIN")]
            THIN = 7,
            
            /// <summary>
            /// Enum THINPOOL for value: THINPOOL
            /// </summary>
            [EnumMember(Value = "THINPOOL")]
            THINPOOL = 8,
            
            /// <summary>
            /// Enum SNAPSHOT for value: SNAPSHOT
            /// </summary>
            [EnumMember(Value = "SNAPSHOT")]
            SNAPSHOT = 9,
            
            /// <summary>
            /// Enum CACHE for value: CACHE
            /// </summary>
            [EnumMember(Value = "CACHE")]
            CACHE = 10,
            
            /// <summary>
            /// Enum CACHEPOOL for value: CACHEPOOL
            /// </summary>
            [EnumMember(Value = "CACHEPOOL")]
            CACHEPOOL = 11
        }

        /// <summary>
        /// Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39;
        /// </summary>
        /// <value>Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39;</value>
        [DataMember(Name="combineMethod", EmitDefaultValue=false)]
        public CombineMethodEnum? CombineMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTree" /> class.
        /// </summary>
        /// <param name="combineMethod">Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39;.</param>
        /// <param name="deviceLength">Specifies the length of this device. This number should match the length that is calculated from the children and combining method..</param>
        /// <param name="deviceNodes">deviceNodes.</param>
        /// <param name="stripeSize">Specifies the size of the striped data if the data is striped..</param>
        public DeviceTree(CombineMethodEnum? combineMethod = default(CombineMethodEnum?), long? deviceLength = default(long?), List<DeviceNode> deviceNodes = default(List<DeviceNode>), int? stripeSize = default(int?))
        {
            this.CombineMethod = combineMethod;
            this.DeviceLength = deviceLength;
            this.DeviceNodes = deviceNodes;
            this.StripeSize = stripeSize;
        }
        

        /// <summary>
        /// Specifies the length of this device. This number should match the length that is calculated from the children and combining method.
        /// </summary>
        /// <value>Specifies the length of this device. This number should match the length that is calculated from the children and combining method.</value>
        [DataMember(Name="deviceLength", EmitDefaultValue=false)]
        public long? DeviceLength { get; set; }

        /// <summary>
        /// Gets or Sets DeviceNodes
        /// </summary>
        [DataMember(Name="deviceNodes", EmitDefaultValue=false)]
        public List<DeviceNode> DeviceNodes { get; set; }

        /// <summary>
        /// Specifies the size of the striped data if the data is striped.
        /// </summary>
        /// <value>Specifies the size of the striped data if the data is striped.</value>
        [DataMember(Name="stripeSize", EmitDefaultValue=false)]
        public int? StripeSize { get; set; }

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
                    this.CombineMethod == input.CombineMethod ||
                    (this.CombineMethod != null &&
                    this.CombineMethod.Equals(input.CombineMethod))
                ) && 
                (
                    this.DeviceLength == input.DeviceLength ||
                    (this.DeviceLength != null &&
                    this.DeviceLength.Equals(input.DeviceLength))
                ) && 
                (
                    this.DeviceNodes == input.DeviceNodes ||
                    this.DeviceNodes != null &&
                    this.DeviceNodes.SequenceEqual(input.DeviceNodes)
                ) && 
                (
                    this.StripeSize == input.StripeSize ||
                    (this.StripeSize != null &&
                    this.StripeSize.Equals(input.StripeSize))
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
                if (this.CombineMethod != null)
                    hashCode = hashCode * 59 + this.CombineMethod.GetHashCode();
                if (this.DeviceLength != null)
                    hashCode = hashCode * 59 + this.DeviceLength.GetHashCode();
                if (this.DeviceNodes != null)
                    hashCode = hashCode * 59 + this.DeviceNodes.GetHashCode();
                if (this.StripeSize != null)
                    hashCode = hashCode * 59 + this.StripeSize.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

