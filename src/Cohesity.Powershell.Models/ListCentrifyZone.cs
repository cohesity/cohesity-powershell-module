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
    /// ListCentrifyZone
    /// </summary>
    [DataContract]
    public partial class ListCentrifyZone :  IEquatable<ListCentrifyZone>
    {
        /// <summary>
        /// Specifies the schema of this Centrify zone. The below list of schemas and their values are taken from the document Centrify Server Suite 2016 Windows API Programmer&#39;s Guide https://docs.centrify.com/en/css/suite2016/centrify-win-progguide.pdf &#39;kCentrifyDynamicSchema_1_0&#39; specifies dynamic schema, version 1.0. &#39;kCentrifyDynamicSchema_2_0&#39; specifies dynamic schema, version 2.0. &#39;kCentrifyDynamicSchema_3_0&#39; specifies dynamic schema, version 3.0. &#39;kCentrifyDynamicSchema_5_0&#39; specifies dynamic schema, version 5.0. &#39;kCentrifySfu_3_0&#39; specifies sfu schema, version 3.0. &#39;kCentrifySfu_3_0_V5&#39; specifies sfu schema, 3.0.5. &#39;kCentrifySfu_4_0&#39; specifies sfu schema, version 4.0. &#39;kCentrifyCdcRfc2307&#39; specifies cdcrfc2307 schema. &#39;kCentrifyCdcRfc2307_2&#39; specifies cdcrfc2307, version 2. &#39;kCentrifyCdcRfc2307_3&#39; specifies cdcrfc2307, version 3.
        /// </summary>
        /// <value>Specifies the schema of this Centrify zone. The below list of schemas and their values are taken from the document Centrify Server Suite 2016 Windows API Programmer&#39;s Guide https://docs.centrify.com/en/css/suite2016/centrify-win-progguide.pdf &#39;kCentrifyDynamicSchema_1_0&#39; specifies dynamic schema, version 1.0. &#39;kCentrifyDynamicSchema_2_0&#39; specifies dynamic schema, version 2.0. &#39;kCentrifyDynamicSchema_3_0&#39; specifies dynamic schema, version 3.0. &#39;kCentrifyDynamicSchema_5_0&#39; specifies dynamic schema, version 5.0. &#39;kCentrifySfu_3_0&#39; specifies sfu schema, version 3.0. &#39;kCentrifySfu_3_0_V5&#39; specifies sfu schema, 3.0.5. &#39;kCentrifySfu_4_0&#39; specifies sfu schema, version 4.0. &#39;kCentrifyCdcRfc2307&#39; specifies cdcrfc2307 schema. &#39;kCentrifyCdcRfc2307_2&#39; specifies cdcrfc2307, version 2. &#39;kCentrifyCdcRfc2307_3&#39; specifies cdcrfc2307, version 3.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CentrifySchemaEnum
        {
            
            /// <summary>
            /// Enum KCentrifyDynamicSchema10 for value: kCentrifyDynamicSchema_1_0
            /// </summary>
            [EnumMember(Value = "kCentrifyDynamicSchema_1_0")]
            KCentrifyDynamicSchema10 = 1,
            
            /// <summary>
            /// Enum KCentrifyDynamicSchema20 for value: kCentrifyDynamicSchema_2_0
            /// </summary>
            [EnumMember(Value = "kCentrifyDynamicSchema_2_0")]
            KCentrifyDynamicSchema20 = 2,
            
            /// <summary>
            /// Enum KCentrifySfu30 for value: kCentrifySfu_3_0
            /// </summary>
            [EnumMember(Value = "kCentrifySfu_3_0")]
            KCentrifySfu30 = 3,
            
            /// <summary>
            /// Enum KCentrifySfu40 for value: kCentrifySfu_4_0
            /// </summary>
            [EnumMember(Value = "kCentrifySfu_4_0")]
            KCentrifySfu40 = 4,
            
            /// <summary>
            /// Enum KCentrifyCdcRfc2307 for value: kCentrifyCdcRfc2307
            /// </summary>
            [EnumMember(Value = "kCentrifyCdcRfc2307")]
            KCentrifyCdcRfc2307 = 5,
            
            /// <summary>
            /// Enum KCentrifyDynamicSchema30 for value: kCentrifyDynamicSchema_3_0
            /// </summary>
            [EnumMember(Value = "kCentrifyDynamicSchema_3_0")]
            KCentrifyDynamicSchema30 = 6,
            
            /// <summary>
            /// Enum KCentrifyCdcRfc23072 for value: kCentrifyCdcRfc2307_2
            /// </summary>
            [EnumMember(Value = "kCentrifyCdcRfc2307_2")]
            KCentrifyCdcRfc23072 = 7,
            
            /// <summary>
            /// Enum KCentrifyDynamicSchema50 for value: kCentrifyDynamicSchema_5_0
            /// </summary>
            [EnumMember(Value = "kCentrifyDynamicSchema_5_0")]
            KCentrifyDynamicSchema50 = 8,
            
            /// <summary>
            /// Enum KCentrifyCdcRfc23073 for value: kCentrifyCdcRfc2307_3
            /// </summary>
            [EnumMember(Value = "kCentrifyCdcRfc2307_3")]
            KCentrifyCdcRfc23073 = 9,
            
            /// <summary>
            /// Enum KCentrifySfu30V5 for value: kCentrifySfu_3_0_V5
            /// </summary>
            [EnumMember(Value = "kCentrifySfu_3_0_V5")]
            KCentrifySfu30V5 = 10
        }

        /// <summary>
        /// Specifies the schema of this Centrify zone. The below list of schemas and their values are taken from the document Centrify Server Suite 2016 Windows API Programmer&#39;s Guide https://docs.centrify.com/en/css/suite2016/centrify-win-progguide.pdf &#39;kCentrifyDynamicSchema_1_0&#39; specifies dynamic schema, version 1.0. &#39;kCentrifyDynamicSchema_2_0&#39; specifies dynamic schema, version 2.0. &#39;kCentrifyDynamicSchema_3_0&#39; specifies dynamic schema, version 3.0. &#39;kCentrifyDynamicSchema_5_0&#39; specifies dynamic schema, version 5.0. &#39;kCentrifySfu_3_0&#39; specifies sfu schema, version 3.0. &#39;kCentrifySfu_3_0_V5&#39; specifies sfu schema, 3.0.5. &#39;kCentrifySfu_4_0&#39; specifies sfu schema, version 4.0. &#39;kCentrifyCdcRfc2307&#39; specifies cdcrfc2307 schema. &#39;kCentrifyCdcRfc2307_2&#39; specifies cdcrfc2307, version 2. &#39;kCentrifyCdcRfc2307_3&#39; specifies cdcrfc2307, version 3.
        /// </summary>
        /// <value>Specifies the schema of this Centrify zone. The below list of schemas and their values are taken from the document Centrify Server Suite 2016 Windows API Programmer&#39;s Guide https://docs.centrify.com/en/css/suite2016/centrify-win-progguide.pdf &#39;kCentrifyDynamicSchema_1_0&#39; specifies dynamic schema, version 1.0. &#39;kCentrifyDynamicSchema_2_0&#39; specifies dynamic schema, version 2.0. &#39;kCentrifyDynamicSchema_3_0&#39; specifies dynamic schema, version 3.0. &#39;kCentrifyDynamicSchema_5_0&#39; specifies dynamic schema, version 5.0. &#39;kCentrifySfu_3_0&#39; specifies sfu schema, version 3.0. &#39;kCentrifySfu_3_0_V5&#39; specifies sfu schema, 3.0.5. &#39;kCentrifySfu_4_0&#39; specifies sfu schema, version 4.0. &#39;kCentrifyCdcRfc2307&#39; specifies cdcrfc2307 schema. &#39;kCentrifyCdcRfc2307_2&#39; specifies cdcrfc2307, version 2. &#39;kCentrifyCdcRfc2307_3&#39; specifies cdcrfc2307, version 3.</value>
        [DataMember(Name="centrifySchema", EmitDefaultValue=false)]
        public CentrifySchemaEnum? CentrifySchema { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCentrifyZone" /> class.
        /// </summary>
        /// <param name="centrifySchema">Specifies the schema of this Centrify zone. The below list of schemas and their values are taken from the document Centrify Server Suite 2016 Windows API Programmer&#39;s Guide https://docs.centrify.com/en/css/suite2016/centrify-win-progguide.pdf &#39;kCentrifyDynamicSchema_1_0&#39; specifies dynamic schema, version 1.0. &#39;kCentrifyDynamicSchema_2_0&#39; specifies dynamic schema, version 2.0. &#39;kCentrifyDynamicSchema_3_0&#39; specifies dynamic schema, version 3.0. &#39;kCentrifyDynamicSchema_5_0&#39; specifies dynamic schema, version 5.0. &#39;kCentrifySfu_3_0&#39; specifies sfu schema, version 3.0. &#39;kCentrifySfu_3_0_V5&#39; specifies sfu schema, 3.0.5. &#39;kCentrifySfu_4_0&#39; specifies sfu schema, version 4.0. &#39;kCentrifyCdcRfc2307&#39; specifies cdcrfc2307 schema. &#39;kCentrifyCdcRfc2307_2&#39; specifies cdcrfc2307, version 2. &#39;kCentrifyCdcRfc2307_3&#39; specifies cdcrfc2307, version 3..</param>
        /// <param name="description">Specifies a description of the Centrify zone..</param>
        /// <param name="distinguishedName">Specifies the distinguished name of the Centrify zone..</param>
        /// <param name="zoneName">Specifies the zone name..</param>
        public ListCentrifyZone(CentrifySchemaEnum? centrifySchema = default(CentrifySchemaEnum?), string description = default(string), string distinguishedName = default(string), string zoneName = default(string))
        {
            this.CentrifySchema = centrifySchema;
            this.Description = description;
            this.DistinguishedName = distinguishedName;
            this.ZoneName = zoneName;
        }
        

        /// <summary>
        /// Specifies a description of the Centrify zone.
        /// </summary>
        /// <value>Specifies a description of the Centrify zone.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the distinguished name of the Centrify zone.
        /// </summary>
        /// <value>Specifies the distinguished name of the Centrify zone.</value>
        [DataMember(Name="distinguishedName", EmitDefaultValue=false)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Specifies the zone name.
        /// </summary>
        /// <value>Specifies the zone name.</value>
        [DataMember(Name="zoneName", EmitDefaultValue=false)]
        public string ZoneName { get; set; }

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
            return this.Equals(input as ListCentrifyZone);
        }

        /// <summary>
        /// Returns true if ListCentrifyZone instances are equal
        /// </summary>
        /// <param name="input">Instance of ListCentrifyZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCentrifyZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CentrifySchema == input.CentrifySchema ||
                    (this.CentrifySchema != null &&
                    this.CentrifySchema.Equals(input.CentrifySchema))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DistinguishedName == input.DistinguishedName ||
                    (this.DistinguishedName != null &&
                    this.DistinguishedName.Equals(input.DistinguishedName))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
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
                if (this.CentrifySchema != null)
                    hashCode = hashCode * 59 + this.CentrifySchema.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DistinguishedName != null)
                    hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

