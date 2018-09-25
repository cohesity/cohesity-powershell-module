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
    /// Specifies the unit of measure for the metric. O specifies a unit of space used such as free disk space. 1 specifies a Unix epoch Timestamp (in microseconds). 2 specifies a Unix epoch Timestamp (in milliseconds). 3 specifies a Unix epoch Timestamp (in seconds). 4 specifies a Unix epoch Timestamp (in minutes). 5 specifies a counter such as the read IO metric. 6 specifies the temperature in Centigrade. 7 specifies the temperature in Fahrenheit. 8 specifies revolutions per minute such as a CPU fan speed. 9 specifies a percentage such as CPU or memory usage.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProtoTimeSeriesDescriptorMetricUnit :  IEquatable<EntitySchemaProtoTimeSeriesDescriptorMetricUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProtoTimeSeriesDescriptorMetricUnit" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        public EntitySchemaProtoTimeSeriesDescriptorMetricUnit(int? type = default(int?))
        {
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as EntitySchemaProtoTimeSeriesDescriptorMetricUnit);
        }

        /// <summary>
        /// Returns true if EntitySchemaProtoTimeSeriesDescriptorMetricUnit instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProtoTimeSeriesDescriptorMetricUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProtoTimeSeriesDescriptorMetricUnit input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

