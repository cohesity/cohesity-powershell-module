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
    /// Specifies a VMware tag.
    /// </summary>
    [DataContract]
    public partial class TagAttribute :  IEquatable<TagAttribute>
    {
        /// <summary>
        /// Specifies the tag attribute type of GCP. Going forward, there will be an additional TagTypes for AWS as well. Specifies the type of the tag GCP entity refers to. &#39;kNetworkTag&#39; indicates a network tag present on instances. &#39;kLabel&#39; indicates a label (key-value pair) present on instances. &#39;kCustomMetadata&#39; indicates custom Metadata (key-value pair) present on instances.
        /// </summary>
        /// <value>Specifies the tag attribute type of GCP. Going forward, there will be an additional TagTypes for AWS as well. Specifies the type of the tag GCP entity refers to. &#39;kNetworkTag&#39; indicates a network tag present on instances. &#39;kLabel&#39; indicates a label (key-value pair) present on instances. &#39;kCustomMetadata&#39; indicates custom Metadata (key-value pair) present on instances.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GcpTagTypeEnum
        {
            /// <summary>
            /// Enum KNetworkTag for value: kNetworkTag
            /// </summary>
            [EnumMember(Value = "kNetworkTag")]
            KNetworkTag = 1,

            /// <summary>
            /// Enum KLabel for value: kLabel
            /// </summary>
            [EnumMember(Value = "kLabel")]
            KLabel = 2,

            /// <summary>
            /// Enum KCustomMetadata for value: kCustomMetadata
            /// </summary>
            [EnumMember(Value = "kCustomMetadata")]
            KCustomMetadata = 3

        }

        /// <summary>
        /// Specifies the tag attribute type of GCP. Going forward, there will be an additional TagTypes for AWS as well. Specifies the type of the tag GCP entity refers to. &#39;kNetworkTag&#39; indicates a network tag present on instances. &#39;kLabel&#39; indicates a label (key-value pair) present on instances. &#39;kCustomMetadata&#39; indicates custom Metadata (key-value pair) present on instances.
        /// </summary>
        /// <value>Specifies the tag attribute type of GCP. Going forward, there will be an additional TagTypes for AWS as well. Specifies the type of the tag GCP entity refers to. &#39;kNetworkTag&#39; indicates a network tag present on instances. &#39;kLabel&#39; indicates a label (key-value pair) present on instances. &#39;kCustomMetadata&#39; indicates custom Metadata (key-value pair) present on instances.</value>
        [DataMember(Name="gcpTagType", EmitDefaultValue=true)]
        public GcpTagTypeEnum? GcpTagType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagAttribute" /> class.
        /// </summary>
        /// <param name="gcpTagType">Specifies the tag attribute type of GCP. Going forward, there will be an additional TagTypes for AWS as well. Specifies the type of the tag GCP entity refers to. &#39;kNetworkTag&#39; indicates a network tag present on instances. &#39;kLabel&#39; indicates a label (key-value pair) present on instances. &#39;kCustomMetadata&#39; indicates custom Metadata (key-value pair) present on instances..</param>
        /// <param name="id">Specifies the Coheisty id of the VM tag..</param>
        /// <param name="name">Specifies the VMware name of the VM tag..</param>
        /// <param name="uuid">Specifies the VMware Universally Unique Identifier (UUID) of the VM tag..</param>
        public TagAttribute(GcpTagTypeEnum? gcpTagType = default(GcpTagTypeEnum?), long? id = default(long?), string name = default(string), string uuid = default(string))
        {
            this.GcpTagType = gcpTagType;
            this.Id = id;
            this.Name = name;
            this.Uuid = uuid;
            this.GcpTagType = gcpTagType;
            this.Id = id;
            this.Name = name;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the Coheisty id of the VM tag.
        /// </summary>
        /// <value>Specifies the Coheisty id of the VM tag.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the VMware name of the VM tag.
        /// </summary>
        /// <value>Specifies the VMware name of the VM tag.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the VMware Universally Unique Identifier (UUID) of the VM tag.
        /// </summary>
        /// <value>Specifies the VMware Universally Unique Identifier (UUID) of the VM tag.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

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
            return this.Equals(input as TagAttribute);
        }

        /// <summary>
        /// Returns true if TagAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of TagAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GcpTagType == input.GcpTagType ||
                    this.GcpTagType.Equals(input.GcpTagType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = hashCode * 59 + this.GcpTagType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

