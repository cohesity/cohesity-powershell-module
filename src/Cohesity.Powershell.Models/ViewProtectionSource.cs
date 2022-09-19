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
    /// Specifies a Protection Source in a View environment.
    /// </summary>
    [DataContract]
    public partial class ViewProtectionSource :  IEquatable<ViewProtectionSource>
    {
        /// <summary>
        /// Specifies the type of managed Object in a View Protection Source environment. Examples of View Objects include &#39;kViewBox&#39; or &#39;kView&#39;. &#39;kViewBox&#39; indicates Storage Domain as a Protection Source type. &#39;kView&#39; indicates View as a Protection Source type.
        /// </summary>
        /// <value>Specifies the type of managed Object in a View Protection Source environment. Examples of View Objects include &#39;kViewBox&#39; or &#39;kView&#39;. &#39;kViewBox&#39; indicates Storage Domain as a Protection Source type. &#39;kView&#39; indicates View as a Protection Source type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KViewBox for value: kViewBox
            /// </summary>
            [EnumMember(Value = "kViewBox")]
            KViewBox = 1,

            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 2

        }

        /// <summary>
        /// Specifies the type of managed Object in a View Protection Source environment. Examples of View Objects include &#39;kViewBox&#39; or &#39;kView&#39;. &#39;kViewBox&#39; indicates Storage Domain as a Protection Source type. &#39;kView&#39; indicates View as a Protection Source type.
        /// </summary>
        /// <value>Specifies the type of managed Object in a View Protection Source environment. Examples of View Objects include &#39;kViewBox&#39; or &#39;kView&#39;. &#39;kViewBox&#39; indicates Storage Domain as a Protection Source type. &#39;kView&#39; indicates View as a Protection Source type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProtectionSource" /> class.
        /// </summary>
        /// <param name="id">Specifies a unique id of a Protection Source for a View. The id is unique across Cohesity Clusters..</param>
        /// <param name="name">Specifies a human readable name of the Protection Source of a View..</param>
        /// <param name="type">Specifies the type of managed Object in a View Protection Source environment. Examples of View Objects include &#39;kViewBox&#39; or &#39;kView&#39;. &#39;kViewBox&#39; indicates Storage Domain as a Protection Source type. &#39;kView&#39; indicates View as a Protection Source type..</param>
        public ViewProtectionSource(UniversalId id = default(UniversalId), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies a unique id of a Protection Source for a View. The id is unique across Cohesity Clusters.
        /// </summary>
        /// <value>Specifies a unique id of a Protection Source for a View. The id is unique across Cohesity Clusters.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public UniversalId Id { get; set; }

        /// <summary>
        /// Specifies a human readable name of the Protection Source of a View.
        /// </summary>
        /// <value>Specifies a human readable name of the Protection Source of a View.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as ViewProtectionSource);
        }

        /// <summary>
        /// Returns true if ViewProtectionSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProtectionSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProtectionSource input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

