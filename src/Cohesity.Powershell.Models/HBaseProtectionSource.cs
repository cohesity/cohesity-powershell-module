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
    /// Specifies an Object representing HBase.
    /// </summary>
    [DataContract]
    public partial class HBaseProtectionSource :  IEquatable<HBaseProtectionSource>
    {
        /// <summary>
        /// Specifies the type of the managed Object in HBase Protection Source. Specifies the type of an HBase source entity. &#39;kCluster&#39; indicates a HBase cluster distributed over several physical nodes. &#39;kNamespace&#39; indicates a Namespace in the HBase environment. &#39;kTable&#39; indicates a Table in the HBase environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in HBase Protection Source. Specifies the type of an HBase source entity. &#39;kCluster&#39; indicates a HBase cluster distributed over several physical nodes. &#39;kNamespace&#39; indicates a Namespace in the HBase environment. &#39;kTable&#39; indicates a Table in the HBase environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KNamespace for value: kNamespace
            /// </summary>
            [EnumMember(Value = "kNamespace")]
            KNamespace = 2,

            /// <summary>
            /// Enum KTable for value: kTable
            /// </summary>
            [EnumMember(Value = "kTable")]
            KTable = 3

        }

        /// <summary>
        /// Specifies the type of the managed Object in HBase Protection Source. Specifies the type of an HBase source entity. &#39;kCluster&#39; indicates a HBase cluster distributed over several physical nodes. &#39;kNamespace&#39; indicates a Namespace in the HBase environment. &#39;kTable&#39; indicates a Table in the HBase environment.
        /// </summary>
        /// <value>Specifies the type of the managed Object in HBase Protection Source. Specifies the type of an HBase source entity. &#39;kCluster&#39; indicates a HBase cluster distributed over several physical nodes. &#39;kNamespace&#39; indicates a Namespace in the HBase environment. &#39;kTable&#39; indicates a Table in the HBase environment.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HBaseProtectionSource" /> class.
        /// </summary>
        /// <param name="name">Specifies the instance name of the HBase entity..</param>
        /// <param name="tableInfo">tableInfo.</param>
        /// <param name="type">Specifies the type of the managed Object in HBase Protection Source. Specifies the type of an HBase source entity. &#39;kCluster&#39; indicates a HBase cluster distributed over several physical nodes. &#39;kNamespace&#39; indicates a Namespace in the HBase environment. &#39;kTable&#39; indicates a Table in the HBase environment..</param>
        /// <param name="uuid">Specifies the UUID for the HBase entity..</param>
        public HBaseProtectionSource(string name = default(string), HBaseTable tableInfo = default(HBaseTable), TypeEnum? type = default(TypeEnum?), string uuid = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.Uuid = uuid;
            this.Name = name;
            this.TableInfo = tableInfo;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the instance name of the HBase entity.
        /// </summary>
        /// <value>Specifies the instance name of the HBase entity.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TableInfo
        /// </summary>
        [DataMember(Name="tableInfo", EmitDefaultValue=false)]
        public HBaseTable TableInfo { get; set; }

        /// <summary>
        /// Specifies the UUID for the HBase entity.
        /// </summary>
        /// <value>Specifies the UUID for the HBase entity.</value>
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
            return this.Equals(input as HBaseProtectionSource);
        }

        /// <summary>
        /// Returns true if HBaseProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of HBaseProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HBaseProtectionSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TableInfo == input.TableInfo ||
                    (this.TableInfo != null &&
                    this.TableInfo.Equals(input.TableInfo))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TableInfo != null)
                    hashCode = hashCode * 59 + this.TableInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

